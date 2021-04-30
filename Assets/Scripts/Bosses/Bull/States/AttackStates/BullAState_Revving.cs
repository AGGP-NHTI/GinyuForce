using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullAState_Revving : BullAState
{
    private float currentRevTime = 0f;

    public override void EnterState()
    {
        base.EnterState();

        myStateMachine.TheBullPawn.PawnSprite.SpriteAnimator.SetBool("IsRevving", true);
    }

    public override void PerformState()
    {
        base.PerformState();

        currentRevTime += Time.deltaTime;
    }

    public override void TransitionState()
    {
        base.TransitionState();

        if(currentRevTime >= myStateMachine.TheBullPawn.revvTime)
        {
            myStateMachine.ChangeAttackState<BullAState_Charging>();
        }
    }

    public override void ExitState()
    {
        base.ExitState();

        myStateMachine.TheBullPawn.PawnSprite.SpriteAnimator.SetBool("IsRevving", false);
    }
}
