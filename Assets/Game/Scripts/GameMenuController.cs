using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenuController : MonoBehaviour
{
    enum Screen
    {
        None,
        gameActionInterface,
        Pause,
    }

    public CanvasGroup gameActionInterfaceScreen;
    public CanvasGroup PauseScreen;
    
    void Start()
    {
        SetCurrentScreen(Screen.gameActionInterface);
    }

    private void SetCurrentScreen(Screen screen)
    {
        Utility.SetCanvasGroupEnabled(gameActionInterfaceScreen, screen == Screen.gameActionInterface);
        Utility.SetCanvasGroupEnabled(PauseScreen, screen == Screen.Pause);
    }

    public void StartNewGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ContinueGame()
    {
        SetCurrentScreen(Screen.gameActionInterface);
    }
    public void ExitToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void SetPause()
    {
        SetCurrentScreen(Screen.Pause);
    }
}
