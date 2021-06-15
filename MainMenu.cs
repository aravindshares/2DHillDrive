using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    [SerializeField]
    private GameObject MainMenuWindow, OptionsMenuWindow;
    public void OptionsMenu()
    {
        MainMenuWindow.SetActive(false);
        OptionsMenuWindow.SetActive(true);
    }
    public void BackButton()
    {
        MainMenuWindow.SetActive(true);
        OptionsMenuWindow.SetActive(false);
    }
    public void Play(int scenenumber)
    {
        scenenumber = 1;
        SceneManager.LoadScene(scenenumber);
    }
    public void Back(int scenenumber)
    {
        scenenumber = 0;
        SceneManager.LoadScene(scenenumber);
    }
    public void EndGame()
    {
        Application.Quit();
    }

}
