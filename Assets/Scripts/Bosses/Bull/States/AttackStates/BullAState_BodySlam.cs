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
            Spawner(myStateMachine.TheBullPawn.DebrisSpawnPrefab, Location, Rotation, myStateMachine.TheBullPawn.GetController());
            myStateMachine.ChangeConditionState<BullCState_Faceplant>();
        }
    }

    public IEnumerator SpawnRubble()
    {
        yield return new WaitForSeconds(0.8f);

        Spawner(myStateMachine.TheBullPawn.DebrisSpawnPrefab, Location, Rotation, myStateMachine.TheBullPawn.GetController());
    }

    public override void ExitState()
    {
        base.ExitState();
        myStateMachine.TheBullPawn.InvokeAttackCycleFinish();
    }
}
