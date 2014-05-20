using UnityEngine;
using System.Collections;

public class HandObject : MonoBehaviour {

	public GameObject carryObject;
	public UMACrowd umaCrowd;

	// Use this for initialization
	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
        ////UMA.UMAData myUMAData = umaCrowd.GetComponentInChildren<UMA.UMAData>();

        //if(myUMAData != null)
        //{
        //    RuntimeAnimatorController myController = myUMAData.animationController;
        //    var rightHand = myUMAData.animator.GetBoneTransform(HumanBodyBones.RightHand);
        //    carryObject.transform.position = rightHand.transform.position;
        //}
	
	
	}
}
