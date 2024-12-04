using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public Transform LaserStart;
    public float laserRange = 20f;

    private Vector3 laserDirection;
    //private Vector3 laserPosition;

    private void Start()
    {
        laserDirection = transform.forward;
    }

    void Update()
    {

    }


}
