using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FlickOn : MonoBehaviour {
    public Animator Lanimator; //Lever's Animator
    public GameObject Hub; //transition to next level
    public GameObject Fence; //fence blocking other box
    bool Open = false; 
    public GameObject Player; //the player
    public GameObject lastFence; //the fence blocking the next level transition
    public AudioSource leverClick;

	// Use this for initialization
	void Start () {
        leverClick.playOnAwake = false;
        Lanimator = gameObject.GetComponent<Animator>(); //make sure the object knows it has animation
        Hub.SetActive(false); //transition off
        if (ItemPuzzleRoom.ItemPuzzleComplete == true)
        {

            Hub.SetActive(true);
            lastFence.SetActive(false); 
            //if you have completed the puzzle then don't reset when leaving the room
        }

    }
	
	// Update is called once per frame
	void Update () {

        CheckIfOpen();
	}

    void CheckIfOpen()
    {
        float playerX = Player.transform.position.x;
        float leverXoffset = this.transform.position.x + 2.0f;
        float leverX = this.transform.position.x;
        if (playerX < leverXoffset && playerX > leverX)
        {
            OpenSesame();
            Debug.Log("oPENsEsAmE");
            //checking if the player is in close range of the lever as to be able to access it
        }
    }

    void OpenSesame()
    {
       
        
            if (Input.GetKeyDown(KeyCode.C))
            {
                Lanimator.SetBool("ClickedOn", true); //play animation for the lever
                Open = true;
            //play sound ------------
            leverClick.Play();
            }

            if (Open == true)
            {
                Hub.SetActive(true);
                Fence.SetActive(false);
            //complete this part of the puzzle
            }
            else
            {
                Hub.SetActive(false);
                Fence.SetActive(true);
            //make sure the completion state is not achieved accidentally 
            }
        
        
        
    }

}
