using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{ 	public Camera cam1;
	public Camera cam3;
	public MünzScore ms;
    // Start is called before the first frame update
    void Start()
    {
        cam1.enabled=true;
		cam3.enabled=false;
    }

    // Update is called once per frame
    void Update()
    {
        if (ms.count==82)
		{
			cam1.enabled=false;
			cam3.enabled=true;
		}
    }
}
