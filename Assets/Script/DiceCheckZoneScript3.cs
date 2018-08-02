using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceCheckZoneScript3 : MonoBehaviour {

	Vector3 diceVelocity;

	// Update is called once per frame
	void FixedUpdate () {
		diceVelocity = DiceScript3.diceVelocity;
	}

	void OnTriggerStay(Collider col)
	{
		if (diceVelocity.x == 0f && diceVelocity.y == 0f && diceVelocity.z == 0f)
		{
            switch (col.gameObject.name) {
			case "C1side":
					DiceNumberTextScript.dice3Number = 6;
					GameControl.diceSide3Thrown = 6;
					break;
			case "C2side":
					DiceNumberTextScript.dice3Number = 5;
					GameControl.diceSide3Thrown = 5;
					break;
			case "C3side":
					DiceNumberTextScript.dice3Number = 4;
					GameControl.diceSide3Thrown = 4;
					break;
			case "C4side":
					DiceNumberTextScript.dice3Number = 3;
					GameControl.diceSide3Thrown = 3;
					break;
			case "C5side":
					DiceNumberTextScript.dice3Number = 2;
					GameControl.diceSide3Thrown = 2;
					break;
			case "C6side":
					DiceNumberTextScript.dice3Number = 1;
					GameControl.diceSide3Thrown = 1;
					break;
			}
		}
	}
}

