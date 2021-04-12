using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCState : StateType_Condition
{
    protected PlayerStateMachine myStateMachine = null;

    protected override void Awake()
    {
        myStateMachine = gameObject.GetComponent<PlayerStateMachine>();
        base.Awake();
    }
}
