using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour {

    private Inventory inventory;
    public GameObject itemButton;
    public bool spriteWood;
    public bool spriteWoodClone;
    public bool spriteWater;
    public bool spriteEarth;
    public bool spriteSword;
    public bool spriteplat;
    public int spriteQuantity;

    private void Start()
    {
        //looks at players inventory component
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();

    }

    //when object is collided with player
    void OnTriggerEnter2D(Collider2D other)
    {
        //will check player and slots
        if (other.CompareTag("Player"))
        {
            for (int i = 0; i < inventory.slots.Length; i++)
            {

                if (inventory.isFull[i] == false)
                {
                    //item can be added
                    inventory.isFull[i] = true;
                    //will check what the item is using the items varible
                    if (spriteWood == true)
                    {
                        
                        //will set the varible of that slot for further developement with crafting but allows the ability of removing a specific item.
                        inventory.isWood[i] = true;
                        //if ((inventory.quantityOfItem[i] + spriteQuantity) >= 40)
                        //{

                        //    inventory.isFull[i] = true;inventory.quantityOfItem[i] = inventory.quantityOfItem[i] + spriteQuantity;

                        //}
                        //else
                        //{

                            

                        //}
                    }
                    else if (spriteWoodClone == true)
                    {
                        inventory.isWood[i] = true;

                    }
                    else if (spriteWater == true)
                    {

                        inventory.isWater[i] = true;
                        //inventory.quantityOfItem[i] = spriteQuantity;

                    }
                    else if (spriteEarth == true)
                    {

                        inventory.isEarth[i] = true;
                        //inventory.quantityOfItem[i] = spriteQuantity;

                    }
                    else if (spriteSword == true)
                    {

                        inventory.isWeapon[i] = true;
                        //inventory.quantityOfItem[i] = spriteQuantity;

                    }
                    else
                    {

                        inventory.isPlatform[i] = true;
                        //inventory.quantityOfItem[i] = spriteQuantity;

                    }
                    
                    //puts the button associated with the item picked up
                    Instantiate(itemButton, inventory.slots[i].transform, false);
                    //destroys the object
                    Destroy(gameObject);
                    print("object picked up");
                    break;


                }

            }
        }

    }

}
