using UnityEngine;
using System.Collections;

public class GameModeManager : MonoBehaviour 
{

	public string mode = "Explore";					//This stores our current Mode: "Explore" (default) or "Combat"
	public bool combatStarted = false;				//This is a condition to determine if we have transitioned into combat mode already or not
	public bool exploreStarted = false;				//This is a condition to determine if we have transitioned into explore mode already or not

	public CombatModeManager combatModeManager;		//This is a reference to our CombatModeManager class so we can turn it on and off as needed.
	public CombatMove combatMove;					//This is a reference to our CombatMove class so we can turn it on and off as needed.
	public GameObject whosTurn;						//This is a reference to the current gameobject in our turnqueue.

	private GameObject avatarGroup;					//Reference the avatarGroup so we can access its various camera control scripts.
	public Camera cam;								//Reference to our main Camera.
	public GameObject cameraCombatPosition;		//The position we want the main camera to be in while in combat mode.
	public GameObject cameraCombatLookat;			//The object we want the camera to look at while in combat mode.
	public GameObject cameraExplorePosition;		//The position we want the main camera to be in while in explore mode.
	public GameObject cameraExploreLookat;			//The object we want the camera to look at while in explore mode.

	private float camSpeed = 15f;					//The speed we want to camera to move durring mode transitions
	public bool modeStartUp = false;				//This is condition to determine if we need to transition into a mode or not.
	private GameObject[] avatars;					//Array of Avatars used for docking purposes
	//private float dockSpeed = 4f;					//The speed we want the avatars to move when we dock them.

	public Transform avatarPad1;
	public Transform avatarPad2;
	public Transform avatarPad3;
	public Transform avatarPad4;
	public Transform avatarPad5;
	public Transform avatarPad6;

	public Transform avatar1;
	public Transform avatar2;
	public Transform avatar3;
	public Transform avatar4;
	public Transform avatar5;
	public Transform avatar6;


	//Add any listeners we need for this class
	void OnEnable()
	{
		Messenger<GameObject>.AddListener("whos turn", OnWhosTurn);		//Listen for the message to tell us the gameobject in current position of turn queue
	}
	
	void Start()
	{
		//cam = Camera.main;														//Assign cam to main camera
		avatarGroup = GameObject.Find("GroupController");							//Assign our Avatargroup

		//Assign the camera positions and look ats
		//cameraCombatPosition = GameObject.Find("Camera Combat Position");	
		//cameraCombatLookat = GameObject.Find("Camera Combat Look At");			
		//cameraExplorePosition = GameObject.Find("Camera Explore Position");		
		//cameraExploreLookat = GameObject.Find("Camera Explore Look At");			
	}
	
	void Update () 
	{
		//When we press the space key we switch between Combat and Explore Modes.
		//However, we also have to transition from one mode to the other.
		//The logic is self-explainatory
		if (Input.GetKeyDown(KeyCode.Space))
		{
			mode = ModeChange(mode);
			modeStartUp = true;
		}
		
		if (mode == "Combat")
		{
			if (modeStartUp == true)
			{
				startCombat();
				Debug.Log("Starting Combat");
			}
			else 
			{
				Debug.Log ("Doing Combat");
				doCombat();
			}
		}
		
		if (mode == "Explore")
		{
			if (modeStartUp == true)
			{
				Debug.Log("Starting Explore");
				startExplore();
			}
			else 
			{
				Debug.Log("do explore");
				doExplore();
			}
		}
	}

	//Methos to handle the combat mode transition
	void startCombat()
	{
		MoveCameraToCombatPosition();
	}

	//Method to handle combat
	public void doCombat()
	{
		//First we change the camera controller scripts around
		cam.GetComponent<MouseLook>().enabled = false;						//Turn off mouselook script on main camera
		cam.GetComponent<MouseOrbitImproved>().enabled = true;				//Turn on MouseOrbitImproved script on main camera
		cam.GetComponent<MouseOrbitImproved>().target = whosTurn;			//Assign the MouseOrbitImproved script to the gameobject in the current position of turn queue

		//Then we turn off the character controller scripts
		avatarGroup.GetComponent<MouseLook>().enabled = false;				//Turn off MouseLook
		avatarGroup.GetComponent<FirstPerson>().enabled = false;			//Turn off FirsPerson

		combatModeManager.GetComponent<CombatModeManager>().enabled = true;		//Turn the CombatModeManager on
		combatMove.GetComponent<CombatMove>().enabled = true;					//Turn CombatMove on.  Note:  I wanted to do this in CombatModeManager but it was buggy.		

		Messenger<bool>.Broadcast("in combat", true);							//Broadcast the in combat message to related classes
	}

	//Method to handle the explore mode transition
	public void startExplore()
	{
		//First change the camera controller scripts around.
		cam.GetComponent<MouseLook>().enabled = true;
		cam.GetComponent<MouseOrbitImproved>().enabled = false;
		cam.GetComponent<MouseOrbitImproved>().target = null;
		MoveCameraToExplorePosition();
	}

	//Method to handle explore mode
	public void doExplore()
	{


		//Then turn our character controller scripts back on
		avatarGroup.GetComponent<MouseLook>().enabled = true;
		avatarGroup.GetComponent<FirstPerson>().enabled = true;

		combatModeManager.GetComponent<CombatModeManager>().enabled = false;	//Turn CombatModeManager off
		combatMove.GetComponent<CombatMove>().enabled = false;					//Turn CombatMove off

		DockAvatars();			//Call our method to dock the avatars back to their respective pads.

		Messenger<bool>.Broadcast("in combat", false);							//Broadcast the message to let related classes know we are not in combat
	}

	//This Method takes in our current Mode and returns the new Mode.
	//I admit this is a complicated way to do this but I was practicing creating methods with parameters and return values.
	public string ModeChange (string mode)
	{
		if (mode == "Explore")
		{	
			return "Combat";
		}
		
		if (mode == "Combat")
		{
			Debug.Log ("explore");
			return "Explore";
		}
		
		else
			return "Explore";
	}

	//Coroutine to handle our transition into Combat Mode.
	//This might be ok as a regular Method, but I was experimenting with Coroutines.
	void MoveCameraToCombatPosition()
	{
		//These are the layers we want to see in Combat Mode.
		cam.camera.cullingMask |= 1 << LayerMask.NameToLayer("Default");
		cam.camera.cullingMask |= 1 << LayerMask.NameToLayer("Avatar");
		//cam.camera.cullingMask &= ~(1 << LayerMask.NameToLayer("ceiling"));
		//cam.camera.cullingMask &= ~(1 << LayerMask.NameToLayer("Radar"));

		//A temp variable to track the distanec between the 2 camera positions
		//We do this because conditional Lerping works better if the conditions are not definate
		float distanceC = Vector3.Distance(cam.transform.position, cameraCombatPosition.transform.position);

		//Move the Camera to combat position.
		if (distanceC > .1f)
		{
			cam.transform.position = Vector3.Lerp (cam.transform.position, cameraCombatPosition.transform.position, camSpeed * Time.deltaTime);
			cam.transform.LookAt(cameraCombatLookat.transform);
		}

		//Once the cameras get close enough, go ahead and end the mode transition
		if (distanceC <= .1f)
		{
			modeStartUp = false;
		}


	}
	
	//This coroutine moves the camera into explore position and turns on the culling masks for the layers we need to render in Explore Mode.
	void MoveCameraToExplorePosition()
	{

		Debug.Log ("moving camera");
		//A temp variable to track the distanec between the 2 camera positions
		//We do this because conditional Lerping works better if the conditions are not definate
		float distanceE = Vector3.Distance(cam.transform.position, cameraExplorePosition.transform.position);

		//Move the Camera to Explore Position.
		if (cam.transform.position != cameraExplorePosition.transform.position)
		{
			cam.transform.position = Vector3.Lerp (cam.transform.position, cameraExplorePosition.transform.position, camSpeed * Time.deltaTime);
			cam.transform.LookAt(cameraExploreLookat.transform);
			//cam.transform.position = cameraExplorePosition.transform.position;
			Debug.Log("Camera is moving now");
		}
		else if (cam.transform.position == cameraExplorePosition.transform.position)
		{
			modeStartUp = false;
		}
		//These are the layers we want to hide in Explore Mode.
		cam.camera.cullingMask |= 1 << LayerMask.NameToLayer("Default");
		cam.camera.cullingMask &= ~(1 << LayerMask.NameToLayer("Avatar"));
		//cam.camera.cullingMask |= 1 << LayerMask.NameToLayer("ceiling");

		//Once the cameras get close enough, go ahead and end the mode transition



	}
	
	//This is our method to Dock the Avatars when Combat Mode ends and Explore Mode begins.
	public void DockAvatars()
	{
		avatar1.position = avatarPad1.position;
		avatar2.position = avatarPad2.position;
		avatar3.position = avatarPad3.position;
		avatar4.position = avatarPad4.position;
		avatar5.position = avatarPad5.position;
		avatar6.position = avatarPad6.position;
	}

	//Assign the gameobject from the whosTurn message to our local variable.
	public void OnWhosTurn(GameObject whosTurn)
	{
		this.whosTurn = whosTurn;
	}

	//As always, remove all listeners when the script is disabled.
	void OnDisable()
	{
		Messenger<GameObject>.RemoveListener("whos turn", OnWhosTurn);
	}
}
