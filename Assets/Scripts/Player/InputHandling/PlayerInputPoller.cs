using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// Controls input retrieval for the player and passes it along to associated Player Controller component
/// </summary>
public class PlayerInputPoller : Core
{
    public static PlayerInputPoller Self = null;

    /// <summary>
    /// Variable to hold the player controller, sends inputs to player controller via
    /// input devices.
    /// </summary>
    public PlayerController Player;

    /// <summary>
    /// Component of set of input actions to parse and send to the associated controller.
    /// </summary>
    private PlayerContActions playerInputActions;

    /// <summary>
    /// Component of set of input actions that control non-movement/combat inputs such as pausing, menu management, etc.
    /// </summary>
    private PlayerContActions playerInterfaceActions;

    private void Awake()
    {
        if (Self)
        {
            LogMsg("There is already a player input handler in this scene, on the gameobject " + 
                Self.gameObject.name + ". Destroying new copy instance.");
            Destroy(this);
        }
        Self = this;

        Player = gameObject.GetComponent<PlayerController>();
        if (!Player)
        {
            LogMsg("NO PLAYER CONTROLLER DETECTED ON THE PLAYER AT OBJECT " + ObjectName + ". THIS IS NOT "
                + "INTENDED BEHAVIOR, IT IS HIGHLY ADVISED THAT YOU ATTACH A PLAYER CONTROLLER IN THE SCENE WINDOW.");
            Player = gameObject.AddComponent<PlayerController>();
        }

        playerInputActions = new PlayerContActions();
        playerInputActions.PlayerActiveInput.HorizontalMovement.performed += movectx => MoveLeftRight(movectx);
        playerInputActions.PlayerActiveInput.HorizontalMovement.canceled += movectx => StopMoving();
        playerInputActions.PlayerActiveInput.Jump.performed += jumpctx => Jump();
        playerInputActions.PlayerActiveInput.AttackDirectional.performed += atkctx => PlayerAttack(atkctx.ReadValue<Vector2>());

        playerInterfaceActions = new PlayerContActions();
        playerInterfaceActions.PlayerInterfaceInput.PauseGame.performed += uictx => PauseUnpause();
    }

    /// <summary>
    /// Accepts callback context from the player inputs and funnels it to the player controller.
    /// </summary>
    /// <param name="context">Callback context from the inputs</param>
    public virtual void MoveLeftRight(InputAction.CallbackContext context)
    {
        if (!GameInstanceManager.Main.IsGamePaused())
        {
            Player.MoveLeftRight(context);
        }
    }

    /// <summary>
    /// Tells the player controller to deliver the "Jump" command to the player pawn.
    /// </summary>
    public virtual void Jump()
    {
        if (!GameInstanceManager.Main.IsGamePaused())
        {
            Player.PlayerJump();
        }
    }

    public virtual void PlayerAttack(Vector2 directions)
    {
        if (!GameInstanceManager.Main.IsGamePaused())
        {
            Player.PlayerAttack(directions);
        }
    }

    /// <summary>
    /// Funnels the signal to set velocity to zero to the player controller.
    /// </summary>
    public virtual void StopMoving()
    {
        if (!GameInstanceManager.Main.IsGamePaused())
        {
            Player.StopMoving();
        }
    }

    public virtual void PauseUnpause()
    {
        GameInstanceManager.Main.PauseUnpause();
    }

    /// <summary>
    /// Public method that disables the player "Active Input Actions" (gameplay controls)
    /// </summary>
    public virtual void DisablePlayerInput()
    {
        playerInputActions.Disable();
    }

    /// <summary>
    /// Public method that enables the player "Active Input Actions" (gameplay controls)
    /// </summary>
    public virtual void EnablePlayerInput()
    {
        playerInputActions.Enable();
    }

    private void OnEnable()
    {
        playerInputActions.Enable();
        playerInterfaceActions.Enable();
    }

    private void OnDisable()
    {
        playerInputActions.Disable();
        playerInterfaceActions.Enable();
    }
}
