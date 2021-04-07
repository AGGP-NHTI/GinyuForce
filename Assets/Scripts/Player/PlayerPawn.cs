using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerPawn : Pawn
{
    /// <summary>
    /// Protected variable that controls the player speed. TODO: Add public method for modifying this.
    /// </summary>
    [SerializeField]
    protected float movementSpeed = 2f;

    [SerializeField]
    protected float jumpHeight = 10f;

    /// <summary>
    /// The rigidbody component of the pawn.
    /// </summary>
    protected Rigidbody2D playerRB = null;

    public Rigidbody2D GetPlayerRB()
    {
        return playerRB;
    }

    public Vector2 GetVelocity()
    {
        return playerRB.velocity;
    }

    /// <summary>
    /// Sets the pawn's rigidbody velocity according to the input velocity vector2.
    /// </summary>
    /// <param name="desiredVelocity">Desired velocity as a vector2 value.</param>
    public void PlayerRB_SetVelocity(Vector2 desiredVelocity)
    {
        playerRB.velocity = desiredVelocity;
    }

    /// <summary>
    /// The current movement state of the player. This includes jumping/falling/running/etc.
    /// </summary>
    protected PlayerMState _currentMoveState = null;

    [SerializeField]
    protected PlayerStateMachine _playerStateMachine = null;

    /// <summary>
    /// Public interface that returns the player pawn's current movement state.
    /// </summary>
    /// <returns></returns>
    public PlayerMState GetCurrentMState()
    {
        return _currentMoveState;
    }

    protected override void Awake()
    {
        playerRB = gameObject.GetComponent<Rigidbody2D>();
        if (!playerRB)
        {
            // If the pawn has no rigidbody, add one. This is not intended behavior, as most pawns should have a rigidbody, with a few exceptions.
            playerRB = gameObject.AddComponent<Rigidbody2D>();
            LogMsg("No rigidbody assigned to player. Assign one in the scene menu for better results.");
        }
        if (!_playerStateMachine)
        {
            _playerStateMachine = gameObject.AddComponent<PlayerStateMachine>();
        }
    }

    public override void Attack(Vector2 directions)
    {
        base.Attack(directions);
    }

    /// <summary>
    /// Moves the pawn's RigidBody in accordance with the input parameter.
    /// </summary>
    /// <param name="movementValues">The pawn's velocity will be set to this Vector2 value.</param>
    public override void PawnMovement(Vector2 movementValues)
    {
        // This mods in the movement speed from the pawn
        Vector2 actualMovement = new Vector2(movementValues.x * movementSpeed, playerRB.velocity.y);

        _playerStateMachine.CurrentMoveState.PlayerMovement(actualMovement);
    }

    public virtual void PlayerPawnJump()
    {
        _playerStateMachine.CurrentMoveState.PlayerJump(jumpHeight);
    }
}
