using System.Collections;
using System.Collections.Generic;
using UnityEngine;  

public class PacMan : MonoBehaviour 
{
    public float moveSpeed = 20.0f;
    void Start()
	{
		
	}
	void Update()
	{
<<<<<<< HEAD
		Vector3 pos = Vector3.forward * 10.0f * Time.deltaTime*10;
=======
		Vector3 pos = Vector3.forward * moveSpeed * Time.deltaTime*10;
>>>>>>> bf08eafc1ae533600a927a9eef3d45164dc13152
		transform.Translate(pos);
		
		if(Input.GetKeyDown("d"))
		{		
			transform.Rotate (0, 90, 0);		
		}
		if(Input.GetKeyDown("a"))
		{
			transform.Rotate(0,-90,0);
		}
<<<<<<< HEAD
		if(Input.GetKeyDown(KeyCode.RightArrow))
		{		
			transform.Rotate (0, 90, 0);		
		}
		if(Input.GetKeyDown(KeyCode.LeftArrow))
		{
			transform.Rotate(0,-90,0);
		}
=======
        checkWall();
>>>>>>> bf08eafc1ae533600a927a9eef3d45164dc13152
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
            moveSpeed = 20.0f;
        }
    }
}