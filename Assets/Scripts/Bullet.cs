using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	//void FixedUpdate()
	//{
	//	OnTriggerEnter2D();

	//}
	void OnTriggerEnter2D(Collider2D col)
	{

		if(col.isTrigger != true)
		{

			if (col.CompareTag("Player"))
			{

				//col.GetComponent<Player>().Damage(1);
				Destroy(gameObject);
				HealthBar.currentHp = HealthBar.currentHp - 5;

			}

			if (col.CompareTag("BulletWall"))
			{

				Destroy(gameObject);
			}

		}
	}
}
