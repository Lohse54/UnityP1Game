using UnityEngine;
using System.Collections;

public class SubMenuLevelsControl : MonoBehaviour {

	// Sub Menu Levels Control

	public void goToLevels () {
		Application.LoadLevel ("SubMenuLevels");
	}
	
	public void goToMainMenu() {
		Application.LoadLevel ("MainMenu");
	}
	
	public void goToInfo() {
		Application.LoadLevel ("SubMenuInfo");
	}
	
	public void goToHelp() {
		Application.LoadLevel ("SubMenuHelp");
	}

	public void goToDarkLevel() {
		Application.LoadLevel ("Level_dark");
	}

	public void goToAloneLevel() {
		Application.LoadLevel ("Level_alone");
	}

	public void goToKidnappingLevel() {
		Application.LoadLevel ("Level_kidnapping");
	}
}
