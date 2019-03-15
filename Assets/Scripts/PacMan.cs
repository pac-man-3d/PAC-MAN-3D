using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacMan : MonoBehaviour {
	
	public float moveSpeed;
	public float jumpForce;
	public float mouseSpeed;
	
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate ()
	{
		// Spieler-Position im Sinne der betätigten Kontrollenn aktualisieren
		GetComponent<Rigidbody>().velocity =
			transform.right * Input.GetAxis ("Horizontal") * moveSpeed + 
			transform.forward * Input.GetAxis ("Vertical") * moveSpeed + 
			Vector3.up * GetComponent<Rigidbody>().velocity.y;
		GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
		
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
		transform.Rotate (0, Input.GetAxisRaw ("Mouse X") * mouseSpeed * Time.fixedDeltaTime, 0);
		
		// Kamera mit Spieler drehen (Position wird automatisch aktualisiert)
		Camera.main.transform.Rotate(new Vector3 (-Input.GetAxisRaw ("Mouse Y") * mouseSpeed * Time.fixedDeltaTime, 0, 0));
	}
}