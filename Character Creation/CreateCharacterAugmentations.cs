/// <summary>
/// Schism
/// CreateCharacterAugmentations.cs
/// Scott Sharpe
/// March 24, 2014
/// 
/// This script handles the creation of our Character Augmentations.
/// We will re-use our six character boxes as we have in the previous menus.  This time, when you click a character box,
/// 	You will get a window that allows you to purchase the Augmentations for each character.
/// </summary>
/// 
#region NameSpaces
using UnityEngine;
using System.Collections;
using System.Linq;
using Mono.Data.Sqlite;
using System;
using System.Collections.Generic;
using SchismDB;
#endregion

public class CreateCharacterAugmentations : MonoBehaviour 
{
#region Fields
	private SchismDB.MonoStrict db;				//Reference to our dbMetal database connection
	
	//This is the whole reason for this script.  We already have our base attributes and derived stats stored int he database
	//	for the selected character.  Now, we want to deterimine what the character's Augmentation Value is.  We start
	//	With this array which will store the values for us locally until it is time to write them to the database.
	private int[] augmentationValue;




	//These are all of our database queried:
	public SchismDB.Character[] characterQuery;									//Character		
	public SchismDB.Augmentations[] augmentationsQuery;							//Augmentations
	public SchismDB.CharacterAugmentations[] characterAugmentationsQuery;		//Character Augmentations
	public SchismDB.AugmentationAttributeBuffs[] augmentationAttributeQuery;	//Augmentation Attribute Buffs
	public SchismDB.AugmentationDerivedStatBuffs[] augmentationDerivedQuery;	//Augmentation Derived Stat Buffs
	public SchismDB.AugmentationSkillBuffs[] augmentationSkillsQuery;			//Augmentation Skills Buffs
	public SchismDB.BaseAttributes[] baseAttributeQuery;						//Base Attributes
	public SchismDB.CharacterAttributes[] characterAttributeQuery;				//Character Attributes
	public SchismDB.CharacterDerivedStats[] characterDerivedStatsQuery;			//Character Derived Stats Query

	
	//Each GUI window has to have a unique ID so we assign an ID for each character in the inspector.  If we need more
	//	than six windows, we will just add 6 to this value.
	private int statsWindowID;	

	//These are the dimmensions for our main character creation window
	private Rect _window; 

	private string[] characterName = new string[6];				//Our Character Name
	private int thisCharacter;		//This is just so we have an index for the currently selected character inside of our arrays.
	private bool[] augmentationsSaved = {false, false, false, false, false, false};		//Our condition to clear the stats window for the specified character once the data has been saved.

	public GUIStyle schismGUIStyle;								//Our GUI Style

    Vector2 LABEL = new Vector2(70, 22);
    float PADDING = 10;
    Vector2 TEXTAREA = new Vector2(30, 20);
    float STAT_OFFSET = 125;
    Vector2 NAME_LABEL = new Vector2(100, 20);
    Vector2 STAT_BOX;
    Vector2 CHARACTERBOX = new Vector2(Screen.width * .15f, Screen.height * .14f);



#endregion

#region Awake Method
	//Here we will go ahead and populate some of the arrays we need for all six characters.
	void Awake()
	{
		for(int i = 0; i < 6; i++)
		{
			augmentationsSaved[i] = false;
			//characterName[i] = PartyManager.Instance._persistentCharacter[i];		//We get the character names from our singlton class
		
		}

        STAT_BOX = new Vector2((PADDING * 7) + (LABEL.x * 3) + (TEXTAREA.x * 3), (PADDING * 7) + (LABEL.y * 5));
        _window = new Rect(CHARACTERBOX.x + (PADDING * 2), PADDING, STAT_BOX.x + (PADDING * 2), Screen.height * .8f);
	}
#endregion
	
	void Start () 
	{
		//Create a link to our database
		SqliteConnection myConnect = new SqliteConnection("URI=file:./Assets/Database/SchismMasterDB.s3db");
		
		//Reference our datbase connection
		db = new SchismDB.MonoStrict(myConnect);

        var thisGroup = PartyManager.Instance._persistentGroup;
        Debug.Log("Character Group is" + thisGroup);
        if (thisGroup == null)
        {
            thisGroup = 1;
            Debug.Log("No group found in PartyManager, defaulting to group 0");
        }


        var partyMembers = (from p in db.CharacterGroup where p.CharacterGroupID == thisGroup select p).FirstOrDefault();


        for (int i = 0; i < 6; i++)
        {

            characterName[0] = (from p in db.Character where p.CharacterID == partyMembers.Character1id select p.CharacterName).FirstOrDefault().ToString();
            characterName[1] = (from p in db.Character where p.CharacterID == partyMembers.Character2id select p.CharacterName).FirstOrDefault().ToString();
            characterName[2] = (from p in db.Character where p.CharacterID == partyMembers.Character3id select p.CharacterName).FirstOrDefault().ToString();
            characterName[3] = (from p in db.Character where p.CharacterID == partyMembers.Character4id select p.CharacterName).FirstOrDefault().ToString();
            characterName[4] = (from p in db.Character where p.CharacterID == partyMembers.Character5id select p.CharacterName).FirstOrDefault().ToString();
            characterName[5] = (from p in db.Character where p.CharacterID == partyMembers.Character6id select p.CharacterName).FirstOrDefault().ToString();
        }

        baseAttributeQuery = (from p in db.BaseAttributes orderby p.AttributName descending select p).ToArray();
        
	}
	
	

#region OnGUI Method
	//OnGUI() Method determines what GUI elements are drawn to the screen
	//We start with our six Character boxes.  When a player clicks the "assign attributes" button on one of the boxes,
	//	the appropriate stats window will appear, allowing the player to adjust the stats for that character.
	void OnGUI()
	{
		//Define some values for our GUI elements
		
		float OFFSET = Screen.width * .005f;
		Vector2 LABEL = new Vector2(CHARACTERBOX.x * .2f, CHARACTERBOX.y * .25f);
		Vector2 NAME_FIELD = new Vector2(CHARACTERBOX.x * .38f, CHARACTERBOX.y * .2f);
		Vector2 BUTTON = new Vector2(CHARACTERBOX.x * .43f, 25);
		float BUTTON_Y = CHARACTERBOX.y * .75f;
		Vector2 TOGGLE = new Vector2(CHARACTERBOX.x * .3f, CHARACTERBOX.y * .25f);
		float PORTRAIT_BOX = CHARACTERBOX.y - (OFFSET * 2);
		
		//Begin the grouping of our 6 character boxes which will be stacked in a column on the left side of the screen.
		GUI.BeginGroup(new Rect(0, OFFSET, 600, Screen.height - (OFFSET * 2)));
		
		for(int i = 0; i < 6; i ++)			//Create a separate character box for each character
		{
			//The main Box
			GUI.Box(new Rect(OFFSET, 
			                 (CHARACTERBOX.y * i) + (OFFSET * i), 
			                 CHARACTERBOX.x, 
			                 CHARACTERBOX.y), "");
			
			//A box to hold the character portrait
			GUI.Box (new Rect(OFFSET * 2, 
			                  (CHARACTERBOX.y * i) + ((OFFSET * i)+ OFFSET), 
			                  PORTRAIT_BOX, 
			                  PORTRAIT_BOX), "");
			
			//A "Name" label
			GUI.Label(new Rect((OFFSET * 3) + PORTRAIT_BOX,
			                   (CHARACTERBOX.y * i) + ((OFFSET * i) + (OFFSET * 2)),
			                   LABEL.x,
			                   LABEL.y), "Name: ");
			
			//A label to display this characters name
			GUI.Label(new Rect(OFFSET + PORTRAIT_BOX + OFFSET + LABEL.x + OFFSET,
			                   (CHARACTERBOX.y * i) + ((OFFSET * i) + (OFFSET * 2)),
			                   NAME_FIELD.x,
			                   NAME_FIELD.y),characterName[i] );
			
			//Create a button, "Assign Stats".  When the player clicks this button, the window for changing THIS characters
			//	attributes will appear and the player can adjust it accordingly.

            if (!augmentationsSaved[1])
            {
                if (GUI.Button(new Rect(OFFSET + PORTRAIT_BOX + OFFSET + OFFSET,
                                   (CHARACTERBOX.y * .65f) + (CHARACTERBOX.y * i) + (OFFSET * i),
                                   BUTTON.x + 30,
                                   BUTTON.y), "Select Augmentations"))
                {
                    thisCharacter = i;		//Make sure we assign this character as the index to determine which stats we are changing
                    statsWindowID = i;		//Make sure the window has a unique ID
                }	
            }

			
		}
        GUI.EndGroup();
		//As long as we have NOT already created the stats for this character, show the window to assign them
		//As soon as we have saved the information for this character to the database, we want this window to be gone forever.
		if(!augmentationsSaved[thisCharacter])
		{
			_window = GUI.Window (statsWindowID, _window, WindowFunction, "Character Stats");
		}
		
		//Close out the character box grouping
		
	}
#endregion



#region WindowFunction Method
	//This is where we handle the organization of our windows based upon their windowID
	//There is, I discovered after the fact, a better way to do this, but this works nonetheless
	public void WindowFunction(int windowID)
	{
		AugmentationsWindow();				//Get instructions for our main character creation stats window
	}
#endregion

#region AugmentationsWindow Method
	//This is the GUI information for the default window.  We create a "Select Character" Button near the top.
	//Once a character has been selected, we display all of the characters current stats (attributes and derived stats)
	//	by iterating through the respective database queries and pulling the data out.
	void AugmentationsWindow()
	{
        

		GUI.BeginGroup(new Rect (PADDING, PADDING * 3, STAT_BOX.x + (PADDING * 2), STAT_BOX.y + (PADDING * 2)));
		
		GUI.Box(new Rect (0, 0, STAT_BOX.x, STAT_BOX.y), "");
		
		//This is where we display the character name on the screen
		GUI.Label(new Rect(PADDING, PADDING * 2, NAME_LABEL.x, NAME_LABEL.y), "Character Name:");
		GUI.TextArea(new Rect(PADDING + NAME_LABEL.x, PADDING * 2, NAME_LABEL.x, TEXTAREA.y), characterName[thisCharacter]);
		
		//Instead of making some crazy multidemsional array to display the rows of stats, I opted to just run 4 loops,
		//	one per row, to display the character data.
		
		//First we iterate through the attributes and display the base attributeName in a label and the characterAttribute
		// Value in a textArea.

        var characterQuery = (from p in db.Character where p.CharacterName == characterName[thisCharacter] select p.CharacterID).FirstOrDefault();
        characterAttributeQuery = (from p in db.CharacterAttributes where p.CharacterID == characterQuery orderby p.AttributeName descending select p).ToArray();

		for(int i = 0; i < 3; i ++)
		{
            GUI.Label(new Rect((i * STAT_OFFSET) + PADDING, PADDING * 6, LABEL.x, LABEL.y), baseAttributeQuery[i].AttributName.ToString());
            GUI.TextArea(new Rect((i * STAT_OFFSET) + (PADDING * 8), PADDING * 6, TEXTAREA.x, TEXTAREA.y), characterAttributeQuery[i].AttributeValue.ToString());
		}
			
		for(int i = 0; i < 3; i ++)
		{
            GUI.Label(new Rect((i * STAT_OFFSET) + PADDING, PADDING * 9, LABEL.x, LABEL.y), baseAttributeQuery[i + 3].AttributName.ToString());
            GUI.TextArea(new Rect((i * STAT_OFFSET) + (PADDING * 8), PADDING * 9, TEXTAREA.x, TEXTAREA.y), characterAttributeQuery[i + 3].AttributeValue.ToString());
		}
			
		for(int i = 0; i < 3; i ++)
		{
            GUI.Label(new Rect((i * STAT_OFFSET) + PADDING, PADDING * 12, LABEL.x, LABEL.y), baseAttributeQuery[i + 6].AttributName.ToString());
            GUI.TextArea(new Rect((i * STAT_OFFSET) + (PADDING * 8), PADDING * 12, TEXTAREA.x, TEXTAREA.y), characterAttributeQuery[i + 6].AttributeValue.ToString());
		}
			
		for(int i = 0; i < 3; i ++)
		{
            GUI.Label(new Rect((i * STAT_OFFSET) + PADDING, PADDING * 15, LABEL.x, LABEL.y), baseAttributeQuery[i + 9].AttributName.ToString());
            GUI.TextArea(new Rect((i * STAT_OFFSET) + (PADDING * 8), PADDING * 15, TEXTAREA.x, TEXTAREA.y), characterAttributeQuery[i + 9].AttributeValue.ToString());
		}

		GUI.EndGroup();
		
		//Then we iterate through the derived stats the same way we went through the attributes.
        GUI.BeginGroup(new Rect(PADDING, (PADDING * 4) + STAT_BOX.y, STAT_BOX.x + (PADDING * 2), STAT_BOX.y - TEXTAREA.y));
		GUI.Box(new Rect (0, 0, STAT_BOX.x, STAT_BOX.y - (TEXTAREA.y + PADDING)), "");

        characterDerivedStatsQuery = (from p in db.CharacterDerivedStats where p.CharacterID == characterQuery orderby p.DerivedStatName descending select p).ToArray();

		for(int i = 0; i < 3; i ++)
		{
            GUI.Label(new Rect((i * STAT_OFFSET) + PADDING, PADDING * 2, LABEL.x, LABEL.y), characterDerivedStatsQuery[i].DerivedStatName.ToString());
            GUI.TextArea(new Rect((i * STAT_OFFSET) + (PADDING * 8), PADDING * 2, TEXTAREA.x, TEXTAREA.y), characterDerivedStatsQuery[i].DerivedStatValue.ToString());
		}
			
		for(int i = 0; i < 3; i ++)
		{
            GUI.Label(new Rect((i * STAT_OFFSET) + PADDING, PADDING * 5, LABEL.x, LABEL.y), characterDerivedStatsQuery[i + 3].DerivedStatName.ToString());
            GUI.TextArea(new Rect((i * STAT_OFFSET) + (PADDING * 8), PADDING * 5, TEXTAREA.x, TEXTAREA.y), characterDerivedStatsQuery[i + 3].DerivedStatValue.ToString());
		}
			
		for(int i = 0; i < 3; i ++)
		{
            GUI.Label(new Rect((i * STAT_OFFSET) + PADDING, PADDING * 8, LABEL.x, LABEL.y), characterDerivedStatsQuery[i + 6].DerivedStatName.ToString());
            GUI.TextArea(new Rect((i * STAT_OFFSET) + (PADDING * 8), PADDING * 8, TEXTAREA.x, TEXTAREA.y), characterDerivedStatsQuery[i + 6].DerivedStatValue.ToString());
		}
			
		for(int i = 0; i < 3; i ++)
		{
            GUI.Label(new Rect((i * STAT_OFFSET) + PADDING, PADDING * 11, LABEL.x, LABEL.y), characterDerivedStatsQuery[i + 9].DerivedStatName.ToString());
            GUI.TextArea(new Rect((i * STAT_OFFSET) + (PADDING * 8), PADDING * 11, TEXTAREA.x, TEXTAREA.y), characterDerivedStatsQuery[i + 9].DerivedStatValue.ToString());
		}

		GUI.EndGroup();
		
		GUI.BeginGroup(new Rect (10, (Screen.height * .42f) + 80, (Screen.width * .25f) - 20, Screen.height * .2f));
		GUI.Box(new Rect (0, 0, (Screen.width * .25f) - 20, Screen.height * .2f), "");
		
		//And then we display the information needed to select the augmentations.  There are 6 of them so we display the
		//	augmentation name in a column and then the buttons to increase/decrease the value, and then a text area to
		//	display the current value.


		for(int i = 0; i < 6; i ++)
		{
			GUI.Label (new Rect(20, (i * 30) + 10, 150, 30), augmentationsQuery[i].AugmentationName.ToString());
			if(GUI.Button (new Rect(190, (i * 30) + 10, 30, 30), "-"))
			{
				augmentationValue[i] --;
			}
			GUI.TextArea (new Rect(230, (i * 30) + 10, 30, 30), augmentationValue[i].ToString());
				
			if(GUI.Button (new Rect(270, (i * 30) + 10, 30, 30), "+"))
			{
				augmentationValue[i] ++;
			}
		}

		
		GUI.EndGroup();
		GUI.DragWindow (new Rect(0, 0, Screen.width * .25f, 40));		//Make the window draggable
	}
#endregion

}
