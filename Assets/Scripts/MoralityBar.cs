using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoralityBar : MonoBehaviour {

    private float totalMoral = 100;
    public static float currentMoral;

    private float minMoral = 5;
    public static bool Increase = false;
    public Image moralBar;

    // Use this for initialization
    void Start()
    {

        currentMoral = 50;

    }

    // Update is called once per frame
    void Update()
    {
        if (Increase == true)
        {


        }
        if (currentMoral <= 100)
        {

            totalMoral = 100;
            transform.localScale = new Vector3((currentMoral / totalMoral), 1, 1);
            moralBar.GetComponent<Image>().color = new Color(0.6858f, 0.2892f, 0.9433f, 1);
            

        }
        if (currentMoral <= 0)
        {

            currentMoral = 0;
            transform.localScale = new Vector3((currentMoral / totalMoral), 1, 1);

        }
        if (currentMoral >= 100)
        {

            currentMoral = 100;
            transform.localScale = new Vector3((currentMoral / totalMoral), 1, 1);
            moralBar.GetComponent<Image>().color = new Color(1f, 0.9f, 0f, 1);

        }
        if (currentMoral >= 70)
        {

            currentMoral = 100;
            transform.localScale = new Vector3((currentMoral / totalMoral), 1, 1);
            moralBar.GetComponent<Image>().color = new Color(1f, 0.9f, 0f, 1);

        }

    }


}
