using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public static bool isPaused = false;
    public GameObject pauseMenuUI;
    public GameObject settingsUI;
    public GameObject controlsUI;

    public int currentScene;

    private void Start()
    {
        pauseMenuUI.SetActive(false);
        settingsUI.SetActive(false);
        controlsUI.SetActive(false);

        currentScene = SceneManager.GetActiveScene().buildIndex;
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
	}

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        settingsUI.SetActive(false);
        controlsUI.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        PlayerPrefs.DeleteAll();
        Application.Quit();
    }

    public void LoadOptions()
    {
        settingsUI.SetActive(true);
        pauseMenuUI.SetActive(false);
    }

    public void Return()
    {
        settingsUI.SetActive(false);
        pauseMenuUI.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(currentScene);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void LoadControls()
    {
        settingsUI.SetActive(false);
        controlsUI.SetActive(true);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene(currentScene + 1);
    }

    public void ReturnFromControls()
    {
        settingsUI.SetActive(true);
        controlsUI.SetActive(false);
    }
}
