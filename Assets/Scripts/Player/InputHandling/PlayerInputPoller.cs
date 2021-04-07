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

    /// <summary>
    /// Component of set of input actions to parse and send to the associated controller.
    /// </summary>
    private PlayerContActions playerInputActions;

    private void Awake()
    {
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
    }

    /// <summary>
    /// Accepts callback context from the player inputs and funnels it to the player controller.
    /// </summary>
    /// <param name="context">Callback context from the inputs</param>
    public virtual void MoveLeftRight(InputAction.CallbackContext context)
    {
        Player.MoveLeftRight(context);
    }

    /// <summary>
    /// Tells the player controller to deliver the "Jump" command to the player pawn.
    /// </summary>
    public virtual void Jump()
    {
        Player.PlayerJump();
    }

    public virtual void PlayerAttack(Vector2 directions)
    {
        Player.PlayerAttack(directions);
    }

    /// <summary>
    /// Funnels the signal to set velocity to zero to the player controller.
    /// </summary>
    public virtual void StopMoving()
    {
        Player.StopMoving();
    }

    private void OnEnable()
    {
        playerInputActions.Enable();
    }

    private void OnDisable()
    {
        playerInputActions.Disable();
    }
}
