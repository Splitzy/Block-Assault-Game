using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {
    public Transform checkpoint;
    GameObject player;

	// Use this for initialization
	void Start()
    {
        player = GameObject.FindWithTag("Player");
	}
	
	// Update is called once per frame
	void OnTriggerEnter (Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            player.transform.position = checkpoint.position;
            player.transform.rotation = checkpoint.rotation;
        }
    }

}
