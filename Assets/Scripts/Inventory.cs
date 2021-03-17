using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {
    //all the varibles associated to the each slot in the inventory
    public bool[] isFull;
    public bool[] isWood;
    public bool[] isEarth;
    public bool[] isWater;
    public bool[] isWeapon;
    public bool[] isPlatform;
    public int[] quantityOfItem;
    public GameObject[] slots;
    public GameObject[] quantity;
    
}
