using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullAState_Charging : BullAState
{
    private Vector2 chargeSpeed;

    public override void EnterState()
    {
        base.EnterState();

        chargeSpeed = Transform.forward;

        chargeSpeed.x += myStateMachine.TheBullPawn.chargeSpeed;

        if (!myStateMachine.TheBullPawn.IsFacingRight())
        {
            chargeSpeed.x *= -1;
        }

        myStateMachine.TheBullPawn.PawnMovement(chargeSpeed);
    }

    public override void PerformState()
    {
        base.PerformState();

        myStateMachine.TheBullPawn.PawnMovement(chargeSpeed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 10)
        {
            myStateMachine.TheBullPawn.TakeDamage(myStateMachine.TheBullPawn, myStateMachine.TheBullPawn.stunDamage);
            myStateMachine.ChangeConditionState<BullCState_Stunned>();
        }
    }
}
