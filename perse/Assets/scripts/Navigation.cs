using UnityEngine;
using System.Collections;

public class Navigation : MonoBehaviour {
	NavMeshAgent agent;
	public GameObject player;
	
	void Start () {
		player = GameObject.Find ("Player");
		agent = GetComponent<NavMeshAgent> ();
	}
	

	void Update () {
		agent.SetDestination (player.transform.position);
	}
}
