using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PawnSpriteCont : Core
{
    /// <summary>
    /// The level of transparency the sprite will reach when flashing. Default is 0.4, should not go below 0.2 or above 0.8
    /// </summary>
    public float flashTransparentLevel = 0.4f;

    public bool isFlashing = false;

    protected SpriteRenderer spriteTexture;

    public Animator SpriteAnimator;

    protected virtual void Awake()
    {
        spriteTexture = gameObject.GetComponent<SpriteRenderer>();

        if (spriteTexture == null)
        {
            LogMsg("No sprite texture found on " + ObjectName);
        }

        if (!SpriteAnimator) { SpriteAnimator = gameObject.GetComponent<Animator>(); }
    }

    /// <summary>
    /// Public method that flashes the sprite "on" or "off" between solid and transparent.
    /// </summary>
    /// <param name="toggle">If true, make sprite semi transparent. If false, make completely opaque.</param>
    public virtual void FlashSprite(bool toggle)
    {
        if (toggle)
        {
            spriteTexture.color = new Color(
                spriteTexture.color.r,
                spriteTexture.color.g,
                spriteTexture.color.b,
                flashTransparentLevel
                );
        }
        else
        {
            spriteTexture.color = new Color(
                spriteTexture.color.r,
                spriteTexture.color.g,
                spriteTexture.color.b,
                1f
                );
        }
    }
}
