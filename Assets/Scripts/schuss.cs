using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class schuss : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mupos = Vector3.forward * 60.0f * Time.deltaTime*10;
		transform.Translate(mupos);
    }
}
