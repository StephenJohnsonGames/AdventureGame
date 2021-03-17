using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterSprite : MonoBehaviour {

    private Inventory inventory;
    public static bool removeButton;

    // Use this for initialization
    void Start () {

        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();

    }
	
	// Update is called once per frame
	void Update () {
	    
        if (removeButton == true)
        {

            RemoveButton();
            removeButton = false;


        }

	}

    public void Use()
    {

        //increases stamina when pressed
        Stamina.StaminaIncreasebool = true;
        //destroys the object right after
        GameObject.Destroy(gameObject);

    }

    public void RemoveButton()
    {

        GameObject.Destroy(gameObject);

    }

}
