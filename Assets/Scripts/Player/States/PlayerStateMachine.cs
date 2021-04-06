using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStateMachine : StateMachineBase
{
    protected PlayerMState _currentMovementState = null;

    public PlayerMState GetPlayerMovementState()
    {
        return _currentMovementState;
    }
}
