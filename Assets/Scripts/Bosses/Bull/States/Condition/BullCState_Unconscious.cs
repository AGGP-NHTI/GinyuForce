using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullCState_Unconscious : BullCState
{
    public override void EnterState()
    {
        base.EnterState();

        myStateMachine.ChangeAttackState<BullAState_Idle>();

        myStateMachine.TheBullPawn.PawnSprite.SpriteAnimator.Play("Unconscious");
        myStateMachine.TheBullPawn.GetComponentInChildren<DamageHitbox>().gameObject.SetActive(false);
    }
}
