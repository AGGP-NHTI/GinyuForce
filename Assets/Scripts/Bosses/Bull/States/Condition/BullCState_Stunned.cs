using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullCState_Stunned : BullCState
{
    private float stunTime = 0f;

    public override void EnterState()
    {
        base.EnterState();

        myStateMachine.TheBullPawn.PawnSprite.SpriteAnimator.SetBool("IsStunned", true);

        myStateMachine.TheBullPawn.BullAudioController.BullSFX.clip = myStateMachine.TheBullPawn.BullAudioController.BullClips.WallCrashClip;
        myStateMachine.TheBullPawn.BullAudioController.BullSFX.Play();

        myStateMachine.TheBullPawn.PawnMovement(Vector2.zero);

        myStateMachine.ChangeAttackState<BullAState_Idle>();

        Vector2 knockback = new Vector2(myStateMachine.TheBullPawn.stunLength, myStateMachine.TheBullPawn.stunHeight);

        if (myStateMachine.TheBullPawn.IsFacingRight())
        {
            knockback.x *= -1f;
        }

        myStateMachine.TheBullPawn.PawnRB_SetVelocity(knockback);
    }

    public override void PerformState()
    {
        base.PerformState();

        stunTime += Time.deltaTime;
    }

    public override void TransitionState()
    {
        base.TransitionState();

        if(stunTime >= myStateMachine.TheBullPawn.stunCooldown)
        {
            myStateMachine.ChangeConditionState<BullCState_Alive>();
        }
    }

    public override void ExitState()
    {
        base.ExitState();

        myStateMachine.TheBullPawn.PawnSprite.SpriteAnimator.SetBool("IsStunned", false);
    }
}
