using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    
    public float smoothSpeed = 0.2f;
    public Vector3 offset;

    void LateUpdate()
    {
        Vector3 optimalePosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp (transform.position, optimalePosition,smoothSpeed);
        transform.position = smoothedPosition;
    }
}
