using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSwordHitbox : DamageHitbox
{
    protected PlayerPawn player;

    protected virtual void Awake()
    {
        player = gameObject.GetComponentInParent<PlayerPawn>();
    }
}
