using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateMachineBase : Core
{
    protected virtual void Awake()
    {
        LogMsg("Base State Machine initialized on GameObject " + ObjectName 
            + ". It is not recommended to use a base state machine as it may have unintended behaviors.");
    }
}
