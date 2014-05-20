using UnityEngine;
using System.Collections;

[AddComponentMenu("Camera-Control/Mouse Orbit with zoom")]
public class MouseOrbitImproved : MonoBehaviour 
{
	public Transform combatCameraPosition;
	public GameObject target;
	public float distance = 15.0f;
	public float xSpeed = 120.0f;
	public float ySpeed = 120.0f;
	
	public float yMinLimit = 10f;
	public float yMaxLimit = 80f;
	
	public float distanceMin = 2f;
	public float distanceMax = 25f;
	public TurnManager turnManager;
	
	float x = 30.0f;
	float y = 30.0f;

	Vector3 position; 
	Quaternion rotation;
	
	// Use this for initialization
	void OnEnable () 
	{


		Vector3 angles = transform.eulerAngles;
		x = angles.y;
		y = angles.x;
		
		// Make the rigid body not change rotation
		if (rigidbody)
			rigidbody.freezeRotation = true;

	}
	
	void LateUpdate () 
	{
		target = turnManager.whosTurn;
		transform.LookAt(target.transform);

		distance = Mathf.Clamp(distance - Input.GetAxis("Mouse ScrollWheel")*5, distanceMin, distanceMax);

		//float dist = Vector3.Distance(target.transform.position, transform.position);

		//distance -=  dist;


		y = ClampAngle(y, yMinLimit, yMaxLimit);

		rotation = Quaternion.Euler(y, x, 0);

		Vector3 negDistance = new Vector3(0.0f, 0.0f, -distance);
		position = rotation * negDistance + target.transform.position;

		transform.rotation = rotation;
		transform.position = position;

		if (Input.GetMouseButton(1)) 
		{

			x += Input.GetAxis("Mouse X") * xSpeed * distance * 0.02f;
			y -= Input.GetAxis("Mouse Y") * ySpeed * 0.02f;
				
		}

	}
	
	public static float ClampAngle(float angle, float min, float max)
	{
		if (angle < -360F)
			angle += 360F;
		if (angle > 360F)
			angle -= 360F;
		return Mathf.Clamp(angle, min, max);
	}
	
	
}