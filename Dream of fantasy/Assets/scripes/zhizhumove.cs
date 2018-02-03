using UnityEngine;
using System.Collections;
public class zhizhumove : MonoBehaviour
{
	public GameObject key;
	UnityEngine.AI.NavMeshAgent nav;
	void start ()
	{
		//GameObject	key = GameObject.Find ("ey");
		nav = GetComponent <UnityEngine.AI.NavMeshAgent> ();
	}
	void Fixedupdate ()
		{
		nav.SetDestination (key.transform.position);
			//nav.enabled = false;
		
	}
}
