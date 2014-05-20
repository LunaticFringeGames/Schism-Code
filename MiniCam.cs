using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MiniCam : MonoBehaviour 
{
	
    public Texture2D border;                    //A border around the camera viweport to indicate it is not active
    public Rect characterBox;                   //The rect for the viewport
    public Texture2D borderHighlighted;         //A highlighted border to indicate to the player that this is the active character
    public Texture2D guiBorder;                 //A variable to hold the border for the current state (active or not active)
    public int characterID;                     //The id we assign to each miniCam to make it unique (this is what we pass to our singleton to indicate which character is active)
    public static int activeCharacter;          //A reference to the currently active character
    public GameObject[] avatars = new GameObject[6];
    public Transform[] myHead;
    public GameObject[] cameras;

	void Start()
	{
        for (int i = 0; i < 6; i++)
        {

            UMA.UMAData myUMAData = avatars[i].GetComponentInChildren<UMA.UMAData>();

            if (myUMAData != null)
            {
                myHead[i] = myUMAData.animator.GetBoneTransform(HumanBodyBones.Neck);
                cameras[i].transform.parent = myHead[i];
                cameras[i].transform.LookAt(myHead[i]);

            }
            else
            {

                Debug.Log("ERROR UMA IS NULL CAMERA SCRIPT");
            }
        }
	}
    
}
