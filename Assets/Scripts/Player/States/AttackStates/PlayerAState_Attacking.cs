using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAState_Attacking : PlayerAState
{
    /// <summary>
    /// Temporary variable that matches the lifetime of the player damage hitbox. This will be replaced 
    /// by a frame integration once animations are implemented
    /// </summary>
    protected float maxDuration = 0.4f;
    private float counter = 0f;

    public override void Attack(Vector2 directionInfo)
    {
        
    }

    public override void PerformState()
    {
        base.PerformState();
        counter += Time.deltaTime;
    }

    public override void TransitionState()
    {
        base.TransitionState();
        if(counter >= maxDuration)
        {
            myStateMachine.ChangeAttackState<PlayerAState_Idle>();
        }
    }
}
