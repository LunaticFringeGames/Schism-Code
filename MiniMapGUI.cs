using UnityEngine;
using System.Collections;

public class MiniMapGUI : MonoBehaviour {

	public Camera miniMapCam;
	public Texture border;
	private float fov = 50f;
	public float fovMin = 10f;
	public float fovMax = 80f;

	void Update()
	{
		fov = Mathf.Clamp(fov, fovMin, fovMax);
		miniMapCam.fieldOfView = fov;
	}

	void OnGUI()
	{
		GUI.DrawTexture(new Rect(miniMapCam.pixelRect.x, (Screen.height - miniMapCam.pixelRect.yMax), miniMapCam.pixelWidth, miniMapCam.pixelHeight), border);
		GUI.Box(new Rect(miniMapCam.pixelRect.x, (Screen.height - miniMapCam.pixelRect.yMax), miniMapCam.pixelWidth, miniMapCam.pixelHeight * .2f), "Mini Map");
		if(GUI.RepeatButton(new Rect(miniMapCam.pixelRect.x + 15, (Screen.height - miniMapCam.pixelRect.yMax + 15), miniMapCam.pixelWidth * .1f, miniMapCam.pixelHeight * .1f), "-"))
		{
			fov ++;
		}

		if(GUI.RepeatButton(new Rect(miniMapCam.pixelRect.xMax - 40, (Screen.height - miniMapCam.pixelRect.yMax + 15), miniMapCam.pixelWidth * .1f, miniMapCam.pixelHeight * .1f), "+"))
		{
			fov --;
		}

	}
}
