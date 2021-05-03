using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullPawn : BossPawn
{
    /// <summary>
    /// Variable that decides how long Bull will revv for.
    /// </summary>
    public float revvTime = 1.5f;

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
    /// The time Bull will charge for before he leaps
    /// </summary>
    public float jumpChargeTime = 0.5f;

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

    /// <summary>
    /// The target position that Bull will jump towards for his slam attack
    /// </summary>
    protected Vector2 _slamTarget = Vector2.zero;

    public Vector2 SlamTarget
    {
        get { return _slamTarget; }
    }

    public void SetSlamTarget(Vector2 targetPos)
    {
        _slamTarget = targetPos;
    }

    [SerializeField]
    protected BullStateMachine _bullStateMachine = null;

    public BullStateMachine OwnStateMachine
    {
        get { return _bullStateMachine; }
    }

    public SpriteRenderer bullSprite;

    protected BullAudioController _bullAudioController;

    public GameObject DebrisSpawnPrefab = null;

    public GameObject MusicSpawnPrefab = null;

    public GameObject HurtBox = null;

    protected override void Awake()
    {
        InitializeRB();
        if (!_bullStateMachine)
        {
            _bullStateMachine = gameObject.AddComponent<BullStateMachine>();
        }

        if (!bullSprite)
        {
            bullSprite = gameObject.GetComponentInChildren<SpriteRenderer>();
        }

        if(_audioController is BullAudioController)
        {
            _bullAudioController = (BullAudioController)_audioController;
        }
    }

    protected override void ProcessDamage(Actor DamageSource, float DamageValue, Controller DamageInstigator, DamageInfo EventInfo)
    {
        _bullAudioController.PlayAudioClip(_bullAudioController.BullClips.DamageClip);

        PawnSprite.FlashSprite(true);

        _actorCurrentHealth -= DamageValue;

        if(_actorCurrentHealth <= 0)
        {
            _bullStateMachine.ChangeConditionState<BullCState_Unconscious>();
        }

        base.ProcessDamage(DamageSource, DamageValue, DamageInstigator, EventInfo);
    }

    public override void PawnMovement(Vector2 movementValues)
    {
        PawnRB_SetVelocity(movementValues);
    }

    public virtual void BullRotate(float turnValue)
    {
        if (turnValue < transform.position.x && facingRight)
        {
            Vector3 tempScale = transform.localScale;
            tempScale.x *= -1f;
            transform.localScale = tempScale;

            facingRight = false;
        }
        else if (turnValue > transform.position.x && !facingRight)
        {
            Vector3 tempScale = transform.localScale;
            tempScale.x *= -1f;
            transform.localScale = tempScale;

            facingRight = true;
        }
    }

    public override void BossAttack1(Vector2 directionalValues = default, float floatValue1 = 0, float floatValue2 = 0)
    {
        //LogMsg("Bull Charge Attack");

        if(_bullStateMachine.CurrentConditionState is BullCState_Alive && _bullStateMachine.CurrentAttackState is BullAState_Idle)
        {
            BullRotate(directionalValues.x);

            _bullStateMachine.ChangeAttackState<BullAState_Revving>();
        }
    }

    public override void BossAttack2(Vector2 directionalValues = default, float floatValue1 = 0, float floatValue2 = 0)
    {
        LogMsg("Bull Sing Attack");
        if(_bullStateMachine.CurrentConditionState is BullCState_Alive && _bullStateMachine.CurrentAttackState is BullAState_Idle)
        {
            BullRotate(directionalValues.x);

            _bullStateMachine.ChangeAttackState<BullAState_Singing>();
        }
    }

    /// <summary>
    /// DirectionalValues should be the player's current position.
    /// </summary>
    /// <param name="directionalValues">Player's position</param>
    /// <param name="floatValue1"></param>
    /// <param name="floatValue2"></param>
    public override void BossAttack3(Vector2 directionalValues = default, float floatValue1 = 0, float floatValue2 = 0)
    {
        //LogMsg("Bull Jump Attack");

        if(_bullStateMachine.CurrentConditionState is BullCState_Alive && _bullStateMachine.CurrentAttackState is BullAState_Idle)
        {
            SetSlamTarget(directionalValues);

            BullRotate(directionalValues.x);

            _bullStateMachine.ChangeAttackState<BullAState_LeapCharge>();
        }
    }
}
