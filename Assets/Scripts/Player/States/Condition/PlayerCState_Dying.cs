using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCState_Dying : PlayerCState
{
    /// <summary>
    /// Temporary variable that will be replaced by the duration of the death animation
    /// </summary>
    protected float deathTimer = 4f;

    public override void EnterState()
    {
        base.EnterState();
        PlayerInputPoller.Self.DisablePlayerInput();
        myStateMachine.ThePlayerPawn.DoesTakeDamage = false;

        myStateMachine.ThePlayerPawn.PlayerAudioController.PlayerSFX.clip = myStateMachine.ThePlayerPawn.PlayerAudioController.PlayerClips.DeathClip;
        myStateMachine.ThePlayerPawn.PlayerAudioController.PlayerSFX.Play();

        myStateMachine.ThePlayerPawn.PawnSprite.SpriteAnimator.Play("Hurt");

        myStateMachine.ThePlayerPawn.PawnRB_SetVelocity(Vector2.zero);

        myStateMachine.ThePlayerPawn.GetPawnRB().AddForce(transform.up * 600);

        myStateMachine.ThePlayerPawn.GetComponentInChildren<ActorPhysicsBox>().gameObject.SetActive(false);
    }

    public override void PerformState()
    {
        base.PerformState();
        // Do death animation stuff here maybe?

        deathTimer -= Time.deltaTime;
    }

    public override void TransitionState()
    {
        base.TransitionState();
        // Once the player death animation is done, go to dead state.
        if(deathTimer <= 0)
        {
            myStateMachine.ChangeConditionState<PlayerCState_Dead>();
        }
    }

    public override void ExitState()
    {
        base.ExitState();
        // Cleanup
    }
}
