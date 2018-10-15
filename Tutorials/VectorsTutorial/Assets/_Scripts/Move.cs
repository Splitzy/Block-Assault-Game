using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {


    private Transform cubeTransform;

    [Range(0,1)]
    public float speed = 0f;

	// Use this for initialization
	void Start()
    {
        cubeTransform = transform;
	}
	
	// Update is called once per frame
	void Update()
    {
        cubeTransform.position = cubeTransform.position + cubeTransform.forward * speed;
	}
}
