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

    private bool facingRight = true;

    public bool IsFacingRight()
    {
        return facingRight;
    }

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

    /// <summary>
    /// The rigidbody component of the pawn.
    /// </summary>
    protected Rigidbody2D playerRB = null;

    /// <summary>
    /// Gets a reference to the rigidbody of the player pawn.
    /// </summary>
    /// <returns></returns>
    public Rigidbody2D GetPlayerRB()
    {
        return playerRB;
    }
    
    /// <summary>
    /// Gets the current velocity of the player's rigidbody component.
    /// </summary>
    /// <returns></returns>
    public Vector2 GetVelocity()
    {
        return playerRB.velocity;
    }

    /// <summary>
    /// Sets the pawn's rigidbody velocity according to the input velocity vector2.
    /// </summary>
    /// <param name="desiredVelocity">Desired velocity as a vector2 value.</param>
    public void PlayerRB_SetVelocity(Vector2 desiredVelocity)
    {
        playerRB.velocity = desiredVelocity;
    }

    [SerializeField]
    protected PlayerStateMachine _playerStateMachine = null;

    protected override void Awake()
    {
        playerRB = gameObject.GetComponent<Rigidbody2D>();
        if (!playerRB)
        {
            // If the pawn has no rigidbody, add one. This is not intended behavior, as most pawns should have a rigidbody, with a few exceptions.
            playerRB = gameObject.AddComponent<Rigidbody2D>();
            LogMsg("No rigidbody assigned to player. Assign one in the scene menu for better results.");
        }
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

    }

    public override void Attack(Vector2 directions)
    {
        _playerStateMachine.CurrentAttackState.Attack(directions);
    }

    /// <summary>
    /// Moves the pawn's RigidBody in accordance with the input parameter.
    /// </summary>
    /// <param name="movementValues">The pawn's velocity will be set to this Vector2 value.</param>
    public override void PawnMovement(Vector2 movementValues)
    {
        // This mods in the movement speed from the pawn
        Vector2 actualMovement = new Vector2(movementValues.x * movementSpeed, playerRB.velocity.y);

        if(movementValues.x < 0 && facingRight)
        {
            Vector3 tempScale = transform.localScale;
            tempScale.x *= -1f;
            transform.localScale = tempScale;

            facingRight = false;
        }
        else if(movementValues.x > 0 && !facingRight)
        {
            Vector3 tempScale = transform.localScale;
            tempScale.x *= -1f;
            transform.localScale = tempScale;

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

        _actorCurrentHealth -= DamageValue;

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
