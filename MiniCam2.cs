using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MiniCam2 : MonoBehaviour
{
    private bool photo = false;
    private bool inventory = false;
    private bool chaSheet = false;
    private float invWindowWidth = Screen.width * .2f;
    private float invWindowHeight = Screen.height * .7f;
    private Texture2D snapshotPhoto;
    private Rect _invWindow;
    private Rect _chaWindow;
    private Camera cam;
    public int id;
    private int cid;

    private int invIconSize = 55;
    public Texture border;
    public List<Item> myInventory = new List<Item>();
    private int myCount = 0;

    void Start()
    {
        cam = this.transform.camera;

        if (transform.parent.name == "_Avatar 1") { id = 0; cid = 6; }
        if (transform.parent.name == "_Avatar 2") { id = 1; cid = 7; }
        if (transform.parent.name == "_Avatar 3") { id = 2; cid = 8; }
        if (transform.parent.name == "_Avatar 4") { id = 3; cid = 9; }
        if (transform.parent.name == "_Avatar 5") { id = 4; cid = 10; }
        if (transform.parent.name == "_Avatar 6") { id = 5; cid = 11; }

        _invWindow = new Rect(((Screen.width * .13f) * id) + (invWindowWidth * .5f), 20, invWindowWidth, invWindowHeight);

        _chaWindow = new Rect(((Screen.width * .13f) * id) + (invWindowWidth * .5f), 40, invWindowWidth, invWindowHeight);

    }

    void Update()
    {
        myCount = myInventory.Count;
    }

    void OnGUI()
    {
        cam = this.transform.camera;

        //Draw a border around the camera viewport to delineate it more
        GUI.Box(new Rect(cam.pixelRect.x, (Screen.height - cam.pixelRect.yMax), cam.pixelWidth, cam.pixelHeight), gameObject.name);
        GUI.DrawTexture(new Rect(cam.pixelRect.x, (Screen.height - cam.pixelRect.yMax), cam.pixelWidth, cam.pixelHeight), border);
        //Create a column of 4 buttons to the right of the viewport
        GUI.BeginGroup(new Rect(cam.pixelRect.x + cam.pixelWidth, Screen.height - cam.pixelRect.yMax, cam.pixelWidth * .3f, cam.pixelHeight));
        //Draw the box to hold our buttons
        GUI.Box(new Rect(0, 0, cam.pixelWidth * .3f, cam.pixelHeight), "");

        //Inventory Button.  When clicked, the inventory condition is set for us
        if (GUI.Button(new Rect(2, 2, (cam.pixelWidth * .3f) - 4, cam.pixelHeight * .25f), "I"))
        {
            if (inventory == false)
            {
                inventory = true;
            }
            else
            {
                inventory = false;
            }
        }

        if (GUI.Button(new Rect(2, cam.pixelHeight * .25f, (cam.pixelWidth * .3f) - 4, cam.pixelHeight * .25f), "C"))
        {
            if (chaSheet == false)
            {
                chaSheet = true;
            }
            else
            {
                chaSheet = false;
            }
        }
        GUI.Button(new Rect(2, cam.pixelHeight * .5f, (cam.pixelWidth * .3f) - 4, cam.pixelHeight * .25f), "ST");	//Stats
        GUI.Button(new Rect(2, cam.pixelHeight * .75f, (cam.pixelWidth * .3f) - 4, cam.pixelHeight * .25f), "SK");	//Skills
        GUI.EndGroup();

        //If the inventory condition is met, tell the Window Function to draw the inventory window,
        if (inventory == true)
        {
            _invWindow = GUI.Window(id, _invWindow, InvWindowFunction, "Inventory");
        }

        if (chaSheet == true)
        {
            _chaWindow = GUI.Window(cid, _chaWindow, ChaWindowFunction, "Character Sheet");
        }
    }

    //The WindowFunction method controls which windows need to be drawn
    //It is a little confusing how this works, but it does.  (Its built into Unity)
    public void InvWindowFunction(int WindowID)
    {
        InventoryWindow();

    }
    public void ChaWindowFunction(int WindowID)
    {
        CharacterWindow();
    }

    //This method holds all of our inventory window data
    void InventoryWindow()
    {
        //We want a snapshot photo to represent our character on his inventory window
        //If he doesn't already have one take, call the method to take the snapshot
        if (photo == false)
        {
            //SnapShot();
        }

        //Define the dimentions of the GUI controls group
        GUI.BeginGroup(new Rect(10, 10, invWindowWidth - 20, invWindowHeight));

        //Create a box at the top of the window to hold our character information
        GUI.Box(new Rect(0, 10, invWindowWidth - 20, 120), "");

        //Draw the snapshot photo
        GUI.DrawTexture(new Rect((invWindowWidth * .205f) - 75, 20, 150, 100), snapshotPhoto, ScaleMode.ScaleToFit);

        GUI.EndGroup();				//End this GUI controls group

        GUI.BeginGroup(new Rect(20, invWindowHeight * .2f, invWindowWidth - 20, invWindowHeight * .8f - 10));
        GUI.Box(new Rect(0, 0, invIconSize * 6, invIconSize * 10), "");

        for (int i = 0; i < myCount; i++)
        {
            //GUI.Button (new Rect(10, 10, 80, 30), myInventory[i].itemName);
        }

        GUI.EndGroup();

        GUI.DragWindow(new Rect(0, 0, invWindowWidth - 20, 20));		//Make the window draggable
    }

    void CharacterWindow()
    {
        //We want a snapshot photo to represent our character on his inventory window
        //If he doesn't already have one take, call the method to take the snapshot
        if (photo == false)
        {
            //SnapShot();
        }

        //Define the dimentions of the GUI controls group
        GUI.BeginGroup(new Rect(10, 10, invWindowWidth - 20, invWindowHeight));

        //Create a box at the top of the window to hold our character information
        GUI.Box(new Rect(0, 10, invWindowWidth - 20, 120), "");

        //Draw the snapshot photo
        GUI.DrawTexture(new Rect((invWindowWidth * .205f) - 75, 20, 150, 100), snapshotPhoto, ScaleMode.ScaleToFit);

        GUI.EndGroup();				//End this GUI controls group

        GUI.BeginGroup(new Rect(20, invWindowHeight * .2f, invWindowWidth - 20, invWindowHeight * .8f - 10));
        GUI.Box(new Rect(0, 0, invIconSize * 6, invIconSize * 10), "");

        GUI.EndGroup();

        GUI.DragWindow(new Rect(0, 0, invWindowWidth - 20, 20));		//Make the window draggable
    }


}
