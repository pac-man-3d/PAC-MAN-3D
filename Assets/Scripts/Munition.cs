/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Munition : MonoBehaviour {
	
	public float moveSpeed;
	//public float jumpForce;
	//public float mouseSpeed;
    //public float turnSpeed;
	// Start is called before the first frame update
    void Start()
    {
        
    }

    void FixedUpdate ()
	{
		GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
		
		GetComponent<Rigidbody> ().AddForce (transform.right * -(moveSpeed));
		//if(Input.GetKeyDown("d"))
		//{
			//		transform.Rotate (0, 90, 0);	
		//}
		//if(Input.GetKeyDown("a"))
		//{
		//	transform.Rotate(0,-90,0);
		//
		}
		// Kamera mit Spieler drehen (Position wird automatisch aktualisiert)
		//Camera.main.transform.Rotate(new Vector3 (-Input.GetAxisRaw ("Mouse Y") * mouseSpeed * Time.fixedDeltaTime, 0, 0));
	}
	*/
using UnityEngine;
using System.Collections;

public class Munition : MonoBehaviour
{
  
 /*   // public member eines Scripts können bequem
    // im Unity Editor gesetzt und auch während
    // das Spiel getestet wird verändert werden.
  
    public float Geschwindigkeit;
    public float Beschleunigung;

  
    float aktuelleGeschwindigkeit = 0;
    Vector3 richtung = Vector3.zero;

    void Start()
    {
    }

    void Update()
    {
        if (EingabeÜberprüfen())
        {
            if (aktuelleGeschwindigkeit < Geschwindigkeit)
            {
                aktuelleGeschwindigkeit += Beschleunigung * Time.deltaTime;
            }
            this.transform.position += richtung * aktuelleGeschwindigkeit * Time.deltaTime;
        }
        else
        {
            aktuelleGeschwindigkeit = 0f;
        }
    }

    private bool EingabeÜberprüfen()
    {
        bool eingabe = false;
        float x = 0f;
        float z = 0f;
      
        // Input.GetKey gibt true zurück wenn
        // die gefragte Taste gedrückt ist
      
        if (Input.GetKey(KeyCode.RightArrow))
        {
            x++;
            eingabe = true;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            x--;
            eingabe = true;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            z++;
            eingabe = true;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            z--;
            eingabe = true;
        }
        richtung = new Vector3(x, 0f, z);
        return eingabe;
    }
}*/

public float _ballSpeed = 2.5f;
Rigidbody _rb;

void Start()
{
    _rb = GetComponent<Rigidbody>();
    _rb.velocity = Vector2.one * _ballSpeed;
}
void Update()
{

}}