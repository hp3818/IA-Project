﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceNumberTextScript : MonoBehaviour {

    public static GameObject player1, player2, player3, player4, player5, player6, player7, player8;
    public static GameObject dice1, dice2, dice3;
    public Transform[] waypoints;
    public Text JailTurn;
    public static GameObject ImageForMid, ImageForRich;
    public static GameObject ImageForBuyHouse;
    public static GameObject ImageForBuyOtherHouse;
	public Button dropButton;
    public static GameObject ImageForJail;
    public static GameObject ImageForHospital;
    public Text InjureTurn;
    public Text player1Cost, player2Cost, player3Cost, player4Cost, player5Cost, player6Cost, player7Cost, player8Cost;

    Text text;
	public static int dice1Number;
	public static int dice2Number;
	public static int dice3Number;
	public int sum;
    public Camera[] camera;
    public static int jail1 = 0, jail2 = 0, jail3 = 0, jail4 = 0, jail5 = 0, jail6 = 0, jail7 = 0, jail8 = 0;
    public static int injure1 = 0, injure2 = 0, injure3 = 0, injure4 = 0, injure5 = 0, injure6 = 0, injure7 = 0, injure8 = 0;
    public static int injure1Turn = 2, injure2Turn = 2, injure3Turn = 2, injure4Turn = 2, injure5Turn = 2, injure6Turn = 2, injure7Turn = 2, injure8Turn = 2;

    public static int whosTurn = 1;
    public static int MaxPeople;
    
    public static bool runOnce = false;
	public static int Redrop = 0;

    public void Start () {

        text = GetComponent<Text> ();
        player1 = GameObject.Find("player1");
        player2 = GameObject.Find("player2");
        player3 = GameObject.Find("player3");
        player4 = GameObject.Find("player4");
        player5 = GameObject.Find("player5");
        player6 = GameObject.Find("player6");
        player7 = GameObject.Find("player7");
        player8 = GameObject.Find("player8");

        ImageForMid = GameObject.Find("ImageForMiddle");
        ImageForRich = GameObject.Find("ImageForRicher");
        ImageForBuyHouse = GameObject.Find("ImageForBuyingHouse");
        ImageForBuyOtherHouse = GameObject.Find("ImageForBuyingOtherHouse");
        ImageForJail = GameObject.Find("ImageForJail");
        ImageForHospital = GameObject.Find("ImageForHospital");
        ImageForHospital.gameObject.SetActive(false);

        dice1 = GameObject.Find("dice");
        dice2 = GameObject.Find("dice2");
        dice3 = GameObject.Find("dice3");
    }
	
	public void Update () {

        sum = int.Parse(dice1Number.ToString()) +int.Parse(dice2Number.ToString()) + int.Parse(dice3Number.ToString());

        text.text = sum.ToString ();

        if(sum == 0)
        {
            runOnce = false;
        }

        if(!runOnce && sum != 0)
        {
            Moving();
        }
    }

    public void Moving()
    {
        MaxPeople = GameControl.numberOfPlayer;
        
        if(MaxPeople == 4)
        {
            FourPeople();
        } 
        else if (MaxPeople == 5)
        {
            FivePeople();
        }
        else if (MaxPeople == 6)
        {
            SixPeople();
        }
        else if (MaxPeople == 7)
        {
            SevenPeople();
        }
        else if (MaxPeople == 8)
        {
            EightPeople();
        }

        whosTurn++;
        runOnce = true;
    }

    public void FourPeople()
    {

        if (whosTurn == 1)
        {
            if (jail1 == 1) {
				if (DiceNumberTextScript.dice1Number == 6) {
                    GameControl.jail1turn = 3;
                    jail1 = 0;
                    GameControl.MovePlayer (1);
					cam1 ();
				} else {
					GameControl.jail1turn--;
                    JailTurn.text = GameControl.jail1turn.ToString();
                    StartCoroutine(TemporarilyDeactivate(2));
                    if (GameControl.jail1turn == 0) {
						jail1 = 0;
                        GameControl.jail1turn = 3;
                    }
					dropButton.interactable = true;
				}
			} else if (injure1 == 1 ){
                injure1Turn--;
                InjureTurn.text = injure1Turn.ToString();
                StartCoroutine(TemporarilyDeactivat2(2));
                if (injure1Turn == 0)
                {
                    injure1 = 0;
                    injure2Turn = 2;
                }     
                dropButton.interactable = true;
            } else
            {
                whosTurn = 0;
                GameControl.MovePlayer(1);
                cam1();
            }
        }
        else if (whosTurn == 2)
        {
            if (jail2 == 1) {
				if (DiceNumberTextScript.dice1Number == 6) {
                    GameControl.jail2turn = 3;
                    jail2 = 0;
                    GameControl.MovePlayer (2);
					cam2 ();
				} else {
					GameControl.jail2turn--;
                    JailTurn.text = GameControl.jail2turn.ToString();
                    StartCoroutine(TemporarilyDeactivate(2));
                    if (GameControl.jail2turn == 0) {
						jail2 = 0;
                        GameControl.jail2turn = 3;
                    }
					dropButton.interactable = true;
				}
            }
            else if (injure2 == 1)
            {
                injure2Turn--;
                InjureTurn.text = injure2Turn.ToString();
                StartCoroutine(TemporarilyDeactivat2(2));
                if (injure2Turn == 0)
                {
                    injure2 = 0;
                    injure2Turn = 2;
                }
                dropButton.interactable = true;
            }
            else
            {
                Debug.Log(Skill.luckydraw);
                if (Skill.luckydraw == 1)
                {
                    if (dice1Number > 3)
                    {
                        HouseSelection.sum2 += 30000;
                        player2Cost.text = HouseSelection.sum2.ToString();
                    }
                    else if (dice1Number <= 3)
                    {
                        HouseSelection.sum2 -= 30000;
                        player2Cost.text = HouseSelection.sum2.ToString();
                    }
                    Skill.luckydraw = 0;
                    whosTurn--;
                    dropButton.interactable = true;
                    GameControl.ImageForMid.gameObject.SetActive(true);
                }
                else
                {
                    GameControl.MovePlayer(2);
                    cam2();
                }
            }
        }
        else if (whosTurn == 3)
        {
            if (jail3 == 1) {
				if (DiceNumberTextScript.dice1Number == 6) {
                    GameControl.jail3turn = 3;
                    jail3 = 0;
                    GameControl.MovePlayer (3);
					cam3 ();
				} else {
					GameControl.jail3turn--;
                    JailTurn.text = GameControl.jail3turn.ToString();
                    StartCoroutine(TemporarilyDeactivate(2));
                    if (GameControl.jail3turn == 0) {
                        GameControl.jail3turn = 3;
                        jail3 = 0;
					}
					dropButton.interactable = true;
				}
            }
            else if (injure3 == 1)
            {
                injure3Turn--;
                InjureTurn.text = injure3Turn.ToString();
                StartCoroutine(TemporarilyDeactivat2(2));
                if (injure3Turn == 0)
                {
                    injure3Turn = 2;
                    injure3 = 0;
                }
                dropButton.interactable = true;
            }
            else
            {
                GameControl.MovePlayer(3);
                cam3();
            }
        }
        else if (whosTurn == 4)
        {
            if (jail4 == 1) {
				if (DiceNumberTextScript.dice1Number == 6) {
                    GameControl.jail4turn = 3;
                    jail4 = 0;
                    GameControl.MovePlayer (4);
					cam4 ();
					whosTurn = 0;
				} else {
					GameControl.jail4turn--;
                    JailTurn.text = GameControl.jail4turn.ToString();
                    StartCoroutine(TemporarilyDeactivate(2));
                    if (GameControl.jail4turn == 0) {
                        GameControl.jail4turn = 3;
                        jail4 = 0;
                    }
					whosTurn = 0;
					dropButton.interactable = true;
				}
            }
            else if (injure4 == 1)
            {
                injure4Turn--;
                InjureTurn.text = injure4Turn.ToString();
                StartCoroutine(TemporarilyDeactivat2(2));
                if (injure4Turn == 0)
                {
                    injure4 = 0;
                    injure4Turn = 2;
                }
                whosTurn = 0;
                dropButton.interactable = true;
            }
            else
            {
                GameControl.MovePlayer(4);
                cam4();
                whosTurn = 0;
            }
        }

    }

    public void FivePeople()
    {
        if (whosTurn == 1)
        {
            if (jail1 == 1)
            {
                if (DiceNumberTextScript.dice1Number == 6)
                {
                    GameControl.jail1turn = 3;
                    jail1 = 0;
                    GameControl.MovePlayer(1);
                    cam1();
                }
                else
                {
                    GameControl.jail1turn--;
                    JailTurn.text = GameControl.jail1turn.ToString();
                    StartCoroutine(TemporarilyDeactivate(2));
                    if (GameControl.jail1turn == 0)
                    {
                        jail1 = 0;
                        GameControl.jail2turn = 3;
                    }
                    dropButton.interactable = true;
                }
            }
            else if (injure1 == 1)
            {
                injure1Turn--;
                InjureTurn.text = injure1Turn.ToString();
                StartCoroutine(TemporarilyDeactivat2(2));
                if (injure1Turn == 0)
                {
                    injure1 = 0;
                    injure1Turn = 2;
                }
                dropButton.interactable = true;
            }
            else
            {
                GameControl.MovePlayer(1);
                cam1();
            }
        }
        else if (whosTurn == 2)
        {
			if (jail2 == 1) {
				if (DiceNumberTextScript.dice1Number == 6) {
                    GameControl.jail2turn = 3;
                    jail2 = 0;
                    GameControl.MovePlayer (2);
					cam2 ();
				} else {
					GameControl.jail2turn--;
                    JailTurn.text = GameControl.jail2turn.ToString();
                    StartCoroutine(TemporarilyDeactivate(2));
                    if (GameControl.jail2turn == 0) {
                        GameControl.jail2turn = 3;
                        jail2 = 0;
					}
					dropButton.interactable = true;
				}
            }
            else if (injure2 == 1)
            {
                injure2Turn--;
                InjureTurn.text = injure2Turn.ToString();
                StartCoroutine(TemporarilyDeactivat2(2));
                if (injure2Turn == 0)
                {
                    injure2Turn = 2;
                    injure2 = 0;
                }
                dropButton.interactable = true;
            }
            else
            {
                if (Skill.luckydraw == 1)
                {
                    if (dice1Number > 3)
                    {
                        HouseSelection.sum2 += 30000;
                        player2Cost.text = HouseSelection.sum2.ToString();
                    }
                    else if (dice1Number <= 3)
                    {
                        HouseSelection.sum2 -= 30000;
                        player2Cost.text = HouseSelection.sum2.ToString();
                    }
                    Skill.luckydraw = 0;
                    whosTurn--;
                    dropButton.interactable = true;
                    GameControl.ImageForMid.gameObject.SetActive(true);
                }
                else
                {
                    GameControl.MovePlayer(2);
                    cam2();
                }
            }
        }
        else if (whosTurn == 3)
        {
			if (jail3 == 1) {
				if (DiceNumberTextScript.dice1Number == 6) {
                    GameControl.jail3turn = 3;
                    jail3 = 0;
                    GameControl.MovePlayer (3);
					cam3 ();
				} else {
					GameControl.jail3turn--;
                    JailTurn.text = GameControl.jail3turn.ToString();
                    StartCoroutine(TemporarilyDeactivate(2));
                    if (GameControl.jail3turn == 0) {
                        GameControl.jail3turn = 3;
                        jail3 = 0;
					}
					dropButton.interactable = true;
				}
            }
            else if (injure3 == 1)
            {
                injure3Turn--;
                InjureTurn.text = injure3Turn.ToString();
                StartCoroutine(TemporarilyDeactivat2(2));
                if (injure3Turn == 0)
                {
                    injure3Turn = 2;
                    injure3 = 0;
                }
                dropButton.interactable = true;
            }
            else
            {
                GameControl.MovePlayer(3);
                cam3();
            }
        }
        else if (whosTurn == 4)
        {
			if (jail4 == 1) {
				if (DiceNumberTextScript.dice1Number == 6) {
                    GameControl.jail4turn = 3;
                    jail4 = 0;
                    GameControl.MovePlayer (4);
					cam4 ();
				} else {
					GameControl.jail4turn--;
                    JailTurn.text = GameControl.jail4turn.ToString();
                    StartCoroutine(TemporarilyDeactivate(2));
                    if (GameControl.jail4turn == 0) {
                        GameControl.jail4turn = 3;
                        jail4 = 0;
					}
					dropButton.interactable = true;
				}
            }
            else if (injure4 == 1)
            {
                injure4Turn--;
                InjureTurn.text = injure4Turn.ToString();
                StartCoroutine(TemporarilyDeactivat2(2));
                if (injure4Turn == 0)
                {
                    injure4Turn = 2;
                    injure4 = 0;
                }
                dropButton.interactable = true;
            }
            else
            {
                GameControl.MovePlayer(4);
                cam4();
            }
        }
        else if (whosTurn == 5)
        {
			if (jail5 == 1) {
				if (DiceNumberTextScript.dice1Number == 6) {
                    GameControl.jail5turn = 3;
                    jail5 = 0;
                    GameControl.MovePlayer (5);
					cam5 ();
					whosTurn = 0;
				} else {
					GameControl.jail5turn--;
                    JailTurn.text = GameControl.jail5turn.ToString();
                    StartCoroutine(TemporarilyDeactivate(2));
                    if (GameControl.jail5turn == 0) {
                        GameControl.jail5turn = 3;
                        jail5 = 0;
					}
                    whosTurn = 0;
                    dropButton.interactable = true;
				}
            }
            else if (injure5 == 1)
            {
                injure5Turn--;
                InjureTurn.text = injure5Turn.ToString();
                StartCoroutine(TemporarilyDeactivat2(2));
                if (injure5Turn == 0)
                {
                    injure5Turn = 2;
                    injure5 = 0;
                }
                dropButton.interactable = true;
                whosTurn = 0;
            }
            else {
				GameControl.MovePlayer (5);
				cam5 ();
				whosTurn = 0;
			}
        }

    }

    public void SixPeople()
    {
        if (whosTurn == 1)
        {
			if (jail1 == 1) {
				if (DiceNumberTextScript.dice1Number == 6) {
                    GameControl.jail1turn = 3;
                    jail1 = 0;
                    GameControl.MovePlayer (1);
					cam1 ();
				} else {
					GameControl.jail1turn--;
                    JailTurn.text = GameControl.jail1turn.ToString();
                    StartCoroutine(TemporarilyDeactivate(2));
                    if (GameControl.jail1turn == 0) {
                        GameControl.jail1turn = 3;
                        jail1 = 0;
					}
					dropButton.interactable = true;
				}
            }
            else if (injure1 == 1)
            {
                injure1Turn--;
                InjureTurn.text = injure1Turn.ToString();
                StartCoroutine(TemporarilyDeactivat2(2));
                if (injure1Turn == 0)
                {
                    injure1Turn = 2;
                    injure1 = 0;
                }
                dropButton.interactable = true;
            }
            else {
				GameControl.MovePlayer (1);
				cam1 ();
			}
        }
        else if (whosTurn == 2)
        {
			if (jail2 == 1) {
				if (DiceNumberTextScript.dice1Number == 6) {
                    GameControl.jail2turn = 3;
                    jail2 = 0;
                    GameControl.MovePlayer (2);
					cam2 ();
				} else {
					GameControl.jail2turn--;
                    JailTurn.text = GameControl.jail2turn.ToString();
                    StartCoroutine(TemporarilyDeactivate(2));
                    if (GameControl.jail2turn == 0) {
                        GameControl.jail2turn = 3;
                        jail2 = 0;
					}
					dropButton.interactable = true;
				}
			}
            else if (injure2 == 1)
            {
                injure2Turn--;
                InjureTurn.text = injure2Turn.ToString();
                StartCoroutine(TemporarilyDeactivat2(2));
                if (injure2Turn == 0)
                {
                    injure2Turn = 2;
                    injure2 = 0;
                }
                dropButton.interactable = true;
            }
            else {
                if (Skill.luckydraw == 1)
                {
                    if (dice1Number > 3)
                    {
                        HouseSelection.sum2 += 30000;
                        player2Cost.text = HouseSelection.sum2.ToString();
                    }
                    else if (dice1Number <= 3)
                    {
                        HouseSelection.sum2 -= 30000;
                        player2Cost.text = HouseSelection.sum2.ToString();
                    }
                    Skill.luckydraw = 0;
                    whosTurn--;
                    dropButton.interactable = true;
                    GameControl.ImageForMid.gameObject.SetActive(true);
                }
                else
                {
                    GameControl.MovePlayer(2);
                    cam2();
                }
            }
        }
        else if (whosTurn == 3)
        {
			if (jail3 == 1) {
				if (DiceNumberTextScript.dice1Number == 6) {
                    GameControl.jail3turn = 3;
                    jail3 = 0;
                    GameControl.MovePlayer (3);
					cam3 ();
				} else {
					GameControl.jail3turn--;
                    JailTurn.text = GameControl.jail3turn.ToString();
                    StartCoroutine(TemporarilyDeactivate(2));
                    if (GameControl.jail3turn == 0) {
						jail3 = 0;
                        GameControl.jail3turn = 3;
                    }
					dropButton.interactable = true;
				}
			}
            else if (injure3 == 1)
            {
                injure3Turn--;
                InjureTurn.text = injure3Turn.ToString();
                StartCoroutine(TemporarilyDeactivat2(2));
                if (injure3Turn == 0)
                {
                    injure3Turn = 2;
                    injure3 = 0;
                }
                dropButton.interactable = true;
            }
            else {
                if (Skill.luckydraw == 1)
                {
                    if (dice1Number > 3)
                    {
                        HouseSelection.sum3 += 30000;
                        player3Cost.text = HouseSelection.sum3.ToString();
                    }
                    else if (dice1Number <= 3)
                    {
                        HouseSelection.sum3 -= 30000;
                        player3Cost.text = HouseSelection.sum3.ToString();
                    }
                    Skill.luckydraw = 0;
                    whosTurn--;
                    dropButton.interactable = true;
                    GameControl.ImageForMid.gameObject.SetActive(true);
                }
                else
                {
                    GameControl.MovePlayer(3);
                    cam3();
                }
            }
        }
        else if (whosTurn == 4)
        {
			if (jail4 == 1) {
				if (DiceNumberTextScript.dice1Number == 6) {
                    GameControl.jail4turn = 3;
                    jail4 = 0;
                    GameControl.MovePlayer (4);
					cam4 ();
				} else {
					GameControl.jail4turn--;
                    JailTurn.text = GameControl.jail4turn.ToString();
                    StartCoroutine(TemporarilyDeactivate(2));
                    if (GameControl.jail4turn == 0) {
						jail4 = 0;
                        GameControl.jail2turn = 3;
                    }
					dropButton.interactable = true;
				}
			}
            else if (injure4 == 1)
            {
                injure4Turn--;
                InjureTurn.text = injure4Turn.ToString();
                StartCoroutine(TemporarilyDeactivat2(2));
                if (injure4Turn == 0)
                {
                    injure4Turn = 2;
                    injure4 = 0;
                }
                dropButton.interactable = true;
            }
            else {
				GameControl.MovePlayer (4);
				cam4 ();
			}
        }
        else if (whosTurn == 5)
        {
			if (jail5 == 1) {
				if (DiceNumberTextScript.dice1Number == 6) {
                    GameControl.jail5turn = 3;
                    jail5 = 0;
                    GameControl.MovePlayer (5);
					cam5 ();
				} else {
					GameControl.jail5turn--;
                    JailTurn.text = GameControl.jail5turn.ToString();
                    StartCoroutine(TemporarilyDeactivate(2));
                    if (GameControl.jail5turn == 0) {
						jail5 = 0;
                        GameControl.jail5turn = 3;
                    }
					dropButton.interactable = true;
				}
			}
            else if (injure5 == 1)
            {
                injure5Turn--;
                InjureTurn.text = injure5Turn.ToString();
                StartCoroutine(TemporarilyDeactivat2(2));
                if (injure5Turn == 0)
                {
                    injure5Turn = 2;
                    injure5 = 0;
                }
                dropButton.interactable = true;
            }
            else {
				GameControl.MovePlayer (5);
				cam5 ();
			}
        }
        else if (whosTurn == 6)
        {
			if (jail6 == 1) {
				if (DiceNumberTextScript.dice1Number == 6) {
                    GameControl.jail6turn = 3;
                    jail6 = 0;
                    GameControl.MovePlayer (6);
					cam6 ();
					whosTurn = 0;
				} else {
					GameControl.jail6turn--;
                    JailTurn.text = GameControl.jail6turn.ToString();
                    StartCoroutine(TemporarilyDeactivate(2));
                    if (GameControl.jail6turn == 0) {
                        GameControl.jail6turn = 3;
                        jail6 = 0;
					}
                    whosTurn = 0;
                    dropButton.interactable = true;
				}
			}
            else if (injure6 == 1)
            {
                injure6Turn--;
                InjureTurn.text = injure6Turn.ToString();
                StartCoroutine(TemporarilyDeactivat2(2));
                if (injure6Turn == 0)
                {
                    injure6Turn = 2;
                    injure6 = 0;
                }
                whosTurn = 0;
                dropButton.interactable = true;
            }
            else {
				GameControl.MovePlayer (6);
				cam6 ();
				whosTurn = 0;
			}
        }

    }

    public void SevenPeople()
    {
        if (whosTurn == 1)
        {
            if (jail1 == 1)
            {
                if (DiceNumberTextScript.dice1Number == 6)
                {
                    GameControl.jail1turn = 3;
                    jail1 = 0;
                    GameControl.MovePlayer(1);
                    cam1();
                }
                else
                {
                    GameControl.jail1turn--;
                    JailTurn.text = GameControl.jail1turn.ToString();
                    StartCoroutine(TemporarilyDeactivate(2));
                    if (GameControl.jail1turn == 0)
                    {
                        jail1 = 0;
                        GameControl.jail1turn = 3;
                    }
                    dropButton.interactable = true;
                }
            }
            else if (injure1 == 1)
            {
                injure1Turn--;
                InjureTurn.text = injure1Turn.ToString();
                StartCoroutine(TemporarilyDeactivat2(2));
                if (injure1Turn == 0)
                {
                    injure1Turn = 2;
                    injure1 = 0;
                }
                dropButton.interactable = true;
            }
            else
            {
                GameControl.MovePlayer(1);
                cam1();
            }
        }
        else if (whosTurn == 2)
        {
            if (jail2 == 1)
            {
                if (DiceNumberTextScript.dice1Number == 6)
                {
                    GameControl.jail2turn = 3;
                    jail2 = 0;
                    GameControl.MovePlayer(2);
                    cam2();
                }
                else
                {
                    GameControl.jail2turn--;
                    JailTurn.text = GameControl.jail2turn.ToString();
                    StartCoroutine(TemporarilyDeactivate(2));
                    if (GameControl.jail2turn == 0)
                    {
                        GameControl.jail2turn = 3;
                        jail2 = 0;
                    }
                    dropButton.interactable = true;
                }
            }
            else if (injure2 == 1)
            {
                injure2Turn--;
                InjureTurn.text = injure2Turn.ToString();
                StartCoroutine(TemporarilyDeactivat2(2));
                if (injure2Turn == 0)
                {
                    injure2Turn = 2;
                    injure2 = 0;
                }
                dropButton.interactable = true;
            }
            else
            {
                if (Skill.luckydraw == 1)
                {
                    if (dice1Number > 3)
                    {
                        HouseSelection.sum2 += 30000;
                        player2Cost.text = HouseSelection.sum2.ToString();
                    }
                    else if (dice1Number <= 3)
                    {
                        HouseSelection.sum2 -= 30000;
                        player2Cost.text = HouseSelection.sum2.ToString();
                    }
                    Skill.luckydraw = 0;
                    whosTurn--;
                    dropButton.interactable = true;
                    GameControl.ImageForMid.gameObject.SetActive(true);
                }
                else
                {
                    GameControl.MovePlayer(2);
                    cam2();
                }
            }
        }
        else if (whosTurn == 3)
        {
            if (jail3 == 1)
            {
                if (DiceNumberTextScript.dice1Number == 6)
                {
                    GameControl.jail3turn = 3;
                    jail3 = 0;
                    GameControl.MovePlayer(3);
                    cam3();
                }
                else
                {
                    GameControl.jail3turn--;
                    JailTurn.text = GameControl.jail3turn.ToString();
                    StartCoroutine(TemporarilyDeactivate(2));
                    if (GameControl.jail3turn == 0)
                    {
                        jail3 = 0;
                        GameControl.jail3turn = 3;
                    }
                    dropButton.interactable = true;
                }
            }
            else if (injure3 == 1)
            {
                injure3Turn--;
                InjureTurn.text = injure3Turn.ToString();
                StartCoroutine(TemporarilyDeactivat2(2));
                if (injure3Turn == 0)
                {
                    injure3Turn = 2;
                    injure3 = 0;
                }
                dropButton.interactable = true;
            }
            else
            {
                if (Skill.luckydraw == 1)
                {
                    if (dice1Number > 3)
                    {
                        HouseSelection.sum3 += 30000;
                        player3Cost.text = HouseSelection.sum3.ToString();
                    }
                    else if (dice1Number <= 3)
                    {
                        HouseSelection.sum3 -= 30000;
                        player3Cost.text = HouseSelection.sum3.ToString();
                    }
                    Skill.luckydraw = 0;
                    whosTurn--;
                    dropButton.interactable = true;
                    GameControl.ImageForMid.gameObject.SetActive(true);
                }
                else
                {
                    GameControl.MovePlayer(2);
                    cam2();
                }
            }
        }
        else if (whosTurn == 4)
        {
            if (jail4 == 1)
            {
                if (DiceNumberTextScript.dice1Number == 6)
                {
                    GameControl.jail4turn = 3;
                    jail4 = 0;
                    GameControl.MovePlayer(4);
                    cam4();
                }
                else
                {
                    GameControl.jail4turn--;
                    JailTurn.text = GameControl.jail4turn.ToString();
                    StartCoroutine(TemporarilyDeactivate(2));
                    if (GameControl.jail4turn == 0)
                    {
                        GameControl.jail4turn = 3;
                        jail4 = 0;
                    }
                    dropButton.interactable = true;
                }
            }
            else if (injure4 == 1)
            {
                injure4Turn--;
                InjureTurn.text = injure4Turn.ToString();
                StartCoroutine(TemporarilyDeactivat2(2));
                if (injure4Turn == 0)
                {
                    injure4Turn = 2;
                    injure4 = 0;
                }
                dropButton.interactable = true;
            }
            else
            {
                GameControl.MovePlayer(4);
                cam4();
            }
        }
        else if (whosTurn == 5)
        {
            if (jail5 == 1)
            {
                if (DiceNumberTextScript.dice1Number == 6)
                {
                    GameControl.jail5turn = 3;
                    jail5 = 0;
                    GameControl.MovePlayer(5);
                    cam5();
                }
                else
                {
                    GameControl.jail5turn--;
                    JailTurn.text = GameControl.jail5turn.ToString();
                    StartCoroutine(TemporarilyDeactivate(2));
                    if (GameControl.jail5turn == 0)
                    {
                        GameControl.jail5turn = 3;
                        jail5 = 0;
                    }
                    dropButton.interactable = true;
                }
            }
            else if (injure5 == 1)
            {
                injure5Turn--;
                InjureTurn.text = injure5Turn.ToString();
                StartCoroutine(TemporarilyDeactivat2(2));
                if (injure5Turn == 0)
                {
                    injure5Turn = 2;
                    injure5 = 0;
                }
                dropButton.interactable = true;
            }
            else
            {
                GameControl.MovePlayer(5);
                cam5();
            }
        }
        else if (whosTurn == 6)
        {
            if (jail6 == 1)
            {
                if (DiceNumberTextScript.dice1Number == 6)
                {
                    GameControl.jail6turn = 3;
                    jail6 = 0;
                    GameControl.MovePlayer(6);
                    cam6();
                }
                else
                {
                    GameControl.jail6turn--;
                    JailTurn.text = GameControl.jail6turn.ToString();
                    StartCoroutine(TemporarilyDeactivate(2));
                    if (GameControl.jail6turn == 0)
                    {
                        jail6 = 0;
                        GameControl.jail6turn = 3;
                    }
                    whosTurn = 0;
                    dropButton.interactable = true;
                }
            }
            else if (injure6 == 1)
            {
                injure6Turn--;
                InjureTurn.text = injure6Turn.ToString();
                StartCoroutine(TemporarilyDeactivat2(2));
                if (injure6Turn == 0)
                {
                    injure6Turn = 2;
                    injure6 = 0;
                }
                dropButton.interactable = true;
            }
            else
            {
                GameControl.MovePlayer(6);
                cam6();
            }
        }
        else if (whosTurn == 7)
        {
			if (jail7 == 1) {
				if (DiceNumberTextScript.dice1Number == 6) {
                    GameControl.jail7turn = 3;
                    jail7 = 0;
                    GameControl.MovePlayer (7);
					cam7 ();
					whosTurn = 0;
				} else {
					GameControl.jail7turn--;
                    JailTurn.text = GameControl.jail7turn.ToString();
                    StartCoroutine(TemporarilyDeactivate(2));
                    if (GameControl.jail7turn == 0) {
                        GameControl.jail7turn = 3;
                        jail7 = 0;
					}
                    whosTurn = 0;
                    dropButton.interactable = true;
				}
			}
            else if (injure7 == 1)
            {
                injure7Turn--;
                InjureTurn.text = injure7Turn.ToString();
                StartCoroutine(TemporarilyDeactivat2(2));
                if (injure7Turn == 0)
                {
                    injure7Turn = 2;
                    injure7 = 0;
                }
                whosTurn = 0;
                dropButton.interactable = true;
            }
            else {
				GameControl.MovePlayer (7);
				cam7 ();
                whosTurn = 0;
			}
        }
    }

    public void EightPeople()
    {
        if (whosTurn == 1)
        {
            if (jail1 == 1)
            {
                if (DiceNumberTextScript.dice1Number == 6)
                {
                    GameControl.jail1turn = 3;
                    jail1 = 0;
                    GameControl.MovePlayer(1);
                    cam1();
                }
                else
                {
                    GameControl.jail1turn--;
                    JailTurn.text = GameControl.jail1turn.ToString();
                    StartCoroutine(TemporarilyDeactivate(2));
                    if (GameControl.jail1turn == 0)
                    {
                        jail1 = 0;
                        GameControl.jail1turn = 3;
                    }
                    dropButton.interactable = true;
                }
            }
            else if (injure1 == 1)
            {
                injure1Turn--;
                InjureTurn.text = injure1Turn.ToString();
                StartCoroutine(TemporarilyDeactivat2(2));
                if (injure1Turn == 0)
                {
                    injure1Turn = 2;
                    injure1 = 0;
                }
                dropButton.interactable = true;
            }
            else
            {
                GameControl.MovePlayer(1);
                cam1();
            }
        }
        else if (whosTurn == 2)
        {
            if (jail2 == 1)
            {
                if (DiceNumberTextScript.dice1Number == 6)
                {
                    GameControl.jail2turn = 3;
                    jail2 = 0;
                    GameControl.MovePlayer(2);
                    cam2();
                }
                else
                {
                    GameControl.jail2turn--;
                    JailTurn.text = GameControl.jail2turn.ToString();
                    StartCoroutine(TemporarilyDeactivate(2));
                    if (GameControl.jail2turn == 0)
                    {
                        GameControl.jail2turn = 3;
                        jail2 = 0;
                    }
                    dropButton.interactable = true;
                }
            }
            else if (injure2 == 1)
            {
                injure2Turn--;
                InjureTurn.text = injure2Turn.ToString();
                StartCoroutine(TemporarilyDeactivat2(2));
                if (injure2Turn == 0)
                {
                    injure2Turn = 2;
                    injure2 = 0;
                }
                dropButton.interactable = true;
            }
            else
            {
                if (Skill.luckydraw == 1)
                {
                    if (dice1Number > 3)
                    {
                        HouseSelection.sum2 += 30000;
                        player2Cost.text = HouseSelection.sum2.ToString();
                    }
                    else if (dice1Number <= 3)
                    {
                        HouseSelection.sum2 -= 30000;
                        player2Cost.text = HouseSelection.sum2.ToString();
                    }
                    Skill.luckydraw = 0;
                    whosTurn--;
                    dropButton.interactable = true;
                    GameControl.ImageForMid.gameObject.SetActive(true);
                }
                else
                {
                    GameControl.MovePlayer(2);
                    cam2();
                }
            }
        }
        else if (whosTurn == 3)
        {
            if (jail3 == 1)
            {
                if (DiceNumberTextScript.dice1Number == 6)
                {
                    GameControl.jail3turn = 3;
                    jail3 = 0;
                    GameControl.MovePlayer(3);
                    cam3();
                }
                else
                {
                    GameControl.jail3turn--;
                    JailTurn.text = GameControl.jail3turn.ToString();
                    StartCoroutine(TemporarilyDeactivate(2));
                    if (GameControl.jail3turn == 0)
                    {
                        jail3 = 0;
                        GameControl.jail3turn = 3;
                    }
                    dropButton.interactable = true;
                }
            }
            else if (injure3 == 1)
            {
                injure3Turn--;
                InjureTurn.text = injure3Turn.ToString();
                StartCoroutine(TemporarilyDeactivat2(2));
                if (injure3Turn == 0)
                {
                    injure3Turn = 2;
                    injure3 = 0;
                }
                dropButton.interactable = true;
            }
            else
            {
                if (Skill.luckydraw == 1)
                {
                    if (dice1Number > 3)
                    {
                        HouseSelection.sum3 += 30000;
                        player3Cost.text = HouseSelection.sum3.ToString();
                    }
                    else if (dice1Number <= 3)
                    {
                        HouseSelection.sum3 -= 30000;
                        player3Cost.text = HouseSelection.sum3.ToString();
                    }
                    Skill.luckydraw = 0;
                    whosTurn--;
                    dropButton.interactable = true;
                    GameControl.ImageForMid.gameObject.SetActive(true);
                }
                else
                {
                    GameControl.MovePlayer(2);
                    cam2();
                }
            }
        }
        else if (whosTurn == 4)
        {
            if (jail4 == 1)
            {
                if (DiceNumberTextScript.dice1Number == 6)
                {
                    GameControl.jail4turn = 3;
                    jail4 = 0;
                    GameControl.MovePlayer(4);
                    cam4();
                }
                else
                {
                    GameControl.jail4turn--;
                    JailTurn.text = GameControl.jail4turn.ToString();
                    StartCoroutine(TemporarilyDeactivate(2));
                    if (GameControl.jail4turn == 0)
                    {
                        GameControl.jail4turn = 3;
                        jail4 = 0;
                    }
                    dropButton.interactable = true;
                }
            }
            else if (injure4 == 1)
            {
                injure4Turn--;
                InjureTurn.text = injure4Turn.ToString();
                StartCoroutine(TemporarilyDeactivat2(2));
                if (injure4Turn == 0)
                {
                    injure4Turn = 2;
                    injure4 = 0;
                }
                dropButton.interactable = true;
            }
            else
            {
                GameControl.MovePlayer(4);
                cam4();
            }
        }
        else if (whosTurn == 5)
        {
            if (jail5 == 1)
            {
                if (DiceNumberTextScript.dice1Number == 6)
                {
                    GameControl.jail5turn = 3;
                    jail5 = 0;
                    GameControl.MovePlayer(5);
                    cam5();
                }
                else
                {
                    GameControl.jail5turn--;
                    JailTurn.text = GameControl.jail5turn.ToString();
                    StartCoroutine(TemporarilyDeactivate(2));
                    if (GameControl.jail5turn == 0)
                    {
                        GameControl.jail5turn = 3;
                        jail5 = 0;
                    }
                    dropButton.interactable = true;
                }
            }
            else if (injure5 == 1)
            {
                injure5Turn--;
                InjureTurn.text = injure5Turn.ToString();
                StartCoroutine(TemporarilyDeactivat2(2));
                if (injure5Turn == 0)
                {
                    injure5Turn = 2;
                    injure5 = 0;
                }
                dropButton.interactable = true;
            }
            else
            {
                GameControl.MovePlayer(5);
                cam5();
            }
        }
        else if (whosTurn == 6)
        {
            if (jail6 == 1)
            {
                if (DiceNumberTextScript.dice1Number == 6)
                {
                    GameControl.jail6turn = 3;
                    jail6 = 0;
                    GameControl.MovePlayer(6);
                    cam6();
                }
                else
                {
                    GameControl.jail6turn--;
                    JailTurn.text = GameControl.jail6turn.ToString();
                    StartCoroutine(TemporarilyDeactivate(2));
                    if (GameControl.jail6turn == 0)
                    {
                        GameControl.jail6turn = 3;
                        jail6 = 0;
                    }
                    whosTurn = 0;
                    dropButton.interactable = true;
                }
            }
            else if (injure6 == 1)
            {
                injure6Turn--;
                InjureTurn.text = injure6Turn.ToString();
                StartCoroutine(TemporarilyDeactivat2(2));
                if (injure6Turn == 0)
                {
                    injure6Turn = 2;
                    injure6 = 0;
                }
                dropButton.interactable = true;
            }
            else
            {
                GameControl.MovePlayer(6);
                cam6();
            }
        }
        else if (whosTurn == 7)
        {
            if (jail7 == 1)
            {
                if (DiceNumberTextScript.dice1Number == 6)
                {
                    GameControl.jail7turn = 3;
                    jail7 = 0;
                    GameControl.MovePlayer(7);
                    cam7();
                }
                else
                {
                    GameControl.jail7turn--;
                    JailTurn.text = GameControl.jail7turn.ToString();
                    StartCoroutine(TemporarilyDeactivate(2));
                    if (GameControl.jail7turn == 0)
                    {
                        GameControl.jail7turn = 3;
                        jail7 = 0;
                    }
                    whosTurn = 0;
                    dropButton.interactable = true;
                }
            }
            else if (injure7 == 1)
            {
                injure7Turn--;
                InjureTurn.text = injure7Turn.ToString();
                StartCoroutine(TemporarilyDeactivat2(2));
                if (injure7Turn == 0)
                {
                    injure7Turn = 2;
                    injure7 = 0;
                }
                dropButton.interactable = true;
            }
            else
            {
                GameControl.MovePlayer(7);
                cam7();
            }
        }
        else if (whosTurn == 8)
        {
			if (jail8 == 1) {
				if (DiceNumberTextScript.dice1Number == 6) {
                    GameControl.jail8turn = 3;
                    jail8 = 0;
                    GameControl.MovePlayer (8);
					cam8 ();
					whosTurn = 0;
				} else {
					GameControl.jail8turn--;
                    JailTurn.text = GameControl.jail8turn.ToString();
                    StartCoroutine(TemporarilyDeactivate(2));
                    if (GameControl.jail8turn == 0) {
						jail8 = 0;
                        GameControl.jail8turn = 3;
                    }
                    whosTurn = 0;
                    dropButton.interactable = true;
				}
			}
            else if (injure8 == 1)
            {
                injure8Turn--;
                InjureTurn.text = injure8Turn.ToString();
                StartCoroutine(TemporarilyDeactivat2(2));
                if (injure8Turn == 0)
                {
                    injure8Turn = 2;
                    injure8 = 0;
                }
                whosTurn = 0;
                dropButton.interactable = true;
            }
            else {
				GameControl.MovePlayer(8);
				cam8 ();
				whosTurn = 0;
			}
        }
    }

    public void camMain()
    {
        camera[0].enabled = true; //
        camera[1].enabled = false;
        camera[2].enabled = false;
        camera[3].enabled = false;
        camera[4].enabled = false;
        camera[5].enabled = false;
        camera[6].enabled = false;
        camera[7].enabled = false;
        camera[8].enabled = false;
    }

    public void cam1()
    {
        camera[0].enabled = false;
        camera[1].enabled = true; //
        camera[2].enabled = false;
        camera[3].enabled = false;
        camera[4].enabled = false;
        camera[5].enabled = false;
        camera[6].enabled = false;
        camera[7].enabled = false;
        camera[8].enabled = false;
		FollowThePath.whosTurn = 1;
    }
   
    public void cam2()
    {
        camera[0].enabled = false;
        camera[1].enabled = false;
        camera[2].enabled = true; //
        camera[3].enabled = false;
        camera[4].enabled = false;
        camera[5].enabled = false;
        camera[6].enabled = false;
        camera[7].enabled = false;
        camera[8].enabled = false;
		FollowThePath.whosTurn = 2;
    }

    public void cam3()
    {
        camera[0].enabled = false;
        camera[1].enabled = false;
        camera[2].enabled = false;
        camera[3].enabled = true; //
        camera[4].enabled = false;
        camera[5].enabled = false;
        camera[6].enabled = false;
        camera[7].enabled = false;
        camera[8].enabled = false;
		FollowThePath.whosTurn = 3;
    }

    public void cam4()
    {
        camera[0].enabled = false;
        camera[1].enabled = false;
        camera[2].enabled = false;
        camera[3].enabled = false;
        camera[4].enabled = true; // 
        camera[5].enabled = false;
        camera[6].enabled = false;
        camera[7].enabled = false;
        camera[8].enabled = false;
		FollowThePath.whosTurn = 4;
    }

    public void cam5()
    {
        camera[0].enabled = false;
        camera[1].enabled = false;
        camera[2].enabled = false;
        camera[3].enabled = false;
        camera[4].enabled = false;
        camera[5].enabled = true; //
        camera[6].enabled = false;
        camera[7].enabled = false;
        camera[8].enabled = false;
		FollowThePath.whosTurn = 5;
    }

    public void cam6()
    {
        camera[0].enabled = false;
        camera[1].enabled = false;
        camera[2].enabled = false;
        camera[3].enabled = false;
        camera[4].enabled = false;
        camera[5].enabled = false;
        camera[6].enabled = true; //
        camera[7].enabled = false;
        camera[8].enabled = false;
		FollowThePath.whosTurn = 6;
    }

    public void cam7()
    {
        camera[0].enabled = false;
        camera[1].enabled = false;
        camera[2].enabled = false;
        camera[3].enabled = false;
        camera[4].enabled = false;
        camera[5].enabled = false;
        camera[6].enabled = false;
        camera[7].enabled = true; //;
        camera[8].enabled = false;
		FollowThePath.whosTurn = 7;
    }

    public void cam8()
    {
        camera[0].enabled = false;
        camera[1].enabled = false;
        camera[2].enabled = false;
        camera[3].enabled = false;
        camera[4].enabled = false;
        camera[5].enabled = false;
        camera[6].enabled = false;
        camera[7].enabled = false;
        camera[8].enabled = true; //
		FollowThePath.whosTurn = 8;
    }

    private IEnumerator TemporarilyDeactivate(float duration)
    {
        ImageForJail.gameObject.SetActive(true);
        yield return new WaitForSeconds(duration);
        ImageForJail.gameObject.SetActive(false);
    }

    private IEnumerator TemporarilyDeactivat2(float duration)
    {
        ImageForHospital.gameObject.SetActive(true);
        yield return new WaitForSeconds(duration);
        ImageForHospital.gameObject.SetActive(false);
    }
}
