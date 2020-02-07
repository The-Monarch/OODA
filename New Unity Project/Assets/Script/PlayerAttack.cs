using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour {

	/*private bool attacking = false;

	private float attackTimer = 0;
	private float attackCd = 0.1f;

	public Collider2D attackTrigger;*/
	public GameObject bullet;

	float nextFire;
	float fireRate;

	// Use this for initialization
	void Start () {
		fireRate = 0.1f;
		nextFire = Time.time;
		//attackTrigger.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("l")) {
			if (Time.time > nextFire) {
				Instantiate (bullet, transform.position, Quaternion.identity);
				nextFire = Time.time + fireRate;
			}
		}
		/*if (Input.GetKeyDown ("l") && !attacking) {
			Debug.Log("The button is pressed");
			attacking = true;
			attackTimer = attackCd;

			attackTrigger.enabled = true;
		}
		if (attacking==true) {
			Debug.Log("The player is attacking");
			if (attackTimer > 0) {
				attackTimer -= Time.deltaTime;
				Debug.Log (attackTimer);
			}else {
				Debug.Log ("The player is not attacking");
				attackTrigger.enabled = false;
				attacking = false;
			}
		}*/
	}
}

