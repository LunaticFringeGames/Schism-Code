/// <summary>
/// Schism
/// CreatePartyRedux.cs
/// April 11, 2014
/// Scott Sharpe
/// 
/// This script handles the GUI for our character creation.  We are going to use the UMA Framework to create the 
/// 	character models and adjust their appearance.  The end result of this scene will be six customized character
/// 	models and assign names and genders to them.  We will also save this data to our database and our persistent
/// 	singleton class.
/// </summary>

#region NameSpaces
using UnityEngine;
using System.Collections;
using System.Linq;
using Mono.Data.Sqlite;
using System;
using System.Collections.Generic;
using SchismDB;
using UMA;
#endregion

public class CreatePartyRedux : MonoBehaviour 
{
#region fields
	private SchismDB.MonoStrict db;							//Reference to our dbMetal database connection context object

	public SchismUMACrowd umaCrowd;							//Reference to the UMA Crowd object
	public UMAData umaData;									//Reference to our UMA Data information
	public UMADynamicAvatar umaDynamicAvatar;				//Reference to our UMA Avatar
	public UMADnaHumanoid umaDna;							//Reference to our UMA Dna information
	public SlotLibrary mySlotLibrary;						//Reference to our slot library
	public OverlayLibrary myOverlayLibrary;					//Reference to our overlay library
	public GameObject myUMACharacter;						//Reference to our UMA character game object

	public GUISkin guiSkin;									//Reference to our GUI skin
	public GUIStyle myStyle;								//Reference to our GUI style

	private string[] characterName = new string[6];			//Array to hold the character names
	private string[] gender;								//Array to hold the character genders
	private bool[] male;									//Array for the Male toggles
	private bool[] female;									//Array for the Female toggles
    private bool maleOptions = true;
	private Character[] characterQuery;						//Character Table Query array
	private bool[] saved;									//Condition to determine if we have saved the character or not

	public string SaveFile = "null";						//A string to save our recipe to
	public string UMARace;									//A String to determine which race to generate
	
	private bool generateCharacter = false;					//Condition to determine if we are generating a character
    private int whichWindow;
	
	private Rect _facewindow;								//The location and dimensions of our Face Window
	private Rect _bodywindow;								//The location and dimensions of our Body Window
    private Rect _hairwindow;
    private Rect _clotheswindow;

	private Vector2 BODY_WINDOW;							//The X, Y dimensions of our Body Window
	private Vector2 FACE_WINDOW;							//The X, Y dimensions of our Face Window
    private Vector2 HAIR_WINDOW;
	private Vector2 CONTROL_BOX;							//The X, Y dimensions of our Control Box
	private Vector2 SLIDER;									//The X, Y dimensions of our Slider Control
	private float SLIDERPOSX;								//The X coordinate of our Slider Control
	private Vector2 WINDOW_LABEL;							//The x, y, dimensions of our window labels
	private float OFFSET = Screen.width * .005f;
	private Vector2 LABEL = new Vector2(Screen.width * .02f, 
	                                    Screen.height * .02f);		//The X, Y dimensions of our standard label
	private Vector2 BUTTON = new Vector2(Screen.width * .04f, 
	                             		 Screen.height * .025f);	//The X, Y dimensions of our buttons
	private Vector2 TOGGLE = new Vector2(Screen.width * .04f, 
	                             		 Screen.height * .025f);	//The X, Y dimensions of our toggle controls
    public bool[] created;
    public int characterCount = 0;
	public Transform hitPoint;
    private int characterGroupID = 0;
    private Character[] character = new Character[6];
#endregion
    public void DrawHairWindow()
    {
		GUI.BeginGroup(new Rect (OFFSET, 
		                         OFFSET , 
		                         FACE_WINDOW.x, 
		                         FACE_WINDOW.y));				//Begin the group to hold our face controls

        

		GUI.Box(new Rect(0, 
		                 OFFSET, 
		                 FACE_WINDOW.x - (OFFSET * 3), 
		                 FACE_WINDOW.y - (OFFSET * 8)), "");	//Draw the box to hold the face controls

        if (GUI.Button(new Rect(OFFSET, OFFSET * 2 , 80, 20), "Hair 1"))
        {
            umaCrowd.hair = 1;
            umaData.isMeshDirty = true;
            umaData.isTextureDirty = true;
            umaCrowd.DefineSlots();
        }

        if (GUI.Button(new Rect(OFFSET + 100, OFFSET * 2 , 80, 20), "Hair 2"))
        {
            umaCrowd.hair = 2;
            umaData.isMeshDirty = true;
            umaData.isTextureDirty = true;
            umaCrowd.DefineSlots();
        }

        if (GUI.Button(new Rect(OFFSET + 200, OFFSET * 2, 80, 20), "Hair 3"))
        {
            umaCrowd.hair = 3;
            umaData.isMeshDirty = true;
            umaData.isTextureDirty = true;
            umaCrowd.DefineSlots();
        }

        if (UMARace == "Female")
        {
            if (GUI.Button(new Rect(OFFSET + 300, OFFSET * 2, 80, 20), "Hair 4"))
            {
                umaCrowd.hair = 4;
                umaData.isMeshDirty = true;
                umaData.isTextureDirty = true;
                umaCrowd.DefineSlots();
            }
        }


        GUI.EndGroup();
    }

    public void DrawClothesWindow()
    {
        GUI.BeginGroup(new Rect(OFFSET,
                                 OFFSET,
                                 FACE_WINDOW.x,
                                 FACE_WINDOW.y));				//Begin the group to hold our face controls



        GUI.Box(new Rect(0,
                         OFFSET,
                         FACE_WINDOW.x - (OFFSET * 3),
                         FACE_WINDOW.y - (OFFSET * 8)), "");	//Draw the box to hold the face controls

        if (UMARace == "Female")
        {
            if (GUI.Button(new Rect(OFFSET, OFFSET * 2, 80, 20), "Shirt 1"))
            {
                umaCrowd.shirt = 1;
                umaData.isMeshDirty = true;
                umaData.isTextureDirty = true;
                umaCrowd.DefineSlots();
            }

            if (GUI.Button(new Rect(OFFSET + 100, OFFSET * 2, 80, 20), "Shirt 2"))
            {
                umaCrowd.shirt = 2;
                umaData.isMeshDirty = true;
                umaData.isTextureDirty = true;
                umaCrowd.DefineSlots();
            }

            if (GUI.Button(new Rect(OFFSET + 200, OFFSET * 2, 80, 20), "Shirt 3"))
            {
                umaCrowd.shirt = 3;
                umaData.isMeshDirty = true;
                umaData.isTextureDirty = true;
                umaCrowd.DefineSlots();
            }
        }

        

        GUI.EndGroup();
    }


	//This method contains the GUI information for the Face Window (the window that contains the controls to manipulate
	//	the face bones of our character mesh)
#region DrawFaceWindow Method
	public void DrawFaceWindow()
	{
		GUI.BeginGroup(new Rect (OFFSET, 
		                         OFFSET , 
		                         FACE_WINDOW.x + 200, 
		                         200));				//Begin the group to hold our face controls

        if (GUI.Button(new Rect(OFFSET, OFFSET , 80, 20), "Head 1"))
        {
            umaCrowd.head = 1;
            umaData.isMeshDirty = true;
            umaData.isTextureDirty = true;
            umaCrowd.DefineSlots();
        }

        if (GUI.Button(new Rect(OFFSET + 100, OFFSET , 80, 20), "Head 2"))
        {
            umaCrowd.head = 2;
            umaData.isMeshDirty = true;
            umaData.isTextureDirty = true;
            umaCrowd.DefineSlots();
        }

       
         if (GUI.Button(new Rect(OFFSET + 200, OFFSET, 80, 20), "Head 3"))
         {
            umaCrowd.head = 3;
            umaData.isMeshDirty = true;
            umaData.isTextureDirty = true;
            umaCrowd.DefineSlots();
        }

         if (UMARace == "Female")
         {
             if (GUI.Button(new Rect(OFFSET + 300, OFFSET, 80, 20), "Head 3"))
             {
                 umaCrowd.head = 4;
                 umaData.isMeshDirty = true;
                 umaData.isTextureDirty = true;
                 umaCrowd.DefineSlots();
             }
         }

        if (UMARace == "Male")
        {
            if (GUI.Button(new Rect(OFFSET, OFFSET * 4, 80, 20), "Beard 1"))
            {
                umaCrowd.beard = 1;
                umaData.isMeshDirty = true;
                umaData.isTextureDirty = true;
                umaCrowd.DefineSlots();
            }

            if (GUI.Button(new Rect(OFFSET + 100, OFFSET * 4, 80, 20), "Beard 2"))
            {
                umaCrowd.beard = 2;
                umaData.isMeshDirty = true;
                umaData.isTextureDirty = true;
                umaCrowd.DefineSlots();
            }
            if (GUI.Button(new Rect(OFFSET + 200, OFFSET * 4, 80, 20), "Beard 3"))
            {
                umaCrowd.beard = 3;
                umaData.isMeshDirty = true;
                umaData.isTextureDirty = true;
                umaCrowd.DefineSlots();
            }

            if (GUI.Button(new Rect(OFFSET + 300, OFFSET * 4, 80, 20), "No Beard"))
            {
                umaCrowd.beard = 4;
                umaData.isMeshDirty = true;
                umaData.isTextureDirty = true;
                umaCrowd.DefineSlots();
            }
        }

        if (UMARace == "Male")
        {
            if (GUI.Button(new Rect(OFFSET, OFFSET * 7, 80, 20), "Eyebrow 1"))
            {
                umaCrowd.eyebrow = 1;
                umaData.isMeshDirty = true;
                umaData.isTextureDirty = true;
                umaCrowd.DefineSlots();
            }
            else if (GUI.Button(new Rect(OFFSET + 100, OFFSET * 7, 80, 20), "Eyebrow 2"))
            {
                umaCrowd.eyebrow = 2;
                umaData.isMeshDirty = true;
                umaData.isTextureDirty = true;
                umaCrowd.DefineSlots();
            }
        }
        

        GUI.EndGroup();
        GUI.BeginGroup(new Rect(OFFSET,
                                 OFFSET * 8,
                                 FACE_WINDOW.x,
                                 FACE_WINDOW.y));				//Begin the group to hold our face controls

		GUI.Box(new Rect(0, 
		                 OFFSET * 3, 
		                 FACE_WINDOW.x - (OFFSET * 6), 
		                 FACE_WINDOW.y - (OFFSET * 6)), "");	//Draw the box to hold the face controls

       


		//Face Controls:
		#region Nose Size
		GUI.Label(new Rect(OFFSET, 
		                   OFFSET * 3, 
		                   WINDOW_LABEL.x, 
		                   WINDOW_LABEL.y), 
		          "Nose Size");

		umaDna.noseSize = GUI.HorizontalSlider(new Rect(SLIDERPOSX, 								//position x
		                                               (OFFSET * 3.5f), 							//position y
		                                                SLIDER.x, 									//dimension x
		                                                SLIDER.y), 									//dimension y
		                                       umaDna.noseSize, 									//UMADna object
		                                       0f, 												//min value
		                                       1f); 												//max value
		#endregion
		#region Nose Curve
		GUI.Label(new Rect(OFFSET, 
		                   (OFFSET * 3) + WINDOW_LABEL.y, 
		                   WINDOW_LABEL.x, 
		                   WINDOW_LABEL.y), 
		          "Nose Curve");

		umaDna.noseCurve = GUI.HorizontalSlider(new Rect(SLIDERPOSX, 
		                                                 (OFFSET * 3.5f) + SLIDER.y, 
		                                                 SLIDER.x, 
		                                                 SLIDER.y), 
		                                        umaDna.noseCurve, 
		                                        0.0f, 
		                                        1.0f); 
		#endregion
		#region Nose Flatten
		GUI.Label(new Rect(OFFSET, 
		                   (OFFSET * 3) + (WINDOW_LABEL.y * 2), 
		                   WINDOW_LABEL.x, 
		                   WINDOW_LABEL.y), 
		          "Nose Flatten");

		umaDna.noseFlatten = GUI.HorizontalSlider(new Rect(SLIDERPOSX, 
		                                                   (OFFSET * 3.5f) + (SLIDER.y * 2), 
		                                                   SLIDER.x, 
		                                                   SLIDER.y), 
		                                          umaDna.noseFlatten, 
		                                          0.0f, 
		                                          1.0f); 
		#endregion
		#region Nose Position
		GUI.Label(new Rect(OFFSET, 
		                   (OFFSET * 3) + (WINDOW_LABEL.y * 3), 
		                   WINDOW_LABEL.x, 
		                   WINDOW_LABEL.y), 
		          "Nose Position");

		umaDna.nosePosition = GUI.HorizontalSlider(new Rect(SLIDERPOSX, 
		                                                    (OFFSET * 3.5f) + (SLIDER.y * 3), 
		                                                    SLIDER.x, 
		                                                    SLIDER.y), 
		                                           umaDna.nosePosition, 
		                                           0.0f, 
		                                           1.0f); 
		#endregion
		#region Mouth Size
		GUI.Label(new Rect(OFFSET, 
		                   (OFFSET * 3) + (WINDOW_LABEL.y * 4), 
		                   WINDOW_LABEL.x, 
		                   WINDOW_LABEL.y), 
		          "Mouth Size");

		umaDna.mouthSize = GUI.HorizontalSlider(new Rect(SLIDERPOSX, 
		                                                 (OFFSET * 3.5f) + (SLIDER.y * 4), 
		                                                 SLIDER.x, 
		                                                 SLIDER.y), 
		                                        umaDna.mouthSize, 
		                                        0.0f, 
		                                        1.0f); 
		#endregion
		#region Nose Width
		GUI.Label(new Rect(OFFSET, 
		                   (OFFSET * 3) + (WINDOW_LABEL.y * 5),
		                   WINDOW_LABEL.x, 
		                   WINDOW_LABEL.y), 
		          "Nose Width");

		umaDna.noseWidth = GUI.HorizontalSlider(new Rect(SLIDERPOSX, 
		                                                 (OFFSET * 3.5f) + (SLIDER.y * 5), 
		                                                 SLIDER.x, 
		                                                 SLIDER.y), 
		                                        umaDna.noseWidth, 
		                                        0.0f, 
		                                        1.0f);
		#endregion
		#region Mandible Size
		GUI.Label(new Rect(OFFSET, 
		                   (OFFSET * 3) + (WINDOW_LABEL.y * 6), 
		                   WINDOW_LABEL.x, 
		                   WINDOW_LABEL.y), 
		          "Mandible Size");

		umaDna.mandibleSize = GUI.HorizontalSlider(new Rect(SLIDERPOSX, 
		                                                    (OFFSET * 3.5f) + (SLIDER.y * 6), 
		                                                    SLIDER.x, 
		                                                    SLIDER.y), 
		                                           umaDna.mandibleSize, 
		                                           0.0f, 
		                                           1.0f); 
		#endregion
		#region Lips Size
		GUI.Label(new Rect(OFFSET, 
		                   (OFFSET * 3) + (WINDOW_LABEL.y * 7), 
		                   WINDOW_LABEL.x, 
		                   WINDOW_LABEL.y), 
		          "Lips Size");

		umaDna.lipsSize = GUI.HorizontalSlider(new Rect(SLIDERPOSX, 
		                                                (OFFSET * 3.5f) + (SLIDER.y * 7), 
		                                                SLIDER.x, 
		                                                SLIDER.y), 
		                                       umaDna.lipsSize, 
		                                       0.0f, 
		                                       1.0f); 
		#endregion
		#region Jaw Size
		GUI.Label(new Rect(OFFSET, 
		                   (OFFSET * 3) + (WINDOW_LABEL.y * 8), 
		                   WINDOW_LABEL.x, 
		                   WINDOW_LABEL.y), 
		          "Jaw Size");

		umaDna.jawsSize = GUI.HorizontalSlider(new Rect(SLIDERPOSX, 
		                                                (OFFSET * 3.5f) + (SLIDER.y * 8), 
		                                                SLIDER.x, 
		                                                SLIDER.y), 
		                                       umaDna.jawsSize, 
		                                       0.0f, 
		                                       1.0f); 
		#endregion
		#region Jaw Position
		GUI.Label(new Rect(OFFSET, 
		                   (OFFSET * 3) + (WINDOW_LABEL.y * 9), 
		                   WINDOW_LABEL.x, 
		                   WINDOW_LABEL.y), 
		          "Jaw Position");

		umaDna.jawsPosition = GUI.HorizontalSlider(new Rect(SLIDERPOSX, 
		                                                    (OFFSET * 3.5f) + (SLIDER.y * 9), 
		                                                    SLIDER.x, 
		                                                    SLIDER.y), 
		                                           umaDna.jawsPosition, 
		                                           0.0f, 
		                                           1.0f); 
		#endregion
		#region Forehead Size
		GUI.Label(new Rect(OFFSET, 
		                   (OFFSET * 3) + (WINDOW_LABEL.y * 10), 
		                   WINDOW_LABEL.x, 
		                   WINDOW_LABEL.y), 
		          "Forehead Size");

		umaDna.foreheadSize = GUI.HorizontalSlider(new Rect(SLIDERPOSX, 
		                                                    (OFFSET * 3.5f) + (SLIDER.y * 10), 
		                                                    SLIDER.x, 
		                                                    SLIDER.y), 
		                                           umaDna.foreheadSize, 
		                                           0.0f, 
		                                           1.0f); 
		#endregion
		#region Forehead Position
		GUI.Label(new Rect(OFFSET, 
		                   (OFFSET * 3) + (WINDOW_LABEL.y * 11), 
		                   WINDOW_LABEL.x, 
		                   WINDOW_LABEL.y), 
		          "Forehead Position");

		umaDna.foreheadPosition = GUI.HorizontalSlider(new Rect(SLIDERPOSX, 
		                                                        (OFFSET * 3.5f) + (SLIDER.y * 11), 
		                                                        SLIDER.x, 
		                                                        SLIDER.y), 
		                                               umaDna.foreheadPosition, 
		                                               0.0f, 
		                                               1.0f); 
		#endregion
		#region Eye Size
		GUI.Label(new Rect(OFFSET, 
		                   (OFFSET * 3) + (WINDOW_LABEL.y * 12), 
		                   WINDOW_LABEL.x, 
		                   WINDOW_LABEL.y), 
		          "Eye Size");

		umaDna.eyeSize = GUI.HorizontalSlider(new Rect(SLIDERPOSX, 
		                                               (OFFSET * 3.5f) + (SLIDER.y * 12), 
		                                               SLIDER.x, 
		                                               SLIDER.y), 
		                                      umaDna.eyeSize, 
		                                      0.0f, 
		                                      2.0f); 
		#endregion
		#region Eye Rotation
		GUI.Label(new Rect(OFFSET, 
		                   (OFFSET * 3) + (WINDOW_LABEL.y * 13), 
		                   WINDOW_LABEL.x, 
		                   WINDOW_LABEL.y), 
		          "Eye Rotation");

		umaDna.eyeRotation = GUI.HorizontalSlider(new Rect(SLIDERPOSX, 
		                                                   (OFFSET * 3.5f) + (SLIDER.y * 13), 
		                                                   SLIDER.x, 
		                                                   SLIDER.y), 
		                                          umaDna.eyeRotation, 
		                                          0.0f, 
		                                          1.0f); 
		#endregion
		#region Ear Size
		GUI.Label(new Rect(OFFSET, 
		                   (OFFSET * 3) + (WINDOW_LABEL.y * 14), 
		                   WINDOW_LABEL.x, 
		                   WINDOW_LABEL.y), 
		          "Ear Size");

		umaDna.earsSize = GUI.HorizontalSlider(new Rect(SLIDERPOSX, 
		                                                (OFFSET * 3.5f) + (SLIDER.y * 14), 
		                                                SLIDER.x, 
		                                                SLIDER.y), 
		                                       umaDna.earsSize, 
		                                       0.0f, 
		                                       1.0f);
		#endregion
		#region Ear Position
		GUI.Label(new Rect(OFFSET, 
		                   (OFFSET * 3) + (WINDOW_LABEL.y * 15), 
		                   WINDOW_LABEL.x, 
		                   WINDOW_LABEL.y), 
		          "Ear Position");

		umaDna.earsPosition = GUI.HorizontalSlider(new Rect(SLIDERPOSX, 
		                                                    (OFFSET * 3.5f) + (SLIDER.y * 15), 
		                                                    SLIDER.x, 
		                                                    SLIDER.y), 
		                                           umaDna.earsPosition, 
		                                           0.0f, 
		                                           1.0f);
		#endregion
		#region Ear Rotation
		GUI.Label(new Rect(OFFSET, 
		                   (OFFSET * 3) + (WINDOW_LABEL.y * 16), 
		                   WINDOW_LABEL.x, 
		                   WINDOW_LABEL.y), 
		          "Ear Rotation");

		umaDna.earsRotation = GUI.HorizontalSlider(new Rect(SLIDERPOSX, 
		                                                    (OFFSET * 3.5f) + (SLIDER.y * 16), 
		                                                    SLIDER.x, 
		                                                    SLIDER.y), 
		                                           umaDna.earsRotation, 
		                                           0.0f, 
		                                           1.0f);
		#endregion
		#region Chin Size
		GUI.Label(new Rect(OFFSET, 
		                   (OFFSET * 3) + (WINDOW_LABEL.y * 17), 
		                   WINDOW_LABEL.x, 
		                   WINDOW_LABEL.y), 
		          "Chin Size");

		umaDna.chinSize = GUI.HorizontalSlider(new Rect(SLIDERPOSX, 
		                                                (OFFSET * 3.5f) + (SLIDER.y * 17), 
		                                                SLIDER.x, 
		                                                SLIDER.y), 
		                                       umaDna.chinSize, 
		                                       0.0f, 
		                                       1.0f);
		#endregion
		#region Chin Pronounced
		GUI.Label(new Rect(OFFSET, 
		                   (OFFSET * 3) + (WINDOW_LABEL.y * 18),
		                   WINDOW_LABEL.x, 
		                   WINDOW_LABEL.y), 
		          "Chin Pronounced");

		umaDna.chinPronounced = GUI.HorizontalSlider(new Rect(SLIDERPOSX, 
		                                                      (OFFSET * 3.5f) + (SLIDER.y * 18), 
		                                                      SLIDER.x, 
		                                                      SLIDER.y), 
		                                             umaDna.chinPronounced, 
		                                             0.0f, 
		                                             1.0f);
		#endregion
		#region Chin Position
		GUI.Label(new Rect(OFFSET, 
		                   (OFFSET * 3) + (WINDOW_LABEL.y * 19), 
		                   WINDOW_LABEL.x, 
		                   WINDOW_LABEL.y), 
		          "Chin Position");

		umaDna.chinPosition = GUI.HorizontalSlider(new Rect(SLIDERPOSX, 
		                                                    (OFFSET * 3.5f) + (SLIDER.y * 19), 
		                                                    SLIDER.x, 
		                                                    SLIDER.y), 
		                                           umaDna.chinPosition, 
		                                           0.0f, 
		                                           1.0f);
		#endregion
		#region Cheek Position
		GUI.Label(new Rect(OFFSET, 
		                   (OFFSET * 3) + (WINDOW_LABEL.y * 20), 
		                   WINDOW_LABEL.x, 
		                   WINDOW_LABEL.y), 
		          "Cheek Position");

		umaDna.cheekPosition = GUI.HorizontalSlider(new Rect(SLIDERPOSX, 
		                                                     (OFFSET * 3.5f) + (SLIDER.y * 20), 
		                                                     SLIDER.x, 
		                                                     SLIDER.y), 
		                                            umaDna.cheekPosition, 
		                                            0.0f, 
		                                            1.0f);
		#endregion
		#region Low Cheek Position
		GUI.Label(new Rect(OFFSET, 
		                   (OFFSET * 3) + (WINDOW_LABEL.y * 21), 
		                   WINDOW_LABEL.x, 
		                   WINDOW_LABEL.y), 
		          "Low Cheek Position");

		umaDna.lowCheekPosition = GUI.HorizontalSlider(new Rect(SLIDERPOSX, 
		                                                        (OFFSET * 3.5f) + (SLIDER.y * 21), 
		                                                        SLIDER.x, 
		                                                        SLIDER.y), 
		                                               umaDna.lowCheekPosition, 
		                                               0.0f, 
		                                               1.0f);
		#endregion
		#region Low Check Size
		GUI.Label(new Rect(OFFSET, 
		                   (OFFSET * 3) + (WINDOW_LABEL.y * 22), 
		                   WINDOW_LABEL.x, 
		                   WINDOW_LABEL.y), 
		          "Low Cheek Size");

		umaDna.lowCheekPronounced = GUI.HorizontalSlider(new Rect(SLIDERPOSX, 
		                                                          (OFFSET * 3.5f) + (SLIDER.y * 22), 
		                                                          SLIDER.x, 
		                                                          SLIDER.y), 
		                                                 umaDna.lowCheekPronounced, 
		                                                 0.0f, 
		                                                 1.0f);
		#endregion

		GUI.EndGroup();											//End the face controls group
	}
#endregion
	//This method contains the GUI information for the Body Window (the window that contains the controls to manipulate
	//	the body bones of our character mesh)
#region DrawBodyWindow Method
	public void DrawBodyWindow()
	{
        GUI.BeginGroup(new Rect(OFFSET,
                                 OFFSET,
                                 BODY_WINDOW.x,
                                 200));
        if (GUI.Button(new Rect(OFFSET, OFFSET, 80, 20), "Body 1"))
        {
            umaCrowd.body = 1;
            umaData.isMeshDirty = true;
            umaData.isTextureDirty = true;
            umaCrowd.DefineSlots();
        }

        if (GUI.Button(new Rect(OFFSET + 100, OFFSET, 80, 20), "Body 2"))
        {
            umaCrowd.body = 2;
            umaData.isMeshDirty = true;
            umaData.isTextureDirty = true;
            umaCrowd.DefineSlots();
        }

        if (GUI.Button(new Rect(OFFSET + 200, OFFSET, 80, 20), "Body 3"))
        {
            umaCrowd.body = 3;
            umaData.isMeshDirty = true;
            umaData.isTextureDirty = true;
            umaCrowd.DefineSlots();
        }

 


        GUI.EndGroup();

		GUI.BeginGroup(new Rect (OFFSET, 
		                         OFFSET + 80, 
		                         BODY_WINDOW.x, 
		                         BODY_WINDOW.y+ 40));				//Begin the group to hold our body controls

		GUI.Box(new Rect(0, 
		                 OFFSET, 
		                 BODY_WINDOW.x - (OFFSET * 2), 
		                 BODY_WINDOW.y - (OFFSET * 3) + 20), "");	//Draw the window to hold the body controls

		//Body Controls
		#region Height
		GUI.Label(new Rect(OFFSET, 
		                   OFFSET * 3, 
		                   WINDOW_LABEL.x, 
		                   WINDOW_LABEL.y), 
		          "Height");

		umaDna.height = GUI.HorizontalSlider(new Rect(SLIDERPOSX, 
		                                              (OFFSET * 3.5f), 
		                                              SLIDER.x, 
		                                              SLIDER.y), 
		                                     umaDna.height, 
		                                     0.4f, 
		                                     0.7f); 
		#endregion
		#region Leg Spread
		GUI.Label(new Rect(OFFSET, 
		                   (OFFSET * 3) + WINDOW_LABEL.y, 
		                   WINDOW_LABEL.x, 
		                   WINDOW_LABEL.y), 
		          "Leg Spread");

		umaDna.legSeparation = GUI.HorizontalSlider(new Rect(SLIDERPOSX, 
		                                                     (OFFSET * 3.5f) + SLIDER.y, 
		                                                     SLIDER.x, 
		                                                     SLIDER.y), 
		                                            umaDna.legSeparation,
		                                            0.4f, 
		                                            0.7f); 
		#endregion
		#region Upper Muscle
		GUI.Label(new Rect(OFFSET, 
		                   (OFFSET * 3) + (WINDOW_LABEL.y * 2), 
		                   WINDOW_LABEL.x, 
		                   WINDOW_LABEL.y), 
		          "Upper Muscle");

		umaDna.upperMuscle = GUI.HorizontalSlider(new Rect(SLIDERPOSX, 
		                                                   (OFFSET * 3.5f) + (SLIDER.y * 2), 
		                                                   SLIDER.x, 
		                                                   SLIDER.y), 
		                                          umaDna.upperMuscle, 
		                                          0.4f, 
		                                          0.7f); 
		#endregion
		#region Lower Muscle
		GUI.Label(new Rect(OFFSET, 
		                   (OFFSET * 3) + (WINDOW_LABEL.y * 3), 
		                   WINDOW_LABEL.x, 
		                   WINDOW_LABEL.y), 
		          "Lower Muscle");

		umaDna.lowerMuscle = GUI.HorizontalSlider(new Rect(SLIDERPOSX, 
		                                                   (OFFSET * 3.5f) + (SLIDER.y * 3), 
		                                                   SLIDER.x, 
		                                                   SLIDER.y), 
		                                          umaDna.lowerMuscle, 
		                                          0.4f, 
		                                          0.7f); 
		#endregion
		#region Upper Weight
		GUI.Label(new Rect(OFFSET, 
		                   (OFFSET * 3) + (WINDOW_LABEL.y * 4), 
		                   WINDOW_LABEL.x, 
		                   WINDOW_LABEL.y), 
		          "Upper Weight");

		umaDna.upperWeight = GUI.HorizontalSlider(new Rect(SLIDERPOSX, 
		                                                   (OFFSET * 3.5f) + (SLIDER.y * 4), 
		                                                   SLIDER.x, 
		                                                   SLIDER.y), 
		                                          umaDna.upperWeight, 
		                                          0.4f, 
		                                          0.7f); 
		#endregion
		#region Lower Weight
		GUI.Label(new Rect(OFFSET, 
		                   (OFFSET * 3) + (WINDOW_LABEL.y * 5), 
		                   WINDOW_LABEL.x,
		                   WINDOW_LABEL.y), 
		          "Lower Weight");

		umaDna.lowerWeight = GUI.HorizontalSlider(new Rect(SLIDERPOSX, 
		                                                   (OFFSET * 3.5f) + (SLIDER.y * 5), 
		                                                   SLIDER.x, 
		                                                   SLIDER.y), 
		                                          umaDna.lowerWeight, 
		                                          0.4f, 
		                                          0.7f); 
		#endregion
		#region Leg Size
		GUI.Label(new Rect(OFFSET, 
		                   (OFFSET * 3) + (WINDOW_LABEL.y * 6), 
		                   WINDOW_LABEL.x, 
		                   WINDOW_LABEL.y), 
		          "Leg Size");

		umaDna.legsSize = GUI.HorizontalSlider(new Rect(SLIDERPOSX, 
		                                                (OFFSET * 3.5f) + (SLIDER.y * 6), 
		                                                SLIDER.x, 
		                                                SLIDER.y), 
		                                       umaDna.legsSize, 
		                                       0.4f, 
		                                       0.7f); 
		#endregion
		#region Arm Width
		GUI.Label(new Rect(OFFSET, 
		                   (OFFSET * 3) + (WINDOW_LABEL.y * 7), 
		                   WINDOW_LABEL.x, 
		                   WINDOW_LABEL.y), 
		          "Arm Width");

		umaDna.armWidth = GUI.HorizontalSlider(new Rect(SLIDERPOSX, 
		                                                (OFFSET * 3.5f) + (SLIDER.y * 7), 
		                                                SLIDER.x, 
		                                                SLIDER.y), 
		                                       umaDna.armWidth, 
		                                       0.4f, 
		                                       0.7f); 
		#endregion
		#region Arm Length
		GUI.Label(new Rect(OFFSET, 
		                   (OFFSET * 3) + (WINDOW_LABEL.y * 8), 
		                   WINDOW_LABEL.x, 
		                   WINDOW_LABEL.y), 
		          "Arm Length");

		umaDna.armLength = GUI.HorizontalSlider(new Rect(SLIDERPOSX, 
		                                                 (OFFSET * 3.5f) + (SLIDER.y * 8), 
		                                                 SLIDER.x, 
		                                                 SLIDER.y), 
		                                        umaDna.armLength, 
		                                        0.4f, 
		                                        0.7f); 
		#endregion
		#region Breast Size
		GUI.Label(new Rect(OFFSET, 
		                   (OFFSET * 3) + (WINDOW_LABEL.y * 9), 
		                   WINDOW_LABEL.x, 
		                   WINDOW_LABEL.y), 
		          "Breast Size");

		umaDna.breastSize = GUI.HorizontalSlider(new Rect(SLIDERPOSX, 
		                                                  (OFFSET * 3.5f) + (SLIDER.y * 9), 
		                                                  SLIDER.x, 
		                                                  SLIDER.y), 
		                                         umaDna.breastSize, 
		                                         0.4f, 
		                                         0.7f); 
		#endregion
		#region Waist
		GUI.Label(new Rect(OFFSET, 
		                   (OFFSET * 3) + (WINDOW_LABEL.y * 10), 
		                   WINDOW_LABEL.x, 
		                   WINDOW_LABEL.y), 
		          "Waist");

		umaDna.waist = GUI.HorizontalSlider(new Rect(SLIDERPOSX, 
		                                             (OFFSET * 3.5f) + (SLIDER.y * 10), 
		                                             SLIDER.x, 
		                                             SLIDER.y), 
		                                    umaDna.waist, 
		                                    0.4f, 
		                                    0.7f); 
		#endregion
		#region Belly
		GUI.Label(new Rect(OFFSET, 
		                   (OFFSET * 3) + (WINDOW_LABEL.y * 11), 
		                   WINDOW_LABEL.x, 
		                   WINDOW_LABEL.y), 
		          "Belly");

		umaDna.belly = GUI.HorizontalSlider(new Rect(SLIDERPOSX, 
		                                             (OFFSET * 3.5f) + (SLIDER.y * 11), 
		                                             SLIDER.x, 
		                                             SLIDER.y), 
		                                    umaDna.belly, 
		                                    0.4f, 
		                                    0.7f); 
		#endregion
		#region Butt Size
		GUI.Label(new Rect(OFFSET, 
		                   (OFFSET * 3) + (WINDOW_LABEL.y * 12), 
		                   WINDOW_LABEL.x, 
		                   WINDOW_LABEL.y), 
		          "Butt Size");

		umaDna.gluteusSize = GUI.HorizontalSlider(new Rect(SLIDERPOSX, 
		                                                   (OFFSET * 3.5f) + (SLIDER.y * 12), 
		                                                   SLIDER.x, 
		                                                   SLIDER.y), 
		                                          umaDna.gluteusSize, 
		                                          0.4f, 
		                                          0.7f); 
		#endregion
		#region Head Size
		GUI.Label(new Rect(OFFSET, 
		                   (OFFSET * 3) + (WINDOW_LABEL.y * 13), 
		                   WINDOW_LABEL.x, 
		                   WINDOW_LABEL.y), 
		          "Head Size");

		umaDna.headSize = GUI.HorizontalSlider(new Rect(SLIDERPOSX, 
		                                                (OFFSET * 3.5f) + (SLIDER.y * 13), 
		                                                SLIDER.x, 
		                                                SLIDER.y), 
		                                       umaDna.headSize, 
		                                       0.4f, 
		                                       0.7f); 
		#endregion
		#region Head Width
		GUI.Label(new Rect(OFFSET, 
		                   (OFFSET * 3) + (WINDOW_LABEL.y * 14), 
		                   WINDOW_LABEL.x, 
		                   WINDOW_LABEL.y), 
		          "Head Width");

		umaDna.headWidth = GUI.HorizontalSlider(new Rect(SLIDERPOSX, 
		                                                 (OFFSET * 3.5f) + (SLIDER.y * 14), 
		                                                 SLIDER.x, 
		                                                 SLIDER.y), 
		                                        umaDna.headWidth, 
		                                        0.4f, 
		                                        0.7f); 
		#endregion
		#region Neck Thickness
		GUI.Label(new Rect(OFFSET, 
		                   (OFFSET * 3) + (WINDOW_LABEL.y * 15), 
		                   WINDOW_LABEL.x, 
		                   WINDOW_LABEL.y), 
		          "Neck Thickness");

		umaDna.neckThickness = GUI.HorizontalSlider(new Rect(SLIDERPOSX, 
		                                                     (OFFSET * 3.5f) + (SLIDER.y * 15), 
		                                                     SLIDER.x, 
		                                                     SLIDER.y), 
		                                            umaDna.neckThickness, 
		                                            0.4f, 
		                                            0.7f); 
		#endregion
		#region Forearm Length
		GUI.Label(new Rect(OFFSET, 
		                   (OFFSET * 3) + (WINDOW_LABEL.y * 16), 
		                   WINDOW_LABEL.x, 
		                   WINDOW_LABEL.y), 
		          "Forearm Length");

		umaDna.forearmLength = GUI.HorizontalSlider(new Rect(SLIDERPOSX, 
		                                                     (OFFSET * 3.5f) + (SLIDER.y * 16), 
		                                                     SLIDER.x, 
		                                                     SLIDER.y), 
		                                            umaDna.forearmLength, 
		                                            0.4f, 
		                                            0.7f); 
		#endregion
		#region Forearm Width
		GUI.Label(new Rect(OFFSET, 
		                   (OFFSET * 3) + (WINDOW_LABEL.y * 17), 
		                   WINDOW_LABEL.x, 
		                   WINDOW_LABEL.y), 
		          "Forearm Width");

		umaDna.forearmWidth = GUI.HorizontalSlider(new Rect(SLIDERPOSX, 
		                                                    (OFFSET * 3.5f) + (SLIDER.y * 17), 
		                                                    SLIDER.x, 
		                                                    SLIDER.y), 
		                                           umaDna.forearmWidth, 
		                                           0.4f, 
		                                           0.7f);

        
		#endregion

        

        

		GUI.EndGroup();											//End body control group
	}
#endregion

#region Start Method
	void Start () 
	{
		//Define the x, y dimensions of the control box (The box to hold the buttons that select which editor window 
		//	we need to open.
		CONTROL_BOX = new Vector2((OFFSET * 5) + (BUTTON.x * 4),
		                          (OFFSET * 4) + BUTTON.y);

		//Define the dimensions of the body window
		BODY_WINDOW = new Vector2(CONTROL_BOX.x, 
		                         (OFFSET * 6) + (LABEL.y * 18));

		//Define the dimensions of the face window
		FACE_WINDOW = new Vector2(CONTROL_BOX.x + 200, 
		                         (OFFSET * 12) + (LABEL.y * 23));

        HAIR_WINDOW = new Vector2(CONTROL_BOX.x,
                                   (OFFSET * 2) + (BUTTON.y * 2));

        _hairwindow = new Rect(OFFSET,
                               (OFFSET * 7) + CONTROL_BOX.y,
                               FACE_WINDOW.x,
                               FACE_WINDOW.y);

		//Define the face window rect
		_facewindow = new Rect(OFFSET, 
		                       (OFFSET * 7) + CONTROL_BOX.y, 
		                       FACE_WINDOW.x, 
		                       FACE_WINDOW.y + 60);

		//Define the body window rect
		_bodywindow = new Rect(OFFSET, 
		                       (OFFSET * 2) + CONTROL_BOX.y, 
		                       BODY_WINDOW.x, 
		                       BODY_WINDOW.y + 180);

        _clotheswindow = new Rect(OFFSET,
                               (OFFSET * 7) + CONTROL_BOX.y,
                               FACE_WINDOW.x,
                               FACE_WINDOW.y);

		//Define the dimensions of the window label
		WINDOW_LABEL = new Vector2(BODY_WINDOW.x * .37f, 
		                           LABEL.y);

		//Define the dimensions of the slider
		SLIDER = new Vector2(BODY_WINDOW.x - (WINDOW_LABEL.x + (OFFSET * 6)), 
		                     LABEL.y);

		//Define the slider's X position
		SLIDERPOSX = (OFFSET * 3) + WINDOW_LABEL.x;

		//Create a link to our database
		SqliteConnection myConnect = new SqliteConnection("URI=file:./Assets/Database/SchismMasterDB.s3db");
		
		//Reference our datbase connection
		db = new SchismDB.MonoStrict(myConnect);
		
		//Query our database to create an array of our base attributes
		characterQuery = (from p in db.Character orderby p.CharacterID ascending select p).ToArray();

		//Fill our arrays with default values
		characterName = new string[]{"", "", "", "", "", ""};
		gender = new string[]{"", "", "", "", "", ""};
		male = new bool[]{true, true, true, true, true, true};
		female = new bool[]{false, false, false, false, false, false};
		saved = new bool[]{false, false, false, false, false, false};
        created = new bool[] {false, false, false, false, false, false};
	}
#endregion

#region Update Method
	void Update () 
	{
		//We need to grab the currently generated character and assign it to our variable
		myUMACharacter = GameObject.Find ("Generated Character");

		//If we have a generated character, we need to grab its UMA Data and fire off the AvatarSetup method
		if(generateCharacter == true)
		{
			umaData = umaCrowd.gameObject.GetComponentInChildren<UMAData>();
			AvatarSetup();
		}

		//If we have a UMA Data object, fire off the UpdateUMAShape method
		if(umaData)
		{
			UpdateUMAShape();
            
		}


	}
#endregion

    


	//In the GUI we create character boxes for each of the six characters with a name field to enter the character 
	//	names, gender toggles to select the gender of each character, a button to create a random character, and button
	//	to save the current character.  We also creat a control box that holds the buttons which allow us to select
	//	which character editor window we need to open.
	void OnGUI()
	{
		//The x, y dimensions for our character box.
		Vector2 CHARACTERBOX = new Vector2((Screen.width / 6) - ((Screen.width * .005f) * 1.25f), 
		                                    Screen.height * .14f);


		//The dimensions of our portrait box (The box that will hold a snapshot of our character's head)
		Vector2 PORTRAIT_BOX = new Vector2(CHARACTERBOX.y - (OFFSET * 4), 
		                                           CHARACTERBOX.y - (OFFSET * 2));

		//The dimensions of our text field to enter the character name
		Vector2 NAME_FIELD = new Vector2(CHARACTERBOX.x * .4f, 
		                                 CHARACTERBOX.y * .2f);

		GUI.skin = guiSkin;		//Assign our GUIskin

		for(int i = 0; i < 6; i++)
		{
			//This is our character box group
			GUI.BeginGroup(new Rect(OFFSET + (OFFSET * i) + (CHARACTERBOX.x * i), 
			                        Screen.height - (OFFSET + CHARACTERBOX.y), 
			                        CHARACTERBOX.x + OFFSET, 
			                        CHARACTERBOX.y + OFFSET));
			//Draw the actual character box
			GUI.Box(new Rect(0, 
			                 0, 
			                 CHARACTERBOX.x, 
			                 CHARACTERBOX.y), "Character " + (i + 1));

			//Draw the box to hold the character portrait
			GUI.Box (new Rect(OFFSET, 
			                  OFFSET, 
			                  PORTRAIT_BOX.x, 
			                  PORTRAIT_BOX.y), "");

			//Draw the "Name" label
			GUI.Label(new Rect((OFFSET * 2) + PORTRAIT_BOX.x,
			                   OFFSET * 3,
			                   BUTTON.x,
			                   BUTTON.y), "Name:");

			//Draw the text field that assign our character name and assign it
			characterName[i] = GUI.TextField(new Rect((OFFSET * 3) + PORTRAIT_BOX.x + LABEL.x,
			                		      OFFSET * 3,
			                 		      NAME_FIELD.x,
			                 		      NAME_FIELD.y), characterName[i]);

			//The Male toggle
			male[i] = GUI.Toggle(new Rect((OFFSET * 2)+ PORTRAIT_BOX.x,
			                              (OFFSET * 4) + NAME_FIELD.y,
			                              TOGGLE.x,
			                              TOGGLE.y), male[i], "Male");
			
			//If you select Male, we make sure female is not selected and assign our gender as Male
			if(male[i])
			{
				female[i] = false;
				gender[i] = "M";
                maleOptions = true;
			}
			
			//The Female toggle
			female[i] = GUI.Toggle(new Rect((OFFSET * 4) + PORTRAIT_BOX.x + TOGGLE.x,
			                                (OFFSET * 4) + NAME_FIELD.y,
			                                TOGGLE.x,
			                                TOGGLE.y), female[i], "Female");
			
			//If we select Female, we make sure Male is not selected and assign our gender as Female.
			if(female[i])
			{
				male[i] = false;
				gender[i] = "F";
                maleOptions = false;
			}

			if(!saved[i])    //Only show the Create and Save buttons if we have not already saved this character
			{
				//Draw the "Customize" button
				if(GUI.Button(new Rect((OFFSET * 2) + PORTRAIT_BOX.x,
				                       (OFFSET * 8) + NAME_FIELD.y,
				                       BUTTON.x,
				                       BUTTON.y), "Create"))
				{
					//If we click this button, detroy the currently generated character and generate a new one
					Destroy(myUMACharacter);
                    created[i] = true;
					umaCrowd.generateUMA = true;
					generateCharacter = true;

					if(gender[i] == "M")
					{
						UMARace = "Male";
					}
					if(gender[i] == "F")
					{
						UMARace = "Female";
					}
				}

                if (created[i] && characterName[i] != null && characterName[i] != "")
                {
                    //Draw the "Save" button
                    if (GUI.Button(new Rect((OFFSET * 3) + PORTRAIT_BOX.x + BUTTON.x,
                                           (OFFSET * 8) + NAME_FIELD.y,
                                           BUTTON.x,
                                           BUTTON.y), "Save"))
                    {
                        Save(gender[i], characterName[i], i);
                        saved[i] = true;
                    }
                }

				
			}

			GUI.EndGroup();
		}

		GUI.BeginGroup(new Rect(OFFSET, OFFSET, CONTROL_BOX.x, CONTROL_BOX.y));

		GUI.Box(new Rect (0, 0, CONTROL_BOX.x, CONTROL_BOX.y), "Customization Controls");

		if(GUI.Button(new Rect (OFFSET, (OFFSET * 3), BUTTON.x, BUTTON.y), "Body"))
		{
            whichWindow = 1;

		}
		if(GUI.Button (new Rect ((OFFSET * 2) + BUTTON.x, (OFFSET * 3), BUTTON.x, BUTTON.y), "Face"))
		{
            whichWindow = 2;
		}

        if (GUI.Button(new Rect((OFFSET * 3) + (BUTTON.x * 2), (OFFSET * 3), BUTTON.x, BUTTON.y), "Hair"))
        {
            whichWindow = 3;
        }



		if(GUI.Button (new Rect ((OFFSET * 4) + (BUTTON.x * 3), (OFFSET * 3), BUTTON.x, BUTTON.y), "Clothes"))
        {
            whichWindow = 4;
        }
		if(whichWindow == 1)
		{
			_bodywindow = GUI.Window (1, _bodywindow, WindowFunction, "Body Controls");
		}
		else if(whichWindow == 2)
		{
			_facewindow = GUI.Window (2, _facewindow, WindowFunction, "Face Controls");
		}

        else if (whichWindow == 3)
        {
            _hairwindow = GUI.Window(3, _hairwindow, WindowFunction, "Hair Controls");
        }
        else if (whichWindow == 4)
        {
            _clotheswindow = GUI.Window(4, _clotheswindow, WindowFunction, "Clothes Controls");
        }

		GUI.EndGroup();

		GUI.BeginGroup (new Rect(Screen.width * .75f, Screen.height * .2f, Screen.width * .21f, Screen.height * .21f));
		GUI.Box (new Rect(Screen.width * .7f, Screen.height * .1f, Screen.width * .2f, Screen.height * .2f), "");
		GUI.TextArea(new Rect(10, 10, (Screen.width * .2f) - 20, (Screen.height * .2f) - 20), "Right click an area of the model to focus on that area. \n \nUse the scroll wheel to zoom. \n \nClick the middle mouse button to orbit the camera.");
		GUI.EndGroup();

        if (characterCount == 6)
        {
            if (GUI.Button(new Rect(Screen.width * .9f, Screen.height * .7f, 100, 25), "Continue"))
            {
                SchismDB.CharacterGroup characterGroup = new SchismDB.CharacterGroup();
                int? lastID = (from p in db.CharacterGroup orderby p.CharacterGroupID descending select p.CharacterGroupID).FirstOrDefault();
                
                if (lastID.HasValue)
                {
                    characterGroupID = lastID.Value +1;
                }
                else
                {
                    characterGroupID = 1;
                }

                characterGroup.CharacterGroupID = characterGroupID;
                characterGroup.Character1id = character[0].CharacterID;
                characterGroup.Character2id = character[1].CharacterID;
                characterGroup.Character3id = character[2].CharacterID;
                characterGroup.Character4id = character[3].CharacterID;
                characterGroup.Character5id = character[4].CharacterID;
                characterGroup.Character6id = character[5].CharacterID;

                db.CharacterGroup.InsertOnSubmit(characterGroup);
                db.SubmitChanges();
                PartyManager.Instance._persistentGroup = characterGroupID;
                Application.LoadLevel("SchismCharacterCreation2");
            }
        }

	}

	public void AvatarSetup()
	{
		umaDynamicAvatar = umaData.gameObject.GetComponent<UMADynamicAvatar>();
		umaDna = umaData.umaRecipe.GetDna<UMADnaHumanoid>();
	}
	
	public void UpdateUMAShape()
	{
		umaData.isShapeDirty = true;
        
		umaData.Dirty();
	}

	//This is where we handle the organization of our windows based upon their windowID
	public void WindowFunction(int windowID)
	{
		if(windowID == 1)
		{
			DrawBodyWindow();		//Draw the body window
		}
		if(windowID == 2)
		{
			DrawFaceWindow();		//Draw the face window
		}
        if (windowID == 3)
        {
            DrawHairWindow();
        }
        if (windowID == 4)
        {
            DrawClothesWindow();
        }
	}

	void Save(string gender, string characterName, int i)
	{
		var avatar = umaData.gameObject.GetComponent<UMAAvatarBase>();
		if( avatar != null )
		{
			var asset = ScriptableObject.CreateInstance<UMATextRecipe>();
			asset.Save(avatar.umaData.umaRecipe, avatar.context);
			SaveFile = asset.recipeString;
            characterCount++;
            SchismDB.Character newCharacter = new SchismDB.Character();	//Create an object to be inserted into the Character Table
            newCharacter.CharacterName = characterName;					//Assign the character Name
            newCharacter.CharacterGender = gender;						//Assign the character gender
            newCharacter.UmA = SaveFile;
            
            db.Character.InsertOnSubmit(newCharacter);					//Prepare the object for insertion into the database


            PartyManager.Instance._persistentCharacter[i] = characterName;
            db.SubmitChanges();											//Submit to the Database

            character[i] = newCharacter; 
			
			ScriptableObject.Destroy(asset);
		}
	}
}
