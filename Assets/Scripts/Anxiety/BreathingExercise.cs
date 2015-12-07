using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class BreathingExercise : MonoBehaviour {

	public static Image circleSlider;
	public static GameObject circleBreating;

	void Awake() {

		circleSlider.fillAmount = 0f;
		circleBreating = GameObject.FindWithTag ("Breathing");
		circleBreating.SetActive (false);
	}

	public static void breathing() {
		Time.timeScale = 0f;
		waitingForCircle ();
		circleBreating.SetActive (true);
		circleSlider.fillAmount += 0.3f;
		if (circleSlider.fillAmount >= 1f) {
			waitingForCircle ();
			circleSlider.fillAmount -= 0.25f;
			if (circleSlider.fillAmount <=0f) {
				circleSlider.fillAmount = 0f;
			}
		}
		waitingForCircle ();
		circleBreating.SetActive (false);
	}

	void OnCollisionEnter2D (Collision2D target){
		if (target.gameObject.tag == "Bonus Coin") {
			Destroy (target.gameObject);
		} 
	}

	public static IEnumerator waitingForCircle() {
		yield return new WaitForSeconds (3f);
	}
}
