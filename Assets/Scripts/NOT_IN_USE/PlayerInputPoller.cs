using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// Controls input retrieval for the player and passes it along to associated Player Controller component
/// </summary>
public class PlayerInputPoller : Core
{
    /// <summary>
    /// Variable to hold the player controller, sends inputs to player controller via
    /// input devices.
    /// </summary>
    public PlayerController Player;

    //private PlayerControls playerInputActions;

    private void Awake()
    {
        Player = gameObject.GetComponent<PlayerController>();

        if (!Player)
        {
            LogMsg("NO PLAYER CONTROLLER DETECTED ON THE PLAYER AT OBJECT " + ObjectName + ". INSTANTIATING FROM DEFAULT. THIS IS NOT "
                + "INTENDED BEHAVIOR, IT IS HIGHLY ADVISED THAT YOU ATTACH A PLAYER CONTROLLER IN THE SCENE WINDOW.");
            Player = gameObject.AddComponent<PlayerController>();
        }

        //playerInputActions = new PlayerControls();
        //playerInputActions.PlayerGameplayControls.DirectionalInput.performed += movectx => MoveLeftRight(movectx);
    }

    public virtual void MoveLeftRight(InputAction.CallbackContext context)
    {
        
    }

    private void OnEnable()
    {
        //playerInputActions.Enable();
    }

    private void OnDisable()
    {
        //playerInputActions.Disable();
    }
}
