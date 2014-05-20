using UnityEngine;
using System.Collections;

public class CombatMove : MonoBehaviour
{
	public bool combatMove = false;				//Are we in Combat Move Mode?
	public GameObject MoveRing;					//This is our MoveRing prefab
	//public GameObject[] avatars;				//We need an array to reference whichever Avatar is currently in turn
	private GameObject moveRing;				//Reference the Move Ring we instantiated from the prefab
	public bool ringInPlace = false;			//Condition to control when the ring moves
	public Vector3 lockThisPosition;			//The position we want the Avatar to move to when we click
	public float speed = 6f;					//The speed we want the Avatar to move 
    public float animationspeed = 1f;
    private bool IsMoving = false;
    private float PreviousDistance = 0f;
	public GameObject whosTurn;
	//public Collider eCollider;
	private LayerMask layerMask = 1 << 8;
	public float dist;
	public CombatModeManager combatModeManager;
	//public bool moveComplete;
	//public bool weAreMoving = false;
    public UMA.UMAData myUMAData;

    public GameObject handSlot;
    public GameObject myGun;

	//Listen for messages from our other objects
	private void OnEnable()
	{
		Messenger<bool>.AddListener("combat move", OnCombatMove);		//Combat Mode Manager will let us know when we enter Combat Move Mode
		Messenger<GameObject>.AddListener("whos turn", OnWhosTurn);

		//Because we turn this script on only when we are in Move mode, it is best to instantiate our Move Ring in the
		//	OnEnable Unity Event.  This way, each time we go to Move mode, a new ring is instantiated for us.
		moveRing = Instantiate(MoveRing, new Vector3 (whosTurn.transform.position.x, .72f, whosTurn.transform.position.z), Quaternion.identity)as GameObject;	

		//We have to reset this so that when we come back to move mode in the future 
		//  we don't try to move to the position set in the last Move event.
		lockThisPosition = Vector3.zero;		

	}

    void Start()
    {
       
        
        handSlot.transform.position = myUMAData.animator.GetBoneTransform(HumanBodyBones.RightHand).position;
        myGun.transform.position = handSlot.transform.position;
    }

	//In our Update method we need to actually make the Move Ring move relative to our mouse cursor and once our 
	//	position is set, move the Avatar to that position.
	void Update () 
	{

       

		if (combatMove)				//We don't want the Move Ring to move until we are certain we are in Move mode.
		{
         
			MoveTheRing();			//Call our method to actually create the ring movement
		}

		if (ringInPlace)			//We don't want to move the Avatar until we have clicked our move position
		{
            myUMAData = GameObject.Find(whosTurn.name).GetComponentInChildren<UMA.UMAData>();
			MoveTheAvatar();		//Call the method that moves the Avatar to the clicked position
		}

	}

	//Convert the Combat Move message value into our own variable
	public void OnCombatMove(bool combatMove)
	{
		this.combatMove = combatMove;
	}

	//It is good practice to make sure listeners are removed if this object is ever disabled
	private void OnDisable()
	{
		Messenger<bool>.RemoveListener("combat move", OnCombatMove);
		Messenger<GameObject>.RemoveListener("whos turn", OnWhosTurn);

		//Make sure out Move Ring dissapears when we change modes.  Because we turn this
		//	scipt off when we go to a new mode, we can use the OnDisable Unity Event
		Destroy(moveRing);				
	}

	//Our Method for moving the Move Ring	
	public void MoveTheRing()
	{

		if (!ringInPlace)
		{
			//Fire a ray from the main camera to the point in world space our mouse cursor is at.  This is how we take the
			//	2D mouse data and translate it into 3D world space.
			Ray currentMousePosition = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit = new RaycastHit();
			Vector3 moveToPosition = Vector3.zero;
			
			
			//If our ray is contacting something in the world.
			//We use a layerMask so our hit data only registers the floor
			if (Physics.Raycast(currentMousePosition, out hit, 100f, layerMask))
			{
				//Turn that point into a vector
				moveToPosition = new Vector3(hit.point.x, 0.6f, hit.point.z);
				
				//Move the Cursor to the ray hit vector
				moveRing.transform.position = moveToPosition; 
				
			}
		}
		//When we press the mouse button, we want the Move Ring to stop moving and we lock its current position into
		//	a vector so we can move our Avatar to it.
		if (Input.GetMouseButtonDown(0))		
			
		{
			ringInPlace = true;			//This should nullify our move the ring condition and make it stop moving

			//We record the position of the Move Ring where we clicked it
			lockThisPosition = new Vector3(moveRing.transform.position.x, 1.8f, moveRing.transform.position.z);

		}
	}

	//Our Method for moving the Avatar to the clicked position simply Lerps him from his current position to the clicked position.
	public void MoveTheAvatar()
	{
		var movePos = new Vector3(lockThisPosition.x, whosTurn.transform.position.y, lockThisPosition.z);

        var myAvatar = whosTurn.GetComponentInChildren<Rigidbody>();
        
        var distance = Vector3.Distance(myAvatar.transform.position, movePos);
        
      
        if(IsMoving == false)
        { 
            var lookPos = new Vector3(lockThisPosition.x, myAvatar.transform.position.y, lockThisPosition.z);
            iTween.LookUpdate(myAvatar.gameObject, lookPos, .1f);
            myUMAData.animator.speed =speed;

        }
        if (distance > .26f)
        {

			dist = Vector3.Distance(whosTurn.transform.position, lockThisPosition);
            if (PreviousDistance > distance - 1)
            {
                myUMAData.animator.SetFloat("Speed", animationspeed);
                myAvatar.transform.position = Vector3.Lerp(myAvatar.transform.position, movePos, speed * Time.deltaTime);  //
               
            }
            else
            {
                Debug.Log("Correcting Movement: " + distance.ToString());
                var lookPos = new Vector3(lockThisPosition.x, myAvatar.transform.position.y, lockThisPosition.z);
                myUMAData.animator.Play("Idle");
                iTween.LookUpdate(myAvatar.gameObject, lookPos, .1f);
                myAvatar.transform.position = Vector3.Lerp(myAvatar.transform.position, movePos, speed * Time.deltaTime);  //
            }
            
            IsMoving = true;

            PreviousDistance = distance;

		}
		else 
        
		{
			IsMoving = false;
            myUMAData.animator.Play("Idle");
            Debug.Log("Destination reached");
			combatMove = false;
			whosTurn.GetComponent<AvatarClass>().actionPoints --;
			Messenger<string>.Broadcast("avatar moved", whosTurn.name.ToString());
			combatModeManager.currentAction = CombatModeManager.CombatActions.deciding;
		}


	}

	public void OnWhosTurn(GameObject whosTurn)
	{
		this.whosTurn = whosTurn;
	}
}
