using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullAState_LeapCharge : BullAState
{
    private float timer = 0f;

    public override void EnterState()
    {
        base.EnterState();

        myStateMachine.TheBullPawn.bullSprite.sprite = SpriteManager.Main.bullSprites.JumpCharge;
    }

    public override void PerformState()
    {
        base.PerformState();
        timer += Time.deltaTime;
    }

    public override void TransitionState()
    {
        base.TransitionState();

        if(timer >= myStateMachine.TheBullPawn.jumpChargeTime)
        {
            myStateMachine.ChangeAttackState<BullAState_Leaping>();
        }
    }
}
