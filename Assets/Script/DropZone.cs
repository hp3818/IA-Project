using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler {

    public Text text1, text2, text3, text4, text5;
    public Text text1a, text1b, text1c, text1d, text1e;
    public Text text2a, text2b, text2c, text2d, text2e;
    public Text text3a, text3b, text3c, text3d, text3e;
    public Text text4a, text4b, text4c, text4d, text4e;
    public Text text5a, text5b, text5c, text5d, text5e;
    public Text text6a, text6b, text6c, text6d, text6e;
    public Text text7a, text7b, text7c, text7d, text7e;
    public static int childCount = 5;
    int getRangeNum = 0;
    int rangeRadomNum = 0;
    public static int
        player1Card1Number1 = 0, player1Card1Number2 = 0, player1Card1Number3 = 0, player1Card1Number4 = 0, player1Card1Number5 = 0, player1Card1Number6 = 0, player1Card1Number7 = 0, player1Card1Number8 = 0, player1Card1Number9 = 0,
        player1Card2Number1 = 0, player1Card2Number2 = 0, player1Card2Number3 = 0, player1Card2Number4 = 0, player1Card2Number5 = 0, player1Card2Number6 = 0, player1Card2Number7 = 0, player1Card2Number8 = 0, player1Card2Number9 = 0,
        player1Card3Number1 = 0, player1Card3Number2 = 0, player1Card3Number3 = 0, player1Card3Number4 = 0, player1Card3Number5 = 0, player1Card3Number6 = 0, player1Card3Number7 = 0, player1Card3Number8 = 0, player1Card3Number9 = 0,
        player1Card4Number1 = 0, player1Card4Number2 = 0, player1Card4Number3 = 0, player1Card4Number4 = 0, player1Card4Number5 = 0, player1Card4Number6 = 0, player1Card4Number7 = 0, player1Card4Number8 = 0, player1Card4Number9 = 0,
        player1Card5Number1 = 0, player1Card5Number2 = 0, player1Card5Number3 = 0, player1Card5Number4 = 0, player1Card5Number5 = 0, player1Card5Number6 = 0, player1Card5Number7 = 0, player1Card5Number8 = 0, player1Card5Number9 = 0,

        player2Card1Number1 = 0, player2Card1Number2 = 0, player2Card1Number3 = 0, player2Card1Number4 = 0, player2Card1Number5 = 0, player2Card1Number6 = 0, player2Card1Number7 = 0, player2Card1Number8 = 0, player2Card1Number9 = 0,
        player2Card2Number1 = 0, player2Card2Number2 = 0, player2Card2Number3 = 0, player2Card2Number4 = 0, player2Card2Number5 = 0, player2Card2Number6 = 0, player2Card2Number7 = 0, player2Card2Number8 = 0, player2Card2Number9 = 0,
        player2Card3Number1 = 0, player2Card3Number2 = 0, player2Card3Number3 = 0, player2Card3Number4 = 0, player2Card3Number5 = 0, player2Card3Number6 = 0, player2Card3Number7 = 0, player2Card3Number8 = 0, player2Card3Number9 = 0,
        player2Card4Number1 = 0, player2Card4Number2 = 0, player2Card4Number3 = 0, player2Card4Number4 = 0, player2Card4Number5 = 0, player2Card4Number6 = 0, player2Card4Number7 = 0, player2Card4Number8 = 0, player2Card4Number9 = 0,
        player2Card5Number1 = 0, player2Card5Number2 = 0, player2Card5Number3 = 0, player2Card5Number4 = 0, player2Card5Number5 = 0, player2Card5Number6 = 0, player2Card5Number7 = 0, player2Card5Number8 = 0, player2Card5Number9 = 0,

        player3Card1Number1 = 0, player3Card1Number2 = 0, player3Card1Number3 = 0, player3Card1Number4 = 0, player3Card1Number5 = 0, player3Card1Number6 = 0, player3Card1Number7 = 0, player3Card1Number8 = 0, player3Card1Number9 = 0,
        player3Card2Number1 = 0, player3Card2Number2 = 0, player3Card2Number3 = 0, player3Card2Number4 = 0, player3Card2Number5 = 0, player3Card2Number6 = 0, player3Card2Number7 = 0, player3Card2Number8 = 0, player3Card2Number9 = 0,
        player3Card3Number1 = 0, player3Card3Number2 = 0, player3Card3Number3 = 0, player3Card3Number4 = 0, player3Card3Number5 = 0, player3Card3Number6 = 0, player3Card3Number7 = 0, player3Card3Number8 = 0, player3Card3Number9 = 0,
        player3Card4Number1 = 0, player3Card4Number2 = 0, player3Card4Number3 = 0, player3Card4Number4 = 0, player3Card4Number5 = 0, player3Card4Number6 = 0, player3Card4Number7 = 0, player3Card4Number8 = 0, player3Card4Number9 = 0,
        player3Card5Number1 = 0, player3Card5Number2 = 0, player3Card5Number3 = 0, player3Card5Number4 = 0, player3Card5Number5 = 0, player3Card5Number6 = 0, player3Card5Number7 = 0, player3Card5Number8 = 0, player3Card5Number9 = 0,

        player4Card1Number1 = 0, player4Card1Number2 = 0, player4Card1Number3 = 0, player4Card1Number4 = 0, player4Card1Number5 = 0, player4Card1Number6 = 0, player4Card1Number7 = 0, player4Card1Number8 = 0, player4Card1Number9 = 0,
        player4Card2Number1 = 0, player4Card2Number2 = 0, player4Card2Number3 = 0, player4Card2Number4 = 0, player4Card2Number5 = 0, player4Card2Number6 = 0, player4Card2Number7 = 0, player4Card2Number8 = 0, player4Card2Number9 = 0,
        player4Card3Number1 = 0, player4Card3Number2 = 0, player4Card3Number3 = 0, player4Card3Number4 = 0, player4Card3Number5 = 0, player4Card3Number6 = 0, player4Card3Number7 = 0, player4Card3Number8 = 0, player4Card3Number9 = 0,
        player4Card4Number1 = 0, player4Card4Number2 = 0, player4Card4Number3 = 0, player4Card4Number4 = 0, player4Card4Number5 = 0, player4Card4Number6 = 0, player4Card4Number7 = 0, player4Card4Number8 = 0, player4Card4Number9 = 0,
        player4Card5Number1 = 0, player4Card5Number2 = 0, player4Card5Number3 = 0, player4Card5Number4 = 0, player4Card5Number5 = 0, player4Card5Number6 = 0, player4Card5Number7 = 0, player4Card5Number8 = 0, player4Card5Number9 = 0,

        player5Card1Number1 = 0, player5Card1Number2 = 0, player5Card1Number3 = 0, player5Card1Number4 = 0, player5Card1Number5 = 0, player5Card1Number6 = 0, player5Card1Number7 = 0, player5Card1Number8 = 0, player5Card1Number9 = 0,
        player5Card2Number1 = 0, player5Card2Number2 = 0, player5Card2Number3 = 0, player5Card2Number4 = 0, player5Card2Number5 = 0, player5Card2Number6 = 0, player5Card2Number7 = 0, player5Card2Number8 = 0, player5Card2Number9 = 0,
        player5Card3Number1 = 0, player5Card3Number2 = 0, player5Card3Number3 = 0, player5Card3Number4 = 0, player5Card3Number5 = 0, player5Card3Number6 = 0, player5Card3Number7 = 0, player5Card3Number8 = 0, player5Card3Number9 = 0,
        player5Card4Number1 = 0, player5Card4Number2 = 0, player5Card4Number3 = 0, player5Card4Number4 = 0, player5Card4Number5 = 0, player5Card4Number6 = 0, player5Card4Number7 = 0, player5Card4Number8 = 0, player5Card4Number9 = 0,
        player5Card5Number1 = 0, player5Card5Number2 = 0, player5Card5Number3 = 0, player5Card5Number4 = 0, player5Card5Number5 = 0, player5Card5Number6 = 0, player5Card5Number7 = 0, player5Card5Number8 = 0, player5Card5Number9 = 0,

        player6Card1Number1 = 0, player6Card1Number2 = 0, player6Card1Number3 = 0, player6Card1Number4 = 0, player6Card1Number5 = 0, player6Card1Number6 = 0, player6Card1Number7 = 0, player6Card1Number8 = 0, player6Card1Number9 = 0,
        player6Card2Number1 = 0, player6Card2Number2 = 0, player6Card2Number3 = 0, player6Card2Number4 = 0, player6Card2Number5 = 0, player6Card2Number6 = 0, player6Card2Number7 = 0, player6Card2Number8 = 0, player6Card2Number9 = 0,
        player6Card3Number1 = 0, player6Card3Number2 = 0, player6Card3Number3 = 0, player6Card3Number4 = 0, player6Card3Number5 = 0, player6Card3Number6 = 0, player6Card3Number7 = 0, player6Card3Number8 = 0, player6Card3Number9 = 0,
        player6Card4Number1 = 0, player6Card4Number2 = 0, player6Card4Number3 = 0, player6Card4Number4 = 0, player6Card4Number5 = 0, player6Card4Number6 = 0, player6Card4Number7 = 0, player6Card4Number8 = 0, player6Card4Number9 = 0,
        player6Card5Number1 = 0, player6Card5Number2 = 0, player6Card5Number3 = 0, player6Card5Number4 = 0, player6Card5Number5 = 0, player6Card5Number6 = 0, player6Card5Number7 = 0, player6Card5Number8 = 0, player6Card5Number9 = 0,

        player7Card1Number1 = 0, player7Card1Number2 = 0, player7Card1Number3 = 0, player7Card1Number4 = 0, player7Card1Number5 = 0, player7Card1Number6 = 0, player7Card1Number7 = 0, player7Card1Number8 = 0, player7Card1Number9 = 0,
        player7Card2Number1 = 0, player7Card2Number2 = 0, player7Card2Number3 = 0, player7Card2Number4 = 0, player7Card2Number5 = 0, player7Card2Number6 = 0, player7Card2Number7 = 0, player7Card2Number8 = 0, player7Card2Number9 = 0,
        player7Card3Number1 = 0, player7Card3Number2 = 0, player7Card3Number3 = 0, player7Card3Number4 = 0, player7Card3Number5 = 0, player7Card3Number6 = 0, player7Card3Number7 = 0, player7Card3Number8 = 0, player7Card3Number9 = 0,
        player7Card4Number1 = 0, player7Card4Number2 = 0, player7Card4Number3 = 0, player7Card4Number4 = 0, player7Card4Number5 = 0, player7Card4Number6 = 0, player7Card4Number7 = 0, player7Card4Number8 = 0, player7Card4Number9 = 0,
        player7Card5Number1 = 0, player7Card5Number2 = 0, player7Card5Number3 = 0, player7Card5Number4 = 0, player7Card5Number5 = 0, player7Card5Number6 = 0, player7Card5Number7 = 0, player7Card5Number8 = 0, player7Card5Number9 = 0,

        player8Card1Number1 = 0, player8Card1Number2 = 0, player8Card1Number3 = 0, player8Card1Number4 = 0, player8Card1Number5 = 0, player8Card1Number6 = 0, player8Card1Number7 = 0, player8Card1Number8 = 0, player8Card1Number9 = 0,
        player8Card2Number1 = 0, player8Card2Number2 = 0, player8Card2Number3 = 0, player8Card2Number4 = 0, player8Card2Number5 = 0, player8Card2Number6 = 0, player8Card2Number7 = 0, player8Card2Number8 = 0, player8Card2Number9 = 0,
        player8Card3Number1 = 0, player8Card3Number2 = 0, player8Card3Number3 = 0, player8Card3Number4 = 0, player8Card3Number5 = 0, player8Card3Number6 = 0, player8Card3Number7 = 0, player8Card3Number8 = 0, player8Card3Number9 = 0,
        player8Card4Number1 = 0, player8Card4Number2 = 0, player8Card4Number3 = 0, player8Card4Number4 = 0, player8Card4Number5 = 0, player8Card4Number6 = 0, player8Card4Number7 = 0, player8Card4Number8 = 0, player8Card4Number9 = 0,
        player8Card5Number1 = 0, player8Card5Number2 = 0, player8Card5Number3 = 0, player8Card5Number4 = 0, player8Card5Number5 = 0, player8Card5Number6 = 0, player8Card5Number7 = 0, player8Card5Number8 = 0, player8Card5Number9 = 0;

    void Start()
    {
        random();
    }

    void Update()
    {
        childCount = this.transform.childCount;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        /*
        if (eventData.pointerDrag == null)
            return;
        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        if (d != null)
        {
            d.placeholderParent = transform;
        }*/
        if (eventData.pointerDrag == null)
            return;
        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        if (d != null)
        {
            d.placeholderParent = transform;
        }

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (eventData.pointerDrag == null)
            return;
        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        if (d != null && d.placeholderParent == this.transform)
        {
            d.placeholderParent = d.parentToReturnTo;
        }
    }

    public void OnDrop(PointerEventData eventData)
    {
        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        if (d != null)
        {
            d.parentToReturnTo = transform;
        }
    }

    public void random()
    {
        for (int j = 1; j <= 8; j ++)
        {
            if (j == 1)
            {
                for (int i = 1; i <= 5; i++)
                {
                    if (i == 1)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum.ToString() == text5.text || getRangeNum.ToString() == text2.text || getRangeNum.ToString() == text3.text || getRangeNum.ToString() == text4.text);
                        text1.text = getRangeNum.ToString();
                        if (getRangeNum == 1)
                        {
                            player1Card1Number1 = 1;
                        }
                        else if (getRangeNum == 2)
                        {
                            player1Card1Number2 = 1;
                        }
                        else if (getRangeNum == 3)
                        {
                            player1Card1Number3 = 1;
                        }
                        else if (getRangeNum == 4)
                        {
                            player1Card1Number4 = 1;
                        }
                        else if (getRangeNum == 5)
                        {
                            player1Card1Number5 = 1;
                        }
                        else if (getRangeNum == 6)
                        {
                            player1Card1Number6 = 1;
                        }
                        else if (getRangeNum == 7)
                        {
                            player1Card1Number7 = 1;
                        }
                        else if (getRangeNum == 8)
                        {
                            player1Card1Number8 = 1;
                        }
                        else if (getRangeNum == 9)
                        {
                            player1Card1Number9 = 1;
                        }
                        DiceNumberTextScript.player1Card1string = text1.text;
                    }
                    else if (i == 2)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum.ToString() == text5.text || getRangeNum.ToString() == text1.text || getRangeNum.ToString() == text3.text || getRangeNum.ToString() == text4.text);
                        text2.text = getRangeNum.ToString();
                        if (getRangeNum == 1)
                        {
                            player1Card2Number1 = 1;
                        }
                        else if (getRangeNum == 2)
                        {
                            player1Card2Number2 = 1;
                        }
                        else if (getRangeNum == 3)
                        {
                            player1Card2Number3 = 1;
                        }
                        else if (getRangeNum == 4)
                        {
                            player1Card2Number4 = 1;
                        }
                        else if (getRangeNum == 5)
                        {
                            player1Card2Number5 = 1;
                        }
                        else if (getRangeNum == 6)
                        {
                            player1Card2Number6 = 1;
                        }
                        else if (getRangeNum == 7)
                        {
                            player1Card2Number7 = 1;
                        }
                        else if (getRangeNum == 8)
                        {
                            player1Card2Number8 = 1;
                        }
                        else if (getRangeNum == 9)
                        {
                            player1Card2Number9 = 1;
                        }
                        DiceNumberTextScript.player1Card2string = text2.text;
                    }
                    else if (i == 3)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum.ToString() == text2.text || getRangeNum.ToString() == text1.text || getRangeNum.ToString() == text5.text || getRangeNum.ToString() == text4.text);
                        text3.text = getRangeNum.ToString();
                        if (getRangeNum == 1)
                        {
                            player1Card3Number1 = 1;
                        }
                        else if (getRangeNum == 2)
                        {
                            player1Card3Number2 = 1;
                        }
                        else if (getRangeNum == 3)
                        {
                            player1Card3Number3 = 1;
                        }
                        else if (getRangeNum == 4)
                        {
                            player1Card3Number4 = 1;
                        }
                        else if (getRangeNum == 5)
                        {
                            player1Card3Number5 = 1;
                        }
                        else if (getRangeNum == 6)
                        {
                            player1Card3Number6 = 1;
                        }
                        else if (getRangeNum == 7)
                        {
                            player1Card3Number7 = 1;
                        }
                        else if (getRangeNum == 8)
                        {
                            player1Card3Number8 = 1;
                        }
                        else if (getRangeNum == 9)
                        {
                            player1Card3Number9 = 1;
                        }
                        DiceNumberTextScript.player1Card3string = text3.text;
                    }
                    else if (i == 4)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum.ToString() == text2.text || getRangeNum.ToString() == text1.text || getRangeNum.ToString() == text3.text || getRangeNum.ToString() == text5.text);
                        text4.text = getRangeNum.ToString();
                        if (getRangeNum == 1)
                        {
                            player1Card4Number1 = 1;
                        }
                        else if (getRangeNum == 2)
                        {
                            player1Card4Number2 = 1;
                        }
                        else if (getRangeNum == 3)
                        {
                            player1Card4Number3 = 1;
                        }
                        else if (getRangeNum == 4)
                        {
                            player1Card4Number4 = 1;
                        }
                        else if (getRangeNum == 5)
                        {
                            player1Card4Number5 = 1;
                        }
                        else if (getRangeNum == 6)
                        {
                            player1Card4Number6 = 1;
                        }
                        else if (getRangeNum == 7)
                        {
                            player1Card4Number7 = 1;
                        }
                        else if (getRangeNum == 8)
                        {
                            player1Card4Number8 = 1;
                        }
                        else if (getRangeNum == 9)
                        {
                            player1Card4Number9 = 1;
                        }
                        DiceNumberTextScript.player1Card4string = text4.text;
                    }
                    else if (i == 5)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum.ToString() == text2.text || getRangeNum.ToString() == text1.text || getRangeNum.ToString() == text3.text || getRangeNum.ToString() == text4.text);
                        text5.text = getRangeNum.ToString();
                        if (getRangeNum == 1)
                        {
                            player1Card5Number1 = 1;
                        }
                        else if (getRangeNum == 2)
                        {
                            player1Card5Number2 = 1;
                        }
                        else if (getRangeNum == 3)
                        {
                            player1Card5Number3 = 1;
                        }
                        else if (getRangeNum == 4)
                        {
                            player1Card5Number4 = 1;
                        }
                        else if (getRangeNum == 5)
                        {
                            player1Card5Number5 = 1;
                        }
                        else if (getRangeNum == 6)
                        {
                            player1Card5Number6 = 1;
                        }
                        else if (getRangeNum == 7)
                        {
                            player1Card5Number7 = 1;
                        }
                        else if (getRangeNum == 8)
                        {
                            player1Card5Number8 = 1;
                        }
                        else if (getRangeNum == 9)
                        {
                            player1Card5Number9 = 1;
                        }
                        DiceNumberTextScript.player1Card5string = text5.text;
                    }
                }
            }
            else if (j == 2)
            {
                for (int i = 1; i <= 5; i++)
                {
                    if (i == 1)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum.ToString() == text1e.text || getRangeNum.ToString() == text1b.text || getRangeNum.ToString() == text1c.text || getRangeNum.ToString() == text1d.text);
                        text2a.text = getRangeNum.ToString();
                        if (getRangeNum == 1)
                        {
                            player2Card1Number1 = 1;
                        }
                        else if (getRangeNum == 2)
                        {
                            player2Card1Number2 = 1;
                        }
                        else if (getRangeNum == 3)
                        {
                            player2Card1Number3 = 1;
                        }
                        else if (getRangeNum == 4)
                        {
                            player2Card1Number4 = 1;
                        }
                        else if (getRangeNum == 5)
                        {
                            player2Card1Number5 = 1;
                        }
                        else if (getRangeNum == 6)
                        {
                            player2Card1Number6 = 1;
                        }
                        else if (getRangeNum == 7)
                        {
                            player2Card1Number7 = 1;
                        }
                        else if (getRangeNum == 8)
                        {
                            player2Card1Number8 = 1;
                        }
                        else if (getRangeNum == 9)
                        {
                            player2Card1Number9 = 1;
                        }
                        DiceNumberTextScript.player2Card1string = text1.text;
                    }
                    else if (i == 2)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum.ToString() == text1a.text || getRangeNum.ToString() == text1e.text || getRangeNum.ToString() == text1c.text || getRangeNum.ToString() == text1d.text);
                        text1b.text = getRangeNum.ToString();
                        if (getRangeNum == 1)
                        {
                            player2Card2Number1 = 1;
                        }
                        else if (getRangeNum == 2)
                        {
                            player2Card2Number2 = 1;
                        }
                        else if (getRangeNum == 3)
                        {
                            player2Card2Number3 = 1;
                        }
                        else if (getRangeNum == 4)
                        {
                            player2Card2Number4 = 1;
                        }
                        else if (getRangeNum == 5)
                        {
                            player2Card2Number5 = 1;
                        }
                        else if (getRangeNum == 6)
                        {
                            player2Card2Number6 = 1;
                        }
                        else if (getRangeNum == 7)
                        {
                            player2Card2Number7 = 1;
                        }
                        else if (getRangeNum == 8)
                        {
                            player2Card2Number8 = 1;
                        }
                        else if (getRangeNum == 9)
                        {
                            player2Card2Number9 = 1;
                        }
                        DiceNumberTextScript.player2Card2string = text2.text;
                    }
                    else if (i == 3)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum.ToString() == text1a.text || getRangeNum.ToString() == text1b.text || getRangeNum.ToString() == text1e.text || getRangeNum.ToString() == text1d.text);
                        text1c.text = getRangeNum.ToString();
                        if (getRangeNum == 1)
                        {
                            player2Card3Number1 = 1;
                        }
                        else if (getRangeNum == 2)
                        {
                            player2Card3Number2 = 1;
                        }
                        else if (getRangeNum == 3)
                        {
                            player2Card3Number3 = 1;
                        }
                        else if (getRangeNum == 4)
                        {
                            player2Card3Number4 = 1;
                        }
                        else if (getRangeNum == 5)
                        {
                            player2Card3Number5 = 1;
                        }
                        else if (getRangeNum == 6)
                        {
                            player2Card3Number6 = 1;
                        }
                        else if (getRangeNum == 7)
                        {
                            player2Card3Number7 = 1;
                        }
                        else if (getRangeNum == 8)
                        {
                            player2Card3Number8 = 1;
                        }
                        else if (getRangeNum == 9)
                        {
                            player2Card3Number9 = 1;
                        }
                        DiceNumberTextScript.player2Card3string = text3.text;
                    }
                    else if (i == 4)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum.ToString() == text1a.text || getRangeNum.ToString() == text1b.text || getRangeNum.ToString() == text1e.text || getRangeNum.ToString() == text1c.text);
                        text1d.text = getRangeNum.ToString();
                        if (getRangeNum == 1)
                        {
                            player2Card4Number1 = 1;
                        }
                        else if (getRangeNum == 2)
                        {
                            player2Card4Number2 = 1;
                        }
                        else if (getRangeNum == 3)
                        {
                            player2Card4Number3 = 1;
                        }
                        else if (getRangeNum == 4)
                        {
                            player2Card4Number4 = 1;
                        }
                        else if (getRangeNum == 5)
                        {
                            player2Card4Number5 = 1;
                        }
                        else if (getRangeNum == 6)
                        {
                            player2Card4Number6 = 1;
                        }
                        else if (getRangeNum == 7)
                        {
                            player2Card4Number7 = 1;
                        }
                        else if (getRangeNum == 8)
                        {
                            player2Card4Number8 = 1;
                        }
                        else if (getRangeNum == 9)
                        {
                            player2Card4Number9 = 1;
                        }
                        DiceNumberTextScript.player2Card4string = text4.text;
                    }
                    else if (i == 5)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum.ToString() == text1a.text || getRangeNum.ToString() == text1b.text || getRangeNum.ToString() == text1c.text || getRangeNum.ToString() == text1d.text);
                        text1e.text = getRangeNum.ToString();
                        if (getRangeNum == 1)
                        {
                            player2Card5Number1 = 1;
                        }
                        else if (getRangeNum == 2)
                        {
                            player2Card5Number2 = 1;
                        }
                        else if (getRangeNum == 3)
                        {
                            player2Card5Number3 = 1;
                        }
                        else if (getRangeNum == 4)
                        {
                            player2Card5Number4 = 1;
                        }
                        else if (getRangeNum == 5)
                        {
                            player2Card5Number5 = 1;
                        }
                        else if (getRangeNum == 6)
                        {
                            player2Card5Number6 = 1;
                        }
                        else if (getRangeNum == 7)
                        {
                            player2Card5Number7 = 1;
                        }
                        else if (getRangeNum == 8)
                        {
                            player2Card5Number8 = 1;
                        }
                        else if (getRangeNum == 9)
                        {
                            player2Card5Number9 = 1;
                        }
                        DiceNumberTextScript.player2Card5string = text5.text;
                    }
                }
            }
            else if (j == 3)
            {
                for (int i = 1; i <= 5; i++)
                {
                    if (i == 1)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum.ToString() == text2b.text || getRangeNum.ToString() == text2c.text || getRangeNum.ToString() == text2e.text || getRangeNum.ToString() == text2d.text);
                        text2a.text = getRangeNum.ToString();
                        if (getRangeNum == 1)
                        {
                            player3Card1Number1 = 1;
                        }
                        else if (getRangeNum == 2)
                        {
                            player3Card1Number2 = 1;
                        }
                        else if (getRangeNum == 3)
                        {
                            player3Card1Number3 = 1;
                        }
                        else if (getRangeNum == 4)
                        {
                            player3Card1Number4 = 1;
                        }
                        else if (getRangeNum == 5)
                        {
                            player3Card1Number5 = 1;
                        }
                        else if (getRangeNum == 6)
                        {
                            player3Card1Number6 = 1;
                        }
                        else if (getRangeNum == 7)
                        {
                            player3Card1Number7 = 1;
                        }
                        else if (getRangeNum == 8)
                        {
                            player3Card1Number8 = 1;
                        }
                        else if (getRangeNum == 9)
                        {
                            player3Card1Number9 = 1;
                        }
                        DiceNumberTextScript.player3Card1string = text1.text;
                    }
                    else if (i == 2)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum.ToString() == text2a.text || getRangeNum.ToString() == text2c.text || getRangeNum.ToString() == text2e.text || getRangeNum.ToString() == text2d.text);
                        text2b.text = getRangeNum.ToString();
                        if (getRangeNum == 1)
                        {
                            player3Card2Number1 = 1;
                        }
                        else if (getRangeNum == 2)
                        {
                            player3Card2Number2 = 1;
                        }
                        else if (getRangeNum == 3)
                        {
                            player3Card2Number3 = 1;
                        }
                        else if (getRangeNum == 4)
                        {
                            player3Card2Number4 = 1;
                        }
                        else if (getRangeNum == 5)
                        {
                            player3Card2Number5 = 1;
                        }
                        else if (getRangeNum == 6)
                        {
                            player3Card2Number6 = 1;
                        }
                        else if (getRangeNum == 7)
                        {
                            player3Card2Number7 = 1;
                        }
                        else if (getRangeNum == 8)
                        {
                            player3Card2Number8 = 1;
                        }
                        else if (getRangeNum == 9)
                        {
                            player3Card2Number9 = 1;
                        }
                        DiceNumberTextScript.player3Card2string = text2.text;
                    }
                    else if (i == 3)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum.ToString() == text2a.text || getRangeNum.ToString() == text2b.text || getRangeNum.ToString() == text2e.text || getRangeNum.ToString() == text2d.text);
                        text2c.text = getRangeNum.ToString();
                        if (getRangeNum == 1)
                        {
                            player3Card3Number1 = 1;
                        }
                        else if (getRangeNum == 2)
                        {
                            player3Card3Number2 = 1;
                        }
                        else if (getRangeNum == 3)
                        {
                            player3Card3Number3 = 1;
                        }
                        else if (getRangeNum == 4)
                        {
                            player3Card3Number4 = 1;
                        }
                        else if (getRangeNum == 5)
                        {
                            player3Card3Number5 = 1;
                        }
                        else if (getRangeNum == 6)
                        {
                            player3Card3Number6 = 1;
                        }
                        else if (getRangeNum == 7)
                        {
                            player3Card3Number7 = 1;
                        }
                        else if (getRangeNum == 8)
                        {
                            player3Card3Number8 = 1;
                        }
                        else if (getRangeNum == 9)
                        {
                            player3Card3Number9 = 1;
                        }
                        DiceNumberTextScript.player3Card3string = text3.text;
                    }
                    else if (i == 4)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum.ToString() == text2a.text || getRangeNum.ToString() == text2b.text || getRangeNum.ToString() == text2e.text || getRangeNum.ToString() == text2c.text);
                        text2d.text = getRangeNum.ToString();
                        if (getRangeNum == 1)
                        {
                            player3Card4Number1 = 1;
                        }
                        else if (getRangeNum == 2)
                        {
                            player3Card4Number2 = 1;
                        }
                        else if (getRangeNum == 3)
                        {
                            player3Card4Number3 = 1;
                        }
                        else if (getRangeNum == 4)
                        {
                            player3Card4Number4 = 1;
                        }
                        else if (getRangeNum == 5)
                        {
                            player3Card4Number5 = 1;
                        }
                        else if (getRangeNum == 6)
                        {
                            player3Card4Number6 = 1;
                        }
                        else if (getRangeNum == 7)
                        {
                            player3Card4Number7 = 1;
                        }
                        else if (getRangeNum == 8)
                        {
                            player3Card4Number8 = 1;
                        }
                        else if (getRangeNum == 9)
                        {
                            player3Card4Number9 = 1;
                        }
                        DiceNumberTextScript.player3Card4string = text4.text;
                    }
                    else if (i == 5)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum.ToString() == text2a.text || getRangeNum.ToString() == text2b.text || getRangeNum.ToString() == text2c.text || getRangeNum.ToString() == text2d.text);
                        text2e.text = getRangeNum.ToString();
                        if (getRangeNum == 1)
                        {
                            player3Card5Number1 = 1;
                        }
                        else if (getRangeNum == 2)
                        {
                            player3Card5Number2 = 1;
                        }
                        else if (getRangeNum == 3)
                        {
                            player3Card5Number3 = 1;
                        }
                        else if (getRangeNum == 4)
                        {
                            player3Card5Number4 = 1;
                        }
                        else if (getRangeNum == 5)
                        {
                            player3Card5Number5 = 1;
                        }
                        else if (getRangeNum == 6)
                        {
                            player3Card5Number6 = 1;
                        }
                        else if (getRangeNum == 7)
                        {
                            player3Card5Number7 = 1;
                        }
                        else if (getRangeNum == 8)
                        {
                            player3Card5Number8 = 1;
                        }
                        else if (getRangeNum == 9)
                        {
                            player3Card5Number9 = 1;
                        }
                        DiceNumberTextScript.player3Card5string = text5.text;
                    }
                } 
            }
            else if (j == 4)
            {
                for (int i = 1; i <= 5; i++)
                {
                    if (i == 1)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum.ToString() == text3c.text || getRangeNum.ToString() == text3b.text || getRangeNum.ToString() == text3e.text || getRangeNum.ToString() == text3d.text);
                        text3a.text = getRangeNum.ToString();
                        if (getRangeNum == 1)
                        {
                            player4Card1Number1 = 1;
                        }
                        else if (getRangeNum == 2)
                        {
                            player4Card1Number2 = 1;
                        }
                        else if (getRangeNum == 3)
                        {
                            player4Card1Number3 = 1;
                        }
                        else if (getRangeNum == 4)
                        {
                            player4Card1Number4 = 1;
                        }
                        else if (getRangeNum == 5)
                        {
                            player4Card1Number5 = 1;
                        }
                        else if (getRangeNum == 6)
                        {
                            player4Card1Number6 = 1;
                        }
                        else if (getRangeNum == 7)
                        {
                            player4Card1Number7 = 1;
                        }
                        else if (getRangeNum == 8)
                        {
                            player4Card1Number8 = 1;
                        }
                        else if (getRangeNum == 9)
                        {
                            player4Card1Number9 = 1;
                        }
                        DiceNumberTextScript.player4Card1string = text1.text;
                    }
                    else if (i == 2)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum.ToString() == text3c.text || getRangeNum.ToString() == text3a.text || getRangeNum.ToString() == text3e.text || getRangeNum.ToString() == text3d.text);
                        text3b.text = getRangeNum.ToString();
                                                if (getRangeNum == 1)
                        {
                            player4Card2Number1 = 1;
                        }
                        else if (getRangeNum == 2)
                        {
                            player4Card2Number2 = 1;
                        }
                        else if (getRangeNum == 3)
                        {
                            player4Card2Number3 = 1;
                        }
                        else if (getRangeNum == 4)
                        {
                            player4Card2Number4 = 1;
                        }
                        else if (getRangeNum == 5)
                        {
                            player4Card2Number5 = 1;
                        }
                        else if (getRangeNum == 6)
                        {
                            player4Card2Number6 = 1;
                        }
                        else if (getRangeNum == 7)
                        {
                            player4Card2Number7 = 1;
                        }
                        else if (getRangeNum == 8)
                        {
                            player4Card2Number8 = 1;
                        }
                        else if (getRangeNum == 9)
                        {
                            player4Card2Number9 = 1;
                        }
                        DiceNumberTextScript.player4Card2string = text2.text;
                    }
                    else if (i == 3)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum.ToString() == text3a.text || getRangeNum.ToString() == text3b.text || getRangeNum.ToString() == text3e.text || getRangeNum.ToString() == text3d.text);
                        text3c.text = getRangeNum.ToString();
                        if (getRangeNum == 1)
                        {
                            player4Card3Number1 = 1;
                        }
                        else if (getRangeNum == 2)
                        {
                            player4Card3Number2 = 1;
                        }
                        else if (getRangeNum == 3)
                        {
                            player4Card3Number3 = 1;
                        }
                        else if (getRangeNum == 4)
                        {
                            player4Card3Number4 = 1;
                        }
                        else if (getRangeNum == 5)
                        {
                            player4Card3Number5 = 1;
                        }
                        else if (getRangeNum == 6)
                        {
                            player4Card3Number6 = 1;
                        }
                        else if (getRangeNum == 7)
                        {
                            player4Card3Number7 = 1;
                        }
                        else if (getRangeNum == 8)
                        {
                            player4Card3Number8 = 1;
                        }
                        else if (getRangeNum == 9)
                        {
                            player4Card3Number9 = 1;
                        }
                        DiceNumberTextScript.player4Card3string = text3.text;
                    }
                    else if (i == 4)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum.ToString() == text3a.text || getRangeNum.ToString() == text3b.text || getRangeNum.ToString() == text3e.text || getRangeNum.ToString() == text3c.text);
                        text3d.text = getRangeNum.ToString();
                        if (getRangeNum == 1)
                        {
                            player4Card4Number1 = 1;
                        }
                        else if (getRangeNum == 2)
                        {
                            player4Card4Number2 = 1;
                        }
                        else if (getRangeNum == 3)
                        {
                            player4Card4Number3 = 1;
                        }
                        else if (getRangeNum == 4)
                        {
                            player4Card4Number4 = 1;
                        }
                        else if (getRangeNum == 5)
                        {
                            player4Card4Number5 = 1;
                        }
                        else if (getRangeNum == 6)
                        {
                            player4Card4Number6 = 1;
                        }
                        else if (getRangeNum == 7)
                        {
                            player4Card4Number7 = 1;
                        }
                        else if (getRangeNum == 8)
                        {
                            player4Card4Number8 = 1;
                        }
                        else if (getRangeNum == 9)
                        {
                            player4Card4Number9 = 1;
                        }
                        DiceNumberTextScript.player4Card4string = text4.text;
                    }
                    else if (i == 5)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum.ToString() == text3a.text || getRangeNum.ToString() == text3b.text || getRangeNum.ToString() == text3c.text || getRangeNum.ToString() == text3d.text);
                        text3e.text = getRangeNum.ToString();
                        if (getRangeNum == 1)
                        {
                            player4Card5Number1 = 1;
                        }
                        else if (getRangeNum == 2)
                        {
                            player4Card5Number2 = 1;
                        }
                        else if (getRangeNum == 3)
                        {
                            player4Card5Number3 = 1;
                        }
                        else if (getRangeNum == 4)
                        {
                            player4Card5Number4 = 1;
                        }
                        else if (getRangeNum == 5)
                        {
                            player4Card5Number5 = 1;
                        }
                        else if (getRangeNum == 6)
                        {
                            player4Card5Number6 = 1;
                        }
                        else if (getRangeNum == 7)
                        {
                            player4Card5Number7 = 1;
                        }
                        else if (getRangeNum == 8)
                        {
                            player4Card5Number8 = 1;
                        }
                        else if (getRangeNum == 9)
                        {
                            player4Card5Number9 = 1;
                        }
                        DiceNumberTextScript.player4Card5string = text5.text;
                    }
                }
            }
            else if (j == 5)
            {
                for (int i = 1; i <= 5; i++)
                { 
                    if (i == 1)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum.ToString() == text4b.text || getRangeNum.ToString() == text4c.text || getRangeNum.ToString() == text4e.text || getRangeNum.ToString() == text4d.text);
                        text4a.text = getRangeNum.ToString();
                        if (getRangeNum == 1)
                        {
                            player5Card1Number1 = 1;
                        }
                        else if (getRangeNum == 2)
                        {
                            player5Card1Number2 = 1;
                        }
                        else if (getRangeNum == 3)
                        {
                            player5Card1Number3 = 1;
                        }
                        else if (getRangeNum == 4)
                        {
                            player5Card1Number4 = 1;
                        }
                        else if (getRangeNum == 5)
                        {
                            player5Card1Number5 = 1;
                        }
                        else if (getRangeNum == 6)
                        {
                            player5Card1Number6 = 1;
                        }
                        else if (getRangeNum == 7)
                        {
                            player5Card1Number7 = 1;
                        }
                        else if (getRangeNum == 8)
                        {
                            player5Card1Number8 = 1;
                        }
                        else if (getRangeNum == 9)
                        {
                            player5Card1Number9 = 1;
                        }
                        DiceNumberTextScript.player5Card1string = text1.text;
                    }
                    else if (i == 2)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum.ToString() == text4a.text || getRangeNum.ToString() == text4c.text || getRangeNum.ToString() == text4e.text || getRangeNum.ToString() == text4d.text);
                        text4b.text = getRangeNum.ToString();
                        if (getRangeNum == 1)
                        {
                            player5Card2Number1 = 1;
                        }
                        else if (getRangeNum == 2)
                        {
                            player5Card2Number2 = 1;
                        }
                        else if (getRangeNum == 3)
                        {
                            player5Card2Number3 = 1;
                        }
                        else if (getRangeNum == 4)
                        {
                            player5Card2Number4 = 1;
                        }
                        else if (getRangeNum == 5)
                        {
                            player5Card2Number5 = 1;
                        }
                        else if (getRangeNum == 6)
                        {
                            player5Card2Number6 = 1;
                        }
                        else if (getRangeNum == 7)
                        {
                            player5Card2Number7 = 1;
                        }
                        else if (getRangeNum == 8)
                        {
                            player5Card2Number8 = 1;
                        }
                        else if (getRangeNum == 9)
                        {
                            player5Card2Number9 = 1;
                        }
                        DiceNumberTextScript.player5Card2string = text2.text;
                    }
                    else if (i == 3)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum.ToString() == text4a.text || getRangeNum.ToString() == text4b.text || getRangeNum.ToString() == text4e.text || getRangeNum.ToString() == text4d.text);
                        text4c.text = getRangeNum.ToString();
                        if (getRangeNum == 1)
                        {
                            player5Card3Number1 = 1;
                        }
                        else if (getRangeNum == 2)
                        {
                            player5Card3Number2 = 1;
                        }
                        else if (getRangeNum == 3)
                        {
                            player5Card3Number3 = 1;
                        }
                        else if (getRangeNum == 4)
                        {
                            player5Card3Number4 = 1;
                        }
                        else if (getRangeNum == 5)
                        {
                            player5Card3Number5 = 1;
                        }
                        else if (getRangeNum == 6)
                        {
                            player5Card3Number6 = 1;
                        }
                        else if (getRangeNum == 7)
                        {
                            player5Card3Number7 = 1;
                        }
                        else if (getRangeNum == 8)
                        {
                            player5Card3Number8 = 1;
                        }
                        else if (getRangeNum == 9)
                        {
                            player5Card3Number9 = 1;
                        }
                        DiceNumberTextScript.player5Card3string = text3.text;
                    }
                    else if (i == 4)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum.ToString() == text4a.text || getRangeNum.ToString() == text4b.text || getRangeNum.ToString() == text4e.text || getRangeNum.ToString() == text4c.text);
                        text4d.text = getRangeNum.ToString();
                        if (getRangeNum == 1)
                        {
                            player5Card4Number1 = 1;
                        }
                        else if (getRangeNum == 2)
                        {
                            player5Card4Number2 = 1;
                        }
                        else if (getRangeNum == 3)
                        {
                            player5Card4Number3 = 1;
                        }
                        else if (getRangeNum == 4)
                        {
                            player5Card4Number4 = 1;
                        }
                        else if (getRangeNum == 5)
                        {
                            player5Card4Number5 = 1;
                        }
                        else if (getRangeNum == 6)
                        {
                            player5Card4Number6 = 1;
                        }
                        else if (getRangeNum == 7)
                        {
                            player5Card4Number7 = 1;
                        }
                        else if (getRangeNum == 8)
                        {
                            player5Card4Number8 = 1;
                        }
                        else if (getRangeNum == 9)
                        {
                            player5Card4Number9 = 1;
                        }
                        DiceNumberTextScript.player5Card4string = text4.text;
                    }
                    else if (i == 5)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum.ToString() == text4a.text || getRangeNum.ToString() == text4b.text || getRangeNum.ToString() == text4c.text || getRangeNum.ToString() == text4d.text);
                        text4e.text = getRangeNum.ToString();
                        if (getRangeNum == 1)
                        {
                            player5Card5Number1 = 1;
                        }
                        else if (getRangeNum == 2)
                        {
                            player5Card5Number2 = 1;
                        }
                        else if (getRangeNum == 3)
                        {
                            player5Card5Number3 = 1;
                        }
                        else if (getRangeNum == 4)
                        {
                            player5Card5Number4 = 1;
                        }
                        else if (getRangeNum == 5)
                        {
                            player5Card5Number5 = 1;
                        }
                        else if (getRangeNum == 6)
                        {
                            player5Card5Number6 = 1;
                        }
                        else if (getRangeNum == 7)
                        {
                            player5Card5Number7 = 1;
                        }
                        else if (getRangeNum == 8)
                        {
                            player5Card5Number8 = 1;
                        }
                        else if (getRangeNum == 9)
                        {
                            player5Card5Number9 = 1;
                        }
                        DiceNumberTextScript.player5Card5string = text5.text;
                    }
                }
            }
            else if (j == 6)
            {

                for (int i = 1; i <= 5; i++)
                {
                    if (i == 1)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum.ToString() == text5c.text || getRangeNum.ToString() == text5b.text || getRangeNum.ToString() == text5e.text || getRangeNum.ToString() == text5d.text);
                        text5e.text = getRangeNum.ToString();
                        if (getRangeNum == 1)
                        {
                            player6Card1Number1 = 1;
                        }
                        else if (getRangeNum == 2)
                        {
                            player6Card1Number2 = 1;
                        }
                        else if (getRangeNum == 3)
                        {
                            player6Card1Number3 = 1;
                        }
                        else if (getRangeNum == 4)
                        {
                            player6Card1Number4 = 1;
                        }
                        else if (getRangeNum == 5)
                        {
                            player6Card1Number5 = 1;
                        }
                        else if (getRangeNum == 6)
                        {
                            player6Card1Number6 = 1;
                        }
                        else if (getRangeNum == 7)
                        {
                            player6Card1Number7 = 1;
                        }
                        else if (getRangeNum == 8)
                        {
                            player6Card1Number8 = 1;
                        }
                        else if (getRangeNum == 9)
                        {
                            player6Card1Number9 = 1;
                        }
                        text1.text = getRangeNum.ToString();
                        DiceNumberTextScript.player6Card1string = text1.text;
                    }
                    else if (i == 2)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum.ToString() == text5a.text || getRangeNum.ToString() == text5c.text || getRangeNum.ToString() == text5e.text || getRangeNum.ToString() == text5d.text);
                        text5b.text = getRangeNum.ToString();
                        if (getRangeNum == 1)
                        {
                            player6Card2Number1 = 1;
                        }
                        else if (getRangeNum == 2)
                        {
                            player6Card2Number2 = 1;
                        }
                        else if (getRangeNum == 3)
                        {
                            player6Card2Number3 = 1;
                        }
                        else if (getRangeNum == 4)
                        {
                            player6Card2Number4 = 1;
                        }
                        else if (getRangeNum == 5)
                        {
                            player6Card2Number5 = 1;
                        }
                        else if (getRangeNum == 6)
                        {
                            player6Card2Number6 = 1;
                        }
                        else if (getRangeNum == 7)
                        {
                            player6Card2Number7 = 1;
                        }
                        else if (getRangeNum == 8)
                        {
                            player6Card2Number8 = 1;
                        }
                        else if (getRangeNum == 9)
                        {
                            player6Card2Number9 = 1;
                        }
                        DiceNumberTextScript.player6Card2string = text2.text;
                    }
                    else if (i == 3)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum.ToString() == text5a.text || getRangeNum.ToString() == text5b.text || getRangeNum.ToString() == text5e.text || getRangeNum.ToString() == text5d.text);
                        text5c.text = getRangeNum.ToString();
                        if (getRangeNum == 1)
                        {
                            player6Card3Number1 = 1;
                        }
                        else if (getRangeNum == 2)
                        {
                            player6Card3Number2 = 1;
                        }
                        else if (getRangeNum == 3)
                        {
                            player6Card3Number3 = 1;
                        }
                        else if (getRangeNum == 4)
                        {
                            player6Card3Number4 = 1;
                        }
                        else if (getRangeNum == 5)
                        {
                            player6Card3Number5 = 1;
                        }
                        else if (getRangeNum == 6)
                        {
                            player6Card3Number6 = 1;
                        }
                        else if (getRangeNum == 7)
                        {
                            player6Card3Number7 = 1;
                        }
                        else if (getRangeNum == 8)
                        {
                            player6Card3Number8 = 1;
                        }
                        else if (getRangeNum == 9)
                        {
                            player6Card3Number9 = 1;
                        }
                        DiceNumberTextScript.player6Card3string = text3.text;
                    }
                    else if (i == 4)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum.ToString() == text5a.text || getRangeNum.ToString() == text5b.text || getRangeNum.ToString() == text5e.text || getRangeNum.ToString() == text5c.text);
                        text5d.text = getRangeNum.ToString();
                        if (getRangeNum == 1)
                        {
                            player6Card4Number1 = 1;
                        }
                        else if (getRangeNum == 2)
                        {
                            player6Card4Number2 = 1;
                        }
                        else if (getRangeNum == 3)
                        {
                            player6Card4Number3 = 1;
                        }
                        else if (getRangeNum == 4)
                        {
                            player6Card4Number4 = 1;
                        }
                        else if (getRangeNum == 5)
                        {
                            player6Card4Number5 = 1;
                        }
                        else if (getRangeNum == 6)
                        {
                            player6Card4Number6 = 1;
                        }
                        else if (getRangeNum == 7)
                        {
                            player6Card4Number7 = 1;
                        }
                        else if (getRangeNum == 8)
                        {
                            player6Card4Number8 = 1;
                        }
                        else if (getRangeNum == 9)
                        {
                            player6Card4Number9 = 1;
                        }
                        DiceNumberTextScript.player6Card4string = text4.text;
                    }
                    else if (i == 5)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum.ToString() == text5a.text || getRangeNum.ToString() == text5b.text || getRangeNum.ToString() == text5c.text || getRangeNum.ToString() == text5d.text);
                        text5e.text = getRangeNum.ToString();
                        if (getRangeNum == 1)
                        {
                            player6Card5Number1 = 1;
                        }
                        else if (getRangeNum == 2)
                        {
                            player6Card5Number2 = 1;
                        }
                        else if (getRangeNum == 3)
                        {
                            player6Card5Number3 = 1;
                        }
                        else if (getRangeNum == 4)
                        {
                            player6Card5Number4 = 1;
                        }
                        else if (getRangeNum == 5)
                        {
                            player6Card5Number5 = 1;
                        }
                        else if (getRangeNum == 6)
                        {
                            player6Card5Number6 = 1;
                        }
                        else if (getRangeNum == 7)
                        {
                            player6Card5Number7 = 1;
                        }
                        else if (getRangeNum == 8)
                        {
                            player6Card5Number8 = 1;
                        }
                        else if (getRangeNum == 9)
                        {
                            player6Card5Number9 = 1;
                        }
                        DiceNumberTextScript.player6Card5string = text5.text;
                    }
                }
            }
            else if (j == 7)
            {
                for (int i = 1; i <= 5; i++)
                {
                    if (i == 1)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum.ToString() == text6b.text || getRangeNum.ToString() == text6c.text || getRangeNum.ToString() == text6e.text || getRangeNum.ToString() == text6d.text);
                        text6a.text = getRangeNum.ToString();
                        if (getRangeNum == 1)
                        {
                            player7Card1Number1 = 1;
                        }
                        else if (getRangeNum == 2)
                        {
                            player7Card1Number2 = 1;
                        }
                        else if (getRangeNum == 3)
                        {
                            player7Card1Number3 = 1;
                        }
                        else if (getRangeNum == 4)
                        {
                            player7Card1Number4 = 1;
                        }
                        else if (getRangeNum == 5)
                        {
                            player7Card1Number5 = 1;
                        }
                        else if (getRangeNum == 6)
                        {
                            player7Card1Number6 = 1;
                        }
                        else if (getRangeNum == 7)
                        {
                            player7Card1Number7 = 1;
                        }
                        else if (getRangeNum == 8)
                        {
                            player7Card1Number8 = 1;
                        }
                        else if (getRangeNum == 9)
                        {
                            player7Card1Number9 = 1;
                        }
                        DiceNumberTextScript.player7Card1string = text1.text;
                    }
                    else if (i == 2)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum.ToString() == text6a.text || getRangeNum.ToString() == text6c.text || getRangeNum.ToString() == text6e.text || getRangeNum.ToString() == text6d.text);
                        text6b.text = getRangeNum.ToString();
                        if (getRangeNum == 1)
                        {
                            player7Card2Number1 = 1;
                        }
                        else if (getRangeNum == 2)
                        {
                            player7Card2Number2 = 1;
                        }
                        else if (getRangeNum == 3)
                        {
                            player7Card2Number3 = 1;
                        }
                        else if (getRangeNum == 4)
                        {
                            player7Card2Number4 = 1;
                        }
                        else if (getRangeNum == 5)
                        {
                            player7Card2Number5 = 1;
                        }
                        else if (getRangeNum == 6)
                        {
                            player7Card2Number6 = 1;
                        }
                        else if (getRangeNum == 7)
                        {
                            player7Card2Number7 = 1;
                        }
                        else if (getRangeNum == 8)
                        {
                            player7Card2Number8 = 1;
                        }
                        else if (getRangeNum == 9)
                        {
                            player7Card2Number9 = 1;
                        }
                        DiceNumberTextScript.player7Card2string = text2.text;
                    }
                    else if (i == 3)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum.ToString() == text6a.text || getRangeNum.ToString() == text6b.text || getRangeNum.ToString() == text6e.text || getRangeNum.ToString() == text6d.text);
                        text6c.text = getRangeNum.ToString();
                        if (getRangeNum == 1)
                        {
                            player7Card3Number1 = 1;
                        }
                        else if (getRangeNum == 2)
                        {
                            player7Card3Number2 = 1;
                        }
                        else if (getRangeNum == 3)
                        {
                            player7Card3Number3 = 1;
                        }
                        else if (getRangeNum == 4)
                        {
                            player7Card3Number4 = 1;
                        }
                        else if (getRangeNum == 5)
                        {
                            player7Card3Number5 = 1;
                        }
                        else if (getRangeNum == 6)
                        {
                            player7Card3Number6 = 1;
                        }
                        else if (getRangeNum == 7)
                        {
                            player7Card3Number7 = 1;
                        }
                        else if (getRangeNum == 8)
                        {
                            player7Card3Number8 = 1;
                        }
                        else if (getRangeNum == 9)
                        {
                            player7Card3Number9 = 1;
                        }
                        DiceNumberTextScript.player7Card3string = text3.text;
                    }
                    else if (i == 4)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum.ToString() == text6a.text || getRangeNum.ToString() == text6b.text || getRangeNum.ToString() == text6e.text || getRangeNum.ToString() == text6c.text);
                        text6d.text = getRangeNum.ToString();
                        if (getRangeNum == 1)
                        {
                            player7Card4Number1 = 1;
                        }
                        else if (getRangeNum == 2)
                        {
                            player7Card4Number2 = 1;
                        }
                        else if (getRangeNum == 3)
                        {
                            player7Card4Number3 = 1;
                        }
                        else if (getRangeNum == 4)
                        {
                            player7Card4Number4 = 1;
                        }
                        else if (getRangeNum == 5)
                        {
                            player7Card4Number5 = 1;
                        }
                        else if (getRangeNum == 6)
                        {
                            player7Card4Number6 = 1;
                        }
                        else if (getRangeNum == 7)
                        {
                            player7Card4Number7 = 1;
                        }
                        else if (getRangeNum == 8)
                        {
                            player7Card4Number8 = 1;
                        }
                        else if (getRangeNum == 9)
                        {
                            player7Card4Number9 = 1;
                        }
                        DiceNumberTextScript.player7Card4string = text4.text;
                    }
                    else if (i == 5)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum.ToString() == text6a.text || getRangeNum.ToString() == text6b.text || getRangeNum.ToString() == text6c.text || getRangeNum.ToString() == text6d.text);
                        text6e.text = getRangeNum.ToString();
                        if (getRangeNum == 1)
                        {
                            player7Card5Number1 = 1;
                        }
                        else if (getRangeNum == 2)
                        {
                            player7Card5Number2 = 1;
                        }
                        else if (getRangeNum == 3)
                        {
                            player7Card5Number3 = 1;
                        }
                        else if (getRangeNum == 4)
                        {
                            player7Card5Number4 = 1;
                        }
                        else if (getRangeNum == 5)
                        {
                            player7Card5Number5 = 1;
                        }
                        else if (getRangeNum == 6)
                        {
                            player7Card5Number6 = 1;
                        }
                        else if (getRangeNum == 7)
                        {
                            player7Card5Number7 = 1;
                        }
                        else if (getRangeNum == 8)
                        {
                            player7Card5Number8 = 1;
                        }
                        else if (getRangeNum == 9)
                        {
                            player7Card5Number9 = 1;
                        }
                        DiceNumberTextScript.player7Card5string = text5.text;
                    }
                }
            }
            else if (j == 8)
            {
                for (int i = 1; i <= 5; i++)
                {
                    if (i == 1)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum.ToString() == text7c.text || getRangeNum.ToString() == text7b.text || getRangeNum.ToString() == text7e.text || getRangeNum.ToString() == text7d.text);
                        text7a.text = getRangeNum.ToString();
                        if (getRangeNum == 1)
                        {
                            player8Card1Number1 = 1;
                        }
                        else if (getRangeNum == 2)
                        {
                            player8Card1Number2 = 1;
                        }
                        else if (getRangeNum == 3)
                        {
                            player8Card1Number3 = 1;
                        }
                        else if (getRangeNum == 4)
                        {
                            player8Card1Number4 = 1;
                        }
                        else if (getRangeNum == 5)
                        {
                            player8Card1Number5 = 1;
                        }
                        else if (getRangeNum == 6)
                        {
                            player8Card1Number6 = 1;
                        }
                        else if (getRangeNum == 7)
                        {
                            player8Card1Number7 = 1;
                        }
                        else if (getRangeNum == 8)
                        {
                            player8Card1Number8 = 1;
                        }
                        else if (getRangeNum == 9)
                        {
                            player8Card1Number9 = 1;
                        }
                        DiceNumberTextScript.player8Card1string = text1.text;
                    }
                    else if (i == 2)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum.ToString() == text7a.text || getRangeNum.ToString() == text7c.text || getRangeNum.ToString() == text7e.text || getRangeNum.ToString() == text7d.text);
                        text7b.text = getRangeNum.ToString();
                        if (getRangeNum == 1)
                        {
                            player8Card2Number1 = 1;
                        }
                        else if (getRangeNum == 2)
                        {
                            player8Card2Number2 = 1;
                        }
                        else if (getRangeNum == 3)
                        {
                            player8Card2Number3 = 1;
                        }
                        else if (getRangeNum == 4)
                        {
                            player8Card2Number4 = 1;
                        }
                        else if (getRangeNum == 5)
                        {
                            player8Card2Number5 = 1;
                        }
                        else if (getRangeNum == 6)
                        {
                            player8Card2Number6 = 1;
                        }
                        else if (getRangeNum == 7)
                        {
                            player8Card2Number7 = 1;
                        }
                        else if (getRangeNum == 8)
                        {
                            player8Card2Number8 = 1;
                        }
                        else if (getRangeNum == 9)
                        {
                            player8Card2Number9 = 1;
                        }
                        DiceNumberTextScript.player8Card2string = text2.text;
                    }
                    else if (i == 3)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum.ToString() == text7a.text || getRangeNum.ToString() == text7b.text || getRangeNum.ToString() == text7e.text || getRangeNum.ToString() == text7d.text);
                        text7c.text = getRangeNum.ToString();
                        if (getRangeNum == 1)
                        {
                            player8Card3Number1 = 1;
                        }
                        else if (getRangeNum == 2)
                        {
                            player8Card3Number2 = 1;
                        }
                        else if (getRangeNum == 3)
                        {
                            player8Card3Number3 = 1;
                        }
                        else if (getRangeNum == 4)
                        {
                            player8Card3Number4 = 1;
                        }
                        else if (getRangeNum == 5)
                        {
                            player8Card3Number5 = 1;
                        }
                        else if (getRangeNum == 6)
                        {
                            player8Card3Number6 = 1;
                        }
                        else if (getRangeNum == 7)
                        {
                            player8Card3Number7 = 1;
                        }
                        else if (getRangeNum == 8)
                        {
                            player8Card3Number8 = 1;
                        }
                        else if (getRangeNum == 9)
                        {
                            player8Card3Number9 = 1;
                        }
                        DiceNumberTextScript.player8Card3string = text3.text;
                    }
                    else if (i == 4)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum.ToString() == text7a.text || getRangeNum.ToString() == text7b.text || getRangeNum.ToString() == text7e.text || getRangeNum.ToString() == text7c.text);
                        text7d.text = getRangeNum.ToString();
                        if (getRangeNum == 1)
                        {
                            player8Card4Number1 = 1;
                        }
                        else if (getRangeNum == 2)
                        {
                            player8Card4Number2 = 1;
                        }
                        else if (getRangeNum == 3)
                        {
                            player8Card4Number3 = 1;
                        }
                        else if (getRangeNum == 4)
                        {
                            player8Card4Number4 = 1;
                        }
                        else if (getRangeNum == 5)
                        {
                            player8Card4Number5 = 1;
                        }
                        else if (getRangeNum == 6)
                        {
                            player8Card4Number6 = 1;
                        }
                        else if (getRangeNum == 7)
                        {
                            player8Card4Number7 = 1;
                        }
                        else if (getRangeNum == 8)
                        {
                            player8Card4Number8 = 1;
                        }
                        else if (getRangeNum == 9)
                        {
                            player8Card4Number9 = 1;
                        }
                        DiceNumberTextScript.player2Card4string = text4.text;
                    }
                    else if (i == 5)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum.ToString() == text7a.text || getRangeNum.ToString() == text7b.text || getRangeNum.ToString() == text7c.text || getRangeNum.ToString() == text7d.text);
                        text7e.text = getRangeNum.ToString();
                        if (getRangeNum == 1)
                        {
                            player8Card5Number1 = 1;
                        }
                        else if (getRangeNum == 2)
                        {
                            player8Card5Number2 = 1;
                        }
                        else if (getRangeNum == 3)
                        {
                            player8Card5Number3 = 1;
                        }
                        else if (getRangeNum == 4)
                        {
                            player8Card5Number4 = 1;
                        }
                        else if (getRangeNum == 5)
                        {
                            player8Card5Number5 = 1;
                        }
                        else if (getRangeNum == 6)
                        {
                            player8Card5Number6 = 1;
                        }
                        else if (getRangeNum == 7)
                        {
                            player8Card5Number7 = 1;
                        }
                        else if (getRangeNum == 8)
                        {
                            player8Card5Number8 = 1;
                        }
                        else if (getRangeNum == 9)
                        {
                            player8Card5Number9 = 1;
                        }
                        DiceNumberTextScript.player8Card5string = text5.text;
                    }
                }
            }
        }

    }

}
