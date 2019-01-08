using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    public GameObject mainMenuUI;
    public GameObject levelSelectUI;
    public GameObject settingsUI;
    public GameObject controlsUI;
    public GameObject imageLevel1;
    public GameObject imageLevel2;
    public GameObject imageLevel3;

    void Start()
    {
        mainMenuUI.SetActive(true);
        levelSelectUI.SetActive(false);
        settingsUI.SetActive(false);
        controlsUI.SetActive(false);
    }

    public void PlayLevel1()
    {
        Debug.Log("Playing Level 1...");
        SceneManager.LoadScene("Level 1");
    }

    public void PlayLevel2()
    {
        Debug.Log("Playing Level 2...");
        SceneManager.LoadScene("Level 2");
    }

    public void PlayLevel3()
    {
        Debug.Log("Playing game...");
        SceneManager.LoadScene("Level 3");
    }

    public void HoverImage1()
    {
        imageLevel1.SetActive(true);
        imageLevel2.SetActive(false);
        imageLevel3.SetActive(false);
    }

    public void HoverImage2()
    {
        imageLevel1.SetActive(false);
        imageLevel2.SetActive(true);
        imageLevel3.SetActive(false);
    }

    public void HoverImage3()
    {
        imageLevel1.SetActive(false);
        imageLevel2.SetActive(false);
        imageLevel3.SetActive(true);
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
