using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishLine : MonoBehaviour {

    public GameObject checkpoint;
    public GameObject WinUI;
    public Text starTxt;
    public ParticleSystem confetti1;
    public ParticleSystem confetti2;
    //GameObject player;
    [SerializeField]
    private GameObject playerCamera;
    [SerializeField]
    private GameObject winCamera;

    //void Start()
    //{
    //    player = GameObject.FindWithTag("Player");
    //}

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            playerCamera.SetActive(false);
            winCamera.SetActive(true);
            confetti1.Play();
            confetti2.Play();
            WinUI.SetActive(true);
            Destroy(checkpoint);
            TimerController.Finish();
            if (TimerController.time <= TimerController.threeStarTime)
            {
                starTxt.text = "YOU WON 3 STARS!";
            }
            else if (TimerController.time > TimerController.threeStarTime && TimerController.time <= TimerController.twoStarTime)
            {
                starTxt.text = "YOU WON 2 STARS!";
            }
            else
            {
                starTxt.text = "YOU WON 1 STAR!";
            }
        }
        Destroy(gameObject);
    }


}
