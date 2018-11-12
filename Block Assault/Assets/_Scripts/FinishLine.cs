using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLine : MonoBehaviour {

    public GameObject checkpoint;
    public GameObject WinUI;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(checkpoint);
            WinUI.SetActive(true);

        }
        Destroy(gameObject);
    }
}
