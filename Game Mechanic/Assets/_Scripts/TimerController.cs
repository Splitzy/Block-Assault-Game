using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerController : MonoBehaviour {

    public Text timerLabel;

    private float time;
	
	// Update is called once per frame
	void Update()
    {
        time += Time.deltaTime;

        int minutes = (int)time / 60;
        int seconds = (int)time % 60;
        float fraction = ((float)time * 100f) % 100f;

        timerLabel.text = minutes.ToString() + ":" + seconds.ToString() + ":" + fraction.ToString();
	}
}
