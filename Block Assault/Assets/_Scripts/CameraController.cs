using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public float height;
    public float distance;
    public float time = 1f;

    void LateUpdate()
    {
        //we get the rotation angle of the player
        float angle = target.rotation.eulerAngles.y;

        //we rotate the camera with the same angle
        transform.rotation = Quaternion.Euler(new Vector3(0.0f, angle, 0.0f));

        //we calculate the cartesian coordinates using the polar coordinates
        Vector3 offsetPosition = new Vector3(-distance * Mathf.Sin(angle * Mathf.Deg2Rad), height, -distance * Mathf.Cos(angle * Mathf.Deg2Rad));

        //we use the player position plus the offset calculated above
        transform.position = Vector3.Lerp(target.position, target.position + offsetPosition, time);
    }
}
