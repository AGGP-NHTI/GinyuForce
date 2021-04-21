using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullPawn : BossPawn
{
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
        
    }

    public override void BossAttack1(Vector2 directionalValues = default, float floatValue1 = 0, float floatValue2 = 0)
    {
        LogMsg("Bull Charge Attack");
    }

    public override void BossAttack2(Vector2 directionalValues = default, float floatValue1 = 0, float floatValue2 = 0)
    {
        LogMsg("Bull Sing Attack");
    }

    public override void BossAttack3(Vector2 directionalValues = default, float floatValue1 = 0, float floatValue2 = 0)
    {
        LogMsg("Bull Jump Attack");
    }
}
