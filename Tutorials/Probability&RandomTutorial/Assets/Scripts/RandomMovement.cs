using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMovement : MonoBehaviour {

    float xValue = 0f;
    float zValue = 0f;
    private Transform cube;

	void Start()
    {
        cube = transform;
	}

    void Update()
    {
        //IfStatements();
        //Array();
        //Float();
        Curve();
        //Vector();
    }

    void IfStatements()
    {
        int num = Random.Range(0,4);
        if (num == 1)
        {
            xValue = 0.1f;
        }
        else if (num == 2)
        {
            xValue = -0.1f;
        }
        else if (num == 3)
        {
            zValue = 0.1f;
        }
        else
        {
            zValue = -0.1f;
        }

        cube.position += new Vector3(xValue, 0.0f, zValue);
    }

    void Array()
    {
        int[] num = new int[5];

        num[0] = 0;
        num[1] = 1;
        num[2] = 2;
        num[3] = 3;
        num[4] = 0;

        int randomIndex = Random.Range(0, 5);
        int randomValue = num[randomIndex];

        if (randomValue == 0)
        {
            xValue = -0.1f;
        }
        else if (randomValue == 1)
        {
            xValue = 0.1f;
        }
        else if (randomValue == 2)
        {
            zValue = 0.1f;
        }
        else if (randomValue == 3)
        {
            zValue = -0.1f;
        }

        cube.position += new Vector3(xValue, 0.0f, zValue);
    }

    void Float()
    {
        float random = Random.Range(0.0f, 1.0f);

        if (random < 0.4f)
        {
            xValue = -0.1f;
        }
        else if (random < 0.6f)
        {
            xValue = 0.1f;
        }
        else if (random < 0.8f)
        {
            zValue = 0.1f;
        }
        else 
        {
            zValue = -0.1f;
        }

        cube.position += new Vector3(xValue, 0.0f, zValue);
    }

    void Curve()
    {
        float curveValue = Random.Range(0.0f, 1.0f);
        float randomValue;
    }

    void Vector()
    {
        xValue = Random.Range(-0.1f, 0.1f);
        zValue = Random.Range(-0.1f, 0.1f);
        cube.position += new Vector3(xValue, 0.0f, zValue);
    }
}
