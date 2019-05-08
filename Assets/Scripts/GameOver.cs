using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public Camera cam1;
    public Camera cam2;
    // Start is called before the first frame update
    void Start()
    {
        cam1.enabled = true;
        cam2.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Pacman")
        {
            Debug.Log("Collision Detected");
            Debug.Log(col.gameObject);
            Destroy(col.gameObject);
            cam1.enabled = false;
            cam2.enabled = true;
        }
    }
}
