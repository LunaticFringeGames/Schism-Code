using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Schism;

[System.Serializable]
public class InventoryGUI : MonoBehaviour
{
    public List<Inventory> inventory = new List<Inventory>();       //A List of each of the character's inventories
    public int activeCharacter;                                     //This is how we index our inventories with the currently selected character
    public Item clipboard = new Item();					            //A place to temporarily store the item we are currently dragging
    public int inventoryRows = 5;						            //The number of rows in our inventory matrix
    public int inventoryColumns = 5;					            //The number of columns in our inventory matrix
    public int totalSlots;								            //The total number of slots in our inventory matrix (max number of items we can carry)
    public Vector3 myMousePosition;						            //Keep track of the position of our mouse cursor
    private string invTooltip = "";                                 //A place to store our tooltip information since we need to display it outside of the window iteself
    public float OFFSET = 10;							            //The number of pixels we want offset our GUI elements
    public float PADDING = 5;							            //The number of pixels we want between the icons and slots
    public Vector2 SLOT = new Vector2(32, 32);			            //Define the dimensions of our inventory slots
    public Rect paperDollBox;                                       //Our rect to hold the box containing our equipment slots
    private Rect _inventoryWindow;                                  //Our inventory window Rect   
    private bool openWindow;                                        //A condition so we can trigger whether the inventory window is open or not
    public Texture2D[] defaultIcons;                                //An array of our default equipment icons
    public CharacterCam[] miniCam = new CharacterCam[6];                      //An array of references to each of character's miniCams so we can drop items onto them

    public void Start()
    {
        totalSlots = inventoryRows * inventoryColumns;		        //Calculate our total slots based on number of columns and rows in the inventory matrix
        //Define our box that hold the equipment slots
        paperDollBox = new Rect(OFFSET,
                                OFFSET,
                                (OFFSET + PADDING) + (inventoryColumns * PADDING) + (inventoryColumns * SLOT.x),
                                (inventoryRows * PADDING) + (inventoryRows * SLOT.x));
        //Define our inventory window
        _inventoryWindow = new Rect(200,
                                    OFFSET,
                                    (OFFSET + PADDING) + (inventoryColumns * PADDING) + (inventoryColumns * SLOT.x),
                                    paperDollBox.height + (OFFSET * 3) + PADDING + (inventoryRows * PADDING) + (inventoryRows * SLOT.y));
    }

    public void Update()
    {
        activeCharacter = PartyManager.Instance.activeCharacter - 1;                //Make our activeCharacter always reflect the global activeCharacter (-1 because globally we use 1-6)
       
        //This is a trigger event that switches our openWindow condition when you press the "i" key
        if (Input.GetKeyDown(KeyCode.I))
        {
            openWindow = !openWindow;
        }
    }

    public void OnGUI()
    {
        GUI.depth = 0;          //Set our GUI depth so that when we drag an item, the item icon appears on top of the other GUI elements

        myMousePosition = new Vector3(Input.mousePosition.x, Screen.height - Input.mousePosition.y, 0);         //Assign our mouse position

        GUI.Label(new Rect(myMousePosition.x, myMousePosition.y - 30, 300, 20), invTooltip);                    //Create the tooltip label

        //Display the inventory window if our openWindow condition is true
        if (openWindow)
        {
            _inventoryWindow = GUI.Window(activeCharacter, _inventoryWindow, WindowMethod, "Inventory");
        }

        if (clipboard.icon != null)		//Check that we have an icon in the clipboard
        {
            //If we do have an item in the clipboard, draw it so we can see it inside a box while we drag it
            GUI.Box(new Rect(myMousePosition.x - 32, myMousePosition.y - 32, 64, 64), clipboard.icon);
        }

        //This block of code allows us to drag and drop an item icon onto a minicam window and drop the item into that character's inventory
        if (clipboard != null)                                                          //Make sure we have an item in the clipboard
        {
            for (int i = 0; i < 6; i++)                                                 //Iterate through our minicam character boxes
            {
                if (miniCam[i].characterBox.Contains(Event.current.mousePosition))      //If our mouse cursor is over a character box...
                {
                    if (Event.current.type == EventType.MouseUp)                        //And we release the mouse button...
                    {
                        AddItem(clipboard, i);                                          //Add the item to the inventory associated with that character box
                        clipboard = new Item();                                         //Clear the clipboard
                    }
                }
            }
        }
    }

    //If the openWindow condition is true, this method calls the method to draw the controlls in the inventory window
    void WindowMethod(int windowID)
    {
        if (openWindow)
        {
            DrawInventoryWindow();
        }
    }

    //This is the method that draws all of the gui controlls in the inventory window
    void DrawInventoryWindow()
    {
        //First we draw all of the equipment slots.  since each one is unique, we can't do this inside of a loop so we define them manually
        inventory[activeCharacter].headGear.rect = new Rect((_inventoryWindow.width * .5f) - (SLOT.x * .5f), (OFFSET * 2) + PADDING, SLOT.x, SLOT.y);
        GUI.Box(inventory[activeCharacter].headGear.rect, new GUIContent(inventory[activeCharacter].headGear.item.icon, inventory[activeCharacter].headGear.item.description));

        inventory[activeCharacter].jacket.rect = new Rect((_inventoryWindow.width * .5f) - (SLOT.x * .5f), ((OFFSET * 2) + (PADDING * 2)) + SLOT.y, SLOT.x, SLOT.y);
        GUI.Box(inventory[activeCharacter].jacket.rect, new GUIContent(inventory[activeCharacter].jacket.item.icon, inventory[activeCharacter].jacket.item.description));

        inventory[activeCharacter].pants.rect = new Rect((_inventoryWindow.width * .5f) - (SLOT.x * .5f), ((OFFSET * 2) + (PADDING * 3)) + (SLOT.y * 2), SLOT.x, SLOT.y);
        GUI.Box(inventory[activeCharacter].pants.rect, new GUIContent(inventory[activeCharacter].pants.item.icon, inventory[activeCharacter].pants.item.description));

        inventory[activeCharacter].shoes.rect = new Rect((_inventoryWindow.width * .5f) - (SLOT.x * .5f), ((OFFSET * 2) + (PADDING * 4)) + (SLOT.y * 3), SLOT.x, SLOT.y);
        GUI.Box(inventory[activeCharacter].shoes.rect, new GUIContent(inventory[activeCharacter].shoes.item.icon, inventory[activeCharacter].shoes.item.description));

        inventory[activeCharacter].shirt.rect = new Rect((_inventoryWindow.width * .5f) + (SLOT.x * .5f) + PADDING, (OFFSET * 3) + (SLOT.y * .5f), SLOT.x, SLOT.y);
        GUI.Box(inventory[activeCharacter].shirt.rect, new GUIContent(inventory[activeCharacter].shirt.item.icon, inventory[activeCharacter].shirt.item.description));

        inventory[activeCharacter].leftArmGear.rect = new Rect((_inventoryWindow.width * .5f) + (SLOT.x * .5f) + PADDING, (OFFSET * 3) + ((SLOT.y * .5f) * 3) + PADDING, SLOT.x, SLOT.y);
        GUI.Box(inventory[activeCharacter].leftArmGear.rect, new GUIContent(inventory[activeCharacter].leftArmGear.item.icon, inventory[activeCharacter].leftArmGear.item.description));

        inventory[activeCharacter].gloves.rect = new Rect((_inventoryWindow.width * .5f) + (SLOT.x * .5f) + PADDING, (OFFSET * 3) + ((SLOT.y * .5f) * 5) + (PADDING * 2), SLOT.x, SLOT.y);
        GUI.Box(inventory[activeCharacter].gloves.rect, new GUIContent(inventory[activeCharacter].gloves.item.icon, inventory[activeCharacter].gloves.item.description));

        inventory[activeCharacter].leftWeapon.rect = new Rect((_inventoryWindow.width * .5f) + ((SLOT.x * .5f) * 3) + (PADDING * 2), (OFFSET * 3) + ((SLOT.y * .5f) * 3) + PADDING, SLOT.x, SLOT.y);
        GUI.Box(inventory[activeCharacter].leftWeapon.rect, new GUIContent(inventory[activeCharacter].leftWeapon.item.icon, inventory[activeCharacter].leftWeapon.item.description));

        inventory[activeCharacter].glasses.rect = new Rect((_inventoryWindow.width * .5f) - ((SLOT.x * .5f) * 3) - PADDING, (OFFSET * 3) + (SLOT.y * .5f), SLOT.x, SLOT.y);
        GUI.Box(inventory[activeCharacter].glasses.rect, new GUIContent(inventory[activeCharacter].glasses.item.icon, inventory[activeCharacter].glasses.item.description));

        inventory[activeCharacter].rightArmGear.rect = new Rect((_inventoryWindow.width * .5f) - ((SLOT.x * .5f) * 3) - PADDING, (OFFSET * 3) + ((SLOT.y * .5f) * 3) + PADDING, SLOT.x, SLOT.y);
        GUI.Box(inventory[activeCharacter].rightArmGear.rect, new GUIContent(inventory[activeCharacter].rightArmGear.item.icon, inventory[activeCharacter].rightArmGear.item.description));

        inventory[activeCharacter].belt.rect = new Rect((_inventoryWindow.width * .5f) - ((SLOT.x * .5f) * 3) - PADDING, (OFFSET * 3) + ((SLOT.y * .5f) * 5) + (PADDING * 2), SLOT.x, SLOT.y);
        GUI.Box(inventory[activeCharacter].belt.rect, new GUIContent(inventory[activeCharacter].belt.item.icon, inventory[activeCharacter].belt.item.description));

        inventory[activeCharacter].rightWeapon.rect = new Rect((_inventoryWindow.width * .5f) - ((SLOT.x * .5f) * 5) - (PADDING * 2), (OFFSET * 3) + ((SLOT.y * .5f) * 3) + PADDING, SLOT.x, SLOT.y);
        GUI.Box(inventory[activeCharacter].rightWeapon.rect, new GUIContent(inventory[activeCharacter].rightWeapon.item.icon, inventory[activeCharacter].rightWeapon.item.description));

        //This block of code allows us to drag and drop items in and out of our equipment slots
        for (int i = 0; i < inventory[activeCharacter].equipment.Count; i++)                            //Iterate through each equipment slot
        {
            var tempItemType = inventory[activeCharacter].equipment[i].item.type;                       //Store the item type of the current item
            if (inventory[activeCharacter].equipment[i].rect.Contains(Event.current.mousePosition))     //Check that the mouse cursor is over one of the equipment slots
            {
                if (Event.current.type == EventType.MouseDrag)                                          //Check that we have initiated the mouse drag event
                {
                    if (clipboard.icon == null)                                                         //Make sure we don't already have an item in the clipboard
                    {
                        if (inventory[activeCharacter].equipment[i].item.icon != defaultIcons[i])       //Make sure the item currently in the equipment slot is not the default item
                        {
                            clipboard = inventory[activeCharacter].equipment[i].item;                   //Assign the item currently in the equipment slot to the clipboard
                            inventory[activeCharacter].equipment[i].item = new Item();                  //Clear the item from the equipment slot
                            inventory[activeCharacter].equipment[i].item.type = tempItemType;           //Reassign the item type for this equipment slot (because it goes with the item)
                            inventory[activeCharacter].equipment[i].item.icon = defaultIcons[i];        //Assign the appropriate default icon back to this slot (to indicate that it is now empty)
                        }
                    }
                }

                else if (Event.current.type == EventType.MouseUp)                                       //Check to see if we have released the mouse button
                {
                    if (clipboard.icon != null)                                                         //Make sure our clipboard is not empty
                    {
                        if (clipboard.type == inventory[activeCharacter].equipment[i].item.type)        //Make sure the type of the item in the clipboard matches the type of the equipment slot we are trying to drop into
                        {
                            inventory[activeCharacter].equipment[i].item = clipboard;                   //Assign the item in the clipboard to the equipment slot
                            clipboard = new Item();                                                     //Clear out the clipboard
                        }
                    }
                }
            }
        }

        //This just draws a box to separate the paperdoll box from the inventory slots
        GUI.Box(new Rect(10, paperDollBox.height - 10, paperDollBox.width - 20, 20), "");

        int slotCount = 0;		//Keep track of each slot as we iterate through the matrix so we can assign our slots uniquely

        //Create the inventory matrix:
        for (int y = 0; y < inventoryColumns; y++)			//Iterate through each columns
        {
            for (int x = 0; x < inventoryRows; x++)			//Iterate through each row
            {
                //Assign rect values to our item slots (we include our offset and padding values)       
                inventory[activeCharacter].inventoryItems[slotCount].rect.x = OFFSET + (x * (SLOT.x + PADDING));			                        //X
                inventory[activeCharacter].inventoryItems[slotCount].rect.y = paperDollBox.height + (OFFSET * 3) + (y * (SLOT.y + PADDING));		//Y
                inventory[activeCharacter].inventoryItems[slotCount].rect.width = SLOT.x;											                //Width
                inventory[activeCharacter].inventoryItems[slotCount].rect.height = SLOT.y;											                //Height

                //Draw the item slots as boxes
                GUI.Box(inventory[activeCharacter].inventoryItems[slotCount].rect, new GUIContent(inventory[activeCharacter].inventoryItems[slotCount].item.icon, inventory[activeCharacter].inventoryItems[slotCount].item.description));	

                if (inventory[activeCharacter].inventoryItems[slotCount].rect.Contains(Event.current.mousePosition))		//Check if the cursor is inside an item slot
                {
                    if (Event.current.type == EventType.MouseDrag)		                                                    //Check if we have clicked and are dragging an icon
                    {
                        if (clipboard.icon == null) 						                                                //Check that we are not already dragging an icon (in the clipboard)
                        {
                            if (inventory[activeCharacter].inventoryItems[slotCount].item.icon != null)		                //Check that there is an item in the slot
                            {
                                clipboard = inventory[activeCharacter].inventoryItems[slotCount].item;		                //Assign the item slot item to the clipboard
                                inventory[activeCharacter].inventoryItems[slotCount].item = new Item();		                //Replace the item slot with a new blank item
                            }
                        }
                    }
                    else if (Event.current.type == EventType.MouseUp)	                                                    //Check if we have released the mouse button
                    {
                        if (clipboard.icon != null)						                                                    //Check that we DO have an icon in the clipboard
                        {
                            if (inventory[activeCharacter].inventoryItems[slotCount].item.icon == null)		                //Check that the item slot is empty
                            {
                                inventory[activeCharacter].inventoryItems[slotCount].item = clipboard;		                //Assign the clipboard item to the item slot
                                clipboard = new Item();					                                                    //Replace the clipboard item with a new blank item
                            }
                        }
                    }
                }
                slotCount++;			//Increment the slot count
            }
        }

        //We have to sort of workaround for our tooltips.  As long as the clipboard is empty, we assign the tooltip to a variable that gets displayed inside the OnGUI() method
        if (clipboard.icon == null)
        {
            invTooltip = GUI.tooltip;
        }

        GUI.DragWindow(new Rect(0, 0, 1000, 20));       //Make the inventory window draggable
    }

    //This is our Method that is called whne we want to add items to our inventory when we loot them.  We can pass item
    //	to this method from our lootable script which we will attach to all lootable objects in the game.
    public void AddItem(Item item)
    {
        bool finished = false;					                                        //We create a condition so we can break out of our loop when we find an open slot
        for (int i = 0; i < totalSlots; i++)	                                        //Iterate through all of the inventory slots
        {
            if (inventory[activeCharacter].inventoryItems[i].item.icon == null)		    //When we find one that is empty
            {
                if (!finished)                                                          //And if our finished condition is false (this lets us break out of the condition after we have added the item)
                {
                    inventory[activeCharacter].inventoryItems[i].item = item;			//Add the item to our items list (inventory) for the active character
                    finished = true;				                                    //Break out of the loop
                }
            }
        }
    }

    //We use this Override Method to add items to a specific character's inventory instead of the currently active character. (So we can drop items onto the miniMap windows)
    public void AddItem(Item item, int character)
    {
        bool finished = false;					                                        //We create a condition so we can break out of our loop when we find an open slot
        for (int i = 0; i < totalSlots; i++)	                                        //Iterate through all of the inventory slots
        {
            if (inventory[character].inventoryItems[i].item.icon == null)		        //When we find one that is empty
            {
                if (!finished)
                {
                    inventory[character].inventoryItems[i].item = item;			        //Add the item to our items list (inventory) for the specified character
                    finished = true;				                                    //Break out of the loop
                }
            }
        }
    }
}