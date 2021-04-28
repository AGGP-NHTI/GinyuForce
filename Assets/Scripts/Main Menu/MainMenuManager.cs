using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : Core
{
    protected GameObject currentMenu;

    public GameObject MainScreen;

    public GameObject TutorialScreen;

    private void Start()
    {
        currentMenu = MainScreen;
    }

    public void GoToScreen(GameObject targetScreen)
    {
        currentMenu.SetActive(false);

        currentMenu = targetScreen;

        currentMenu.SetActive(true);
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("BossFightTest");
    }

    public void QuitGame()
    {
        LogMsg("App quit.");
        Application.Quit();
    }
}
