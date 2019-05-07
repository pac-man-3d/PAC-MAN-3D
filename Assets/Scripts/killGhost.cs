using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class killGhost : MonoBehaviour
{
    public bool dead = false;
    public float respawnTimer = 10.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

       
        if (dead == true)
        {

            respawnTimer -= Time.deltaTime;
            if (respawnTimer < 0)
            {
                respawnTimer = 10.0f;
                dead = false;

            }
        }
    }


    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Ghost")
        {
            Debug.Log("Collision Detected");
            dead = true;


        }
    }
}
