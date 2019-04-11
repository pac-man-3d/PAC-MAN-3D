using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTest : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.2f;
    public Vector3 offset;

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 optimalePosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp (transform.position, optimalePosition, smoothSpeed);
        transform.position = smoothedPosition;

        transform.LookAt(target);
        transform.rotation = Quaternion.Euler (target.rotation.eulerAngles.x+40,target.rotation.eulerAngles.y-90, target.rotation.eulerAngles.z);
}
}   