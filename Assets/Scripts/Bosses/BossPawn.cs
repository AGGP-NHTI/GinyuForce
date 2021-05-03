using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossPawn : Pawn
{
    public delegate void BossAttackEvent();
    public event BossAttackEvent AttackCycleFinish;

    public virtual void InvokeAttackCycleFinish()
    {
        AttackCycleFinish?.Invoke();
    }

    public virtual void BossAttack1(Vector2 directionalValues = default, float floatValue1 = 0, float floatValue2 = 0)
    {

    }

    public virtual void BossAttack2(Vector2 directionalValues = default, float floatValue1 = 0, float floatValue2 = 0)
    {
        
    }

    public virtual void BossAttack3(Vector2 directionalValues = default, float floatValue1 = 0, float floatValue2 = 0)
    {
        
    }

    public virtual void BossAttack4(Vector2 directionalValues = default, float floatValue1 = 0, float floatValue2 = 0)
    {

    }
}