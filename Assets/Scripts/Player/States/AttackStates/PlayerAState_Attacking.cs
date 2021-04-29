using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAState_Attacking : PlayerAState
{
    GameObject swordHitbox;

    protected override void Awake()
    {
        base.Awake();

        swordHitbox = gameObject.GetComponentInChildren<PlayerSwordHitbox>().gameObject;
    }

    public override void EnterState()
    {
        base.EnterState();

        myStateMachine.ThePlayerPawn.PawnSprite.SpriteAnimator.SetBool("IsAttacking", true);
    }

    public override void Attack(Vector2 directionInfo)
    {
        
    }

    public override void PerformState()
    {
        base.PerformState();
    }

    public override void TransitionState()
    {
        base.TransitionState();
        if(!swordHitbox)
        {
            myStateMachine.ChangeAttackState<PlayerAState_Idle>();
        }
    }

    public override void ExitState()
    {
        base.ExitState();
        myStateMachine.ThePlayerPawn.PawnSprite.SpriteAnimator.SetBool("AttackingFront", false);
        myStateMachine.ThePlayerPawn.PawnSprite.SpriteAnimator.SetBool("AttackingUp", false);
        myStateMachine.ThePlayerPawn.PawnSprite.SpriteAnimator.SetBool("PlungeAttack", false);
        myStateMachine.ThePlayerPawn.PawnSprite.SpriteAnimator.SetBool("IsAttacking", false);
    }
}
