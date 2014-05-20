using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Schism;

[System.Serializable]
public class Inventory : MonoBehaviour 
{
    public List<Slot> equipment = new List<Slot>();                  //This is a list of the equipment slots for this character's inventory
    public List<Slot> inventoryItems = new List<Slot>();             //This is a list of the item slots for this character's inventory

    public Slot headGear = new Slot();          //Create the headgear slot
    public Slot shirt = new Slot();             //Create the shirt slot
    public Slot gloves = new Slot();            //Create the gloves slot
    public Slot pants = new Slot();             //Create the pants slot
    public Slot shoes = new Slot();             //Create the shoes slot
    public Slot jacket = new Slot();            //Create the jacket slot
    public Slot rightWeapon = new Slot();       //Create the right weapon slot
    public Slot leftWeapon = new Slot();        //Create the left weapon slot
    public Slot belt = new Slot();              //Create the belt slot
    public Slot glasses = new Slot();           //Create the glasses slot
    public Slot rightArmGear = new Slot();      //Create the right arm gear slot
    public Slot leftArmGear = new Slot();       //Create the left arm gear slot

    //Create a default constructor for our inventory class
    public Inventory()
    {
        //Add the default equipment slots to our equipment list
        equipment.Add(headGear);
        equipment.Add(shirt);
        equipment.Add(gloves);
        equipment.Add(pants);
        equipment.Add(shoes);
        equipment.Add(jacket);
        equipment.Add(rightWeapon);
        equipment.Add(leftWeapon);
        equipment.Add(belt);
        equipment.Add(glasses);
        equipment.Add(rightArmGear);
        equipment.Add(leftArmGear);
    }
	
}
