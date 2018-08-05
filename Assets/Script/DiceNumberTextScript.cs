using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceNumberTextScript : MonoBehaviour {

    public static GameObject player1, player2, player3, player4, player5, player6, player7, player8;
    public static GameObject dice1, dice2, dice3;

    Text text;
	public static int dice1Number;
	public static int dice2Number;
	public static int dice3Number;
	public int sum;
    public Camera[] camera;
    public static int jail1 = 0, jail2 = 0, jail3 =, jail4 = 0, jail5 = 0, jail6 = 0, jail7 = 0, jail8 = 0;

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
            if (jail1 == 1)
            {
                ImageForJail.gameObject.setActive(true);
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
                ImageForJail.gameObject.setActive(true);
            }
            else
            {
                GameControl.MovePlayer(2);
                cam2();
            }
        }
        else if (whosTurn == 3)
        {
            if (jail3 == 1)
            {
                ImageForJail.gameObject.setActive(true);
            }
            else
            {
                GameControl.MovePlayer(3);
                cam3();
            }
        }
        else if (whosTurn == 4)
        {
            if (jail4 == 1)
            {
                ImageForJail.gameObject.setActive(true);
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
                ImageForJail.gameObject.setActive(true);
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
                ImageForJail.gameObject.setActive(true);
            }
            else
            {
                GameControl.MovePlayer(2);
                cam2();
            }
        }
        else if (whosTurn == 3)
        {
            if (jail3 == 1)
            {
                ImageForJail.gameObject.setActive(true);
            }
            else
            {
                GameControl.MovePlayer(3);
                cam3();
            }
        }
        else if (whosTurn == 4)
        {
            if (jail4 == 1)
            {
                ImageForJail.gameObject.setActive(true);
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
                ImageForJail.gameObject.setActive(true);
            }
            else
            {
                GameControl.MovePlayer(5);
                cam5();
                whosTurn = 0;
            }
        }

    }

    public void SixPeople()
    {
        if (whosTurn == 1)
        {
            if (jail1 == 1)
            {
                ImageForJail.gameObject.setActive(true);
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
                ImageForJail.gameObject.setActive(true);
            }
            else
            {
                GameControl.MovePlayer(2);
                cam2();
            }
        }
        else if (whosTurn == 3)
        {
            if (jail3 == 1)
            {
                ImageForJail.gameObject.setActive(true);
            }
            else
            {
                GameControl.MovePlayer(3);
                cam3();
            }
        }
        else if (whosTurn == 4)
        {
            if (jail4 == 1)
            {
                ImageForJail.gameObject.setActive(true);
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
                ImageForJail.gameObject.setActive(true);
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
                ImageForJail.gameObject.setActive(true);
            }
            else
            {
                GameControl.MovePlayer(6);
                cam6();
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
                ImageForJail.gameObject.setActive(true);
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
                ImageForJail.gameObject.setActive(true);
            }
            else
            {
                GameControl.MovePlayer(2);
                cam2();
            }
        }
        else if (whosTurn == 3)
        {
            if (jail3 == 1)
            {
                ImageForJail.gameObject.setActive(true);
            }
            else
            {
                GameControl.MovePlayer(3);
                cam3();
            }
        }
        else if (whosTurn == 4)
        {
            if (jail4 == 1)
            {
                ImageForJail.gameObject.setActive(true);
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
                ImageForJail.gameObject.setActive(true);
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
                ImageForJail.gameObject.setActive(true);
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
                ImageForJail.gameObject.setActive(true);
            }
            else
            {
                GameControl.MovePlayer(7);
                cam7();
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
                ImageForJail.gameObject.setActive(true);
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
                ImageForJail.gameObject.setActive(true);
            }
            else
            {
                GameControl.MovePlayer(2);
                cam2();
            }
        }
        else if (whosTurn == 3)
        {
            if (jail3 == 1)
            {
                ImageForJail.gameObject.setActive(true);
            }
            else
            {
                GameControl.MovePlayer(3);
                cam3();
            }
        }
        else if (whosTurn == 4)
        {
            if (jail4 == 1)
            {
                ImageForJail.gameObject.setActive(true);
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
                ImageForJail.gameObject.setActive(true);
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
                ImageForJail.gameObject.setActive(true);
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
                ImageForJail.gameObject.setActive(true);
            }
            else
            {
                GameControl.MovePlayer(7);
                cam7();
            }
        }
        else if (whosTurn == 8)
        {
            if (jail8 == 1)
            {
                ImageForJail.gameObject.setActive(true);
            }
            else
            {
                GameControl.MovePlayer(8);
                cam8();
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

}
