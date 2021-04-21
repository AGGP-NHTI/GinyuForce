using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullStateMachine : StateMachineBase
{
    protected BullPawn _bullPawn = null;

    public BullPawn TheBullPawn
    {
        get { return _bullPawn; }
    }

    /// <summary>
    /// Currently unused state to hold his anger level
    /// </summary>
    protected BullAngState _currentAngerState = null;

    /// <summary>
    /// Currently unused state to hold his anger level
    /// </summary>
    public BullAngState CurrentAngerState
    {
        get { return _currentAngerState; }
    }

    protected BullAState _currentAttackState = null;

    public BullAState CurrentAttackState
    {
        get { return _currentAttackState; }
    }

    protected BullCState _currentConditionState = null;

    public BullCState CurrentConditionState
    {
        get { return _currentConditionState; }
    }

    protected override void Awake()
    {
        _bullPawn = gameObject.GetComponent<BullPawn>();

        ChangeAttackState<BullAState_Idle>();
        ChangeConditionState<BullCState_Alive>();
    }

    protected virtual void Update()
    {
        _currentAttackState.PerformState();
        _currentAttackState.TransitionState();

        _currentConditionState.PerformState();
        _currentConditionState.TransitionState();
    }

    public virtual void ChangeAttackState<TargetStateType>() where TargetStateType : BullAState
    {
        if (CurrentAttackState)
        {
            _currentAttackState.ExitState();
            Destroy(_currentAttackState);
        }

        _currentAttackState = gameObject.AddComponent<TargetStateType>();
    }

    public virtual void ChangeConditionState<TargetStateType>() where TargetStateType : BullCState
    {
        if (CurrentConditionState)
        {
            _currentConditionState.ExitState();
            Destroy(_currentConditionState);
        }

        _currentConditionState = gameObject.AddComponent<TargetStateType>();
    }
}
