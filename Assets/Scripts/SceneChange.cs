using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneChange : MonoBehaviour {

	public int index;

	// Use this for initialization
	void OnTriggerEnter2D(Collider2D other) {
		if (other.CompareTag("Player"))
		{
			SceneManager.LoadScene(index);
	
		}
	}

    //private void Update()
    //{
        
    //    if (HealthBar.dead == true)
    //    {

    //        SceneManager.LoadScene(13);         

    //    }

    //}
    public static void ManualChange(int Index)
    {

        SceneManager.LoadScene(Index);
      

    }
	
	//restart level
	//SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
}
