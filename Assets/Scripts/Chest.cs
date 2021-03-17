using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour {

	public Animator anim;
	public GameObject sword;
	BoxCollider2D m_Collider;


	// Use this for initialization
	void Start () {

		anim = gameObject.GetComponent<Animator>();
		m_Collider = GetComponent<BoxCollider2D>();
		sword.SetActive(false);
	}

	// Update is called once per frame

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.CompareTag("Player"))
		{
			anim.SetBool("Open", true);
			m_Collider.enabled = !m_Collider.enabled;
			sword.SetActive(true);

		}
	}

}
