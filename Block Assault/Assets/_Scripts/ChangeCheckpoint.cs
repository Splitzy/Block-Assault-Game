using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCheckpoint : MonoBehaviour
{
    public GameObject checkpoint;
    public GameObject checkpoint2;
    public ParticleSystem confetti1;
    public ParticleSystem confetti2;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Destroy(checkpoint);
            Destroy(gameObject);
            confetti1.Play();
            confetti2.Play();
            checkpoint2.SetActive(true);
        } 
    }

}

