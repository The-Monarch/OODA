using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollision : MonoBehaviour
{
	float moveSpeed = 7.0f;

	Rigidbody2D rb;

	//Player_Health player;
	public GameObject target;
	Vector2 moveDirection;

	void Start()
	{
		rb = GetComponent<Rigidbody2D>();
		target = GameObject.FindGameObjectWithTag("Enemy");
		moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
		rb.velocity = new Vector2(moveDirection.x, moveDirection.y);
		Destroy(gameObject, 3.0f);
		//player = GameObject.FindObjectOfType<Player_Health>();
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Enemy")
		{
			//player.health -= 1;
			Destroy(gameObject);
		}
	}
}
