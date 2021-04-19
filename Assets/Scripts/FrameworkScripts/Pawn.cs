using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : Actor
{
    /// <summary>
    /// The controller that will provide directions to this pawn.
    /// </summary>
    protected Controller _controller = null;

    /// <summary>
    /// Returns the controller for this pawn.
    /// </summary>
    /// <returns></returns>
    public Controller GetController()
    {
        return _controller;
    }

    /// <summary>
    /// Private reference to this pawn's sprite.
    /// </summary>
    [SerializeField]
    protected PawnSpriteCont _pawnSprite = null;

    /// <summary>
    /// Public accessor to this pawn's sprite.
    /// </summary>
    public PawnSpriteCont PawnSprite
    {
        get { return _pawnSprite; }
    }

    protected Rigidbody2D pawnRB;

    public virtual Rigidbody2D GetPawnRB()
    {
        return pawnRB;
    }

    public virtual Vector2 GetVelocity()
    {
        return pawnRB.velocity;
    }

    protected bool facingRight = true;

    public virtual bool IsFacingRight()
    {
        return facingRight;
    }

    /// <summary>
    /// Sets the pawn's rigidbody velocity according to the input velocity vector2.
    /// </summary>
    /// <param name="desiredVelocity">Desired velocity as a vector2 value.</param>
    public virtual void PawnRB_SetVelocity(Vector2 desiredVelocity)
    {
        pawnRB.velocity = desiredVelocity;
    }

    protected virtual void Awake()
    {
        InitializeRB();
        LogMsg("Default initialization from Pawn " + ObjectName);
    }

    protected virtual void InitializeRB()
    {
        pawnRB = gameObject.GetComponent<Rigidbody2D>();
        if (!pawnRB)
        {
            // If the pawn has no rigidbody, add one. This is not intended behavior, as most pawns should have a rigidbody, with a few exceptions.
            pawnRB = gameObject.AddComponent<Rigidbody2D>();
            LogMsg("No rigidbody assigned to pawn at " + ObjectName + ". Assign one in the scene menu for better results.");
        }
    }

    /// <summary>
    /// Base attack method for the pawn.
    /// </summary>
    /// <param name="directions">Base input of Vector2 variable. This will be used differently for each pawn type.</param>
    public virtual void Attack(Vector2 directions)
    {
        LogMsg("Default attack from " + ObjectName + " in direction " + directions.x + "-" + directions.y);
    }

    /// <summary>
    /// Movement command for the pawn.
    /// </summary>
    /// <param name="movementValues">Vector2 value that controls the pawn's movement.</param>
    public virtual void PawnMovement(Vector2 movementValues)
    {
        LogMsg("Movement from " + ObjectName + " but it is a default pawn.");
    }
}
