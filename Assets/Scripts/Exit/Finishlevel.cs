using UnityEngine;
using System.Collections;

public class Finishlevel : MonoBehaviour {


	void OnTriggerEnter2D (Collider2D target){
		if (target.tag == "Player" && PlayerControl.sanity <= 3) {
		
			Application.LoadLevel(Application.loadedLevelName); 
		}
	}
}
