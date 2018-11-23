using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    public GameObject mainMenuUI;
    public GameObject levelSelectUI;
    public GameObject settingsUI;

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
