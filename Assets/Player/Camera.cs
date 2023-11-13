using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform focus;
    public float height = 20.0f;
    public float smoothSpeed = 0.125f;
    Vector3 focalPoint;
    Vector3 velocity;

    void Update()
    {
        if (focus != null)
        {
            focalPoint = focus.position + Vector3.up * height;
        }

        transform.position = Vector3.SmoothDamp(transform.position, focalPoint, ref velocity, smoothSpeed);
    }
}
