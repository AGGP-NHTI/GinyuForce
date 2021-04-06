using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : StateMachineBase
{
    protected PlayerPawn _playerPawn = null;

    public PlayerPawn ThePlayerPawn
    {
        get { return _playerPawn; }
    }

    protected PlayerMState _currentMovementState = null;

    public PlayerMState CurrentMoveState
    {
        get { return _currentMovementState; }
        set { _currentMovementState = value; }
    }

    protected override void Awake()
    {
        _playerPawn = gameObject.GetComponent<PlayerPawn>();
        if (!_playerPawn)
        {
            LogMsg("CRITICAL ERROR. GAMEOBJECT " + ObjectName + " HAS A PLAYERSTATEMACHINE BUT NO PLAYER PAWN. FIX THIS IMMEDIATELY.");
        }
    }

    /// <summary>
    /// Changes the player's movement state to target input player movement state type.
    /// </summary>
    /// <typeparam name="TargetStateType">The intended movement state. MUST BE "PlayerMState"</typeparam>
    public virtual void ChangeMoveState<TargetStateType>() where TargetStateType : PlayerMState
    {
        Destroy(CurrentMoveState);
        CurrentMoveState = gameObject.AddComponent<TargetStateType>();
    }

    protected void Update()
    {
        CurrentMoveState.PerformState();
        CurrentMoveState.TransitionState();
    }
}
