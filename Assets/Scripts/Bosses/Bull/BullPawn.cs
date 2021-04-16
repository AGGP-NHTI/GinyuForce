using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullPawn : Pawn
{
    protected override void Awake()
    {
        InitializeRB();
    }

    protected override void ProcessDamage(Actor DamageSource, float DamageValue, Controller DamageInstigator, DamageInfo EventInfo)
    {
        PawnSprite.FlashSprite(true);

        _actorCurrentHealth -= DamageValue;

        base.ProcessDamage(DamageSource, DamageValue, DamageInstigator, EventInfo);
    }
}
