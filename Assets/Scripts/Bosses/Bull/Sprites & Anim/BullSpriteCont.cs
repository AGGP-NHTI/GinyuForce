using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BullSpriteCont : PawnSpriteCont
{
    public override void FlashSprite(bool toggle)
    {
        if (!isFlashing)
        {
            StartCoroutine(FlashBullSprite());
        }
    }

    IEnumerator FlashBullSprite()
    {
        spriteTexture.color = Color.red;
        isFlashing = true;

        yield return new WaitForSeconds(0.3f);

        spriteTexture.color = Color.white;
        isFlashing = false;
    }
}
