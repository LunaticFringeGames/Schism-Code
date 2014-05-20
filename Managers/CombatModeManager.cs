using UnityEngine;
using System.Collections;

public class CombatModeManager : MonoBehaviour 
{
	public CombatMove combatMove;			//Connect to our CombatMove class so we access it
	public CombatRanged combatRanged;
	public CombatMelee combatMelee;

	public int actionPoints;				//The number of action points the current avatar has left
	public bool combat = false;				//Turn combat on or off (we initially get this value from GameModeManager)
	public int turn;						//This is how we track the current turn sequence.  Value comes from turnManager.
	public GameObject whosTurn;				//This is how we track the gameobject for whos turn it currently is.  Value comes from turnManager.
	private int hitPoints;
	private Rect _window = new Rect(Screen.width * .7f, 20, 140, 570);
	public TurnManager turnManager;

	private float actionBarWidth = Screen.width * .78f;
	private float actionBarHeight = Screen.height * .1f;
	private float windowWidth = Screen.width * .2f;	
	
	//Create a combat action Type so we can clearly keep track of what state our switch is in
	public enum CombatActions
	{
		moving = 0,				//We move the avatar to a new position based upon player input
		rangeAttacking = 1,		//We attack an enemy with a ranged weapon
		meleeAttacking = 2,		//We attack an enemy with a melee weapon
		equiping = 3,			//We are choosing new equipment
		usingItem = 4,			//We are using a readied item
		usingAbility = 5,		//We are using one of our abilities
		defending = 6,			//We are going to stand our ground and defend our current position
		countering = 7,			//We are going to be ready to counter an enemy attack if we attacked on the enemies turn
		deciding = 8			//We are choosing our next move
	}
	
	public CombatActions currentAction = CombatActions.equiping;		//Create a variable to change the action we are currently in
	
	//When this object is enabled, we start listening for key messages from some of our other objects.
	private void OnEnable()
	{
		Messenger<bool>.AddListener("in combat", OnCombat);					//Are we in combat right now?
		Messenger<GameObject>.AddListener("whos turn", OnWhosTurn);			//Whos turn is it?
	}

	//This is where our combat action switch does its thing.
	void Update () 
	{
		if (combat == true)			//We only need to use our combat actions switch when we are in combat.
		{
			SwitchScripts(currentAction);		//Call our method to change out the scripts we need for the current action.

			//Create a switch to manage all of our combat actions for us
			switch(currentAction)
			{
			case CombatActions.moving:

				Messenger<bool>.Broadcast("combat move", true);			//Tell the Combat Move class to get busy

				break;

			case CombatActions.rangeAttacking:

				Messenger<bool>.Broadcast("ranged attack", true);		//Tell related scripts to get busy

				break;

			case CombatActions.meleeAttacking:

				Messenger<bool>.Broadcast("melee attack", true);

				break;

			case CombatActions.equiping:

				break;

			case CombatActions.usingItem:

				break;

			case CombatActions.usingAbility:

				break;

			case CombatActions.defending:

				break;

			case CombatActions.countering:

				break;

			case CombatActions.deciding:
				
				break;
			}
		}

		if(whosTurn != null)
		{
			if(whosTurn.tag == "Avatar")
			{
				actionPoints = whosTurn.GetComponent<AvatarClass>().actionPoints;
				hitPoints = whosTurn.GetComponent<AvatarClass>().hp;
			}
			else if(whosTurn.tag == "Enemy")
			{
				hitPoints = whosTurn.GetComponent<EnemyClass>().hitPoints;
			}

			turn = turnManager.turn;
		}
	}

	void WindowFunction(int windowID)
	{
		float buttonWidth = 100f;							//Define our standard button width
		float buttonHeight = 30f;							//Define our standard button height

		GUILayout.BeginVertical();
		GUILayout.BeginHorizontal();
		GUILayout.Label("Turn: ", GUILayout.Width(30));
		GUILayout.TextArea( turn.ToString() );
		GUILayout.EndHorizontal();

		GUILayout.BeginHorizontal();
		GUILayout.Label("Who: ", GUILayout.Width(30));
		GUILayout.TextArea( whosTurn.name );
		GUILayout.EndHorizontal();

		GUILayout.BeginHorizontal();
		GUILayout.Label("AP: ", GUILayout.Width(30));
		GUILayout.TextArea( actionPoints.ToString() );
		GUILayout.EndHorizontal();

		GUILayout.BeginHorizontal();
		GUILayout.Label("HP: ", GUILayout.Width(30));
		GUILayout.TextArea( hitPoints.ToString() );
		GUILayout.EndHorizontal();

		GUILayout.EndVertical();

		if (GUI.Button (new Rect (20, 150, 100, 30), "Move"))
		{
			currentAction = CombatActions.moving;
		}

		if (GUI.Button (new Rect (20, 200, buttonWidth, buttonHeight), "Ranged"))
		{
			currentAction = CombatActions.rangeAttacking;
		}
		
		if (GUI.Button (new Rect (20, 250, buttonWidth, buttonHeight), "Melee"))
		{
			currentAction = CombatActions.meleeAttacking;
		}
		
		if (GUI.Button (new Rect (20, 300, buttonWidth, buttonHeight), "Equip"))
		{
			currentAction = CombatActions.equiping;
		}
		
		if (GUI.Button (new Rect (20, 350, buttonWidth, buttonHeight), "Item"))
		{
			currentAction = CombatActions.usingItem;
		}
		
		if (GUI.Button (new Rect (20, 400, buttonWidth, buttonHeight), "Ability"))
		{
			currentAction = CombatActions.usingAbility;
		}
		
		if (GUI.Button (new Rect (20, 450, buttonWidth, buttonHeight), "Defend"))
		{
			currentAction = CombatActions.defending;
		}
		
		if (GUI.Button (new Rect (20, 500, buttonWidth, buttonHeight), "Counter"))
		{
			currentAction = CombatActions.countering;
		}

		GUI.DragWindow (new Rect(0, 0, 200, 40));
	}


	//Handle all GUI stuff in here.
	void OnGUI()
	{
		if (combat == true)			//We only want to draw the combat action menu when we are in combat mode.
		{
			//Draggable Window
			_window = GUI.Window (0, _window, WindowFunction, "Combat Actions");
		
			GUI.BeginGroup(new Rect (windowWidth + 20, Screen.height - (actionBarHeight + 25), actionBarWidth + 10, actionBarHeight + 10));
			GUI.Box(new Rect (10, 10, actionBarWidth, actionBarHeight), "Action Bar");
			for(int i = 0; i < 16; i++)
				{
					GUI.Box(new Rect (20 + (i * 20) + (80 * i), 30, 85, 80), "");
				}
			GUI.EndGroup();
		}

	}

	//Take the data from our "in combat" message and assign it to our local variable
	public void OnCombat(bool combat)
	{
		this.combat = combat;
	}

	//Method to take the whos turn message and apply it to our local variable
	public void OnWhosTurn(GameObject whosTurn)
	{
		this.whosTurn = whosTurn;
	}

	//It is good practice to make sure listeners are removed if this object is ever disabled
	private void OnDisable()
	{
		Messenger<bool>.RemoveListener("in combat", OnCombat);
		Messenger<GameObject>.RemoveListener("whos turn", OnWhosTurn);
	}

	//The method lets us change the scripts we need for the current combat action.
	public void SwitchScripts(CombatActions action)
	{
		if (action != CombatActions.moving)				//When we leave the Moving Event...
		{
			combatMove.GetComponent<CombatMove>().ringInPlace = false;	//Make sure we reset ringInPlace so we can move again if need be
			combatMove.GetComponent<CombatMove>().enabled = false;		//When are not doing the combat move action, we disable its script.
		}

		if (action == CombatActions.rangeAttacking)
		{
			combatRanged.GetComponent<CombatRanged>().enabled = true;
		}

		if (action != CombatActions.rangeAttacking)
		{
			combatRanged.GetComponent<CombatRanged>().enabled = false;
		}

		if(action == CombatActions.meleeAttacking)
		{
			combatMelee.GetComponent<CombatMelee>().enabled = true;
		}

		if(action != CombatActions.meleeAttacking)
		{
			combatMelee.GetComponent<CombatMelee>().enabled = false;
		}
	}
}
