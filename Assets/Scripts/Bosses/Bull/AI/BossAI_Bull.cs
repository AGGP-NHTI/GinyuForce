using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAI_Bull : BossAI
{ 
    /// <summary>
    /// Reference to Bull's controller, which will send information to Bull's pawn to take action.
    /// </summary>
    public BullController bull;

    bool pinchMode = false;

    int currentAttack = 0;

    private void Awake()
    {
        bull.theBullPawn.AttackCycleFinish += StartAttackCycle;
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
        if (!GameInstanceManager.Main.IsGameOver() && bull.theBullPawn.CurrentHealth >= 1f)
        {
            int attackChance;
            //attackCooldown = true;

            if (pinchMode == true)
            {
                attackChance = Random.Range(1, 4);
            }
            else
            {
                //LogMsg("Stage 0");
                attackChance = currentAttack;
            }

            if (bull.theBullPawn.OwnStateMachine.CurrentAttackState is BullAState_Idle && bull.theBullPawn.OwnStateMachine.CurrentConditionState is BullCState_Alive)
            {
                //LogMsg("Stage 1");
                if (attackChance == 1)
                {
                    //LogMsg("Stage 2");
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

            yield return new WaitUntil(() => bull.theBullPawn.OwnStateMachine.CurrentAttackState is BullAState_Idle && bull.theBullPawn.OwnStateMachine.CurrentConditionState is BullCState_Alive);
            //attackCooldown = false;
            currentAttack++;

            //LogMsg("Stage 3");

            if (currentAttack > 3)
            {
                currentAttack = 1;
            }

            StartCoroutine(AttackCooldown());
        }       
    }

    public IEnumerator AttackCooldown()
    {
        yield return new WaitForSeconds(Random.Range(1f,1.8f));

        StartCoroutine(AttackCycle());
    }
}
