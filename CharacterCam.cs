using UnityEngine;
using System.Collections;

public class CharacterCam : MonoBehaviour {

    
    public Texture2D border;                    //A border around the camera viweport to indicate it is not active
    public Rect characterBox;                   //The rect for the viewport
    public Texture2D borderHighlighted;         //A highlighted border to indicate to the player that this is the active character
    public Texture2D guiBorder;                 //A variable to hold the border for the current state (active or not active)
    public int characterID;                     //The id we assign to each miniCam to make it unique (this is what we pass to our singleton to indicate which character is active)
    public static int activeCharacter;          //A reference to the currently active character
    public Camera cam;                         //The camera we want to use for our miniCam

    void Start()
    {
        cam = this.transform.camera;
        guiBorder = border;                     //Make the gui border start as the inactive border
        activeCharacter = 1;                    //Start our with character 1 being the active character
    }


    void Update()
    {
        if (activeCharacter == characterID)     //Check to see if this is the active character's miniCam
        {
            guiBorder = borderHighlighted;      //If this is the active character's miniCam, assign the highlighted border
            PartyManager.Instance.activeCharacter = activeCharacter;        //Assign the active character to the singleton
        }
        else
        {
            guiBorder = border;                 //Otherwise, assign the not active border
        }

       
    }

    void OnGUI()
    {
        //Draw the characterbox around the cam viewport
        characterBox = new Rect(cam.pixelRect.x, (Screen.height - cam.pixelRect.yMax), cam.pixelWidth, cam.pixelHeight);
        GUI.Box(characterBox, "");
        //Draw the current border (either the active border or the not active border) inside the cam viewport
        GUI.DrawTexture(new Rect(cam.pixelRect.x, (Screen.height - cam.pixelRect.yMax), cam.pixelWidth, cam.pixelHeight), guiBorder);

        //This is how we select the active character.  
        if (characterBox.Contains(Event.current.mousePosition))     //If the mouse cursor is over a character box...
        {
            if (Event.current.type == EventType.MouseDown)          //And we click the mouse button...
            {
                activeCharacter = characterID;                      //Make the character associated with that character box the active character
            }
        }
    }

}
