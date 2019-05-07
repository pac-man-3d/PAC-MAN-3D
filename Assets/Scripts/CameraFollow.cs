using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.2f;
    public Vector3 offset;
    public float rotSpeed;

    // Update is called once per frame
    private void Start()
    {
        offset += offset;
    }
    void FixedUpdate()
    {


        Vector3 optimalePosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, optimalePosition, smoothSpeed);
        transform.position = smoothedPosition;


        transform.rotation = Quaternion.Slerp(Quaternion.Euler(new Vector3(25, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z)), target.rotation, rotSpeed * Time.deltaTime);


        //transform.rotation = Quaternion.Slerp(transform.rotation, target.rotation, rotSpeed * Time.deltaTime);



        if (transform.rotation.eulerAngles.y >= 10 && transform.rotation.eulerAngles.y < 120)
        {
            offset = new Vector3(-400, 200, 0);
            Debug.Log("right");


        }
        if (transform.rotation.eulerAngles.y >= 0 && transform.rotation.eulerAngles.y < 50 || transform.rotation.eulerAngles.y > 320)
        {
            offset = new Vector3(0, 200, -400);
            Debug.Log("front");

        }

        if (transform.rotation.eulerAngles.y >= 120 && transform.rotation.eulerAngles.y < 220)
        {
            offset = new Vector3(0, 200, 400);
            Debug.Log("back");
        }
        if (transform.rotation.eulerAngles.y >= 240 && transform.rotation.eulerAngles.y < 300)
        {
            offset = new Vector3(400, 200, 0);
            Debug.Log("left");


        }
    }
}
