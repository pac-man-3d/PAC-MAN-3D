using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
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
        
        if(transform.rotation.eulerAngles.y>= 180 && transform.rotation.eulerAngles.y <181 )
        {
             offset = new Vector3(0,200,150);
        }
        if(transform.rotation.eulerAngles.y>= 90 && transform.rotation.eulerAngles.y <91 )
        {
            offset = new Vector3 (-150,200,0);
        }
        if(transform.rotation.eulerAngles.y>= 0 && transform.rotation.eulerAngles.y <1 )
        {
            offset = new Vector3 (0,200,-150);
        }
        if(transform.rotation.eulerAngles.y >= 270 && transform.rotation.eulerAngles.y <271)
        {
           offset = new Vector3 (150,200,0);
        }
    
}

}   