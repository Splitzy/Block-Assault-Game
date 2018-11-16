using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour {

    public GameObject checkpoint;
    public GameObject WinUI;
    GameObject player;

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

        }
        Destroy(gameObject);
    }
}
