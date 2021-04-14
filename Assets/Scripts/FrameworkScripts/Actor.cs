using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actor : Core
{
    /// <summary>
    /// Boolean value. Determines how damage will be processed by this actor. Default value is false.
    /// </summary>
    [SerializeField]
    protected bool TakesDamage = false;

    /// <summary>
    /// public access to this actor's "TakesDamage" variable, which determines if the "processdamage" function is called.
    /// </summary>
    public bool DoesTakeDamage
    {
        get { return TakesDamage; }
        set { TakesDamage = value; }
    }

    /// <summary>
    /// The name of the actor.
    /// </summary>
    [SerializeField]
    protected string _actorName = "ActorName_Default";

    /// <summary>
    /// Gets name of the actor as a string.
    /// </summary>
    /// <returns></returns>
    public string ActorName
    {
        get { return _actorName; }
        set { _actorName = value; }
    }

    /// <summary>
    /// If true, outputs damage event information to the console.
    /// </summary>
    [SerializeField]
    protected bool DebugDamageLog = true;

    /// <summary>
    /// Protected reference to this Actor's owner. Retrieved/edited via public interface. Default value is "null" for not belonging to any entity.
    /// </summary>
    protected Controller _owner = null;

    /// <summary>
    /// Public interface for this actor's owner controller, if it has one.
    /// </summary>
    public Controller Owner
    {
        get { return _owner; }
        set { _owner = value; }
    }

    /// <summary>
    /// The maximum health that this actor has. Default value is 100.
    /// </summary>
    [SerializeField]
    protected float _actorMaximumHealth = 100f;

    /// <summary>
    /// Returns the maximum health value of the actor.
    /// </summary>
    /// <returns></returns>
    public float GetActorMaxHealth()
    {
        return _actorMaximumHealth;
    }

    /// <summary>
    /// Sets the actor's maximum health to the float value and will act appropriately if current health is greater than that value.
    /// </summary>
    /// <param name="targetMaxHealth">The value to set the actor's max health to</param>
    public void SetActorMaxHealth(float targetMaxHealth)
    {
        _actorMaximumHealth = targetMaxHealth;
        if(_actorCurrentHealth > _actorMaximumHealth)
        {
            _actorCurrentHealth = _actorMaximumHealth;
        }
    }

    /// <summary>
    /// The health of this actor. Default value is 100.
    /// </summary>
    [SerializeField]
    protected float _actorCurrentHealth = 100f;

    /// <summary>
    /// Public access variable to this actor's current health.
    /// </summary>
    public float CurrentHealth
    {
        get { return _actorCurrentHealth; }
    }

    /// <summary>
    /// Public method that accepts information about damage being dealt to the actor. Will return false if the damage was ignored, or true if the
    /// damage was processed. Should generally not be overridden.
    /// </summary>
    /// <param name="DamageSource">The Actor that dealt the damage</param>
    /// <param name="DamageValue">The amount of damage being taken</param>
    /// <param name="DamageInstigator">Optional parameter, the controller of the actor that did the damage</param>
    /// <param name="EventInfo">Information about the properties of the damage taken</param>
    /// <returns>Returns False if this actor did not process the damage.</returns>
    public virtual bool TakeDamage(Actor DamageSource, float DamageValue, Controller DamageInstigator = null, DamageInfo EventInfo = null)
    {
        if (TakesDamage)
        {
            if(EventInfo == null)
            {
                EventInfo = new DamageInfo();
            }
            ProcessDamage(DamageSource, DamageValue, DamageInstigator, EventInfo);
            return true;
        }
        else
        {
            return false;
        }
    }

    /// <summary>
    /// Protected method to be overridden by child actor classes. Base method logs damage if the DebugDamage bool is set to true.
    /// </summary>
    /// <param name="DamageSource"></param>
    /// <param name="DamageValue"></param>
    /// <param name="DamageInstigator"></param>
    /// <param name="EventInfo"></param>
    protected virtual void ProcessDamage(Actor DamageSource, float DamageValue, Controller DamageInstigator, DamageInfo EventInfo)
    {
        string DamageDebugString = DamageSource.ActorName + " dealt " + DamageValue + " damage of type " + EventInfo.damageType.DamageTypeName + " to " + ActorName;
        if (DamageInstigator)
        {
            DamageDebugString += DamageInstigator.ControllerName + ", using " + DamageDebugString;
        }

        if (DebugDamageLog)
        {
            DebugDamage(DamageDebugString);
        }
    }

    /// <summary>
    /// Virtual method that processes the death for the actor.
    /// </summary>
    /// <param name="DeathSource"></param>
    /// <param name="SourceController"></param>
    protected virtual void ActorDeath(Actor DeathSource, Controller SourceController)
    {
        LogMsg("Actor " + ActorName + " has died. Was killed by " + DeathSource.ActorName);
    }

    protected virtual void DebugDamage(string debugString)
    {
        LogMsg(debugString);
    }
}
