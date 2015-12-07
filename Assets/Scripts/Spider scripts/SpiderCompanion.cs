using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class SpiderCompanion : MonoBehaviour {

	private Rigidbody2D myBody;
	
	public float speed = 0.9f;
	// Use this for initialization
	void Awake () {
		myBody = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {
		myBody.velocity = new Vector2(transform.localRotation.x, 0) * speed;
	}
}
