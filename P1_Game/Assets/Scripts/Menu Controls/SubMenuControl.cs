using UnityEngine;
using System.Collections;

public class SubMenuControl : MonoBehaviour {

	// Sub Menu Controller

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
}
