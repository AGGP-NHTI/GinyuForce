﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnSpriteCont : Core
{
    /// <summary>
    /// The level of transparency the sprite will reach when flashing. Default is 0.4, should not go below 0.2 or above 0.8
    /// </summary>
    public float flashTransparentLevel = 0.4f;

    protected SpriteRenderer spriteTexture;

    protected virtual void Awake()
    {
        spriteTexture = gameObject.GetComponent<SpriteRenderer>();

        if (spriteTexture == null)
        {
            LogMsg("No sprite texture found on " + ObjectName);
        }
    }

    /// <summary>
    /// Public method that flashes the sprite "on" or "off"
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
