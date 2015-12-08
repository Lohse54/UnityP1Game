using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PlayerControl : MonoBehaviour {

	public float speed = 10f;
	public float maxVelocityX = 3f;
	public float maxVelocityY = 5f;

	private bool grounded;
	public float flySpeed = 15f;
	public float airSpeed = .3f;

	private Rigidbody2D myBody;
	private Animator animator;
	private MovementContraller movementController;
	public static int sanity = 0;
	public int score;
	public Text countText;
	public Text scoreText;
	


	// Use this for initialization


	void Awake(){ 
		SetCountText ();
		SetScoreText ();
		myBody = GetComponent<Rigidbody2D> ();
		animator = GetComponent<Animator> ();
		movementController = GetComponent<MovementContraller> ();
	}


	// Update is called once per frame
	void Update () {



		var forceX = 0f;
		var forceY = 0f;

		var absX = Mathf.Abs (myBody.velocity.x);
		var absY = Mathf.Abs (myBody.velocity.y);

		if (absY < 0f) {

			grounded = true;
		} else {

			grounded = false;
		}


		if (movementController.movement.x != 0) {

			if (absX < maxVelocityX) {

				if(grounded){
					forceX = speed * movementController.movement.x;

				}else{
					forceX = speed * movementController.movement.x*airSpeed;
				}
			}

			if(forceX > 0){
				transform.localScale = new Vector3(0.26f,0.21f,0.26f);
			}else if(forceX < 0){
				transform.localScale = new Vector3(-0.26f,0.21f,0.26f);
			}

			animator.SetInteger ("State", 1);


		} else {

			animator.SetInteger ("State", 0);
		}

		if (movementController.movement.y != 0) {
			
			if(absY<maxVelocityY){
				forceY = flySpeed * movementController.movement.y;
				animator.SetInteger ("State", 0);
			}
			
		}

		myBody.AddForce (new Vector2 (forceX, forceY));

	}


	void OnCollisionEnter2D (Collision2D target){
		if (target.gameObject.tag == "Coins") {
			Destroy (target.gameObject);
			score = score + 1;
			SetScoreText();
		}
		if (target.gameObject.tag == "Spikes") {
			Destroy(target.gameObject);
			sanity = sanity + 1;
			SetCountText();
			}
		if (target.gameObject.tag == "Bonus Coin") {
            BreathingExercise.sliderDirection = 0;
			Destroy (target.gameObject);
			sanity = sanity - 5;
			score = score + 5;
			SetCountText();
			SetScoreText();
		}
	} 

	public void SetCountText() {
		countText.text = "" + sanity;
	}

	public void SetScoreText() {
		scoreText.text = "Score: " + score;
	}
	}
	

