using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : Actor
{
    /// <summary>
    /// The controller that will provide directions to this pawn.
    /// </summary>
    protected Controller _controller = null;

    public Controller GetController()
    {
        return _controller;
    }

    protected virtual void Awake()
    {
        LogMsg("Default initialization from Pawn " + ObjectName);
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
