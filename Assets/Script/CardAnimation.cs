using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardAnimation : MonoBehaviour {

    public static Animator anim;
    public static GameObject Card2;
    public Button dropButton;
    public Text text1, text2, text3, text4, text5;

	void Start () {
        anim = GetComponent<Animator>();
        Card2 = GameObject.Find("CardAnimation");
    }

    public void PlayAnimation()
    {
        dropButton.interactable = false;
        anim.Play("CardAnimation");
        StartCoroutine(TemporarilyDeactivate(2));
    }

    public IEnumerator TemporarilyDeactivate(float duration)
    {
        yield return new WaitForSeconds(duration);
        anim.Play("NewState", -1, 0f);
        dropButton.interactable = true;
        StopCoroutine(TemporarilyDeactivate(2));
        if (Card.Card1.gameObject.activeSelf == false)
        {
            if (DiceNumberTextScript.whosTurn == 1)
            {
                int NotAccept1 = 0, NotAccept2 = 0, NotAccept3 = 0, NotAccept4 = 0, NotAccept5 = 0, NotAccept6 = 0, NotAccept7 = 0, NotAccept8 = 0, NotAccept9 = 0;
                int num1 = 0, num2 =  0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0;
                int getRangeNum;

                if (DropZone.player1Card1Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player1Card1Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player1Card1Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player1Card1Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player1Card1Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player1Card1Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player1Card1Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player1Card1Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player1Card1Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player1Card2Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player1Card2Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player1Card2Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player1Card2Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player1Card2Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player1Card2Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player1Card2Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player1Card2Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player1Card2Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player1Card3Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player1Card3Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player1Card3Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player1Card3Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player1Card3Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player1Card3Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player1Card3Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player1Card3Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player1Card3Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player1Card4Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player1Card4Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player1Card4Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player1Card4Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player1Card4Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player1Card4Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player1Card4Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player1Card4Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player1Card4Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player1Card5Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player1Card5Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player1Card5Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player1Card5Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player1Card5Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player1Card5Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player1Card5Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player1Card5Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player1Card5Number9 == 1)
                    NotAccept9 = 1;

                if (NotAccept1 == 1)
                    num1 = 1;
                if (NotAccept2 == 1)
                    num2 = 2;
                if (NotAccept3 == 1)
                    num3 = 3;
                if (NotAccept4 == 1)
                    num4 = 4;
                if (NotAccept5 == 1)
                    num5 = 5;
                if (NotAccept6 == 1)
                    num6 = 6;
                if (NotAccept7 == 1)
                    num7 = 7;
                if (NotAccept8== 1)
                    num8 = 8;
                if (NotAccept9 == 1)
                    num9 = 9;

                do
                {
                    getRangeNum = Random.Range(1, 10);
                }
                while (getRangeNum == num1 || getRangeNum == num2 || getRangeNum == num3 || getRangeNum == num4 || getRangeNum == num5 || getRangeNum == num6 || getRangeNum == num7 || getRangeNum == num8 || getRangeNum == num9);
                
                text1.text = getRangeNum.ToString();
                DiceNumberTextScript.player1Card1string  = text1.text;
                
                Card.Card1.gameObject.SetActive(true);
                DiceNumberTextScript.hide11 = 0;
            }
            if (DiceNumberTextScript.whosTurn == 2)
            {
                int NotAccept1 = 0, NotAccept2 = 0, NotAccept3 = 0, NotAccept4 = 0, NotAccept5 = 0, NotAccept6 = 0, NotAccept7 = 0, NotAccept8 = 0, NotAccept9 = 0;
                int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0;
                int getRangeNum;

                if (DropZone.player2Card1Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player2Card1Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player2Card1Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player2Card1Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player2Card1Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player2Card1Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player2Card1Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player2Card1Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player2Card1Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player2Card2Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player2Card2Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player2Card2Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player2Card2Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player2Card2Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player2Card2Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player2Card2Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player2Card2Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player2Card2Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player2Card3Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player2Card3Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player2Card3Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player2Card3Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player2Card3Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player2Card3Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player2Card3Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player2Card3Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player2Card3Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player2Card4Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player2Card4Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player2Card4Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player2Card4Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player2Card4Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player2Card4Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player2Card4Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player2Card4Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player2Card4Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player2Card5Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player2Card5Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player2Card5Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player2Card5Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player2Card5Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player2Card5Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player2Card5Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player2Card5Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player2Card5Number9 == 1)
                    NotAccept9 = 1;

                if (NotAccept1 == 1)
                    num1 = 1;
                if (NotAccept2 == 1)
                    num2 = 2;
                if (NotAccept3 == 1)
                    num3 = 3;
                if (NotAccept4 == 1)
                    num4 = 4;
                if (NotAccept5 == 1)
                    num5 = 5;
                if (NotAccept6 == 1)
                    num6 = 6;
                if (NotAccept7 == 1)
                    num7 = 7;
                if (NotAccept8 == 1)
                    num8 = 8;
                if (NotAccept9 == 1)
                    num9 = 9;

                do
                {
                    getRangeNum = Random.Range(1, 10);
                }
                while (getRangeNum == num1 || getRangeNum == num2 || getRangeNum == num3 || getRangeNum == num4 || getRangeNum == num5 || getRangeNum == num6 || getRangeNum == num7 || getRangeNum == num8 || getRangeNum == num9);
                text1.text = getRangeNum.ToString();
                DiceNumberTextScript.player2Card1string = text1.text;

                Card.Card1.gameObject.SetActive(true);
                DiceNumberTextScript.hide21 = 0;
            }
            if (DiceNumberTextScript.whosTurn == 3)
            {
                int NotAccept1 = 0, NotAccept2 = 0, NotAccept3 = 0, NotAccept4 = 0, NotAccept5 = 0, NotAccept6 = 0, NotAccept7 = 0, NotAccept8 = 0, NotAccept9 = 0;
                int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0;
                int getRangeNum;

                if (DropZone.player3Card1Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player3Card1Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player3Card1Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player3Card1Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player3Card1Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player3Card1Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player3Card1Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player3Card1Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player3Card1Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player3Card2Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player3Card2Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player3Card2Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player3Card2Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player3Card2Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player3Card2Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player3Card2Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player3Card2Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player3Card2Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player3Card3Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player3Card3Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player3Card3Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player3Card3Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player3Card3Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player3Card3Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player3Card3Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player3Card3Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player3Card3Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player3Card4Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player3Card4Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player3Card4Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player3Card4Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player3Card4Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player3Card4Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player3Card4Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player3Card4Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player3Card4Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player3Card5Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player3Card5Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player3Card5Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player3Card5Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player3Card5Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player3Card5Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player3Card5Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player3Card5Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player3Card5Number9 == 1)
                    NotAccept9 = 1;

                if (NotAccept1 == 1)
                    num1 = 1;
                if (NotAccept2 == 1)
                    num2 = 2;
                if (NotAccept3 == 1)
                    num3 = 3;
                if (NotAccept4 == 1)
                    num4 = 4;
                if (NotAccept5 == 1)
                    num5 = 5;
                if (NotAccept6 == 1)
                    num6 = 6;
                if (NotAccept7 == 1)
                    num7 = 7;
                if (NotAccept8 == 1)
                    num8 = 8;
                if (NotAccept9 == 1)
                    num9 = 9;

                do
                {
                    getRangeNum = Random.Range(1, 10);
                }
                while (getRangeNum == num1 || getRangeNum == num2 || getRangeNum == num3 || getRangeNum == num4 || getRangeNum == num5 || getRangeNum == num6 || getRangeNum == num7 || getRangeNum == num8 || getRangeNum == num9);
                text1.text = getRangeNum.ToString();
                DiceNumberTextScript.player3Card1string = text1.text;

                Card.Card1.gameObject.SetActive(true);
                DiceNumberTextScript.hide31 = 0;
            }
            if (DiceNumberTextScript.whosTurn == 4)
            {
                int NotAccept1 = 0, NotAccept2 = 0, NotAccept3 = 0, NotAccept4 = 0, NotAccept5 = 0, NotAccept6 = 0, NotAccept7 = 0, NotAccept8 = 0, NotAccept9 = 0;
                int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0;
                int getRangeNum;

                if (DropZone.player4Card1Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player4Card1Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player4Card1Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player4Card1Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player4Card1Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player4Card1Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player4Card1Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player4Card1Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player4Card1Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player4Card2Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player4Card2Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player4Card2Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player4Card2Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player4Card2Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player4Card2Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player4Card2Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player4Card2Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player4Card2Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player4Card3Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player4Card3Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player4Card3Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player4Card3Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player4Card3Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player4Card3Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player4Card3Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player4Card3Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player4Card3Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player4Card4Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player4Card4Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player4Card4Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player4Card4Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player4Card4Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player4Card4Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player4Card4Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player4Card4Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player4Card4Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player4Card5Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player4Card5Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player4Card5Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player4Card5Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player4Card5Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player4Card5Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player4Card5Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player4Card5Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player4Card5Number9 == 1)
                    NotAccept9 = 1;

                if (NotAccept1 == 1)
                    num1 = 1;
                if (NotAccept2 == 1)
                    num2 = 2;
                if (NotAccept3 == 1)
                    num3 = 3;
                if (NotAccept4 == 1)
                    num4 = 4;
                if (NotAccept5 == 1)
                    num5 = 5;
                if (NotAccept6 == 1)
                    num6 = 6;
                if (NotAccept7 == 1)
                    num7 = 7;
                if (NotAccept8 == 1)
                    num8 = 8;
                if (NotAccept9 == 1)
                    num9 = 9;

                do
                {
                    getRangeNum = Random.Range(1, 10);
                }
                while (getRangeNum == num1 || getRangeNum == num2 || getRangeNum == num3 || getRangeNum == num4 || getRangeNum == num5 || getRangeNum == num6 || getRangeNum == num7 || getRangeNum == num8 || getRangeNum == num9);
                text1.text = getRangeNum.ToString();
                DiceNumberTextScript.player4Card1string = text1.text;

                Card.Card1.gameObject.SetActive(true);
                DiceNumberTextScript.hide41 = 0;
            }
            if (DiceNumberTextScript.whosTurn == 5)
            {
                int NotAccept1 = 0, NotAccept2 = 0, NotAccept3 = 0, NotAccept4 = 0, NotAccept5 = 0, NotAccept6 = 0, NotAccept7 = 0, NotAccept8 = 0, NotAccept9 = 0;
                int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0;
                int getRangeNum;

                if (DropZone.player5Card1Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player5Card1Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player5Card1Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player5Card1Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player5Card1Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player5Card1Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player5Card1Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player5Card1Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player5Card1Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player5Card2Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player5Card2Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player5Card2Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player5Card2Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player5Card2Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player5Card2Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player5Card2Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player5Card2Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player5Card2Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player5Card3Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player5Card3Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player5Card3Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player5Card3Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player5Card3Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player5Card3Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player5Card3Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player5Card3Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player5Card3Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player5Card4Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player5Card4Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player5Card4Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player5Card4Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player5Card4Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player5Card4Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player5Card4Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player5Card4Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player5Card4Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player5Card5Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player5Card5Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player5Card5Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player5Card5Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player5Card5Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player5Card5Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player5Card5Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player5Card5Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player5Card5Number9 == 1)
                    NotAccept9 = 1;

                if (NotAccept1 == 1)
                    num1 = 1;
                if (NotAccept2 == 1)
                    num2 = 2;
                if (NotAccept3 == 1)
                    num3 = 3;
                if (NotAccept4 == 1)
                    num4 = 4;
                if (NotAccept5 == 1)
                    num5 = 5;
                if (NotAccept6 == 1)
                    num6 = 6;
                if (NotAccept7 == 1)
                    num7 = 7;
                if (NotAccept8 == 1)
                    num8 = 8;
                if (NotAccept9 == 1)
                    num9 = 9;

                do
                {
                    getRangeNum = Random.Range(1, 10);
                }
                while (getRangeNum == num1 || getRangeNum == num2 || getRangeNum == num3 || getRangeNum == num4 || getRangeNum == num5 || getRangeNum == num6 || getRangeNum == num7 || getRangeNum == num8 || getRangeNum == num9);
                text1.text = getRangeNum.ToString();
                DiceNumberTextScript.player5Card1string = text1.text;

                Card.Card1.gameObject.SetActive(true);
                DiceNumberTextScript.hide51 = 0;
            }
            if (DiceNumberTextScript.whosTurn == 6)
            {
                int NotAccept1 = 0, NotAccept2 = 0, NotAccept3 = 0, NotAccept4 = 0, NotAccept5 = 0, NotAccept6 = 0, NotAccept7 = 0, NotAccept8 = 0, NotAccept9 = 0;
                int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0;
                int getRangeNum;

                if (DropZone.player6Card1Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player6Card1Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player6Card1Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player6Card1Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player6Card1Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player6Card1Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player6Card1Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player6Card1Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player6Card1Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player6Card2Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player6Card2Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player6Card2Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player6Card2Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player6Card2Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player6Card2Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player6Card2Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player6Card2Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player6Card2Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player6Card3Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player6Card3Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player6Card3Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player6Card3Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player6Card3Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player6Card3Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player6Card3Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player6Card3Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player6Card3Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player6Card4Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player6Card4Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player6Card4Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player6Card4Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player6Card4Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player6Card4Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player6Card4Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player6Card4Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player6Card4Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player6Card5Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player6Card5Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player6Card5Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player6Card5Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player6Card5Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player6Card5Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player6Card5Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player6Card5Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player6Card5Number9 == 1)
                    NotAccept9 = 1;

                if (NotAccept1 == 1)
                    num1 = 1;
                if (NotAccept2 == 1)
                    num2 = 2;
                if (NotAccept3 == 1)
                    num3 = 3;
                if (NotAccept4 == 1)
                    num4 = 4;
                if (NotAccept5 == 1)
                    num5 = 5;
                if (NotAccept6 == 1)
                    num6 = 6;
                if (NotAccept7 == 1)
                    num7 = 7;
                if (NotAccept8 == 1)
                    num8 = 8;
                if (NotAccept9 == 1)
                    num9 = 9;

                do
                {
                    getRangeNum = Random.Range(1, 10);
                }
                while (getRangeNum == num1 || getRangeNum == num2 || getRangeNum == num3 || getRangeNum == num4 || getRangeNum == num5 || getRangeNum == num6 || getRangeNum == num7 || getRangeNum == num8 || getRangeNum == num9);
                text1.text = getRangeNum.ToString();
                DiceNumberTextScript.player6Card1string = text1.text;

                Card.Card1.gameObject.SetActive(true);
                DiceNumberTextScript.hide61 = 0;
            }
            if (DiceNumberTextScript.whosTurn == 7)
            {
                int NotAccept1 = 0, NotAccept2 = 0, NotAccept3 = 0, NotAccept4 = 0, NotAccept5 = 0, NotAccept6 = 0, NotAccept7 = 0, NotAccept8 = 0, NotAccept9 = 0;
                int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0;
                int getRangeNum;

                if (DropZone.player7Card1Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player7Card1Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player7Card1Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player7Card1Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player7Card1Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player7Card1Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player7Card1Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player7Card1Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player7Card1Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player7Card2Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player7Card2Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player7Card2Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player7Card2Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player7Card2Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player7Card2Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player7Card2Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player7Card2Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player7Card2Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player7Card3Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player7Card3Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player7Card3Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player7Card3Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player7Card3Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player7Card3Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player7Card3Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player7Card3Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player7Card3Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player7Card4Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player7Card4Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player7Card4Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player7Card4Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player7Card4Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player7Card4Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player7Card4Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player7Card4Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player7Card4Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player7Card5Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player7Card5Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player7Card5Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player7Card5Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player7Card5Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player7Card5Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player7Card5Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player7Card5Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player7Card5Number9 == 1)
                    NotAccept9 = 1;

                if (NotAccept1 == 1)
                    num1 = 1;
                if (NotAccept2 == 1)
                    num2 = 2;
                if (NotAccept3 == 1)
                    num3 = 3;
                if (NotAccept4 == 1)
                    num4 = 4;
                if (NotAccept5 == 1)
                    num5 = 5;
                if (NotAccept6 == 1)
                    num6 = 6;
                if (NotAccept7 == 1)
                    num7 = 7;
                if (NotAccept8 == 1)
                    num8 = 8;
                if (NotAccept9 == 1)
                    num9 = 9;

                do
                {
                    getRangeNum = Random.Range(1, 10);
                }
                while (getRangeNum == num1 || getRangeNum == num2 || getRangeNum == num3 || getRangeNum == num4 || getRangeNum == num5 || getRangeNum == num6 || getRangeNum == num7 || getRangeNum == num8 || getRangeNum == num9);
                text1.text = getRangeNum.ToString();
                DiceNumberTextScript.player7Card1string = text1.text;

                Card.Card1.gameObject.SetActive(true);
                DiceNumberTextScript.hide71 = 0;
            }
            if (DiceNumberTextScript.whosTurn == 8)
            {
                int NotAccept1 = 0, NotAccept2 = 0, NotAccept3 = 0, NotAccept4 = 0, NotAccept5 = 0, NotAccept6 = 0, NotAccept7 = 0, NotAccept8 = 0, NotAccept9 = 0;
                int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0;
                int getRangeNum;

                if (DropZone.player8Card1Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player8Card1Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player8Card1Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player8Card1Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player8Card1Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player8Card1Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player8Card1Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player8Card1Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player8Card1Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player8Card2Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player8Card2Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player8Card2Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player8Card2Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player8Card2Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player8Card2Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player8Card2Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player8Card2Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player8Card2Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player8Card3Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player8Card3Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player8Card3Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player8Card3Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player8Card3Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player8Card3Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player8Card3Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player8Card3Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player8Card3Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player8Card4Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player8Card4Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player8Card4Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player8Card4Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player8Card4Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player8Card4Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player8Card4Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player8Card4Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player8Card4Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player8Card5Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player8Card5Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player8Card5Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player8Card5Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player8Card5Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player8Card5Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player8Card5Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player8Card5Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player8Card5Number9 == 1)
                    NotAccept9 = 1;

                if (NotAccept1 == 1)
                    num1 = 1;
                if (NotAccept2 == 1)
                    num2 = 2;
                if (NotAccept3 == 1)
                    num3 = 3;
                if (NotAccept4 == 1)
                    num4 = 4;
                if (NotAccept5 == 1)
                    num5 = 5;
                if (NotAccept6 == 1)
                    num6 = 6;
                if (NotAccept7 == 1)
                    num7 = 7;
                if (NotAccept8 == 1)
                    num8 = 8;
                if (NotAccept9 == 1)
                    num9 = 9;

                do
                {
                    getRangeNum = Random.Range(1, 10);
                }
                while (getRangeNum == num1 || getRangeNum == num2 || getRangeNum == num3 || getRangeNum == num4 || getRangeNum == num5 || getRangeNum == num6 || getRangeNum == num7 || getRangeNum == num8 || getRangeNum == num9);
                text1.text = getRangeNum.ToString();
                DiceNumberTextScript.player8Card1string = text1.text;

                Card.Card1.gameObject.SetActive(true);
                DiceNumberTextScript.hide81 = 0;
            }
        }
        else if (Card.Card2.gameObject.activeSelf == false)
        {
            if (DiceNumberTextScript.whosTurn == 1)
            {
                int NotAccept1 = 0, NotAccept2 = 0, NotAccept3 = 0, NotAccept4 = 0, NotAccept5 = 0, NotAccept6 = 0, NotAccept7 = 0, NotAccept8 = 0, NotAccept9 = 0;
                int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0;
                int getRangeNum;

                if (DropZone.player1Card1Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player1Card1Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player1Card1Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player1Card1Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player1Card1Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player1Card1Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player1Card1Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player1Card1Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player1Card1Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player1Card2Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player1Card2Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player1Card2Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player1Card2Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player1Card2Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player1Card2Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player1Card2Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player1Card2Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player1Card2Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player1Card3Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player1Card3Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player1Card3Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player1Card3Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player1Card3Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player1Card3Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player1Card3Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player1Card3Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player1Card3Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player1Card4Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player1Card4Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player1Card4Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player1Card4Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player1Card4Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player1Card4Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player1Card4Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player1Card4Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player1Card4Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player1Card5Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player1Card5Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player1Card5Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player1Card5Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player1Card5Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player1Card5Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player1Card5Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player1Card5Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player1Card5Number9 == 1)
                    NotAccept9 = 1;

                if (NotAccept1 == 1)
                    num1 = 1;
                if (NotAccept2 == 1)
                    num2 = 2;
                if (NotAccept3 == 1)
                    num3 = 3;
                if (NotAccept4 == 1)
                    num4 = 4;
                if (NotAccept5 == 1)
                    num5 = 5;
                if (NotAccept6 == 1)
                    num6 = 6;
                if (NotAccept7 == 1)
                    num7 = 7;
                if (NotAccept8 == 1)
                    num8 = 8;
                if (NotAccept9 == 1)
                    num9 = 9;

                do
                {
                    getRangeNum = Random.Range(1, 10);
                }
                while (getRangeNum == num1 || getRangeNum == num2 || getRangeNum == num3 || getRangeNum == num4 || getRangeNum == num5 || getRangeNum == num6 || getRangeNum == num7 || getRangeNum == num8 || getRangeNum == num9);

                text2.text = getRangeNum.ToString();
                DiceNumberTextScript.player1Card2string = text2.text;

                Card.Card2.gameObject.SetActive(true);
                DiceNumberTextScript.hide12 = 0;
            }
            if (DiceNumberTextScript.whosTurn == 2)
            {
                int NotAccept1 = 0, NotAccept2 = 0, NotAccept3 = 0, NotAccept4 = 0, NotAccept5 = 0, NotAccept6 = 0, NotAccept7 = 0, NotAccept8 = 0, NotAccept9 = 0;
                int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0;
                int getRangeNum;

                if (DropZone.player2Card1Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player2Card1Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player2Card1Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player2Card1Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player2Card1Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player2Card1Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player2Card1Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player2Card1Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player2Card1Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player2Card2Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player2Card2Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player2Card2Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player2Card2Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player2Card2Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player2Card2Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player2Card2Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player2Card2Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player2Card2Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player2Card3Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player2Card3Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player2Card3Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player2Card3Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player2Card3Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player2Card3Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player2Card3Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player2Card3Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player2Card3Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player2Card4Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player2Card4Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player2Card4Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player2Card4Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player2Card4Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player2Card4Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player2Card4Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player2Card4Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player2Card4Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player2Card5Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player2Card5Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player2Card5Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player2Card5Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player2Card5Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player2Card5Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player2Card5Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player2Card5Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player2Card5Number9 == 1)
                    NotAccept9 = 1;

                if (NotAccept1 == 1)
                    num1 = 1;
                if (NotAccept2 == 1)
                    num2 = 2;
                if (NotAccept3 == 1)
                    num3 = 3;
                if (NotAccept4 == 1)
                    num4 = 4;
                if (NotAccept5 == 1)
                    num5 = 5;
                if (NotAccept6 == 1)
                    num6 = 6;
                if (NotAccept7 == 1)
                    num7 = 7;
                if (NotAccept8 == 1)
                    num8 = 8;
                if (NotAccept9 == 1)
                    num9 = 9;

                do
                {
                    getRangeNum = Random.Range(1, 10);
                }
                while (getRangeNum == num1 || getRangeNum == num2 || getRangeNum == num3 || getRangeNum == num4 || getRangeNum == num5 || getRangeNum == num6 || getRangeNum == num7 || getRangeNum == num8 || getRangeNum == num9);

                text2.text = getRangeNum.ToString();
                DiceNumberTextScript.player2Card2string = text2.text;

                Card.Card2.gameObject.SetActive(true);
                DiceNumberTextScript.hide22 = 0;
            }
            if (DiceNumberTextScript.whosTurn == 3)
            {
                int NotAccept1 = 0, NotAccept2 = 0, NotAccept3 = 0, NotAccept4 = 0, NotAccept5 = 0, NotAccept6 = 0, NotAccept7 = 0, NotAccept8 = 0, NotAccept9 = 0;
                int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0;
                int getRangeNum;

                if (DropZone.player3Card2Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player3Card1Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player3Card1Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player3Card1Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player3Card1Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player3Card1Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player3Card1Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player3Card1Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player3Card1Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player3Card2Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player3Card2Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player3Card2Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player3Card2Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player3Card2Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player3Card2Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player3Card2Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player3Card2Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player3Card2Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player3Card3Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player3Card3Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player3Card3Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player3Card3Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player3Card3Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player3Card3Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player3Card3Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player3Card3Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player3Card3Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player3Card4Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player3Card4Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player3Card4Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player3Card4Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player3Card4Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player3Card4Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player3Card4Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player3Card4Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player3Card4Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player3Card5Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player3Card5Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player3Card5Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player3Card5Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player3Card5Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player3Card5Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player3Card5Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player3Card5Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player3Card5Number9 == 1)
                    NotAccept9 = 1;

                if (NotAccept1 == 1)
                    num1 = 1;
                if (NotAccept2 == 1)
                    num2 = 2;
                if (NotAccept3 == 1)
                    num3 = 3;
                if (NotAccept4 == 1)
                    num4 = 4;
                if (NotAccept5 == 1)
                    num5 = 5;
                if (NotAccept6 == 1)
                    num6 = 6;
                if (NotAccept7 == 1)
                    num7 = 7;
                if (NotAccept8 == 1)
                    num8 = 8;
                if (NotAccept9 == 1)
                    num9 = 9;

                do
                {
                    getRangeNum = Random.Range(1, 10);
                }
                while (getRangeNum == num1 || getRangeNum == num2 || getRangeNum == num3 || getRangeNum == num4 || getRangeNum == num5 || getRangeNum == num6 || getRangeNum == num7 || getRangeNum == num8 || getRangeNum == num9);

                text2.text = getRangeNum.ToString();
                DiceNumberTextScript.player3Card2string = text2.text;

                Card.Card2.gameObject.SetActive(true);
                DiceNumberTextScript.hide32 = 0;
            }
            if (DiceNumberTextScript.whosTurn == 4)
            {
                int NotAccept1 = 0, NotAccept2 = 0, NotAccept3 = 0, NotAccept4 = 0, NotAccept5 = 0, NotAccept6 = 0, NotAccept7 = 0, NotAccept8 = 0, NotAccept9 = 0;
                int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0;
                int getRangeNum;

                if (DropZone.player4Card2Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player4Card1Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player4Card1Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player4Card1Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player4Card1Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player4Card1Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player4Card1Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player4Card1Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player4Card1Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player4Card2Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player4Card2Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player4Card2Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player4Card2Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player4Card2Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player4Card2Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player4Card2Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player4Card2Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player4Card2Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player4Card3Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player4Card3Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player4Card3Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player4Card3Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player4Card3Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player4Card3Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player4Card3Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player4Card3Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player4Card3Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player4Card4Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player4Card4Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player4Card4Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player4Card4Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player4Card4Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player4Card4Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player4Card4Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player4Card4Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player4Card4Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player5Card5Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player5Card5Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player5Card5Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player5Card5Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player5Card5Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player5Card5Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player5Card5Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player5Card5Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player5Card5Number9 == 1)
                    NotAccept9 = 1;

                if (NotAccept1 == 1)
                    num1 = 1;
                if (NotAccept2 == 1)
                    num2 = 2;
                if (NotAccept3 == 1)
                    num3 = 3;
                if (NotAccept4 == 1)
                    num4 = 4;
                if (NotAccept5 == 1)
                    num5 = 5;
                if (NotAccept6 == 1)
                    num6 = 6;
                if (NotAccept7 == 1)
                    num7 = 7;
                if (NotAccept8 == 1)
                    num8 = 8;
                if (NotAccept9 == 1)
                    num9 = 9;

                do
                {
                    getRangeNum = Random.Range(1, 10);
                }
                while (getRangeNum == num1 || getRangeNum == num2 || getRangeNum == num3 || getRangeNum == num4 || getRangeNum == num5 || getRangeNum == num6 || getRangeNum == num7 || getRangeNum == num8 || getRangeNum == num9);

                text2.text = getRangeNum.ToString();
                DiceNumberTextScript.player4Card2string = text2.text;

                Card.Card2.gameObject.SetActive(true);
                DiceNumberTextScript.hide42 = 0;
            }
            if (DiceNumberTextScript.whosTurn == 5)
            {
                int NotAccept1 = 0, NotAccept2 = 0, NotAccept3 = 0, NotAccept4 = 0, NotAccept5 = 0, NotAccept6 = 0, NotAccept7 = 0, NotAccept8 = 0, NotAccept9 = 0;
                int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0;
                int getRangeNum;

                if (DropZone.player5Card2Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player5Card1Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player5Card1Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player5Card1Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player5Card1Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player5Card1Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player5Card1Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player5Card1Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player5Card1Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player5Card2Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player5Card2Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player5Card2Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player5Card2Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player5Card2Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player5Card2Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player5Card2Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player5Card2Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player5Card2Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player5Card3Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player5Card3Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player5Card3Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player5Card3Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player5Card3Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player5Card3Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player5Card3Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player5Card3Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player5Card3Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player5Card4Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player5Card4Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player5Card4Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player5Card4Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player5Card4Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player5Card4Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player5Card4Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player5Card4Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player5Card4Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player5Card5Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player5Card5Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player5Card5Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player5Card5Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player5Card5Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player5Card5Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player5Card5Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player5Card5Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player5Card5Number9 == 1)
                    NotAccept9 = 1;

                if (NotAccept1 == 1)
                    num1 = 1;
                if (NotAccept2 == 1)
                    num2 = 2;
                if (NotAccept3 == 1)
                    num3 = 3;
                if (NotAccept4 == 1)
                    num4 = 4;
                if (NotAccept5 == 1)
                    num5 = 5;
                if (NotAccept6 == 1)
                    num6 = 6;
                if (NotAccept7 == 1)
                    num7 = 7;
                if (NotAccept8 == 1)
                    num8 = 8;
                if (NotAccept9 == 1)
                    num9 = 9;

                do
                {
                    getRangeNum = Random.Range(1, 10);
                }
                while (getRangeNum == num1 || getRangeNum == num2 || getRangeNum == num3 || getRangeNum == num4 || getRangeNum == num5 || getRangeNum == num6 || getRangeNum == num7 || getRangeNum == num8 || getRangeNum == num9);

                text2.text = getRangeNum.ToString();
                DiceNumberTextScript.player5Card2string = text2.text;

                Card.Card2.gameObject.SetActive(true);
                DiceNumberTextScript.hide52 = 0;
            }
            if (DiceNumberTextScript.whosTurn == 6)
            {
                int NotAccept1 = 0, NotAccept2 = 0, NotAccept3 = 0, NotAccept4 = 0, NotAccept5 = 0, NotAccept6 = 0, NotAccept7 = 0, NotAccept8 = 0, NotAccept9 = 0;
                int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0;
                int getRangeNum;

                if (DropZone.player6Card2Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player6Card1Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player6Card1Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player6Card1Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player6Card1Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player6Card1Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player6Card1Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player6Card1Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player6Card1Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player6Card2Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player6Card2Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player6Card2Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player6Card2Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player6Card2Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player6Card2Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player6Card2Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player6Card2Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player6Card2Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player6Card3Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player6Card3Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player6Card3Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player6Card3Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player6Card3Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player6Card3Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player6Card3Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player6Card3Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player6Card3Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player6Card4Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player6Card4Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player6Card4Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player6Card4Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player6Card4Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player6Card4Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player6Card4Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player6Card4Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player6Card4Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player6Card5Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player6Card5Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player6Card5Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player6Card5Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player6Card5Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player6Card5Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player6Card5Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player6Card5Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player6Card5Number9 == 1)
                    NotAccept9 = 1;
            
                if (NotAccept1 == 1)
                    num1 = 1;
                if (NotAccept2 == 1)
                    num2 = 2;
                if (NotAccept3 == 1)
                    num3 = 3;
                if (NotAccept4 == 1)
                    num4 = 4;
                if (NotAccept5 == 1)
                    num5 = 5;
                if (NotAccept6 == 1)
                    num6 = 6;
                if (NotAccept7 == 1)
                    num7 = 7;
                if (NotAccept8 == 1)
                    num8 = 8;
                if (NotAccept9 == 1)
                    num9 = 9;

                do
                {
                    getRangeNum = Random.Range(1, 10);
                }
                while (getRangeNum == num1 || getRangeNum == num2 || getRangeNum == num3 || getRangeNum == num4 || getRangeNum == num5 || getRangeNum == num6 || getRangeNum == num7 || getRangeNum == num8 || getRangeNum == num9);

                text2.text = getRangeNum.ToString();
                DiceNumberTextScript.player6Card2string = text2.text;

                Card.Card2.gameObject.SetActive(true);
                DiceNumberTextScript.hide62 = 0;
            }
            if (DiceNumberTextScript.whosTurn == 7)
            {
                int NotAccept1 = 0, NotAccept2 = 0, NotAccept3 = 0, NotAccept4 = 0, NotAccept5 = 0, NotAccept6 = 0, NotAccept7 = 0, NotAccept8 = 0, NotAccept9 = 0;
                int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0;
                int getRangeNum;

                if (DropZone.player7Card2Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player7Card1Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player7Card1Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player7Card1Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player7Card1Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player7Card1Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player7Card1Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player7Card1Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player7Card1Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player7Card2Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player7Card2Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player7Card2Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player7Card2Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player7Card2Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player7Card2Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player7Card2Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player7Card2Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player7Card2Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player7Card3Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player7Card3Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player7Card3Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player7Card3Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player7Card3Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player7Card3Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player7Card3Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player7Card3Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player7Card3Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player7Card4Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player7Card4Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player7Card4Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player7Card4Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player7Card4Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player7Card4Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player7Card4Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player7Card4Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player7Card4Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player7Card5Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player7Card5Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player7Card5Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player7Card5Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player7Card5Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player7Card5Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player7Card5Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player7Card5Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player7Card5Number9 == 1)
                    NotAccept9 = 1;

                if (NotAccept1 == 1)
                    num1 = 1;
                if (NotAccept2 == 1)
                    num2 = 2;
                if (NotAccept3 == 1)
                    num3 = 3;
                if (NotAccept4 == 1)
                    num4 = 4;
                if (NotAccept5 == 1)
                    num5 = 5;
                if (NotAccept6 == 1)
                    num6 = 6;
                if (NotAccept7 == 1)
                    num7 = 7;
                if (NotAccept8 == 1)
                    num8 = 8;
                if (NotAccept9 == 1)
                    num9 = 9;

                do
                {
                    getRangeNum = Random.Range(1, 10);
                }
                while (getRangeNum == num1 || getRangeNum == num2 || getRangeNum == num3 || getRangeNum == num4 || getRangeNum == num5 || getRangeNum == num6 || getRangeNum == num7 || getRangeNum == num8 || getRangeNum == num9);

                text2.text = getRangeNum.ToString();
                DiceNumberTextScript.player7Card2string = text2.text;

                Card.Card2.gameObject.SetActive(true);
                DiceNumberTextScript.hide72 = 0;
            }
            if (DiceNumberTextScript.whosTurn == 8)
            {
                int NotAccept1 = 0, NotAccept2 = 0, NotAccept3 = 0, NotAccept4 = 0, NotAccept5 = 0, NotAccept6 = 0, NotAccept7 = 0, NotAccept8 = 0, NotAccept9 = 0;
                int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0;
                int getRangeNum;

                if (DropZone.player8Card2Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player8Card1Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player8Card1Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player8Card1Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player8Card1Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player8Card1Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player8Card1Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player8Card1Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player8Card1Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player8Card2Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player8Card2Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player8Card2Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player8Card2Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player8Card2Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player8Card2Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player8Card2Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player8Card2Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player8Card2Number9 == 1)
                    NotAccept9 = 1;
            
                if (DropZone.player8Card3Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player8Card3Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player8Card3Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player8Card3Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player8Card3Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player8Card3Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player8Card3Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player8Card3Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player8Card3Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player8Card4Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player8Card4Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player8Card4Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player8Card4Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player8Card4Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player8Card4Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player8Card4Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player8Card4Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player8Card4Number9 == 1)
                    NotAccept9 = 1;
            
                if (DropZone.player8Card5Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player8Card5Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player8Card5Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player8Card5Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player8Card5Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player8Card5Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player8Card5Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player8Card5Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player8Card5Number9 == 1)
                    NotAccept9 = 1;

                if (NotAccept1 == 1)
                    num1 = 1;
                if (NotAccept2 == 1)
                    num2 = 2;
                if (NotAccept3 == 1)
                    num3 = 3;
                if (NotAccept4 == 1)
                    num4 = 4;
                if (NotAccept5 == 1)
                    num5 = 5;
                if (NotAccept6 == 1)
                    num6 = 6;
                if (NotAccept7 == 1)
                    num7 = 7;
                if (NotAccept8 == 1)
                    num8 = 8;
                if (NotAccept9 == 1)
                    num9 = 9;

                do
                {
                    getRangeNum = Random.Range(1, 10);
                }
                while (getRangeNum == num1 || getRangeNum == num2 || getRangeNum == num3 || getRangeNum == num4 || getRangeNum == num5 || getRangeNum == num6 || getRangeNum == num7 || getRangeNum == num8 || getRangeNum == num9);

                text2.text = getRangeNum.ToString();
                DiceNumberTextScript.player8Card2string = text2.text;

                Card.Card2.gameObject.SetActive(true);
                DiceNumberTextScript.hide82 = 0;
            }
        }
        else if (Card.Card3.gameObject.activeSelf == false)
        {
            if (DiceNumberTextScript.whosTurn == 1)
            {
                int NotAccept1 = 0, NotAccept2 = 0, NotAccept3 = 0, NotAccept4 = 0, NotAccept5 = 0, NotAccept6 = 0, NotAccept7 = 0, NotAccept8 = 0, NotAccept9 = 0;
                int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0;
                int getRangeNum;

                if (DropZone.player1Card1Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player1Card1Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player1Card1Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player1Card1Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player1Card1Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player1Card1Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player1Card1Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player1Card1Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player1Card1Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player1Card2Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player1Card2Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player1Card2Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player1Card2Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player1Card2Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player1Card2Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player1Card2Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player1Card2Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player1Card2Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player1Card3Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player1Card3Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player1Card3Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player1Card3Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player1Card3Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player1Card3Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player1Card3Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player1Card3Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player1Card3Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player1Card4Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player1Card4Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player1Card4Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player1Card4Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player1Card4Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player1Card4Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player1Card4Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player1Card4Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player1Card4Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player1Card5Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player1Card5Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player1Card5Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player1Card5Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player1Card5Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player1Card5Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player1Card5Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player1Card5Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player1Card5Number9 == 1)
                    NotAccept9 = 1;

                if (NotAccept1 == 1)
                    num1 = 1;
                if (NotAccept2 == 1)
                    num2 = 2;
                if (NotAccept3 == 1)
                    num3 = 3;
                if (NotAccept4 == 1)
                    num4 = 4;
                if (NotAccept5 == 1)
                    num5 = 5;
                if (NotAccept6 == 1)
                    num6 = 6;
                if (NotAccept7 == 1)
                    num7 = 7;
                if (NotAccept8 == 1)
                    num8 = 8;
                if (NotAccept9 == 1)
                    num9 = 9;

                do
                {
                    getRangeNum = Random.Range(1, 10);
                }
                while (getRangeNum == num1 || getRangeNum == num2 || getRangeNum == num3 || getRangeNum == num4 || getRangeNum == num5 || getRangeNum == num6 || getRangeNum == num7 || getRangeNum == num8 || getRangeNum == num9);

                text3.text = getRangeNum.ToString();
                DiceNumberTextScript.player1Card3string = text3.text;

                Card.Card3.gameObject.SetActive(true);
                DiceNumberTextScript.hide13 = 0;
            }
            if (DiceNumberTextScript.whosTurn == 2)
            {
                int NotAccept1 = 0, NotAccept2 = 0, NotAccept3 = 0, NotAccept4 = 0, NotAccept5 = 0, NotAccept6 = 0, NotAccept7 = 0, NotAccept8 = 0, NotAccept9 = 0;
                int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0;
                int getRangeNum;

                if (DropZone.player2Card1Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player2Card1Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player2Card1Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player2Card1Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player2Card1Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player2Card1Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player2Card1Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player2Card1Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player2Card1Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player2Card2Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player2Card2Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player2Card2Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player2Card2Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player2Card2Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player2Card2Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player2Card2Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player2Card2Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player2Card2Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player2Card3Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player2Card3Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player2Card3Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player2Card3Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player2Card3Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player2Card3Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player2Card3Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player2Card3Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player2Card3Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player2Card4Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player2Card4Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player2Card4Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player2Card4Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player2Card4Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player2Card4Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player2Card4Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player2Card4Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player2Card4Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player2Card5Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player2Card5Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player2Card5Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player2Card5Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player2Card5Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player2Card5Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player2Card5Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player2Card5Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player2Card5Number9 == 1)
                    NotAccept9 = 1;

                if (NotAccept1 == 1)
                    num1 = 1;
                if (NotAccept2 == 1)
                    num2 = 2;
                if (NotAccept3 == 1)
                    num3 = 3;
                if (NotAccept4 == 1)
                    num4 = 4;
                if (NotAccept5 == 1)
                    num5 = 5;
                if (NotAccept6 == 1)
                    num6 = 6;
                if (NotAccept7 == 1)
                    num7 = 7;
                if (NotAccept8 == 1)
                    num8 = 8;
                if (NotAccept9 == 1)
                    num9 = 9;

                do
                {
                    getRangeNum = Random.Range(1, 10);
                }
                while (getRangeNum == num1 || getRangeNum == num2 || getRangeNum == num3 || getRangeNum == num4 || getRangeNum == num5 || getRangeNum == num6 || getRangeNum == num7 || getRangeNum == num8 || getRangeNum == num9);

                text3.text = getRangeNum.ToString();
                DiceNumberTextScript.player2Card3string = text3.text;

                Card.Card3.gameObject.SetActive(true);
                DiceNumberTextScript.hide23 = 0;
            }
            if (DiceNumberTextScript.whosTurn == 3)
            {
                int NotAccept1 = 0, NotAccept2 = 0, NotAccept3 = 0, NotAccept4 = 0, NotAccept5 = 0, NotAccept6 = 0, NotAccept7 = 0, NotAccept8 = 0, NotAccept9 = 0;
                int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0;
                int getRangeNum;

                if (DropZone.player3Card1Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player3Card1Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player3Card1Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player3Card1Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player3Card1Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player3Card1Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player3Card1Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player3Card1Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player3Card1Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player3Card2Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player3Card2Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player3Card2Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player3Card2Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player3Card2Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player3Card2Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player3Card2Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player3Card2Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player3Card2Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player3Card3Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player3Card3Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player3Card3Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player3Card3Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player3Card3Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player3Card3Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player3Card3Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player3Card3Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player3Card3Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player3Card4Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player3Card4Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player3Card4Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player3Card4Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player3Card4Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player3Card4Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player3Card4Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player3Card4Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player3Card4Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player3Card5Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player3Card5Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player3Card5Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player3Card5Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player3Card5Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player3Card5Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player3Card5Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player3Card5Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player3Card5Number9 == 1)
                    NotAccept9 = 1;

                if (NotAccept1 == 1)
                    num1 = 1;
                if (NotAccept2 == 1)
                    num2 = 2;
                if (NotAccept3 == 1)
                    num3 = 3;
                if (NotAccept4 == 1)
                    num4 = 4;
                if (NotAccept5 == 1)
                    num5 = 5;
                if (NotAccept6 == 1)
                    num6 = 6;
                if (NotAccept7 == 1)
                    num7 = 7;
                if (NotAccept8 == 1)
                    num8 = 8;
                if (NotAccept9 == 1)
                    num9 = 9;

                do
                {
                    getRangeNum = Random.Range(1, 10);
                }
                while (getRangeNum == num1 || getRangeNum == num2 || getRangeNum == num3 || getRangeNum == num4 || getRangeNum == num5 || getRangeNum == num6 || getRangeNum == num7 || getRangeNum == num8 || getRangeNum == num9);

                text3.text = getRangeNum.ToString();
                DiceNumberTextScript.player3Card3string = text3.text;

                Card.Card3.gameObject.SetActive(true);
                DiceNumberTextScript.hide33 = 0;
            }
            if (DiceNumberTextScript.whosTurn == 4)
            {
                int NotAccept1 = 0, NotAccept2 = 0, NotAccept3 = 0, NotAccept4 = 0, NotAccept5 = 0, NotAccept6 = 0, NotAccept7 = 0, NotAccept8 = 0, NotAccept9 = 0;
                int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0;
                int getRangeNum;

                if (DropZone.player4Card1Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player4Card1Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player4Card1Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player4Card1Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player4Card1Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player4Card1Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player4Card1Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player4Card1Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player4Card1Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player4Card2Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player4Card2Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player4Card2Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player4Card2Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player4Card2Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player4Card2Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player4Card2Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player4Card2Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player4Card2Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player4Card3Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player4Card3Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player4Card3Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player4Card3Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player4Card3Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player4Card3Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player4Card3Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player4Card3Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player4Card3Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player4Card4Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player4Card4Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player4Card4Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player4Card4Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player4Card4Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player4Card4Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player4Card4Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player4Card4Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player4Card4Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player4Card5Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player4Card5Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player4Card5Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player4Card5Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player4Card5Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player4Card5Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player4Card5Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player4Card5Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player4Card5Number9 == 1)
                    NotAccept9 = 1;

                if (NotAccept1 == 1)
                    num1 = 1;
                if (NotAccept2 == 1)
                    num2 = 2;
                if (NotAccept3 == 1)
                    num3 = 3;
                if (NotAccept4 == 1)
                    num4 = 4;
                if (NotAccept5 == 1)
                    num5 = 5;
                if (NotAccept6 == 1)
                    num6 = 6;
                if (NotAccept7 == 1)
                    num7 = 7;
                if (NotAccept8 == 1)
                    num8 = 8;
                if (NotAccept9 == 1)
                    num9 = 9;

                do
                {
                    getRangeNum = Random.Range(1, 10);
                }
                while (getRangeNum == num1 || getRangeNum == num2 || getRangeNum == num3 || getRangeNum == num4 || getRangeNum == num5 || getRangeNum == num6 || getRangeNum == num7 || getRangeNum == num8 || getRangeNum == num9);

                text3.text = getRangeNum.ToString();
                DiceNumberTextScript.player4Card3string = text3.text;

                Card.Card3.gameObject.SetActive(true);
                DiceNumberTextScript.hide43 = 0;
            }
            if (DiceNumberTextScript.whosTurn == 5)
            {
                int NotAccept1 = 0, NotAccept2 = 0, NotAccept3 = 0, NotAccept4 = 0, NotAccept5 = 0, NotAccept6 = 0, NotAccept7 = 0, NotAccept8 = 0, NotAccept9 = 0;
                int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0;
                int getRangeNum;

                if (DropZone.player5Card1Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player5Card1Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player5Card1Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player5Card1Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player5Card1Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player5Card1Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player5Card1Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player5Card1Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player5Card1Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player5Card2Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player5Card2Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player5Card2Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player5Card2Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player5Card2Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player5Card2Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player5Card2Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player5Card2Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player5Card2Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player5Card3Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player5Card3Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player5Card3Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player5Card3Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player5Card3Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player5Card3Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player5Card3Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player5Card3Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player5Card3Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player5Card4Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player5Card4Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player5Card4Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player5Card4Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player5Card4Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player5Card4Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player5Card4Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player5Card4Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player5Card4Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player5Card5Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player5Card5Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player5Card5Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player5Card5Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player5Card5Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player5Card5Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player5Card5Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player5Card5Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player5Card5Number9 == 1)
                    NotAccept9 = 1;

                if (NotAccept1 == 1)
                    num1 = 1;
                if (NotAccept2 == 1)
                    num2 = 2;
                if (NotAccept3 == 1)
                    num3 = 3;
                if (NotAccept4 == 1)
                    num4 = 4;
                if (NotAccept5 == 1)
                    num5 = 5;
                if (NotAccept6 == 1)
                    num6 = 6;
                if (NotAccept7 == 1)
                    num7 = 7;
                if (NotAccept8 == 1)
                    num8 = 8;
                if (NotAccept9 == 1)
                    num9 = 9;

                do
                {
                    getRangeNum = Random.Range(1, 10);
                }
                while (getRangeNum == num1 || getRangeNum == num2 || getRangeNum == num3 || getRangeNum == num4 || getRangeNum == num5 || getRangeNum == num6 || getRangeNum == num7 || getRangeNum == num8 || getRangeNum == num9);

                text3.text = getRangeNum.ToString();
                DiceNumberTextScript.player5Card3string = text3.text;

                Card.Card3.gameObject.SetActive(true);
                DiceNumberTextScript.hide53 = 0;
            }
            if (DiceNumberTextScript.whosTurn == 6)
            {
                int NotAccept1 = 0, NotAccept2 = 0, NotAccept3 = 0, NotAccept4 = 0, NotAccept5 = 0, NotAccept6 = 0, NotAccept7 = 0, NotAccept8 = 0, NotAccept9 = 0;
                int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0;
                int getRangeNum;

                if (DropZone.player6Card1Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player6Card1Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player6Card1Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player6Card1Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player6Card1Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player6Card1Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player6Card1Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player6Card1Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player6Card1Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player6Card2Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player6Card2Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player6Card2Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player6Card2Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player6Card2Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player6Card2Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player6Card2Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player6Card2Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player6Card2Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player6Card3Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player6Card3Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player6Card3Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player6Card3Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player6Card3Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player6Card3Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player6Card3Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player6Card3Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player6Card3Number9 == 1)
                    NotAccept9 = 1;
            
                if (DropZone.player6Card4Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player6Card4Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player6Card4Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player6Card4Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player6Card4Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player6Card4Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player6Card4Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player6Card4Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player6Card4Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player6Card5Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player6Card5Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player6Card5Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player6Card5Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player6Card5Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player6Card5Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player6Card5Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player6Card5Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player6Card5Number9 == 1)
                    NotAccept9 = 1;
            
                if (NotAccept1 == 1)
                    num1 = 1;
                if (NotAccept2 == 1)
                    num2 = 2;
                if (NotAccept3 == 1)
                    num3 = 3;
                if (NotAccept4 == 1)
                    num4 = 4;
                if (NotAccept5 == 1)
                    num5 = 5;
                if (NotAccept6 == 1)
                    num6 = 6;
                if (NotAccept7 == 1)
                    num7 = 7;
                if (NotAccept8 == 1)
                    num8 = 8;
                if (NotAccept9 == 1)
                    num9 = 9;

                do
                {
                    getRangeNum = Random.Range(1, 10);
                }
                while (getRangeNum == num1 || getRangeNum == num2 || getRangeNum == num3 || getRangeNum == num4 || getRangeNum == num5 || getRangeNum == num6 || getRangeNum == num7 || getRangeNum == num8 || getRangeNum == num9);

                text3.text = getRangeNum.ToString();
                DiceNumberTextScript.player6Card3string = text3.text;

                Card.Card3.gameObject.SetActive(true);
                DiceNumberTextScript.hide63 = 0;
            }
            if (DiceNumberTextScript.whosTurn == 7)
            {
                int NotAccept1 = 0, NotAccept2 = 0, NotAccept3 = 0, NotAccept4 = 0, NotAccept5 = 0, NotAccept6 = 0, NotAccept7 = 0, NotAccept8 = 0, NotAccept9 = 0;
                int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0;
                int getRangeNum;

                if (DropZone.player7Card1Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player7Card1Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player7Card1Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player7Card1Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player7Card1Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player7Card1Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player7Card1Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player7Card1Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player7Card1Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player7Card2Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player7Card2Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player7Card2Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player7Card2Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player7Card2Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player7Card2Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player7Card2Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player7Card2Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player7Card2Number9 == 1)
                    NotAccept9 = 1;
            
                if (DropZone.player7Card3Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player7Card3Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player7Card3Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player7Card3Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player7Card3Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player7Card3Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player7Card3Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player7Card3Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player7Card3Number9 == 1)
                    NotAccept9 = 1;
            
                if (DropZone.player7Card4Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player7Card4Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player7Card4Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player7Card4Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player7Card4Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player7Card4Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player7Card4Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player7Card4Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player7Card4Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player7Card5Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player7Card5Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player7Card5Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player7Card5Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player7Card5Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player7Card5Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player7Card5Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player7Card5Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player7Card5Number9 == 1)
                    NotAccept9 = 1;

                if (NotAccept1 == 1)
                    num1 = 1;
                if (NotAccept2 == 1)
                    num2 = 2;
                if (NotAccept3 == 1)
                    num3 = 3;
                if (NotAccept4 == 1)
                    num4 = 4;
                if (NotAccept5 == 1)
                    num5 = 5;
                if (NotAccept6 == 1)
                    num6 = 6;
                if (NotAccept7 == 1)
                    num7 = 7;
                if (NotAccept8 == 1)
                    num8 = 8;
                if (NotAccept9 == 1)
                    num9 = 9;

                do
                {
                    getRangeNum = Random.Range(1, 10);
                }
                while (getRangeNum == num1 || getRangeNum == num2 || getRangeNum == num3 || getRangeNum == num4 || getRangeNum == num5 || getRangeNum == num6 || getRangeNum == num7 || getRangeNum == num8 || getRangeNum == num9);

                text3.text = getRangeNum.ToString();
                DiceNumberTextScript.player7Card3string = text3.text;

                Card.Card3.gameObject.SetActive(true);
                DiceNumberTextScript.hide73 = 0;
            }
            if (DiceNumberTextScript.whosTurn == 8)
            {
                int NotAccept1 = 0, NotAccept2 = 0, NotAccept3 = 0, NotAccept4 = 0, NotAccept5 = 0, NotAccept6 = 0, NotAccept7 = 0, NotAccept8 = 0, NotAccept9 = 0;
                int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0;
                int getRangeNum;

                if (DropZone.player8Card1Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player8Card1Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player8Card1Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player8Card1Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player8Card1Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player8Card1Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player8Card1Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player8Card1Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player8Card1Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player8Card2Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player8Card2Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player8Card2Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player8Card2Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player8Card2Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player8Card2Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player8Card2Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player8Card2Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player8Card2Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player8Card3Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player8Card3Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player8Card3Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player8Card3Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player8Card3Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player8Card3Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player8Card3Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player8Card3Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player8Card3Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player8Card4Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player8Card4Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player8Card4Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player8Card4Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player8Card4Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player8Card4Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player8Card4Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player8Card4Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player8Card4Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player8Card5Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player8Card5Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player8Card5Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player8Card5Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player8Card5Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player8Card5Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player8Card5Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player8Card5Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player8Card5Number9 == 1)
                    NotAccept9 = 1;

                if (NotAccept1 == 1)
                    num1 = 1;
                if (NotAccept2 == 1)
                    num2 = 2;
                if (NotAccept3 == 1)
                    num3 = 3;
                if (NotAccept4 == 1)
                    num4 = 4;
                if (NotAccept5 == 1)
                    num5 = 5;
                if (NotAccept6 == 1)
                    num6 = 6;
                if (NotAccept7 == 1)
                    num7 = 7;
                if (NotAccept8 == 1)
                    num8 = 8;
                if (NotAccept9 == 1)
                    num9 = 9;

                do
                {
                    getRangeNum = Random.Range(1, 10);
                }
                while (getRangeNum == num1 || getRangeNum == num2 || getRangeNum == num3 || getRangeNum == num4 || getRangeNum == num5 || getRangeNum == num6 || getRangeNum == num7 || getRangeNum == num8 || getRangeNum == num9);

                text3.text = getRangeNum.ToString();
                DiceNumberTextScript.player8Card3string = text3.text;

                Card.Card3.gameObject.SetActive(true);
                DiceNumberTextScript.hide83 = 0;
            }
        }
        else if (Card.Card4.gameObject.activeSelf == false)
        {
            if (DiceNumberTextScript.whosTurn == 1)
            {
                int NotAccept1 = 0, NotAccept2 = 0, NotAccept3 = 0, NotAccept4 = 0, NotAccept5 = 0, NotAccept6 = 0, NotAccept7 = 0, NotAccept8 = 0, NotAccept9 = 0;
                int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0;
                int getRangeNum;

                if (DropZone.player1Card1Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player1Card1Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player1Card1Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player1Card1Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player1Card1Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player1Card1Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player1Card1Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player1Card1Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player1Card1Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player1Card2Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player1Card2Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player1Card2Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player1Card2Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player1Card2Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player1Card2Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player1Card2Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player1Card2Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player1Card2Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player1Card3Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player1Card3Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player1Card3Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player1Card3Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player1Card3Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player1Card3Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player1Card3Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player1Card3Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player1Card3Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player1Card4Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player1Card4Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player1Card4Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player1Card4Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player1Card4Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player1Card4Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player1Card4Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player1Card4Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player1Card4Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player1Card5Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player1Card5Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player1Card5Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player1Card5Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player1Card5Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player1Card5Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player1Card5Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player1Card5Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player1Card5Number9 == 1)
                    NotAccept9 = 1;

                if (NotAccept1 == 1)
                    num1 = 1;
                if (NotAccept2 == 1)
                    num2 = 2;
                if (NotAccept3 == 1)
                    num3 = 3;
                if (NotAccept4 == 1)
                    num4 = 4;
                if (NotAccept5 == 1)
                    num5 = 5;
                if (NotAccept6 == 1)
                    num6 = 6;
                if (NotAccept7 == 1)
                    num7 = 7;
                if (NotAccept8 == 1)
                    num8 = 8;
                if (NotAccept9 == 1)
                    num9 = 9;

                do
                {
                    getRangeNum = Random.Range(1, 10);
                }
                while (getRangeNum == num1 || getRangeNum == num2 || getRangeNum == num3 || getRangeNum == num4 || getRangeNum == num5 || getRangeNum == num6 || getRangeNum == num7 || getRangeNum == num8 || getRangeNum == num9);

                text4.text = getRangeNum.ToString();
                DiceNumberTextScript.player1Card4string = text4.text;

                Card.Card4.gameObject.SetActive(true);
                DiceNumberTextScript.hide14 = 0;
            }
            if (DiceNumberTextScript.whosTurn == 2)
            {
                int NotAccept1 = 0, NotAccept2 = 0, NotAccept3 = 0, NotAccept4 = 0, NotAccept5 = 0, NotAccept6 = 0, NotAccept7 = 0, NotAccept8 = 0, NotAccept9 = 0;
                int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0;
                int getRangeNum;

                if (DropZone.player2Card1Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player2Card1Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player2Card1Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player2Card1Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player2Card1Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player2Card1Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player2Card1Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player2Card1Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player2Card1Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player2Card2Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player2Card2Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player2Card2Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player2Card2Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player2Card2Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player2Card2Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player2Card2Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player2Card2Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player2Card2Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player2Card3Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player2Card3Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player2Card3Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player2Card3Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player2Card3Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player2Card3Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player2Card3Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player2Card3Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player2Card3Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player2Card4Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player2Card4Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player2Card4Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player2Card4Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player2Card4Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player2Card4Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player2Card4Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player2Card4Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player2Card4Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player2Card5Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player2Card5Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player2Card5Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player2Card5Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player2Card5Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player2Card5Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player2Card5Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player2Card5Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player2Card5Number9 == 1)
                    NotAccept9 = 1;

                if (NotAccept1 == 1)
                    num1 = 1;
                if (NotAccept2 == 1)
                    num2 = 2;
                if (NotAccept3 == 1)
                    num3 = 3;
                if (NotAccept4 == 1)
                    num4 = 4;
                if (NotAccept5 == 1)
                    num5 = 5;
                if (NotAccept6 == 1)
                    num6 = 6;
                if (NotAccept7 == 1)
                    num7 = 7;
                if (NotAccept8 == 1)
                    num8 = 8;
                if (NotAccept9 == 1)
                    num9 = 9;

                do
                {
                    getRangeNum = Random.Range(1, 10);
                }
                while (getRangeNum == num1 || getRangeNum == num2 || getRangeNum == num3 || getRangeNum == num4 || getRangeNum == num5 || getRangeNum == num6 || getRangeNum == num7 || getRangeNum == num8 || getRangeNum == num9);

                text4.text = getRangeNum.ToString();
                DiceNumberTextScript.player2Card4string = text4.text;

                Card.Card4.gameObject.SetActive(true);
                DiceNumberTextScript.hide24 = 0;
            }
            if (DiceNumberTextScript.whosTurn == 3)
            {
                int NotAccept1 = 0, NotAccept2 = 0, NotAccept3 = 0, NotAccept4 = 0, NotAccept5 = 0, NotAccept6 = 0, NotAccept7 = 0, NotAccept8 = 0, NotAccept9 = 0;
                int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0;
                int getRangeNum;

                if (DropZone.player3Card1Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player3Card1Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player3Card1Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player3Card1Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player3Card1Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player3Card1Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player3Card1Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player3Card1Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player3Card1Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player3Card2Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player3Card2Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player3Card2Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player3Card2Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player3Card2Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player3Card2Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player3Card2Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player3Card2Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player3Card2Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player3Card3Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player3Card3Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player3Card3Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player3Card3Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player3Card3Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player3Card3Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player3Card3Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player3Card3Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player3Card3Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player3Card4Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player3Card4Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player3Card4Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player3Card4Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player3Card4Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player3Card4Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player3Card4Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player3Card4Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player3Card4Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player3Card5Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player3Card5Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player3Card5Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player3Card5Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player3Card5Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player3Card5Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player3Card5Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player3Card5Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player3Card5Number9 == 1)
                    NotAccept9 = 1;

                if (NotAccept1 == 1)
                    num1 = 1;
                if (NotAccept2 == 1)
                    num2 = 2;
                if (NotAccept3 == 1)
                    num3 = 3;
                if (NotAccept4 == 1)
                    num4 = 4;
                if (NotAccept5 == 1)
                    num5 = 5;
                if (NotAccept6 == 1)
                    num6 = 6;
                if (NotAccept7 == 1)
                    num7 = 7;
                if (NotAccept8 == 1)
                    num8 = 8;
                if (NotAccept9 == 1)
                    num9 = 9;

                do
                {
                    getRangeNum = Random.Range(1, 10);
                }
                while (getRangeNum == num1 || getRangeNum == num2 || getRangeNum == num3 || getRangeNum == num4 || getRangeNum == num5 || getRangeNum == num6 || getRangeNum == num7 || getRangeNum == num8 || getRangeNum == num9);

                text4.text = getRangeNum.ToString();
                DiceNumberTextScript.player3Card4string = text4.text;

                Card.Card4.gameObject.SetActive(true);
                DiceNumberTextScript.hide34 = 0;
            }
            if (DiceNumberTextScript.whosTurn == 4)
            {
                int NotAccept1 = 0, NotAccept2 = 0, NotAccept3 = 0, NotAccept4 = 0, NotAccept5 = 0, NotAccept6 = 0, NotAccept7 = 0, NotAccept8 = 0, NotAccept9 = 0;
                int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0;
                int getRangeNum;

                if (DropZone.player4Card1Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player4Card1Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player4Card1Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player4Card1Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player4Card1Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player4Card1Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player4Card1Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player4Card1Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player4Card1Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player4Card2Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player4Card2Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player4Card2Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player4Card2Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player4Card2Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player4Card2Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player4Card2Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player4Card2Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player4Card2Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player4Card3Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player4Card3Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player4Card3Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player4Card3Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player4Card3Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player4Card3Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player4Card3Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player4Card3Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player4Card3Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player4Card4Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player4Card4Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player4Card4Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player4Card4Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player4Card4Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player4Card4Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player4Card4Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player4Card4Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player4Card4Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player4Card5Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player4Card5Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player4Card5Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player4Card5Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player4Card5Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player4Card5Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player4Card5Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player4Card5Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player4Card5Number9 == 1)
                    NotAccept9 = 1;

                if (NotAccept1 == 1)
                    num1 = 1;
                if (NotAccept2 == 1)
                    num2 = 2;
                if (NotAccept3 == 1)
                    num3 = 3;
                if (NotAccept4 == 1)
                    num4 = 4;
                if (NotAccept5 == 1)
                    num5 = 5;
                if (NotAccept6 == 1)
                    num6 = 6;
                if (NotAccept7 == 1)
                    num7 = 7;
                if (NotAccept8 == 1)
                    num8 = 8;
                if (NotAccept9 == 1)
                    num9 = 9;

                do
                {
                    getRangeNum = Random.Range(1, 10);
                }
                while (getRangeNum == num1 || getRangeNum == num2 || getRangeNum == num3 || getRangeNum == num4 || getRangeNum == num5 || getRangeNum == num6 || getRangeNum == num7 || getRangeNum == num8 || getRangeNum == num9);

                text4.text = getRangeNum.ToString();
                DiceNumberTextScript.player4Card4string = text4.text;

                Card.Card4.gameObject.SetActive(true);
                DiceNumberTextScript.hide44 = 0;
            }
            if (DiceNumberTextScript.whosTurn == 5)
            {
                int NotAccept1 = 0, NotAccept2 = 0, NotAccept3 = 0, NotAccept4 = 0, NotAccept5 = 0, NotAccept6 = 0, NotAccept7 = 0, NotAccept8 = 0, NotAccept9 = 0;
                int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0;
                int getRangeNum;

                if (DropZone.player5Card1Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player5Card1Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player5Card1Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player5Card1Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player5Card1Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player5Card1Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player5Card1Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player5Card1Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player5Card1Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player5Card2Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player5Card2Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player5Card2Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player5Card2Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player5Card2Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player5Card2Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player5Card2Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player5Card2Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player5Card2Number9 == 1)
                    NotAccept9 = 1;
            
                if (DropZone.player5Card3Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player5Card3Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player5Card3Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player5Card3Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player5Card3Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player5Card3Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player5Card3Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player5Card3Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player5Card3Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player5Card4Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player5Card4Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player5Card4Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player5Card4Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player5Card4Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player5Card4Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player5Card4Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player5Card4Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player5Card4Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player5Card5Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player5Card5Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player5Card5Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player5Card5Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player5Card5Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player5Card5Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player5Card5Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player5Card5Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player5Card5Number9 == 1)
                    NotAccept9 = 1;

                if (NotAccept1 == 1)
                    num1 = 1;
                if (NotAccept2 == 1)
                    num2 = 2;
                if (NotAccept3 == 1)
                    num3 = 3;
                if (NotAccept4 == 1)
                    num4 = 4;
                if (NotAccept5 == 1)
                    num5 = 5;
                if (NotAccept6 == 1)
                    num6 = 6;
                if (NotAccept7 == 1)
                    num7 = 7;
                if (NotAccept8 == 1)
                    num8 = 8;
                if (NotAccept9 == 1)
                    num9 = 9;

                do
                {
                    getRangeNum = Random.Range(1, 10);
                }
                while (getRangeNum == num1 || getRangeNum == num2 || getRangeNum == num3 || getRangeNum == num4 || getRangeNum == num5 || getRangeNum == num6 || getRangeNum == num7 || getRangeNum == num8 || getRangeNum == num9);

                text4.text = getRangeNum.ToString();
                DiceNumberTextScript.player5Card4string = text4.text;

                Card.Card4.gameObject.SetActive(true);
                DiceNumberTextScript.hide54 = 0;
            }
            if (DiceNumberTextScript.whosTurn == 6)
            {
                int NotAccept1 = 0, NotAccept2 = 0, NotAccept3 = 0, NotAccept4 = 0, NotAccept5 = 0, NotAccept6 = 0, NotAccept7 = 0, NotAccept8 = 0, NotAccept9 = 0;
                int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0;
                int getRangeNum;

                if (DropZone.player6Card1Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player6Card1Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player6Card1Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player6Card1Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player6Card1Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player6Card1Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player6Card1Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player6Card1Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player6Card1Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player6Card2Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player6Card2Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player6Card2Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player6Card2Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player6Card2Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player6Card2Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player6Card2Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player6Card2Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player6Card2Number9 == 1)
                    NotAccept9 = 1;
            
                if (DropZone.player6Card3Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player6Card3Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player6Card3Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player6Card3Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player6Card3Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player6Card3Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player6Card3Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player6Card3Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player6Card3Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player6Card4Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player6Card4Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player6Card4Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player6Card4Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player6Card4Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player6Card4Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player6Card4Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player6Card4Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player6Card4Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player6Card5Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player6Card5Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player6Card5Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player6Card5Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player6Card5Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player6Card5Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player6Card5Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player6Card5Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player6Card5Number9 == 1)
                    NotAccept9 = 1;
            
                if (NotAccept1 == 1)
                    num1 = 1;
                if (NotAccept2 == 1)
                    num2 = 2;
                if (NotAccept3 == 1)
                    num3 = 3;
                if (NotAccept4 == 1)
                    num4 = 4;
                if (NotAccept5 == 1)
                    num5 = 5;
                if (NotAccept6 == 1)
                    num6 = 6;
                if (NotAccept7 == 1)
                    num7 = 7;
                if (NotAccept8 == 1)
                    num8 = 8;
                if (NotAccept9 == 1)
                    num9 = 9;

                do
                {
                    getRangeNum = Random.Range(1, 10);
                }
                while (getRangeNum == num1 || getRangeNum == num2 || getRangeNum == num3 || getRangeNum == num4 || getRangeNum == num5 || getRangeNum == num6 || getRangeNum == num7 || getRangeNum == num8 || getRangeNum == num9);

                text4.text = getRangeNum.ToString();
                DiceNumberTextScript.player6Card4string = text4.text;

                Card.Card4.gameObject.SetActive(true);
                DiceNumberTextScript.hide64 = 0;
            }
            if (DiceNumberTextScript.whosTurn == 7)
            {
                int NotAccept1 = 0, NotAccept2 = 0, NotAccept3 = 0, NotAccept4 = 0, NotAccept5 = 0, NotAccept6 = 0, NotAccept7 = 0, NotAccept8 = 0, NotAccept9 = 0;
                int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0;
                int getRangeNum;

                if (DropZone.player7Card1Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player7Card1Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player7Card1Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player7Card1Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player7Card1Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player7Card1Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player7Card1Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player7Card1Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player7Card1Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player7Card2Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player7Card2Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player7Card2Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player7Card2Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player7Card2Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player7Card2Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player7Card2Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player7Card2Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player7Card2Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player7Card3Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player7Card3Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player7Card3Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player7Card3Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player7Card3Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player7Card3Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player7Card3Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player7Card3Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player7Card3Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player7Card4Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player7Card4Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player7Card4Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player7Card4Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player7Card4Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player7Card4Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player7Card4Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player7Card4Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player7Card4Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player7Card5Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player7Card5Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player7Card5Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player7Card5Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player7Card5Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player7Card5Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player7Card5Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player7Card5Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player7Card5Number9 == 1)
                    NotAccept9 = 1;

                if (NotAccept1 == 1)
                    num1 = 1;
                if (NotAccept2 == 1)
                    num2 = 2;
                if (NotAccept3 == 1)
                    num3 = 3;
                if (NotAccept4 == 1)
                    num4 = 4;
                if (NotAccept5 == 1)
                    num5 = 5;
                if (NotAccept6 == 1)
                    num6 = 6;
                if (NotAccept7 == 1)
                    num7 = 7;
                if (NotAccept8 == 1)
                    num8 = 8;
                if (NotAccept9 == 1)
                    num9 = 9;

                do
                {
                    getRangeNum = Random.Range(1, 10);
                }
                while (getRangeNum == num1 || getRangeNum == num2 || getRangeNum == num3 || getRangeNum == num4 || getRangeNum == num5 || getRangeNum == num6 || getRangeNum == num7 || getRangeNum == num8 || getRangeNum == num9);

                text4.text = getRangeNum.ToString();
                DiceNumberTextScript.player7Card4string = text4.text;

                Card.Card4.gameObject.SetActive(true);
                DiceNumberTextScript.hide74 = 0;
            }
            if (DiceNumberTextScript.whosTurn == 8)
            {
                int NotAccept1 = 0, NotAccept2 = 0, NotAccept3 = 0, NotAccept4 = 0, NotAccept5 = 0, NotAccept6 = 0, NotAccept7 = 0, NotAccept8 = 0, NotAccept9 = 0;
                int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0;
                int getRangeNum;

                if (DropZone.player8Card1Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player8Card1Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player8Card1Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player8Card1Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player8Card1Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player8Card1Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player8Card1Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player8Card1Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player8Card1Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player8Card2Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player8Card2Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player8Card2Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player8Card2Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player8Card2Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player8Card2Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player8Card2Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player8Card2Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player8Card2Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player8Card3Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player8Card3Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player8Card3Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player8Card3Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player8Card3Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player8Card3Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player8Card3Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player8Card3Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player8Card3Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player8Card4Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player8Card4Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player8Card4Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player8Card4Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player8Card4Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player8Card4Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player8Card4Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player8Card4Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player8Card4Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player8Card5Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player8Card5Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player8Card5Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player8Card5Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player8Card5Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player8Card5Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player8Card5Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player8Card5Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player8Card5Number9 == 1)
                    NotAccept9 = 1;

                if (NotAccept1 == 1)
                    num1 = 1;
                if (NotAccept2 == 1)
                    num2 = 2;
                if (NotAccept3 == 1)
                    num3 = 3;
                if (NotAccept4 == 1)
                    num4 = 4;
                if (NotAccept5 == 1)
                    num5 = 5;
                if (NotAccept6 == 1)
                    num6 = 6;
                if (NotAccept7 == 1)
                    num7 = 7;
                if (NotAccept8 == 1)
                    num8 = 8;
                if (NotAccept9 == 1)
                    num9 = 9;

                do
                {
                    getRangeNum = Random.Range(1, 10);
                }
                while (getRangeNum == num1 || getRangeNum == num2 || getRangeNum == num3 || getRangeNum == num4 || getRangeNum == num5 || getRangeNum == num6 || getRangeNum == num7 || getRangeNum == num8 || getRangeNum == num9);

                text4.text = getRangeNum.ToString();
                DiceNumberTextScript.player8Card4string = text4.text;

                Card.Card4.gameObject.SetActive(true);
                DiceNumberTextScript.hide84 = 0;
            }
        }
        else if (Card.Card5.gameObject.activeSelf == false)
        {
            if (DiceNumberTextScript.whosTurn == 1)
            {
                int NotAccept1 = 0, NotAccept2 = 0, NotAccept3 = 0, NotAccept4 = 0, NotAccept5 = 0, NotAccept6 = 0, NotAccept7 = 0, NotAccept8 = 0, NotAccept9 = 0;
                int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0;
                int getRangeNum;

                if (DropZone.player1Card1Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player1Card1Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player1Card1Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player1Card1Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player1Card1Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player1Card1Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player1Card1Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player1Card1Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player1Card1Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player1Card2Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player1Card2Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player1Card2Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player1Card2Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player1Card2Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player1Card2Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player1Card2Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player1Card2Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player1Card2Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player1Card3Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player1Card3Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player1Card3Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player1Card3Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player1Card3Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player1Card3Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player1Card3Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player1Card3Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player1Card3Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player1Card4Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player1Card4Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player1Card4Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player1Card4Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player1Card4Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player1Card4Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player1Card4Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player1Card4Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player1Card4Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player1Card5Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player1Card5Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player1Card5Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player1Card5Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player1Card5Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player1Card5Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player1Card5Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player1Card5Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player1Card5Number9 == 1)
                    NotAccept9 = 1;

                if (NotAccept1 == 1)
                    num1 = 1;
                if (NotAccept2 == 1)
                    num2 = 2;
                if (NotAccept3 == 1)
                    num3 = 3;
                if (NotAccept4 == 1)
                    num4 = 4;
                if (NotAccept5 == 1)
                    num5 = 5;
                if (NotAccept6 == 1)
                    num6 = 6;
                if (NotAccept7 == 1)
                    num7 = 7;
                if (NotAccept8 == 1)
                    num8 = 8;
                if (NotAccept9 == 1)
                    num9 = 9;

                do
                {
                    getRangeNum = Random.Range(1, 10);
                }
                while (getRangeNum == num1 || getRangeNum == num2 || getRangeNum == num3 || getRangeNum == num4 || getRangeNum == num5 || getRangeNum == num6 || getRangeNum == num7 || getRangeNum == num8 || getRangeNum == num9);

                text5.text = getRangeNum.ToString();
                DiceNumberTextScript.player1Card5string = text5.text;

                Card.Card5.gameObject.SetActive(true);
                DiceNumberTextScript.hide15 = 0;
            }
            if (DiceNumberTextScript.whosTurn == 2)
            {
                int NotAccept1 = 0, NotAccept2 = 0, NotAccept3 = 0, NotAccept4 = 0, NotAccept5 = 0, NotAccept6 = 0, NotAccept7 = 0, NotAccept8 = 0, NotAccept9 = 0;
                int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0;
                int getRangeNum;

                if (DropZone.player2Card1Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player2Card1Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player2Card1Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player2Card1Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player2Card1Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player2Card1Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player2Card1Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player2Card1Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player2Card1Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player2Card2Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player2Card2Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player2Card2Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player2Card2Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player2Card2Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player2Card2Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player2Card2Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player2Card2Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player2Card2Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player2Card3Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player2Card3Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player2Card3Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player2Card3Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player2Card3Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player2Card3Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player2Card3Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player2Card3Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player2Card3Number9 == 1)
                    NotAccept9 = 1;
            
                if (DropZone.player2Card4Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player2Card4Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player2Card4Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player2Card4Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player2Card4Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player2Card4Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player2Card4Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player2Card4Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player2Card4Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player2Card5Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player2Card5Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player2Card5Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player2Card5Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player2Card5Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player2Card5Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player2Card5Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player2Card5Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player2Card5Number9 == 1)
                    NotAccept9 = 1;

                if (NotAccept1 == 1)
                    num1 = 1;
                if (NotAccept2 == 1)
                    num2 = 2;
                if (NotAccept3 == 1)
                    num3 = 3;
                if (NotAccept4 == 1)
                    num4 = 4;
                if (NotAccept5 == 1)
                    num5 = 5;
                if (NotAccept6 == 1)
                    num6 = 6;
                if (NotAccept7 == 1)
                    num7 = 7;
                if (NotAccept8 == 1)
                    num8 = 8;
                if (NotAccept9 == 1)
                    num9 = 9;

                do
                {
                    getRangeNum = Random.Range(1, 10);
                }
                while (getRangeNum == num1 || getRangeNum == num2 || getRangeNum == num3 || getRangeNum == num4 || getRangeNum == num5 || getRangeNum == num6 || getRangeNum == num7 || getRangeNum == num8 || getRangeNum == num9);

                text5.text = getRangeNum.ToString();
                DiceNumberTextScript.player2Card5string = text5.text;

                Card.Card5.gameObject.SetActive(true);
                DiceNumberTextScript.hide25 = 0;
            }
            if (DiceNumberTextScript.whosTurn == 3)
            {
                int NotAccept1 = 0, NotAccept2 = 0, NotAccept3 = 0, NotAccept4 = 0, NotAccept5 = 0, NotAccept6 = 0, NotAccept7 = 0, NotAccept8 = 0, NotAccept9 = 0;
                int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0;
                int getRangeNum;

                if (DropZone.player3Card1Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player3Card1Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player3Card1Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player3Card1Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player3Card1Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player3Card1Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player3Card1Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player3Card1Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player3Card1Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player3Card2Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player3Card2Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player3Card2Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player3Card2Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player3Card2Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player3Card2Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player3Card2Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player3Card2Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player3Card2Number9 == 1)
                    NotAccept9 = 1;
            
                if (DropZone.player3Card3Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player3Card3Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player3Card3Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player3Card3Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player3Card3Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player3Card3Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player3Card3Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player3Card3Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player3Card3Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player3Card4Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player3Card4Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player3Card4Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player3Card4Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player3Card4Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player3Card4Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player3Card4Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player3Card4Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player3Card4Number9 == 1)
                    NotAccept9 = 1;
            
                if (DropZone.player3Card5Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player3Card5Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player3Card5Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player3Card5Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player3Card5Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player3Card5Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player3Card5Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player3Card5Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player3Card5Number9 == 1)
                    NotAccept9 = 1;
            
                if (NotAccept1 == 1)
                    num1 = 1;
                if (NotAccept2 == 1)
                    num2 = 2;
                if (NotAccept3 == 1)
                    num3 = 3;
                if (NotAccept4 == 1)
                    num4 = 4;
                if (NotAccept5 == 1)
                    num5 = 5;
                if (NotAccept6 == 1)
                    num6 = 6;
                if (NotAccept7 == 1)
                    num7 = 7;
                if (NotAccept8 == 1)
                    num8 = 8;
                if (NotAccept9 == 1)
                    num9 = 9;

                do
                {
                    getRangeNum = Random.Range(1, 10);
                }
                while (getRangeNum == num1 || getRangeNum == num2 || getRangeNum == num3 || getRangeNum == num4 || getRangeNum == num5 || getRangeNum == num6 || getRangeNum == num7 || getRangeNum == num8 || getRangeNum == num9);

                text5.text = getRangeNum.ToString();
                DiceNumberTextScript.player3Card5string = text5.text;

                Card.Card5.gameObject.SetActive(true);
                DiceNumberTextScript.hide35 = 0;
            }
            if (DiceNumberTextScript.whosTurn == 4)
            {
                int NotAccept1 = 0, NotAccept2 = 0, NotAccept3 = 0, NotAccept4 = 0, NotAccept5 = 0, NotAccept6 = 0, NotAccept7 = 0, NotAccept8 = 0, NotAccept9 = 0;
                int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0;
                int getRangeNum;

                if (DropZone.player4Card1Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player4Card1Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player4Card1Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player4Card1Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player4Card1Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player4Card1Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player4Card1Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player4Card1Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player4Card1Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player4Card2Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player4Card2Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player4Card2Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player4Card2Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player4Card2Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player4Card2Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player4Card2Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player4Card2Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player4Card2Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player4Card3Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player4Card3Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player4Card3Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player4Card3Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player4Card3Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player4Card3Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player4Card3Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player4Card3Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player4Card3Number9 == 1)
                    NotAccept9 = 1;
            
                if (DropZone.player4Card4Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player4Card4Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player4Card4Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player4Card4Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player4Card4Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player4Card4Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player4Card4Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player4Card4Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player4Card4Number9 == 1)
                    NotAccept9 = 1;
            
                if (DropZone.player4Card5Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player4Card5Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player4Card5Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player4Card5Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player4Card5Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player4Card5Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player4Card5Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player4Card5Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player4Card5Number9 == 1)
                    NotAccept9 = 1;

                if (NotAccept1 == 1)
                    num1 = 1;
                if (NotAccept2 == 1)
                    num2 = 2;
                if (NotAccept3 == 1)
                    num3 = 3;
                if (NotAccept4 == 1)
                    num4 = 4;
                if (NotAccept5 == 1)
                    num5 = 5;
                if (NotAccept6 == 1)
                    num6 = 6;
                if (NotAccept7 == 1)
                    num7 = 7;
                if (NotAccept8 == 1)
                    num8 = 8;
                if (NotAccept9 == 1)
                    num9 = 9;

                do
                {
                    getRangeNum = Random.Range(1, 10);
                }
                while (getRangeNum == num1 || getRangeNum == num2 || getRangeNum == num3 || getRangeNum == num4 || getRangeNum == num5 || getRangeNum == num6 || getRangeNum == num7 || getRangeNum == num8 || getRangeNum == num9);

                text5.text = getRangeNum.ToString();
                DiceNumberTextScript.player4Card5string = text5.text;

                Card.Card5.gameObject.SetActive(true);
                DiceNumberTextScript.hide45 = 0;
            }
            if (DiceNumberTextScript.whosTurn == 5)
            {
                int NotAccept1 = 0, NotAccept2 = 0, NotAccept3 = 0, NotAccept4 = 0, NotAccept5 = 0, NotAccept6 = 0, NotAccept7 = 0, NotAccept8 = 0, NotAccept9 = 0;
                int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0;
                int getRangeNum;

                if (DropZone.player5Card1Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player5Card1Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player5Card1Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player5Card1Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player5Card1Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player5Card1Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player5Card1Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player5Card1Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player5Card1Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player5Card2Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player5Card2Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player5Card2Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player5Card2Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player5Card2Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player5Card2Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player5Card2Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player5Card2Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player5Card2Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player5Card3Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player5Card3Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player5Card3Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player5Card3Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player5Card3Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player5Card3Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player5Card3Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player5Card3Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player5Card3Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player5Card4Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player5Card4Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player5Card4Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player5Card4Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player5Card4Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player5Card4Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player5Card4Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player5Card4Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player5Card4Number9 == 1)
                    NotAccept9 = 1;
            
                if (DropZone.player5Card5Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player5Card5Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player5Card5Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player5Card5Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player5Card5Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player5Card5Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player5Card5Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player5Card5Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player5Card5Number9 == 1)
                    NotAccept9 = 1;
            
                if (NotAccept1 == 1)
                    num1 = 1;
                if (NotAccept2 == 1)
                    num2 = 2;
                if (NotAccept3 == 1)
                    num3 = 3;
                if (NotAccept4 == 1)
                    num4 = 4;
                if (NotAccept5 == 1)
                    num5 = 5;
                if (NotAccept6 == 1)
                    num6 = 6;
                if (NotAccept7 == 1)
                    num7 = 7;
                if (NotAccept8 == 1)
                    num8 = 8;
                if (NotAccept9 == 1)
                    num9 = 9;

                do
                {
                    getRangeNum = Random.Range(1, 10);
                }
                while (getRangeNum == num1 || getRangeNum == num2 || getRangeNum == num3 || getRangeNum == num4 || getRangeNum == num5 || getRangeNum == num6 || getRangeNum == num7 || getRangeNum == num8 || getRangeNum == num9);

                text5.text = getRangeNum.ToString();
                DiceNumberTextScript.player5Card5string = text5.text;

                Card.Card5.gameObject.SetActive(true);
                DiceNumberTextScript.hide55 = 0;
            }
            if (DiceNumberTextScript.whosTurn == 6)
            {
                int NotAccept1 = 0, NotAccept2 = 0, NotAccept3 = 0, NotAccept4 = 0, NotAccept5 = 0, NotAccept6 = 0, NotAccept7 = 0, NotAccept8 = 0, NotAccept9 = 0;
                int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0;
                int getRangeNum;

                if (DropZone.player6Card1Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player6Card1Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player6Card1Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player6Card1Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player6Card1Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player6Card1Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player6Card1Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player6Card1Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player6Card1Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player6Card2Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player6Card2Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player6Card2Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player6Card2Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player6Card2Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player6Card2Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player6Card2Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player6Card2Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player6Card2Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player6Card3Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player6Card3Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player6Card3Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player6Card3Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player6Card3Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player6Card3Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player6Card3Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player6Card3Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player6Card3Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player6Card4Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player6Card4Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player6Card4Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player6Card4Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player6Card4Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player6Card4Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player6Card4Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player6Card4Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player6Card4Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player6Card5Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player6Card5Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player6Card5Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player6Card5Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player6Card5Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player6Card5Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player6Card5Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player6Card5Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player6Card5Number9 == 1)
                    NotAccept9 = 1;

                if (NotAccept1 == 1)
                    num1 = 1;
                if (NotAccept2 == 1)
                    num2 = 2;
                if (NotAccept3 == 1)
                    num3 = 3;
                if (NotAccept4 == 1)
                    num4 = 4;
                if (NotAccept5 == 1)
                    num5 = 5;
                if (NotAccept6 == 1)
                    num6 = 6;
                if (NotAccept7 == 1)
                    num7 = 7;
                if (NotAccept8 == 1)
                    num8 = 8;
                if (NotAccept9 == 1)
                    num9 = 9;

                do
                {
                    getRangeNum = Random.Range(1, 10);
                }
                while (getRangeNum == num1 || getRangeNum == num2 || getRangeNum == num3 || getRangeNum == num4 || getRangeNum == num5 || getRangeNum == num6 || getRangeNum == num7 || getRangeNum == num8 || getRangeNum == num9);

                text5.text = getRangeNum.ToString();
                DiceNumberTextScript.player6Card5string = text5.text;

                Card.Card5.gameObject.SetActive(true);
                DiceNumberTextScript.hide65 = 0;
            }
            if (DiceNumberTextScript.whosTurn == 7)
            {
                int NotAccept1 = 0, NotAccept2 = 0, NotAccept3 = 0, NotAccept4 = 0, NotAccept5 = 0, NotAccept6 = 0, NotAccept7 = 0, NotAccept8 = 0, NotAccept9 = 0;
                int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0;
                int getRangeNum;

                if (DropZone.player7Card1Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player7Card1Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player7Card1Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player7Card1Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player7Card1Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player7Card1Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player7Card1Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player7Card1Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player7Card1Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player7Card2Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player7Card2Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player7Card2Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player7Card2Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player7Card2Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player7Card2Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player7Card2Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player7Card2Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player7Card2Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player7Card3Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player7Card3Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player7Card3Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player7Card3Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player7Card3Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player7Card3Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player7Card3Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player7Card3Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player7Card3Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player7Card4Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player7Card4Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player7Card4Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player7Card4Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player7Card4Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player7Card4Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player7Card4Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player7Card4Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player7Card4Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player7Card5Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player7Card5Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player7Card5Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player7Card5Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player7Card5Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player7Card5Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player7Card5Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player7Card5Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player7Card5Number9 == 1)
                    NotAccept9 = 1;

                if (NotAccept1 == 1)
                    num1 = 1;
                if (NotAccept2 == 1)
                    num2 = 2;
                if (NotAccept3 == 1)
                    num3 = 3;
                if (NotAccept4 == 1)
                    num4 = 4;
                if (NotAccept5 == 1)
                    num5 = 5;
                if (NotAccept6 == 1)
                    num6 = 6;
                if (NotAccept7 == 1)
                    num7 = 7;
                if (NotAccept8 == 1)
                    num8 = 8;
                if (NotAccept9 == 1)
                    num9 = 9;

                do
                {
                    getRangeNum = Random.Range(1, 10);
                }
                while (getRangeNum == num1 || getRangeNum == num2 || getRangeNum == num3 || getRangeNum == num4 || getRangeNum == num5 || getRangeNum == num6 || getRangeNum == num7 || getRangeNum == num8 || getRangeNum == num9);

                text5.text = getRangeNum.ToString();
                DiceNumberTextScript.player7Card5string = text5.text;

                Card.Card5.gameObject.SetActive(true);
                DiceNumberTextScript.hide75 = 0;
            }
            if (DiceNumberTextScript.whosTurn == 8)
            {
                int NotAccept1 = 0, NotAccept2 = 0, NotAccept3 = 0, NotAccept4 = 0, NotAccept5 = 0, NotAccept6 = 0, NotAccept7 = 0, NotAccept8 = 0, NotAccept9 = 0;
                int num1 = 0, num2 = 0, num3 = 0, num4 = 0, num5 = 0, num6 = 0, num7 = 0, num8 = 0, num9 = 0;
                int getRangeNum;

                if (DropZone.player8Card1Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player8Card1Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player8Card1Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player8Card1Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player8Card1Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player8Card1Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player8Card1Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player8Card1Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player8Card1Number9 == 1)
                    NotAccept9 = 1;
            
                if (DropZone.player8Card2Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player8Card2Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player8Card2Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player8Card2Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player8Card2Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player8Card2Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player8Card2Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player8Card2Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player8Card2Number9 == 1)
                    NotAccept9 = 1;
            
                if (DropZone.player8Card3Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player8Card3Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player8Card3Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player8Card3Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player8Card3Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player8Card3Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player8Card3Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player8Card3Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player8Card3Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player8Card4Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player8Card4Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player8Card4Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player8Card4Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player8Card4Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player8Card4Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player8Card4Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player8Card4Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player8Card4Number9 == 1)
                    NotAccept9 = 1;

                if (DropZone.player8Card5Number1 == 1)
                    NotAccept1 = 1;
                else if (DropZone.player8Card5Number2 == 1)
                    NotAccept2 = 1;
                else if (DropZone.player8Card5Number3 == 1)
                    NotAccept3 = 1;
                else if (DropZone.player8Card5Number4 == 1)
                    NotAccept4 = 1;
                else if (DropZone.player8Card5Number5 == 1)
                    NotAccept5 = 1;
                else if (DropZone.player8Card5Number6 == 1)
                    NotAccept6 = 1;
                else if (DropZone.player8Card5Number7 == 1)
                    NotAccept7 = 1;
                else if (DropZone.player8Card5Number8 == 1)
                    NotAccept8 = 1;
                else if (DropZone.player8Card5Number9 == 1)
                    NotAccept9 = 1;

                if (NotAccept1 == 1)
                    num1 = 1;
                if (NotAccept2 == 1)
                    num2 = 2;
                if (NotAccept3 == 1)
                    num3 = 3;
                if (NotAccept4 == 1)
                    num4 = 4;
                if (NotAccept5 == 1)
                    num5 = 5;
                if (NotAccept6 == 1)
                    num6 = 6;
                if (NotAccept7 == 1)
                    num7 = 7;
                if (NotAccept8 == 1)
                    num8 = 8;
                if (NotAccept9 == 1)
                    num9 = 9;

                do
                {
                    getRangeNum = Random.Range(1, 10);
                }
                while (getRangeNum == num1 || getRangeNum == num2 || getRangeNum == num3 || getRangeNum == num4 || getRangeNum == num5 || getRangeNum == num6 || getRangeNum == num7 || getRangeNum == num8 || getRangeNum == num9);

                text5.text = getRangeNum.ToString();
                DiceNumberTextScript.player8Card5string = text5.text;

                Card.Card5.gameObject.SetActive(true);
                DiceNumberTextScript.hide85 = 0;
            }
        }
            
    }



}
