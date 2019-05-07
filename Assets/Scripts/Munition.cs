using UnityEngine;
using System.Collections;

public class Munition : MonoBehaviour
{
	//public float moveSpeed;
	public Transform spawnposition;
	public GameObject prefab;
	
	
	void Start(){}
	void Update()
	{		
		if (Input.GetKey(KeyCode.Space))
        {
			
			for(int i=0; i<1; i++)
			{
				Vector3 ammopos = spawnposition.transform.position;
				Instantiate(prefab, ammopos, prefab.transform.rotation);
				ammopos = Vector3.forward * 5.0f * Time.deltaTime*10;
				transform.Translate(ammopos);
			//	yield WaitForSeconds (1.0f);
			}
			
		} 
		
	}
}