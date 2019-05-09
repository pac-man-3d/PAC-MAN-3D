using UnityEngine;
using System.Collections;

public class Munition : MonoBehaviour
{
	//public float moveSpeed;
	public Transform spawnposition;
	public Transform spawnrotation;
	public GameObject prefab;
	public float reloadTime = 3f;
	
	
	void Start()
	{
		
	}
	void Update()
	{		
		if (Input.GetKeyDown(KeyCode.Space))
        {
				Vector3 ammopos = spawnposition.transform.position;
				Quaternion ammorot = spawnrotation.transform.rotation;
				Instantiate(prefab, ammopos, ammorot);
		} 
	}
}