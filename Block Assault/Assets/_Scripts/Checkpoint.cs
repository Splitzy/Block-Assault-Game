using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {
    public Transform checkpoint;
    GameObject player;
    public Rigidbody rb;

	// Use this for initialization
	void Start()
    {
        player = GameObject.FindWithTag("Player");
	}

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            Reset();
        }
    }

    // Update is called once per frame
    void OnTriggerEnter (Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Reset();
        }
    }

    void Reset()
    {
        player.transform.position = checkpoint.position;
        player.transform.rotation = checkpoint.rotation;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }

}
