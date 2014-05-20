
/// <summary>
/// Schism
/// CreateCharacterStats.cs
/// Scott Sharpe
/// March 17, 2014
/// 
/// This script handles the creation of all six characters' primary stats and in turn, create the derived stat
/// 	values based upon those stats.  Basically, we create six menus, one to represent each character and let the
///		player roll the attributes for each one.
/// </summary>

#region NameSpaces
using UnityEngine;
using System.Collections;
using System.Linq;
using Mono.Data.Sqlite;
using System;
using System.Collections.Generic;
using SchismDB;
#endregion

public class CreateCharacterStats : MonoBehaviour 
{
#region fields
	private SchismDB.MonoStrict db;				//Reference to our dbMetal database connection

	private SchismDB.BaseAttributes[] baseAttributeQuery;					//Base Attribute Table Query array
	private SchismDB.DerivedStats[] derivedStatsQuery;						//Derived Stats Table Query array

	//Each GUI window has to have a unique ID so we assign an ID for each character in the inspector.  If we need more
	//	than six windows, we will just add 6 to this value.
	private int statsWindowID;	

	private bool[] attributesSaved = {false, false, false, false, false, false};		//Our condition to clear the stats window for the specified character once the data has been saved.

	//We create 6 instances of our BaseCharacter class so we can have a unique placeholder for the data until we store it
	//	in the database.
	private BaseCharacter[] thisBaseCharacter = new BaseCharacter[6];

	public GUIStyle schismGUIStyle;								//Our GUI Style
	private string[] characterName = new string[6];				//Our Character Name
	private int[] attributePoints = new int[6];					//Our attribute points - to increase stats
	private int maxAttributeValue = 10;							//The highest value our attributes can have

	private int thisCharacter;		//This is just so we have an index for the currently selected character inside of our arrays.

	//These are the dimmensions for our main character creation window
	private Rect _window = new Rect(Screen.width * .21f, 20, 440, 700);

    private int savedCount = 0;


#endregion

#region Awake Method
	//Here we will go ahead and populate some of the arrays we need for all six characters.
	void Awake()
	{
		
	}
#endregion

#region Start Method
	//Set up our database connection and create a couple of attribute
	void Start()
	{
		//Create a link to our database
		SqliteConnection myConnect = new SqliteConnection("URI=file:./Assets/Database/SchismMasterDB.s3db");
		
		//Reference our datbase connection
		db = new SchismDB.MonoStrict(myConnect);
		
		//Create an array of the entries in our BaseAttributes Table
		baseAttributeQuery = (from p in db.BaseAttributes orderby p.AttributeID ascending select p).ToArray();
		
		//Create an array of the entries in our DerivedStats Table
		derivedStatsQuery = (from p in db.DerivedStats orderby p.DerivedStatID ascending select p).ToArray();

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
            thisBaseCharacter[i] = new BaseCharacter();								//Our BaseCharacter Classes
            characterName[0] = (from p in db.Character where p.CharacterID == partyMembers.Character1id select p.CharacterName).FirstOrDefault().ToString();
            characterName[1] = (from p in db.Character where p.CharacterID == partyMembers.Character2id select p.CharacterName).FirstOrDefault().ToString();
            characterName[2] = (from p in db.Character where p.CharacterID == partyMembers.Character3id select p.CharacterName).FirstOrDefault().ToString();
            characterName[3] = (from p in db.Character where p.CharacterID == partyMembers.Character4id select p.CharacterName).FirstOrDefault().ToString();
            characterName[4] = (from p in db.Character where p.CharacterID == partyMembers.Character5id select p.CharacterName).FirstOrDefault().ToString();
            characterName[5] = (from p in db.Character where p.CharacterID == partyMembers.Character6id select p.CharacterName).FirstOrDefault().ToString();


            //characterName[i] = partyMembers[i];		//We get the character names from our singlton class
            thisBaseCharacter[i].thisCharacterName = characterName[i];				//Assign names to our BaseCharacter Classes
            attributePoints[i] = 30;												//Give each character a defined number of attribute points to assign.
            attributesSaved[i] = false;												//Set the starting condition for our attributes saved
        }


	}
#endregion

#region Update Method
	//Assign all of our Derived Stat Values to the appropriate combination of Base Attributes
	public void Update()
	{
		//Vitality = Strength + Endurance + Fortitude
		thisBaseCharacter[thisCharacter].derivedStatValue[0] = thisBaseCharacter[thisCharacter].attributeValue[0] + thisBaseCharacter[thisCharacter].attributeValue[8] + thisBaseCharacter[thisCharacter].attributeValue[10];
		//Initiative = Speed + Agility + Perception
		thisBaseCharacter[thisCharacter].derivedStatValue[1] = thisBaseCharacter[thisCharacter].attributeValue[4] + thisBaseCharacter[thisCharacter].attributeValue[9] + thisBaseCharacter[thisCharacter].attributeValue[2];
		//Atunement = Logic + Intuition + Perception
		thisBaseCharacter[thisCharacter].derivedStatValue[2] = thisBaseCharacter[thisCharacter].attributeValue[1] + thisBaseCharacter[thisCharacter].attributeValue[3] + thisBaseCharacter[thisCharacter].attributeValue[2];
		//Capacity = Logic + Willpower + Dexterity
		thisBaseCharacter[thisCharacter].derivedStatValue[3] = thisBaseCharacter[thisCharacter].attributeValue[1] + thisBaseCharacter[thisCharacter].attributeValue[7] + thisBaseCharacter[thisCharacter].attributeValue[5];
		//Action Points = Speed + Agility + Dexterity
		thisBaseCharacter[thisCharacter].derivedStatValue[4] = thisBaseCharacter[thisCharacter].attributeValue[4] + thisBaseCharacter[thisCharacter].attributeValue[9] + thisBaseCharacter[thisCharacter].attributeValue[5];
		//Evasion = Agility + Speed + Dexterity
		thisBaseCharacter[thisCharacter].derivedStatValue[5] = thisBaseCharacter[thisCharacter].attributeValue[9] + thisBaseCharacter[thisCharacter].attributeValue[4] + thisBaseCharacter[thisCharacter].attributeValue[5];
		//Accuracy = Dexterity + Perception + Focus
		thisBaseCharacter[thisCharacter].derivedStatValue[6] = thisBaseCharacter[thisCharacter].attributeValue[5] + thisBaseCharacter[thisCharacter].attributeValue[2] + thisBaseCharacter[thisCharacter].attributeValue[11];
		//Armor Rating will be an item dependent stat
		thisBaseCharacter[thisCharacter].derivedStatValue[7] = 0;
		//Melee Rating will be Strength plus melee weapon damage
		thisBaseCharacter[thisCharacter].derivedStatValue[8] = thisBaseCharacter[thisCharacter].attributeValue[0];
		//Ranged Rating will be an item dependent stat
		thisBaseCharacter[thisCharacter].derivedStatValue[9] = 0;
		//Edge - I haven't decided how to calculate edge just yet
		thisBaseCharacter[thisCharacter].derivedStatValue[10] = 0;
		//Humanity - for now we set it at 100.  We might consider it as a percentage value and modifications take percentages away
		thisBaseCharacter[thisCharacter].derivedStatValue[11] = 100;
	}
#endregion

#region WindowFunction Method
	//This is where we handle the organization of our windows based upon their windowID
	//There is, I discovered after the fact, a better way to do this, but this works nonetheless
	public void WindowFunction(int windowID)
	{
		StatsWindow();				//Get instructions for our main character creation stats window
	}
#endregion

#region OnGUI Method
	//OnGUI() Method determines what GUI elements are drawn to the screen
	//We start with our six Character boxes.  When a player clicks the "assign attributes" button on one of the boxes,
	//	the appropriate stats window will appear, allowing the player to adjust the stats for that character.
	void OnGUI()
	{
		//Define some values for our GUI elements
		Vector2 CHARACTERBOX = new Vector2(Screen.width * .2f, Screen.height * .14f);
		float OFFSET = Screen.width * .005f;
		Vector2 LABEL = new Vector2(CHARACTERBOX.x * .2f, CHARACTERBOX.y * .25f);
		Vector2 NAME_FIELD = new Vector2(CHARACTERBOX.x * .38f, CHARACTERBOX.y * .2f);
		Vector2 BUTTON = new Vector2(CHARACTERBOX.x * .3f, CHARACTERBOX.y * .28f);
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

            if (!attributesSaved[i])
            {
                if (GUI.Button(new Rect(OFFSET + PORTRAIT_BOX + OFFSET + OFFSET,
                                   (CHARACTERBOX.y * .65f) + (CHARACTERBOX.y * i) + (OFFSET * i),
                                   BUTTON.x,
                                   BUTTON.y), "Assign Stats"))
                {
                    thisCharacter = i;		//Make sure we assign this character as the index to determine which stats we are changing
                    statsWindowID = i;		//Make sure the window has a unique ID
                }	
            }
            
		}

		//As long as we have NOT already created the stats for this character, show the window to assign them
		//As soon as we have saved the information for this character to the database, we want this window to be gone forever.
		if(!attributesSaved[thisCharacter])
		{
			_window = GUI.Window (statsWindowID, _window, WindowFunction, "Create Character");
		}

		//Close out the character box grouping
		GUI.EndGroup();

        if (savedCount == 6)
        {
            if (GUI.Button(new Rect(Screen.width * .8f, Screen.height * .8f, 100, 30), "Continue"))
            {
                Application.LoadLevel("SchismCharacterCreation3");
            }
        }

	}
#endregion

#region StatsWindow Method
	//This method handles all of the necessary GUI components and layout for the main character creation stats window
	public void StatsWindow()
	{
		int labelWidth = 80;		//How wide do want the lables to be
		
		GUILayout.BeginVertical();		//This section draws the GUI for the top portion of our window
		
		GUILayout.BeginHorizontal();	//This row hold our Character Name label and text field and the Points Left
		GUILayout.Label("Name: ", schismGUIStyle, GUILayout.Width(labelWidth), GUILayout.Height(30));
		GUILayout.Label(characterName[thisCharacter], GUILayout.Height(30));	//Assign our Character Name here
		GUILayout.Label ("Points Left: ", schismGUIStyle, GUILayout.Width(100), GUILayout.Height(30));
		GUILayout.TextField(attributePoints[thisCharacter].ToString(), GUILayout.Width(30), GUILayout.Height(30));
		
		GUILayout.EndHorizontal();
		GUILayout.EndVertical();		//End of the top portion section of the window
		
		//Define some re-usable values to some of our RECT values
		int OFFSET = 20;				//How far we want to be from the border
		int LINE_HEIGHT = 40;			//How high we want each line to be
		int STAT_LABEL_WIDTH = 100;		//The width of the stat labels
		int BUTTON_WIDTH = 30;			//The width of the buttons
		int BUTTON_HEIGHT = 30;			//The height of the buttons
		int START_POSITION = 60;		//Our starting y position
		
		GUI.BeginGroup(new Rect(10, 60, 230, 540));				//Begin the Base Attribute gouping (Left column of the window)
		GUI.Box(new Rect(0, 0, 230, 540), "Attributes");		//Create the Attributes Box
		
		//Cycle through the base attribute query
		for(int i = 0; i < baseAttributeQuery.Count(); i++)
		{	
			//Create a label for each base attribute - including a tooltip
			GUI.Label(new Rect(OFFSET, START_POSITION + (i * LINE_HEIGHT), STAT_LABEL_WIDTH, LINE_HEIGHT), new GUIContent (baseAttributeQuery[i].AttributName.ToString(), baseAttributeQuery[i].AttributeDescription.ToString()));
			
			//thisCharacterStats[thisCharacter].attributeValue[i] = (from p in db.CharacterAttributes where p.CharacterName == characterName[thisCharacter] && p.AttributeName == baseAttributeQuery[i].AttributName select p.AttributeValue).FirstOrDefault();

			//Create a label to display each attributes value
			GUI.Label(new Rect(OFFSET + 80, START_POSITION + (i * LINE_HEIGHT), STAT_LABEL_WIDTH, LINE_HEIGHT), thisBaseCharacter[thisCharacter].attributeValue[i].ToString());
			
			//Create the buttons for each attribute to add to the attribute value (and subtract from points left)
			if(GUI.Button(new Rect(OFFSET + 120,START_POSITION + (i * LINE_HEIGHT), BUTTON_WIDTH, BUTTON_HEIGHT)," + "))
			{
				//We make sure don't exceed our maxAttributeValue and that we have attributePoints remaining
				if(thisBaseCharacter[thisCharacter].attributeValue[i] < maxAttributeValue && attributePoints[thisCharacter] >= 0)
				{
					thisBaseCharacter[thisCharacter].attributeValue[i]++;		//Increment the value for this character
					attributePoints[thisCharacter]--;							//subtract from our attriubte points for this character
				}
			}
			
			//Create the buttons for each attribute to subtract from the attribute value (and add to points left)
			if(GUI.Button(new Rect(OFFSET + 160,START_POSITION + (i * LINE_HEIGHT), BUTTON_WIDTH, BUTTON_HEIGHT)," - "))
			{
				//We want to make sure we do not go below 1 point
				if(thisBaseCharacter[thisCharacter].attributeValue[i] > 1)
				{
					thisBaseCharacter[thisCharacter].attributeValue[i]--;		//Subtract from the attribute value
					attributePoints[thisCharacter]++;							//Increment attribute points
				}
			}
		}

		GUI.EndGroup();			//End of the Base Attribute grouping (Left column of the window)
		
		GUI.BeginGroup(new Rect(250, 60, 180, 540));			//Begin the Derived Stats grouping (Right column of the window)
		GUI.Box(new Rect(0, 0, 180, 540), "Derived Stats");		//Create the Derived Stats Box
		
		//Cycle through the derived stats query
		for(int i = 0; i < derivedStatsQuery.Count(); i++)
		{
			//Create a label for each Derived Stat - including a tootlip
			GUI.Label(new Rect(OFFSET, START_POSITION + (i * LINE_HEIGHT), STAT_LABEL_WIDTH, LINE_HEIGHT), new GUIContent (derivedStatsQuery[i].DerivedStatName.ToString(), derivedStatsQuery[i].DerivedStatDescription.ToString())); 
			
			//Create a labelto display each derived stats value
			GUI.Label (new Rect(OFFSET + 100, START_POSITION + (i * LINE_HEIGHT), STAT_LABEL_WIDTH, LINE_HEIGHT), thisBaseCharacter[thisCharacter].derivedStatValue[i].ToString());
		}
		
		GUI.EndGroup();			//End of the Derived Stats grouping (Right column of the window)
		
		GUI.BeginGroup(new Rect(10, 620, 420, 60));				//Begin the bottom portion of the window where the Create Button will be
		GUI.Box (new Rect(0, 0, 420, 60), "");					//Draw the box for the bottom portion
		GUI.Label (new Rect(10, 10, 400, 40), GUI.tooltip);		//This is our ToolTip Rect
		
		//Check that all values have been entered and all points used before displaying the Create button
		if(characterName[thisCharacter] != "" && attributePoints[thisCharacter] == 0)
		{
			//Create the button to actualy submit the character creating information to the database
			if(GUI.Button (new Rect(180, 20, 80, 30), "Create"))
			{
                savedCount++;
				CreateStats ();	//If the name is unique, call the method to write the data to the database
			}
		}
		GUI.EndGroup();			//End the bottom portion grouping
		GUI.DragWindow (new Rect(0, 0, 500, 40));		//Make the window draggable
	}
#endregion

#region CreateStats Method
	//This is our Method to actually assign all of the stat values to the database Once they have been inputted and calculated
	public void CreateStats()
	{
		//First we cycle through the Attributes
		for(int i = 0; i < baseAttributeQuery.Count(); i++) 
		{
			//Define a new object to insert into the CharacterAttributes Table in the database
			SchismDB.CharacterAttributes myNewAttribute = new SchismDB.CharacterAttributes();
			
			//Assign the necessary properties to the attribute object
			myNewAttribute.CharacterID = (from p in db.Character where p.CharacterName == characterName[thisCharacter] select p.CharacterID).FirstOrDefault(); //CharacterID							
			myNewAttribute.AttributeName = baseAttributeQuery[i].AttributName;						//Attribute Name
			myNewAttribute.AttributeValue = thisBaseCharacter[thisCharacter].attributeValue[i];		//Attribute Value
			
			db.CharacterAttributes.InsertOnSubmit (myNewAttribute);		//Prepare attribute object for insertion into the database.
		}
		
		//Second we cycle through the Derived Stats
		for(int i = 0; i < derivedStatsQuery.Count(); i++)
		{
			//Define a new object to insert into the CharacterDerivedStats Table in the database
			SchismDB.CharacterDerivedStats myNewDerivedStat = new SchismDB.CharacterDerivedStats();
			
			//Assign the necessary properties to the derived stat object
			myNewDerivedStat.CharacterID = (from p in db.Character where p.CharacterName == characterName[thisCharacter] select p.CharacterID).FirstOrDefault();	//CharacterID						
			myNewDerivedStat.DerivedStatName = derivedStatsQuery[i].DerivedStatName;					//Derived Stat Name
			myNewDerivedStat.DerivedStatValue = thisBaseCharacter[thisCharacter].derivedStatValue[i];	//Derived Stat Value
			
			db.CharacterDerivedStats.InsertOnSubmit (myNewDerivedStat);	//Prepare derived stat object for insertion into database
		}
		db.SubmitChanges();							//Submit to the database
		attributesSaved[thisCharacter] = true;		//Set our saved condition to make the window dissapear
	}
#endregion

}
