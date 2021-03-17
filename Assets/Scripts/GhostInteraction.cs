using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GhostInteraction : MonoBehaviour {

    private Inventory inventory;
    private readonly string[] Tutorials = new string[100];
    //private string tutorial;
    private Text msgAreaTxtBox;
    private Text GhostName;
    //public GameObject InfoPanel;
    public string gname;
    public int Index;
    private int changingIndex;
    private bool End;
    private bool alreadyTalking;

    // Use this for initialization
    void Start ()
    {

        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
        msgAreaTxtBox = GameObject.Find("msgAreaTxtBox").GetComponent<Text>();
        GhostName = GameObject.Find("GhostName").GetComponent<Text>();
        UIPanels.tutActive = false;

    }
    void Main()
    {

        Tutorials[0] = "Hi Ent, Welcome to the HUB, to move around use your movement keys W, A, S and D this will help you navigate through each level!";
        Tutorials[1] = "Another thing If you Press the [Tab] key this will open your inventory.";
        Tutorials[2] = "Once you have done this you will be able to select sprites you want to use!";
        Tutorials[3] = " ";
        Tutorials[4] = " ";
        Tutorials[5] = " ";
        Tutorials[6] = " ";
        Tutorials[7] = " ";
        Tutorials[8] = " ";
        Tutorials[9] = " ";
        //introduces sprites
        Tutorials[10] = "Hi Ent!";
        Tutorials[11] = "Throughout each level there will be a several sprites that will be collectables.";
        //introducing wood sprites
        Tutorials[12] = "This is the Wood Sprite.";
        Tutorials[13] = "This sprite gives the ability for you increase your health when is has been lost";
        //introducing water sprites
        Tutorials[14] = "This is the Water Sprite";
        Tutorials[15] = "This sprite gives the ability for you increase your Attacking Stamina when is has been lost";
        //introducing Earth Sprites
        Tutorials[16] = "This is the Earth Sprite";
        Tutorials[17] = "This sprite maybe asked to creat certain items or to help you through the tasks that lie ahead.";
        //Sprite Puzzle
        Tutorials[18] = "Hey Ent, i was hoping you could help me. This bucket needs something to weigh it down";
        Tutorials[19] = "I was hoping you could find some of your Earth Sprites I remember seeing some down in one of the corners";
    }
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown(KeyCode.F))
        {

            if (End == true)
            {

                //InfoPanel.SetActive(false);
                UIPanels.tutActive = false;
                End = false;
                msgAreaTxtBox.text = " ";
                GhostName.text = " ";
                changingIndex = 0;

            }
            else
            {

                
                NextInfo();
                

            }
            

        }
        

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (alreadyTalking == false)
        {
            print(Tutorials[Index]);
            UIPanels.tutActive = true;
            //InfoPanel.SetActive(true);
            msgAreaTxtBox.text = Tutorials[Index];
            GhostName.text = name;
            //End = true;
            changingIndex = Index; 
            alreadyTalking = true;

        }
    }

    void NextInfo()
    {


        changingIndex = changingIndex + 1;
        msgAreaTxtBox.text = Tutorials[changingIndex];

        if (changingIndex == 2)
        {

            End = true;

        }
        
        if (changingIndex == 11)
        {

            End = true;

        }

        if (changingIndex == 13)
        {

            End = true;

        }

        if (changingIndex == 15)
        {

            End = true;

        }
        if (changingIndex == 19)
        {

            End = true;

        }
    }

}
