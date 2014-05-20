using UnityEngine;
using System.Collections;

public class SnapshotPhoto : MonoBehaviour
{
    public Camera cam;


    //This method takes a snapshot of the characters viewport and converts it into a texture
    public void SnapShot()
    {
        //Define the texture element
        Texture2D snapshotPhoto = new Texture2D(Mathf.RoundToInt(cam.pixelWidth), Mathf.RoundToInt(cam.pixelHeight), TextureFormat.RGB24, false);

        //Read the pixel data from the characters minicam
        snapshotPhoto.ReadPixels(new Rect(cam.pixelRect.x, cam.pixelRect.y, cam.pixelWidth, cam.pixelHeight), 0, 0);

        //Apply the pixel data to the texture
        snapshotPhoto.Apply();
       
    }
}

