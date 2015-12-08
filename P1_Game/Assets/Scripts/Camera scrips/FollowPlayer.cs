using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {


	private GameObject player;
	private Transform trans;

	// Use this for initialization

	void Awake (){
		player = GameObject.Find ("Finish---Runing-Animation 1");
		trans = player.transform;
	}


	
	// Update is called once per frame
	void Update () {
		if (trans != null) {
		
			transform.position = new Vector3(trans.position.x,0,transform.position.z);
		
		}

	
	}
}
