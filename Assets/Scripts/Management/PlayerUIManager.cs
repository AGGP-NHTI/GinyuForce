using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUIManager : Core
{
    public static PlayerUIManager Main = null;

    [SerializeField]
    protected GameObject PauseScreen = null;

    [SerializeField]
    protected GameObject GameOverScreen = null;

    [SerializeField]
    protected PlayerHealthbar _playerHealthbar = null;

    public GameObject PlayerHeartSprite;

    [SerializeField]
    protected BullHealthbar _bullHealthbar = null;

    private void Awake()
    {
        if (Main)
        {
            LogMsg("A PlayerUIManager already exists. Deleting new duplicate instance from " + gameObject.name);
            Destroy(this);
        }

        Main = this;
    }

    /// <summary>
    /// Toggles the pause screen UI based on the input boolean
    /// </summary>
    /// <param name="toggleMode">Boolean that controls the pause UI. False will disable the pause screen, true will enable it.</param>
    public void TogglePauseScreen(bool toggleMode)
    {
        PauseScreen.SetActive(toggleMode);
    }

    /// <summary>
    /// Toggles the game over screen UI based on the input boolean
    /// </summary>
    /// <param name="toggleMode">Boolean that controls the gameover UI. False will disable the gameover screen, true will enable it.</param>
    public void ToggleGameOverScreen(bool toggleMode)
    {
        GameOverScreen.SetActive(toggleMode);
    }

    public void UpdatePlayerHearts()
    {
        _playerHealthbar.UpdateHearts();
    }
}
