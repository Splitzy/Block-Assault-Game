﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public List<WheelInfo> wheelInfo;
    public float maxTorque;
    public float maxAngle;
    public float brakeTorque;
    public Transform car;
    public ParticleSystem smokeL;
    public ParticleSystem smokeR;

    public AudioSource carSource;

    [SerializeField]
    private Rigidbody rb;

    public void Start()
    {
        car = transform;
        rb = GetComponent<Rigidbody>();
    }

    public void FixedUpdate()
    {
        Debug.Log(Input.GetAxis("Vertical"));
        float motor = maxTorque * Input.GetAxis("Vertical");
        float steering = maxAngle * Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            brakeTorque = 1000000;
            smokeL.Play();
            smokeR.Play();
            carSource.Play();
        }
        else
        {
            brakeTorque = 0;
            smokeL.Stop();
            smokeR.Stop();
            carSource.Stop();
        }

        foreach (WheelInfo wheel in wheelInfo)
        {
            if (wheel.steering)
            {
                wheel.leftWheel.steerAngle = steering;
                wheel.rightWheel.steerAngle = steering;
            }

            if (wheel.motor)
            {
                wheel.leftWheel.motorTorque = motor * 1.5f;
                wheel.rightWheel.motorTorque = motor * 1.5f;
                wheel.leftWheel.brakeTorque = brakeTorque;
                wheel.rightWheel.brakeTorque = brakeTorque;
            }
        }
    }
    
}

[System.Serializable]
public class WheelInfo
{
    public WheelCollider leftWheel;
    public WheelCollider rightWheel;
    public bool motor;
    public bool steering;
}