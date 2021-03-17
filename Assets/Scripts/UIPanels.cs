using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIPanels : MonoBehaviour {

    public GameObject InventoryPanel;
    public GameObject CraftingPanel;
    //public GameObject tutorialBox;
    //public GameObject Map;
    bool inventActive;
    public static bool tutActive;
   

	// Use this for initialization
	void Start () {

        InventoryPanel.SetActive(false);
        inventActive = false;
        CraftingPanel.SetActive(false);
        

    }
	
	// Update is called once per frame
	void Update () {

        bool tabPressed = Input.GetKeyDown(KeyCode.Tab);
        

        if (tabPressed)
        {
            if (inventActive == false)
            {

                ShowInvent();
               

            }
            else
            {

                HideInvent();
                

            }
            
           

        }

        if (tutActive == true)
        {

            ShowTutBox();

        }
        else
        {

            HideTutBox();

        }




    }

    void ShowInvent()
    {

        InventoryPanel.SetActive(true);
        //CraftingPanel.SetActive(true);
        inventActive = true;

    }

    void HideInvent()
    {

                InventoryPanel.SetActive(false);
                //CraftingPanel.SetActive(false);
                inventActive = false;

    }

    void HideTutBox()
    {

        //tutorialBox.SetActive(false);


    }
    void ShowTutBox()
    {

        //tutorialBox.SetActive(true);


    }

}
