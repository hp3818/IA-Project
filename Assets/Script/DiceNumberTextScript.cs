using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceNumberTextScript : MonoBehaviour
{

    public static GameObject player1, player2, player3, player4, player5, player6, player7, player8;
    public static GameObject dice1, dice2, dice3;
    public Transform[] waypoints;
    public Text JailTurn; public Text RoundText; public static int round = 0;
    public static GameObject ImageForMid, ImageForRich;
    public static GameObject ImageForBuyHouse;
    public static GameObject ImageForBuyOtherHouse;
    public Button dropButton;
    public static GameObject ImageForJail;
    public static GameObject ImageForHospital;
    public Text InjureTurn;
    public static int challenge = 0, challengeRule = 0, challengeRuleRound = 2;
    public Text player1Cost, player2Cost, player3Cost, player4Cost, player5Cost, player6Cost, player7Cost, player8Cost;
    public Text player1Card1, player1Card2, player1Card3, player1Card4, player1Card5, player2Card1, player2Card2, player2Card3, player2Card4, player2Card5,
                            player3Card1, player3Card2, player3Card3, player3Card4, player3Card5, player4Card1, player4Card2, player4Card3, player4Card4, player4Card5,
                               player5Card1, player5Card2, player5Card3, player5Card4, player5Card5, player6Card1, player6Card2, player6Card3, player6Card4, player6Card5,
                                  player7Card1, player7Card2, player7Card3, player7Card4, player7Card5, player8Card1, player8Card2, player8Card3, player8Card4, player8Card5;

    public static string player1Card1string, player1Card2string, player1Card3string, player1Card4string, player1Card5string, player2Card1string, player2Card2string, player2Card3string, player2Card4string, player2Card5string,
                                        player3Card1string, player3Card2string, player3Card3string, player3Card4string, player3Card5string, player4Card1string, player4Card2string, player4Card3string, player4Card4string, player4Card5string,
                                           player5Card1string, player5Card2string, player5Card3string, player5Card4string, player5Card5string, player6Card1string, player6Card2string, player6Card3string, player6Card4string, player6Card5string,
                                               player7Card1string, player7Card2string, player7Card3string, player7Card4string, player7Card5string, player8Card1string, player8Card2string, player8Card3string, player8Card4string, player8Card5string;

    Text text;
    public static int dice1Number;
    public static int dice2Number;
    public static int dice3Number;
    public int sum;
    public Camera[] camera;
    public static int jail1 = 0, jail2 = 0, jail3 = 0, jail4 = 0, jail5 = 0, jail6 = 0, jail7 = 0, jail8 = 0;
    public static int injure1 = 0, injure2 = 0, injure3 = 0, injure4 = 0, injure5 = 0, injure6 = 0, injure7 = 0, injure8 = 0;
    public static int injure1Turn = 2, injure2Turn = 2, injure3Turn = 2, injure4Turn = 2, injure5Turn = 2, injure6Turn = 2, injure7Turn = 2, injure8Turn = 2;

    public static int hide11, hide12, hide13, hide14, hide15, hide21, hide22, hide23, hide24, hide25, hide31, hide32, hide33, hide34, hide35, hide41, hide42, hide43, hide44, hide45;
    public static int hide51, hide52, hide53, hide54, hide55, hide61, hide62, hide63, hide64, hide65, hide71, hide72, hide73, hide74, hide75, hide81, hide82, hide83, hide84, hide85;

    public static GameObject Card1, Card2, Card3, Card4, Card5;
    GameControl instanceOfB;
    public static int godMoney = 0;

    public static int OK = 1;
    public static int whosTurn = 1;
    public static int MaxPeople;
    public static int stop = 0;

    public static bool runOnce = false;
    public static int Redrop = 0;

    public CardAnimation CA;

    public void Start()
    {

        Card1 = GameObject.Find("Card1");
        Card2 = GameObject.Find("Card2");
        Card3 = GameObject.Find("Card3");
        Card4 = GameObject.Find("Card4");
        Card5 = GameObject.Find("Card5");

        CA = GameObject.Find("CardAnimation").GetComponent<CardAnimation>();
        instanceOfB = GameObject.Find("GameControl").GetComponent<GameControl>();
        
        /*
        if (DropZone.childCount < 5)
        {
            CA.PlayAnimation();
        }
        */

        text = GetComponent<Text>();
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

    public void Update()
    {
        
        sum = int.Parse(dice1Number.ToString()) + int.Parse(dice2Number.ToString()) + int.Parse(dice3Number.ToString());
        text.text = sum.ToString();

        if (sum == 0)
        {
            runOnce = false;
        }

        if (dropButton.interactable == false)
            Card.show = 1;
        else if (dropButton.interactable == true)
            Card.show = 0;
            
        if (!runOnce && sum != 0)
        {
            Moving();
            if (godMoney == 1)
            {
                if (GameControl.numberOfPlayer == 4 || GameControl.numberOfPlayer == 5)
                {
                    if (whosTurn == 3)
                    {
                        HouseSelection.sum3 += (sum * 5000);
                        player3Cost.text = HouseSelection.sum3.ToString();
                    }
                    if (whosTurn == 4)
                    {
                        HouseSelection.sum4 += (sum * 5000);
                        player4Cost.text = HouseSelection.sum4.ToString();
                    }
                    if (whosTurn == 5)
                    {
                        HouseSelection.sum5 += (sum * 5000);
                        player5Cost.text = HouseSelection.sum5.ToString();
                    }
                }
                if (GameControl.numberOfPlayer == 6 || GameControl.numberOfPlayer == 7 || GameControl.numberOfPlayer == 8)
                {
                    if (whosTurn == 4)
                    {
                        HouseSelection.sum4 += (sum * 5000);
                        player4Cost.text = HouseSelection.sum4.ToString();
                    }
                    if (whosTurn == 5)
                    {
                        HouseSelection.sum5 += (sum * 5000);
                        player5Cost.text = HouseSelection.sum5.ToString();
                    }
                    if (whosTurn == 6)
                    {
                        HouseSelection.sum6 += (sum * 5000);
                        player6Cost.text = HouseSelection.sum6.ToString();
                    }
                    if (whosTurn == 7)
                    {
                        HouseSelection.sum7 += (sum * 5000);
                        player7Cost.text = HouseSelection.sum7.ToString();
                    }
                    if (whosTurn == 8)
                    {
                        HouseSelection.sum8 += (sum * 5000);
                        player8Cost.text = HouseSelection.sum8.ToString();
                    }
                }
                godMoney = 0;
            }
            stop = 1;
        }

        if ((stop == 0 && dropButton.interactable == true) || (stop == 1 && dropButton.interactable == true))
        {
            if (whosTurn == 1)
            {
                Card1.gameObject.SetActive(true);
                Card2.gameObject.SetActive(true);
                Card3.gameObject.SetActive(true);
                Card4.gameObject.SetActive(true);
                Card5.gameObject.SetActive(true);
                if (hide11 == 1)
                    Card1.gameObject.SetActive(false);
                if (hide12 == 1)
                    Card2.gameObject.SetActive(false);
                if (hide13 == 1)
                    Card3.gameObject.SetActive(false);
                if (hide14 == 1)
                    Card4.gameObject.SetActive(false);
                if (hide15 == 1)
                    Card5.gameObject.SetActive(false);
                player1Card1.text = player1Card1string;
                player1Card2.text = player1Card2string;
                player1Card3.text = player1Card3string;
                player1Card4.text = player1Card4string;
                player1Card5.text = player1Card5string;
            }
            else if (whosTurn == 2)
            {
                Card1.gameObject.SetActive(true);
                Card2.gameObject.SetActive(true);
                Card3.gameObject.SetActive(true);
                Card4.gameObject.SetActive(true);
                Card5.gameObject.SetActive(true);
                if (hide21 == 1)
                    Card1.gameObject.SetActive(false);
                if (hide22 == 1)
                    Card2.gameObject.SetActive(false);
                if (hide23 == 1)
                    Card3.gameObject.SetActive(false);
                if (hide24 == 1)
                    Card4.gameObject.SetActive(false);
                if (hide25 == 1)
                    Card5.gameObject.SetActive(false);
                player2Card1.text = player2Card1string;
                player2Card2.text = player2Card2string;
                player2Card3.text = player2Card3string;
                player2Card4.text = player2Card4string;
                player2Card5.text = player2Card5string;
            }
            else if (whosTurn == 3)
            {
                Card1.gameObject.SetActive(true);
                Card2.gameObject.SetActive(true);
                Card3.gameObject.SetActive(true);
                Card4.gameObject.SetActive(true);
                Card5.gameObject.SetActive(true);
                if (hide31 == 1)
                    Card1.gameObject.SetActive(false);
                if (hide32 == 1)
                    Card2.gameObject.SetActive(false);
                if (hide33 == 1)
                    Card3.gameObject.SetActive(false);
                if (hide34 == 1)
                    Card4.gameObject.SetActive(false);
                if (hide35 == 1)
                    Card5.gameObject.SetActive(false);
                player3Card1.text = player3Card1string;
                player3Card2.text = player3Card2string;
                player3Card3.text = player3Card3string;
                player3Card4.text = player3Card4string;
                player3Card5.text = player3Card5string;
            }
            else if (whosTurn == 4)
            {
                Card1.gameObject.SetActive(true);
                Card2.gameObject.SetActive(true);
                Card3.gameObject.SetActive(true);
                Card4.gameObject.SetActive(true);
                Card5.gameObject.SetActive(true);
                if (hide41 == 1)
                    Card1.gameObject.SetActive(false);
                if (hide42 == 1)
                    Card2.gameObject.SetActive(false);
                if (hide43 == 1)
                    Card3.gameObject.SetActive(false);
                if (hide44 == 1)
                    Card4.gameObject.SetActive(false);
                if (hide45 == 1)
                    Card5.gameObject.SetActive(false);
                player4Card1.text = player4Card1string;
                player4Card2.text = player4Card2string;
                player4Card3.text = player4Card3string;
                player4Card4.text = player4Card4string;
                player4Card5.text = player4Card5string;
            }
            else if (whosTurn == 5)
            {
                Card1.gameObject.SetActive(true);
                Card2.gameObject.SetActive(true);
                Card3.gameObject.SetActive(true);
                Card4.gameObject.SetActive(true);
                Card5.gameObject.SetActive(true);
                if (hide51 == 1)
                    Card1.gameObject.SetActive(false);
                if (hide52 == 1)
                    Card2.gameObject.SetActive(false);
                if (hide53 == 1)
                    Card3.gameObject.SetActive(false);
                if (hide54 == 1)
                    Card4.gameObject.SetActive(false);
                if (hide55 == 1)
                    Card5.gameObject.SetActive(false);
                player5Card1.text = player5Card1string;
                player5Card2.text = player5Card2string;
                player5Card3.text = player5Card3string;
                player5Card4.text = player5Card4string;
                player5Card5.text = player5Card5string;
            }
            else if (whosTurn == 6)
            {
                Card1.gameObject.SetActive(true);
                Card2.gameObject.SetActive(true);
                Card3.gameObject.SetActive(true);
                Card4.gameObject.SetActive(true);
                Card5.gameObject.SetActive(true);
                if (hide61 == 1)
                    Card1.gameObject.SetActive(false);
                if (hide62 == 1)
                    Card2.gameObject.SetActive(false);
                if (hide63 == 1)
                    Card3.gameObject.SetActive(false);
                if (hide64 == 1)
                    Card4.gameObject.SetActive(false);
                if (hide65 == 1)
                    Card5.gameObject.SetActive(false);
                player6Card1.text = player6Card1string;
                player6Card2.text = player6Card2string;
                player6Card3.text = player6Card3string;
                player6Card4.text = player6Card4string;
                player6Card5.text = player6Card5string;
            }
            else if (whosTurn == 7)
            {
                Card1.gameObject.SetActive(true);
                Card2.gameObject.SetActive(true);
                Card3.gameObject.SetActive(true);
                Card4.gameObject.SetActive(true);
                Card5.gameObject.SetActive(true);
                if (hide71 == 1)
                    Card1.gameObject.SetActive(false);
                if (hide72 == 1)
                    Card2.gameObject.SetActive(false);
                if (hide73 == 1)
                    Card3.gameObject.SetActive(false);
                if (hide74 == 1)
                    Card4.gameObject.SetActive(false);
                if (hide75 == 1)
                    Card5.gameObject.SetActive(false);
                player7Card1.text = player7Card1string;
                player7Card2.text = player7Card2string;
                player7Card3.text = player7Card3string;
                player7Card4.text = player7Card4string;
                player7Card5.text = player7Card5string;
            }
            else if (whosTurn == 8)
            {
                Card1.gameObject.SetActive(true);
                Card2.gameObject.SetActive(true);
                Card3.gameObject.SetActive(true);
                Card4.gameObject.SetActive(true);
                Card5.gameObject.SetActive(true);
                if (hide81 == 1)
                    Card1.gameObject.SetActive(false);
                if (hide82 == 1)
                    Card2.gameObject.SetActive(false);
                if (hide83 == 1)
                    Card3.gameObject.SetActive(false);
                if (hide84 == 1)
                    Card4.gameObject.SetActive(false);
                if (hide85 == 1)
                    Card5.gameObject.SetActive(false);
                player8Card1.text = player8Card1string;
                player8Card2.text = player8Card2string;
                player8Card3.text = player8Card3string;
                player8Card4.text = player8Card4string;
                player8Card5.text = player8Card5string;
            }
        }
        if (stop == 1 && dropButton.interactable == true)
        {
            if (whosTurn == 1)
            {
                Debug.Log("CA animation");
                Card1.gameObject.SetActive(true);
                Card2.gameObject.SetActive(true);
                Card3.gameObject.SetActive(true);
                Card4.gameObject.SetActive(true);
                Card5.gameObject.SetActive(true);
                if (hide11 == 1)
                    Card1.gameObject.SetActive(false);
                if (hide12 == 1)
                    Card2.gameObject.SetActive(false);
                if (hide13 == 1)
                    Card3.gameObject.SetActive(false);
                if (hide14 == 1)
                    Card4.gameObject.SetActive(false);
                if (hide15 == 1)
                    Card5.gameObject.SetActive(false);
                player1Card1.text = player1Card1string;
                player1Card2.text = player1Card2string;
                player1Card3.text = player1Card3string;
                player1Card4.text = player1Card4string;
                player1Card5.text = player1Card5string;
                if (Card1.gameObject.activeSelf == false)
                {
                    CA.PlayAnimation();
                }
                else if (Card2.gameObject.activeSelf == false)
                {
                    CA.PlayAnimation();
                }
                else if (Card3.gameObject.activeSelf == false)
                {
                    CA.PlayAnimation();
                }
                else if (Card3.gameObject.activeSelf == false)
                {
                    CA.PlayAnimation();
                }
                else if (Card4.gameObject.activeSelf == false)
                {
                    CA.PlayAnimation();
                }
                
            }
            else if (whosTurn == 2)
            {
                Card1.gameObject.SetActive(true);
                Card2.gameObject.SetActive(true);
                Card3.gameObject.SetActive(true);
                Card4.gameObject.SetActive(true);
                Card5.gameObject.SetActive(true);
                if (hide21 == 1)
                    Card1.gameObject.SetActive(false);
                if (hide22 == 1)
                    Card2.gameObject.SetActive(false);
                if (hide23 == 1)
                    Card3.gameObject.SetActive(false);
                if (hide24 == 1)
                    Card4.gameObject.SetActive(false);
                if (hide25 == 1)
                    Card5.gameObject.SetActive(false);
                player2Card1.text = player2Card1string;
                player2Card2.text = player2Card2string;
                player2Card3.text = player2Card3string;
                player2Card4.text = player2Card4string;
                player2Card5.text = player2Card5string;
                if (Card1.gameObject.activeSelf == false)
                {
                    CA.PlayAnimation();
                }
                else if (Card2.gameObject.activeSelf == false)
                {
                    CA.PlayAnimation();
                }
                else if (Card3.gameObject.activeSelf == false)
                {
                    CA.PlayAnimation();
                }
                else if (Card3.gameObject.activeSelf == false)
                {
                    CA.PlayAnimation();
                }
                else if (Card4.gameObject.activeSelf == false)
                {
                    CA.PlayAnimation();
                }
            }
            else if (whosTurn == 3)
            {
                Card1.gameObject.SetActive(true);
                Card2.gameObject.SetActive(true);
                Card3.gameObject.SetActive(true);
                Card4.gameObject.SetActive(true);
                Card5.gameObject.SetActive(true);
                if (hide31 == 1)
                    Card1.gameObject.SetActive(false);
                if (hide32 == 1)
                    Card2.gameObject.SetActive(false);
                if (hide33 == 1)
                    Card3.gameObject.SetActive(false);
                if (hide34 == 1)
                    Card4.gameObject.SetActive(false);
                if (hide35 == 1)
                    Card5.gameObject.SetActive(false);
                player3Card1.text = player3Card1string;
                player3Card2.text = player3Card2string;
                player3Card3.text = player3Card3string;
                player3Card4.text = player3Card4string;
                player3Card5.text = player3Card5string;
                if (Card1.gameObject.activeSelf == false)
                {
                    CA.PlayAnimation();
                }
                else if (Card2.gameObject.activeSelf == false)
                {
                    CA.PlayAnimation();
                }
                else if (Card3.gameObject.activeSelf == false)
                {
                    CA.PlayAnimation();
                }
                else if (Card3.gameObject.activeSelf == false)
                {
                    CA.PlayAnimation();
                }
                else if (Card4.gameObject.activeSelf == false)
                {
                    CA.PlayAnimation();
                }
            }
            else if (whosTurn == 4)
            {
                Card1.gameObject.SetActive(true);
                Card2.gameObject.SetActive(true);
                Card3.gameObject.SetActive(true);
                Card4.gameObject.SetActive(true);
                Card5.gameObject.SetActive(true);
                if (hide41 == 1)
                    Card1.gameObject.SetActive(false);
                if (hide42 == 1)
                    Card2.gameObject.SetActive(false);
                if (hide43 == 1)
                    Card3.gameObject.SetActive(false);
                if (hide44 == 1)
                    Card4.gameObject.SetActive(false);
                if (hide45 == 1)
                    Card5.gameObject.SetActive(false);
                player4Card1.text = player4Card1string;
                player4Card2.text = player4Card2string;
                player4Card3.text = player4Card3string;
                player4Card4.text = player4Card4string;
                player4Card5.text = player4Card5string;
                if (Card1.gameObject.activeSelf == false)
                {
                    CA.PlayAnimation();
                }
                else if (Card2.gameObject.activeSelf == false)
                {
                    CA.PlayAnimation();
                }
                else if (Card3.gameObject.activeSelf == false)
                {
                    CA.PlayAnimation();
                }
                else if (Card3.gameObject.activeSelf == false)
                {
                    CA.PlayAnimation();
                }
                else if (Card4.gameObject.activeSelf == false)
                {
                    CA.PlayAnimation();
                }
            }
            else if (whosTurn == 5)
            {
                Card1.gameObject.SetActive(true);
                Card2.gameObject.SetActive(true);
                Card3.gameObject.SetActive(true);
                Card4.gameObject.SetActive(true);
                Card5.gameObject.SetActive(true);
                if (hide51 == 1)
                    Card1.gameObject.SetActive(false);
                if (hide52 == 1)
                    Card2.gameObject.SetActive(false);
                if (hide53 == 1)
                    Card3.gameObject.SetActive(false);
                if (hide54 == 1)
                    Card4.gameObject.SetActive(false);
                if (hide55 == 1)
                    Card5.gameObject.SetActive(false);
                player5Card1.text = player5Card1string;
                player5Card2.text = player5Card2string;
                player5Card3.text = player5Card3string;
                player5Card4.text = player5Card4string;
                player5Card5.text = player5Card5string;
                if (Card1.gameObject.activeSelf == false)
                {
                    CA.PlayAnimation();
                }
                else if (Card2.gameObject.activeSelf == false)
                {
                    CA.PlayAnimation();
                }
                else if (Card3.gameObject.activeSelf == false)
                {
                    CA.PlayAnimation();
                }
                else if (Card3.gameObject.activeSelf == false)
                {
                    CA.PlayAnimation();
                }
                else if (Card4.gameObject.activeSelf == false)
                {
                    CA.PlayAnimation();
                }
            }
            else if (whosTurn == 6)
            {
                Card1.gameObject.SetActive(true);
                Card2.gameObject.SetActive(true);
                Card3.gameObject.SetActive(true);
                Card4.gameObject.SetActive(true);
                Card5.gameObject.SetActive(true);
                if (hide61 == 1)
                    Card1.gameObject.SetActive(false);
                if (hide62 == 1)
                    Card2.gameObject.SetActive(false);
                if (hide63 == 1)
                    Card3.gameObject.SetActive(false);
                if (hide64 == 1)
                    Card4.gameObject.SetActive(false);
                if (hide65 == 1)
                    Card5.gameObject.SetActive(false);
                player6Card1.text = player6Card1string;
                player6Card2.text = player6Card2string;
                player6Card3.text = player6Card3string;
                player6Card4.text = player6Card4string;
                player6Card5.text = player6Card5string;
                if (Card1.gameObject.activeSelf == false)
                {
                    CA.PlayAnimation();
                }
                else if (Card2.gameObject.activeSelf == false)
                {
                    CA.PlayAnimation();
                }
                else if (Card3.gameObject.activeSelf == false)
                {
                    CA.PlayAnimation();
                }
                else if (Card3.gameObject.activeSelf == false)
                {
                    CA.PlayAnimation();
                }
                else if (Card4.gameObject.activeSelf == false)
                {
                    CA.PlayAnimation();
                }
            }
            else if (whosTurn == 7)
            {
                Card1.gameObject.SetActive(true);
                Card2.gameObject.SetActive(true);
                Card3.gameObject.SetActive(true);
                Card4.gameObject.SetActive(true);
                Card5.gameObject.SetActive(true);
                if (hide71 == 1)
                    Card1.gameObject.SetActive(false);
                if (hide72 == 1)
                    Card2.gameObject.SetActive(false);
                if (hide73 == 1)
                    Card3.gameObject.SetActive(false);
                if (hide74 == 1)
                    Card4.gameObject.SetActive(false);
                if (hide75 == 1)
                    Card5.gameObject.SetActive(false);
                player7Card1.text = player7Card1string;
                player7Card2.text = player7Card2string;
                player7Card3.text = player7Card3string;
                player7Card4.text = player7Card4string;
                player7Card5.text = player7Card5string;
                if (Card1.gameObject.activeSelf == false)
                {
                    CA.PlayAnimation();
                }
                else if (Card2.gameObject.activeSelf == false)
                {
                    CA.PlayAnimation();
                }
                else if (Card3.gameObject.activeSelf == false)
                {
                    CA.PlayAnimation();
                }
                else if (Card3.gameObject.activeSelf == false)
                {
                    CA.PlayAnimation();
                }
                else if (Card4.gameObject.activeSelf == false)
                {
                    CA.PlayAnimation();
                }
            }
            else if (whosTurn == 8)
            {
                Card1.gameObject.SetActive(true);
                Card2.gameObject.SetActive(true);
                Card3.gameObject.SetActive(true);
                Card4.gameObject.SetActive(true);
                Card5.gameObject.SetActive(true);
                if (hide81 == 1)
                    Card1.gameObject.SetActive(false);
                if (hide82 == 1)
                    Card2.gameObject.SetActive(false);
                if (hide83 == 1)
                    Card3.gameObject.SetActive(false);
                if (hide84 == 1)
                    Card4.gameObject.SetActive(false);
                if (hide85 == 1)
                    Card5.gameObject.SetActive(false);
                player8Card1.text = player8Card1string;
                player8Card2.text = player8Card2string;
                player8Card3.text = player8Card3string;
                player8Card4.text = player8Card4string;
                player8Card5.text = player8Card5string;
                if (Card1.gameObject.activeSelf == false)
                {
                    CA.PlayAnimation();
                }
                else if (Card2.gameObject.activeSelf == false)
                {
                    CA.PlayAnimation();
                }
                else if (Card3.gameObject.activeSelf == false)
                {
                    CA.PlayAnimation();
                }
                else if (Card3.gameObject.activeSelf == false)
                {
                    CA.PlayAnimation();
                }
                else if (Card4.gameObject.activeSelf == false)
                {
                    CA.PlayAnimation();
                }
            }
            stop = 0;
        }
            /*
        if (stop == 1)
            stop = 0;
            */
    }

    public void Moving()
    {
        MaxPeople = GameControl.numberOfPlayer;

        if (MaxPeople == 4)
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
            round++;
            RoundText.text = round.ToString();
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
                    injure1 = 0;
                    injure2Turn = 2;
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
                    dropButton.interactable = false;
                    GameControl.ImageForMid.gameObject.SetActive(true);
                }
                else
                {
                    if (challenge == 1)
                    {
                        StartCoroutine(TemporarilyDeactivate3(2));
                    } 
                    if (challengeRule == 1)
                    {
                        StartCoroutine(TemporarilyDeactivate4(2));
                    }
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
                        GameControl.jail3turn = 3;
                        jail3 = 0;
                    }
                    if (challengeRule == 1)
                    {
                        StartCoroutine(TemporarilyDeactivate4(2));
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
            if (jail4 == 1)
            {
                if (DiceNumberTextScript.dice1Number == 6)
                {
                    GameControl.jail4turn = 3;
                    jail4 = 0;
                    GameControl.MovePlayer(4);
                    cam4();
                    whosTurn = 0;
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
        round++;
        RoundText.text = round.ToString();
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
                    dropButton.interactable = false;
                    GameControl.ImageForMid.gameObject.SetActive(true);
                }
                else
                {
                    if (challenge == 1)
                    {
                        StartCoroutine(TemporarilyDeactivate3(2));
                    }
                    if (challengeRule == 1)
                    {
                        StartCoroutine(TemporarilyDeactivate4(2));
                    }
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
                    whosTurn = 0;
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
        round++;
        RoundText.text = round.ToString();
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
                    dropButton.interactable = false;
                    GameControl.ImageForMid.gameObject.SetActive(true);
                }
                else
                {
                    if (challenge == 1)
                    {
                        StartCoroutine(TemporarilyDeactivate3(2));
                    }
                    if (challengeRule == 1)
                    {
                        StartCoroutine(TemporarilyDeactivate4(2));
                    }
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
                    dropButton.interactable = false;
                    GameControl.ImageForMid.gameObject.SetActive(true);
                }
                else
                {
                    if (challenge == 1)
                    {
                        StartCoroutine(TemporarilyDeactivate3(2));
                    }
                    if (challengeRule == 1)
                    {
                        StartCoroutine(TemporarilyDeactivate4(2));
                    }
                    GameControl.MovePlayer(3);
                    cam3();
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
                    whosTurn = 0;
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
                whosTurn = 0;
                dropButton.interactable = true;
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
        round++;
        RoundText.text = round.ToString();
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
                    dropButton.interactable = false;
                    GameControl.ImageForMid.gameObject.SetActive(true);
                }
                else
                {
                    if (challenge == 1)
                    {
                        StartCoroutine(TemporarilyDeactivate3(2));
                    }
                    if (challengeRule == 1)
                    {
                        StartCoroutine(TemporarilyDeactivate4(2));
                    }
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
                    dropButton.interactable = false;
                    GameControl.ImageForMid.gameObject.SetActive(true);
                }
                else
                {
                    if (challenge == 1)
                    {
                        StartCoroutine(TemporarilyDeactivate3(2));
                    }
                    if (challengeRule == 1)
                    {
                        StartCoroutine(TemporarilyDeactivate4(2));
                    }
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
            if (jail7 == 1)
            {
                if (DiceNumberTextScript.dice1Number == 6)
                {
                    GameControl.jail7turn = 3;
                    jail7 = 0;
                    GameControl.MovePlayer(7);
                    cam7();
                    whosTurn = 0;
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
                whosTurn = 0;
                dropButton.interactable = true;
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
        round++;
        RoundText.text = round.ToString();
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
                    dropButton.interactable = false;
                    GameControl.ImageForMid.gameObject.SetActive(true);
                }
                else
                {
                    if (challenge == 1)
                    {
                        StartCoroutine(TemporarilyDeactivate3(2));
                    }
                    if (challengeRule == 1)
                    {
                        StartCoroutine(TemporarilyDeactivate4(2));
                    }
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
                    dropButton.interactable = false;
                    GameControl.ImageForMid.gameObject.SetActive(true);
                }
                else
                {
                    if (challenge == 1)
                    {
                        StartCoroutine(TemporarilyDeactivate3(2));
                    }
                    if (challengeRule == 1)
                    {
                        StartCoroutine(TemporarilyDeactivate4(2));
                    }
                    GameControl.MovePlayer(3);
                    cam3();
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
            if (jail8 == 1)
            {
                if (DiceNumberTextScript.dice1Number == 6)
                {
                    GameControl.jail8turn = 3;
                    jail8 = 0;
                    GameControl.MovePlayer(8);
                    cam8();
                    whosTurn = 0;
                }
                else
                {
                    GameControl.jail8turn--;
                    JailTurn.text = GameControl.jail8turn.ToString();
                    StartCoroutine(TemporarilyDeactivate(2));
                    if (GameControl.jail8turn == 0)
                    {
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

    public IEnumerator TemporarilyDeactivate(float duration)
    {
        ImageForJail.gameObject.SetActive(true);
        yield return new WaitForSeconds(duration);
        ImageForJail.gameObject.SetActive(false);
    }

    public IEnumerator TemporarilyDeactivat2(float duration)
    {
        ImageForHospital.gameObject.SetActive(true);
        yield return new WaitForSeconds(duration);
        ImageForHospital.gameObject.SetActive(false);
    }

    public IEnumerator TemporarilyDeactivate3(float duration)
    {
        yield return new WaitForSeconds(duration);
        int sum2 = dice1Number + dice2Number;
        if (sum2 >= 8)
        {
            instanceOfB.getBuilding();
        }
    }

    public IEnumerator TemporarilyDeactivate4(float duration)
    {
        yield return new WaitForSeconds(duration);
        int sum2 = dice1Number + dice2Number;
        if (sum2 >= 8)
        {
            Debug.Log(GameControl.whoTurn);
            if (GameControl.numberOfPlayer == 4)
            {
                if (GameControl.whoTurn - 3 == 1)
                {
                    HouseSelection.sum1 *= 0.9;
                    player1Cost.text = HouseSelection.sum1.ToString();
                }
                if (GameControl.whoTurn + 1 == 2)
                {
                    HouseSelection.sum2 *= 0.9;
                    player2Cost.text = HouseSelection.sum2.ToString();
                } // 1
                if (GameControl.whoTurn + 1== 3)
                {
                    HouseSelection.sum3 *= 0.9;
                    player3Cost.text = HouseSelection.sum3.ToString();
                }  // 2
                if (GameControl.whoTurn + 1== 4)
                {
                    HouseSelection.sum4 *= 0.9;
                    player4Cost.text = HouseSelection.sum4.ToString();
                }  // 3
            } else if (GameControl.numberOfPlayer == 5)
            {
                if (GameControl.whoTurn - 4 == 1)
                {
                    HouseSelection.sum1 *= 0.9;
                    player1Cost.text = HouseSelection.sum1.ToString();
                }
                if (GameControl.whoTurn +1 == 2)
                {
                    HouseSelection.sum2 *= 0.9;
                    player2Cost.text = HouseSelection.sum2.ToString();
                }
                if (GameControl.whoTurn +1 == 3)
                {
                    HouseSelection.sum3 *= 0.9;
                    player3Cost.text = HouseSelection.sum3.ToString();
                }
                if (GameControl.whoTurn +1 == 4)
                {
                    HouseSelection.sum4 *= 0.9;
                    player4Cost.text = HouseSelection.sum4.ToString();
                }
                if (GameControl.whoTurn +1 == 5)
                {
                    HouseSelection.sum5 *= 0.9;
                    player5Cost.text = HouseSelection.sum5.ToString();
                }
            }  else if (GameControl.numberOfPlayer == 6)
            {
                if (GameControl.whoTurn - 5 == 1)
                {
                    HouseSelection.sum1 *= 0.9;
                    player1Cost.text = HouseSelection.sum1.ToString();
                }
                if (GameControl.whoTurn + 1 == 2)
                {
                    HouseSelection.sum2 *= 0.9;
                    player2Cost.text = HouseSelection.sum2.ToString();
                }
                if (GameControl.whoTurn + 1 == 3)
                {
                    HouseSelection.sum3 *= 0.9;
                    player3Cost.text = HouseSelection.sum3.ToString();
                }
                if (GameControl.whoTurn + 1 == 4)
                {
                    HouseSelection.sum4 *= 0.9;
                    player4Cost.text = HouseSelection.sum4.ToString();
                }
                if (GameControl.whoTurn + 1 == 5)
                {
                    HouseSelection.sum5 *= 0.9;
                    player5Cost.text = HouseSelection.sum5.ToString();
                }
                if (GameControl.whoTurn + 1 == 6)
                {
                    HouseSelection.sum6 *= 0.9;
                    player6Cost.text = HouseSelection.sum6.ToString();
                }
            } else if (GameControl.numberOfPlayer == 7)
            {
                if (GameControl.whoTurn - 6 == 1)
                {
                    HouseSelection.sum1 *= 0.9;
                    player1Cost.text = HouseSelection.sum1.ToString();
                }
                if (GameControl.whoTurn + 1 == 2)
                {
                    HouseSelection.sum2 *= 0.9;
                    player2Cost.text = HouseSelection.sum2.ToString();
                }
                if (GameControl.whoTurn + 1 == 3)
                {
                    HouseSelection.sum3 *= 0.9;
                    player3Cost.text = HouseSelection.sum3.ToString();
                }
                if (GameControl.whoTurn + 1 == 4)
                {
                    HouseSelection.sum4 *= 0.9;
                    player4Cost.text = HouseSelection.sum4.ToString();
                }
                if (GameControl.whoTurn + 1 == 5)
                {
                    HouseSelection.sum5 *= 0.9;
                    player5Cost.text = HouseSelection.sum5.ToString();
                }
                if (GameControl.whoTurn + 1 == 6)
                {
                    HouseSelection.sum6 *= 0.9;
                    player6Cost.text = HouseSelection.sum6.ToString();
                }
                if (GameControl.whoTurn + 1 == 7)
                {
                    HouseSelection.sum7 *= 0.9;
                    player7Cost.text = HouseSelection.sum7.ToString();
                }
            } else if (GameControl.numberOfPlayer ==8)
            {
                if (GameControl.whoTurn - 7 == 1)
                {
                    HouseSelection.sum1 *= 0.9;
                    player1Cost.text = HouseSelection.sum1.ToString();
                }
                if (GameControl.whoTurn + 1 == 2)
                {
                    HouseSelection.sum2 *= 0.9;
                    player2Cost.text = HouseSelection.sum2.ToString();
                }
                if (GameControl.whoTurn + 1 == 3)
                {
                    HouseSelection.sum3 *= 0.9;
                    player3Cost.text = HouseSelection.sum3.ToString();
                }
                if (GameControl.whoTurn + 1 == 4)
                {
                    HouseSelection.sum4 *= 0.9;
                    player4Cost.text = HouseSelection.sum4.ToString();
                }
                if (GameControl.whoTurn + 1 == 5)
                {
                    HouseSelection.sum5 *= 0.9;
                    player5Cost.text = HouseSelection.sum5.ToString();
                }
                if (GameControl.whoTurn + 1 == 6)
                {
                    HouseSelection.sum6 *= 0.9;
                    player6Cost.text = HouseSelection.sum6.ToString();
                }
                if (GameControl.whoTurn + 1 == 7)
                {
                    HouseSelection.sum7 *= 0.9;
                    player7Cost.text = HouseSelection.sum7.ToString();
                }
                if (GameControl.whoTurn + 1 == 8)
                {
                    HouseSelection.sum8 *= 0.9;
                    player8Cost.text = HouseSelection.sum8.ToString();
                }
            }

        }
        challengeRuleRound--;
        if (challengeRuleRound == 0)
        {
            challengeRule = 0;
            challengeRuleRound = 2;
        }
    }

}


