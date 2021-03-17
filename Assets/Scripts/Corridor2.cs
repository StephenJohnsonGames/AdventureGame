using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corridor2 : MonoBehaviour {

    public static bool ObtainedSword;

    public GameObject BossAccess;

	// Use this for initialization
	void Start () {

        //corridor2.ObtainedSword = true;
        if (ObtainedSword == true)
        {

            BossAccess.SetActive(true);

        }
        else
        {

            BossAccess.SetActive(false);

        }
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
