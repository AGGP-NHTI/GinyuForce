using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullAState_Singing : BullAState
{
    GameObject singSpawner = null;

    bool spawnedSpawner = false;

    public override void EnterState()
    {
        base.EnterState();

        myStateMachine.TheBullPawn.PawnSprite.SpriteAnimator.SetBool("IsSinging", true);
        myStateMachine.TheBullPawn.PawnSprite.SpriteAnimator.SetBool("IsAttacking", true);
    }

    public override void PerformState()
    {
        base.PerformState();

        if(myStateMachine.isSinging)
        {
            //LogMsg("Stage1");
            if(singSpawner == null && !spawnedSpawner)
            {
                spawnedSpawner = true;
                singSpawner = Spawner(myStateMachine.TheBullPawn.MusicSpawnPrefab, myStateMachine.TheBullPawn.Transform, myStateMachine.TheBullPawn.Owner);
            }
        }
    }

    public override void TransitionState()
    {
        base.TransitionState();

        if(singSpawner == null && myStateMachine.isSinging)
        {
            myStateMachine.ChangeAttackState<BullAState_Idle>();
        }
    }

    public override void ExitState()
    {
        base.ExitState();

        myStateMachine.isSinging = false;

        myStateMachine.TheBullPawn.InvokeAttackCycleFinish();

        myStateMachine.TheBullPawn.PawnSprite.SpriteAnimator.SetBool("IsSinging", false);
    }
}
