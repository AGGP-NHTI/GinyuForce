using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInstanceManager : Core
{
    public static GameInstanceManager Main = null;

    private void Awake()
    {
        if (Main)
        {
            LogMsg("Game Manager Singleton already exists in scene. Destroying copy at " + gameObject.name);
            Destroy(this);
        }
        Main = this;
    }

    public void GameOver()
    {
        LogMsg("Game over man, game over!");
    }
}
