using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Special child class of the Falling state that is only entered after jumping. This one simply prevents the player from jumping again.
/// </summary>
public class PlayerMStates_JumpFall : PlayerMState_Falling
{
    public override void EnterState()
    {
        base.EnterState();

        myStateMachine.ThePlayerPawn.PawnSprite.SpriteAnimator.SetBool("IsJumping", false);

        myStateMachine.ThePlayerPawn.PawnSprite.SpriteAnimator.SetBool("IsFalling", true);
    }

    public override void PlayerJump(float jumpHeight)
    {
        
    }

    public override void ExitState()
    {
        base.ExitState();

        myStateMachine.ThePlayerPawn.PawnSprite.SpriteAnimator.SetBool("IsFalling", false);
    }
}
