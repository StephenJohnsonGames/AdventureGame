using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour {

	private bool attacking = false;

	private float attackTimer = 0;
	private float attackCooldown = 0.8f;

	public Collider2D attackTrigger;



	void Awake()
	{

		attackTrigger.enabled = false;
	}

	void Update()
	{
		if (!attacking)
		{
			attacking = true;
			attackTimer = attackCooldown;

			attackTrigger.enabled = true;

		}

		if (attacking)
		{
			if (attackTimer > 0)
			{
				attackTimer -= Time.deltaTime;
			}
			else
			{
				attacking = false;
				attackTrigger.enabled = false;
			}

		}


	}

}

