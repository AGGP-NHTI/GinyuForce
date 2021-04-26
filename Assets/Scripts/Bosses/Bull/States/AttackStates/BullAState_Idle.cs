using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullAState_Idle : BullAState
{
    public override void EnterState()
    {
        base.EnterState();

        if(myStateMachine.CurrentConditionState is BullCState_Alive)
        {
           // myStateMachine.TheBullPawn.bullSprite.sprite = SpriteManager.Main.bullSprites.Idle;
        }
    }
}
