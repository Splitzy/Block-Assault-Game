using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishLine : MonoBehaviour {

    public GameObject checkpoint;
    public GameObject WinUI;
    GameObject player;
    public Text starTxt;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(checkpoint);
            WinUI.SetActive(true);
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
