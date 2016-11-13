﻿using UnityEngine;
using System.Collections;

public class RobotJump : MonoBehaviour {

	public float jumpVelocity = 15;
	bool isRobotJumping = false;
	bool isRobotDoubleJumping = false;
	Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		rb = this.transform.parent.GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			if (!isRobotJumping||!isRobotDoubleJumping) {
				rb.velocity = new Vector3 (0, jumpVelocity, 0);
				if (isRobotJumping) {
					isRobotDoubleJumping = true;
				}
				isRobotJumping = true;
			}
		}
	
	}

	void OnCollisionEnter2D(Collision2D coll)
	{
		isRobotJumping = false;
		isRobotDoubleJumping = false;
	}
}