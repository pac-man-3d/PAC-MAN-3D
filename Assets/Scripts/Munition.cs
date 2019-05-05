using UnityEngine;
using System.Collections;

public class Munition : MonoBehaviour
{
	//public float moveSpeed;

	void Start(){}
	void Update()
	{		
		if (Input.GetKey(KeyCode.Space))
        {
			Vector3 pos = Vector3.forward * 5.0f * Time.deltaTime*10;
			transform.Translate(pos);
            //transform.position = new Vector3(transform.position.x, transform.position.y+1, transform.position.z);
			//transform.Translate(moveSpeed*Input.GetAxis("Horizontal")*Time.deltaTime,0f,moveSpeed*Input.GetAxis("Vertical")*Time.deltaTime);
        }
	}
}