using UnityEngine;
using System.Collections;

//[RequireComponent (typeof (AudioSource))]
public class Enemy : Entity {

	public float expOnDeath;
	private Player player;

	private GameGUI gui;
	 
	void Start() {
		player = GameObject.FindGameObjectWithTag ("Player").GetComponent<Player> ();
		gui = GameObject.FindGameObjectWithTag ("GUI").GetComponent<GameGUI> ();
	}

	void Update(){


		 /*if (level == 4f) {
			slurps.text = ("You killed all enemies, \n good job!");
		} else {
			slurps.text = ("");
		} */

		/*	if (health <= 0) {
		
			GetComponent<AudioSource>().Play();
		}*/
	

	}


	
	public override void Die ()
	{
		//	GetComponent<AudioSource>().Play();
		player.AddExperience (expOnDeath);
		base.Die ();
	}
}