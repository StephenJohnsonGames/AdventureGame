using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdWall : MonoBehaviour
{

	public GameObject Wood;
	private Inventory inventory;
	private int woodToRemove;
	public GameObject Collider;
	BoxCollider2D m_Collider;


	void Start()
	{
		m_Collider = GetComponent<BoxCollider2D>();
		inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
		GetComponent<Renderer>().material.color = new Color(1, 1, 1, 0.3f);
		Collider.SetActive(false);
		


	}

	void OnTriggerEnter2D(Collider2D other)
	{

		if (other.CompareTag("Player"))
		{
			print("start loop");
			for (int i = 0; i < inventory.slots.Length; i++)
			{

				if (inventory.isWood[i] == true)
				{

					if (woodToRemove <= 1)
					{

						GetComponent<Renderer>().material.color = new Color(1, 1, 1, 1);

						woodToRemove = woodToRemove + 1;

						WoodSprite.removeButton = true;
						print("removed 1 wood");

						Collider.SetActive(true);

						m_Collider.enabled = !m_Collider.enabled;



					}

				}

			}
		}
	}
}