using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour {


    private Inventory inventory;
    public int index;

    private void Start()
    {
        
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();

    }

    private void Update()
    {
        //checks whether there is a button in each slot if not then will set every varible to false
        if (transform.childCount <= 0) {

            inventory.isFull[index] = false;
            inventory.isWood[index] = false;
            inventory.isWater[index] = false;
            inventory.isEarth[index] = false;
            inventory.isWeapon[index] = false;

        }

//        inventory.quantity[i].guiText

    }

    public void Remove() {

        //when remove buttons is pressed it will remove this for each child that is removed
        foreach (Transform child in transform)
        {

            //excutes the spawning item code
            child.GetComponent<Spawn>().SpawnDroppedItem();
            //will destroy the gameobject in the inventory
            GameObject.Destroy(child.gameObject);

        }
    }

    

}
