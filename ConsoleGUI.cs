using UnityEngine;
using System.Collections;

public class ConsoleGUI : MonoBehaviour 
{

	private Vector2 scrollBarPosition = Vector2.zero;	//This is the position of the scroll bar

	private string hitter;								//This is our reference variable to indicate who hit in combat
	private string hittee;								//This is our reference variable to indicate who got hit in combat
	private string avatar;								//This is a reference variable to indicate which Avatar moved
	private string enemy;								//This is a reference variable to indicate which enemy died.

	public bool combatMessage = false;					//Do we need to create a combat hit message?
	private bool movedMessage = false;					//Do we need to create an avatar moved message?
	private bool enemyDead = false;						//Do we need to create an enemy died message?

	public GUISkin mySkin;								//Our custom skin reference
	public GUIStyle consoleStyle;						//Our reference to out custom style in the mySkin

	private string consoleText;							//This is the current text being displayed in the console window
	private string consoleCache;						//This is the cached text in the console window
	private string dumpCache;							//This is the cached text we are getting ready to dump
	private string tempText;

	private float windowWidth = Screen.width * .2f;			//The width of our console window (30% of the screen width)
	private float windowHeight = Screen.height * .26f;		//The height of our console window (15% of the screen height)




	
	//Listen for any messages concerning information we need to output to the console window
	void OnEnable()
	{
		Messenger<string, string>.AddListener("avatar hit", OnAvatarHit);		//If an avatar gets hit
		Messenger<string, string>.AddListener("enemy hit", OnEnemyHit);			//If an enemy gets hit
		Messenger<string>.AddListener("avatar moved", OnAvatarMoved);			//If an avatar used an AP to move
		Messenger<string>.AddListener("enemy dead", OnEnemyDead);				//If an enemy is dead
	}

	void Update()
	{

	}

	//Apply the enemy died message string to our local variable and activate its create message condition
	void OnEnemyDead(string enemy)
	{
		this.enemy = enemy;			//Which enemy is dead?
		enemyDead = true;
	}

	//Apply the avatar moved message string to our local variable and activate its create message condition
	void OnAvatarMoved( string avatar)
	{
		this.avatar = avatar;		//Who moved?
		movedMessage = true;
	}

	//Apply the hitter and hittee strings we received from our enemy hit message and activate its create message condition
	void OnEnemyHit(string hitter, string hittee)
	{
		combatMessage = true;
		this.hitter = hitter;		//Who hit?
		this.hittee = hittee;		//Who got hit?
	}

	//Apply the hitter and hittee string we received from out avatar hit message and activate its create message condition
	void OnAvatarHit(string hitter, string hittee)
	{
		combatMessage = true;
		this.hitter = hitter;		//Who hit?
		this.hittee = hittee;		//Who got hit?
	}
	
	//Assign some default values
	void Start () 
	{
		consoleText = "<color=cyan> <b>**** Welcome to Schism **** </b></color>";
	}

	//Handle our GUI information for the Console Window
	void OnGUI()
	{
		//We have to assign a skin to this GUI because we need it in order to use various Styles when we create our 
		//	console text and so we can utilize the CalcHeight method to achieve our auto-scroll effect.
		GUI.skin = mySkin;

		//Again, in order to use the CalcHeight method we have to assign a GUIStyle.
		//We also use this style in order to use Rich Text in the console window which allows us to mark the text up
		//	similar to marking up HTML.  This allows us to change colors and fonts styles within a single label.
		GUIStyle consoleStyle = mySkin.GetStyle("Console Style");

		//This creates a reference to the data we currently have in the console window.
		//We need this reference so we can calculate its height in order to make the console window auto-scroll
		GUIContent content = new GUIContent(consoleText);			//The current consoleText content
		GUIContent cacheContent = new GUIContent(consoleCache);		//The consoleCache content
		GUIContent dumpCacheContent = new GUIContent(dumpCache);	//The dumpCache content

		//Begin the grouping for the console window GUI		
		//We want the console window to be in the center of the screen at the very bottom so we position it at half of the
		//	Screen width - half of the window width X the screen height - the window height.
		GUI.BeginGroup(new Rect((Screen.width * .005f), Screen.height - windowHeight, windowWidth, windowHeight));

		//Create a box inside our console window to hold the ScrollView.  This is basically the "window" where our console text
		//	will be displayed on the screen.  We make the box just a little smaller than the GUI grouping so we get a nice
		//	border around our console window.
		GUI.Box(new Rect(0, 0, (windowWidth * .98f), (windowHeight * .95f)), "Console");

		//Create a ScrollView to hold our text so that it will scroll as new text is added to it and assign our scrollBarPosition
		//The way this works, as best as I can tell, lol, is that the first rect is the actual view on the screen and the second 
		//	Rect is what actually contains the information.  The scrollBarPosition is an indicator of where, in the second Rect
		//	the view (first rect) is positioned.
		//So, the first rect (view) is positioned with an offset on x and y to create a "margin": 12, 25 and the dimensions
		//	of the view rect are 92% of the console window width and 72% of the console window height.
		//The second Rect is positioned without a margin at 0, 0, and is 87% of the console window width and 3X the console
		//	window height.  (ToDo: determine what to do when the console text reaches the bottom of the second rect)
		scrollBarPosition = GUI.BeginScrollView(new Rect(15, 25, (windowWidth * .92f), (windowHeight * .72f)), scrollBarPosition, new Rect(0, 0, (windowWidth * .87f), (windowHeight * 11)));

		CreateConsoleText();		//Call our Method to determine what text needs to be added to the console window at any given moment.

		//This label is what we use to actual display the console text in the console window.
		//We use GUILayout so most of our layout is done automatically for us.  We display the console text, using the console style we 
		//	have created in the inspector, and since GUILayout will want to use 100% of the console window width, we fix the width
		//	ourselves to 87% of the console window width.
		//In the label, we display the dumpCache, consoleCache, and the current consoleText, that way we can scroll back
		//	in order to see the previous messages.
		GUILayout.Label(dumpCache + consoleCache + consoleText, consoleStyle, GUILayout.Width(windowWidth * .87f));

		//Ok, here is the crazy part...
		//If our content has filled the console window, we append our consoleText to the consoleCache and clear consoleText.
		//	When the content of the consoleCache reaches half of our scrollview size (windowHeight * 5), we overwrite the dumpCache
		//	with our consoleCache and overwrite the consoleCache with the consoleText and clear consoleText so we don't repeat it.
		//Then, we set the scrollBarPosition.y to equal the height of content + cacheContent + dumpCacheContent minus 30% of
		//	The console windowHeight.  (we only subtract 30% so we can still see our last message displayed.
		if(consoleStyle.CalcHeight(content, windowWidth * .87f) >= windowHeight * .7f)

		{
			consoleCache += consoleText;
			consoleText = "";

			if(consoleStyle.CalcHeight(cacheContent, windowWidth * .87f) > (windowHeight * 5))
			{
				dumpCache = consoleCache ;
				consoleCache = consoleText;
				consoleText = "";
			}

			scrollBarPosition.y = consoleStyle.CalcHeight(content, windowWidth * .87f)
								+ consoleStyle.CalcHeight(cacheContent, windowWidth * .87f) 
								+ consoleStyle.CalcHeight(dumpCacheContent, windowWidth * .87f) 
								- (windowHeight * .3f);
		}

		//End the Scrollview
		GUI.EndScrollView();

		//End the console window GUI grouping
		GUI.EndGroup();


	}

	//This is the method where we create the text to be displayed in our label based upon the messages we have received
	//	that we want to display to the player.
	private string CreateConsoleText()
	{
		//This is the message indicating someone has been hit in combat.  It can indicate an Enemy being hit, or an avatar
		//	being hit.
		if(combatMessage)
		{
			tempText = "\n <color=red>" + hitter + "</color>" + "<Color=#ffffffff> hits </color>" + "<color=yellow>" + hittee + "</color>";
			consoleText += tempText;

			combatMessage = false;
		}
		//This is the message that one of our avatars has taken an action point to move
		if(movedMessage)
		{
			tempText += "\n <color=cyan>" + avatar + "</color>" + "<Color=#ffffffff> moved </color>";

			consoleText += tempText;

			movedMessage = false;
		}
		//This message indicates that we have killed an enemy in combat.
		if(enemyDead)
		{
			tempText += "\n <color=brown>" + enemy + "</color>" + "<Color=#ffffffff> is dead! </color>";

			consoleText += tempText;
		
			enemyDead = false;
		}

		return consoleText;			//Return the appropriate string for the message we want to display in the console window
	}

}
