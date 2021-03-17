using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostAttacked : MonoBehaviour {

    public int gMaxHealth;
    public int gCurrentHealth;

    void Start()
    {

        gCurrentHealth = gMaxHealth;


    }

    // Update is called once per frame
    void Update()
    {

        if (gCurrentHealth <= 0)
        {
            Destroy(gameObject);

        }

    }

    public void Damage(int damage)
    {

        gCurrentHealth -= damage;

        MoralityBar.currentMoral = MoralityBar.currentMoral - 5;
        print("taking damage");
        //gameObject.GetComponent<Animation>().Play("Damage Animation");
    }

}
