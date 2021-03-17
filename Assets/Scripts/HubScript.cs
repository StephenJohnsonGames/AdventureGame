using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HubScript : MonoBehaviour {

    public GameObject itemPuzzleAccess;

	// Use this for initialization
	void Start () {
		
        if (ItemPuzzleRoom.ItemPuzzleComplete == true)
        {

            itemPuzzleAccess.SetActive(true);

        }
        else
        {

            itemPuzzleAccess.SetActive(false);

        }

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
