using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxDrop : MonoBehaviour {
    public GameObject Fence; //get the fence object
    public static bool LastFence = false; //the checker for if the object is still intact or not
	// Use this for initialization

 
        void OnTriggerEnter2D(Collider2D other)
        {
            if( other.CompareTag("Hole"))
            {
                Fence.SetActive(false); //if you enter collider turn the fence object off so player can pass through
                LastFence = true; //last fence is now true 
            ItDisCom.completion = true; //so puzzle must be complete
            }
        }

}
