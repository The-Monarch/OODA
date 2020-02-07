﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

	public Transform target;
	public float smoothing;
	public Vector3 maxPosition;
	public Vector3 minPosition;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void LateUpdate () {  //30 time a second vs 60 time a second
		if (transform.position != target.position)
		{
			Vector3 targetPosition = new Vector3 (target.position.x, 
				                         		  target.position.y,
				                         		  transform.position.z);

			targetPosition.x = Mathf.Clamp (targetPosition.x,
											minPosition.x,
											maxPosition.x);
			targetPosition.y = Mathf.Clamp (targetPosition.y,
											minPosition.y,
											maxPosition.y);

			transform.position = Vector3.Lerp (transform.position,
											   targetPosition, smoothing);
		}
	}
}
