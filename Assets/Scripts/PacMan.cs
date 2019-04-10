﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacMan : MonoBehaviour {
	
	public float moveSpeed;
	public float jumpForce;
	//public float mouseSpeed;
    public float turnSpeed;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate ()
	{
		GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
		
		GetComponent<Rigidbody> ().AddForce (transform.right * -(moveSpeed));
		
		//Vector3.forward++;
		
		/*if(Input.GetKeyDown("d"))
		{
			for(var i = 0; i < 90; i++)
				{
					transform.Rotate (0, i * Time.deltaTime * 100, 0);
				}
		}
		if(Input.GetKeyDown("a"))
		{
			for(var i = 90; i > 0; i--)
				{
					transform.Rotate (0, i * Time.deltaTime * 100, 0);
				}
		}
		/*if(Input.GetKey(KeyCode.LeftArrow))
			// transform.rotation = Quaternion.Euler(x,0,0);
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        
        if(Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
		*/
		// Sprungfähigkeit
		RaycastHit hit;
		Debug.DrawRay(transform.position + Vector3.up * 0.1f, Vector3.down * 0.2f, Color.yellow);
		// wenn Spieler auf dem Boden steht...
		if (Physics.Raycast (transform.position + Vector3.up * 0.1f, Vector3.down, out hit, 0.2f))
		{
			// und die Leertaste gegrückt ist
			if (Input.GetKeyDown ("space"))
			{
				// eine Kraft nach oben ausüben
				GetComponent<Rigidbody> ().AddForce (Vector3.up * jumpForce);
			}
		}
	
		// Spieler-Drehung im Sinne der Mausbewegung aktualisieren
		//transform.Rotate (0, Input.GetAxisRaw ("Mouse X") * mouseSpeed * Time.fixedDeltaTime, 0);
		
		// Kamera mit Spieler drehen (Position wird automatisch aktualisiert)
		//Camera.main.transform.Rotate(new Vector3 (-Input.GetAxisRaw ("Mouse Y") * mouseSpeed * Time.fixedDeltaTime, 0, 0));
	}

    
}