using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverContinue : MonoBehaviour {

    public static bool BossRoomAccessed;
	public static bool StealthAccessed;
    public static bool PuzzleRoomAccessed = false;
    

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    public void Continue()
    {
        if (BossRoomAccessed == true)
        {
			PuzzleRoomAccessed = false;
			StealthAccessed = false;
			SceneManager.LoadScene(12);
			

        }
        else if (StealthAccessed == true)
        {
			SceneManager.LoadScene(10);

		}
        else if(PuzzleRoomAccessed == true)
        {
            ItemPuzzleRoom.ItemPuzzleComplete = false;
            SceneManager.LoadScene(5);
        }
        
        else
        {

           // SceneChange.ManualChange(Index);
            
        }


    }

}
