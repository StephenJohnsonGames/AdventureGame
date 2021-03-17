using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour {

    //carrys through the dialogue vairables to the character
    public Dialogue dialogue;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //activates when the player walks into the collision
    public void OnTriggerEnter2D(Collider2D other)
    {

        TriggerDialogue();

    }

    //what starts the dialogue
    public void TriggerDialogue ()
    {

        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);

    }


}
