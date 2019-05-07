using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacMan : MonoBehaviour {
    public float moveSpeed = 5.0f;


    void Start(){}
	void Update()
	{
		Vector3 pos = Vector3.forward * moveSpeed * Time.deltaTime*10;
		transform.Translate(pos);
        checkWall();
 
        if (Input.GetKeyDown("d"))
		{		
			transform.Rotate (0, 90, 0);		
		}
		if(Input.GetKeyDown("a"))
		{
			transform.Rotate(0,-90,0);
		}
	}
    void checkWall()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 50f))
        {
            moveSpeed = 0;
            //Debug.Log(hit.transform.name);
        }
        else
        {
            moveSpeed = 5.0f;
        }
    }
}


