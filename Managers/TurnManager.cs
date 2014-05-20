using UnityEngine;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.Linq;

public class TurnManager : MonoBehaviour
{
	public int enemyCount;								//How many enemies are in the scene?
	public GameObject[] enemy; 							//An array to store the enemies.
	public GameObject[] avatar;							//An array to store the avatars.
	public int turn = 0;								//Track whos turn we are on.
	public int Queuecount;								//How many turns do we need to take per round.
	public KeyValuePair<GameObject, int> sortedQueue;	//Our avatars and enemies are sorted by their initiative score, highest to lowest.
	public GameObject whosTurn;							//This will be the gameobject currently in the turn queue we can pass to other scripts
	public float detectEnemyRadius;				//The radius to which our collider extends to detect enemies.
	public GameModeManager gameModeManager;				//Reference to our GameModeManager class so we can access a couple variables from it
	public bool changeTurn = false;
	public int newEnemyCount;
	
	//Create a Dictionary to match each enemy and avatar with his initiative score.
	//We want to have a Queue for our turns based on initiative scores.
	Dictionary<GameObject, int> turnDict = new Dictionary<GameObject, int>();		

	//This is the turn queue we will use as our turn order.  It is sorted by initiative score and can be accessed by index.
	//turnQueue[].Key is the GameObject for the current turn and turnQueue[].Value is the initiative score.
	//We will mostly use this to call turnQueue[turn].Key.
	public List<KeyValuePair<GameObject, int>> turnQueue;	

	//Listen for messages
	void OnEnable()
	{
		Messenger<bool>.AddListener("change turn", OnChangeTurn);		//Listen for our change turn condition 
	}

	//Methos to apply our message info to our local variable
	void OnChangeTurn(bool changeTurn)
	{
		this.changeTurn = changeTurn;
	}

	void Start()
	{

	}

	void Update()
	{

		if(gameModeManager.mode == "Combat")
		{
			if(enemyCount == 0)
			{
				gameModeManager.modeStartUp = true;					
				gameModeManager.mode = "Explore";
				newEnemyCount = 0;
				Debug.Log ("Enemies Dead, going to Explore");
			}
			
			//if (newEnemyCount == 0)									//If all enemies are dead...
			//{
				//...exit combat mode.
				//gameModeManager.modeStartUp = true;					
				//gameModeManager.mode = "Explore";
			//}
			
			//Constantly check to see if we need to change turns or not
			if (changeTurn)
			{
				CreateTurnQueue();
				SortTurnQueue();
				NextTurn (turn);
			}
		}


		//Even though we already do this when we create the turn queue, we do it again in Update() because we want to be
		//able to exit combat mode when all of the enemies are dead.
		enemy = GameObject.FindGameObjectsWithTag("Enemy");		//Populate the enemy array
		enemyCount = enemy.Length;								//Find out how many enemies are in the array

		Messenger<GameObject>.Broadcast("whos turn", whosTurn);		//Broadcast the turn to whoever is listening

		//Here we allow the enemies to take their turns.
		if(whosTurn.tag == "Enemy")
		{
			EnemyAttack();
		}
	}



	//This is our method to create the turn queue
	public void CreateTurnQueue () 
	{
		enemy = GameObject.FindGameObjectsWithTag("Enemy");		//Populate the enemy array
		enemyCount = enemy.Length;								//Find out how many enemies are in the array
		avatar = GameObject.FindGameObjectsWithTag("Avatar");	//Populate the avatar array
		turnDict.Clear();

		//Use this loop to add the enemies to our Dictionary
		for (int i=0; i < enemyCount; i++)								//We us enemyCount as the number of cycles.
		{
			enemy[i].name = "Enemy" + i;											//Assign unique names to each enemy
			EnemyClass enemyClass = enemy[i].GetComponent<EnemyClass>();			//Get the EnemyClass script from each enemy

			//Create a temp variable to store the distance from each enemy we put into our enemy array to our position
			var distance = Vector3.Distance(transform.position, enemy[i].transform.position);
			//newEnemyCount = enemyCount;
			//We only want to add the enemies from the enemy array that are inside our colliders radius
			if (distance < detectEnemyRadius + 10)
			{
				turnDict[enemy[i]] = enemyClass.initiativeScore;		//Assign the enemies as keys and initiative scores as values.
			}
			newEnemyCount = turnDict.Count;

		}

		//This loop adds the avatars to the Dictionary
		for (int i=0; i < 6; i++)
		{
			AvatarClass avatarClass = avatar[i].GetComponent<AvatarClass>();		//Get the AvatarClass script from our Avatar
			turnDict[avatar[i]] = avatarClass.initiativeScore;						//Add the Avatar to our queue
		}
	}	

	//This is our method for taking our dictionary of unsorted enemies and avatars and converting them into an IOrderedEnummerable
	//KeyValuePair so that we can sort them by their initiative scores stored as the Values.
	//Then we convert the sorted queue into a List of KeyValuePairs so that we can access them by index.
	public void SortTurnQueue ()
	{
		//turnQueue.Clear();
		//Use LINQ to sort our dictionary based on the values.
		var sortedQueue = from pair in turnDict orderby pair.Value descending select pair;
		
		turnQueue = sortedQueue.ToList();			//We turn the queue back into a List so we can access it by index.
		//We can use sortedQueue[turn].Key to get whos turn it is.

		Queuecount = turnQueue.Count;					//How many enemies and avatars are in our queue

		whosTurn = turnQueue[turn].Key;		
	}

	//This is our method for changing the turn
	public void NextTurn(int t)
	{
		if (t >= Queuecount)							//Make sure we don't go over our turn count
		{	
			turn = 0;								//If we try to go over turn count, reset turn to 0
			whosTurn = turnQueue[turn].Key;			//Assign the turn to the turnQueue Key in the current position.
			changeTurn = false;						//Reset our change turn conditon
		}
		else if (t < Queuecount)
		{
			turn++;									//Increment the turn count
			whosTurn = turnQueue[turn].Key;			//If we are still in the turn count range, assign the current turn.

			changeTurn = false;						//Reset our change turn condition
		}
	}

	//This is our method to similate enemy attacks for now.
	void EnemyAttack()
	{
		int rndm = Random.Range(0, 5);								//Get a random number
		avatar[rndm].GetComponent<AvatarClass>().hp--;				//Get the avatar coresponding to the random numbers hp value and subtract 1
		Debug.Log("Enemy attacks: " + avatar[rndm]);	
		changeTurn = true;											//activate our change turn condition to move to next turn

		Messenger<string, string>.Broadcast("avatar hit", whosTurn.name.ToString(), avatar[rndm].name.ToString());

	}

	//As always, remove listeners if the script is disabled
	void OnDisable()
	{
		Messenger<bool>.RemoveListener("change turn", OnChangeTurn); 
	}
}
