using UnityEngine;
using System.Collections;

[AddComponentMenu("Camera-Control/Mouse Orbit with zoom")]
public class MouseOrbitImproved : MonoBehaviour {
	

	public float distance = 4;
	public float xSpeed = 120f;
	public float ySpeed = 120;
	public float scrollSpeed = 4;

	private Quaternion rotation;
	private Vector3 position;

	private Vector3 point;
	private float x = 4;
	private float y = 4;
	


	void Update()
	{
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		
		if(Input.GetMouseButtonDown(1))
		{
			if (Physics.Raycast(ray, out hit, 100))
			{
				Camera.main.transform.LookAt(hit.point);
				point = hit.point;
			}
		}
		
		if(Input.GetAxis("Mouse ScrollWheel") > 0)
		{
			if(Camera.main.fieldOfView >= 5)
			{
				Camera.main.fieldOfView -= scrollSpeed;
			}
		}
		if(Input.GetAxis("Mouse ScrollWheel") < 0)
		{
			if(Camera.main.fieldOfView <= 80)
			{
				Camera.main.fieldOfView += scrollSpeed;
			}

		}
	}

	void LateUpdate () 
	{

		if (Input.GetMouseButton(2)) {

			x += Input.GetAxis("Mouse X") * xSpeed * 0.02f;
			y += Input.GetAxis("Mouse Y") * ySpeed * 0.02f;
		}
		
		rotation = Quaternion.Euler(y, x, 0);
		
		Vector3 negDistance = new Vector3(0, 1.5f, distance);
		position = rotation * negDistance;
	
		transform.position = position;
		Camera.main.transform.LookAt(point);
	}
	

	
	
}