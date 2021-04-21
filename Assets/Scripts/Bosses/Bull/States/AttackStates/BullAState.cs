using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullAState : StateType_Attack
{
    protected BullStateMachine myStateMachine = null;

    protected override void Awake()
    {
        myStateMachine = gameObject.GetComponent<BullStateMachine>();
        base.Awake();
    }
}
