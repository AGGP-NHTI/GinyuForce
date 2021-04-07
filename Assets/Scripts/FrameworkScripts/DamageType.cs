using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DamageType
{
    [SerializeField]
    protected string _damageTypeName = "DamageType_Default";

    public string DamageTypeName
    {
        get { return _damageTypeName; }
    }

    public bool RadialDamage = false;
    public bool PointDamage = false;

    public bool IsKnockback = false;
    public float KnockbackValue = 0f;

    public bool IsInstantKill = false;

    public bool IsStun = false;
    public float StunDuration = 0f;
}
