using UnityEngine;
using System.Collections;

public class ObjectColor : MonoBehaviour {
    public SchismUMACrowd umaCrowd;
	void OnSetColor(Color color)
	{
		UMA.UMAData myUMAData = umaCrowd.GetComponentInChildren<UMA.UMAData>();
		
		if (myUMAData != null) 
        
        {
          
            
                myUMAData.isTextureDirty = true;
                //myUMAData.umaRecipe.slotDataList[1].AddOverlay(umaCrowd.overlayLibrary.InstantiateOverlay("MaleHair02", color));
                umaCrowd.hairColor = color;
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