using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPush : MonoBehaviour {
    public float distance = 1f;
    public LayerMask boxMask;
    
    public GameObject box;
    public AudioSource pushingbox;

	// Use this for initialization
	void Start () {
        pushingbox.playOnAwake = false;
    }
	
	// Update is called once per frame
	void Update () {
        Physics2D.queriesStartInColliders = false; //avoid players colliders
        RaycastHit2D hitR = Physics2D.Raycast (transform.position, Vector2.right * transform.localScale.x, distance, boxMask); //right raycast
        RaycastHit2D hitL = Physics2D.Raycast(transform.position, Vector2.left * transform.localScale.x, distance, boxMask); //left raycast


        if (hitR.collider != null && hitR.collider.gameObject.tag == "Pushable" && Input.GetKeyDown(KeyCode.C))
        {
            box = hitR.collider.gameObject;
            //Checking if you are on the right of the object and if so then push the box and attach it to the players rigidbody so they stick together nicely
            Debug.Log("Moving Right\n");
            box.GetComponent<FixedJoint2D>().enabled = true;
            box.GetComponent<boxstop>().Pushing = true;
            box.GetComponent<FixedJoint2D>().connectedBody = this.GetComponent<Rigidbody2D>();
            pushSound.pushing = true;
            pushingbox.Play();
            
        }
        else if (hitL.collider != null && hitL.collider.gameObject.tag == "Pushable" && Input.GetKeyDown(KeyCode.C))
        {
            box = hitL.collider.gameObject;
            //same as above just checking for the left side
            Debug.Log("Moving Left\n");
            box.GetComponent<FixedJoint2D>().enabled = true;
            box.GetComponent<boxstop>().Pushing = true;
            box.GetComponent<FixedJoint2D>().connectedBody = this.GetComponent<Rigidbody2D>();
            pushSound.pushing = true;
            pushingbox.Play();
            
        }
        else if (Input.GetKeyUp(KeyCode.C))
        {
            box.GetComponent<FixedJoint2D>().enabled = false;
            box.GetComponent<boxstop>().Pushing = false;
            pushSound.pushing = false;
            pushingbox.Stop();
           
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        //Colour of raycasts for easy debugging

        Gizmos.DrawLine(transform.position, (Vector2)transform.position + Vector2.right * transform.localScale.x * distance);
        Gizmos.DrawLine(transform.position, (Vector2)transform.position + Vector2.left * transform.localScale.x * distance);
       
    }
}
