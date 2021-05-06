using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAI_Bull : BossAI
{
    bool exampleCondition = false;
    
    /// <summary>
    /// Reference to Bull's controller, which will send information to Bull's pawn to take action.
    /// </summary>
    public BullController bull;

    bool pinchMode = false;
    bool attackCooldown = false;
    int currentAttack = 1;

    private void Awake()
    {
        // The AttackCycleFinish event is called whenever Bull finishes one of his Sing, Charge, or Jump attacks.
        // Here is an example of adding some command after Bull finishes his current attack pattern.
        if (bull.theBullPawn)
        {
            bull.theBullPawn.AttackCycleFinish += StartAttackCycle;
        }
        
    }

    private void Update()
    {
        if (bull.theBullPawn.CurrentHealth < bull.theBullPawn.GetActorMaxHealth() / 2)
        {
            pinchMode = true;
        }
        else
        {
            pinchMode = false;
        }
    }

    public void StartAttackCycle()
    {
        StartCoroutine(AttackCycle());
        bull.theBullPawn.AttackCycleFinish -= StartAttackCycle;
    }

    public virtual IEnumerator AttackCycle()
    {
        int attackChance;
        attackCooldown = true;

        if (pinchMode == true)
        {
            attackChance = Random.Range(1, 3);
        }
        else
        {
            attackChance = currentAttack;
        }

        if (bull.theBullPawn.OwnStateMachine.CurrentAttackState is BullAState_Idle)
        {
            if (attackChance == 1)
            {
                bull.DoAttack2(GameInstanceManager.Main.ThePlayer.Location);             
            }
            else if (attackChance == 2)
            {
                bull.DoAttack1(GameInstanceManager.Main.ThePlayer.Location);
            }
            else if (attackChance == 3)
            {
                bull.DoAttack3(GameInstanceManager.Main.ThePlayer.Location);
            }
        }
        yield return new WaitUntil (() => bull.theBullPawn.OwnStateMachine.CurrentAttackState is BullAState_Idle);
        attackCooldown = false;
        currentAttack++;
        if (currentAttack > 3)
        {
            currentAttack = 1;
        }
    }

    public void AttackPatternExample()
    {       
        // fulfill conditions here.
        if (exampleCondition)
        {
            if(bull.theBullPawn.OwnStateMachine.CurrentConditionState is BullCState_Stunned)
            {
                // This will execute if Bull's current Condition state is "stunned". (meaning he just finished a charge attack and hit a wall)
            }

            // Example of doing Bull's charge attack, with the player's current location as the target.
            bull.DoAttack1(GameInstanceManager.Main.ThePlayer.Location);
        }
    }
}
