﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour {

    public Text timerLabel;
    public GameObject star1;
    public GameObject star2;
    static bool isFinished = false;
    private int stars = 3;
    public float threeStarTime;
    public float twoStarTime;
    private float time;
	
	// Update is called once per frame
	void Update()
    {
        time += Time.deltaTime;

        int minutes = (int)time / 60;
        int seconds = (int)time % 60;
        double fraction = ((double)time * 100) % 100;

        if(isFinished == true)
        {
            return;
        }

        if (minutes < 10 && seconds < 10)
        {
            timerLabel.text = "0" + minutes.ToString() + ":" + "0" + seconds.ToString() + ":" + fraction.ToString("f0");
        }
        else if (minutes < 10)
        {
            timerLabel.text = "0" + minutes.ToString() + ":" + seconds.ToString() + ":" + fraction.ToString("f0");
        }
        else
        {
            timerLabel.text = minutes.ToString() + ":" + seconds.ToString() + ":" + fraction.ToString("f0");
        }

        if (Time.deltaTime <= threeStarTime)
        {
            timerLabel.color = Color.green;
        }
        else if (Time.deltaTime > threeStarTime && Time.deltaTime <= twoStarTime)
        {
            timerLabel.color = Color.yellow;
            star1.SetActive(false);
        }
        else
        {
            timerLabel.color = Color.red;
            star1.SetActive(false);
            star2.SetActive(false);
        }
    }

    public static void Finish()
    {
        isFinished = true;
    }
}
