using UnityEngine;
using System.Collections;

public class MovementContraller : MonoBehaviour {

	public Vector2 movement = new Vector2();



	// Use this for initialization
	

	// Update is called once per frame
	void Update () {
		movement.x = movement.y = 0f;

		if(Input.GetKey("right") || Input.GetKey("d")){
			movement.x = 1f;
			
		}else if(Input.GetKey("left") || Input.GetKey("a")){
			movement.x = -1f;
		}

		if(Input.GetKey("up") || Input.GetKey("w")){
			movement.y = 1f;

		}else if(Input.GetKey("down") || Input.GetKey("s")){
			movement.y = -1f;
		}
	}
}
