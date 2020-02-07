using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomMoveOut : MonoBehaviour {

	public Vector3 cameraChange;
	public Vector3 playerChange;
	private CameraMovement cam;

	// Use this for initialization
	void Start () {
		cam = Camera.main.GetComponent<CameraMovement> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter2D(Collider2D col)
	{
		if (col.CompareTag ("Player")) {
			Debug.Log ("hit");
			cam.minPosition += cameraChange;
			cam.maxPosition += cameraChange;
			col.transform.position += playerChange;
		}
	}
}
