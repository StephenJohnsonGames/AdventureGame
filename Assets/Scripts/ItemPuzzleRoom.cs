using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPuzzleRoom : MonoBehaviour {

    public static bool ItemPuzzleComplete = false; //have you completed the puzzle
    
    private void Start()
    {
        GameOverContinue.PuzzleRoomAccessed = true; //if die in the room it will reload this room 
      
    }
    private void Update()
    {
        if (BoxDrop.LastFence == true)
        {
            ItemPuzzleComplete = true;
            Debug.Log("puzzle complete\n");
            //if the last fence is gone then the puzzle is complete 
        }
    }

    
}
