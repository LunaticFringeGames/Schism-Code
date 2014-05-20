using UnityEngine;
using System.Collections;

public class AvatarClass : MonoBehaviour 
{
	public int initiativeScore;					//Avatar initiative score, used to determine turn order
	public int actionPoints;					//Avatars action points
	private static int actionPointsInit;		//We use this to hold our starting value so we can reset it when we start a new turn
	public int hp;								//Avatar HP
    


	void Start () 
	{
		actionPointsInit = actionPoints;		//Assign our action points to the init value




	}

	void Update () 
	{
		//When we are out of action points, send the message to turn manager to change the turn and we reset our action points
		if (actionPoints == 0)									
		{
			Messenger<bool>.Broadcast("change turn", true);
			actionPoints = actionPointsInit;
		}

		if(hp < 0)
		{
			Debug.Log("Game Over!");
		}
	}


}
