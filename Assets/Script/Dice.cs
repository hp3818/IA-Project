using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour {

    public Button dropButton;
    public static int boolean = 0;
    public static int accept = 0;

    public void Clicked()
    {
        if (DiceNumberTextScript.whosTurn == 1)
        {
            if (boolean == 1)
            {
                DiceNumberTextScript.dice1.gameObject.SetActive(true);
                DiceNumberTextScript.dice2.gameObject.SetActive(false);
                DiceNumberTextScript.dice3.gameObject.SetActive(false);
                DiceNumberTextScript.dice2Number = 0; GameControl.diceSide2Thrown = 0;
                DiceNumberTextScript.dice3Number = 0; GameControl.diceSide3Thrown = 0;
                boolean = 0;
                accept = 1;
            } else
            {
                if (GameControl.player1.GetComponent<FollowThePath>().transform.position == GameControl.player1.GetComponent<FollowThePath>().waypoints[58].transform.position ||
                    GameControl.player1.GetComponent<FollowThePath>().transform.position == GameControl.player1.GetComponent<FollowThePath>().waypoints[59].transform.position ||
                    GameControl.player1.GetComponent<FollowThePath>().transform.position == GameControl.player1.GetComponent<FollowThePath>().waypoints[60].transform.position ||
                    GameControl.player1.GetComponent<FollowThePath>().transform.position == GameControl.player1.GetComponent<FollowThePath>().waypoints[61].transform.position ||
                    GameControl.player1.GetComponent<FollowThePath>().transform.position == GameControl.player1.GetComponent<FollowThePath>().waypoints[62].transform.position ||
                    GameControl.player1.GetComponent<FollowThePath>().transform.position == GameControl.player1.GetComponent<FollowThePath>().waypoints[63].transform.position ||
                    GameControl.player1.GetComponent<FollowThePath>().transform.position == GameControl.player1.GetComponent<FollowThePath>().waypoints[64].transform.position ||
                    GameControl.player1.GetComponent<FollowThePath>().transform.position == GameControl.player1.GetComponent<FollowThePath>().waypoints[65].transform.position ||
                    GameControl.player1.GetComponent<FollowThePath>().transform.position == GameControl.player1.GetComponent<FollowThePath>().waypoints[66].transform.position ||
                    GameControl.player1.GetComponent<FollowThePath>().transform.position == GameControl.player1.GetComponent<FollowThePath>().waypoints[67].transform.position ||
                    GameControl.player1.GetComponent<FollowThePath>().transform.position == GameControl.player1.GetComponent<FollowThePath>().waypoints[68].transform.position ||
                    GameControl.player1.GetComponent<FollowThePath>().transform.position == GameControl.player1.GetComponent<FollowThePath>().waypoints[69].transform.position ||
                    GameControl.player1.GetComponent<FollowThePath>().transform.position == GameControl.player1.GetComponent<FollowThePath>().waypoints[70].transform.position ||
                    GameControl.player1.GetComponent<FollowThePath>().transform.position == GameControl.player1.GetComponent<FollowThePath>().waypoints[71].transform.position ||
                    GameControl.player1.GetComponent<FollowThePath>().transform.position == GameControl.player1.GetComponent<FollowThePath>().waypoints[72].transform.position ||
                    GameControl.player1.GetComponent<FollowThePath>().transform.position == GameControl.player1.GetComponent<FollowThePath>().waypoints[73].transform.position ||
                    GameControl.player1.GetComponent<FollowThePath>().transform.position == GameControl.player1.GetComponent<FollowThePath>().waypoints[74].transform.position) {

                    DiceNumberTextScript.dice1.gameObject.SetActive(true);
                    DiceNumberTextScript.dice2.gameObject.SetActive(false);
                    DiceNumberTextScript.dice3.gameObject.SetActive(false);
                    DiceNumberTextScript.dice2Number = 0; GameControl.diceSide2Thrown = 0;
                    DiceNumberTextScript.dice3Number = 0; GameControl.diceSide3Thrown = 0;
                    accept = 1;
                } else {
					if (DiceNumberTextScript.jail1 == 1) {
						DiceNumberTextScript.dice1.gameObject.SetActive(true);
						DiceNumberTextScript.dice2.gameObject.SetActive(false);
						DiceNumberTextScript.dice3.gameObject.SetActive(false);
						DiceNumberTextScript.dice2Number = 0; GameControl.diceSide2Thrown = 0;
						DiceNumberTextScript.dice3Number = 0; GameControl.diceSide3Thrown = 0;
						accept = 1;
					} else {
						DiceNumberTextScript.dice1.gameObject.SetActive(true);
						DiceNumberTextScript.dice2.gameObject.SetActive(false);
						DiceNumberTextScript.dice3.gameObject.SetActive(false);
						DiceNumberTextScript.dice2Number = 0; GameControl.diceSide2Thrown = 0;
						DiceNumberTextScript.dice3Number = 0; GameControl.diceSide3Thrown = 0;
						accept = 1;
					}

                }

            }

        } else if (DiceNumberTextScript.whosTurn == 2)
        {
            if (boolean == 1)
            {
                DiceNumberTextScript.dice1.gameObject.SetActive(true);
                DiceNumberTextScript.dice2.gameObject.SetActive(false);
                DiceNumberTextScript.dice3.gameObject.SetActive(false);
                DiceNumberTextScript.dice2Number = 0; GameControl.diceSide2Thrown = 0;
                DiceNumberTextScript.dice3Number = 0; GameControl.diceSide3Thrown = 0;
                boolean = 0;
                accept = 1;
            }
            else
            {
                if (GameControl.player2.GetComponent<FollowThePath>().transform.position == GameControl.player2.GetComponent<FollowThePath>().waypoints[58].transform.position ||
                    GameControl.player2.GetComponent<FollowThePath>().transform.position == GameControl.player2.GetComponent<FollowThePath>().waypoints[59].transform.position ||
                    GameControl.player2.GetComponent<FollowThePath>().transform.position == GameControl.player2.GetComponent<FollowThePath>().waypoints[60].transform.position ||
                    GameControl.player2.GetComponent<FollowThePath>().transform.position == GameControl.player2.GetComponent<FollowThePath>().waypoints[61].transform.position ||
                    GameControl.player2.GetComponent<FollowThePath>().transform.position == GameControl.player2.GetComponent<FollowThePath>().waypoints[62].transform.position ||
                    GameControl.player2.GetComponent<FollowThePath>().transform.position == GameControl.player2.GetComponent<FollowThePath>().waypoints[63].transform.position ||
                    GameControl.player2.GetComponent<FollowThePath>().transform.position == GameControl.player2.GetComponent<FollowThePath>().waypoints[64].transform.position ||
                    GameControl.player2.GetComponent<FollowThePath>().transform.position == GameControl.player2.GetComponent<FollowThePath>().waypoints[65].transform.position ||
                    GameControl.player2.GetComponent<FollowThePath>().transform.position == GameControl.player2.GetComponent<FollowThePath>().waypoints[66].transform.position ||
                    GameControl.player2.GetComponent<FollowThePath>().transform.position == GameControl.player2.GetComponent<FollowThePath>().waypoints[67].transform.position ||
                    GameControl.player2.GetComponent<FollowThePath>().transform.position == GameControl.player2.GetComponent<FollowThePath>().waypoints[68].transform.position ||
                    GameControl.player2.GetComponent<FollowThePath>().transform.position == GameControl.player2.GetComponent<FollowThePath>().waypoints[69].transform.position ||
                    GameControl.player2.GetComponent<FollowThePath>().transform.position == GameControl.player2.GetComponent<FollowThePath>().waypoints[70].transform.position ||
                    GameControl.player2.GetComponent<FollowThePath>().transform.position == GameControl.player2.GetComponent<FollowThePath>().waypoints[71].transform.position ||
                    GameControl.player2.GetComponent<FollowThePath>().transform.position == GameControl.player2.GetComponent<FollowThePath>().waypoints[72].transform.position ||
                    GameControl.player2.GetComponent<FollowThePath>().transform.position == GameControl.player2.GetComponent<FollowThePath>().waypoints[73].transform.position ||
                    GameControl.player2.GetComponent<FollowThePath>().transform.position == GameControl.player2.GetComponent<FollowThePath>().waypoints[74].transform.position) {

                    DiceNumberTextScript.dice1.gameObject.SetActive(true);
                    DiceNumberTextScript.dice2.gameObject.SetActive(false);
                    DiceNumberTextScript.dice3.gameObject.SetActive(false);
                    DiceNumberTextScript.dice2Number = 0;
                    GameControl.diceSide2Thrown = 0;
                    DiceNumberTextScript.dice3Number = 0;
                    GameControl.diceSide3Thrown = 0;
                    accept = 1;
                } else {
					if (DiceNumberTextScript.jail2 == 1) {
						DiceNumberTextScript.dice1.gameObject.SetActive (true);
						DiceNumberTextScript.dice2.gameObject.SetActive (false);
						DiceNumberTextScript.dice3.gameObject.SetActive (false);
						DiceNumberTextScript.dice2Number = 0;
						GameControl.diceSide2Thrown = 0;
						DiceNumberTextScript.dice3Number = 0;
						GameControl.diceSide3Thrown = 0;
						accept = 1;
					} else {
						GameControl.ImageForMid.gameObject.SetActive(true);
					}
                    
                }

            }
        } else if (DiceNumberTextScript.whosTurn == 3)
        {
            if (boolean == 1)
            {
                DiceNumberTextScript.dice1.gameObject.SetActive(true);
                DiceNumberTextScript.dice2.gameObject.SetActive(false);
                DiceNumberTextScript.dice3.gameObject.SetActive(false);
                DiceNumberTextScript.dice2Number = 0; GameControl.diceSide2Thrown = 0;
                DiceNumberTextScript.dice3Number = 0; GameControl.diceSide3Thrown = 0;
                boolean = 0;
                accept = 1;
            }
            else
            {
                if (GameControl.player3.GetComponent<FollowThePath>().transform.position == GameControl.player3.GetComponent<FollowThePath>().waypoints[58].transform.position ||
                    GameControl.player3.GetComponent<FollowThePath>().transform.position == GameControl.player3.GetComponent<FollowThePath>().waypoints[59].transform.position ||
                    GameControl.player3.GetComponent<FollowThePath>().transform.position == GameControl.player3.GetComponent<FollowThePath>().waypoints[60].transform.position ||
                    GameControl.player3.GetComponent<FollowThePath>().transform.position == GameControl.player3.GetComponent<FollowThePath>().waypoints[61].transform.position ||
                    GameControl.player3.GetComponent<FollowThePath>().transform.position == GameControl.player3.GetComponent<FollowThePath>().waypoints[62].transform.position ||
                    GameControl.player3.GetComponent<FollowThePath>().transform.position == GameControl.player3.GetComponent<FollowThePath>().waypoints[63].transform.position ||
                    GameControl.player3.GetComponent<FollowThePath>().transform.position == GameControl.player3.GetComponent<FollowThePath>().waypoints[64].transform.position ||
                    GameControl.player3.GetComponent<FollowThePath>().transform.position == GameControl.player3.GetComponent<FollowThePath>().waypoints[65].transform.position ||
                    GameControl.player3.GetComponent<FollowThePath>().transform.position == GameControl.player3.GetComponent<FollowThePath>().waypoints[66].transform.position ||
                    GameControl.player3.GetComponent<FollowThePath>().transform.position == GameControl.player3.GetComponent<FollowThePath>().waypoints[67].transform.position ||
                    GameControl.player3.GetComponent<FollowThePath>().transform.position == GameControl.player3.GetComponent<FollowThePath>().waypoints[68].transform.position ||
                    GameControl.player3.GetComponent<FollowThePath>().transform.position == GameControl.player3.GetComponent<FollowThePath>().waypoints[69].transform.position ||
                    GameControl.player3.GetComponent<FollowThePath>().transform.position == GameControl.player3.GetComponent<FollowThePath>().waypoints[70].transform.position ||
                    GameControl.player3.GetComponent<FollowThePath>().transform.position == GameControl.player3.GetComponent<FollowThePath>().waypoints[71].transform.position ||
                    GameControl.player3.GetComponent<FollowThePath>().transform.position == GameControl.player3.GetComponent<FollowThePath>().waypoints[72].transform.position ||
                    GameControl.player3.GetComponent<FollowThePath>().transform.position == GameControl.player3.GetComponent<FollowThePath>().waypoints[73].transform.position ||
                    GameControl.player3.GetComponent<FollowThePath>().transform.position == GameControl.player3.GetComponent<FollowThePath>().waypoints[74].transform.position) {

                    DiceNumberTextScript.dice1.gameObject.SetActive(true);
                    DiceNumberTextScript.dice2.gameObject.SetActive(false);
                    DiceNumberTextScript.dice3.gameObject.SetActive(false);
                    DiceNumberTextScript.dice2Number = 0;
                    GameControl.diceSide2Thrown = 0;
                    DiceNumberTextScript.dice3Number = 0;
                    GameControl.diceSide3Thrown = 0;
                    accept = 1;
                } else {
					if (DiceNumberTextScript.jail3 == 1) {
						DiceNumberTextScript.dice1.gameObject.SetActive (true);
						DiceNumberTextScript.dice2.gameObject.SetActive (false);
						DiceNumberTextScript.dice3.gameObject.SetActive (false);
						DiceNumberTextScript.dice2Number = 0;
						GameControl.diceSide2Thrown = 0;
						DiceNumberTextScript.dice3Number = 0;
						GameControl.diceSide3Thrown = 0;
						accept = 1;
					} else {
						GameControl.ImageForMid.gameObject.SetActive(true);
					}
                }

            }
        } else if (DiceNumberTextScript.whosTurn == 4)
        {
            if (boolean == 1)
            {
                DiceNumberTextScript.dice1.gameObject.SetActive(true);
                DiceNumberTextScript.dice2.gameObject.SetActive(false);
                DiceNumberTextScript.dice3.gameObject.SetActive(false);
                DiceNumberTextScript.dice2Number = 0; GameControl.diceSide2Thrown = 0;
                DiceNumberTextScript.dice3Number = 0; GameControl.diceSide3Thrown = 0;
                boolean = 0;
                accept = 1;
            }
            else
            {
                if (GameControl.player4.GetComponent<FollowThePath>().transform.position == GameControl.player4.GetComponent<FollowThePath>().waypoints[58].transform.position ||
                    GameControl.player4.GetComponent<FollowThePath>().transform.position == GameControl.player4.GetComponent<FollowThePath>().waypoints[59].transform.position ||
                    GameControl.player4.GetComponent<FollowThePath>().transform.position == GameControl.player4.GetComponent<FollowThePath>().waypoints[60].transform.position ||
                    GameControl.player4.GetComponent<FollowThePath>().transform.position == GameControl.player4.GetComponent<FollowThePath>().waypoints[61].transform.position ||
                    GameControl.player4.GetComponent<FollowThePath>().transform.position == GameControl.player4.GetComponent<FollowThePath>().waypoints[62].transform.position ||
                    GameControl.player4.GetComponent<FollowThePath>().transform.position == GameControl.player4.GetComponent<FollowThePath>().waypoints[63].transform.position ||
                    GameControl.player4.GetComponent<FollowThePath>().transform.position == GameControl.player4.GetComponent<FollowThePath>().waypoints[64].transform.position ||
                    GameControl.player4.GetComponent<FollowThePath>().transform.position == GameControl.player4.GetComponent<FollowThePath>().waypoints[65].transform.position ||
                    GameControl.player4.GetComponent<FollowThePath>().transform.position == GameControl.player4.GetComponent<FollowThePath>().waypoints[66].transform.position ||
                    GameControl.player4.GetComponent<FollowThePath>().transform.position == GameControl.player4.GetComponent<FollowThePath>().waypoints[67].transform.position ||
                    GameControl.player4.GetComponent<FollowThePath>().transform.position == GameControl.player4.GetComponent<FollowThePath>().waypoints[68].transform.position ||
                    GameControl.player4.GetComponent<FollowThePath>().transform.position == GameControl.player4.GetComponent<FollowThePath>().waypoints[69].transform.position ||
                    GameControl.player4.GetComponent<FollowThePath>().transform.position == GameControl.player4.GetComponent<FollowThePath>().waypoints[70].transform.position ||
                    GameControl.player4.GetComponent<FollowThePath>().transform.position == GameControl.player4.GetComponent<FollowThePath>().waypoints[71].transform.position ||
                    GameControl.player4.GetComponent<FollowThePath>().transform.position == GameControl.player4.GetComponent<FollowThePath>().waypoints[72].transform.position ||
                    GameControl.player4.GetComponent<FollowThePath>().transform.position == GameControl.player4.GetComponent<FollowThePath>().waypoints[73].transform.position ||
                    GameControl.player4.GetComponent<FollowThePath>().transform.position == GameControl.player4.GetComponent<FollowThePath>().waypoints[74].transform.position) {

                    DiceNumberTextScript.dice1.gameObject.SetActive(true);
                    DiceNumberTextScript.dice2.gameObject.SetActive(false);
                    DiceNumberTextScript.dice3.gameObject.SetActive(false);
                    DiceNumberTextScript.dice2Number = 0;
                    GameControl.diceSide2Thrown = 0;
                    DiceNumberTextScript.dice3Number = 0;
                    GameControl.diceSide3Thrown = 0;
                    accept = 1;
                } else {
					if (DiceNumberTextScript.jail4 == 1) {
						DiceNumberTextScript.dice1.gameObject.SetActive (true);
						DiceNumberTextScript.dice2.gameObject.SetActive (false);
						DiceNumberTextScript.dice3.gameObject.SetActive (false);
						DiceNumberTextScript.dice2Number = 0;
						GameControl.diceSide2Thrown = 0;
						DiceNumberTextScript.dice3Number = 0;
						GameControl.diceSide3Thrown = 0;
						accept = 1;
					} else {
						GameControl.ImageForRich.gameObject.SetActive(true);
					}
                }

            }
        } else if (DiceNumberTextScript.whosTurn == 5)
        {
            if (boolean == 1)
            {
                DiceNumberTextScript.dice1.gameObject.SetActive(true);
                DiceNumberTextScript.dice2.gameObject.SetActive(false);
                DiceNumberTextScript.dice3.gameObject.SetActive(false);
                DiceNumberTextScript.dice2Number = 0; GameControl.diceSide2Thrown = 0;
                DiceNumberTextScript.dice3Number = 0; GameControl.diceSide3Thrown = 0;
                boolean = 0;
                accept = 1;
            }
            else
            {
                if (GameControl.player5.GetComponent<FollowThePath>().transform.position == GameControl.player5.GetComponent<FollowThePath>().waypoints[58].transform.position ||
                    GameControl.player5.GetComponent<FollowThePath>().transform.position == GameControl.player5.GetComponent<FollowThePath>().waypoints[59].transform.position ||
                    GameControl.player5.GetComponent<FollowThePath>().transform.position == GameControl.player5.GetComponent<FollowThePath>().waypoints[60].transform.position ||
                    GameControl.player5.GetComponent<FollowThePath>().transform.position == GameControl.player5.GetComponent<FollowThePath>().waypoints[61].transform.position ||
                    GameControl.player5.GetComponent<FollowThePath>().transform.position == GameControl.player5.GetComponent<FollowThePath>().waypoints[62].transform.position ||
                    GameControl.player5.GetComponent<FollowThePath>().transform.position == GameControl.player5.GetComponent<FollowThePath>().waypoints[63].transform.position ||
                    GameControl.player5.GetComponent<FollowThePath>().transform.position == GameControl.player5.GetComponent<FollowThePath>().waypoints[64].transform.position ||
                    GameControl.player5.GetComponent<FollowThePath>().transform.position == GameControl.player5.GetComponent<FollowThePath>().waypoints[65].transform.position ||
                    GameControl.player5.GetComponent<FollowThePath>().transform.position == GameControl.player5.GetComponent<FollowThePath>().waypoints[66].transform.position ||
                    GameControl.player5.GetComponent<FollowThePath>().transform.position == GameControl.player5.GetComponent<FollowThePath>().waypoints[67].transform.position ||
                    GameControl.player5.GetComponent<FollowThePath>().transform.position == GameControl.player5.GetComponent<FollowThePath>().waypoints[68].transform.position ||
                    GameControl.player5.GetComponent<FollowThePath>().transform.position == GameControl.player5.GetComponent<FollowThePath>().waypoints[69].transform.position ||
                    GameControl.player5.GetComponent<FollowThePath>().transform.position == GameControl.player5.GetComponent<FollowThePath>().waypoints[70].transform.position ||
                    GameControl.player5.GetComponent<FollowThePath>().transform.position == GameControl.player5.GetComponent<FollowThePath>().waypoints[71].transform.position ||
                    GameControl.player5.GetComponent<FollowThePath>().transform.position == GameControl.player5.GetComponent<FollowThePath>().waypoints[72].transform.position ||
                    GameControl.player5.GetComponent<FollowThePath>().transform.position == GameControl.player5.GetComponent<FollowThePath>().waypoints[73].transform.position ||
                    GameControl.player5.GetComponent<FollowThePath>().transform.position == GameControl.player5.GetComponent<FollowThePath>().waypoints[74].transform.position) {

                    DiceNumberTextScript.dice1.gameObject.SetActive(true);
                    DiceNumberTextScript.dice2.gameObject.SetActive(false);
                    DiceNumberTextScript.dice3.gameObject.SetActive(false);
                    DiceNumberTextScript.dice2Number = 0;
                    GameControl.diceSide2Thrown = 0;
                    DiceNumberTextScript.dice3Number = 0;
                    GameControl.diceSide3Thrown = 0;
                    accept = 1;
                } else {
					if (DiceNumberTextScript.jail5 == 1) {
						DiceNumberTextScript.dice1.gameObject.SetActive (true);
						DiceNumberTextScript.dice2.gameObject.SetActive (false);
						DiceNumberTextScript.dice3.gameObject.SetActive (false);
						DiceNumberTextScript.dice2Number = 0;
						GameControl.diceSide2Thrown = 0;
						DiceNumberTextScript.dice3Number = 0;
						GameControl.diceSide3Thrown = 0;
						accept = 1;
					} else {
						GameControl.ImageForRich.gameObject.SetActive(true);
					}
                }

            }
        } else if (DiceNumberTextScript.whosTurn == 6)
        {
            if (boolean == 1)
            {
                DiceNumberTextScript.dice1.gameObject.SetActive(true);
                DiceNumberTextScript.dice2.gameObject.SetActive(false);
                DiceNumberTextScript.dice3.gameObject.SetActive(false);
                DiceNumberTextScript.dice2Number = 0; GameControl.diceSide2Thrown = 0;
                DiceNumberTextScript.dice3Number = 0; GameControl.diceSide3Thrown = 0;
                boolean = 0;
                accept = 1;
            }
            else
            {
                if (GameControl.player6.GetComponent<FollowThePath>().transform.position == GameControl.player6.GetComponent<FollowThePath>().waypoints[58].transform.position ||
                    GameControl.player6.GetComponent<FollowThePath>().transform.position == GameControl.player6.GetComponent<FollowThePath>().waypoints[59].transform.position ||
                    GameControl.player6.GetComponent<FollowThePath>().transform.position == GameControl.player6.GetComponent<FollowThePath>().waypoints[60].transform.position ||
                    GameControl.player6.GetComponent<FollowThePath>().transform.position == GameControl.player6.GetComponent<FollowThePath>().waypoints[61].transform.position ||
                    GameControl.player6.GetComponent<FollowThePath>().transform.position == GameControl.player6.GetComponent<FollowThePath>().waypoints[62].transform.position ||
                    GameControl.player6.GetComponent<FollowThePath>().transform.position == GameControl.player6.GetComponent<FollowThePath>().waypoints[63].transform.position ||
                    GameControl.player6.GetComponent<FollowThePath>().transform.position == GameControl.player6.GetComponent<FollowThePath>().waypoints[64].transform.position ||
                    GameControl.player6.GetComponent<FollowThePath>().transform.position == GameControl.player6.GetComponent<FollowThePath>().waypoints[65].transform.position ||
                    GameControl.player6.GetComponent<FollowThePath>().transform.position == GameControl.player6.GetComponent<FollowThePath>().waypoints[66].transform.position ||
                    GameControl.player6.GetComponent<FollowThePath>().transform.position == GameControl.player6.GetComponent<FollowThePath>().waypoints[67].transform.position ||
                    GameControl.player6.GetComponent<FollowThePath>().transform.position == GameControl.player6.GetComponent<FollowThePath>().waypoints[68].transform.position ||
                    GameControl.player6.GetComponent<FollowThePath>().transform.position == GameControl.player6.GetComponent<FollowThePath>().waypoints[69].transform.position ||
                    GameControl.player6.GetComponent<FollowThePath>().transform.position == GameControl.player6.GetComponent<FollowThePath>().waypoints[70].transform.position ||
                    GameControl.player6.GetComponent<FollowThePath>().transform.position == GameControl.player6.GetComponent<FollowThePath>().waypoints[71].transform.position ||
                    GameControl.player6.GetComponent<FollowThePath>().transform.position == GameControl.player6.GetComponent<FollowThePath>().waypoints[72].transform.position ||
                    GameControl.player6.GetComponent<FollowThePath>().transform.position == GameControl.player6.GetComponent<FollowThePath>().waypoints[73].transform.position ||
                    GameControl.player6.GetComponent<FollowThePath>().transform.position == GameControl.player6.GetComponent<FollowThePath>().waypoints[74].transform.position) {

                    DiceNumberTextScript.dice1.gameObject.SetActive(true);
                    DiceNumberTextScript.dice2.gameObject.SetActive(false);
                    DiceNumberTextScript.dice3.gameObject.SetActive(false);
                    DiceNumberTextScript.dice2Number = 0;
                    GameControl.diceSide2Thrown = 0;
                    DiceNumberTextScript.dice3Number = 0;
                    GameControl.diceSide3Thrown = 0;
                    accept = 1;
                } else {
					if (DiceNumberTextScript.jail6 == 1) {
						DiceNumberTextScript.dice1.gameObject.SetActive (true);
						DiceNumberTextScript.dice2.gameObject.SetActive (false);
						DiceNumberTextScript.dice3.gameObject.SetActive (false);
						DiceNumberTextScript.dice2Number = 0;
						GameControl.diceSide2Thrown = 0;
						DiceNumberTextScript.dice3Number = 0;
						GameControl.diceSide3Thrown = 0;
						accept = 1;
					} else {
						GameControl.ImageForRich.gameObject.SetActive(true);
					}
                }

            }
        } else if (DiceNumberTextScript.whosTurn == 7)
        {
            if (boolean == 1)
            {
                DiceNumberTextScript.dice1.gameObject.SetActive(true);
                DiceNumberTextScript.dice2.gameObject.SetActive(false);
                DiceNumberTextScript.dice3.gameObject.SetActive(false);
                DiceNumberTextScript.dice2Number = 0; GameControl.diceSide2Thrown = 0;
                DiceNumberTextScript.dice3Number = 0; GameControl.diceSide3Thrown = 0;
                boolean = 0;
                accept = 1;
            }
            else
            {
                if (GameControl.player7.GetComponent<FollowThePath>().transform.position == GameControl.player7.GetComponent<FollowThePath>().waypoints[58].transform.position ||
                    GameControl.player7.GetComponent<FollowThePath>().transform.position == GameControl.player7.GetComponent<FollowThePath>().waypoints[59].transform.position ||
                    GameControl.player7.GetComponent<FollowThePath>().transform.position == GameControl.player7.GetComponent<FollowThePath>().waypoints[60].transform.position ||
                    GameControl.player7.GetComponent<FollowThePath>().transform.position == GameControl.player7.GetComponent<FollowThePath>().waypoints[61].transform.position ||
                    GameControl.player7.GetComponent<FollowThePath>().transform.position == GameControl.player7.GetComponent<FollowThePath>().waypoints[62].transform.position ||
                    GameControl.player7.GetComponent<FollowThePath>().transform.position == GameControl.player7.GetComponent<FollowThePath>().waypoints[63].transform.position ||
                    GameControl.player7.GetComponent<FollowThePath>().transform.position == GameControl.player7.GetComponent<FollowThePath>().waypoints[64].transform.position ||
                    GameControl.player7.GetComponent<FollowThePath>().transform.position == GameControl.player7.GetComponent<FollowThePath>().waypoints[65].transform.position ||
                    GameControl.player7.GetComponent<FollowThePath>().transform.position == GameControl.player7.GetComponent<FollowThePath>().waypoints[66].transform.position ||
                    GameControl.player7.GetComponent<FollowThePath>().transform.position == GameControl.player7.GetComponent<FollowThePath>().waypoints[67].transform.position ||
                    GameControl.player7.GetComponent<FollowThePath>().transform.position == GameControl.player7.GetComponent<FollowThePath>().waypoints[68].transform.position ||
                    GameControl.player7.GetComponent<FollowThePath>().transform.position == GameControl.player7.GetComponent<FollowThePath>().waypoints[69].transform.position ||
                    GameControl.player7.GetComponent<FollowThePath>().transform.position == GameControl.player7.GetComponent<FollowThePath>().waypoints[70].transform.position ||
                    GameControl.player7.GetComponent<FollowThePath>().transform.position == GameControl.player7.GetComponent<FollowThePath>().waypoints[71].transform.position ||
                    GameControl.player7.GetComponent<FollowThePath>().transform.position == GameControl.player7.GetComponent<FollowThePath>().waypoints[72].transform.position ||
                    GameControl.player7.GetComponent<FollowThePath>().transform.position == GameControl.player7.GetComponent<FollowThePath>().waypoints[73].transform.position ||
                    GameControl.player7.GetComponent<FollowThePath>().transform.position == GameControl.player7.GetComponent<FollowThePath>().waypoints[74].transform.position) {

                    DiceNumberTextScript.dice1.gameObject.SetActive(true);
                    DiceNumberTextScript.dice2.gameObject.SetActive(false);
                    DiceNumberTextScript.dice3.gameObject.SetActive(false);
                    DiceNumberTextScript.dice2Number = 0;
                    GameControl.diceSide2Thrown = 0;
                    DiceNumberTextScript.dice3Number = 0;
                    GameControl.diceSide3Thrown = 0;
                    accept = 1;
                } else {
					if (DiceNumberTextScript.jail7 == 1) {
						DiceNumberTextScript.dice1.gameObject.SetActive (true);
						DiceNumberTextScript.dice2.gameObject.SetActive (false);
						DiceNumberTextScript.dice3.gameObject.SetActive (false);
						DiceNumberTextScript.dice2Number = 0;
						GameControl.diceSide2Thrown = 0;
						DiceNumberTextScript.dice3Number = 0;
						GameControl.diceSide3Thrown = 0;
						accept = 1;
					} else {
						GameControl.ImageForRich.gameObject.SetActive(true);
					}
                }

            }
        } else if (DiceNumberTextScript.whosTurn == 8)
        {
            if (boolean == 1)
            {
                DiceNumberTextScript.dice1.gameObject.SetActive(true);
                DiceNumberTextScript.dice2.gameObject.SetActive(false);
                DiceNumberTextScript.dice3.gameObject.SetActive(false);
                DiceNumberTextScript.dice2Number = 0; GameControl.diceSide2Thrown = 0;
                DiceNumberTextScript.dice3Number = 0; GameControl.diceSide3Thrown = 0;
                boolean = 0;
                accept = 1;
            }
            else
            {
                if (GameControl.player8.GetComponent<FollowThePath>().transform.position == GameControl.player8.GetComponent<FollowThePath>().waypoints[58].transform.position ||
                    GameControl.player8.GetComponent<FollowThePath>().transform.position == GameControl.player8.GetComponent<FollowThePath>().waypoints[59].transform.position ||
                    GameControl.player8.GetComponent<FollowThePath>().transform.position == GameControl.player8.GetComponent<FollowThePath>().waypoints[60].transform.position ||
                    GameControl.player8.GetComponent<FollowThePath>().transform.position == GameControl.player8.GetComponent<FollowThePath>().waypoints[61].transform.position ||
                    GameControl.player8.GetComponent<FollowThePath>().transform.position == GameControl.player8.GetComponent<FollowThePath>().waypoints[62].transform.position ||
                    GameControl.player8.GetComponent<FollowThePath>().transform.position == GameControl.player8.GetComponent<FollowThePath>().waypoints[63].transform.position ||
                    GameControl.player8.GetComponent<FollowThePath>().transform.position == GameControl.player8.GetComponent<FollowThePath>().waypoints[64].transform.position ||
                    GameControl.player8.GetComponent<FollowThePath>().transform.position == GameControl.player8.GetComponent<FollowThePath>().waypoints[65].transform.position ||
                    GameControl.player8.GetComponent<FollowThePath>().transform.position == GameControl.player8.GetComponent<FollowThePath>().waypoints[66].transform.position ||
                    GameControl.player8.GetComponent<FollowThePath>().transform.position == GameControl.player8.GetComponent<FollowThePath>().waypoints[67].transform.position ||
                    GameControl.player8.GetComponent<FollowThePath>().transform.position == GameControl.player8.GetComponent<FollowThePath>().waypoints[68].transform.position ||
                    GameControl.player8.GetComponent<FollowThePath>().transform.position == GameControl.player8.GetComponent<FollowThePath>().waypoints[69].transform.position ||
                    GameControl.player8.GetComponent<FollowThePath>().transform.position == GameControl.player8.GetComponent<FollowThePath>().waypoints[70].transform.position ||
                    GameControl.player8.GetComponent<FollowThePath>().transform.position == GameControl.player8.GetComponent<FollowThePath>().waypoints[71].transform.position ||
                    GameControl.player8.GetComponent<FollowThePath>().transform.position == GameControl.player8.GetComponent<FollowThePath>().waypoints[72].transform.position ||
                    GameControl.player8.GetComponent<FollowThePath>().transform.position == GameControl.player8.GetComponent<FollowThePath>().waypoints[73].transform.position ||
                    GameControl.player8.GetComponent<FollowThePath>().transform.position == GameControl.player8.GetComponent<FollowThePath>().waypoints[74].transform.position) {

                    DiceNumberTextScript.dice1.gameObject.SetActive(true);
                    DiceNumberTextScript.dice2.gameObject.SetActive(false);
                    DiceNumberTextScript.dice3.gameObject.SetActive(false);
                    DiceNumberTextScript.dice2Number = 0;
                    GameControl.diceSide2Thrown = 0;
                    DiceNumberTextScript.dice3Number = 0;
                    GameControl.diceSide3Thrown = 0;
                    accept = 1;
                } else {
					if (DiceNumberTextScript.jail8 == 1) {
						DiceNumberTextScript.dice1.gameObject.SetActive (true);
						DiceNumberTextScript.dice2.gameObject.SetActive (false);
						DiceNumberTextScript.dice3.gameObject.SetActive (false);
						DiceNumberTextScript.dice2Number = 0;
						GameControl.diceSide2Thrown = 0;
						DiceNumberTextScript.dice3Number = 0;
						GameControl.diceSide3Thrown = 0;
						accept = 1;
					} else {
						GameControl.ImageForRich.gameObject.SetActive(true);
					}
                }

            }
        }

        if (accept == 1)
        {
            DiceScript.Vaild = 1;
            DiceScript2.Vaild = 1;
            DiceScript3.Vaild = 1;
            accept = 0;
            dropButton.interactable = false;
        }

    }

}
