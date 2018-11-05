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
        double fraction = ((double)time * 100) % 100;

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
        
	}
}
