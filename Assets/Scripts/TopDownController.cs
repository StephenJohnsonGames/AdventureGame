using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownController : MonoBehaviour {
	
	//alpha components for the sprite texture
	public float alphaLevel = 0.1f;
	public float alphaOpaque = 1.0f;
    public Animator animator;
	public Rigidbody2D rb; //for smooth collision with colliders
	public float moveSpeed = 5; //to speed up movement 
	public float timerforsword;
	bool swordAnimation = false;
    public AudioSource thud;



    

	
	// Use this for initialization
	void Start () {
        GetComponent<AudioSource>().playOnAwake = false;
        //GetComponent<AudioSource>().clip = thud;
        thud = GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update () {
	Vector3 MV = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f); //allows for 8-Dir Movement 
                                                                                        //transform.position = transform.position + MV * Time.deltaTime * moveSpeed; //depricated 

        animator.SetFloat("Horizontal", MV.x);
        animator.SetFloat("Vertical", MV.y);
        animator.SetFloat("Magnitude", MV.magnitude);
        
		rb.velocity = new Vector2(MV.x, MV.y) * moveSpeed; //Allows for movement to be smooth and fast 


		if (swordAnimation == true)
		{
			timerforsword++;
			
			if (timerforsword == 75)
			{
				animator.SetBool("Sword", false);
				
			}
			if(timerforsword >= 100)
			{
				swordAnimation = false;
				

			}

		}
		
	}
	//if item has a stealth tag, reduce alpha
    void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Stealth"))
		{
			GetComponent<Renderer>().material.color = new Color(1, 1, 1, alphaLevel);
            transform.gameObject.tag = "Stealth";
            //cube.GetComponent<Renderer>().material.GetColour();
            //											
            // Use this for initialization
        }

		if (other.CompareTag("Sword"))
		{

			animator.SetBool("Sword", true);
			swordAnimation = true;
			
			
		}

	}

    //return to opaque alpha on exit
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Stealth"))
        {
            GetComponent<Renderer>().material.color = new Color(1, 1, 1, 1);
            transform.gameObject.tag = "Player";
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        thud.Play();
        Debug.Log("Thud");
    }

}
