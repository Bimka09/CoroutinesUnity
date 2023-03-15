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
        Settings
    }

    public CanvasGroup mainScreen;
    public CanvasGroup settingsScreen;
    [SerializeField] private PlaySound _soundEffect;
    
    void Start()
    {
        SetCurrentScreen(Screen.Main);
    }

    private void SetCurrentScreen(Screen screen)
    {
        Utility.SetCanvasGroupEnabled(mainScreen, screen == Screen.Main);
        Utility.SetCanvasGroupEnabled(settingsScreen, screen == Screen.Settings);
    }

    public void StartNewGame()
    {
        if (_soundEffect) _soundEffect.PlaySoundEffect("Click");
        SetCurrentScreen(Screen.None);
        LoadingScreen.instance.LoadScene("Game");
    }

    public void OpenSettings()
    {
        if (_soundEffect) _soundEffect.PlaySoundEffect("Click");
        SetCurrentScreen(Screen.Settings);
    }

    public void CloseSettings()
    {
        if (_soundEffect) _soundEffect.PlaySoundEffect("Click");
        SetCurrentScreen(Screen.Main);
    }

    public void ExitGame()
    {
        if (_soundEffect) _soundEffect.PlaySoundEffect("Click");
        Application.Quit();
    }
}
