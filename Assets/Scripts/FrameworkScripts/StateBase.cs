using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// State components should be added/removed when being changed via .AddComponent<>() and Destroy().
/// As such, Enterstate is called in the Awake() method of Statebase. This behavior is intended and should not be changed.
/// </summary>
public class StateBase : Core
{
    public delegate void StateFunctionEvent();

    public event StateFunctionEvent EnterStateEvent;
    public event StateFunctionEvent PerformStateEvent;
    public event StateFunctionEvent TransitionStateEvent;
    public event StateFunctionEvent ExitStateEvent;

    protected virtual void Awake()
    {
        EnterState();
    }

    /// <summary>
    /// Function called when the state is "entered." This is called in the State's Awake() method and should usually not be
    /// called elsewhere. MAKE SURE THIS CALLS "InvokeEnter()"
    /// </summary>
    public virtual void EnterState()
    {
        InvokeEnter();
    }

    /// <summary>
    /// Function called whenever the state is set to perform its primary behavior, usually on Update() or based on a trigger of some kind.
    /// MAKE SURE THIS CALLS "InvokePerform()"
    /// </summary>
    public virtual void PerformState()
    {
        InvokePerform();
    }

    /// <summary>
    /// Function usually called within PerformState() but can also be called on its own when a possible transition to another state happens.
    /// MAKE SURE THIS CALLS "InvokeTransition()"
    /// </summary>
    public virtual void TransitionState()
    {
        InvokeTransition();
    }

    /// <summary>
    /// Function called from within the TransitionState() method when transition criteria are met. Can also be called from outside in specific
    /// circumstances, but generally should be left to TransitionState(). MAKE SURE THIS CALLS "InvokeExit()"
    /// </summary>
    public virtual void ExitState()
    {
        InvokeExit();
    }

    /// <summary>
    /// Invokes the Enter State Event.
    /// </summary>
    protected void InvokeEnter()
    {
        EnterStateEvent?.Invoke();
    }

    /// <summary>
    /// Invokes the Perform State Event.
    /// </summary>
    protected void InvokePerform()
    {
        PerformStateEvent?.Invoke();
    }

    /// <summary>
    /// Invokes the Transition State Event.
    /// </summary>
    protected void InvokeTransition()
    {
        TransitionStateEvent?.Invoke();
    }

    /// <summary>
    /// Invokes the Exit State Event.
    /// </summary>
    protected void InvokeExit()
    {
        ExitStateEvent?.Invoke();
    }
}
