using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowThePath : MonoBehaviour {

	public Transform[] waypoints;
    public int Movement = 0;
    public int Accept = 0;
	public static int whosTurn = 1;

    public static int point0 = 1;
    public static int point12 = 0;

    [SerializeField]
    private float moveSpeed = 1f;

    public int wayPointIndex = 0;

    public bool moveAllowed = false;

    private void Start()
    {
        transform.position = waypoints[wayPointIndex].transform.position;
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

            if (transform.position == waypoints[57].transform.position )
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

        }

    }

}
