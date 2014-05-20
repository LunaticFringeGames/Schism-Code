using UnityEngine;
using System.Collections;

public class DetectEnemies : MonoBehaviour 
{
	public GameModeManager gameModeManager;
	public TurnManager turnManager;



	//This is how we determine if there are any enemies within range.  If there are, we create a turn queue and enter Combat Mode
	void OnTriggerEnter(Collider c)
	{
		if (c.gameObject.tag == "Enemy")			//Make sure whatever we collided with is an Enemy
		{
			//turnManager.enabled = true;
			turnManager.CreateTurnQueue();						//Call the method to create the turn queue
			turnManager.SortTurnQueue();						//Call the method to sort the turn queue
			
			gameModeManager.modeStartUp = true;		//Tell GameModeManager that we are starting combat mode
			gameModeManager.mode = "Combat";		//Assign GameModeManagers mode to combat
			Debug.Log("found enemy");


		}
		else return;
	}	
}
