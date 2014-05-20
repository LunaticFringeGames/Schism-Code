using UnityEngine;
using System.Collections;

public class TargetBehavior2 : MonoBehaviour {


	//public GameObject target;				//Our target game object
	public GameObject whosTurn;
	
	//Add our listeners
	void OnEnable()
	{

		Messenger<GameObject>.AddListener("whos turn", OnWhosTurn);		//Listen for the message to tell us the gameobject in current position of turn queue
	}
	
	//Assign the gameobject from the whosTurn message to our local variable.
	public void OnWhosTurn(GameObject whosTurn)
	{
		this.whosTurn = whosTurn;
	}
	

	
	//When we "mouse over" an enemy, we want it apparent that it is our target and assign it so
	void OnMouseEnter()
	{
		var lookPos = new Vector3(whosTurn.transform.position.x, transform.position.y, whosTurn.transform.position.z);
		transform.LookAt(lookPos);
	}
	
	//When we move off this object, we reset it
	void OnMouseExit()
	{
		transform.LookAt(Vector3.zero);
	}
	
	void OnMouseDown()
	{
		animation.Play("soldierHitFront");
	}
	
	void OnMouseUp()
	{
		animation.Play ("soldierIdle");
	}
	

	
	//Kill our listeners when the script is disabled.
	void OnDisable()
	{

		Messenger<GameObject>.RemoveListener("whos turn", OnWhosTurn);
	}
}
