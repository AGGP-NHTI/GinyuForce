using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageHitbox : Actor
{
    /// <summary>
    /// If this field is filled, this hitbox is a composite of another actor and should redirect damage taken to that actor.
    /// </summary>
    public Actor mainActor = null;

    public bool isPermament = false;

    public bool tickDamage = false;

    public float damageValue = 0f;

    [SerializeField]
    protected float hitboxLifetime = 4f;

    protected float lifetimeCounter = 0f;

    public float GetCurrentLifetime()
    {
        return lifetimeCounter;
    }

    protected DamageInfo thisDamageInfo = null;

    protected virtual void OnTriggerEnter2D(Collider2D collision)
    {
        Actor otherActor = collision.GetComponent<Actor>();

        if (otherActor)
        {
            otherActor.TakeDamage(this, damageValue, Owner, thisDamageInfo);
        }
    }

    protected virtual void OnTriggerStay2D(Collider2D collision)
    {
        if (tickDamage)
        {
            Actor otherActor = collision.GetComponent<Actor>();

            if (otherActor)
            {
                otherActor.TakeDamage(this, damageValue, Owner, thisDamageInfo);
            }
        }
    }

    public override bool TakeDamage(Actor DamageSource, float DamageValue, Controller DamageInstigator = null, DamageInfo EventInfo = null)
    {
        if (mainActor)
        {
            return mainActor.TakeDamage(DamageSource, DamageValue, DamageInstigator, EventInfo);
        }
        else
        {
            return base.TakeDamage(DamageSource, DamageValue, DamageInstigator, EventInfo);
        }
    }

    protected virtual void Update()
    {
        if (!isPermament)
        {
            lifetimeCounter += Time.deltaTime;
            if (lifetimeCounter >= hitboxLifetime)
            {
                Destroy(gameObject);
            }
        }
    }
}
