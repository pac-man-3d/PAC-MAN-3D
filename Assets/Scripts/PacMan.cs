using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacMan : MonoBehaviour 
{
	void Start()
	{
		
	}
	void Update()
	{
		Vector3 pos = Vector3.forward * 20.0f * Time.deltaTime*10;
		transform.Translate(pos);
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


