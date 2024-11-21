using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour
{
    public Vector3 direction = Vector3.right; // first direction of the lazer
    public float speed = 5f; // speed of the lazer
    public LineRenderer lineRenderer; // lineRenderer to see the lazer 

    void Update()
    {
        transform.Translate(direction*speed*Time.deltaTime); 

        if (lineRenderer != null )
        {
            lineRenderer.SetPosition(0, transform.position);
            lineRenderer.SetPosition(1, transform.position + (Vector3)direction * 10f); // Length of the lazer
        }
    }


}
