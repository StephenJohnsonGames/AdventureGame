using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logs : MonoBehaviour {

	public int maxHealth;
	public int currentHealth;
	public GameObject WoodSprite;
	//public GameObject Wood;

	// Use this for initialization
	void Start () {

		currentHealth = maxHealth;
		

	}
	
	// Update is called once per frame
	void Update () {

		if (currentHealth <= 0)
		{
			Destroy(gameObject);
			spriteSpawn();
		}

	}

	public void Damage(int damage)
	{

		currentHealth -= damage;
		//gameObject.GetComponent<Animation>().Play("Damage Animation");
	}

	public void spriteSpawn()
	{
	// Instantiate the wreck game object at the same position we are at
	GameObject WoodSpriteClone; 
			
	WoodSpriteClone = Instantiate(WoodSprite, transform.position, transform.rotation) as GameObject;

	}
}
