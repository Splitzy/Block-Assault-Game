using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
	

	public void PlayGame()
    {
        Debug.Log("Playing game...");
        SceneManager.LoadScene("Level 1");
    }

    public void LoadOptions()
    {
        Debug.Log("Loading Options");
    }

    public void LoadLevelSelect()
    {
        Debug.Log("Loading Level Select");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game...");
        Application.Quit();
    }
}
