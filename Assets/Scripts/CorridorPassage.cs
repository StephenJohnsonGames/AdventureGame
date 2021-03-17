using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorridorPassage : MonoBehaviour {

    //public GameObject ItemPuzzle;
    public GameObject SpritePuzzle;
    public GameObject Continue;


	// Use this for initialization
	void Start () {
        //SpritePuzzleRoom.SpritePuzzleComplete = true; 
        //Tom create a 'public static bool ItemPuzzleComplete' in the script then untag this below
        if (SpritePuzzleRoom.SpritePuzzleComplete == true && ItemPuzzleRoom.ItemPuzzleComplete == true)
        {
            //print("working");
            Continue.SetActive(true);


        }
        else
        {

            Continue.SetActive(false);

        }

        if (SpritePuzzleRoom.SpritePuzzleComplete == true)
        {

            SpritePuzzle.SetActive(true);

        }
        else
        {

            SpritePuzzle.SetActive(false);

        }

        //same here for below
        //if (ItemPuzzleRoom.ItemPuzzleComplete == true)
        //{

        //    SpritePuzzle.SetActive(true);

        //}
        //else
        //{

        //    SpritePuzzle.SetActive(false);

        //}

        print(SpritePuzzleRoom.SpritePuzzleComplete);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
