using UnityEngine;
using System.Collections;

public class FadeIn : MonoBehaviour {

	private float colorchange = 1;
	private float colorchange2 = 1;


	// Use this for initialization
	void Start () {
		colorchange = 0f;
		colorchange2 = 0f;
		GameObject Text2 = GameObject.Find ("IntroText2");
		GameObject Text3 = GameObject.Find ("IntroText3");
		Color clearAlpha = new Color (255f, 255f, 255f, colorchange);
		gameObject.guiText.color = clearAlpha;
		Text2.guiText.color = clearAlpha;
		Text3.guiText.color = clearAlpha;

	}
	
	// Update is called once per frame
	void Update () {

		 
		if (gameObject.guiText.color.a < 1f) {
						Color myNewColor = new Color (255f, 255f, 255f, colorchange);
						colorchange += .005f;
						gameObject.guiText.color = myNewColor;
				} else {
						GameObject Text2 = GameObject.Find ("IntroText2");
						GameObject Text3 = GameObject.Find ("IntroText3");
						Color myNewColor = new Color (255f, 255f, 255f, colorchange2);
						if (myNewColor.a < 1f) {
							myNewColor = new Color (255f, 255f, 255f, colorchange2);
							colorchange2 += .005f;
							Text2.guiText.color = myNewColor;
							Text3.guiText.color = myNewColor;
						}
			           else
			{
				//code to load scene 2 here...
				Application.LoadLevel("MainMenu");
			}
				}
	}
}
