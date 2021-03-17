using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrigger : MonoBehaviour {

	public int dmg = 1;

	void OnTriggerEnter2D(Collider2D col)
	{

		if (col.isTrigger != true && col.CompareTag("Player"))
		{

			col.SendMessageUpwards("Damage", dmg);
		}
	}
}
