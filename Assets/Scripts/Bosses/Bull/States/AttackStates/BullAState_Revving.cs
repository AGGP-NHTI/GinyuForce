using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullAState_Revving : BullAState
{
    /// <summary>
    /// Variable that decides how long Bull will revv for.
    /// </summary>
    protected float revvTime = 3f;

    private float currentRevTime = 0f;

    public override void EnterState()
    {
        base.EnterState();
        // Switch to revving animation here
    }

    public override void PerformState()
    {
        base.PerformState();

        currentRevTime += Time.deltaTime;
    }

    public override void TransitionState()
    {
        base.TransitionState();

        if(currentRevTime >= revvTime)
        {
            myStateMachine.ChangeAttackState<BullAState_Charging>();
        }
    }
}
