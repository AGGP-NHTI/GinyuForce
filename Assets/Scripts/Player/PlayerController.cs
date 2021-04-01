using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


// ###CREDITS###
// Help with character controller from https://www.youtube.com/watch?v=1QWjm6yVp3g

public class PlayerController : Controller
{
    public float MoveSpeed = 2f;

    protected Rigidbody2D playerRB;

    private float xMove;

    protected override void Awake()
    {
        _ownType = ControllerType.Player;
        playerRB = gameObject.GetComponent<Rigidbody2D>();
        if (!playerRB)
        {
            playerRB = gameObject.AddComponent<Rigidbody2D>();
            LogMsg("No rigidbody assigned to player. Assign one in the scene menu for better results.");
        }
    }

    public void MoveLeftRight(InputAction.CallbackContext context)
    {
        xMove = context.ReadValue<Vector2>().x;
    }

    private void FixedUpdate()
    {
        playerRB.velocity = new Vector2(xMove * MoveSpeed, playerRB.velocity.y);
    }
}
