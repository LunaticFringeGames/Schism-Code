using UnityEngine;
using System.Collections;

public class FirstPerson : MonoBehaviour 
{

	public float MoveSpeed = 10f;			//This is how fast we want to move.
	public float RotateSpeed = 8f;			//This is how fast we want the camera to move.

	
	void Update () 
	{
		//Reference our Character Controller.
		CharacterController controller = GetComponent<CharacterController>();

		//If we only press the RMB we pan the camera left and right.  Vertical camera movement is handled on the camera itself.
		if(Input.GetMouseButton(1))
		{
			transform.Rotate(0, Input.GetAxis("Mouse X") * RotateSpeed, 0);
		}

		//If we press both mouse button we move in the direction we are currently facing.
		if(Input.GetMouseButton(0) && Input.GetMouseButton(1))
		{
			Vector3 forward = transform.TransformDirection(Vector3.forward);
			controller.SimpleMove(forward * MoveSpeed);
		}
	}
}
