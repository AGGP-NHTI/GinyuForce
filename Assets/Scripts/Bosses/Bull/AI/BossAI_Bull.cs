using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAI_Bull : BossAI
{
    bool exampleCondition = false;
    
    /// <summary>
    /// Reference to Bull's controller, which will send information to Bull's pawn to take action.
    /// </summary>
    protected BullController bull;

    private void Awake()
    {
        // The AttackCycleFinish event is called whenever Bull finishes one of his Sing, Charge, or Jump attacks.
        // Here is an example of adding some command after Bull finishes his current attack pattern.
        bull.theBullPawn.AttackCycleFinish += AttackPatternExample;
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
