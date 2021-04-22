﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullPawn : BossPawn
{
    /// <summary>
    /// Speed that modifies how fast Bull charges.
    /// </summary>
    public float chargeSpeed = 10f;

    /// <summary>
    /// How long Bull remains stunned for after hitting a wall.
    /// </summary>
    public float stunCooldown = 3.5f;

    /// <summary>
    /// How much damage Bull takes when he hits a wall.
    /// </summary>
    public float stunDamage = 10f;

    /// <summary>
    /// How high Bull is shifted when he hits a wall.
    /// </summary>
    public float stunHeight = 4f;

    /// <summary>
    /// How far Bull is knocked back when he hits a wall.
    /// </summary>
    public float stunLength = 2f;

    /// <summary>
    /// Bull's jump height in units.
    /// </summary>
    public float jumpHeight = 5f;

    /// <summary>
    /// The time it takes for Bull to complete his jump.
    /// </summary>
    public float jumpTime = 1.5f;
    
    /// <summary>
    /// How fast Bull will fall after completing the arc of his jump
    /// </summary>
    public float fallSpeed = 11.5f;

    /// <summary>
    /// How long Bull will be on his face after his jump attack.
    /// </summary>
    public float faceplantTime = 2.5f;

    [SerializeField]
    protected BullStateMachine _bullStateMachine = null;

    protected override void Awake()
    {
        InitializeRB();
        if (!_bullStateMachine)
        {
            _bullStateMachine = gameObject.AddComponent<BullStateMachine>();
        }
    }

    protected override void ProcessDamage(Actor DamageSource, float DamageValue, Controller DamageInstigator, DamageInfo EventInfo)
    {
        PawnSprite.FlashSprite(true);

        _actorCurrentHealth -= DamageValue;

        base.ProcessDamage(DamageSource, DamageValue, DamageInstigator, EventInfo);
    }

    public override void PawnMovement(Vector2 movementValues)
    {
        PawnRB_SetVelocity(movementValues);
    }

    public virtual void BullRotate(float turnValue)
    {
        if (turnValue < 0 && facingRight)
        {
            Vector3 tempScale = transform.localScale;
            tempScale.x *= -1f;
            transform.localScale = tempScale;

            facingRight = false;
        }
        else if (turnValue > 0 && !facingRight)
        {
            Vector3 tempScale = transform.localScale;
            tempScale.x *= -1f;
            transform.localScale = tempScale;

            facingRight = true;
        }
    }

    public override void BossAttack1(Vector2 directionalValues = default, float floatValue1 = 0, float floatValue2 = 0)
    {
        LogMsg("Bull Charge Attack");

        if(_bullStateMachine.CurrentConditionState is BullCState_Alive && _bullStateMachine.CurrentAttackState is BullAState_Idle)
        {
            BullRotate(directionalValues.x);

            _bullStateMachine.ChangeAttackState<BullAState_Revving>();
        }
    }

    public override void BossAttack2(Vector2 directionalValues = default, float floatValue1 = 0, float floatValue2 = 0)
    {
        LogMsg("Bull Sing Attack");
    }

    /// <summary>
    /// DirectionalValues should be the player's current position.
    /// </summary>
    /// <param name="directionalValues">Player's position</param>
    /// <param name="floatValue1"></param>
    /// <param name="floatValue2"></param>
    public override void BossAttack3(Vector2 directionalValues = default, float floatValue1 = 0, float floatValue2 = 0)
    {
        LogMsg("Bull Jump Attack");

        if(_bullStateMachine.CurrentConditionState is BullCState_Alive && _bullStateMachine.CurrentAttackState is BullAState_Idle)
        {
            BullRotate(directionalValues.x);

            _bullStateMachine.ChangeAttackState<BullAState_Leaping>();
        }
    }
}
