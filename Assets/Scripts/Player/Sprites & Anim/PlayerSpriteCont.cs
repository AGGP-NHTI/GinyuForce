using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpriteCont : PawnSpriteCont
{
    public SpriteRenderer sprite = null;

    protected override void Awake()
    {
        if(!sprite)
        {
            LogMsg("Player Sprite is missing the sprite!");
        }
    }

    /// <summary>
    /// Public method that flashes the sprite "on" or "off"
    /// </summary>
    /// <param name="toggle">If true, make sprite semi transparent. If false, make completely opaque.</param>
    public override void FlashSprite(bool toggle)
    {
        if (toggle)
        {
            sprite.color = new Color(
                sprite.color.r,
                sprite.color.g,
                sprite.color.b,
                flashTransparentLevel
                );
        }
        else
        {
            sprite.color = new Color(
                sprite.color.r,
                sprite.color.g,
                sprite.color.b,
                1f
                );
        }

        isFlashing = toggle;
    }
}
