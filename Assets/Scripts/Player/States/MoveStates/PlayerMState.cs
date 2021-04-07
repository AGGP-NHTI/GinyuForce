using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMState : StateType_Movement
{
    /// <summary>
    /// The state machine that this object is a part of.
    /// </summary>
    protected PlayerStateMachine myStateMachine = null;

    protected override void Awake()
    {
        myStateMachine = gameObject.GetComponent<PlayerStateMachine>();
        base.Awake();
    }

    /// <summary>
    /// Sets the velocity of the player's X-directional movement according to the input movement vector.
    /// </summary>
    /// <param name="movementVector"></param>
    public virtual void PlayerMovement(Vector2 movementVector)
    {
        myStateMachine.ThePlayerPawn.PlayerRB_SetVelocity(movementVector);
    }

    /// <summary>
    /// Adds upward-direction force to the player's rigidbody to simulate jumping.
    /// </summary>
    /// <param name="jumpHeight"></param>
    public virtual void PlayerJump(float jumpHeight)
    {
        myStateMachine.ThePlayerPawn.PlayerRB_SetVelocity(
            new Vector2(myStateMachine.ThePlayerPawn.GetVelocity().x, 0));

        myStateMachine.ThePlayerPawn.GetPlayerRB().AddForce(transform.up * jumpHeight * 50);
    }

    public override void PerformState()
    {
        base.PerformState();
        // This is where animation stuff would be done, preferably by calling another "DoAnimation()" or something.
    }
}
