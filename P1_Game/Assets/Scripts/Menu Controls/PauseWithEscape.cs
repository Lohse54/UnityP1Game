using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PauseWithEscape : MonoBehaviour {

	private GameObject pauseMenu;
	private GameObject playerMovement;

	void Awake() {
		playerMovement = GameObject.FindWithTag ("Player");
		pauseMenu = GameObject.Find ("Pause Menu");//Be sure to change when needed in real code
		pauseMenu.SetActive (false);
		playerMovement.SetActive (true);
	}

	public void PauseMenu() {
		pauseMenu.SetActive (true);
		Time.timeScale = 0f;
		playerMovement.SetActive (false);
	}


	public void resumeGame() {
		Time.timeScale = 1f;
		pauseMenu.SetActive (false);
		playerMovement.SetActive (true);
	}

	public void backToMenu() {
		Time.timeScale = 1f;
		Application.LoadLevel ("MainMenu");
	}
}