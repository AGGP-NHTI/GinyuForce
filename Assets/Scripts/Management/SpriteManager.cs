using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteManager : Core
{
    public static SpriteManager Main;

    public BullSprites bullSprites;

    private void Awake()
    {
        if (Main)
        {
            Destroy(this);
        }

        Main = this;

        bullSprites = gameObject.GetComponent<BullSprites>();
    }
}
