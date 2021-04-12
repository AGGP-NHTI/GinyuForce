﻿using System.Collections;
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
