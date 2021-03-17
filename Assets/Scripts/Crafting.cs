using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crafting : MonoBehaviour {

    //not in use for prototype but a deep work in progress requires quantity for full functionality
    private Inventory inventory;
    private Transform player;

    int numOfWood = 0, numOfEarth = 0, numOfWater = 0, numOfWeapon = 0;
    int woodToRemove = 0, earthToRemove = 0;

    public bool woodTaken;
    public bool pWoodTaken;
    public bool earthTaken;
    

    private bool swordSpawned;
    private bool platSpawned;
    public GameObject Sword;
    public GameObject Platform;

    public static bool earthRemoveButton;

    //public GameObject itemButton;


    // Use this for initialization
    void Start () {

        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        player = GameObject.FindGameObjectWithTag("Player").transform;

    }
	
	// Update is called once per frame
	void Update () {
		
        if (woodTaken == true && earthTaken == true && swordSpawned == false)
        {

            swordSpawned = true;
            Vector2 playerPos = new Vector2(player.position.x, player.position.y + 0);
            Instantiate(Sword, playerPos, Quaternion.identity);
            swordSpawned = true;
            numOfWood = 0;
            numOfEarth = 0;
            earthToRemove = 0;
            woodToRemove = 0;

        }

        if (pWoodTaken == true && earthTaken == true && platSpawned == false)
        {

            platSpawned = true;
            Vector2 playerPos = new Vector2(player.position.x, player.position.y + 0);
            Instantiate(Platform, playerPos, Quaternion.identity);
            swordSpawned = true;
            numOfWood = 0;
            numOfEarth = 0;
            earthToRemove = 0;
            woodToRemove = 0;

        }


    }

    public void CraftSword()
    {

        for (int i = 0; i < inventory.slots.Length; i++)
        {

            if (inventory.isWood[i] == true)
            {


                numOfWood = numOfWood + 1;//inventory.quantityOfItem[i];
                               
                //If the child was found.

                print("num of wood " + numOfWood);

            }

            if (inventory.isEarth[i] == true)
            {


                numOfEarth = numOfEarth + 1; // inventory.quantityOfItem[i];

                                           
                print("num of earth" + numOfEarth);

            }
                                   
        }

        if (numOfWood >= 1 && numOfEarth >= 3)
        {

            TakeAndCraftSword();
            
        }
        else
        {

            CannotCraft();

        }
        //print("doing things");

    }

    public void TakeAndCraftSword()
    {

        print("will craft");
        for (int i = 0; i < inventory.slots.Length; i++)
        {

            if (inventory.isWood[i] == true)
            {
                
                if (woodToRemove < 1)
                {

                    woodToRemove = woodToRemove + 1;
                    WoodSprite.removeButton = true;
                    print("removed 1 wood");
                    
                }
               
                               
                
                if (woodToRemove == 1)
                {
                    //WoodSprite.removeButton = false;
                    woodTaken = true;
                    

                }

            }

           
        }
        

            for (int i = 0; i < inventory.slots.Length; i++)
            {


                if (inventory.isEarth[i] == true)
                {

                    

                    if (earthToRemove < 3)
                    {

                        EarthSprite.removeButton = true;
                        earthToRemove = earthToRemove + 1;

                        print("removed one earth");

                    }

                    if (earthToRemove == 3)
                    {

                        earthTaken = true;
                        //EarthSprite.removeButton = false;

                    }

                }

            }
          
            

    


    }

    public void CraftPlatform()
    {

        for (int i = 0; i < inventory.slots.Length; i++)
        {

            if (inventory.isWood[i] == true)
            {


                numOfWood = numOfWood + 1;

                //If the child was found.

                print("num of wood " + numOfWood);

            }

        }

        if (numOfWood <= 4)
        {

            TakeAndCraftPlat();

        }
        else
        {

            CannotCraft();

        }
        //print("doing things");

    }

    public void TakeAndCraftPlat()
    {

        print("will craft");
        for (int i = 0; i < inventory.slots.Length; i++)
        {

            if (inventory.isWood[i] == true && woodToRemove < 4)
            {

                woodToRemove = woodToRemove + 1;
                WoodSprite.removeButton = true;


                print("removed 1 wood");
                if (woodToRemove == 4)
                {

                    pWoodTaken = true;
                    numOfWood = 0;
                    numOfEarth = 0;
                    earthToRemove = 0;
                    woodToRemove = 0;

                }

            }


        }

    }


    


    public void CannotCraft()
    {

        print("cannot craft");
        numOfWood = 0;
        numOfEarth = 0;
        earthToRemove = 0;
        woodToRemove = 0;

    }


}
