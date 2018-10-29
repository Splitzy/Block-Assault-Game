using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    public List<WheelInfo> wheelInfo;
    public float maxTorque;
    public float maxAngle;
    public float brakeTorque;
    public Transform car;
    //public Rigidbody rb;

    public void Start()
    {
        car = transform;
        //rb = GetComponent<Rigidbody>();
    }

    public void FixedUpdate()
    {
        float motor = maxTorque * Input.GetAxis("Vertical");
        float steering = maxAngle * Input.GetAxis("Horizontal");

        if (Input.GetKey(KeyCode.Space))
        {
            brakeTorque = 1000000;
        }
        else
        {
            brakeTorque = 0;
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
                wheel.leftWheel.motorTorque = motor * 2f;
                wheel.rightWheel.motorTorque = motor * 2f;
                wheel.leftWheel.brakeTorque = brakeTorque;
                wheel.rightWheel.brakeTorque = brakeTorque;
                //rb.AddForce(new Vector3(0f, motor, 0f));    
            }

            if (Input.GetKey(KeyCode.R))
            {
                car.position = new Vector3(0.0f, 0.6f, 0.0f);
                car.rotation = new Quaternion(0.0f, 0.0f, 0.0f, 0.0f);
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