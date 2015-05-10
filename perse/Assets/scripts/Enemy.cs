using UnityEngine;
using System.Collections;

[RequireComponent (typeof (AudioSource))]
public class Enemy : Entity {

	public float expOnDeath;
	private Player player;

	void Start() {
		player = GameObject.FindGameObjectWithTag ("Player").GetComponent<Player> ();
	}

	/*void Update(){
		if (health <= 0) {
		
			GetComponent<AudioSource>().Play();
		}
	
	
	}*/


	public override void Die ()
	{
		GetComponent<AudioSource>().Play();
		player.AddExperience (expOnDeath);
		base.Die ();
	}
}