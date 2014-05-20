using UnityEngine;
using System.Collections;

public class InstantiateAvatars : MonoBehaviour 
{
	public GameObject[] avatars;				//Create an array from avatar prefabs in the inspector to be instantiated
	public GameObject[] avatarPads;			//Create an array of Avatar Pads in the inspector so we have locations for our instantiations

	//We will do this in the Awake() Event so it happens immediately upon initialization before anything else.
	void Awake () 
	{



		//Populate our arrays by looping through them 6 times
		for (int i = 0; i <=5; i++)
		{
			//Instantiate all of our Avatars.
			GameObject avatar = Instantiate(avatars[i], new Vector3 (avatarPads[i].transform.position.x, 2.4f, avatarPads[i].transform.position.z), Quaternion.identity) as GameObject;
			//Make sure they have unique names
			avatar.name = avatars[i].name;
			//Child the Avatar objects to the Avatar Pads
			avatar.transform.parent = avatarPads[i].transform;
			//Tag them for good measure.
			avatar.tag = "Avatar";

		}
	}
}
