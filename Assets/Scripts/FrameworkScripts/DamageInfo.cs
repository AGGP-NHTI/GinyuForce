using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DamageInfo
{
    public DamageType damageType;

    public DamageInfo()
    {
        damageType = new DamageType();
    }

    public DamageInfo(Type targetDamageType)
    {
        damageType = (DamageType)Activator.CreateInstance(targetDamageType);
    }
}
