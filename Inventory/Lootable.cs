using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Lootable : MonoBehaviour 
{

	public List<Item> lootItems = new List<Item>();		    //A list of items we can loot from this object
	public int[] chosenItem;							    //An array to index our loot items
	public bool[] looted;								    //An array of loot conditions so we can control when to display the button for each loot item
    public InventoryGUI inventoryGUI;                       //Get a reference to our inventory GUI object
	public int numberOfItems;							    //Our randomly generated number of items we can loot from this object
	public bool looting;								    //A condition to determine if we are curently displaying the loot items
	public bool lootReady;								    //A condition to determine if the number of items and specific items have been decided as the loot
	public Vector3 mousePosition;                           //To store our current mouse position
    private GameObject groupController;                     //A reference to our Group Controller so we can calculate our distance from the lootable object
    private float distance;                                 //A variable to store our distance from the group controller
    public float minDistance = 2.0f;                        //The minimum distance we want to be away from the object in order to loot the object
    public float maxDistance = 5.0f;                        //The distance we want to be away from the lootable object before the loot window automatically closes.
    public Texture2D closeButton;                           //A reference for our close button
    public Vector2 closeButtonRect = new Vector2(10, 10);   //The dimensions of the close button

    void Start()
    {
        groupController = GameObject.Find("GroupController");
    }

	//Check to see if we have clicked on this object
	void OnMouseDown()
	{
        if (distance < minDistance)
        {
            looting = !looting;                             //If we have clicked on it, trigger the looting condition true or false depending on its current state
        }
		
	}

	void Update()
	{
        //activeCharacter = PartyManager.Instance.activeCharacter;
		mousePosition = new Vector3(Input.mousePosition.x, Screen.height - Input.mousePosition.y, 0);

        distance = Vector3.Distance(this.transform.position, groupController.transform.position);

        if (distance > maxDistance)
        {
            looting = false;
        }
	}

	public void OnGUI()
	{
		if(looting)														//If we are looting
		{
			if(!lootReady)												//And our loot has not been decided yet
			{
				numberOfItems = Random.Range(2, 6);						//Assign the number of items in the loot object a random value
				chosenItem = new int[numberOfItems];					//Create an array with an index equal to the number of items
				looted = new bool[numberOfItems];						//Assign our looted condition to each index in number of items

				for(int i = 0; i < numberOfItems; i++)					//Iterate through for each item
				{
					chosenItem[i] = Random.Range(0, lootItems.Count);	//Make our currently indexed chosen item a random item
					looted[i] = false;									//Reset the looted condition
				}
				lootReady = true;										//Tell our loot ready condition that the loot has been decided
			}

			//Draw a box to display the loot items.  The box is drawn dynamically based on how many loot items there are
			GUI.BeginGroup(new Rect((Screen.width * .5f) - ((numberOfItems * 69) * .5f), (Screen.height * .5f) - 74, 10 + (numberOfItems * 64) + closeButtonRect.x, 95), "Loot", "Box");
            if (GUI.Button(new Rect(numberOfItems * 64, 5, closeButtonRect.x, closeButtonRect.y), closeButton))
            {
                looting = false;
            }
			for(int i = 0; i < numberOfItems; i++)						//Iterate through each of our randomly determined loot items
			{
				if(looted[i] == false)									//Check that we have not already looted this item
				{
					//Draw a button containing the item icon.  As long as the looted condition is false, the button will be drawn,
					//	but when we click the button and the item is added to the inventory, the button dissapears.  Also, display
					//	the item's description as a tooltip when we hover over the button.
					if(GUI.Button (new Rect(5 + (i * 64), 25, 64, 64), new GUIContent(lootItems[chosenItem[i]].icon, lootItems[chosenItem[i]].description)))
					{
						//When we click the button, call our AddItem() method in the Inventory Class
						inventoryGUI.AddItem(lootItems[chosenItem[i]]);
						looted[i] = true;											//Reset the looted condition for this button
					}
				}
			}


			GUI.EndGroup();				//End the GUI group for the box that contains the lootable item icons
		}
		if(GUI.tooltip != "")			//Check if we have information that needs to be displayed in a tooltip
		{
			GUI.Label(new Rect(mousePosition.x, mousePosition.y - 50, 200, 50), GUI.tooltip); 	 //Draw the tooltip box
		}
	}
}
