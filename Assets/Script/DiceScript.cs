﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceScript : MonoBehaviour {

	static Rigidbody rb;
	public static Vector3 diceVelocity;
    public static int Vaild = 0;

	void Start () {
		rb = GetComponent<Rigidbody> ();
    }

	void Update () {
		diceVelocity = rb.velocity;

		if (Vaild > 0) {
			DiceNumberTextScript.dice1Number = 0;
			float dirX = Random.Range (0, 500);
			float dirY = Random.Range (0, 500);
			float dirZ = Random.Range (0, 500);
			transform.position = new Vector3 (0, 4, 0);
			transform.rotation = Quaternion.identity;
			rb.AddForce (transform.up * 500);
			rb.AddTorque (dirX, dirY, dirZ);
            oneDice.OneDice(); //
            Vaild = 0;
		}

    }
}
