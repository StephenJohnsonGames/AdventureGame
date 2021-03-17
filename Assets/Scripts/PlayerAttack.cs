using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

	private bool attacking = false;

	private float attackTimer = 0;
	private float attackCooldown = 0.2f;

	public Collider2D attackTrigger;

	

	void Awake()
	{
	
		attackTrigger.enabled = false;
	}

	void Update()
	{
		if(Input.GetKeyDown("space") && !attacking)
		{
			attacking = true;
			attackTimer = attackCooldown;

			attackTrigger.enabled = true;
            //play sound swipe

		}

		if (attacking && Stamina.StaminaEmpty == false)
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
