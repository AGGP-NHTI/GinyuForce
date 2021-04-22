using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullAState_BodySlam : BullAState
{
    public override void EnterState()
    {
        base.EnterState();

        myStateMachine.TheBullPawn.GetPawnRB().AddForce(Vector2.down * 10f);
    }

    public override void TransitionState()
    {
        base.TransitionState();

        if (myStateMachine.TheBullPawn.GetVelocity().y < 0.001f)
        {
            myStateMachine.ChangeConditionState<BullCState_Faceplant>();
        }
    }
}
