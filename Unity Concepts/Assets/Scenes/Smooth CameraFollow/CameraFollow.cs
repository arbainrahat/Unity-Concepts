using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float smoothspeed = 0.125f;

    void FixedUpdate()
    {
        Vector3 desireposition = target.position + offset;
        Vector3 smoothposition = Vector3.Lerp(transform.position, desireposition, smoothspeed);
        transform.position = smoothposition;

        transform.LookAt(target);
    }
}
