﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// State machine class for the player. Calls the _current[X]State.Perform and .Transition methods on Update()
/// </summary>
public class PlayerStateMachine : StateMachineBase
{
    /// <summary>
    /// Private reference to the player pawn this state machine is attached to.
    /// </summary>
    protected PlayerPawn _playerPawn = null;

    /// <summary>
    /// Public access that returns the state machine's associated player pawn.
    /// </summary>
    public PlayerPawn ThePlayerPawn
    {
        get { return _playerPawn; }
    }

    protected PlayerMState _currentMovementState = null;

    /// <summary>
    /// Reference to the current move state of this pawn.
    /// </summary>
    public PlayerMState CurrentMoveState
    {
        get { return _currentMovementState; }
    }

    protected PlayerAState _currentAttackState = null;

    /// <summary>
    /// Reference to the current attack state of the pawn.
    /// </summary>
    public PlayerAState CurrentAttackState
    {
        get { return _currentAttackState; }
    }

    protected PlayerCState _currentConditionState = null;

    /// <summary>
    /// Reference to the current condition state of the pawn.
    /// </summary>
    public PlayerCState CurrentConditionState
    {
        get { return _currentConditionState; }
    }

    protected override void Awake()
    {
        _playerPawn = gameObject.GetComponent<PlayerPawn>();
        if (!_playerPawn)
        {
            LogMsg("CRITICAL ERROR. GAMEOBJECT " + ObjectName + " HAS A PLAYERSTATEMACHINE BUT NO PLAYER PAWN. FIX THIS IMMEDIATELY.");
        }

        // Temporary
        ChangeMoveState<PlayerMState_Idle>();
        ChangeAttackState<PlayerAState_Idle>();
        ChangeConditionState<PlayerCState_Alive>();
    }

    /// <summary>
    /// Changes the player's movement state to target input player movement state type. IMPORTANT: Also calls the previous state's ExitState before switching.
    /// </summary>
    /// <typeparam name="TargetStateType">The intended movement state. MUST BE "PlayerMState"</typeparam>
    public virtual void ChangeMoveState<TargetStateType>() where TargetStateType : PlayerMState
    {
        if (CurrentMoveState)
        {
            CurrentMoveState.ExitState();
            Destroy(CurrentMoveState);
        }

        _currentMovementState = gameObject.AddComponent<TargetStateType>();
    }

    /// <summary>
    /// Changes the player's attack state to target input player attack state type. IMPORTANT: Also calls the previous state's ExitState before switching.
    /// </summary>
    /// <typeparam name="TargetStateType">The intended attack state.</typeparam>
    public virtual void ChangeAttackState<TargetStateType>() where TargetStateType : PlayerAState
    {
        if (CurrentAttackState)
        {
            CurrentAttackState.ExitState();
            Destroy(CurrentAttackState);
        }

        _currentAttackState = gameObject.AddComponent<TargetStateType>();
    }

    /// <summary>
    /// Changes the player's condition state to the target input player condition state type. IMPORTANT: Also calls the previous state's ExitState before switching.
    /// </summary>
    /// <typeparam name="TargetStateType">The intended condition state.</typeparam>
    public virtual void ChangeConditionState<TargetStateType>() where TargetStateType : PlayerCState
    {
        if (CurrentConditionState)
        {
            CurrentConditionState.ExitState();
            Destroy(CurrentConditionState);
        }

        _currentConditionState = gameObject.AddComponent<TargetStateType>();
    }

    protected void Update()
    {
        CurrentMoveState.PerformState();
        CurrentMoveState.TransitionState();

        CurrentAttackState.PerformState();
        CurrentAttackState.TransitionState();

        CurrentConditionState.PerformState();
        CurrentConditionState.TransitionState();
    }
}
