using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour {

    private float totalHp = 100;
    public static float currentHp = 100;
    public static bool dead;
    private float minHealth = 5;
    public static bool Increase = false;
	public static bool HealthDecreasing = false;

	public GameObject player;

    // Use this for initialization
    void Start()
    {

        //currentHp = totalHp;

    }

    // Update is called once per frame
    void Update()
    {

        //if (Input.GetMouseButtonDown(0))
        //{

        //    TakeDamage(5);

        //}

        if (Increase == true)
        {
            
            IncreaseHealth();
            Increase = false;

        }
        if (currentHp <= 100)
        {

            totalHp = 100;
            transform.localScale = new Vector3((currentHp / totalHp), 1, 1);

        }
        if (currentHp <= 0)
        {

            currentHp = 0;
            Died();
            transform.localScale = new Vector3((currentHp / totalHp), 1, 1);

        }
        if (currentHp >= 100)
        {

            currentHp = 100;
            transform.localScale = new Vector3((currentHp / totalHp), 1, 1);

        }

    }

    void TakeDamage(int damage)
    {

        print("taking damage");

        if (currentHp >= minHealth)
        {
            currentHp -= damage;
            transform.localScale = new Vector3((currentHp / totalHp), 1, 1);
			
        }
        else
        {

            Died();
            dead = true;

        }

    }

    void Died()
    {

        print("You died");
        SceneChange.ManualChange(14);
        currentHp = totalHp;

    }

    void IncreaseHealth()
    {
        print("increasing");
        if (currentHp >= 100)
        {
            totalHp = 100;
            print(totalHp);
            currentHp = 100;
            transform.localScale = new Vector3((currentHp / totalHp), 1, 1);
        }
        else
        {

            currentHp = currentHp + 20;
            transform.localScale = new Vector3((currentHp / totalHp), 1, 1);

        }


    }


    

        

    


}

