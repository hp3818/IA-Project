using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FollowThePath : MonoBehaviour {

	public Transform[] waypoints;
    public int Movement = 0;
    public int Accept = 0;
	public static int whosTurn = 1;
	public static int numberOfChance;
    public Text chance;
    public GameObject ImageForChance;
    public static int Go = 0;

    public static int point0 = 1;
    public static int point12 = 0;

    [SerializeField]
    private float moveSpeed = 1f;

    public int wayPointIndex = 0;

    public bool moveAllowed = false;

    void Start()
    {
        transform.position = waypoints[wayPointIndex].transform.position;

        ImageForChance.gameObject.SetActive(false);
    }
    
    private void Update()
    {
        if (moveAllowed)
            Move();
    }

    private void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position, waypoints[wayPointIndex].transform.position, moveSpeed * Time.deltaTime);

        if (transform.position == waypoints[wayPointIndex].transform.position)
        {
            if (transform.position == waypoints[0].transform.position && point0 == 1) // Used for set the value movement in START
            {
                Movement = -1;
            }

            wayPointIndex += 1; // Wosition++

            Movement++; //  Walk++

            if (transform.position == waypoints[1].transform.position) 
            {
                Go = 1;
            }

            if (transform.position == waypoints[0].transform.position && Go == 1) 
            {
                if (whosTurn == 1)
                {
                    GameControl.Go1 = 1;
                }
                if (whosTurn == 2)
                {
                    GameControl.Go2 = 1;
                }
                if (whosTurn == 3)
                {
                    GameControl.Go3 = 1;
                }
                if (whosTurn == 4)
                {
                    GameControl.Go4 = 1;
                }
                if (whosTurn == 5)
                {
                    GameControl.Go5 = 1;
                }
                if (whosTurn == 6)
                {
                    GameControl.Go6 = 1;
                }
                if (whosTurn == 7)
                {
                    GameControl.Go7 = 1;
                }
                if (whosTurn == 8)
                {
                    GameControl.Go8 = 1;
                }
            }

            if (transform.position == waypoints[57].transform.position)
            {
                wayPointIndex = 0;
                if(whosTurn == 1)
                {
                    GameControl.player1Waypoint = 0;
                }
                if (whosTurn == 2)
                {
                    GameControl.player2Waypoint = 0;
                }
                if (whosTurn == 3)
                {
                    GameControl.player3Waypoint = 0;
                }
                if (whosTurn == 4)
                {
                    GameControl.player4Waypoint = 0;
                }
                if (whosTurn == 5)
                {
                    GameControl.player5Waypoint = 0;
                }
                if (whosTurn == 6)
                {
                    GameControl.player6Waypoint = 0;
                }
                if (whosTurn == 7)
                {
                    GameControl.player7Waypoint = 0;
                }
                if (whosTurn == 8)
                {
                    GameControl.player8Waypoint = 0;
                }

                Accept += Movement;
                Accept += 1;

            }  // Used for loop the map

			if (transform.position == waypoints [65].transform.position)
			{
                wayPointIndex = 35;
                Dice.boolean = 0;
				if(whosTurn == 1)
				{
					GameControl.player1Waypoint = 35;
				}
				else if (whosTurn == 2)
				{
					GameControl.player2Waypoint = 35;
				}
				else if (whosTurn == 3)
				{
					GameControl.player3Waypoint = 35;
				}
				else if (whosTurn == 4)
				{
					GameControl.player4Waypoint = 35;
				}
				else if (whosTurn == 5)
				{
					GameControl.player5Waypoint = 35;
				}
				else if (whosTurn == 6)
				{
					GameControl.player6Waypoint = 35;
				}
				else if (whosTurn == 7)
				{
					GameControl.player7Waypoint = 35;
				}
				else if (whosTurn == 8)
				{
					GameControl.player8Waypoint = 35;
				}

				Accept += Movement;
                Accept += 1;

			} // when it try to exit the luck road

			if (transform.position == waypoints[74].transform.position)
			{
                wayPointIndex = 6;
                Dice.boolean = 0;
                if (whosTurn == 1)
				{
					GameControl.player1Waypoint = 6;
				}
				else if (whosTurn == 2)
				{
					GameControl.player2Waypoint = 6;
				}
				else if (whosTurn == 3)
				{
					GameControl.player3Waypoint = 6;
				}
				else if (whosTurn == 4)
				{
					GameControl.player4Waypoint = 6;
				}
				else if (whosTurn == 5)
				{
					GameControl.player5Waypoint = 6;
				}
				else if (whosTurn == 6)
				{
					GameControl.player6Waypoint = 6;
				}
				else if (whosTurn == 7)
				{
					GameControl.player7Waypoint = 6;
				}
				else if (whosTurn == 8)
				{
					GameControl.player8Waypoint = 6;
				}

				Accept += Movement;
                Accept += 1;
            }  // when it try to exit the bad road                                                                                                            

            if ((transform.position == waypoints[12].transform.position) && (Movement == GameControl.diceSide1Thrown + GameControl.diceSide2Thrown + GameControl.diceSide3Thrown))
            {
                Dice.boolean = 1;
                transform.position = waypoints[18].transform.position;
                wayPointIndex = 18;

                if (whosTurn == 1)
                {
                    DiceNumberTextScript.whosTurn = 1;
                }
                else if (whosTurn == 2)
                {
                    DiceNumberTextScript.whosTurn = 2;
                }
                else if (whosTurn == 3)
                {
                    DiceNumberTextScript.whosTurn = 3;
                }
                else if (whosTurn == 4)
                {
                    DiceNumberTextScript.whosTurn = 4;
                }
                else if (whosTurn == 5)
                {
                    DiceNumberTextScript.whosTurn = 5;
                }
                else if (whosTurn == 6)
                {
                    DiceNumberTextScript.whosTurn = 6;
                }
                else if (whosTurn == 7)
                {
                    DiceNumberTextScript.whosTurn = 7;
                }
                else if (whosTurn == 8)
                {
                    DiceNumberTextScript.whosTurn = 8;
                }

            }  

			if ((transform.position == waypoints[53].transform.position) && (Movement == GameControl.diceSide1Thrown + GameControl.diceSide2Thrown + GameControl.diceSide3Thrown)) 
			{
                Dice.boolean = 1; 
                wayPointIndex = 66;

                if (whosTurn == 1)
                {
                    DiceNumberTextScript.whosTurn = 1;
                }
                else if (whosTurn == 2)
                {
                    DiceNumberTextScript.whosTurn = 2;
                }
                else if (whosTurn == 3)
                {
                    DiceNumberTextScript.whosTurn = 3;
                }
                else if (whosTurn == 4)
                {
                    DiceNumberTextScript.whosTurn = 4;
                }
                else if (whosTurn == 5)
                {
                    DiceNumberTextScript.whosTurn = 5;
                }
                else if (whosTurn == 6)
                {
                    DiceNumberTextScript.whosTurn = 6;
                }
                else if (whosTurn == 7)
                {
                    DiceNumberTextScript.whosTurn = 7;
                }
                else if (whosTurn == 8)
                {
                    DiceNumberTextScript.whosTurn = 8;
                }
            } 

            if ((transform.position == waypoints[18].transform.position) && (Movement == GameControl.diceSide1Thrown + GameControl.diceSide2Thrown + GameControl.diceSide3Thrown))
            {
                Dice.boolean = 1;
                wayPointIndex = 58;
                point12 = 1;

                if (whosTurn == 1)
                {
                    DiceNumberTextScript.whosTurn = 1;
                }
                else if (whosTurn == 2)
                {
                    DiceNumberTextScript.whosTurn = 2;
                }
                else if (whosTurn == 3)
                {
                    DiceNumberTextScript.whosTurn = 3;
                }
                else if (whosTurn == 4)
                {
                    DiceNumberTextScript.whosTurn = 4;
                }
                else if (whosTurn == 5)
                {
                    DiceNumberTextScript.whosTurn = 5;
                }
                else if (whosTurn == 6)
                {
                    DiceNumberTextScript.whosTurn = 6;
                }
                else if (whosTurn == 7)
                {
                    DiceNumberTextScript.whosTurn = 7;
                }
                else if (whosTurn == 8)
                {
                    DiceNumberTextScript.whosTurn = 8;
                }
            } 

            if (transform.position == waypoints [41].transform.position && Movement == (GameControl.diceSide1Thrown + GameControl.diceSide2Thrown + GameControl.diceSide3Thrown)) {
                transform.position = waypoints[0].transform.position;
                wayPointIndex = 0;
                if (whosTurn == 1)
                {
                    GameControl.player1Waypoint = 0;
                }
                if (whosTurn == 2)
                {
                    GameControl.player2Waypoint = 0;
                }
                if (whosTurn == 3)
                {
                    GameControl.player3Waypoint = 0;
                }
                if (whosTurn == 4)
                {
                    GameControl.player4Waypoint = 0;
                }
                if (whosTurn == 5)
                {
                    GameControl.player5Waypoint = 0;
                }
                if (whosTurn == 6)
                {
                    GameControl.player6Waypoint = 0;
                }
                if (whosTurn == 7)
                {
                    GameControl.player7Waypoint = 0;
                }
                if (whosTurn == 8)
                {
                    GameControl.player8Waypoint = 0;
                }
                Accept += Movement;
            } 

			if (transform.position == waypoints [25].transform.position && Movement == (GameControl.diceSide1Thrown + GameControl.diceSide2Thrown + GameControl.diceSide3Thrown) ||
				transform.position == waypoints [45].transform.position && Movement == (GameControl.diceSide1Thrown + GameControl.diceSide2Thrown + GameControl.diceSide3Thrown) ||
				transform.position == waypoints [54].transform.position && Movement == (GameControl.diceSide1Thrown + GameControl.diceSide2Thrown + GameControl.diceSide3Thrown)) {
				random ();
			}

        }

    }

    void random() {

		int getRangeNum = 0;
		int rangeRadomNum = 0;


		do {
			rangeRadomNum = Random.Range (1, 3);				// 1, 6
		} while (getRangeNum == rangeRadomNum);

		getRangeNum = rangeRadomNum;

		numberOfChance = 4;

		switch (numberOfChance) {
		case 1:
                chance.text = "你被陷害入獄了";
                StartCoroutine(TemporarilyDeactivate(2));
                goToJail();
                break;
		case 2:
                chance.text = "災難之地";
                StartCoroutine(TemporarilyDeactivate(2));
                goToBadLuckyRoad();
                break;
		case 3:
                chance.text = "重生!!";
                StartCoroutine(TemporarilyDeactivate(2));
                goToGo();
                break;
        case 4:
                chance.text = "你受傷了!!";
                StartCoroutine(TemporarilyDeactivate(2));
                goToHospital();
                break;

        }
        
	}


	void goToJail() {
		transform.position = waypoints [30].transform.position;
		wayPointIndex = 30;
	}

	void goToBadLuckyRoad () {
		transform.position = waypoints [53].transform.position;
		wayPointIndex = 66;
        Dice.boolean = 1;
        if (whosTurn == 1)
        {
            DiceNumberTextScript.whosTurn = 1;
        }
        else if (whosTurn == 2)
        {
            DiceNumberTextScript.whosTurn = 2;
        }
        else if (whosTurn == 3)
        {
            DiceNumberTextScript.whosTurn = 3;
        }
        else if (whosTurn == 4)
        {
            DiceNumberTextScript.whosTurn = 4;
        }
        else if (whosTurn == 5)
        {
            DiceNumberTextScript.whosTurn = 5;
        }
        else if (whosTurn == 6)
        {
            DiceNumberTextScript.whosTurn = 6;
        }
        else if (whosTurn == 7)
        {
            DiceNumberTextScript.whosTurn = 7;
        }
        else if (whosTurn == 8)
        {
            DiceNumberTextScript.whosTurn = 8;
        }
    }

	void goToGo() {
		transform.position = waypoints[0].transform.position;
		wayPointIndex = 0;
	}

    void goToHospital()
    {
        transform.position = waypoints[46].transform.position;
        wayPointIndex = 47;
        if (whosTurn == 1)
        {
            DiceNumberTextScript.injure1 = 1;
        }
        else if (whosTurn == 2)
        {
            DiceNumberTextScript.injure2 = 1;
        }
        else if (whosTurn == 3)
        {
            DiceNumberTextScript.injure3 = 1;
        }
        else if (whosTurn == 4)
        {
            DiceNumberTextScript.injure4 = 1;
        }
        else if (whosTurn == 5)
        {
            DiceNumberTextScript.injure5 = 1;
        }
        else if (whosTurn == 6)
        {
            DiceNumberTextScript.injure6 = 1;
        }
        else if (whosTurn == 7)
        {
            DiceNumberTextScript.injure7 = 1;
        }
        else if (whosTurn == 8)
        {
            DiceNumberTextScript.injure8 = 1;
        }

    }

    private IEnumerator TemporarilyDeactivate(float duration)
    {
        ImageForChance.gameObject.SetActive(true);
        yield return new WaitForSeconds(duration);
        ImageForChance.gameObject.SetActive(false);
    }


}
