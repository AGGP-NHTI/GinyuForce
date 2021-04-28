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

    [SerializeField]
    protected Actor _currentBoss = null;

    public Actor CurrentBoss
    {
        get { return _currentBoss; }
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

    protected FightInstance _instance;

    public float FightDuration
    {
        get { return _instance.fightTime; }
    }

    /// <summary>
    /// SET: Fightscore = 10 will INCREASE the fight score by 10, not set it to 10.
    /// </summary>
    public int FightScore
    {
        get { return _instance.playerScore; }
        set { _instance.playerScore += value; }
    }

    private void Awake()
    {
        if (Main)
        {
            LogMsg("Game Manager Singleton already exists in scene. Destroying copy at " + gameObject.name);
            Destroy(this);
        }
        Main = this;

        _instance = FindObjectOfType<FightInstance>();

        if (_instance)
        {
            _player = _instance.Player;

            _currentBoss = _instance.InstanceBoss;

            FightInstance.OnBossDown += GameWin;
        }
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

    protected void GameWin()
    {
        //Play the "ding ding" sound here.

        if(FightDuration >= 120f)
        {
            FightScore = -50;
        }
        else if(FightDuration >= 240f)
        {
            FightScore = -100;
        }
        else if(FightDuration >= 360f)
        {
            FightScore = -350;
        }

        switch (ThePlayer.CurrentHealth)
        {
            case 2:
                FightScore = -150;
                break;
            case 1:
                FightScore = -250;
                break;
        }

        PlayerInputPoller.Self.DisablePlayerInput();
        PlayerUIManager.Main.ToggleVictoryScreen(true);
    }

    public void QuitGame()
    {
        LogMsg("Application quit.");
        Application.Quit();
    }

    public void GameOver()
    {
        LogMsg("Game over man, game over!");
        _gameOver = true;
        PlayerUIManager.Main.ToggleGameOverScreen(true);
    }
}
