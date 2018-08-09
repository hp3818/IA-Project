using UnityEngine;

public class DiceCheckZoneScript2 : MonoBehaviour {

	Vector3 diceVelocity;

	// Update is called once per frame
	void FixedUpdate () {
		diceVelocity = DiceScript2.diceVelocity;
	}

	void OnTriggerStay(Collider col)
	{
		if (diceVelocity.x == 0f && diceVelocity.y == 0f && diceVelocity.z == 0f)
		{
            switch (col.gameObject.name) {
			case "B1side":
				    DiceNumberTextScript.dice2Number = 6;
                    GameControl.diceSide2Thrown = 6;
                    break;
			case "B2side":
				    DiceNumberTextScript.dice2Number = 5;
                    GameControl.diceSide2Thrown = 5;
                    break;
			case "B3side":
				    DiceNumberTextScript.dice2Number = 4;
                    GameControl.diceSide2Thrown = 4;
                    break;
			case "B4side":
				    DiceNumberTextScript.dice2Number = 3;
                    GameControl.diceSide2Thrown = 3;
                    break;
			case "B5side":
				    DiceNumberTextScript.dice2Number = 2;
                    GameControl.diceSide2Thrown = 2;
                    break;
			case "B6side":
				    DiceNumberTextScript.dice2Number = 1;
                    GameControl.diceSide2Thrown = 1;
                    break;
			}
		}
	}
}

