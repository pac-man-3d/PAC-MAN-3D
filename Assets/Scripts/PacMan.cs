using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class Bewegen : MonoBehaviour
{
	
	//this.transform.position.Set(1f, 0f, 0f);
	//this.transform.position = new Vector3(1f, 0f, 0f);

	public float Geschwindigkeit = 10f;
	public float Richtung = Vector3(1f, 0f, 0f);

	float aktuelleGeschwindigkeit = 0;
    //public float Geschwindigkeit;
    
    Vector3 richtung = Vector3.zero;

    void Start()
    {
    }

    void Update()
    {
        if (EingabeUeberpruefen())
        {
            if (aktuelleGeschwindigkeit < Geschwindigkeit)
            {
                aktuelleGeschwindigkeit += Geschwindigkeit;
            }
            this.transform.position += richtung * aktuelleGeschwindigkeit;
        }
        else
        {
            aktuelleGeschwindigkeit = 0f;
        }
    }

    private bool EingabeUeberpruefen()
    {
        bool eingabe = false;
        //float x = 0f;
        //float z = 0f;
      
      
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
        richtung = Vector3(x, 0f, z);
        return eingabe;
    }
	
							
}