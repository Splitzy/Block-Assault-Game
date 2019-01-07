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
    public ParticleSystem smokeL;
    public ParticleSystem smokeR;
    public AudioSource carSource;
    
    public float EngineRev { get; private set; }
    public float AccelInput { get; private set; }

    private Rigidbody rb;
    private readonly float topSpeed = 150;

    public void Start()
    {
        car = transform;
        rb = GetComponent<Rigidbody>();
        EngineRev = Random.Range(0.1f, 0.5f);
    }

    public void FixedUpdate()
    {
        float motor = maxTorque * Input.GetAxis("Vertical");
        float steering = maxAngle * Input.GetAxis("Horizontal");

        float accel = Input.GetAxis("Vertical");

        AccelInput = accel = Mathf.Clamp(accel, 0, 1);

        if (motor > topSpeed)
        {
            motor = topSpeed;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            brakeTorque = 100000000;
            smokeL.Play();
            smokeR.Play();
            AudioPlay();
        }
        else
        {
            brakeTorque = 0;
            smokeL.Stop();
            smokeR.Stop();
            AudioStop();
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

    private void AudioPlay()
    {
        if(!carSource.isPlaying)
        {
            carSource.Play();
        }
    }

    private void AudioStop()
    {
        if(carSource.isPlaying)
        {
            carSource.Stop();
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