using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrowSound : MonoBehaviour {
    public AudioClip Crow; //the clip of sound
    public GameObject CrowObject; //the object in game that has a collider trigger for the sound to play
    int time = 0; //checker for playing the sound once
	// Use this for initialization
	void Start () {
        GetComponent<AudioSource>().playOnAwake = false; //do not play on start up
        GetComponent<AudioSource>().clip = Crow; //the audio clip is the crow
	}

    void Update()
    {
        PlaySound();   
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        time += 1; //when entering the collider increment the checker
        
    }

    void PlaySound()
    {
        if (time == 1)
        {
            GetComponent<AudioSource>().Play(); //if this is the first time you have entered the collider then play crow sound
        }
    }
    
}
