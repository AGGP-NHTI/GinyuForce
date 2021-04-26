using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullCState_Faceplant : BullCState
{
    float count = 0f;

    public override void EnterState()
    {
        base.EnterState();

        myStateMachine.TheBullPawn.bullSprite.sprite = SpriteManager.Main.bullSprites.FacePlant;

        myStateMachine.TheBullPawn.PawnRB_SetVelocity(Vector2.zero);

        myStateMachine.TheBullPawn.TakeDamage(myStateMachine.TheBullPawn, myStateMachine.TheBullPawn.stunDamage);

        myStateMachine.ChangeAttackState<BullAState_Idle>();
    }

    public override void PerformState()
    {
        base.PerformState();

        count += Time.deltaTime;
    }

    public override void TransitionState()
    {
        base.TransitionState();

        if(count >= myStateMachine.TheBullPawn.faceplantTime)
        {
            myStateMachine.ChangeConditionState<BullCState_Alive>();
        }
    }
}
