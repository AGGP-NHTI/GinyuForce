using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullAState_Idle : BullAState
{
    public override void EnterState()
    {
        base.EnterState();

        myStateMachine.TheBullPawn.PawnSprite.SpriteAnimator.SetBool("IsAttacking",false);
    }

    public override void ExitState()
    {
        base.ExitState();

        myStateMachine.TheBullPawn.PawnSprite.SpriteAnimator.SetBool("IsAttacking", true);
    }
}
