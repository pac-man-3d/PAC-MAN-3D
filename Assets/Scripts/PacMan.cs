using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacMan : MonoBehaviour {
	
	public float moveSpeed;
	public float jumpForce;
	//public float mouseSpeed;
    public float turnSpeed;
	public static int i=0;
	public static int j=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate ()
	{
		GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
		
		GetComponent<Rigidbody> ().AddForce (transform.right * -(moveSpeed));
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
		//Vector3.forward++;
		/*if(Input.GetKeyDown("d"))
		{
			
			transform.rotation = Quaternion.Euler(0, i, 0);
			i = i+90;
		}
		
		if(Input.GetKeyDown("a"))
		{
			
			transform.rotation = Quaternion.Euler(0, j, 0);
			j = j-90;
		}
		}
		/*if(Input.GetKey(KeyCode.LeftArrow))
			// transform.rotation = Quaternion.Euler(x,0,0);
            transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
        
        if(Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
		*/
		// Sprungfähigkeit
	/*	RaycastHit hit;
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
	*/
		// Spieler-Drehung im Sinne der Mausbewegung aktualisieren
		//transform.Rotate (0, Input.GetAxisRaw ("Mouse X") * mouseSpeed * Time.fixedDeltaTime, 0);
		
		// Kamera mit Spieler drehen (Position wird automatisch aktualisiert)
		//Camera.main.transform.Rotate(new Vector3 (-Input.GetAxisRaw ("Mouse Y") * mouseSpeed * Time.fixedDeltaTime, 0, 0));
	}

}
