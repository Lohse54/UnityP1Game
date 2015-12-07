using UnityEngine;
using System.Collections;

public class MainMenuControl : MonoBehaviour {

	//Main Menu Control
	
	public void goToSubMenu() {
		Application.LoadLevel ("SubMenu");
	}

	public void exit() {
		Application.Quit ();
	}
}
