using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    private Vector3 velocity;

    void LateUpdate()
    {
        if(this.target != null)
        {
            this.transform.position = Vector3.SmoothDamp(this.transform.position, this.target.position + this.offset, ref this.velocity, this.smoothSpeed);
        }
    }
}
