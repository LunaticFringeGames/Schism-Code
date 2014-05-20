using UnityEngine;
using System.Collections;

public class CombatMelee : MonoBehaviour 
{
	public bool meleeAttack = false;
	public GameObject whosTurn;
	public float minMeleeDistance;
	public CombatModeManager combatModeManager;


	void OnEnable()
	{
		Messenger<bool>.AddListener("melee attack", OnMeleeAttack);		//Listen for our ranged attack message
		Messenger<GameObject>.AddListener("whos turn", OnWhosTurn);			//Listen for our whos turn message
	}

	void Update()
	{
		if(meleeAttack)
		{
			DoMeleeAttack();
		}
	}

	void DoMeleeAttack()
	{
		//Fire a ray from the main camera to the point in world space our mouse cursor is at.  This is how we take the
		//	2D mouse data and translate it into 3D world space.
		Ray currentMousePosition = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit = new RaycastHit();
		Vector3 hitVector = Vector3.zero;

		if (Physics.Raycast(currentMousePosition, out hit, 500f))
		{

			if(hit.transform.tag == "Enemy")
			{
				var lookPos = new Vector3(hit.point.x, whosTurn.transform.position.y, hit.point.z);
				whosTurn.transform.LookAt(lookPos);

				var target = hit.transform.gameObject;	//...assign the hit point as our target
				var dist = Vector3.Distance(whosTurn.transform.position, hit.transform.position);
				if (dist <= minMeleeDistance)
				{
					//target.transform.renderer.material.color = Color.yellow;
					if(Input.GetMouseButtonDown(0))
					{

						//target.transform.renderer.material.color = Color.red;
						target.GetComponent<EnemyClass>().hitPoints--;
						whosTurn.GetComponent<AvatarClass>().actionPoints--;	//Subract one from current avatars turn action points
						Messenger<string, string>.Broadcast("enemy hit", whosTurn.name.ToString(), target.name.ToString());
						combatModeManager.currentAction = CombatModeManager.CombatActions.deciding;	

					}
				}
				else
				{
					meleeAttack = false;
				}
			}
		}
	}

	void OnMeleeAttack(bool meleeAttack)
	{
		this.meleeAttack = meleeAttack;
	}

	//Take the data from our whos turn message and assign it to our local variable
	public void OnWhosTurn(GameObject whosTurn)
	{
		this.whosTurn = whosTurn;
	}

	void OnDisable()
	{
		meleeAttack = false;
		Messenger<bool>.RemoveListener("melee attack", OnMeleeAttack);
		Messenger<GameObject>.RemoveListener("whos turn", OnWhosTurn);
	}

}
