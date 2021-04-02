using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


// ###CREDITS###
// Help with character controller from https://www.youtube.com/watch?v=1QWjm6yVp3g

public class PlayerController : Controller
{
    public float MoveSpeed = 2f;

    private float xMove;

    protected bool isMoving = false;

    protected PlayerPawn thisPlayerPawn = null;

    protected override void Awake()
    {
        _ownType = ControllerType.Player;

        if(GetPawn() is PlayerPawn)
        {
            thisPlayerPawn = (PlayerPawn)GetPawn();
        }
        else
        {
            LogMsg("No player pawn given to main player controller. THIS IS A FATAL ERROR.");
        }
    }

    public void MoveLeftRight(InputAction.CallbackContext context)
    {
        LogMsg("MLR");
        xMove = context.ReadValue<Vector2>().x;
        isMoving = true;
    }

    public void StopMoving()
    {
        LogMsg("SMLR");
        isMoving = false;
    }

    private void FixedUpdate()
    {
        if (isMoving)
        {
            //playerRB.velocity = new Vector2(xMove * MoveSpeed, playerRB.velocity.y);
            Vector2 movementValues = new Vector2(xMove * MoveSpeed,0);
            thisPlayerPawn.PawnMovement(movementValues);
        }
        else
        {
            Vector2 movementValues = new Vector2(0, 0);
            thisPlayerPawn.PawnMovement(movementValues);
        }
    }
}
