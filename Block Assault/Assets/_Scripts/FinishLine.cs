using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour {

    public GameObject checkpoint;
    public GameObject winUI;
    public GameObject pauseUI;
    public Text starTxt;
    public ParticleSystem confetti1;
    public ParticleSystem confetti2;
    public Button nxtLevelButton;
    //GameObject player;
    [SerializeField]
    private GameObject playerCamera;
    [SerializeField]
    private GameObject winCamera;
    [SerializeField]
    private int nextScene;

    string winTxt;

    void Start()
    {
        nextScene = SceneManager.GetActiveScene().buildIndex + 1;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(pauseUI);
            playerCamera.SetActive(false);
            winCamera.SetActive(true);
            confetti1.Play();
            confetti2.Play();
            winUI.SetActive(true);
            Destroy(checkpoint);
            TimerController.Finish();

            if (TimerController.time <= TimerController.threeStarTime)
            {
                winTxt = "YOU WON 3 STARS! Advance to the next level!";
                nxtLevelButton.interactable = true;
                Win(winTxt);
            }
            else if (TimerController.time > TimerController.threeStarTime && TimerController.time <= TimerController.twoStarTime)
            {
                winTxt = "You won 2 stars! Advance to the next level!";
                nxtLevelButton.interactable = true;
                Win(winTxt);
            }
            else
            {
                starTxt.text = "YOU WON 1 STAR! Try again!";
                nxtLevelButton.interactable = false;
            }

            Destroy(gameObject);
        }
    }

    void Win(string s)
    {
        if(SceneManager.GetActiveScene().buildIndex == 6)
        {
            starTxt.text = "Game Complete";
            nxtLevelButton.interactable = false;
        }
        else
        {
            starTxt.text = s;
            if (nextScene > PlayerPrefs.GetInt("levelAt"))
            {
                PlayerPrefs.SetInt("levelAt", nextScene);
            }
        }
    }


}
