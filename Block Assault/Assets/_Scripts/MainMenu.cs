using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    public GameObject mainMenuUI;
    public GameObject levelSelectUI;
    public GameObject settingsUI;
    public GameObject controlsUI;

    void Start()
    {
        mainMenuUI.SetActive(true);
        levelSelectUI.SetActive(false);
        settingsUI.SetActive(false);
        controlsUI.SetActive(false);
    }

    public void PlayGame()
    {
        Debug.Log("Playing game...");
        SceneManager.LoadScene("Level 1");
    }

    public void LoadOptions()
    {
        Debug.Log("Loading Options");
        settingsUI.SetActive(true);
        mainMenuUI.SetActive(false);
    }

    public void LoadLevelSelect()
    {
        Debug.Log("Loading Level Select");
        mainMenuUI.SetActive(false);
        levelSelectUI.SetActive(true);
    }

    public void LoadControls()
    {
        settingsUI.SetActive(false);
        controlsUI.SetActive(true);
    }

    public void ReturnFromControls()
    {
        settingsUI.SetActive(true);
        controlsUI.SetActive(false);
    }

    public void Return()
    {
        Debug.Log("Returning to main menu");
        levelSelectUI.SetActive(false);
        settingsUI.SetActive(false);
        mainMenuUI.SetActive(true);
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}
