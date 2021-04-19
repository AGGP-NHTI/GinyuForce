using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : Controller
{
    public virtual void DoAttack1(Vector2 directionalValues = default, float floatValue1 = 0, float floatValue2 = 0)
    {
        LogMsg("Base Attack1 method called on " + ObjectName);
    }

    public virtual void DoAttack2(Vector2 directionalValues = default, float floatValue1 = 0, float floatValue2 = 0)
    {
        LogMsg("Base Attack2 method called on " + ObjectName);
    }

    public virtual void DoAttack3(Vector2 directionalValues = default, float floatValue1 = 0, float floatValue2 = 0)
    {
        LogMsg("Base Attack3 method called on " + ObjectName);
    }

    public virtual void DoAttack4(Vector2 directionalValues = default, float floatValue1 = 0, float floatValue2 = 0)
    {
        LogMsg("Base Attack4 method called on " + ObjectName);
    }
}
