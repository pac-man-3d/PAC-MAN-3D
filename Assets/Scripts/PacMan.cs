using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacMan : MonoBehaviour {
	public float moveSpeed;

	void Start(){}
	void Update()
	{
		Vector3 pos = Vector3.forward * 5.0f * Time.deltaTime*10;
		transform.Translate(pos);
        //transform.Translate(moveSpeed*Input.GetAxis("Horizontal")*Time.deltaTime,0f,moveSpeed*Input.GetAxis("Vertical")*Time.deltaTime);
		if(Input.GetKeyDown("d"))
		{		
			transform.Rotate (0, 90, 0);		
		}
		if(Input.GetKeyDown("a"))
		{
			transform.Rotate(0,-90,0);
		}
	}
}


