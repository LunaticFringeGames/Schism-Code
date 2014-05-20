/// <summary>
/// Schism
/// BaseCharacter.cs
/// Scott Sharpe
/// March 23, 2014
/// 
/// This script creats a class we can use to hold unique data for each character while we are in the character creation process.
/// </summary>

using UnityEngine;
using System.Collections;

[System.Serializable]
public class BaseCharacter
{
	public string thisCharacterName;					//Character Name
	public int[] attributeValue = new int[12];			//The 12 Base Attributes
	public int[] derivedStatValue = new int[12];		//The 12 Derived Stats

	//Constructor
	public BaseCharacter()
	{
		thisCharacterName = "";					//assign default name to empty string
		for(int i = 0; i < 12; i++)				
		{
			attributeValue[i] = 5;				//assing default attribute values
			derivedStatValue[i] = 0;			//assign default derived stat values
		}
	}

}
