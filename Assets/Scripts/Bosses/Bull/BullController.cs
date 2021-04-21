using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullController : AIController
{
    protected BullPawn Bull = null;

    protected override void Awake()
    {
        _ownType = ControllerType.AI;
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
    /// Bull's Charge attack method.
    /// </summary>
    public override void DoAttack1(Vector2 directionalValues = default, float floatValue1 = 0, float floatValue2 = 0)
    {
        if (Bull)
        {
            Bull.BossAttack1(directionalValues);
        }
    }

    /// <summary>
    /// Bull's Sing attack.
    /// </summary>
    public override void DoAttack2(Vector2 directionalValues = default, float floatValue1 = 0, float floatValue2 = 0)
    {
        if (Bull)
        {
            Bull.BossAttack2();
        }
    }

    /// <summary>
    /// Bull's Jump attack.
    /// </summary>
    public override void DoAttack3(Vector2 directionalValues = default, float floatValue1 = 0, float floatValue2 = 0)
    {
        if (Bull)
        {
            Bull.BossAttack3();
        }
    }
}
