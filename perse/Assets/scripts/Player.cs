using UnityEngine;
using System.Collections;

public class Player : Entity {

	private int level;
	private float currentLevelExperience;
	private float experienceToLevel;
	public TextMesh winner, slurps;
	public LayerMask enemies;


	private GameGUI gui;

	void Start() {

		//Enemy = GameObject.FindGameObjectsWithTag ("Enemy").GetComponent<Enemy> ();
		gui = GameObject.FindGameObjectWithTag ("GUI").GetComponent<GameGUI> ();
		LevelUp ();
	}


	void Update(){
		if (level == 4f) {
			winner.text = ("You killed all enemies, \n good job!");
		} else {
			winner.text = ("");
		}

		Collider[] hitColliders = Physics.OverlapSphere(transform.position, 1, enemies);
		int i = 0;
		while (i < hitColliders.Length) {

			i++;
		}

		if (hitColliders.Length > 0) {
			slurps.text = "Eat shit and die!";

			if(!GetComponent<AudioSource>().isPlaying)
				GetComponent<AudioSource>().Play();
		} else {
			slurps.text = "";

			if(GetComponent<AudioSource>().isPlaying)
				GetComponent<AudioSource>().Stop();
		}
	}
	
	public void AddExperience (float exp) {
		currentLevelExperience += exp;
		if (currentLevelExperience >= experienceToLevel){
			currentLevelExperience -= experienceToLevel;
			LevelUp();
		}
		gui.SetPlayerExperience (currentLevelExperience / experienceToLevel, level);
	}



	private void LevelUp() {
		level++;
		experienceToLevel = level * 50 + Mathf.Pow (level * 2, 2);
		AddExperience (0);

	
	}

}
