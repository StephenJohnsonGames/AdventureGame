using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogSpawn : MonoBehaviour {

	public GameObject Logs;
	private Inventory inventory;
	private int woodToRemove;
	public GameObject Collider;
	GameObject LogsClone;
	public GameObject SpawnPoint;

	// Use this for initialization
	void Start () {

		inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
		LogsClone = Instantiate(Logs, SpawnPoint.transform.position, SpawnPoint.transform.rotation) as GameObject;
		
		

	}

	// Update is called once per frame
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
		{
			for (int i = 0; i < inventory.slots.Length; i++)
			{
				if (inventory.isWood[i] == false)
				{
					if (woodToRemove <= 1)
					{
						LogsClone = Instantiate(Logs, SpawnPoint.transform.position, SpawnPoint.transform.rotation) as GameObject;
					}
					else
					{
						Debug.Log("Test");
					}
						
					
				}
			}
				
			
			

		}


		//for (int i = 0; i < inventory.slots.Length; i++)
		//{

		//	if (inventory.isWood[i] == true)
		//	{

		//		if (woodToRemove <= 1)
		//		{
		//			GameObject LogsClone;
		//			LogsClone = Instantiate(Logs, transform.position, transform.rotation);

		//		}
		//	}
		//}
	}
}
