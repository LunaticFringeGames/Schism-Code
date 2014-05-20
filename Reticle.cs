using UnityEngine;
using System.Collections;

public class Reticle : MonoBehaviour 
{
	private Transform myTransform;




	void Start()
	{

		myTransform = this.transform;
	
	}

	void Update () 
	{
		var lookAtPosition = Camera.main.transform.position;
		lookAtPosition.y = myTransform.position.x;
		transform.LookAt(lookAtPosition);
	}


}
