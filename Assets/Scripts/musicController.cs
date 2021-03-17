using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicController : MonoBehaviour {

    public AudioSource mainMusic; //main music for any given level
    public AudioSource victory;
    public AudioSource PunchedDeath;
    public AudioSource WeakPointDeath;
    bool playOnce = false;
	// Use this for initialization
	void Start () {
        //GetComponent<AudioSource>().playOnAwake = false; depricated
        victory.playOnAwake = false;
        PunchedDeath.playOnAwake = false;
        WeakPointDeath.playOnAwake = false;
        mainMusic = GetComponent<AudioSource>(); //telling it has audiosource
       // DontDestroyOnLoad(mainMusic); depricated; in case we wanted one track to play consistently throughout all the levels
    }
	
	// Update is called once per frame
	void Update () {
        if (Boss.dead == true && playOnce == false && WeakPointDeath == false)
        {
        CompletedLevel1();
            playOnce = true;
        }
        if (Boss.dead == true && playOnce == false && WeakPointDeath == true)
        {
            CompletedLevel2();
            playOnce = true;
        }
    }

    void CompletedLevel1()
    {
       
            
            mainMusic.Stop();
        //death sound
        PunchedDeath.Play();
            victory.PlayDelayed(2);
            
        
    }
    void CompletedLevel2()
    {
        mainMusic.Stop();
        //death sound
        WeakPointDeath.Play();
        victory.PlayDelayed(2);
    }
}
