using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullAState_BodySlam : BullAState
{
    public override void EnterState()
    {
        base.EnterState();

        myStateMachine.TheBullPawn.PawnSprite.SpriteAnimator.SetBool("IsBodySlam", true);

        myStateMachine.TheBullPawn.PawnRB_SetVelocity(Vector2.down * myStateMachine.TheBullPawn.fallSpeed);
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer == 10)
        {
            myStateMachine.ChangeConditionState<BullCState_Faceplant>();
        }
    }
}
