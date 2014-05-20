using UnityEngine;
using System.Collections;

public class CombatRanged : MonoBehaviour 
{
	public bool rangedAttack;							//This is our ranged attack condition

	public GameObject avatarGroup;						//This is a reference to our avatar group
	public GameObject target;							//This is our target variable
	public GameObject whosTurn;							//This is our whos turn variable
	public CombatModeManager combatModeManager;			//This is a reference to our Cambat Mode Manager class
	//public LayerMask layerMask;							//This is a layermask we create for our reticle

	public Transform hand;
	private Transform muzzle;
	private string enemyHit;

	void OnEnable()
	{
		Messenger<bool>.AddListener("ranged attack", OnRangedAttack);		//Listen for our ranged attack message
		Messenger<GameObject>.AddListener("whos turn", OnWhosTurn);			//Listen for our whos turn message

		//hand = myUMA.transform.Find("RightHand");

	}

	//As long as we are in the ranged attack event, we want to be able to acquire targets
	void Update () 
	{
		if (rangedAttack)
		{
			acquireTarget();		//Call the method to acquire a target
		}

		

	}

	//This is our acquire target method
	void acquireTarget()
	{

        var myAvatar = whosTurn.GetComponentInChildren<Rigidbody>();

		//Fire a ray from the main camera to the point in world space our mouse cursor is at.  This is how we take the
		//	2D mouse data and translate it into 3D world space.
		Ray currentMousePosition = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit = new RaycastHit();
		Vector3 hitVector = Vector3.zero;

		//If our ray is contacting something in the world.
		//We use a layerMask so our hit data only registers the floor and enemies
		if (Physics.Raycast(currentMousePosition, out hit, 500f))
		{
			//Turn that point into a vector
			hitVector = new Vector3(hit.point.x, hit.point.y, hit.point.z);

            GameObject myGun = GameObject.Find("Gun" + whosTurn.name.Replace("Avatar", ""));



			var laser = gameObject.GetComponent<LineRenderer>();
			//laser.SetPosition(0, muzzle.position);
			laser.SetPosition(0, new Vector3(myGun.transform.position.x, myGun.transform.position.y, myGun.transform.position.z));
			laser.SetPosition(1, hitVector);

			laser.SetWidth(.05f, .05f);

			var lookPos = new Vector3(hit.point.x, myAvatar.transform.position.y, hit.point.z);

			myAvatar.transform.LookAt(lookPos);



			if (Input.GetMouseButtonDown(0))			//If we press the mouse button...
			{
				if(hit.transform.tag == "Enemy")		//..and if the raycast is hitting an enemy...
				{
					target = hit.transform.gameObject;	//...assign the hit point as our target

					target.GetComponent<EnemyClass>().hitPoints--;			//Subtract one from target enemies HP
					//Send our message for the console
					Messenger<string, string>.Broadcast("enemy hit", whosTurn.name.ToString(), target.name.ToString());
					whosTurn.GetComponent<AvatarClass>().actionPoints--;	//Subract one from current avatars turn action points

					//Now go back into the deciding event (this action is complete)
					combatModeManager.currentAction = CombatModeManager.CombatActions.deciding;	

					laser.SetPosition(0, Vector3.zero);
					laser.SetPosition(1, Vector3.zero);
					Messenger<bool>.Broadcast("ranged attack", false);
				}
			}
		}
	}

	//Take the data from our ranged attack message and assign it to a local variable
	void OnRangedAttack(bool rangedAttack)
	{
		this.rangedAttack = rangedAttack;
	}

	//Take the data from our whos turn message and assign it to our local variable
	public void OnWhosTurn(GameObject whosTurn)
	{
		this.whosTurn = whosTurn;
	}

	//When we disable this script, remove our listeners and destroy the reticle
	void OnDisable()
	{
		rangedAttack = false;
		Messenger<bool>.RemoveListener("ranged attack", OnRangedAttack);
		Messenger<GameObject>.RemoveListener("whos turn", OnWhosTurn);

	}
}
