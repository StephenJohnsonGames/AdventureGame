using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodSprite : MonoBehaviour {

    private Inventory inventory;
    public static bool removeButton;

    // Use this for initialization
    void Start () {

        //HealthBar = GameObject.FindGameObjectWithTag("UI").transform;
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();

    }
	
    void Update()
    {

        if (removeButton == true)
        {

            RemoveSpriteW();
            removeButton = false;

        }

    }
	// Update is called once per frame
    public void Use()
    {

        HealthBar.Increase = true;
        GameObject.Destroy(gameObject);

    }

    public void RemoveSpriteW()
    {

        GameObject.Destroy(gameObject);
        print("wood destroyed");


    }
}
