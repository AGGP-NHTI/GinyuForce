using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInstanceManager : Core
{
    public static GameInstanceManager Main = null;

    [SerializeField]
    protected Actor _player = null;

    public Actor ThePlayer
    {
        get { return _player; }
    }

    protected bool _gameIsPaused = false;

    public bool IsGamePaused()
    {
        return _gameIsPaused;
    }

    protected bool _gameOver = false;

    public bool IsGameOver()
    {
        return _gameOver;
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
        if (!IsGameOver())
        {
            if (_gameIsPaused)
            {
                Time.timeScale = 1f;
                _gameIsPaused = false;
                LogMsg("Game is unpaused");
                PlayerUIManager.Main.TogglePauseScreen(false);
            }
            else
            {
                Time.timeScale = 0f;
                _gameIsPaused = true;
                LogMsg("Game is paused");
                PlayerUIManager.Main.TogglePauseScreen(true);
            }
        }
    }

    public void QuitGame()
    {
        LogMsg("Application quit.");
        UnityEngine.Application.Quit();
    }

    public void GameOver()
    {
        LogMsg("Game over man, game over!");
        _gameOver = true;
        PlayerUIManager.Main.ToggleGameOverScreen(true);
    }
}
