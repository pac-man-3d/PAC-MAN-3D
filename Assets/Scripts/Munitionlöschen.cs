using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Munitionlöschen : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
    void OnCollisionEnter(Collision col)
		{
            if(gameObject != null)
            {
        if (col.gameObject.tag == "Wall")
        {
            Debug.Log("Collision Detected");
			Destroy(this.gameObject);
        }
            }
}
}