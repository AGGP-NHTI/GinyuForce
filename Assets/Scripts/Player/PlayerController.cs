using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


// ###CREDITS###
// Help with character controller from https://www.youtube.com/watch?v=1QWjm6yVp3g

public class PlayerController : Controller
{
    /// <summary>
    /// Private member variable to control what values are sent to the pawn for movement input.
    /// </summary>
    private float xMove = 0f;

    /// <summary>
    /// Boolean value to determine whether to send movement to the pawn, controlled by input sent by the associated inputpoller.
    /// </summary>
    protected bool isMoving = false;

    /// <summary>
    /// The playerpawn to send input to. This is "inherited" from the Controller parent's "controlledPawn" member variable.
    /// </summary>
    protected PlayerPawn thisPlayerPawn = null;

    protected override void Awake()
    {
        _ownType = ControllerType.Player;
    }

    protected virtual void Start()
    {
        if (GetPawn() is PlayerPawn)
        {
            thisPlayerPawn = (PlayerPawn)GetPawn();
        }
        else
        {
            // TODO: Put a boolean here to stop this from sending input to thisPlayerPawn if it's not a playerpawn.
            LogMsg("No player pawn given to main player controller. THIS IS A FATAL ERROR.");
        }
    }

    public void PlayerAttack(Vector2 directions)
    {
        thisPlayerPawn.Attack(directions);
    }

    /// <summary>
    /// Adjusts the movement values sent to the controlled pawn on FixedUpdate based on a Vector2 value from input context.
    /// </summary>
    /// <param name="context">CallbackContext from the input that calls this function, which should be in PlayerInputPoller.</param>
    public void MoveLeftRight(InputAction.CallbackContext context)
    {
        //LogMsg("MLR");
        xMove = context.ReadValue<Vector2>().x;
        isMoving = true;
    }

    /// <summary>
    /// Adjusts the movement values sent to the controlled. Sets value to zero to prevent movement.
    /// </summary>
    public void StopMoving()
    {
        //LogMsg("SMLR");
        xMove = 0f;
        isMoving = false;
    }

    public void PlayerJump()
    {
        thisPlayerPawn.PlayerPawnJump();
    }

    private void FixedUpdate()
    {
        Vector2 movementValues = new Vector2(xMove, 0);

        thisPlayerPawn.PawnMovement(movementValues);
    }
}
