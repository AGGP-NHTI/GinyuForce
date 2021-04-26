using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullCState_Alive : BullCState
{
    public override void EnterState()
    {
        base.EnterState();

        myStateMachine.TheBullPawn.bullSprite.sprite = SpriteManager.Main.bullSprites.Idle;
    }
}
