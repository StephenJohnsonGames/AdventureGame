using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordPickup : MonoBehaviour {

    public static bool ObtainedSword = false;

	void Start () {

	
	}

	void OnTriggerEnter2D(Collider2D other)
	{
        if (other.CompareTag("Player"))

            ObtainedSword = true;

		{

			gameObject.SetActive(false);
			//gameObject.tag = "Untagged";
			
		}
	}

}
