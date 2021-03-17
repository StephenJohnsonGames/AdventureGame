using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackCone : MonoBehaviour {

	public Boss boss;

	void Awake()
	{

		boss = gameObject.GetComponentInParent<Boss>();

	}

	void OnTriggerStay2D(Collider2D col)
	{

		if (col.CompareTag("Player"))
		{
			//Debug.Log("Attacking" + gameObject.name);
			//boss.Attack(true);

		}
		else
		{

			//boss.Attack(false);
		}
	}
}
