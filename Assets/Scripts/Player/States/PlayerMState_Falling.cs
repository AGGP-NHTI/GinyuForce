using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMState_Falling : PlayerMState
{
    public override void TransitionState()
    {
        base.TransitionState();
        if(Mathf.Abs(myStateMachine.ThePlayerPawn.GetVelocity().y) < 0.001)
        {
            myStateMachine.ChangeMoveState<PlayerMState_Idle>();
        }
    }

    public override void PlayerJump(float jumpHeight)
    {
        base.PlayerJump(jumpHeight);
        myStateMachine.ChangeMoveState<PlayerMState_Jumping>();
    }
}
