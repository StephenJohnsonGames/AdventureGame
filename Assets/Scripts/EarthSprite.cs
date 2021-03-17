using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthSprite : MonoBehaviour {

    private Inventory inventory;
    public static bool removeButton = false;


    // Use this for initialization
    void Start()
    {

        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        

    }

    // Update is called once per frame
    void Update()
    {

        if (removeButton == true)
        {

            
            
            RemoveButton();



        }

    }

    public void RemoveButton()
    {

        GameObject.Destroy(gameObject);
        removeButton = false;
    }
}
