using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pushSound : MonoBehaviour {
    //script currently unused because have not added the correct sound into the game files yet but when that happens this script will be used to play a sound when player pushes any box

    public static bool pushing = false;
    public AudioSource pushingSound;
	// Use this for initialization
	void Start () {
        pushingSound = GetComponent<AudioSource>();
        pushingSound.playOnAwake = false;
    }
	
	// Update is called once per frame
	void Update () {
        PlaySound();
	}

    void PlaySound()
    {
        if(pushing == true)
        {
            pushingSound.Play();
            Debug.Log("PUSH");
        }
        else
        {
            pushingSound.Stop();
        }
    }
}
