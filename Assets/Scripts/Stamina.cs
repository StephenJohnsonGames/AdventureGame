using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stamina : MonoBehaviour {
    public float totalStamina = 200.0f, currentStamina;
    //public float walkspeed, runspeed;
    private bool staminaEmpty;
    //private float StaminaRegenTimer = 0.0f;

    bool isRunning;

    private const float StaminaDecreasePerFrame = 1.0f;
    private const float StaminaIncreasePerFrame = 5.0f;
    private const float StaminaTimeToRegen = 3.0f;

    public static bool StaminaIncreasebool = false;
    public static bool StaminaEmpty = false;

    // Use this for initialization
    void Start () {

        //currentStamina = totalStamina;

    }
	
	// Update is called once per frame
	void Update () {

        //for when runninmg
        bool isRunning = Input.GetKey(KeyCode.LeftShift);


        if (StaminaIncreasebool == false)
        {
            if (isRunning)
            {
                currentStamina -= 2 * Time.deltaTime * 5;
                transform.localScale = new Vector3((currentStamina / totalStamina), 1, 1);
            }
            else if (currentStamina < totalStamina)
            {
                IncreaseStamina();
                transform.localScale = new Vector3((currentStamina / totalStamina), 1, 1);

            }
        }

        if (StaminaIncreasebool == true)
        {
            
            StaminaIncrease();
            StaminaIncreasebool = false;

        }

        if (currentStamina >= 200)
        {
            
            currentStamina = 200;
            transform.localScale = new Vector3((currentStamina / totalStamina), 1, 1);

        }

        if (currentStamina <= 200)
        {

            StaminaEmpty = false;

        }

        if (Input.GetKeyDown("space"))
		{
			if(currentStamina >= 3)
			{
				currentStamina -= 3;

			}

		}

        if (currentStamina <= 0)
        {

            StaminaEmpty = true;

        }


    }

    void IncreaseStamina()
    {
               //handles what it increases per frame
            currentStamina += 6.0f * Time.deltaTime * 1;
            transform.localScale = new Vector3((currentStamina / totalStamina), 1, 1);

    }

    public void StaminaIncrease()
    {

        currentStamina = currentStamina + 20;
        transform.localScale = new Vector3((currentStamina / totalStamina), 1, 1);

    }


}
