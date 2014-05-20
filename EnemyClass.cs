using UnityEngine;
using System.Collections;

public class EnemyClass : MonoBehaviour 
{
	public int initiativeScore;
	public int hitPoints;

	public AudioClip boom;
	void Start()
	{

	}

	void Update () 
	{
		if (hitPoints <=0 )
		{
			Messenger<string>.Broadcast("enemy dead", this.gameObject.name.ToString());
			StartCoroutine (KillEnemy());



		}


	}

	IEnumerator KillEnemy()
	{
		var detonator = gameObject.GetComponent<Detonator>();

		detonator.Explode();
		audio.PlayOneShot(boom);


		yield return new WaitForSeconds(5);

		Destroy(this.gameObject);

		yield return 0;
	}
}
