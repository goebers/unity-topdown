using UnityEngine;
using System.Collections;

public class GameGUI : MonoBehaviour {

	public Transform experienceBar;
	public TextMesh levelText;

	public void SetPlayerExperience(float percentToLevel, int playerLevel){
		levelText.text = "Taso; " + playerLevel;
		experienceBar.localScale = new Vector3 (percentToLevel, 1, 1);
	}
}
