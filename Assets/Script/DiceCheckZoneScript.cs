using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceCheckZoneScript : MonoBehaviour {

	Vector3 diceVelocity;

	// Update is called once per frame
	void FixedUpdate () {
		diceVelocity = DiceScript.diceVelocity;
	}

	void OnTriggerStay(Collider col)
	{
		if (diceVelocity.x == 0f && diceVelocity.y == 0f && diceVelocity.z == 0f)
		{
			switch (col.gameObject.name) {
			case "A1side":
                    DiceNumberTextScript.dice1Number = 6;
                    GameControl.diceSide1Thrown = 6;
                    break;
			case "A2side":
                    DiceNumberTextScript.dice1Number = 5;
                    GameControl.diceSide1Thrown = 5;
                    break;
			case "A3side":
                    DiceNumberTextScript.dice1Number = 4;
                    GameControl.diceSide1Thrown = 4;
                    break;
			case "A4side":
                    DiceNumberTextScript.dice1Number = 3;
                    GameControl.diceSide1Thrown = 3;
                    break;
			case "A5side":
				    DiceNumberTextScript.dice1Number = 2;
                    GameControl.diceSide1Thrown = 2;
                    break;
			case "A6side":
                    DiceNumberTextScript.dice1Number = 1;
                    GameControl.diceSide1Thrown = 1;
                    break;
			}
		}
	}
}
