using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullController : AIController
{
    [SerializeField]
    protected BullPawn Bull = null;

    public BullPawn theBullPawn
    {
        get { return Bull; }
    }

    protected override void Awake()
    {
        _ownType = ControllerType.AI;

        ControlPawn(_controlledPawn);

        if(_controlledPawn is BullPawn)
        {
            Bull = (BullPawn)_controlledPawn;
        }
        else
        {
            LogMsg("BULL CONTROLLER DOES NOT HAVE BULL PAWN ATTACHED. THIS IS AN ERROR.");
        }
    }

    /// <summary>
    /// Bull's Charging attack. Needs a vector2 for the player's position.
    /// </summary>
    /// <param name="directionalValues">Should be the player's position.</param>
    /// <param name="floatValue1"></param>
    /// <param name="floatValue2"></param>
    public override void DoAttack1(Vector2 directionalValues = default, float floatValue1 = 0, float floatValue2 = 0)
    {
        if (Bull)
        {
            Bull.BossAttack1(directionalValues);
        }
    }

    /// <summary>
    /// Bull's singing attack. Needs a Vector2 to turn towards player. Should be the player's position.
    /// </summary>
    /// <param name="directionalValues">Vector2 to turn towards. Should be player location.</param>
    /// <param name="floatValue1"></param>
    /// <param name="floatValue2"></param>
    public override void DoAttack2(Vector2 directionalValues = default, float floatValue1 = 0, float floatValue2 = 0)
    {
        if (Bull)
        {
            Bull.BossAttack2(directionalValues);
        }
    }

    /// <summary>
    /// Bull's Jumping attack. Needs a Vector2 input for the location to jump to. Should be player's location.
    /// </summary>
    /// <param name="directionalValues">The location where Bull will jump to.</param>
    /// <param name="floatValue1">Does nothing</param>
    /// <param name="floatValue2">Does nothing</param>
    public override void DoAttack3(Vector2 directionalValues = default, float floatValue1 = 0, float floatValue2 = 0)
    {
        if (Bull)
        {
            Bull.BossAttack3(directionalValues);
        }
    }
}
