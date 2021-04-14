using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpriteCont : PawnSpriteCont
{
    public SpriteRenderer topHalf = null;

    public SpriteRenderer bottomHalf = null;

    protected override void Awake()
    {
        if(!topHalf || !bottomHalf)
        {
            LogMsg("Player Sprite is missing its top or bottom half sprite reference!");
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
            topHalf.color = new Color(
                topHalf.color.r,
                topHalf.color.g,
                topHalf.color.b,
                flashTransparentLevel
                );
            bottomHalf.color = new Color(
                bottomHalf.color.r,
                bottomHalf.color.g,
                bottomHalf.color.b,
                flashTransparentLevel
                );
        }
        else
        {
            topHalf.color = new Color(
                topHalf.color.r,
                topHalf.color.g,
                topHalf.color.b,
                1f
                );
            bottomHalf.color = new Color(
                bottomHalf.color.r,
                bottomHalf.color.g,
                bottomHalf.color.b,
                1f
                );
        }

        isFlashing = toggle;
    }
}
