using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCState_Invuln : PlayerCState
{
    float duration = 1.5f; // Default value of 1.5 seconds

    float flashInterval = 0.35f;
    float flashDuration = 0f;

    public override void EnterState()
    {
        base.EnterState();
        myStateMachine.ThePlayerPawn.DoesTakeDamage = false;
        duration = myStateMachine.ThePlayerPawn.InvulnDuration;
    }

    public override void PerformState()
    {
        base.PerformState();
        duration -= Time.deltaTime;
        flashDuration -= Time.deltaTime;

        if(flashDuration <= 0f)
        {
            //if()
        }
    }

    public override void TransitionState()
    {
        base.TransitionState();
        if (duration <= 0f)
        {
            myStateMachine.ChangeConditionState<PlayerCState_Alive>();
        }
    }
}
