using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Interaction : MonoBehaviour
{
    [SerializeField]
    GameObject pause, resume, restart, exit, options, optionsPanel, bike, gamepad;
 
    public void PauseAction()
    {   
        Time.timeScale = 0;
        pause.SetActive(false);
        gamepad.SetActive(false);
        bike.SetActive(false);
        resume.SetActive(true);
        restart.SetActive(true);
        options.SetActive(true);
        exit.SetActive(true);
    } 
    public void ResumeAction()
    {
        Time.timeScale = 1;
        pause.SetActive(true);
        gamepad.SetActive(true);
        bike.SetActive(true);
        resume.SetActive(false);
        restart.SetActive(false);
        options.SetActive(false);
        exit.SetActive(false);
    }
    public void OptionsMenu()
    {
        optionsPanel.SetActive(true);
        resume.SetActive(false);
        restart.SetActive(false);
        options.SetActive(false);
        exit.SetActive(false);
    }
    public void OptionsMenuBack()
    {
        optionsPanel.SetActive(false);
        resume.SetActive(true);
        restart.SetActive(true);
        options.SetActive(true);
        exit.SetActive(true);
    }
    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+0);
    }
    public void Exit()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
    }
}

