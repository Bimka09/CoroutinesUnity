using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    enum Screen
    {
        None,
        Main,
        Settings,
        ChooseSide,
    }

    public CanvasGroup mainScreen;
    public CanvasGroup settingsScreen;
    public CanvasGroup chooseSideScreen;
    
    void Start()
    {
        SetCurrentScreen(Screen.Main);
    }

    private void SetCurrentScreen(Screen screen)
    {
        Utility.SetCanvasGroupEnabled(mainScreen, screen == Screen.Main);
        Utility.SetCanvasGroupEnabled(settingsScreen, screen == Screen.Settings);
        Utility.SetCanvasGroupEnabled(chooseSideScreen, screen == Screen.ChooseSide);
    }

    public void StartNewGame()
    {
        SetCurrentScreen(Screen.ChooseSide);
    }

    public void OpenSettings()
    {
        SetCurrentScreen(Screen.Settings);
    }

    public void ChoosePoliceSide()
    {
        SetCurrentScreen(Screen.None);
        SceneManager.LoadScene("GamePolice");
    }
    public void ChooseHooliganSide()
    {
        SetCurrentScreen(Screen.None);
        SceneManager.LoadScene("GameHooligan");
    }
    public void CloseSettings()
    {
        SetCurrentScreen(Screen.Main);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
