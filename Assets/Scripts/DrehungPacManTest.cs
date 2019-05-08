using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrehungPacManTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //var grad : int = 90;
		//var i : float;
		//var factor : int = 100;
		if(Input.GetKeyDown("d"))
		{
			
				{
					transform.Rotate (0, 90, 0);
				}
		}
		if(Input.GetKeyDown("a"))
		{
			transform.Rotate(0,-90,0);
		}
    }
	
	
	/*
	function OnMouseDown()
	{

		switch(mode)
		{
			case 1:

				for(i = 0; i < grad; i++) //soll in die eine Richtung drehen
				{
					transform.Rotate (0, i * Time.deltaTime * factor, 0);
				}
				break;
			case 2:

				for(i = 35; i > grad-grad; i--)
				{
					transform.Rotate (0, i * Time.deltaTime * factor, 0); //soll in die andere Richtung drehen
				}
				break;
		}

	}
*/

}
