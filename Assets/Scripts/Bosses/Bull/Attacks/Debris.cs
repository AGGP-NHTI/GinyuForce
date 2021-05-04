using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Adapted from Nicole's "falling_motion" script

public class Debris : Actor
{
    //falling speed
    [SerializeField]
    private float speed = 0.4f;

    private Rigidbody2D rb;

    private bool dealsDamage = true;

    protected float damageAmount = 10;

    private void Awake()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();

        rb.velocity = Vector2.down * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Actor actor = collision.gameObject.GetComponent<Actor>();

        if (collision.gameObject.layer == 10)
        {
            dealsDamage = false;
            GetComponent<Animator>().Play("Destroyed");
            rb.velocity = Vector2.zero;
            rb.gravityScale = 0f;
        }
        else if (actor && dealsDamage)
        {
            actor.TakeDamage(this, damageAmount, Owner);           
        }
    }

    public void BreakDebris()
    {
        Destroy(gameObject);
    }
}
