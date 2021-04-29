using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Made with help from https://gamedev.stackexchange.com/questions/157642/moving-a-2d-object-along-circular-arc-between-two-points

public class BullAState_Leaping : BullAState
{
    Vector2 bullPos;
    Vector2 arcControlPoint;
    Vector2 playerPos;

    float count = 0f;
    float maxTime = 1.0f;

    public override void EnterState()
    {
        base.EnterState();

        myStateMachine.TheBullPawn.PawnRB_SetVelocity(Vector2.zero);

        bullPos = myStateMachine.TheBullPawn.Location;

        playerPos = myStateMachine.TheBullPawn.SlamTarget + Vector2.up * 5f;

        Vector2 distance = new Vector2(Vector2.Distance(playerPos, bullPos), 0);

        if (playerPos.x < bullPos.x) distance *= -1;

        arcControlPoint = bullPos + distance / 2 + Vector2.up * myStateMachine.TheBullPawn.jumpHeight;

        maxTime = myStateMachine.TheBullPawn.jumpTime;

        myStateMachine.TheBullPawn.bullSprite.sprite = SpriteManager.Main.bullSprites.Leaping;
    }

    public override void PerformState()
    {
        base.PerformState();

        if (count < maxTime)
        {
            count += 1.0f * Time.deltaTime;

            Vector2 m1 = Vector2.Lerp(bullPos, arcControlPoint, count);
            Vector2 m2 = Vector2.Lerp(arcControlPoint, playerPos, count);
            myStateMachine.TheBullPawn.transform.position = Vector2.Lerp(m1, m2, count);
        }
    }

    public override void TransitionState()
    {
        base.TransitionState();

        if(Vector2.Distance(Location,playerPos) <= 0.0005f)
        {
            myStateMachine.ChangeAttackState<BullAState_BodySlam>();
        }
    }
}
