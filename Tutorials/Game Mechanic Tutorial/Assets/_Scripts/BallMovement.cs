using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    [SerializeField]
    private GameObject prefabDot;
    public float force = 10;
    private GameObject[] dotArray;
    private Camera cam;
    private Transform ball;
    private Vector3 direction;
    private float gravity = 9.81f;
    private Rigidbody projRigid;

    // Use this for initialization
	void Start()
    {
        dotArray = new GameObject[10];
        cam = Camera.main;
        ball = transform;
        projRigid = ball.GetComponent<Rigidbody>();

        for ( int i = 0; i < dotArray.Length; i++)
        {
            GameObject tempObject = Instantiate(prefabDot);

            dotArray[i] = tempObject;

            dotArray[i].SetActive(false);

        }
	}
	
	// Update is called once per frame
	void Update()
    {
        
        if (Input.GetMouseButton(0))
        {
            Vector3 projPos = cam.WorldToScreenPoint(ball.position);
            projPos.z = 0;
            direction = (projPos - Input.mousePosition).normalized;

            Aim();
        }

        if(Input.GetMouseButtonUp(0))
        {
            projRigid.AddForce(direction * force, ForceMode.Impulse);

            for (int i = 0; i < dotArray.Length; i++)
            {
                dotArray[i].SetActive(false);
            }
        }

    }

    private void Aim()
    {
        float sx = direction.x * force;
        float sy = direction.y * force;

        for (int i = 0; i < dotArray.Length; i++)
        {
            float t = i * 0.1f;

            float dx = sx * t;
            float dy = (sy * t) - (0.5f * gravity * (t * t));

            dotArray[i].transform.position = new Vector3(ball.position.x + dx, ball.position.y + dy, ball.position.z);

            dotArray[i].SetActive(true);
        }
    }
}
