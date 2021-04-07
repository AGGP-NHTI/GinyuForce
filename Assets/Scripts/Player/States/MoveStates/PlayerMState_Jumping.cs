using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMState_Jumping : PlayerMState
{
    public override void TransitionState()
    {
        base.TransitionState();
        if (myStateMachine.ThePlayerPawn.GetVelocity().y < -0.0001)
        {
            myStateMachine.ChangeMoveState<PlayerMStates_JumpFall>();
        }
    }

    public override void PlayerJump(float jumpHeight)
    {
        
    }
}
