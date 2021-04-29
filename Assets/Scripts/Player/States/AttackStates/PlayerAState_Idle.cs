using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAState_Idle : PlayerAState
{
    public override void Attack(Vector2 directionInfo)
    {
        Vector3 attackDir = Vector3.zero;
        Quaternion updownRotation = Quaternion.identity;

        if (directionInfo.y >= 0)
        {
            if (Mathf.Abs(directionInfo.x) > 0)
            {
                attackDir = new Vector3(directionInfo.x * 0.8f, 0, 0);
            }
            else if (Mathf.Abs(directionInfo.y) > 0)
            {
                attackDir = new Vector3(0, directionInfo.y * 0.6f, 0);
                updownRotation = Quaternion.Euler(new Vector3(0, 0, 90));
            }

            GameObject attackHitbox = Spawner(
                myStateMachine.ThePlayerPawn.SwordHitboxPrefab,
                myStateMachine.ThePlayerPawn.AttackAnchorPoint.transform,
                myStateMachine.ThePlayerPawn.Owner
                );

            if(directionInfo.x < 0)
            {
                attackHitbox.transform.localScale = new Vector3(
                                                    attackHitbox.transform.localScale.x * -1, 
                                                    attackHitbox.transform.localScale.y, 
                                                    attackHitbox.transform.localScale.z
                                                    );
            }

            if(directionInfo.y > 0 && myStateMachine.ThePlayerPawn.IsFacingRight())
            {
                attackHitbox.transform.localScale = new Vector3(
                                                    attackHitbox.transform.localScale.x,
                                                    attackHitbox.transform.localScale.y * -1,
                                                    attackHitbox.transform.localScale.z
                                                    );
            }

            attackHitbox.transform.localPosition = attackDir;
            attackHitbox.transform.localRotation = updownRotation;

            myStateMachine.ChangeAttackState<PlayerAState_Attacking>();
        }
        else
        {
            if (myStateMachine.CurrentMoveState is PlayerMState_InAir)
            {
                attackDir = new Vector3(0, directionInfo.y * 0.8f, 0);
                //updownRotation = Quaternion.Euler(new Vector3(0, 0, 90));

                GameObject attackHitbox = Spawner(
                myStateMachine.ThePlayerPawn.SwordPlungingPrefab,
                myStateMachine.ThePlayerPawn.AttackAnchorPoint.transform,
                myStateMachine.ThePlayerPawn.Owner
                );

                attackHitbox.transform.localPosition = attackDir;
                attackHitbox.transform.localRotation = updownRotation;

                myStateMachine.ChangeAttackState<PlayerAState_Attacking>();
            }
        }
    }
}
