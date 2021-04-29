using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMState_Jumping : PlayerMState_InAir
{
    public override void EnterState()
    {
        base.EnterState();

        myStateMachine.ThePlayerPawn.PawnSprite.SpriteAnimator.SetBool("IsJumping", true);
    }

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
