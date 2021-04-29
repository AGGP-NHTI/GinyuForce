using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMState_Idle : PlayerMState_OnGround
{
    public override void EnterState()
    {
        base.EnterState();
        myStateMachine.ThePlayerPawn.PawnSprite.SpriteAnimator.SetBool("IsRunning", false);
    }

    public override void TransitionState()
    {
        base.TransitionState();
        if (myStateMachine.ThePlayerPawn.GetVelocity().y < -0.0001)
        {
            myStateMachine.ChangeMoveState<PlayerMState_Falling>();
        }
    }

    public override void PlayerMovement(Vector2 movementVector)
    {
        base.PlayerMovement(movementVector);
        if(movementVector.x != 0)
        {
            myStateMachine.ChangeMoveState<PlayerMState_Running>();
        }
    }

    public override void PlayerJump(float jumpHeight)
    {
        base.PlayerJump(jumpHeight);
        myStateMachine.ChangeMoveState<PlayerMState_Jumping>();
    }
}
