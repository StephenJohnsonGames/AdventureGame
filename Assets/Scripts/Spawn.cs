using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    private Transform player;
    public GameObject item;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    //spawns the item above the player
    public void SpawnDroppedItem()
    {
        //figures out where to drop the item in relation to the player
        Vector3 playerPos = new Vector3(player.position.x + 2, player.position.y, player.position.z);
        //drops the item related to the object removed
        Instantiate(item, playerPos, Quaternion.identity);

    }

    public void DontSpawnDropped()
    {

        print("destroyed item");

    }
}
