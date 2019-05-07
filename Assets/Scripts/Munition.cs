using UnityEngine;
using System.Collections;

public class Munition : MonoBehaviour
{
	//public float moveSpeed;
	public Transform spawnposition;
	public Transform spawnrotation;
	public GameObject prefab;
	
	
	void Start(){}
	void Update()
	{		
		if (Input.GetKeyDown(KeyCode.Space))
        {
			for(int i=0; i<1; i++)
			{
				Vector3 ammopos = spawnposition.transform.position;
				Quaternion ammorot = spawnrotation.transform.rotation;
				Instantiate(prefab, ammopos, ammorot);
			}
		} 
	}
}