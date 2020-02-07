using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PlayerState{ //Three states
	walk,
	attack,
	interact
}

public class PlayerMovement : MonoBehaviour {

	/*Rigidbody2D body;
	float horizontal;
	float vertical;
	float moveLimiter = 0.7f;
	public float runSpeed = 20; 

	void Start ()
	{
		body = GetComponent<Rigidbody2D>();
	}

	void Update()
	{
		horizontal = Input.GetAxisRaw("Horizontal");
		vertical = Input.GetAxisRaw("Vertical"); 
	}

	void FixedUpdate ()
	{ 
		if(horizontal != 0 && vertical != 0) // Check for diagonal movement
			body.velocity = new Vector2((horizontal * runSpeed) * moveLimiter , (vertical * runSpeed) * moveLimiter); // move at less speed 
		else // if not moving diagonally
			body.velocity = new Vector2(horizontal * runSpeed, vertical * runSpeed); // move at normal speed
	}*/

	public PlayerState currentState;
	public float speed;
	private Rigidbody2D myRB;
	private Vector3 change;
	/*public Sprite playerDown;
	public Sprite playerUp;
	public Sprite playerLeft;
	public Sprite playerRight;*/

	void Start(){
		currentState = PlayerState.walk;
		myRB = GetComponent<Rigidbody2D> ();
		//sprites = Resources.LoadAll<Sprite>("Untitled3");
	}

	void Update(){
		change = Vector3.zero;
		change.x = Input.GetAxisRaw ("Horizontal");
		change.y = Input.GetAxisRaw ("Vertical");
		/*if (change.x < 0) {this.gameObject.GetComponent<SpriteRenderer> ().sprite = playerLeft;}
		if (change.x > 0) {this.gameObject.GetComponent<SpriteRenderer> ().sprite = playerRight;}
		if (change.y < 0) {this.gameObject.GetComponent<SpriteRenderer> ().sprite = playerDown;}
		if (change.y > 0) {this.gameObject.GetComponent<SpriteRenderer> ().sprite = playerUp;}*/
		/*if (Input.GetButtonDown ("attack") && currentState != PlayerState.attack) {
			StartCoroutine (AttackCo ());
		}*/

		if (change != Vector3.zero) {
			Movement ();
		}
	}

	void Movement()
	{
		change.Normalize ();
		myRB.MovePosition (
			transform.position + change * speed * Time.deltaTime
		); // Move a small amount each frame.
	}
}
