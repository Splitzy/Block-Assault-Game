using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public bool shouldRotate = true;

    public Transform target;
    public float distance;
    public float height;
    public float heightDamp = 2.0f;
    public float rotationDamp = 3.0f;
    float angle;
    float wantedHeight;
    float currentAngle;
    float currentHeight;
    Quaternion currentRot;

    void LateUpdate()
    {
        if(target)
        {
            angle = target.eulerAngles.y;
            wantedHeight = target.position.y + height;
            currentAngle = transform.eulerAngles.y;
            currentHeight = transform.position.y;

            currentAngle = Mathf.LerpAngle(currentAngle, angle, rotationDamp * Time.deltaTime);
            currentHeight = Mathf.Lerp(currentHeight, wantedHeight, heightDamp * Time.deltaTime);

            currentRot = Quaternion.Euler(0, currentAngle, 0);

            transform.position = target.position;
            transform.position -= currentRot * Vector3.forward * distance;

            transform.position = new Vector3(transform.position.x, currentHeight, transform.position.z);
            if(shouldRotate)
            {
                transform.LookAt(target);
            }
        }
    }
}
