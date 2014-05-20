using UnityEngine;
using System.Collections;

public class ObjectColor1 : MonoBehaviour {
    public SchismUMACrowd umaCrowd;
    public Color skinColor;
    public float skinTone;
    

    public void Update()
    {
        
    }

    

	void OnSetColor(Color color)
	{
        UMA.UMAData myUMAData = umaCrowd.GetComponentInChildren<UMA.UMAData>();
		
		if (myUMAData != null) 
        
        {
               
                myUMAData.Dirty(true, true, true);
                //myUMAData.umaRecipe.slotDataList[1].AddOverlay(umaCrowd.overlayLibrary.InstantiateOverlay("MaleHair02", color));
                //umaCrowd.skinTone = 1;

                skinColor = new Color(1, 1, 1, 1);
                //skinTone = 1;
                skinColor = color;


                umaCrowd.skinColor = color;
                
                umaCrowd.DefineSlots();

           
		}
		else
		{
			
			Debug.Log("UMA DATA IS NULL");
			// Material[] mt = GetComponent<Renderer> ().sharedMaterials;
			// foreach(Material mat in mt)
			// {
			// mat.color = color;
			// Debug.Log("Shader Name: " +mat.shader.name); 
			// }
			// GetComponent<Renderer>().materials = mt;
		}

       
	}
	
	void OnGetColor(ColorPicker picker)
	{
		//Debug.Log("Event Fired Get");
		try{
			picker.NotifyColor(GetComponent<Renderer>().material.color);
		}
		catch
		{
			// Debug.Log ("ERROR setting picker color");
		}
	}

    
}