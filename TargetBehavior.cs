using UnityEngine;
using System.Collections;

public class TargetBehavior : MonoBehaviour {

	private bool rangedAttack;				//Our ranged attack condition
	public GameObject combatRanged;			//reference to our combat ranged object
	//public GameObject target;				//Our target game object
	public GameObject whosTurn;

	//Add our listeners
	void OnEnable()
	{
		Messenger<bool>.AddListener("ranged attack", OnRangedAttack);		//Listen for our ranged attack message
		Messenger<GameObject>.AddListener("whos turn", OnWhosTurn);		//Listen for the message to tell us the gameobject in current position of turn queue
	}

	//Assign the gameobject from the whosTurn message to our local variable.
	public void OnWhosTurn(GameObject whosTurn)
	{
		this.whosTurn = whosTurn;
	}

	void Update()
	{
		if(whosTurn.tag == "Avatar")
		{
			var lookPos = new Vector3(whosTurn.transform.position.x, transform.position.y, whosTurn.transform.position.z);
			transform.LookAt(lookPos);
		}
	}

	//When we "mouse over" an enemy, we want it apparent that it is our target and assign it so
	void OnMouseEnter()
	{
		if (rangedAttack)							//If we are in ranged attack event...
		{
			renderer.material.color = Color.yellow;	//...highlight it yellow
		}
	}

	//When we move off this object, we reset it
	void OnMouseExit()
	{
		renderer.material.color = Color.white;
	}

	void OnMouseDown()
	{
		if (rangedAttack)
		{
			renderer.material.color = Color.red;
		}
	}

	void OnMouseUp()
	{
		renderer.material.color = Color.white;
	}

	//Apply our message condition to this local variable
	void OnRangedAttack(bool rangedAttack)
	{
		this.rangedAttack = rangedAttack;
	}

	//Kill our listeners when the script is disabled.
	void OnDisable()
	{
		Messenger<bool>.RemoveListener("ranged attack", OnRangedAttack);		//Listen for our ranged attack message
		Messenger<GameObject>.RemoveListener("whos turn", OnWhosTurn);
	}
}
