using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteProjectile : Actor
{
    public float maxLifetime = 5f;

    public float lifetime = 0f;

    public float damageAmount = 5f;

    private bool dealsDamage = true;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

        int coin = Random.Range(0, 2);

        switch (coin)
        {
            case 0:
                GetComponent<Animator>().Play("MusicNoteFlying");
                break;
            case 1:
                GetComponent<Animator>().Play("MusicNoteFlying2");
                break;
        }
    }

    private void Update()
    {
        lifetime += Time.deltaTime;

        if(lifetime >= maxLifetime)
        {
            rb.velocity = Vector2.zero;
            dealsDamage = false;
            GetComponent<Animator>().Play("MusicNoteDestroy");
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.layer == 10)
        {
            rb.velocity = Vector2.zero;
            dealsDamage = false;
            GetComponent<Animator>().Play("MusicNoteDestroy");
        }
        else if(collision.gameObject.GetComponent<Actor>() != null)
        {
            Actor actor = collision.gameObject.GetComponent<Actor>();

            LogMsg("Other actor: " + actor.ActorName);

            if(actor is PlayerPawn && dealsDamage)
            {
                actor.TakeDamage(this, damageAmount, _owner);
                rb.velocity = Vector2.zero;
                rb.gravityScale = 0f;
                dealsDamage = false;
                GetComponent<Animator>().Play("MusicNoteDestroy");
            }
        }
    }

    public void DestroyNote()
    {
        Destroy(gameObject);
    }

    protected override void ProcessDamage(Actor DamageSource, float DamageValue, Controller DamageInstigator, DamageInfo EventInfo)
    {
        if(DamageInstigator is PlayerController)
        {
            rb.velocity = Vector2.zero;
            rb.gravityScale = 0f;
            dealsDamage = false;
            GetComponent<Animator>().Play("MusicNoteDestroy");
            base.ProcessDamage(DamageSource, DamageValue, DamageInstigator, EventInfo);
        }
    }
}
