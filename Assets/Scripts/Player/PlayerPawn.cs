using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPawn : Pawn
{
    protected Rigidbody2D playerRB = null;

    protected override void Awake()
    {
        playerRB = gameObject.GetComponent<Rigidbody2D>();
        if (!playerRB)
        {
            playerRB = gameObject.AddComponent<Rigidbody2D>();
            LogMsg("No rigidbody assigned to player. Assign one in the scene menu for better results.");
        }
    }

    public override void PawnMovement(Vector2 movementValues)
    {
        playerRB.velocity = movementValues;
    }
}
