using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{



	//GameObject Player;      //Game object player available    //not really sure that this is needed. 

	public Transform Ts;

	GameObject Player;

	public Transform PlayerPos;     //allows player pos.
									//public Tag PlayerTag;
									//public GameObject respawn;


	public float DistanceToTarget;  //Always set to 0 at start then updated and checked in update.
	public float AwarenessRange;    //Can be changed in unity GUI.

	public float speed;      //Speed of enemy chasing player.   //editable in unity gui on enemy. 
	private Transform target;       //this is the transform(position of the target(player))     //could have probally just looked at players pos and not made a new thing called target but from example so im sticking to this for now. 

	public float waitTime; //
	public float startWaitTime; //

	public Transform[] patrolPoints;   //Array holding move spots object positions.
	private int i = 0; //Array I, not the best initaliation.


	//Stats of specific enemy

	public int maxHealth;
	public int currentHealth; //Within player you could add the damage
	public int attackPower;
	public int attackReach;
	public float originalAttackCooldown;
	private float attackCooldown;
	bool cooldownStart = false;

	GameObject Raja; /////////////////
	bool oh;

	void Start()
	{
		currentHealth = maxHealth;
		//Player = GameObject.FindWithTag("Player");        //Should be looking for player but player can be destroyed. 
		//Rigidbody2D sc = gameObject.AddComponent(typeof(Rigidbody2D)) as Rigidbody2D; //automatically adds a rigidbody to the object this script is atatched to.  the only thing is that if i want to use this i then need to drag the enemy into the script box to allow the use to code to change it which isnt working for me.

		target = PlayerPos.transform;       //This remakes the players position at the beginning of the game. //should take this out at a later date.
		target.transform.localScale = new Vector3(3f, 3f, 0f);
		//target.transform.position = new Vector3(0f, 1.3f, -2f);


		waitTime = startWaitTime; //
		attackCooldown = originalAttackCooldown;


		gameObject.tag = "Enemy";      //THIS SETS THE TAG TO ENEMY ON START UP
									   //Ts.Translate(2, 2, 2); //this lets me change the sprites position.

		Player = GameObject.FindWithTag("Player");
	}



	void Update()
	{
		DistanceToTarget = Vector3.Distance(transform.position, PlayerPos.position);

		//Debug.Log("time is %f" + waitTime); //Constantly print what the time is at. 
		waitTime -= Time.deltaTime; //Constantly descreasing the wait time over time through the use of time dealta. 
									//Debug.Log("i = " + i);    //Wait time log debugged
									//Movement if when wait time is less than "".


		if (patrolPoints[i].position == Ts.position)
		{

			Player = GameObject.FindWithTag("Player");

			Debug.Log("Reset");
		}






		//if (respawn == null)
		//{
		//    respawn = GameObject.FindWithTag("Player");
		//    Debug.Log("Plasyer see");
		//}

		//Raja = GameObject.FindWithTag("Player");
		//if (Raja = GameObject.FindWithTag("Player"))
		//    {
		//    bool oh = true;
		//    }

		//if (oh == true)
		//{
		//    Debug.Log("SEE PLAYER");
		//} 

		//if (FindGameObject.WithTag == "Player")
		//{
		//    Debug.Log("SEE PLAYER");
		//}

		//if (other.gameObject.CompareTag("Player"))
		//{
		//    Destroy(other.gameObject);
		//}

		//    if (GameObjects.DoesTagExist("Player") == true)
		//{
		//    bool doesIt = true;
		//}
		//aObj.FindGameObjectsWithTag(aTag);


		//if (doesIt == true)
		//{
		//    Debug.Log("yeS");
		//}
		//if (other.CompareTag("Stealth"))
		//{
		//if (collision.gameObject.name == "MyGameObjectName")


		if (Player.CompareTag("Player"))
		{
			//Debug.Log("1");
			if (DistanceToTarget < AwarenessRange)      //CHASING PLAYER IF IN RANGE, OTHERWISE IN ELSE IT IS DOING ITS PATROL...
			{

				//Debug.Log("2");
				float step = speed * Time.deltaTime; // calculate distance to move
				transform.position = Vector3.MoveTowards(transform.position, target.position, step);        //Debug.Log("Player being followed");
				//Debug.Log("2.1");
				//Ts.Translate(2, 2, 0);      //Dont affect z!! messes up awareness range //Moves enemies position. 
				//Destroy(Player);        //only looking at tag? thats not looking at the sprites name. Even without including "Player = GameObject.FindWithTag("Player");"

			}
			else
			{
				if (waitTime < 0)   //Movement once the wait time is less than 0
				{
					transform.position = Vector2.MoveTowards(transform.position, patrolPoints[i].position, speed * Time.deltaTime);    //The enemy moves towards the patrol point in the list? canty tink of the word...
					//Debug.Log("3");                                                                                                                   //Debug.Log("pos is %f" + transform.position.z);        //z position log debugger, had bug where z was being ultered.
				}
			}
		}
		else
		{
			//Debug.Log("2.2");

			if (waitTime < 0)   //Movement once the wait time is less than 0
			{
				transform.position = Vector2.MoveTowards(transform.position, patrolPoints[i].position, speed * Time.deltaTime);    //The enemy moves towards the patrol point in the list? canty tink of the word...
				//Debug.Log("3");                                                                                                                   //Debug.Log("pos is %f" + transform.position.z);        //z position log debugger, had bug where z was being ultered.
			}
		}








		///////////  MOVEMENT BETWEEN PATROL POINTS WHEN PLAYER ISNT DETECTED   ///////////////////////
		//Checking position of enemy, if ontop of movespot then... 
		//if (Player.tag == "Stealth")
		//{
		//Debug.Log("3.9");
		if (Vector2.Distance(transform.position, patrolPoints[i].position) < 0.01f)
		{       //checking enemy pos compared to patrol points pos. 
			//Debug.Log("4");
			//Debug.Log("PatrolPoint " + patrolPoints[i] + " reached");
			i++;
			//Debug.Log("4.1");
			waitTime = startWaitTime;   //This wait time increase once the I has been plussed so the enemy doesnt start walking towards the next one before the time is increased. 
			//Debug.Log("4.2");

			if (waitTime < -4)      //Wait time is below a certain point then restart the wait time to the startwaittime (this can be changed).
			{
				waitTime = startWaitTime; Debug.Log("Wait Time increased back to set amount");  //This wait time only affects waity time if i takes a long time to reach its place. 
				//Debug.Log("4.3");
			}
		}

		//Debug.Log("5");
		if (i == patrolPoints.Length)
		{
			//Debug.Log("5.1");
			i = 0;
		}

		

		//} if player s
		/////////////////////        MOVEMENT IF'S ABOVE     ////////////////////////////////




		/////////////////////  INTERACTION WITH PLAYER BELOW     ////////////////////////////////
		if (cooldownStart == true)
		{
			//start the countdown for the value.
			attackCooldown -= Time.deltaTime;   //Should reduce the set attackCooldown time in seconds/milliseconds. 
			Debug.Log("Cooldown in progress... " + attackCooldown + " seconds left");       //Will print the enemies cooldown timers and update the console on the progress. 
			if (attackCooldown < 0)
			{
				cooldownStart = false;
				attackCooldown = originalAttackCooldown; Debug.Log("Cooldown reset to original time");
			}
		}


		if (Vector2.Distance(transform.position, PlayerPos.position) < attackReach)     //If the enemies pos and players pos is less than the attackrach then do this...
		{
			//attack Players Health

			if (cooldownStart == false)     //if the cooldown hasnt started then hit the player and start the cooldown. Update will then decrease cooldowns time and allow the player to be hit again after the time expires. 
			{
				Debug.Log("Player hit");
				//Add the damage done to the player here...
				cooldownStart = true;
				Debug.Log("Cooldown started...");
			}
		}



		if (currentHealth <= 0)
		{
			Destroy(gameObject);
		}

		if(HealthBar.HealthDecreasing == true)
		{
			Debug.Log("Health Decreasing");

		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
		{

			waitTime = startWaitTime;

			HealthBar.currentHp = HealthBar.currentHp - 15;
			HealthBar.HealthDecreasing = true;

			//Player = GameObject.FindWithTag("Untagged");

			Debug.Log("Attacking Player");



		}
	}

	public void Damage(int damage)
	{

		currentHealth -= damage;
		//gameObject.GetComponent<Animation>().Play("Damage Animation");
	}

	

}  //End of everything..


