using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullAState_Revving : BullAState
{
    private float currentRevTime = 0f;

    public override void EnterState()
    {
        base.EnterState();
        // Switch to revving animation here
        myStateMachine.TheBullPawn.bullSprite.sprite = SpriteManager.Main.bullSprites.Revv;
    }

    public override void PerformState()
    {
        base.PerformState();

        currentRevTime += Time.deltaTime;
    }

    public override void TransitionState()
    {
        base.TransitionState();

        if(currentRevTime >= myStateMachine.TheBullPawn.revvTime)
        {
            myStateMachine.ChangeAttackState<BullAState_Charging>();
        }
    }
}
