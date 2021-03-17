using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpritePuzzleRoom : MonoBehaviour {

    public static bool SpritePuzzleComplete;
    private Inventory inventory;
    private int earthToRemove;
    public bool keypressed;
    public GameObject hole;
    public AudioSource droppingSprite;

    // Use this for initialization
    void Start () {
        droppingSprite.playOnAwake = false;
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        //checks whether is has been complete before
        if (SpritePuzzleComplete == true)
        {

            hole.SetActive(false);

        }

    }
	
	// Update is called once per frame
	void Update () {

        

        //if (Input.GetKeyDown(KeyCode.E) == true)
        //{

        //    keypressed = true;
        //    print("key is pressed");

        //}
        //if (Input.GetKeyUp(KeyCode.E) == true)
        //{

        //    keypressed = false;

        //}
    }

    //happens when player enters the collider
    void OnTriggerEnter2D(Collider2D other)
    {
        //print("key pressed");
            if (other.CompareTag("Player") && SpritePuzzleComplete == false)
            {
            print("start loop");
                for (int i = 0; i < inventory.slots.Length; i++)
                {
                    
                    //checks whether the item is a earth sprite
                    if (inventory.isEarth[i] == true)
                    {

                        if (earthToRemove <= 1)
                        {
                            //math
                            earthToRemove = earthToRemove + 1;
                        //removes earth sprite
                            EarthSprite.removeButton = true;
                            print("removed 1 earth");
                        //break;
                        //SOUND HERE ---------------
                        droppingSprite.Play();
                            //vairible to use for corridor
                            SpritePuzzleComplete = true;
                            //hides the black cover over the slot
                            hole.SetActive(false);
                        }

                    }
                    else
                    {

                        print("need more earth");
                        //break;
                    }
                
                }

            }
        }
    }

