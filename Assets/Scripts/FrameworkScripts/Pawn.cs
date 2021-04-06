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

    public virtual void PawnMovement(Vector2 movementValues)
    {
        LogMsg("Movement from " + ObjectName + " but it is a default pawn.");
    }
}
