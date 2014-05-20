/// <summary>
/// Schism
/// PartyManager.cs
/// Scott Sharpe
/// March 23, 2014
/// 
/// The is a class that uses our Singleton script to create a singlton class where we can keep track of data we need about our
/// 	character group from scene to scene.
/// </summary>

using UnityEngine;
using System.Collections;

public class PartyManager : Singleton<PartyManager>
{
	protected PartyManager() {}			//Lock the constructor so we cannot create another instance of this class

	public int? _persistentGroup;								//Keep track of the current character group
	public string[] _persistentCharacter = new string[6];		//Keep track of all six of our characters
    public int activeCharacter;
}
