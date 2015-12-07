using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PauseWithEscape : MonoBehaviour {

	private GameObject pauseMenu;

	void Awake() {
		pauseMenu = GameObject.Find ("Pause Menu");//Be sure to change when needed in real code
		pauseMenu.SetActive (false);
	}

	public void PauseMenu() {
		pauseMenu.SetActive (true);
		Time.timeScale = 0f;
	}


	public void resumeGame() {
		Time.timeScale = 1f;
		pauseMenu.SetActive (false);
	}

	public void backToMenu() {
		Time.timeScale = 1f;
		Application.LoadLevel ("MainMenu");
	}
}
