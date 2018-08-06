using System.Collections;
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

    Text text;
	public static int dice1Number;
	public static int dice2Number;
	public static int dice3Number;
	public int sum;
    public Camera[] camera;
    public static int jail1 = 0, jail2 = 0, jail3 = 0, jail4 = 0, jail5 = 0, jail6 = 0, jail7 = 0, jail8 = 0;

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
					GameControl.MovePlayer (1);
					cam1 ();
				} else {
					GameControl.jail1turn--;
					if(GameControl.jail1turn == 0) {
						jail1 = 0;
					}
					whosTurn++;
					dropButton.interactable = true;
				}

			} else {
				GameControl.MovePlayer (1);
				cam1 ();
			}
        }
        else if (whosTurn == 2)
        {	
			if (jail2 == 1) {
				if (DiceNumberTextScript.dice1Number == 6) {
					GameControl.MovePlayer (2);
					cam2 ();
				} else {
					GameControl.jail2turn--;
					if(GameControl.jail2turn == 0) {
						jail2 = 0;
					}
					whosTurn++;
					dropButton.interactable = true;
				}
			} else {
				GameControl.MovePlayer (2);
				cam2 ();
			}
        }
        else if (whosTurn == 3)
        {
			if (jail3 == 1) {
				if (DiceNumberTextScript.dice1Number == 6) {
					GameControl.MovePlayer (3);
					cam3 ();
				} else {
					GameControl.jail3turn--;
					if(GameControl.jail3turn == 0) {
						jail3 = 0;
					}
					whosTurn++;
					dropButton.interactable = true;
				}
			} else {
				GameControl.MovePlayer (3);
				cam3 ();
			}
        }
        else if (whosTurn == 4)
        {
			if (jail4 == 1) {
				if (DiceNumberTextScript.dice1Number == 6) {
					GameControl.MovePlayer (4);
					cam4 ();
					whosTurn = 0;
				} else {
					GameControl.jail4turn--;
					if(GameControl.jail4turn == 0) {
						jail4 = 0;
					}
					whosTurn = 0;
					dropButton.interactable = true;
				}
			} else {
				GameControl.MovePlayer (4);
				cam4 ();
				whosTurn = 0;
			}
        }

    }

    public void FivePeople()
    {
        if (whosTurn == 1)
        {
			if (jail1 == 1) {
				if (DiceNumberTextScript.dice1Number == 6) {
					GameControl.MovePlayer (1);
					cam1 ();
				} else {
					GameControl.jail1turn--;
					if(GameControl.jail1turn == 0) {
						jail1 = 0;
					}
					whosTurn++;
					dropButton.interactable = true;
				}
			} else {
				GameControl.MovePlayer (1);
				cam1 ();
			}
        }
        else if (whosTurn == 2)
        {
			if (jail2 == 1) {
				if (DiceNumberTextScript.dice1Number == 6) {
					GameControl.MovePlayer (2);
					cam2 ();
				} else {
					GameControl.jail2turn--;
					if(GameControl.jail2turn == 0) {
						jail2 = 0;
					}
					whosTurn++;
					dropButton.interactable = true;
				}
			} else {
				GameControl.MovePlayer (2);
				cam2 ();
			}
        }
        else if (whosTurn == 3)
        {
			if (jail2 == 1) {
				if (DiceNumberTextScript.dice1Number == 6) {
					GameControl.MovePlayer (2);
					cam2 ();
				} else {
					GameControl.jail3turn--;
					if(GameControl.jail3turn == 0) {
						jail3 = 0;
					}
					whosTurn++;
					dropButton.interactable = true;
				}
			} else {
				GameControl.MovePlayer (2);
				cam2 ();
			}
        }
        else if (whosTurn == 4)
        {
			if (jail4 == 1) {
				if (DiceNumberTextScript.dice1Number == 6) {
					GameControl.MovePlayer (4);
					cam4 ();
				} else {
					GameControl.jail4turn--;
					if(GameControl.jail4turn == 0) {
						jail4 = 0;
					}
					whosTurn++;
					dropButton.interactable = true;
				}
			} else {
				GameControl.MovePlayer (4);
				cam4 ();
			}
        }
        else if (whosTurn == 5)
        {
			if (jail5 == 1) {
				if (DiceNumberTextScript.dice1Number == 6) {
					GameControl.MovePlayer (5);
					cam5 ();
					whosTurn = 0;
				} else {
					GameControl.jail5turn--;
					if(GameControl.jail5turn == 0) {
						jail5 = 0;
					}
                    whosTurn = 0;
                    dropButton.interactable = true;
				}
			} else {
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
					GameControl.MovePlayer (1);
					cam1 ();
				} else {
					GameControl.jail1turn--;
					if(GameControl.jail1turn == 0) {
						jail1 = 0;
					}
					whosTurn++;
					dropButton.interactable = true;
				}
			} else {
				GameControl.MovePlayer (1);
				cam1 ();
			}
        }
        else if (whosTurn == 2)
        {
			if (jail2 == 1) {
				if (DiceNumberTextScript.dice1Number == 6) {
					GameControl.MovePlayer (2);
					cam2 ();
				} else {
					GameControl.jail2turn--;
					if(GameControl.jail2turn == 0) {
						jail2 = 0;
					}
					whosTurn++;
					dropButton.interactable = true;
				}
			} else {
				GameControl.MovePlayer (2);
				cam2 ();
			}
        }
        else if (whosTurn == 3)
        {
			if (jail3 == 1) {
				if (DiceNumberTextScript.dice1Number == 6) {
					GameControl.MovePlayer (3);
					cam3 ();
				} else {
					GameControl.jail3turn--;
					if(GameControl.jail3turn == 0) {
						jail3 = 0;
					}
					whosTurn++;
					dropButton.interactable = true;
				}
			} else {
				GameControl.MovePlayer (3);
				cam3 ();
			}
        }
        else if (whosTurn == 4)
        {
			if (jail4 == 1) {
				if (DiceNumberTextScript.dice1Number == 6) {
					GameControl.MovePlayer (4);
					cam4 ();
				} else {
					GameControl.jail4turn--;
					if(GameControl.jail4turn == 0) {
						jail4 = 0;
					}
					whosTurn++;
					dropButton.interactable = true;
				}
			} else {
				GameControl.MovePlayer (4);
				cam4 ();
			}
        }
        else if (whosTurn == 5)
        {
			if (jail5 == 1) {
				if (DiceNumberTextScript.dice1Number == 6) {
					GameControl.MovePlayer (5);
					cam5 ();
				} else {
					GameControl.jail5turn--;
					if(GameControl.jail5turn == 0) {
						jail5 = 0;
					}
					whosTurn++;
					dropButton.interactable = true;
				}
			} else {
				GameControl.MovePlayer (5);
				cam5 ();
			}
        }
        else if (whosTurn == 6)
        {
			if (jail6 == 1) {
				if (DiceNumberTextScript.dice1Number == 6) {
					GameControl.MovePlayer (6);
					cam6 ();
					whosTurn = 0;
				} else {
					GameControl.jail6turn--;
					if(GameControl.jail6turn == 0) {
						jail6 = 0;
					}
                    whosTurn = 0;
                    dropButton.interactable = true;
				}
			} else {
				GameControl.MovePlayer (1);
				cam6 ();
				whosTurn = 0;
			}
        }

    }

    public void SevenPeople()
    {
        if (whosTurn == 1)
        {
			if (jail1 == 1) {
				if (DiceNumberTextScript.dice1Number == 6) {
					GameControl.MovePlayer (1);
					cam1 ();
				} else {
					GameControl.jail1turn--;
					if(GameControl.jail1turn == 0) {
						jail1 = 0;
					}
					whosTurn++;
					dropButton.interactable = true;
				}
			} else {
				GameControl.MovePlayer (1);
				cam1 ();
			}
        }
        else if (whosTurn == 2)
        {
			if (jail2 == 1) {
				if (DiceNumberTextScript.dice1Number == 6) {
					GameControl.MovePlayer (2);
					cam2 ();
				} else {
					GameControl.jail2turn--;
					if(GameControl.jail2turn == 0) {
						jail2 = 0;
					}
					whosTurn++;
					dropButton.interactable = true;
				}
			} else {
				GameControl.MovePlayer (2);
				cam2 ();
			}
        }
        else if (whosTurn == 3)
        {
			if (jail3 == 1) {
				if (DiceNumberTextScript.dice1Number == 6) {
					GameControl.MovePlayer (3);
					cam3 ();
				} else {
					GameControl.jail3turn--;
					if(GameControl.jail3turn == 0) {
						jail3 = 0;
					}
					whosTurn++;
					dropButton.interactable = true;
				}
			} else {
				GameControl.MovePlayer (3);
				cam3 ();
			}
        }
        else if (whosTurn == 4)
        {
			if (jail4 == 1) {
				if (DiceNumberTextScript.dice1Number == 6) {
					GameControl.MovePlayer (4);
					cam4 ();
				} else {
					GameControl.jail4turn--;
					if(GameControl.jail4turn == 0) {
						jail4 = 0;
					}
					whosTurn++;
					dropButton.interactable = true;
				}
			} else {
				GameControl.MovePlayer (4);
				cam4 ();
			}
        }
        else if (whosTurn == 5)
        {
			if (jail5 == 1) {
				if (DiceNumberTextScript.dice1Number == 6) {
					GameControl.MovePlayer (5);
					cam5 ();
				} else {
					GameControl.jail5turn--;
					if(GameControl.jail5turn == 0) {
						jail5 = 0;
					}
					whosTurn++;
					dropButton.interactable = true;
				}
			} else {
				GameControl.MovePlayer (5);
				cam5 ();
			}
        }
        else if (whosTurn == 6)
        {
			if (jail6 == 1) {
				if (DiceNumberTextScript.dice1Number == 6) {
					GameControl.MovePlayer (6);
					cam6 ();
				} else {
					GameControl.jail6turn--;
					if(GameControl.jail6turn == 0) {
						jail6 = 0;
					}
					whosTurn++;
					dropButton.interactable = true;
				}
			} else {
				GameControl.MovePlayer (6);
				cam6 ();
			}
        }
        else if (whosTurn == 7)
        {
			if (jail7 == 1) {
				if (DiceNumberTextScript.dice1Number == 6) {
					GameControl.MovePlayer (7);
					cam7 ();
					whosTurn = 0;
				} else {
					GameControl.jail7turn--;
					if(GameControl.jail7turn == 0) {
						jail7 = 0;
					}
                    whosTurn = 0;
                    dropButton.interactable = true;
				}
			} else {
				GameControl.MovePlayer (7);
				cam7 ();
			}
        }
    }

    public void EightPeople()
    {
        if (whosTurn == 1)
        {
			if (jail1 == 1) {
				if (DiceNumberTextScript.dice1Number == 6) {
					GameControl.MovePlayer (1);
					cam1 ();
				} else {
					GameControl.jail1turn--;
					if(GameControl.jail1turn == 0) {
						jail1 = 0;
					}
					whosTurn++;
					dropButton.interactable = true;
				}
			} else {
				GameControl.MovePlayer (1);
				cam1 ();
			}
        }
        else if (whosTurn == 2)
        {
			if (jail2 == 1) {
				if (DiceNumberTextScript.dice1Number == 6) {
					GameControl.MovePlayer (2);
					cam2 ();
				} else {
					GameControl.jail2turn--;
					if(GameControl.jail2turn == 0) {
						jail2 = 0;
					}
					whosTurn++;
					dropButton.interactable = true;
				}
			} else {
				GameControl.MovePlayer (2);
				cam2 ();
			}
        }
        else if (whosTurn == 3)
        {
			if (jail3 == 1) {
				if (DiceNumberTextScript.dice1Number == 6) {
					GameControl.MovePlayer (3);
					cam3 ();
				} else {
					GameControl.jail3turn--;
					if(GameControl.jail3turn == 0) {
						jail3 = 0;
					}
					whosTurn++;
					dropButton.interactable = true;
				}
			} else {
				GameControl.MovePlayer (3);
				cam3 ();
			}
        }
        else if (whosTurn == 4)
        {
			if (jail4 == 1) {
				if (DiceNumberTextScript.dice1Number == 6) {
					GameControl.MovePlayer (4);
					cam4 ();
				} else {
					GameControl.jail4turn--;
					if(GameControl.jail4turn == 0) {
						jail4 = 0;
					}
					whosTurn++;
					dropButton.interactable = true;
				}
			} else {
				GameControl.MovePlayer (4);
				cam4 ();
			}
        }
        else if (whosTurn == 5)
        {
			if (jail5 == 1) {
				if (DiceNumberTextScript.dice1Number == 6) {
					GameControl.MovePlayer (5);
					cam5 ();
				} else {
					GameControl.jail5turn--;
					if(GameControl.jail5turn == 0) {
						jail5 = 0;
					}
					whosTurn++;
					dropButton.interactable = true;
				}
			} else {
				GameControl.MovePlayer (5);
				cam5 ();
			}
        }
        else if (whosTurn == 6)
        {
			if (jail6 == 1) {
				if (DiceNumberTextScript.dice1Number == 6) {
					GameControl.MovePlayer (6);
					cam6 ();
				} else {
					GameControl.jail6turn--;
					if(GameControl.jail6turn == 0) {
						jail6 = 0;
					}
					whosTurn++;
					dropButton.interactable = true;
				}
			} else {
				GameControl.MovePlayer (6);
				cam6 ();
			}
        }
        else if (whosTurn == 7)
        {
			if (jail7 == 1) {
				if (DiceNumberTextScript.dice1Number == 6) {
					GameControl.MovePlayer (7);
					cam7 ();
				} else {
					GameControl.jail7turn--;
					if(GameControl.jail7turn == 0) {
						jail7 = 0;
					}
					whosTurn++;
					dropButton.interactable = true;
				}
			} else {
				GameControl.MovePlayer (7);
				cam7 ();
			}
        }
        else if (whosTurn == 8)
        {
			if (jail8 == 1) {
				if (DiceNumberTextScript.dice1Number == 6) {
					GameControl.MovePlayer (8);
					cam8 ();
					whosTurn = 0;
				} else {
					GameControl.jail8turn--;
					if(GameControl.jail8turn == 0) {
						jail8 = 0;
					}
                    whosTurn = 0;
                    dropButton.interactable = true;
				}
			} else {
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
	/*
    void Jail()
    {
        if (whosTurn + 1 == 2)
        {
            if (jail2 == 1)
            {
                GameControl.jail2turn--;
                JailTurn.text = GameControl.jail2turn.ToString();
                if(GameControl.jail2turn == 0)
                {
                    GameControl.jail2turn = 3;
                    jail2 = 0;
                }
                whosTurn++;
            }
        }

        if (whosTurn + 1 == 3)
        {
            if (jail3 == 1)
            {
                GameControl.jail3turn--;
                JailTurn.text = GameControl.jail3turn.ToString();
                whosTurn++;
                if (GameControl.jail3turn == 0)
                {
                    GameControl.jail3turn = 3;
                    jail3 = 0;
                }
            }
        }

        if (whosTurn + 1 == 4)
        {
            if (jail4 == 1)
            {
                GameControl.jail4turn--;
                JailTurn.text = GameControl.jail4turn.ToString();
                if (GameControl.jail4turn == 0)
                {
                    GameControl.jail4turn = 3;
                    jail4 = 0;
                }
				if (MaxPeople == 4) {
					whosTurn = 0;
				} else {
					whosTurn++;

				} 
            }
        }

        if (whosTurn + 1 == 5)
        {
            if (jail5 == 1)
            {
                GameControl.jail5turn--;
                JailTurn.text = GameControl.jail5turn.ToString();
                if (GameControl.jail5turn == 0)
                {
                    GameControl.jail5turn = 3;
                    jail5 = 0;
                }
				if (MaxPeople == 5) {
					whosTurn = 0;
				} else {
					whosTurn++;
				}
            }
        }

        if (whosTurn + 1 == 6)
        {
            if (jail6 == 1)
            {
                GameControl.jail6turn--;
                JailTurn.text = GameControl.jail6turn.ToString();
                if (GameControl.jail6turn == 0)
                {
                    GameControl.jail6turn = 3;
                    jail6 = 0;
                }
				if (MaxPeople == 5) {
					whosTurn = 0;
				} else {
					whosTurn++;
				}
            }
        }

        if (whosTurn + 1 == 7)
        {
            if (jail7 == 1)
            {
                GameControl.jail7turn--;
                JailTurn.text = GameControl.jail7turn.ToString();
                if (GameControl.jail7turn == 0)
                {
                    GameControl.jail7turn = 3;
                    jail7 = 0;
                }
				if (MaxPeople == 6) {
					whosTurn = 0;
				} else {
					whosTurn++;
				}
            }
        }

        if (whosTurn + 1 == 8)
        {
            if (jail8 == 1)
            {
                GameControl.jail8turn--;
                JailTurn.text = GameControl.jail8turn.ToString();
                if (GameControl.jail8turn == 0)
                {
                    GameControl.jail8turn = 3;
                    jail8 = 0;
                }
				if (MaxPeople == 7) {
					whosTurn = 1;
				} else {
					whosTurn = 0;
				}
            }
        }

        if (whosTurn -3 == 1 || whosTurn - 4 == 1 || whosTurn -5 == 1 || whosTurn -6 == 1 || whosTurn -7 == 1)
        {
            if(whosTurn == 4 && MaxPeople == 4)
            {
                if (jail1 == 1)
                {
                    GameControl.jail1turn--;
                    JailTurn.text = GameControl.jail1turn.ToString();
                    if (GameControl.jail1turn == 0)
                    {
                        GameControl.jail1turn = 3;
                        jail1 = 0;
					} 
                    whosTurn = 1;
                }
            }
            if (whosTurn == 5 && MaxPeople == 5)
            {
                if (jail1 == 1)
                {
                    GameControl.jail1turn--;
                    JailTurn.text = GameControl.jail1turn.ToString();
                    if (GameControl.jail1turn == 0)
                    {
                        GameControl.jail1turn = 3;
                        jail1 = 0;
                    }
                    whosTurn = 1;
                }
            }
            if (whosTurn == 6 && MaxPeople == 6)
            {
                if (jail1 == 1)
                {
                    GameControl.jail1turn--;
                    JailTurn.text = GameControl.jail1turn.ToString();
                    if (GameControl.jail1turn == 0)
                    {
                        GameControl.jail1turn = 3;
                        jail1 = 0;
                    }
                    whosTurn = 1;
                }
            }
            if (whosTurn == 7 && MaxPeople == 7)
            {
                if (jail1 == 1)
                {
                    GameControl.jail1turn--;
                    JailTurn.text = GameControl.jail1turn.ToString();
                    if (ImageForBuyHouse.activeSelf == false && ImageForBuyOtherHouse == false && ImageForMid == false && ImageForRich == false)
                    if (GameControl.jail1turn == 0)
                    {
                        GameControl.jail1turn = 3;
                        jail1 = 0;
                    }
                    whosTurn = 1;
                }
            }
            if (whosTurn == 7 && MaxPeople == 7)
            {
                if (jail1 == 1)
                {
                    GameControl.jail1turn--;
                    JailTurn.text = GameControl.jail1turn.ToString();
                    if (ImageForBuyHouse.activeSelf == false && ImageForBuyOtherHouse == false && ImageForMid == false && ImageForRich == false)
                    if (GameControl.jail1turn == 0)
                    {
                        GameControl.jail1turn = 3;
                        jail1 = 0;
                    }
                    whosTurn = 1;
                }
            }

        }

    }*/


}
