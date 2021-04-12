using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInstanceManager : Core
{
    public static GameInstanceManager Main = null;

    protected bool _gameIsPaused = false;

    public bool IsGamePaused()
    {
        return _gameIsPaused;
    }

    private void Awake()
    {
        if (Main)
        {
            LogMsg("Game Manager Singleton already exists in scene. Destroying copy at " + gameObject.name);
            Destroy(this);
        }
        Main = this;
    }

    public void PauseUnpause()
    {
        if (_gameIsPaused)
        {
            Time.timeScale = 1f;
            _gameIsPaused = false;
            LogMsg("Game is unpaused");
        }
        else
        {
            Time.timeScale = 0f;
            _gameIsPaused = true;
            LogMsg("Game is paused");
        }
    }

    public void GameOver()
    {
        LogMsg("Game over man, game over!");
    }
}
