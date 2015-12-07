using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Anxietymeter : MonoBehaviour {



	private Slider slider;
	public float level = 10f;

	// Use this for initialization
	void Awake () {
		GetReferences ();
	}
	
	// Update is called once per frame
	void Update () {
		slider.value = PlayerControl.sanity;

	}

	void GetReferences (){
		slider = GameObject.Find ("Slider").GetComponent<Slider> ();

		slider.minValue = 0f;
		slider.maxValue = level;


	}



}
