using System.Collections;
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
    public Text player1Cost, player2Cost, player3Cost, player4Cost, player5Cost, player6Cost, player7Cost, player8Cost;

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

            if (GameControl.numberOfPlayer == 4)
            {
                if (DiceNumberTextScript.whosTurn - 1 == 1)
                    GameControl.Go1 = 1;
                if (DiceNumberTextScript.whosTurn - 1 == 2)
                    GameControl.Go2 = 1;
                if (DiceNumberTextScript.whosTurn - 1 == 3)
                    GameControl.Go3 = 1;
                if (DiceNumberTextScript.whosTurn + 3 == 4)
                    GameControl.Go4 = 1;
            }
            if (GameControl.numberOfPlayer == 5)
            {
                if (DiceNumberTextScript.whosTurn - 1 == 1)
                    GameControl.Go1 = 1;
                if (DiceNumberTextScript.whosTurn - 1 == 2)
                    GameControl.Go2 = 1;
                if (DiceNumberTextScript.whosTurn - 1 == 3)
                    GameControl.Go3 = 1;
                if (DiceNumberTextScript.whosTurn - 1 == 4)
                    GameControl.Go4 = 1;
                if (DiceNumberTextScript.whosTurn + 4 == 5)
                    GameControl.Go5 = 1;
            }
            if (GameControl.numberOfPlayer == 6)
            {
                if (DiceNumberTextScript.whosTurn - 1 == 1)
                    GameControl.Go1 = 1;
                if (DiceNumberTextScript.whosTurn - 1 == 2)
                    GameControl.Go2 = 1;
                if (DiceNumberTextScript.whosTurn - 1 == 3)
                    GameControl.Go3 = 1;
                if (DiceNumberTextScript.whosTurn - 1 == 4)
                    GameControl.Go4 = 1;
                if (DiceNumberTextScript.whosTurn - 1 == 5)
                    GameControl.Go5 = 1;
                if (DiceNumberTextScript.whosTurn + 5 == 6)
                    GameControl.Go6 = 1;
            }
            if (GameControl.numberOfPlayer == 7)
            {
                if (DiceNumberTextScript.whosTurn - 1 == 1)
                    GameControl.Go1 = 1;
                if (DiceNumberTextScript.whosTurn - 1 == 2)
                    GameControl.Go2 = 1;
                if (DiceNumberTextScript.whosTurn - 1 == 3)
                    GameControl.Go3 = 1;
                if (DiceNumberTextScript.whosTurn - 1 == 4)
                    GameControl.Go4 = 1;
                if (DiceNumberTextScript.whosTurn - 1 == 5)
                    GameControl.Go5 = 1;
                if (DiceNumberTextScript.whosTurn - 1 == 6)
                    GameControl.Go6 = 1;
                if (DiceNumberTextScript.whosTurn + 6 == 7)
                    GameControl.Go7 = 1;
            }
            if (GameControl.numberOfPlayer == 8)
            {
                if (DiceNumberTextScript.whosTurn - 1 == 1)
                    GameControl.Go1 = 1;
                if (DiceNumberTextScript.whosTurn - 1 == 2)
                    GameControl.Go2 = 1;
                if (DiceNumberTextScript.whosTurn - 1 == 3)
                    GameControl.Go3 = 1;
                if (DiceNumberTextScript.whosTurn - 1 == 4)
                    GameControl.Go4 = 1;
                if (DiceNumberTextScript.whosTurn - 1 == 5)
                    GameControl.Go5 = 1;
                if (DiceNumberTextScript.whosTurn - 1 == 6)
                    GameControl.Go6 = 1;
                if (DiceNumberTextScript.whosTurn - 1 == 7)
                    GameControl.Go7 = 1;
                if (DiceNumberTextScript.whosTurn + 7 == 8)
                    GameControl.Go8 = 1;
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

            if (transform.position == waypoints[60].transform.position && Movement == (GameControl.diceSide1Thrown + GameControl.diceSide2Thrown + GameControl.diceSide3Thrown - Accept))
            {
                transform.position = waypoints[58].transform.position;
                wayPointIndex = 58;
                Accept += Movement;
            }

            if (transform.position == waypoints[61].transform.position && Movement == (GameControl.diceSide1Thrown + GameControl.diceSide2Thrown + GameControl.diceSide3Thrown - Accept))
            {
                transform.position = waypoints[58].transform.position;
                wayPointIndex = 58;
                Accept += Movement;
            }

            if (transform.position == waypoints[62].transform.position && Movement == (GameControl.diceSide1Thrown + GameControl.diceSide2Thrown + GameControl.diceSide3Thrown))
            {
                StartCoroutine((GameControl.TemporarilyDeactivate3(2)));
                if (GameControl.numberOfPlayer == 4)
                {
                    if (DiceNumberTextScript.whosTurn == 1)
                    {
                        HouseSelection.sum1 += 80000;
                        player1Cost.text = HouseSelection.sum1.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn  == 2)
                    {
                        HouseSelection.sum2 += 80000;
                        player2Cost.text = HouseSelection.sum2.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 3)
                    {
                        HouseSelection.sum3 += 80000;
                        player3Cost.text = HouseSelection.sum3.ToString();
                        HouseSelection.sum4 += 80000;
                        player4Cost.text = HouseSelection.sum4.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 4)
                    {
                        HouseSelection.sum3 += 80000;
                        player3Cost.text = HouseSelection.sum3.ToString();
                        HouseSelection.sum4 += 80000;
                        player4Cost.text = HouseSelection.sum4.ToString();

                    }
                }
                if (GameControl.numberOfPlayer == 5)
                {
                    if (DiceNumberTextScript.whosTurn  == 1)
                    {
                        HouseSelection.sum1 += 80000;
                        player1Cost.text = HouseSelection.sum1.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 2)
                    {
                        HouseSelection.sum2 += 80000;
                        player2Cost.text = HouseSelection.sum2.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn  == 3)
                    {
                        HouseSelection.sum3 += 80000;
                        player3Cost.text = HouseSelection.sum3.ToString();
                        HouseSelection.sum4 += 80000;
                        player4Cost.text = HouseSelection.sum4.ToString();
                        HouseSelection.sum5 += 80000;
                        player5Cost.text = HouseSelection.sum5.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 4)
                    {
                        HouseSelection.sum3 += 80000;
                        player3Cost.text = HouseSelection.sum3.ToString();
                        HouseSelection.sum4 += 80000;
                        player4Cost.text = HouseSelection.sum4.ToString();
                        HouseSelection.sum5 += 80000;
                        player5Cost.text = HouseSelection.sum5.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn + 4 == 5)
                    {
                        HouseSelection.sum3 += 80000;
                        player3Cost.text = HouseSelection.sum3.ToString();
                        HouseSelection.sum4 += 80000;
                        player4Cost.text = HouseSelection.sum4.ToString();
                        HouseSelection.sum5 += 80000;
                        player5Cost.text = HouseSelection.sum5.ToString();
                    }

                }
                if (GameControl.numberOfPlayer == 6)
                {
                    if (DiceNumberTextScript.whosTurn  == 1)
                    {
                        HouseSelection.sum1 += 80000;
                        player1Cost.text = HouseSelection.sum1.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn  == 2)
                    {
                        HouseSelection.sum2 += 80000;
                        player2Cost.text = HouseSelection.sum2.ToString();
                        HouseSelection.sum3 += 80000;
                        player3Cost.text = HouseSelection.sum3.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 3)
                    {
                        HouseSelection.sum2 += 80000;
                        player2Cost.text = HouseSelection.sum2.ToString();
                        HouseSelection.sum3 += 80000;
                        player3Cost.text = HouseSelection.sum3.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 4)
                    {
                        HouseSelection.sum4 += 80000;
                        player4Cost.text = HouseSelection.sum4.ToString();
                        HouseSelection.sum5 += 80000;
                        player5Cost.text = HouseSelection.sum5.ToString();
                        HouseSelection.sum6 += 80000;
                        player5Cost.text = HouseSelection.sum6.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn  == 5)
                    {
                        HouseSelection.sum4 += 80000;
                        player4Cost.text = HouseSelection.sum4.ToString();
                        HouseSelection.sum5 += 80000;
                        player5Cost.text = HouseSelection.sum5.ToString();
                        HouseSelection.sum6 += 80000;
                        player6Cost.text = HouseSelection.sum6.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn  == 6)
                    {
                        HouseSelection.sum4 += 80000;
                        player4Cost.text = HouseSelection.sum4.ToString();
                        HouseSelection.sum5 += 80000;
                        player5Cost.text = HouseSelection.sum5.ToString();
                        HouseSelection.sum6 += 80000;
                        player6Cost.text = HouseSelection.sum6.ToString();
                    }

                }
                if (GameControl.numberOfPlayer == 7)
                {
                    if (DiceNumberTextScript.whosTurn  == 1)
                    {
                        HouseSelection.sum1 += 80000;
                        player1Cost.text = HouseSelection.sum1.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn  == 2)
                    {
                        HouseSelection.sum2 += 80000;
                        player2Cost.text = HouseSelection.sum2.ToString();
                        HouseSelection.sum3 += 80000;
                        player3Cost.text = HouseSelection.sum3.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 3)
                    {
                        HouseSelection.sum2 += 80000;
                        player2Cost.text = HouseSelection.sum2.ToString();
                        HouseSelection.sum3 += 80000;
                        player3Cost.text = HouseSelection.sum3.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn  == 4)
                    {
                        HouseSelection.sum4 += 80000;
                        player4Cost.text = HouseSelection.sum4.ToString();
                        HouseSelection.sum5 += 80000;
                        player5Cost.text = HouseSelection.sum5.ToString();
                        HouseSelection.sum6 += 80000;
                        player6Cost.text = HouseSelection.sum6.ToString();
                        HouseSelection.sum7 += 80000;
                        player7Cost.text = HouseSelection.sum7.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn  == 5)
                    {
                        HouseSelection.sum4 += 80000;
                        player4Cost.text = HouseSelection.sum4.ToString();
                        HouseSelection.sum5 += 80000;
                        player5Cost.text = HouseSelection.sum5.ToString();
                        HouseSelection.sum6 += 80000;
                        player6Cost.text = HouseSelection.sum6.ToString();
                        HouseSelection.sum7 += 80000;
                        player7Cost.text = HouseSelection.sum7.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn  == 6)
                    {
                        HouseSelection.sum4 += 80000;
                        player4Cost.text = HouseSelection.sum4.ToString();
                        HouseSelection.sum5 += 80000;
                        player5Cost.text = HouseSelection.sum5.ToString();
                        HouseSelection.sum6 += 80000;
                        player6Cost.text = HouseSelection.sum6.ToString();
                        HouseSelection.sum7 += 80000;
                        player7Cost.text = HouseSelection.sum7.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn  == 7)
                    {
                        HouseSelection.sum4 += 80000;
                        player4Cost.text = HouseSelection.sum4.ToString();
                        HouseSelection.sum5 += 80000;
                        player5Cost.text = HouseSelection.sum5.ToString();
                        HouseSelection.sum6 += 80000;
                        player6Cost.text = HouseSelection.sum6.ToString();
                        HouseSelection.sum7 += 80000;
                        player7Cost.text = HouseSelection.sum7.ToString();
                    }

                }
                if (GameControl.numberOfPlayer == 8)
                {
                    if (DiceNumberTextScript.whosTurn == 1)
                    {
                        HouseSelection.sum1 += 80000;
                        player1Cost.text = HouseSelection.sum1.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn  == 2)
                    {
                        HouseSelection.sum2 += 80000;
                        player2Cost.text = HouseSelection.sum2.ToString();
                        HouseSelection.sum3 += 80000;
                        player3Cost.text = HouseSelection.sum3.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn  == 3)
                    {
                        HouseSelection.sum2 += 80000;
                        player2Cost.text = HouseSelection.sum2.ToString();
                        HouseSelection.sum3 += 80000;
                        player3Cost.text = HouseSelection.sum3.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 4)
                    {
                        HouseSelection.sum4 += 80000;
                        player4Cost.text = HouseSelection.sum4.ToString();
                        HouseSelection.sum5 += 80000;
                        player5Cost.text = HouseSelection.sum5.ToString();
                        HouseSelection.sum6 += 80000;
                        player6Cost.text = HouseSelection.sum6.ToString();
                        HouseSelection.sum7 += 80000;
                        player7Cost.text = HouseSelection.sum7.ToString();
                        HouseSelection.sum8 += 80000;
                        player8Cost.text = HouseSelection.sum8.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn== 5)
                    {
                        HouseSelection.sum4 += 80000;
                        player4Cost.text = HouseSelection.sum4.ToString();
                        HouseSelection.sum5 += 80000;
                        player5Cost.text = HouseSelection.sum5.ToString();
                        HouseSelection.sum6 += 80000;
                        player6Cost.text = HouseSelection.sum6.ToString();
                        HouseSelection.sum7 += 80000;
                        player7Cost.text = HouseSelection.sum7.ToString();
                        HouseSelection.sum8 += 80000;
                        player8Cost.text = HouseSelection.sum8.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn  == 6)
                    {
                        HouseSelection.sum4 += 80000;
                        player4Cost.text = HouseSelection.sum4.ToString();
                        HouseSelection.sum5 += 80000;
                        player5Cost.text = HouseSelection.sum5.ToString();
                        HouseSelection.sum6 += 80000;
                        player6Cost.text = HouseSelection.sum6.ToString();
                        HouseSelection.sum7 += 80000;
                        player7Cost.text = HouseSelection.sum7.ToString();
                        HouseSelection.sum8 += 80000;
                        player8Cost.text = HouseSelection.sum8.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 7)
                    {
                        HouseSelection.sum4 += 80000;
                        player4Cost.text = HouseSelection.sum4.ToString();
                        HouseSelection.sum5 += 80000;
                        player5Cost.text = HouseSelection.sum5.ToString();
                        HouseSelection.sum6 += 80000;
                        player5Cost.text = HouseSelection.sum6.ToString();
                        HouseSelection.sum7 += 80000;
                        player7Cost.text = HouseSelection.sum7.ToString();
                        HouseSelection.sum8 += 80000;
                        player8Cost.text = HouseSelection.sum8.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 8)
                    {
                        HouseSelection.sum4 += 80000;
                        player4Cost.text = HouseSelection.sum4.ToString();
                        HouseSelection.sum5 += 80000;
                        player5Cost.text = HouseSelection.sum5.ToString();
                        HouseSelection.sum6 += 80000;
                        player5Cost.text = HouseSelection.sum6.ToString();
                        HouseSelection.sum7 += 80000;
                        player7Cost.text = HouseSelection.sum7.ToString();
                        HouseSelection.sum8 += 80000;
                        player8Cost.text = HouseSelection.sum8.ToString();
                    }

                }
            }

            if (transform.position == waypoints[63].transform.position && Movement == (GameControl.diceSide1Thrown + GameControl.diceSide2Thrown + GameControl.diceSide3Thrown))
            {
                StartCoroutine((GameControl.TemporarilyDeactivate4(2)));
                if (GameControl.numberOfPlayer == 4)
                {
                    if (DiceNumberTextScript.whosTurn == 1)
                    {
                        HouseSelection.sum1 += 1000000;
                        player1Cost.text = HouseSelection.sum1.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 2)
                    {
                        HouseSelection.sum2 += 1000000;
                        player2Cost.text = HouseSelection.sum2.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 3)
                    {
                        HouseSelection.sum3 += 1000000;
                        player3Cost.text = HouseSelection.sum3.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 4)
                    {
                        HouseSelection.sum4 += 1000000;
                        player4Cost.text = HouseSelection.sum4.ToString();
                    }
                }
                if (GameControl.numberOfPlayer == 5)
                {
                    if (DiceNumberTextScript.whosTurn == 1)
                    {
                        HouseSelection.sum1 += 1000000;
                        player1Cost.text = HouseSelection.sum1.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn  == 2)
                    {
                        HouseSelection.sum2 += 1000000;
                        player2Cost.text = HouseSelection.sum2.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 3)
                    {
                        HouseSelection.sum3 += 1000000;
                        player3Cost.text = HouseSelection.sum3.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 4)
                    {
                        HouseSelection.sum4 += 1000000;
                        player4Cost.text = HouseSelection.sum4.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn  == 5)
                    {
                        HouseSelection.sum5 += 1000000;
                        player5Cost.text = HouseSelection.sum5.ToString();
                    }
                }
                if (GameControl.numberOfPlayer == 6)
                {
                    if (DiceNumberTextScript.whosTurn == 1)
                    {
                        HouseSelection.sum1 += 1000000;
                        player1Cost.text = HouseSelection.sum1.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn  == 2)
                    {
                        HouseSelection.sum2 += 1000000;
                        player2Cost.text = HouseSelection.sum2.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn  == 3)
                    {
                        HouseSelection.sum3 += 1000000;
                        player3Cost.text = HouseSelection.sum3.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn== 4)
                    {
                        HouseSelection.sum4 += 1000000;
                        player4Cost.text = HouseSelection.sum4.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn  == 5)
                    {
                        HouseSelection.sum5 += 1000000;
                        player5Cost.text = HouseSelection.sum5.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 6)
                    {
                        HouseSelection.sum6 += 1000000;
                        player6Cost.text = HouseSelection.sum6.ToString();
                    }
                }
                if (GameControl.numberOfPlayer == 7)
                {
                    if (DiceNumberTextScript.whosTurn == 1)
                    {
                        HouseSelection.sum1 += 1000000;
                        player1Cost.text = HouseSelection.sum1.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 2)
                    {
                        HouseSelection.sum2 += 1000000;
                        player2Cost.text = HouseSelection.sum2.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn  == 3)
                    {
                        HouseSelection.sum3 += 1000000;
                        player3Cost.text = HouseSelection.sum3.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn  == 4)
                    {
                        HouseSelection.sum4 += 1000000;
                        player4Cost.text = HouseSelection.sum4.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 5)
                    {
                        HouseSelection.sum5 += 1000000;
                        player5Cost.text = HouseSelection.sum5.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 6)
                    {
                        HouseSelection.sum6 += 1000000;
                        player6Cost.text = HouseSelection.sum6.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 7)
                    {
                        HouseSelection.sum7 += 1000000;
                        player7Cost.text = HouseSelection.sum7.ToString();
                    }

                }
                if (GameControl.numberOfPlayer == 8)
                {
                    if (DiceNumberTextScript.whosTurn  == 1)
                    {
                        HouseSelection.sum1 += 1000000;
                        player1Cost.text = HouseSelection.sum1.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 2)
                    {
                        HouseSelection.sum2 += 1000000;
                        player2Cost.text = HouseSelection.sum2.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn  == 3)
                    {
                        HouseSelection.sum3 += 1000000;
                        player3Cost.text = HouseSelection.sum3.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn  == 4)
                    {
                        HouseSelection.sum4 += 1000000;
                        player4Cost.text = HouseSelection.sum4.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn  == 5)
                    {
                        HouseSelection.sum5 += 1000000;
                        player5Cost.text = HouseSelection.sum5.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 6)
                    {
                        HouseSelection.sum6 += 1000000;
                        player6Cost.text = HouseSelection.sum6.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn  == 7)
                    {
                        HouseSelection.sum7 += 1000000;
                        player7Cost.text = HouseSelection.sum7.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn  == 8)
                    {
                        HouseSelection.sum8 += 1000000;
                        player8Cost.text = HouseSelection.sum8.ToString();
                    }

                }
            }

            if (transform.position == waypoints[68].transform.position && Movement == (GameControl.diceSide1Thrown + GameControl.diceSide2Thrown + GameControl.diceSide3Thrown))
            {
                StartCoroutine((GameControl.TemporarilyDeactivate9(2)));
                if (GameControl.numberOfPlayer == 4)
                {
                    if (DiceNumberTextScript.whosTurn == 1)
                    {
                        HouseSelection.sum1 *= 0.8;
                        player1Cost.text = HouseSelection.sum1.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 2)
                    {
                        HouseSelection.sum2 *= 0.8;
                        player2Cost.text = HouseSelection.sum2.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 3)
                    {
                        HouseSelection.sum3 *= 0.8;
                        player3Cost.text = HouseSelection.sum3.ToString();
                        HouseSelection.sum4 *= 0.8;
                        player4Cost.text = HouseSelection.sum4.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 4)
                    {
                        HouseSelection.sum3 *= 0.8;
                        player3Cost.text = HouseSelection.sum3.ToString();
                        HouseSelection.sum4 *= 0.8;
                        player4Cost.text = HouseSelection.sum4.ToString();

                    }
                }
                if (GameControl.numberOfPlayer == 5)
                {
                    if (DiceNumberTextScript.whosTurn == 1)
                    {
                        HouseSelection.sum1 *= 0.8;
                        player1Cost.text = HouseSelection.sum1.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 2)
                    {
                        HouseSelection.sum2 *= 0.8;
                        player2Cost.text = HouseSelection.sum2.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 3)
                    {
                        HouseSelection.sum3 *= 0.8;
                        player3Cost.text = HouseSelection.sum3.ToString();
                        HouseSelection.sum4 *= 0.8;
                        player4Cost.text = HouseSelection.sum4.ToString();
                        HouseSelection.sum5 *= 0.8;
                        player5Cost.text = HouseSelection.sum5.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 4)
                    {
                        HouseSelection.sum3 *= 0.8;
                        player3Cost.text = HouseSelection.sum3.ToString();
                        HouseSelection.sum4 *= 0.8;
                        player4Cost.text = HouseSelection.sum4.ToString();
                        HouseSelection.sum5 *= 0.8;
                        player5Cost.text = HouseSelection.sum5.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn + 4 == 5)
                    {
                        HouseSelection.sum3 *= 0.8;
                        player3Cost.text = HouseSelection.sum3.ToString();
                        HouseSelection.sum4 *= 0.8;
                        player4Cost.text = HouseSelection.sum4.ToString();
                        HouseSelection.sum5 *= 0.8;
                        player5Cost.text = HouseSelection.sum5.ToString();
                    }

                }
                if (GameControl.numberOfPlayer == 6)
                {
                    if (DiceNumberTextScript.whosTurn == 1)
                    {
                        HouseSelection.sum1 *= 0.8;
                        player1Cost.text = HouseSelection.sum1.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 2)
                    {
                        HouseSelection.sum2 *= 0.8;
                        player2Cost.text = HouseSelection.sum2.ToString();
                        HouseSelection.sum3 *= 0.8;
                        player3Cost.text = HouseSelection.sum3.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 3)
                    {
                        HouseSelection.sum2 *= 0.8;
                        player2Cost.text = HouseSelection.sum2.ToString();
                        HouseSelection.sum3 *= 0.8;
                        player3Cost.text = HouseSelection.sum3.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 4)
                    {
                        HouseSelection.sum4 *= 0.8;
                        player4Cost.text = HouseSelection.sum4.ToString();
                        HouseSelection.sum4 *= 0.8;
                        player5Cost.text = HouseSelection.sum5.ToString();
                        HouseSelection.sum4 *= 0.8;
                        player5Cost.text = HouseSelection.sum6.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 5)
                    {
                        HouseSelection.sum4 *= 0.8;
                        player4Cost.text = HouseSelection.sum4.ToString();
                        HouseSelection.sum4 *= 0.8;
                        player5Cost.text = HouseSelection.sum5.ToString();
                        HouseSelection.sum4 *= 0.8;
                        player5Cost.text = HouseSelection.sum6.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 6)
                    {
                        HouseSelection.sum4 *= 0.8;
                        player4Cost.text = HouseSelection.sum4.ToString();
                        HouseSelection.sum4 *= 0.8;
                        player5Cost.text = HouseSelection.sum5.ToString();
                        HouseSelection.sum4 *= 0.8;
                        player5Cost.text = HouseSelection.sum6.ToString();
                    }

                }
                if (GameControl.numberOfPlayer == 7)
                {
                    if (DiceNumberTextScript.whosTurn == 1)
                    {
                        HouseSelection.sum1 *= 0.8;
                        player1Cost.text = HouseSelection.sum1.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 2)
                    {
                        HouseSelection.sum2 *= 0.8;
                        player2Cost.text = HouseSelection.sum2.ToString();
                        HouseSelection.sum3 *= 0.8;
                        player3Cost.text = HouseSelection.sum3.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 3)
                    {
                        HouseSelection.sum2 *= 0.8;
                        player2Cost.text = HouseSelection.sum2.ToString();
                        HouseSelection.sum3 *= 0.8;
                        player3Cost.text = HouseSelection.sum3.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 4)
                    {
                        HouseSelection.sum4 *= 0.8;
                        player4Cost.text = HouseSelection.sum4.ToString();
                        HouseSelection.sum5 *= 0.8;
                        player5Cost.text = HouseSelection.sum5.ToString();
                        HouseSelection.sum6 *= 0.8;
                        player6Cost.text = HouseSelection.sum6.ToString();
                        HouseSelection.sum7 *= 0.8;
                        player7Cost.text = HouseSelection.sum7.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 5)
                    {
                        HouseSelection.sum4 *= 0.8;
                        player4Cost.text = HouseSelection.sum4.ToString();
                        HouseSelection.sum5 *= 0.8;
                        player5Cost.text = HouseSelection.sum5.ToString();
                        HouseSelection.sum6 *= 0.8;
                        player6Cost.text = HouseSelection.sum6.ToString();
                        HouseSelection.sum7 *= 0.8;
                        player7Cost.text = HouseSelection.sum7.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 6)
                    {
                        HouseSelection.sum4 *= 0.8;
                        player4Cost.text = HouseSelection.sum4.ToString();
                        HouseSelection.sum5 *= 0.8;
                        player5Cost.text = HouseSelection.sum5.ToString();
                        HouseSelection.sum6 *= 0.8;
                        player6Cost.text = HouseSelection.sum6.ToString();
                        HouseSelection.sum7 *= 0.8;
                        player7Cost.text = HouseSelection.sum7.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 7)
                    {
                        HouseSelection.sum4 *= 0.8;
                        player4Cost.text = HouseSelection.sum4.ToString();
                        HouseSelection.sum5 *= 0.8;
                        player5Cost.text = HouseSelection.sum5.ToString();
                        HouseSelection.sum6 *= 0.8;
                        player6Cost.text = HouseSelection.sum6.ToString();
                        HouseSelection.sum7 *= 0.8;
                        player7Cost.text = HouseSelection.sum7.ToString();
                    }

                }
                if (GameControl.numberOfPlayer == 8)
                {
                    if (DiceNumberTextScript.whosTurn == 1)
                    {
                        HouseSelection.sum1 *= 0.8;
                        player1Cost.text = HouseSelection.sum1.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 2)
                    {
                        HouseSelection.sum2 *= 0.8;
                        player2Cost.text = HouseSelection.sum2.ToString();
                        HouseSelection.sum3 *= 0.8;
                        player3Cost.text = HouseSelection.sum3.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 3)
                    {
                        HouseSelection.sum2 *= 0.8;
                        player2Cost.text = HouseSelection.sum2.ToString();
                        HouseSelection.sum3 *= 0.8;
                        player3Cost.text = HouseSelection.sum3.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 4)
                    {
                        HouseSelection.sum4 *= 0.8;
                        player4Cost.text = HouseSelection.sum4.ToString();
                        HouseSelection.sum5 *= 0.8;
                        player5Cost.text = HouseSelection.sum5.ToString();
                        HouseSelection.sum6 *= 0.8;
                        player6Cost.text = HouseSelection.sum6.ToString();
                        HouseSelection.sum7 *= 0.8;
                        player7Cost.text = HouseSelection.sum7.ToString();
                        HouseSelection.sum8 *= 0.8;
                        player8Cost.text = HouseSelection.sum8.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 5)
                    {
                        HouseSelection.sum4 *= 0.8;
                        player4Cost.text = HouseSelection.sum4.ToString();
                        HouseSelection.sum5 *= 0.8;
                        player5Cost.text = HouseSelection.sum5.ToString();
                        HouseSelection.sum6 *= 0.8;
                        player6Cost.text = HouseSelection.sum6.ToString();
                        HouseSelection.sum7 *= 0.8;
                        player7Cost.text = HouseSelection.sum7.ToString();
                        HouseSelection.sum8 *= 0.8;
                        player8Cost.text = HouseSelection.sum8.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 6)
                    {
                        HouseSelection.sum4 *= 0.8;
                        player4Cost.text = HouseSelection.sum4.ToString();
                        HouseSelection.sum5 *= 0.8;
                        player5Cost.text = HouseSelection.sum5.ToString();
                        HouseSelection.sum6 *= 0.8;
                        player6Cost.text = HouseSelection.sum6.ToString();
                        HouseSelection.sum7 *= 0.8;
                        player7Cost.text = HouseSelection.sum7.ToString();
                        HouseSelection.sum8 *= 0.8;
                        player8Cost.text = HouseSelection.sum8.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 7)
                    {
                        HouseSelection.sum4 *= 0.8;
                        player4Cost.text = HouseSelection.sum4.ToString();
                        HouseSelection.sum5 *= 0.8;
                        player5Cost.text = HouseSelection.sum5.ToString();
                        HouseSelection.sum6 *= 0.8;
                        player6Cost.text = HouseSelection.sum6.ToString();
                        HouseSelection.sum7 *= 0.8;
                        player7Cost.text = HouseSelection.sum7.ToString();
                        HouseSelection.sum8 *= 0.8;
                        player8Cost.text = HouseSelection.sum8.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 8)
                    {
                        HouseSelection.sum4 *= 0.8;
                        player4Cost.text = HouseSelection.sum4.ToString();
                        HouseSelection.sum5 *= 0.8;
                        player5Cost.text = HouseSelection.sum5.ToString();
                        HouseSelection.sum6 *= 0.8;
                        player6Cost.text = HouseSelection.sum6.ToString();
                        HouseSelection.sum7 *= 0.8;
                        player7Cost.text = HouseSelection.sum7.ToString();
                        HouseSelection.sum8 *= 0.8;
                        player8Cost.text = HouseSelection.sum8.ToString();
                    }

                }
            }

            if (transform.position == waypoints[69].transform.position && Movement == (GameControl.diceSide1Thrown + GameControl.diceSide2Thrown + GameControl.diceSide3Thrown))
            {
                StartCoroutine((GameControl.TemporarilyDeactivate10(2)));
                if (GameControl.numberOfPlayer == 4)
                {
                    if (DiceNumberTextScript.whosTurn == 1)
                    {
                        HouseSelection.sum1 *= 0.5;
                        player1Cost.text = HouseSelection.sum1.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 2)
                    {
                        HouseSelection.sum2 *= 0.5;
                        player2Cost.text = HouseSelection.sum2.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 3)
                    {
                        HouseSelection.sum3 *= 0.5;
                        player3Cost.text = HouseSelection.sum3.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 4)
                    {
                        HouseSelection.sum5 *= 0.5;
                        player4Cost.text = HouseSelection.sum4.ToString();
                    }
                }
                if (GameControl.numberOfPlayer == 5)
                {
                    if (DiceNumberTextScript.whosTurn == 1)
                    {
                        HouseSelection.sum1 *= 0.5;
                        player1Cost.text = HouseSelection.sum1.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 2)
                    {
                        HouseSelection.sum2 *= 0.5;
                        player2Cost.text = HouseSelection.sum2.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 3)
                    {
                        HouseSelection.sum3 *= 0.5;
                        player3Cost.text = HouseSelection.sum3.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 4)
                    {
                        HouseSelection.sum5 *= 0.5;
                        player4Cost.text = HouseSelection.sum4.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 5)
                    {
                        HouseSelection.sum5 *= 0.5;
                        player5Cost.text = HouseSelection.sum5.ToString();
                    }
                }
                if (GameControl.numberOfPlayer == 6)
                {
                    if (DiceNumberTextScript.whosTurn == 1)
                    {
                        HouseSelection.sum1 *= 0.5;
                        player1Cost.text = HouseSelection.sum1.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 2)
                    {
                        HouseSelection.sum2 *= 0.5;
                        player2Cost.text = HouseSelection.sum2.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 3)
                    {
                        HouseSelection.sum3 *= 0.5;
                        player3Cost.text = HouseSelection.sum3.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 4)
                    {
                        HouseSelection.sum4 *= 0.5;
                        player4Cost.text = HouseSelection.sum4.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 5)
                    {
                        HouseSelection.sum5 *= 0.5;
                        player5Cost.text = HouseSelection.sum5.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 6)
                    {
                        HouseSelection.sum6 *= 0.5;
                        player6Cost.text = HouseSelection.sum6.ToString();
                    }
                }
                if (GameControl.numberOfPlayer == 7)
                {
                    if (DiceNumberTextScript.whosTurn == 1)
                    {
                        HouseSelection.sum1 *= 0.5;
                        player1Cost.text = HouseSelection.sum1.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 2)
                    {
                        HouseSelection.sum2 *= 0.5;
                        player2Cost.text = HouseSelection.sum2.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 3)
                    {
                        HouseSelection.sum3 *= 0.5;
                        player3Cost.text = HouseSelection.sum3.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 4)
                    {
                        HouseSelection.sum4 *= 0.5;
                        player4Cost.text = HouseSelection.sum4.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 5)
                    {
                        HouseSelection.sum5 *= 0.5;
                        player5Cost.text = HouseSelection.sum5.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 6)
                    {
                        HouseSelection.sum6 *= 0.5;
                        player6Cost.text = HouseSelection.sum6.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 7)
                    {
                        HouseSelection.sum7 *= 0.5;
                        player7Cost.text = HouseSelection.sum7.ToString();
                    }

                }
                if (GameControl.numberOfPlayer == 8)
                {
                    if (DiceNumberTextScript.whosTurn == 1)
                    {
                        HouseSelection.sum1 *= 0.5;
                        player1Cost.text = HouseSelection.sum1.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 2)
                    {
                        HouseSelection.sum2 *= 0.5;
                        player2Cost.text = HouseSelection.sum2.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 3)
                    {
                        HouseSelection.sum3 *= 0.5;
                        player3Cost.text = HouseSelection.sum3.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 4)
                    {
                        HouseSelection.sum4 *= 0.5;
                        player4Cost.text = HouseSelection.sum4.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 5)
                    {
                        HouseSelection.sum5 *= 0.5;
                        player5Cost.text = HouseSelection.sum5.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 6)
                    {
                        HouseSelection.sum6 *= 0.5;
                        player6Cost.text = HouseSelection.sum6.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 7)
                    {
                        HouseSelection.sum7 *= 0.5;
                        player7Cost.text = HouseSelection.sum7.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 8)
                    {
                        HouseSelection.sum8 *= 0.5;
                        player8Cost.text = HouseSelection.sum8.ToString();
                    }

                }
            }

            if (transform.position == waypoints[70].transform.position && Movement == (GameControl.diceSide1Thrown + GameControl.diceSide2Thrown + GameControl.diceSide3Thrown))
            {
                transform.position = waypoints[30].transform.position;
                wayPointIndex = 30;
                Accept += Movement;
            }

            if (transform.position == waypoints[71].transform.position && Movement == (GameControl.diceSide1Thrown + GameControl.diceSide2Thrown + GameControl.diceSide3Thrown))
            {
                goToHospital();
                Accept += Movement;
            }

            if (transform.position == waypoints[72].transform.position && Movement == (GameControl.diceSide1Thrown + GameControl.diceSide2Thrown + GameControl.diceSide3Thrown - Accept))
            {
                transform.position = waypoints[71].transform.position;
                wayPointIndex = 71;
                Accept += Movement;
            }

            if (transform.position == waypoints[74].transform.position && Movement == (GameControl.diceSide1Thrown + GameControl.diceSide2Thrown + GameControl.diceSide3Thrown))
            {
                StartCoroutine((GameControl.TemporarilyDeactivate10(2)));
                if (GameControl.numberOfPlayer == 4)
                {
                    if (DiceNumberTextScript.whosTurn == 1)
                    {
                        HouseSelection.sum1 *= 0.1;
                        player1Cost.text = HouseSelection.sum1.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 2)
                    {
                        HouseSelection.sum2 *= 0.1;
                        player2Cost.text = HouseSelection.sum2.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 3)
                    {
                        HouseSelection.sum3 *= 0.1;
                        player3Cost.text = HouseSelection.sum3.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 4)
                    {
                        HouseSelection.sum5 *= 0.1;
                        player4Cost.text = HouseSelection.sum4.ToString();
                    }
                }
                if (GameControl.numberOfPlayer == 5)
                {
                    if (DiceNumberTextScript.whosTurn == 1)
                    {
                        HouseSelection.sum1 *= 0.1;
                        player1Cost.text = HouseSelection.sum1.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 2)
                    {
                        HouseSelection.sum2 *= 0.1;
                        player2Cost.text = HouseSelection.sum2.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 3)
                    {
                        HouseSelection.sum3 *= 0.1;
                        player3Cost.text = HouseSelection.sum3.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 4)
                    {
                        HouseSelection.sum5 *= 0.1;
                        player4Cost.text = HouseSelection.sum4.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 5)
                    {
                        HouseSelection.sum5 *= 0.1;
                        player5Cost.text = HouseSelection.sum5.ToString();
                    }
                }
                if (GameControl.numberOfPlayer == 6)
                {
                    if (DiceNumberTextScript.whosTurn == 1)
                    {
                        HouseSelection.sum1 *= 0.1;
                        player1Cost.text = HouseSelection.sum1.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 2)
                    {
                        HouseSelection.sum2 *= 0.1;
                        player2Cost.text = HouseSelection.sum2.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 3)
                    {
                        HouseSelection.sum3 *= 0.1;
                        player3Cost.text = HouseSelection.sum3.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 4)
                    {
                        HouseSelection.sum4 *= 0.1;
                        player4Cost.text = HouseSelection.sum4.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 5)
                    {
                        HouseSelection.sum5 *= 0.1;
                        player5Cost.text = HouseSelection.sum5.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 6)
                    {
                        HouseSelection.sum6 *= 0.1;
                        player6Cost.text = HouseSelection.sum6.ToString();
                    }
                }
                if (GameControl.numberOfPlayer == 7)
                {
                    if (DiceNumberTextScript.whosTurn == 1)
                    {
                        HouseSelection.sum1 *= 0.1;
                        player1Cost.text = HouseSelection.sum1.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 2)
                    {
                        HouseSelection.sum2 *= 0.1;
                        player2Cost.text = HouseSelection.sum2.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 3)
                    {
                        HouseSelection.sum3 *= 0.1;
                        player3Cost.text = HouseSelection.sum3.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 4)
                    {
                        HouseSelection.sum4 *= 0.1;
                        player4Cost.text = HouseSelection.sum4.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 5)
                    {
                        HouseSelection.sum5 *= 0.1;
                        player5Cost.text = HouseSelection.sum5.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 6)
                    {
                        HouseSelection.sum6 *= 0.1;
                        player6Cost.text = HouseSelection.sum6.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 7)
                    {
                        HouseSelection.sum7 *= 0.1;
                        player7Cost.text = HouseSelection.sum7.ToString();
                    }

                }
                if (GameControl.numberOfPlayer == 8)
                {
                    if (DiceNumberTextScript.whosTurn == 1)
                    {
                        HouseSelection.sum1 *= 0.1;
                        player1Cost.text = HouseSelection.sum1.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 2)
                    {
                        HouseSelection.sum2 *= 0.1;
                        player2Cost.text = HouseSelection.sum2.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 3)
                    {
                        HouseSelection.sum3 *= 0.1;
                        player3Cost.text = HouseSelection.sum3.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 4)
                    {
                        HouseSelection.sum4 *= 0.1;
                        player4Cost.text = HouseSelection.sum4.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 5)
                    {
                        HouseSelection.sum5 *= 0.1;
                        player5Cost.text = HouseSelection.sum5.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 6)
                    {
                        HouseSelection.sum6 *= 0.1;
                        player6Cost.text = HouseSelection.sum6.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 7)
                    {
                        HouseSelection.sum7 *= 0.1;
                        player7Cost.text = HouseSelection.sum7.ToString();
                    }
                    if (DiceNumberTextScript.whosTurn == 8)
                    {
                        HouseSelection.sum8 *= 0.1;
                        player8Cost.text = HouseSelection.sum8.ToString();
                    }

                }
            }


        }

    }

    void random() {

		int getRangeNum = 0;
		int rangeRadomNum = 0;


		do {
			rangeRadomNum = Random.Range (1, 4);		
		} while (getRangeNum == rangeRadomNum);

		getRangeNum = rangeRadomNum;

		numberOfChance = rangeRadomNum;

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
        GameControl.player1Waypoint = 0;
        Accept += Movement;
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
