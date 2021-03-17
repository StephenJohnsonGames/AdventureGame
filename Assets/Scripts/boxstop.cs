using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boxstop : MonoBehaviour {


    public bool Pushing; //pushing checker
    float posX; 
    float posY;
	// Use this for initialization
	void Start () {
        posX = transform.position.x; //setting position on X
        posY = transform.position.y; //setting position on Y
    }
	
	// Update is called once per frame
	void Update () {
        if (Pushing == false)
        {
            transform.position = new Vector3(posX, posY); //If pushing isn't true keep box static

        }
        else
            posX = transform.position.x; //update position accordingly
            posY = transform.position.y;
    }
}
