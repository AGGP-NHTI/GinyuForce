using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerPawn : Pawn
{
    /// <summary>
    /// Protected variable that controls the player speed. TODO: Add public method for modifying this.
    /// </summary>
    [SerializeField]
    protected float movementSpeed = 2f;

    [SerializeField]
    protected float jumpHeight = 10f;

    [SerializeField]
    protected float invulnTime = 1.5f;

    /// <summary>
    /// The duration that this pawn will be invincible for upon taking nonlethal damage.
    /// </summary>
    public float InvulnDuration
    {
        get { return invulnTime; }
    }

    public GameObject AttackAnchorPoint = null;

    public GameObject SwordHitboxPrefab = null;

    public GameObject SwordPlungingPrefab = null;

    /// <summary>
    /// Script reference to the container object for the player sprite.
    /// </summary>
    protected PlayerSpriteCont _playerSprite = null;

    /// <summary>
    /// Public reference to this player's sprite.
    /// </summary>
    public PlayerSpriteCont PlayerSprite
    {
        get { return _playerSprite; }
    }

    [SerializeField]
    protected PlayerStateMachine _playerStateMachine = null;

    public PlayerStateMachine MainStateMachine
    {
        get { return _playerStateMachine; }
    }

    protected override void Awake()
    {
        InitializeRB();
        if (!_playerStateMachine)
        {
            _playerStateMachine = gameObject.AddComponent<PlayerStateMachine>();
        }

        if (!_pawnSprite)
        {
            LogMsg("No pawn sprite attached to this object.");
        }
        else
        {
            if(_pawnSprite is PlayerSpriteCont)
            {
                _playerSprite = (PlayerSpriteCont)_pawnSprite;
            }
            else
            {
                LogMsg("There is a sprite attached to the player, but it is not a player sprite!");
            }
        }

        if(_audioController is PlayerAudioController)
        {

        }
    }

    public override void Attack(Vector2 directions)
    {
        if(_playerStateMachine.CurrentConditionState is PlayerCState_Alive)
        {
            _playerStateMachine.CurrentAttackState.Attack(directions);
        }
    }

    /// <summary>
    /// Moves the pawn's RigidBody in accordance with the input parameter.
    /// </summary>
    /// <param name="movementValues">The pawn's velocity will be set to this Vector2 value.</param>
    public override void PawnMovement(Vector2 movementValues)
    {
        // This mods in the movement speed from the pawn
        Vector2 actualMovement = new Vector2(movementValues.x * movementSpeed, pawnRB.velocity.y);

        if(movementValues.x < 0 && facingRight)
        {
            Vector3 tempScale = transform.localScale;
            tempScale.x *= -1f;
            transform.localScale = tempScale;

            AttackAnchorPoint.transform.localScale = tempScale;

            facingRight = false;
        }
        else if(movementValues.x > 0 && !facingRight)
        {
            Vector3 tempScale = transform.localScale;
            tempScale.x *= -1f;
            transform.localScale = tempScale;

            AttackAnchorPoint.transform.localScale = tempScale;

            facingRight = true;
        }

        _playerStateMachine.CurrentMoveState.PlayerMovement(actualMovement);
    }

    public virtual void PlayerPawnJump()
    {
        _playerStateMachine.CurrentMoveState.PlayerJump(jumpHeight);
    }

    protected override void ProcessDamage(Actor DamageSource, float DamageValue, Controller DamageInstigator, DamageInfo EventInfo)
    {
        base.ProcessDamage(DamageSource, DamageValue, DamageInstigator, EventInfo);

        _actorCurrentHealth -= 1;

        pawnRB.velocity = Vector2.zero;

        PlayerUIManager.Main.UpdatePlayerHearts();

        if(_actorCurrentHealth <= 0f)
        {
            ActorDeath(DamageSource, DamageInstigator);
        }
        else
        {
            PlayerInvuln();
        }
    }

    protected override void ActorDeath(Actor DeathSource, Controller SourceController)
    {
        _playerStateMachine.ChangeConditionState<PlayerCState_Dying>();
    }

    protected virtual void PlayerInvuln()
    {
        _playerStateMachine.ChangeConditionState<PlayerCState_Invuln>();
    }
}
