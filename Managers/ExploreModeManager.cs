using UnityEngine;
using System.Collections;

public class ExploreModeManager : MonoBehaviour 
{
	public bool explore = true;
	public GameObject whosTurn;

	private void OnEnable()
	{
		Messenger<bool>.AddListener("in explore", OnExplore);					//Are we in combat right now?
	}

	void Start () 
	{
	
	}
	

	void Update () 
	{
		if (explore == true)
		{

		}
	}

	void OnExplore(bool explore)
	{
		this.explore = explore;
	}

	void SearchForEnemies()
	{

	}



	//It is good practice to make sure listeners are removed if this object is ever disabled
	private void OnDisable()
	{
		Messenger<bool>.RemoveListener("in explore", OnExplore);
	}
}
