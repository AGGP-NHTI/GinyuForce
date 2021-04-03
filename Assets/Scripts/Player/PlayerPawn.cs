using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPawn : Pawn
{
    /// <summary>
    /// Protected variable that controls the player speed. TODO: Add public method for modifying this.
    /// </summary>
    [SerializeField]
    protected float movementSpeed = 2f;

    /// <summary>
    /// The rigidbody component of the pawn.
    /// </summary>
    protected Rigidbody2D playerRB = null;

    protected override void Awake()
    {
        playerRB = gameObject.GetComponent<Rigidbody2D>();
        if (!playerRB)
        {
            /// If the pawn has no rigidbody, add one. This is not intended behavior, as most pawns should have a rigidbody, with a few exceptions.
            playerRB = gameObject.AddComponent<Rigidbody2D>();
            LogMsg("No rigidbody assigned to player. Assign one in the scene menu for better results.");
        }
    }

    /// <summary>
    /// Moves the pawn's RigidBody in accordance with the input parameter.
    /// </summary>
    /// <param name="movementValues">The pawn's velocity will be set to this Vector2 value.</param>
    public override void PawnMovement(Vector2 movementValues)
    {
        // This mods in the movement speed from the pawn
        Vector2 actualMovement = new Vector2(movementValues.x * movementSpeed, movementValues.y);

        playerRB.velocity = actualMovement;
    }
}
