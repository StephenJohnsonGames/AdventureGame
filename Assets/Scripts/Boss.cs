using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour {

	public int currentHealth;
	public int maxHealth;
    public static bool dead;

	public float distance;
	public float stealthDistance;
	public float wakeRange;
	public float shootInterval;
	public float bulletSpeed = 100;
	public float bulletTimer = 1.0f;

	public bool awake = false;
	
	public GameObject bullet;
	public GameObject player;
	public Transform target;
	public Transform shootPoint;
	public float timer;
	public GameObject weakPoint;
	public GameObject Ending;
    public AudioSource shootingSound;
    


	void Awake()
	{

	}

	void Start()
	{
        GameOverContinue.BossRoomAccessed = true;
		player = GameObject.Find("Player");
		currentHealth = maxHealth;
        //boss = GameObject.Find("Boss");

        
        shootingSound.playOnAwake = false;
       

	}
	void Update()
	{
		//anim.SetBool("Awake", awake);


		//RangeCheck();

		if (timer < 175)
		{
			timer++;

		}


		if (timer >= 150 && player.CompareTag("Player"))
		{
			bulletTimer += Time.deltaTime;

			if (bulletTimer >= shootInterval)
			{

				Vector2 direction = target.transform.position - transform.position;
				direction.Normalize();

				GameObject bulletClone;
				bulletClone = Instantiate(bullet, shootPoint.transform.position, shootPoint.transform.rotation) as GameObject;
				bulletClone.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;
                shootingSound.Play(); //BULLET SOUND
				bulletTimer = 0.0f;


			}
		}

		else
		{
			bulletTimer = 0.0f;


		}

		if (currentHealth <= 0)
		{
            //playvictory sound & death sounds
            
            dead = true;
           
            Ending.SetActive(true);
            gameObject.SetActive(false);
			//Destroy(gameObject);
			
		}

		if(timer >= 175)
		{

			GetComponent<Renderer>().material.color = new Color(1, 1, 1, 1);

		}




		//if ()
		//{

		//	bulletTimer = 0.0f;
		//}


		//	if (boss.CompareTag("Boss"))

		//{
		//	//StopAttack(false);
		//	Attack(true);
		//	Debug.Log("Attacking");
		//}

		//if (boss.CompareTag("BossFrozen"))
		//{

		//	Debug.Log("Attacking stopped");
		//	Attack(false);
		//	//StopAttack(true);
		//}






	}

	public void Damage(int damage)
	{

		currentHealth -= damage;
		GetComponent<Renderer>().material.color = new Color(1, 0, 0, 1);
		timer -= 15;
		
	}

	//void RangeCheck()
	//{

	//	distance = Vector3.Distance(transform.position, target.transform.position);

	//	if(distance < wakeRange)
	//	{

	//		awake = true;

	//	}

	//	if(distance > wakeRange)
	//	{

	//		awake = false;

	//	}
	//}

	//public void Attack(bool attack)
	//{


	//	bulletTimer += Time.deltaTime;

	//	if(bulletTimer >= shootInterval)
	//	{

	//		Vector2 direction = target.transform.position - transform.position;
	//		direction.Normalize();

	//		GameObject bulletClone;
	//		bulletClone = Instantiate(bullet, shootPoint.transform.position, shootPoint.transform.rotation) as GameObject;
	//		bulletClone.GetComponent<Rigidbody2D>().velocity = direction * bulletSpeed;

	//		bulletTimer = 0.0f;


	//	}

	//}

	//public void StopAttack(bool stopAttack)
	//{

	//	bulletTimer = 0.0f;

	//}
}
