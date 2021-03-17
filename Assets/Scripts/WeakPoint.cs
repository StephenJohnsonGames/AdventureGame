using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeakPoint : MonoBehaviour {

	public int maxHealth;
	public int currentHealth;
	public GameObject Boss;
	public Boss boss;
    public static bool WeakPointGone;

	//public GameObject Wood;

	// Use this for initialization
	void Start()
	{
		boss = gameObject.GetComponentInParent<Boss>();
		currentHealth = maxHealth;


	}

	// Update is called once per frame
	void Update()
	{

		if (currentHealth <= 0)
		{
            //play victory and death sound
            WeakPointGone = true;

            Boss.GetComponent<Renderer>().material.color = new Color(0.3f, 0.3f, 0.3f, 1.0f);
			boss.timer = 0;
			boss.bulletTimer = 0.0f;
		}

	}

	public void Damage(int damage)
	{

		currentHealth -= damage;
		//gameObject.GetComponent<Animation>().Play("Damage Animation");
	}

}