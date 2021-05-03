using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullAState_Singing : BullAState
{
    public override void ExitState()
    {
        base.ExitState();

        myStateMachine.TheBullPawn.InvokeAttackCycleFinish();

        myStateMachine.TheBullPawn.PawnSprite.SpriteAnimator.SetBool("IsSinging", false);
    }
}
