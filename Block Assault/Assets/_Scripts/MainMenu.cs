using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    public GameObject mainMenuUI, levelSelectUI, settingsUI, controlsUI;
    public GameObject[] imageLevel;

    void Start()
    {
        mainMenuUI.SetActive(true);
        levelSelectUI.SetActive(false);
        settingsUI.SetActive(false);
        controlsUI.SetActive(false);
    }

    public void PlayLevel1()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void PlayLevel2()
    { 
        SceneManager.LoadScene("Level 2");
    }

    public void PlayLevel3()
    {
        SceneManager.LoadScene("Level 3");
    }

    public void PlayLevel4()
    {
        SceneManager.LoadScene("Level 4");
    }

    public void PlayLevel5()
    {
        SceneManager.LoadScene("Level 5");
    }

    public void HoverImage1()
    {
        int index = 0;

        for(int i = 0; i < imageLevel.Length; i++)
        {
            if (i == index)
            {
                imageLevel[i].SetActive(true);
            }
            else
            {
                imageLevel[i].SetActive(false);
            }
        }

    }

    public void HoverImage2()
    {
        int index = 1;

        for (int i = 0; i < imageLevel.Length; i++)
        {
            if (i == index)
            {
                imageLevel[i].SetActive(true);
            }
            else
            {
                imageLevel[i].SetActive(false);
            }
        }
    }

    public void HoverImage3()
    {
        int index = 2;

        for (int i = 0; i < imageLevel.Length; i++)
        {
            if (i == index)
            {
                imageLevel[i].SetActive(true);
            }
            else
            {
                imageLevel[i].SetActive(false);
            }
        }
    }

    public void HoverImage4()
    {
        int index = 3;

        for (int i = 0; i < imageLevel.Length; i++)
        {
            if (i == index)
            {
                imageLevel[i].SetActive(true);
            }
            else
            {
                imageLevel[i].SetActive(false);
            }
        }
    }

    public void HoverImage5()
    {
        int index = 4;

        for (int i = 0; i < imageLevel.Length; i++)
        {
            if (i == index)
            {
                imageLevel[i].SetActive(true);
            }
            else
            {
                imageLevel[i].SetActive(false);
            }
        }
    }

    public void LoadOptions()
    {
        settingsUI.SetActive(true);
        mainMenuUI.SetActive(false);
    }

    public void LoadLevelSelect()
    {
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
        levelSelectUI.SetActive(false);
        settingsUI.SetActive(false);
        mainMenuUI.SetActive(true);
    }

    public void QuitGame()
    {
        PlayerPrefs.DeleteAll();
        Application.Quit();
    }
}
