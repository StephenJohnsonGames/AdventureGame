using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NoJail : MonoBehaviour {
    public GameObject Fence; //fence blocking the lever
    public GameObject Box; //the box needed to complete the puzzle
    public GameObject tile; //the pit object the box falls into
    public GameObject player; //the player
    
    // Use this for initialization


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Pushable"))
        {
            Fence.SetActive(false);

            Destroy(Box);
            Destroy(tile);
            //if the player drops the box in the hole destroy the necessary objects so the lever can be reached and turn the initial fence off 
        }
        else
        {
            Destroy(player);
            SceneManager.LoadScene(14);
            //if the player falls into the hole, kill them and reload the scene
        }
    }
}
