using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItDisCom : MonoBehaviour {

    public GameObject Fence; //fence blocking exit
    public static bool completion = false; //have you completed this room before

	// Use this for initialization
	void Start () {
        Fence.SetActive(true); //blocking ppath forward upon entry
	}
	
	// Update is called once per frame
	void Update () {
        CompleteditMate();	//check for completion 
	}

    void CompleteditMate()
    {

        if (completion == true)
        {
            Fence.SetActive(false);
            //if you have placed the block over the floor switch the fence is turned off allowing progression
        }
    }
}
