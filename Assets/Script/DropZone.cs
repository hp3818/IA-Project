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

        if (Input.touchCount == 1)
        {
            if (d != null)
            {
                d.parentToReturnTo = transform;
            }
        }


    }

    public void random()
    {
        int getRangeNum1 = 0;
        int getRangeNum2 = 0;
        int getRangeNum3 = 0;
        int getRangeNum4 = 0;
        int getRangeNum5 = 0;
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
                            getRangeNum = Random.Range(1, 9);
                        }
                        while (getRangeNum == getRangeNum2 || getRangeNum == getRangeNum3 || getRangeNum == getRangeNum4 || getRangeNum == getRangeNum5);
                        getRangeNum1 = getRangeNum;
                        if (getRangeNum == 1)
                        {
                            player1Card1Number1 = 1;
                            text1.text = "強制入獄";
                        }
                        else if (getRangeNum == 2)
                        {
                            player1Card1Number2 = 1;
                            text1.text = "跑車奔馳";
                        }
                        else if (getRangeNum == 3)
                        {
                            player1Card1Number3 = 1;
                            text1.text = "高級飛機";
                        }
                        else if (getRangeNum == 4)
                        {
                            player1Card1Number4 = 1;
                            text1.text = "黑手黨";
                        }
                        else if (getRangeNum == 5)
                        {
                            player1Card1Number5 = 1;
                            text1.text = "商業霸權";
                        }
                        else if (getRangeNum == 6)
                        {
                            player1Card1Number6 = 1;
                            text1.text = "搬龍門";
                        }
                        else if (getRangeNum == 7)
                        {
                            player1Card1Number7 = 1;
                            text1.text = "上司特權";
                        }
                        else if (getRangeNum == 8)
                        {
                            player1Card1Number8 = 1;
                            text1.text = "盛會";
                        }
                        /*
                        else if (getRangeNum == 9)
                        {
                            player1Card1Number9 = 1;
                        }
                        */
                        DiceNumberTextScript.player1Card1string = text1.text;
                    }
                    else if (i == 2)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 9);
                        }
                        while (getRangeNum == getRangeNum1 || getRangeNum == getRangeNum3 || getRangeNum == getRangeNum4 || getRangeNum == getRangeNum5);
                        getRangeNum2 = getRangeNum;
                        if (getRangeNum == 1)
                        {
                            player1Card2Number1 = 1;
                            text2.text = "強制入獄";
                        }
                        else if (getRangeNum == 2)
                        {
                            player1Card2Number2 = 1;
                            text2.text = "跑車奔馳";
                        }
                        else if (getRangeNum == 3)
                        {
                            player1Card2Number3 = 1;
                            text2.text = "高級飛機";
                        }
                        else if (getRangeNum == 4)
                        {
                            player1Card2Number4 = 1;
                            text2.text = "黑手黨";
                        }
                        else if (getRangeNum == 5)
                        {
                            player1Card2Number5 = 1;
                            text2.text = "商業霸權";
                        }
                        else if (getRangeNum == 6)
                        {
                            player1Card2Number6 = 1;
                            text2.text = "搬龍門";
                        }
                        else if (getRangeNum == 7)
                        {
                            player1Card2Number7 = 1;
                            text2.text = "上司特權";
                        }
                        else if (getRangeNum == 8)
                        {
                            player1Card2Number8 = 1;
                            text2.text = "盛會";
                        }
                        /*
                        else if (getRangeNum == 9)
                        {
                            player1Card2Number9 = 1;
                        }
                        */
                        DiceNumberTextScript.player1Card2string = text2.text;
                    }
                    else if (i == 3)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 9);
                        }
                        while (getRangeNum == getRangeNum2 || getRangeNum == getRangeNum1 || getRangeNum == getRangeNum4 || getRangeNum == getRangeNum5);
                        getRangeNum3 = getRangeNum;
                        if (getRangeNum == 1)
                        {
                            player1Card3Number1 = 1;
                            text3.text = "強制入獄";
                        }
                        else if (getRangeNum == 2)
                        {
                            player1Card3Number2 = 1;
                            text3.text = "跑車奔馳";
                        }
                        else if (getRangeNum == 3)
                        {
                            player1Card3Number3 = 1;
                            text3.text = "高級飛機";
                        }
                        else if (getRangeNum == 4)
                        {
                            player1Card3Number4 = 1;
                            text3.text = "黑手黨";
                        }
                        else if (getRangeNum == 5)
                        {
                            player1Card3Number5 = 1;
                            text3.text = "商業霸權";
                        }
                        else if (getRangeNum == 6)
                        {
                            player1Card3Number6 = 1;
                            text3.text = "搬龍門";
                        }
                        else if (getRangeNum == 7)
                        {
                            player1Card3Number7 = 1;
                            text3.text = "上司特權";
                        }
                        else if (getRangeNum == 8)
                        {
                            player1Card3Number8 = 1;
                            text3.text = "盛會";
                        }
                        DiceNumberTextScript.player1Card3string = text3.text;
                    }
                    else if (i == 4)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 9);
                        }
                        while (getRangeNum == getRangeNum2 || getRangeNum == getRangeNum3 || getRangeNum == getRangeNum1 || getRangeNum == getRangeNum5);
                        getRangeNum4 = getRangeNum;
                        if (getRangeNum == 1)
                        {
                            player1Card4Number1 = 1;
                            text4.text = "強制入獄";
                        }
                        else if (getRangeNum == 2)
                        {
                            player1Card4Number2 = 1;
                            text4.text = "跑車奔馳";
                        }
                        else if (getRangeNum == 3)
                        {
                            player1Card4Number3 = 1;
                            text4.text = "高級飛機";
                        }
                        else if (getRangeNum == 4)
                        {
                            player1Card4Number4 = 1;
                            text4.text = "黑手黨";
                        }
                        else if (getRangeNum == 5)
                        {
                            player1Card4Number5 = 1;
                            text4.text = "商業霸權";
                        }
                        else if (getRangeNum == 6)
                        {
                            player1Card4Number6 = 1;
                            text4.text = "搬龍門";
                        }
                        else if (getRangeNum == 7)
                        {
                            player1Card4Number7 = 1;
                            text4.text = "上司特權";
                        }
                        else if (getRangeNum == 8)
                        {
                            player1Card4Number8 = 1;
                            text4.text = "盛會";
                        }
                        DiceNumberTextScript.player1Card4string = text4.text;
                    }
                    else if (i == 5)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 9);
                        }
                        while (getRangeNum == getRangeNum2 || getRangeNum == getRangeNum3 || getRangeNum == getRangeNum4 || getRangeNum == getRangeNum1);
                        getRangeNum5 = getRangeNum;
                        if (getRangeNum == 1)
                        {
                            player1Card5Number1 = 1;
                            text5.text = "強制入獄";
                        }
                        else if (getRangeNum == 2)
                        {
                            player1Card5Number2 = 1;
                            text5.text = "跑車奔馳";
                        }
                        else if (getRangeNum == 3)
                        {
                            player1Card5Number3 = 1;
                            text5.text = "高級飛機";
                        }
                        else if (getRangeNum == 4)
                        {
                            player1Card5Number4 = 1;
                            text5.text = "黑手黨";
                        }
                        else if (getRangeNum == 5)
                        {
                            player1Card5Number5 = 1;
                            text5.text = "商業霸權";
                        }
                        else if (getRangeNum == 6)
                        {
                            player1Card5Number6 = 1;
                            text5.text = "搬龍門";
                        }
                        else if (getRangeNum == 7)
                        {
                            player1Card5Number7 = 1;
                            text5.text = "上司特權";
                        }
                        else if (getRangeNum == 8)
                        {
                            player1Card5Number8 = 1;
                            text5.text = "盛會";
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
                        while (getRangeNum == getRangeNum2 || getRangeNum == getRangeNum3 || getRangeNum == getRangeNum4 || getRangeNum == getRangeNum5);
                        getRangeNum1 = getRangeNum;
                        if (getRangeNum == 1)
                        {
                            player2Card1Number1 = 1;
                            text1a.text = "接受物業(中)";
                        }
                        else if (getRangeNum == 2)
                        {
                            player2Card1Number2 = 1;
                            text1a.text = "愛回家";
                        }
                        else if (getRangeNum == 3)
                        {
                            player2Card1Number3 = 1;
                            text1a.text = "開心快遞";
                        }
                        else if (getRangeNum == 4)
                        {
                            player2Card1Number4 = 1;
                            text1a.text = "綠化物業";
                        }
                        else if (getRangeNum == 5)
                        {
                            player2Card1Number5 = 1;
                            text1a.text = "沉默";
                        }
                        else if (getRangeNum == 6)
                        {
                            player2Card1Number6 = 1;
                            text1a.text = "幸運輪";
                        }
                        else if (getRangeNum == 7)
                        {
                            player2Card1Number7 = 1;
                            text1a.text = "挑戰節目";
                        }
                        else if (getRangeNum == 8)
                        {
                            player2Card1Number8 = 1;
                            text1a.text = "交通規則";
                        }
                        else if (getRangeNum == 9)
                        {
                            player2Card1Number9 = 1;
                            text1a.text = "逆轉移動";
                        }
                        DiceNumberTextScript.player2Card1string = text1a.text;
                    }
                    else if (i == 2)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum == getRangeNum1 || getRangeNum == getRangeNum3 || getRangeNum == getRangeNum4 || getRangeNum == getRangeNum5);
                        getRangeNum2 = getRangeNum;
                        if (getRangeNum == 1)
                        {
                            player2Card2Number1 = 1;
                            text1b.text = "接受物業(中)";
                        }
                        else if (getRangeNum == 2)
                        {
                            player2Card2Number2 = 1;
                            text1b.text = "愛回家";
                        }
                        else if (getRangeNum == 3)
                        {
                            player2Card2Number3 = 1;
                            text1b.text = "開心快遞";
                        }
                        else if (getRangeNum == 4)
                        {
                            player2Card2Number4 = 1;
                            text1b.text = "綠化物業";
                        }
                        else if (getRangeNum == 5)
                        {
                            player2Card2Number5 = 1;
                            text1b.text = "沉默";
                        }
                        else if (getRangeNum == 6)
                        {
                            player2Card2Number6 = 1;
                            text1b.text = "幸運輪";
                        }
                        else if (getRangeNum == 7)
                        {
                            player2Card2Number7 = 1;
                            text1b.text = "挑戰節目";
                        }
                        else if (getRangeNum == 8)
                        {
                            player2Card2Number8 = 1;
                            text1b.text = "交通規則";
                        }
                        else if (getRangeNum == 9)
                        {
                            player2Card2Number9 = 1;
                            text1b.text = "逆轉移動";
                        }
                        DiceNumberTextScript.player2Card2string = text1b.text;
                    }
                    else if (i == 3)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum == getRangeNum2 || getRangeNum == getRangeNum1 || getRangeNum == getRangeNum4 || getRangeNum == getRangeNum5);
                        getRangeNum3 = getRangeNum;
                        if (getRangeNum == 1)
                        {
                            player2Card3Number1 = 1;
                            text1c.text = "接受物業(中)";
                        }
                        else if (getRangeNum == 2)
                        {
                            player2Card3Number2 = 1;
                            text1c.text = "愛回家";
                        }
                        else if (getRangeNum == 3)
                        {
                            player2Card3Number3 = 1;
                            text1c.text = "開心快遞";
                        }
                        else if (getRangeNum == 4)
                        {
                            player2Card3Number4 = 1;
                            text1c.text = "綠化物業";
                        }
                        else if (getRangeNum == 5)
                        {
                            player2Card3Number5 = 1;
                            text1c.text = "沉默";
                        }
                        else if (getRangeNum == 6)
                        {
                            player2Card3Number6 = 1;
                            text1c.text = "幸運輪";
                        }
                        else if (getRangeNum == 7)
                        {
                            player2Card3Number7 = 1;
                            text1c.text = "挑戰節目";
                        }
                        else if (getRangeNum == 8)
                        {
                            player2Card3Number8 = 1;
                            text1c.text = "交通規則";
                        }
                        else if (getRangeNum == 9)
                        {
                            player2Card3Number9 = 1;
                            text1c.text = "逆轉移動";
                        }
                        DiceNumberTextScript.player2Card3string = text1c.text;
                    }
                    else if (i == 4)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum == getRangeNum2 || getRangeNum == getRangeNum3 || getRangeNum == getRangeNum1 || getRangeNum == getRangeNum5);
                        getRangeNum4 = getRangeNum;
                        if (getRangeNum == 1)
                        {
                            player2Card4Number1 = 1;
                            text1d.text = "接受物業(中)";
                        }
                        else if (getRangeNum == 2)
                        {
                            player2Card4Number2 = 1;
                            text1d.text = "愛回家";
                        }
                        else if (getRangeNum == 3)
                        {
                            player2Card4Number3 = 1;
                            text1d.text = "開心快遞";
                        }
                        else if (getRangeNum == 4)
                        {
                            player2Card4Number4 = 1;
                            text1d.text = "綠化物業";
                        }
                        else if (getRangeNum == 5)
                        {
                            player2Card4Number5 = 1;
                            text1d.text = "沉默";
                        }
                        else if (getRangeNum == 6)
                        {
                            player2Card4Number6 = 1;
                            text1d.text = "幸運輪";
                        }
                        else if (getRangeNum == 7)
                        {
                            player2Card4Number7 = 1;
                            text1d.text = "挑戰節目";
                        }
                        else if (getRangeNum == 8)
                        {
                            player2Card4Number8 = 1;
                            text1d.text = "交通規則";
                        }
                        else if (getRangeNum == 9)
                        {
                            player2Card4Number9 = 1;
                            text1d.text = "逆轉移動";
                        }
                        DiceNumberTextScript.player2Card4string = text1d.text;
                    }
                    else if (i == 5)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum == getRangeNum2 || getRangeNum == getRangeNum3 || getRangeNum == getRangeNum4 || getRangeNum == getRangeNum1);
                        getRangeNum5 = getRangeNum;
                        if (getRangeNum == 1)
                        {
                            player2Card5Number1 = 1;
                            text1e.text = "接受物業(中)";
                        }
                        else if (getRangeNum == 2)
                        {
                            player2Card5Number2 = 1;
                            text1e.text = "愛回家";
                        }
                        else if (getRangeNum == 3)
                        {
                            player2Card5Number3 = 1;
                            text1e.text = "開心快遞";
                        }
                        else if (getRangeNum == 4)
                        {
                            player2Card5Number4 = 1;
                            text1e.text = "綠化物業";
                        }
                        else if (getRangeNum == 5)
                        {
                            player2Card5Number5 = 1;
                            text1e.text = "沉默";
                        }
                        else if (getRangeNum == 6)
                        {
                            player2Card5Number6 = 1;
                            text1e.text = "幸運輪";
                        }
                        else if (getRangeNum == 7)
                        {
                            player2Card5Number7 = 1;
                            text1e.text = "挑戰節目";
                        }
                        else if (getRangeNum == 8)
                        {
                            player2Card5Number8 = 1;
                            text1e.text = "交通規則";
                        }
                        else if (getRangeNum == 9)
                        {
                            player2Card5Number9 = 1;
                            text1e.text = "逆轉移動";
                        }
                        DiceNumberTextScript.player2Card5string = text1e.text;
                    }
                }
            }
            else if (j == 3)
            {
                for (int i = 1; i <= 5; i++)
                {
                    if (GameControl.numberOfPlayer == 4 || GameControl.numberOfPlayer == 5)
                    {
                        if (i == 1)
                        {

                            do
                            {
                                getRangeNum = Random.Range(1, 10);
                            }
                            while (getRangeNum == getRangeNum2 || getRangeNum == getRangeNum3 || getRangeNum == getRangeNum4 || getRangeNum == getRangeNum5);
                            getRangeNum1 = getRangeNum;
                            if (getRangeNum == 1)
                            {
                                player3Card1Number1 = 1;
                                text2a.text = "接受物業(低)";
                            }
                            else if (getRangeNum == 2)
                            {
                                player3Card1Number2 = 1;
                                text2a.text = "上級借款";
                            }
                            else if (getRangeNum == 3)
                            {
                                player3Card1Number3 = 1;
                                text2a.text = "隻資";
                            }
                            else if (getRangeNum == 4)
                            {
                                player3Card1Number4 = 1;
                                text2a.text = "眾集人口";
                            }
                            else if (getRangeNum == 5)
                            {
                                player3Card1Number5 = 1;
                                text2a.text = "共產主義";
                            }
                            else if (getRangeNum == 6)
                            {
                                player3Card1Number6 = 1;
                                text2a.text = "偷工減料";
                            }
                            else if (getRangeNum == 7)
                            {
                                player3Card1Number7 = 1;
                                text2a.text = "神之救濟";
                            }
                            else if (getRangeNum == 8)
                            {
                                player3Card1Number8 = 1;
                                text2a.text = "良心建築";
                            }
                            else if (getRangeNum == 9)
                            {
                                player3Card1Number9 = 1;
                                text2a.text = "小偷";
                            }
                            DiceNumberTextScript.player3Card1string = text2a.text;
                        }
                        else if (i == 2)
                        {
                            do
                            {
                                getRangeNum = Random.Range(1, 10);
                            }
                            while (getRangeNum == getRangeNum1 || getRangeNum == getRangeNum3 || getRangeNum == getRangeNum4 || getRangeNum == getRangeNum5);
                            getRangeNum2 = getRangeNum;
                            if (getRangeNum == 1)
                            {
                                player3Card2Number1 = 1;
                                text2b.text = "接受物業(低)";
                            }
                            else if (getRangeNum == 2)
                            {
                                player3Card2Number2 = 1;
                                text2b.text = "上級借款";
                            }
                            else if (getRangeNum == 3)
                            {
                                player3Card2Number3 = 1;
                                text2b.text = "隻資";
                            }
                            else if (getRangeNum == 4)
                            {
                                player3Card2Number4 = 1;
                                text2b.text = "眾集人口";
                            }
                            else if (getRangeNum == 5)
                            {
                                player3Card2Number5 = 1;
                                text2b.text = "共產主義";
                            }
                            else if (getRangeNum == 6)
                            {
                                player3Card2Number6 = 1;
                                text2b.text = "偷工減料";
                            }
                            else if (getRangeNum == 7)
                            {
                                player3Card2Number7 = 1;
                                text2b.text = "神之救濟";
                            }
                            else if (getRangeNum == 8)
                            {
                                player3Card2Number8 = 1;
                                text2b.text = "良心建築";
                            }
                            else if (getRangeNum == 9)
                            {
                                player3Card2Number9 = 1;
                                text2b.text = "小偷";
                            }
                            DiceNumberTextScript.player3Card2string = text2b.text;
                        }
                        else if (i == 3)
                        {
                            do
                            {
                                getRangeNum = Random.Range(1, 10);
                            }
                            while (getRangeNum == getRangeNum2 || getRangeNum == getRangeNum1 || getRangeNum == getRangeNum4 || getRangeNum == getRangeNum5);
                            getRangeNum3 = getRangeNum;
                            if (getRangeNum == 1)
                            {
                                player3Card3Number1 = 1;
                                text2c.text = "接受物業(低)";
                            }
                            else if (getRangeNum == 2)
                            {
                                player3Card3Number2 = 1;
                                text2c.text = "上級借款";
                            }
                            else if (getRangeNum == 3)
                            {
                                player3Card3Number3 = 1;
                                text2c.text = "隻資";
                            }
                            else if (getRangeNum == 4)
                            {
                                player3Card3Number4 = 1;
                                text2c.text = "眾集人口";
                            }
                            else if (getRangeNum == 5)
                            {
                                player3Card3Number5 = 1;
                                text2c.text = "共產主義";
                            }
                            else if (getRangeNum == 6)
                            {
                                player3Card3Number6 = 1;
                                text2c.text = "偷工減料";
                            }
                            else if (getRangeNum == 7)
                            {
                                player3Card3Number7 = 1;
                                text2c.text = "神之救濟";
                            }
                            else if (getRangeNum == 8)
                            {
                                player3Card3Number8 = 1;
                                text2c.text = "良心建築";
                            }
                            else if (getRangeNum == 9)
                            {
                                player3Card3Number9 = 1;
                                text2c.text = "小偷";
                            }
                            DiceNumberTextScript.player3Card3string = text2c.text;
                        }
                        else if (i == 4)
                        {
                            do
                            {
                                getRangeNum = Random.Range(1, 10);
                            }
                            while (getRangeNum == getRangeNum2 || getRangeNum == getRangeNum3 || getRangeNum == getRangeNum1 || getRangeNum == getRangeNum5);
                            getRangeNum4 = getRangeNum1;
                            if (getRangeNum == 1)
                            {
                                player3Card4Number1 = 1;
                                text2d.text = "接受物業(低)";
                            }
                            else if (getRangeNum == 2)
                            {
                                player3Card4Number2 = 1;
                                text2d.text = "上級借款";
                            }
                            else if (getRangeNum == 3)
                            {
                                player3Card4Number3 = 1;
                                text2d.text = "隻資";
                            }
                            else if (getRangeNum == 4)
                            {
                                player3Card4Number4 = 1;
                                text2d.text = "眾集人口";
                            }
                            else if (getRangeNum == 5)
                            {
                                player3Card4Number5 = 1;
                                text2d.text = "共產主義";
                            }
                            else if (getRangeNum == 6)
                            {
                                player3Card4Number6 = 1;
                                text2d.text = "偷工減料";
                            }
                            else if (getRangeNum == 7)
                            {
                                player3Card4Number7 = 1;
                                text2d.text = "神之救濟";
                            }
                            else if (getRangeNum == 8)
                            {
                                player3Card4Number8 = 1;
                                text2d.text = "良心建築";
                            }
                            else if (getRangeNum == 9)
                            {
                                player3Card4Number9 = 1;
                                text2d.text = "小偷";
                            }
                            DiceNumberTextScript.player3Card4string = text2d.text;
                        }
                        else if (i == 5)
                        {
                            do
                            {
                                getRangeNum = Random.Range(1, 10);
                            }
                            while (getRangeNum == getRangeNum2 || getRangeNum == getRangeNum3 || getRangeNum == getRangeNum4 || getRangeNum == getRangeNum1);
                            getRangeNum5 = getRangeNum1;
                            if (getRangeNum == 1)
                            {
                                player3Card5Number1 = 1;
                                text2e.text = "接受物業(低)";
                            }
                            else if (getRangeNum == 2)
                            {
                                player3Card5Number2 = 1;
                                text2e.text = "上級借款";
                            }
                            else if (getRangeNum == 3)
                            {
                                player3Card5Number3 = 1;
                                text2e.text = "隻資";
                            }
                            else if (getRangeNum == 4)
                            {
                                player3Card5Number4 = 1;
                                text2e.text = "眾集人口";
                            }
                            else if (getRangeNum == 5)
                            {
                                player3Card5Number5 = 1;
                                text2e.text = "共產主義";
                            }
                            else if (getRangeNum == 6)
                            {
                                player3Card5Number6 = 1;
                                text2e.text = "偷工減料";
                            }
                            else if (getRangeNum == 7)
                            {
                                player3Card5Number7 = 1;
                                text2e.text = "神之救濟";
                            }
                            else if (getRangeNum == 8)
                            {
                                player3Card5Number8 = 1;
                                text2e.text = "良心建築";
                            }
                            else if (getRangeNum == 9)
                            {
                                player3Card5Number9 = 1;
                                text2e.text = "小偷";
                            }
                            DiceNumberTextScript.player3Card5string = text2e.text;
                        }
                    }
                    else if (GameControl.numberOfPlayer == 6 || GameControl.numberOfPlayer == 7 || GameControl.numberOfPlayer == 8)
                    {
                        if (i == 1)
                        {

                            do
                            {
                                getRangeNum = Random.Range(1, 10);
                            }
                            while (getRangeNum == getRangeNum2 || getRangeNum == getRangeNum3 || getRangeNum == getRangeNum4 || getRangeNum == getRangeNum5);
                            getRangeNum1 = getRangeNum;
                            if (getRangeNum == 1)
                            {
                                player3Card1Number1 = 1;
                                text2a.text = "接受物業(中)";
                            }
                            else if (getRangeNum == 2)
                            {
                                player3Card1Number2 = 1;
                                text2a.text = "愛回家";
                            }
                            else if (getRangeNum == 3)
                            {
                                player3Card1Number3 = 1;
                                text2a.text = "開心快遞";
                            }
                            else if (getRangeNum == 4)
                            {
                                player3Card1Number4 = 1;
                                text2a.text = "綠化物業";
                            }
                            else if (getRangeNum == 5)
                            {
                                player3Card1Number5 = 1;
                                text2a.text = "沉默";
                            }
                            else if (getRangeNum == 6)
                            {
                                player3Card1Number6 = 1;
                                text2a.text = "幸運輪";
                            }
                            else if (getRangeNum == 7)
                            {
                                player3Card1Number7 = 1;
                                text2a.text = "挑戰節目";
                            }
                            else if (getRangeNum == 8)
                            {
                                player3Card1Number8 = 1;
                                text2a.text = "交通規則";
                            }
                            else if (getRangeNum == 9)
                            {
                                player3Card1Number9 = 1;
                                text2a.text = "逆轉行動";
                            }
                            DiceNumberTextScript.player3Card1string = text2a.text;
                        }
                        else if (i == 2)
                        {
                            do
                            {
                                getRangeNum = Random.Range(1, 10);
                            }
                            while (getRangeNum == getRangeNum1 || getRangeNum == getRangeNum3 || getRangeNum == getRangeNum4 || getRangeNum == getRangeNum5);
                            getRangeNum1 = getRangeNum;
                            if (getRangeNum == 1)
                            {
                                player3Card2Number1 = 1;
                                text2b.text = "接受物業(中)";
                            }
                            else if (getRangeNum == 2)
                            {
                                player3Card2Number2 = 1;
                                text2b.text = "愛回家";
                            }
                            else if (getRangeNum == 3)
                            {
                                player3Card2Number3 = 1;
                                text2b.text = "開心快遞";
                            }
                            else if (getRangeNum == 4)
                            {
                                player3Card2Number4 = 1;
                                text2b.text = "綠化物業";
                            }
                            else if (getRangeNum == 5)
                            {
                                player3Card2Number5 = 1;
                                text2b.text = "沉默";
                            }
                            else if (getRangeNum == 6)
                            {
                                player3Card2Number6 = 1;
                                text2b.text = "幸運輪";
                            }
                            else if (getRangeNum == 7)
                            {
                                player3Card2Number7 = 1;
                                text2b.text = "挑戰節目";
                            }
                            else if (getRangeNum == 8)
                            {
                                player3Card2Number8 = 1;
                                text2b.text = "交通規則";
                            }
                            else if (getRangeNum == 9)
                            {
                                player3Card2Number9 = 1;
                                text2b.text = "逆轉移動";
                            }
                            DiceNumberTextScript.player3Card2string = text2b.text;
                        }
                        else if (i == 3)
                        {
                            do
                            {
                                getRangeNum = Random.Range(1, 10);
                            }
                            while (getRangeNum == getRangeNum2 || getRangeNum == getRangeNum1 || getRangeNum == getRangeNum4 || getRangeNum == getRangeNum5);
                            getRangeNum3 = getRangeNum;
                            if (getRangeNum == 1)
                            {
                                player3Card3Number1 = 1;
                                text2c.text = "接受物業(中)";
                            }
                            else if (getRangeNum == 2)
                            {
                                player3Card3Number2 = 1;
                                text2c.text = "愛回家";
                            }
                            else if (getRangeNum == 3)
                            {
                                player3Card3Number3 = 1;
                                text2c.text = "開心快遞";
                            }
                            else if (getRangeNum == 4)
                            {
                                player3Card3Number4 = 1;
                                text2c.text = "綠化物業";
                            }
                            else if (getRangeNum == 5)
                            {
                                player3Card3Number5 = 1;
                                text2c.text = "沉默";
                            }
                            else if (getRangeNum == 6)
                            {
                                player3Card3Number6 = 1;
                                text2c.text = "幸運輪";
                            }
                            else if (getRangeNum == 7)
                            {
                                player3Card3Number7 = 1;
                                text2c.text = "挑戰節目";
                            }
                            else if (getRangeNum == 8)
                            {
                                player3Card3Number8 = 1;
                                text2c.text = "交通規則";
                            }
                            else if (getRangeNum == 9)
                            {
                                player3Card3Number9 = 1;
                                text2c.text = "逆轉移動";
                            }
                            DiceNumberTextScript.player3Card3string = text2c.text;
                        }
                        else if (i == 4)
                        {
                            do
                            {
                                getRangeNum = Random.Range(1, 10);
                            }
                            while (getRangeNum == getRangeNum2 || getRangeNum == getRangeNum1 || getRangeNum == getRangeNum4 || getRangeNum == getRangeNum5);
                            getRangeNum3 = getRangeNum;
                            if (getRangeNum == 1)
                            {
                                player3Card4Number1 = 1;
                                text2d.text = "接受物業(中)";
                            }
                            else if (getRangeNum == 2)
                            {
                                player3Card4Number2 = 1;
                                text2d.text = "愛回家";
                            }
                            else if (getRangeNum == 3)
                            {
                                player3Card4Number3 = 1;
                                text2d.text = "開心快遞";
                            }
                            else if (getRangeNum == 4)
                            {
                                player3Card4Number4 = 1;
                                text2d.text = "綠化物業";
                            }
                            else if (getRangeNum == 5)
                            {
                                player3Card4Number5 = 1;
                                text2d.text = "沉默";
                            }
                            else if (getRangeNum == 6)
                            {
                                player3Card4Number6 = 1;
                                text2d.text = "幸運輪";
                            }
                            else if (getRangeNum == 7)
                            {
                                player3Card4Number7 = 1;
                                text2d.text = "挑戰節目";
                            }
                            else if (getRangeNum == 8)
                            {
                                player3Card4Number8 = 1;
                                text2d.text = "交通規則";
                            }
                            else if (getRangeNum == 9)
                            {
                                player3Card4Number9 = 1;
                                text2d.text = "逆轉移動";
                            }
                            DiceNumberTextScript.player3Card4string = text2d.text;
                        }
                        else if (i == 5)
                        {
                            do
                            {
                                getRangeNum = Random.Range(1, 10);
                            }
                            while (getRangeNum == getRangeNum2 || getRangeNum == getRangeNum3 || getRangeNum == getRangeNum4 || getRangeNum == getRangeNum1);
                            getRangeNum5 = getRangeNum;
                            if (getRangeNum == 1)
                            {
                                player3Card5Number1 = 1;
                                text2e.text = "接受物業(中)";
                            }
                            else if (getRangeNum == 2)
                            {
                                player3Card5Number2 = 1;
                                text2e.text = "愛回家";
                            }
                            else if (getRangeNum == 3)
                            {
                                player3Card5Number3 = 1;
                                text2e.text = "開心快遞";
                            }
                            else if (getRangeNum == 4)
                            {
                                player3Card5Number4 = 1;
                                text2e.text = "綠化物業";
                            }
                            else if (getRangeNum == 5)
                            {
                                player3Card5Number5 = 1;
                                text2e.text = "沉默";
                            }
                            else if (getRangeNum == 6)
                            {
                                player3Card5Number6 = 1;
                                text2e.text = "幸運輪";
                            }
                            else if (getRangeNum == 7)
                            {
                                player3Card5Number7 = 1;
                                text2e.text = "挑戰節目";
                            }
                            else if (getRangeNum == 8)
                            {
                                player3Card5Number8 = 1;
                                text2e.text = "交通規則";
                            }
                            else if (getRangeNum == 9)
                            {
                                player3Card5Number9 = 1;
                                text2e.text = "逆轉移動";
                            }
                            DiceNumberTextScript.player3Card5string = text2e.text;
                        }
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
                        while (getRangeNum == getRangeNum2 || getRangeNum == getRangeNum3 || getRangeNum == getRangeNum4 || getRangeNum == getRangeNum5);
                        getRangeNum1 = getRangeNum;
                        if (getRangeNum == 1)
                        {
                            player4Card1Number1 = 1;
                            text3a.text = "接受物業(低)";
                        }
                        else if (getRangeNum == 2)
                        {
                            player4Card1Number2 = 1;
                            text3a.text = "上級借款";
                        }
                        else if (getRangeNum == 3)
                        {
                            player4Card1Number3 = 1;
                            text3a.text = "隻資";
                        }
                        else if (getRangeNum == 4)
                        {
                            player4Card1Number4 = 1;
                            text3a.text = "眾集人口";
                        }
                        else if (getRangeNum == 5)
                        {
                            player4Card1Number5 = 1;
                            text3a.text = "共產主義";
                        }
                        else if (getRangeNum == 6)
                        {
                            player4Card1Number6 = 1;
                            text3a.text = "偷工減料";
                        }
                        else if (getRangeNum == 7)
                        {
                            player4Card1Number7 = 1;
                            text3a.text = "神之救濟";
                        }
                        else if (getRangeNum == 8)
                        {
                            player4Card1Number8 = 1;
                            text3a.text = "良心建築";
                        }
                        else if (getRangeNum == 9)
                        {
                            player4Card1Number9 = 1;
                            text3a.text = "小偷";
                        }
                        DiceNumberTextScript.player4Card1string = text3a.text;
                    }
                    else if (i == 2)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum == getRangeNum1 || getRangeNum == getRangeNum3 || getRangeNum == getRangeNum4 || getRangeNum == getRangeNum5);
                        getRangeNum2 = getRangeNum;
                        if (getRangeNum == 1)
                        {
                            player4Card2Number1 = 1;
                            text3b.text = "接受物業(低)";
                        }
                        else if (getRangeNum == 2)
                        {
                            player4Card2Number2 = 1;
                            text3b.text = "上級借款";
                        }
                        else if (getRangeNum == 3)
                        {
                            player4Card2Number3 = 1;
                            text3b.text = "隻資";
                        }
                        else if (getRangeNum == 4)
                        {
                            player4Card2Number4 = 1;
                            text3b.text = "眾集人口";
                        }
                        else if (getRangeNum == 5)
                        {
                            player4Card2Number5 = 1;
                            text3b.text = "共產主義";
                        }
                        else if (getRangeNum == 6)
                        {
                            player4Card2Number6 = 1;
                            text3b.text = "偷工減料";
                        }
                        else if (getRangeNum == 7)
                        {
                            player4Card2Number7 = 1;
                            text3b.text = "神之救濟";
                        }
                        else if (getRangeNum == 8)
                        {
                            player4Card2Number8 = 1;
                            text3b.text = "良心建築";
                        }
                        else if (getRangeNum == 9)
                        {
                            player4Card2Number9 = 1;
                            text3b.text = "小偷";
                        }
                        DiceNumberTextScript.player4Card2string = text3b.text;
                    }
                    else if (i == 3)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum == getRangeNum1 || getRangeNum == getRangeNum2 || getRangeNum == getRangeNum4 || getRangeNum == getRangeNum5);
                        getRangeNum3 = getRangeNum;
                        if (getRangeNum == 1)
                        {
                            player4Card3Number1 = 1;
                            text3c.text = "接受物業(低)";
                        }
                        else if (getRangeNum == 2)
                        {
                            player4Card3Number2 = 1;
                            text3c.text = "上級借款";
                        }
                        else if (getRangeNum == 3)
                        {
                            player4Card3Number3 = 1;
                            text3c.text = "隻資";
                        }
                        else if (getRangeNum == 4)
                        {
                            player4Card3Number4 = 1;
                            text3c.text = "眾集人口";
                        }
                        else if (getRangeNum == 5)
                        {
                            player4Card3Number5 = 1;
                            text3c.text = "共產主義";
                        }
                        else if (getRangeNum == 6)
                        {
                            player4Card3Number6 = 1;
                            text3c.text = "偷工減料";
                        }
                        else if (getRangeNum == 7)
                        {
                            player4Card3Number7 = 1;
                            text3c.text = "神之救濟";
                        }
                        else if (getRangeNum == 8)
                        {
                            player4Card3Number8 = 1;
                            text3c.text = "良心建築";
                        }
                        else if (getRangeNum == 9)
                        {
                            player4Card3Number9 = 1;
                            text3c.text = "小偷";
                        }
                        DiceNumberTextScript.player4Card3string = text3c.text;
                    }
                    else if (i == 4)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum == getRangeNum1 || getRangeNum == getRangeNum3 || getRangeNum == getRangeNum2 || getRangeNum == getRangeNum5);
                        getRangeNum4 = getRangeNum;
                        if (getRangeNum == 1)
                        {
                            player4Card4Number1 = 1;
                            text3d.text = "接受物業(低)";
                        }
                        else if (getRangeNum == 2)
                        {
                            player4Card4Number2 = 1;
                            text3d.text = "上級借款";
                        }
                        else if (getRangeNum == 3)
                        {
                            player4Card4Number3 = 1;
                            text3d.text = "隻資";
                        }
                        else if (getRangeNum == 4)
                        {
                            player4Card4Number4 = 1;
                            text3d.text = "眾集人口";
                        }
                        else if (getRangeNum == 5)
                        {
                            player4Card4Number5 = 1;
                            text3d.text = "共產主義";
                        }
                        else if (getRangeNum == 6)
                        {
                            player4Card4Number6 = 1;
                            text3d.text = "偷工減料";
                        }
                        else if (getRangeNum == 7)
                        {
                            player4Card4Number7 = 1;
                            text3d.text = "神之救濟";
                        }
                        else if (getRangeNum == 8)
                        {
                            player4Card4Number8 = 1;
                            text3d.text = "良心建築";
                        }
                        else if (getRangeNum == 9)
                        {
                            player4Card4Number9 = 1;
                            text3d.text = "小偷";
                        }
                        DiceNumberTextScript.player4Card4string = text3d.text;
                    }
                    else if (i == 5)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum == getRangeNum1 || getRangeNum == getRangeNum3 || getRangeNum == getRangeNum4 || getRangeNum == getRangeNum2);
                        getRangeNum5 = getRangeNum;
                        if (getRangeNum == 1)
                        {
                            player4Card5Number1 = 1;
                            text3e.text = "接受物業(低)";
                        }
                        else if (getRangeNum == 2)
                        {
                            player4Card5Number2 = 1;
                            text3e.text = "上級借款";
                        }
                        else if (getRangeNum == 3)
                        {
                            player4Card5Number3 = 1;
                            text3e.text = "隻資";
                        }
                        else if (getRangeNum == 4)
                        {
                            player4Card5Number4 = 1;
                            text3e.text = "眾集人口";
                        }
                        else if (getRangeNum == 5)
                        {
                            player4Card5Number5 = 1;
                            text3e.text = "共產主義";
                        }
                        else if (getRangeNum == 6)
                        {
                            player4Card5Number6 = 1;
                            text3e.text = "偷工減料";
                        }
                        else if (getRangeNum == 7)
                        {
                            player4Card5Number7 = 1;
                            text3e.text = "神之救濟";
                        }
                        else if (getRangeNum == 8)
                        {
                            player4Card5Number8 = 1;
                            text3e.text = "良心建築";
                        }
                        else if (getRangeNum == 9)
                        {
                            player4Card5Number9 = 1;
                            text3e.text = "小偷";
                        }
                        DiceNumberTextScript.player4Card5string = text3e.text;
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
                        while (getRangeNum == getRangeNum2 || getRangeNum == getRangeNum3 || getRangeNum == getRangeNum4 || getRangeNum == getRangeNum5);
                        getRangeNum1 = getRangeNum;
                        if (getRangeNum == 1)
                        {
                            player5Card1Number1 = 1;
                            text4a.text = "接受物業(低)";
                        }
                        else if (getRangeNum == 2)
                        {
                            player5Card1Number2 = 1;
                            text4a.text = "上級借款";
                        }
                        else if (getRangeNum == 3)
                        {
                            player5Card1Number3 = 1;
                            text4a.text = "隻資";
                        }
                        else if (getRangeNum == 4)
                        {
                            player5Card1Number4 = 1;
                            text4a.text = "眾集人口";
                        }
                        else if (getRangeNum == 5)
                        {
                            player5Card1Number5 = 1;
                            text4a.text = "共產主義";
                        }
                        else if (getRangeNum == 6)
                        {
                            player5Card1Number6 = 1;
                            text4a.text = "偷工減料";
                        }
                        else if (getRangeNum == 7)
                        {
                            player5Card1Number7 = 1;
                            text4a.text = "神之救濟";
                        }
                        else if (getRangeNum == 8)
                        {
                            player5Card1Number8 = 1;
                            text4a.text = "良心建築";
                        }
                        else if (getRangeNum == 9)
                        {
                            player5Card1Number9 = 1;
                            text4a.text = "小偷";
                        }
                        DiceNumberTextScript.player5Card1string = text4a.text;
                    }
                    else if (i == 2)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum == getRangeNum1 || getRangeNum == getRangeNum3 || getRangeNum == getRangeNum4 || getRangeNum == getRangeNum5);
                        getRangeNum2 = getRangeNum;
                        if (getRangeNum == 1)
                        {
                            player5Card2Number1 = 1;
                            text4b.text = "接受物業(低)";
                        }
                        else if (getRangeNum == 2)
                        {
                            player5Card2Number2 = 1;
                            text4b.text = "上級借款";
                        }
                        else if (getRangeNum == 3)
                        {
                            player5Card2Number3 = 1;
                            text4b.text = "隻資";
                        }
                        else if (getRangeNum == 4)
                        {
                            player5Card2Number4 = 1;
                            text4b.text = "眾集人口";
                        }
                        else if (getRangeNum == 5)
                        {
                            player5Card2Number5 = 1;
                            text4b.text = "共產主義";
                        }
                        else if (getRangeNum == 6)
                        {
                            player5Card2Number6 = 1;
                            text4b.text = "偷工減料";
                        }
                        else if (getRangeNum == 7)
                        {
                            player5Card2Number7 = 1;
                            text4b.text = "神之救濟";
                        }
                        else if (getRangeNum == 8)
                        {
                            player5Card2Number8 = 1;
                            text4b.text = "良心建築";
                        }
                        else if (getRangeNum == 9)
                        {
                            player5Card2Number9 = 1;
                            text4b.text = "小偷";
                        }
                        DiceNumberTextScript.player5Card2string = text4b.text;
                    }
                    else if (i == 3)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum == getRangeNum2 || getRangeNum == getRangeNum1 || getRangeNum == getRangeNum4 || getRangeNum == getRangeNum5);
                        getRangeNum3 = getRangeNum;
                        if (getRangeNum == 1)
                        {
                            player5Card3Number1 = 1;
                            text4c.text = "接受物業(低)";
                        }
                        else if (getRangeNum == 2)
                        {
                            player5Card3Number2 = 1;
                            text4c.text = "上級借款";
                        }
                        else if (getRangeNum == 3)
                        {
                            player5Card3Number3 = 1;
                            text4c.text = "隻資";
                        }
                        else if (getRangeNum == 4)
                        {
                            player5Card3Number4 = 1;
                            text4c.text = "眾集人口";
                        }
                        else if (getRangeNum == 5)
                        {
                            player5Card3Number5 = 1;
                            text4c.text = "共產主義";
                        }
                        else if (getRangeNum == 6)
                        {
                            player5Card3Number6 = 1;
                            text4c.text = "偷工減料";
                        }
                        else if (getRangeNum == 7)
                        {
                            player5Card3Number7 = 1;
                            text4c.text = "神之救濟";
                        }
                        else if (getRangeNum == 8)
                        {
                            player5Card3Number8 = 1;
                            text4c.text = "良心建築";
                        }
                        else if (getRangeNum == 9)
                        {
                            player5Card3Number9 = 1;
                            text4c.text = "小偷";
                        }
                        DiceNumberTextScript.player5Card3string = text4c.text;
                    }
                    else if (i == 4)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum == getRangeNum2 || getRangeNum == getRangeNum3 || getRangeNum == getRangeNum1 || getRangeNum == getRangeNum5);
                        getRangeNum4 = getRangeNum;

                        if (getRangeNum == 1)
                        {
                            player5Card4Number1 = 1;
                            text4d.text = "接受物業(低)";
                        }
                        else if (getRangeNum == 2)
                        {
                            player5Card4Number2 = 1;
                            text4d.text = "上級借款";
                        }
                        else if (getRangeNum == 3)
                        {
                            player5Card4Number3 = 1;
                            text4d.text = "隻資";
                        }
                        else if (getRangeNum == 4)
                        {
                            player5Card4Number4 = 1;
                            text4d.text = "眾集人口";
                        }
                        else if (getRangeNum == 5)
                        {
                            player5Card4Number5 = 1;
                            text4d.text = "共產主義";
                        }
                        else if (getRangeNum == 6)
                        {
                            player5Card4Number6 = 1;
                            text4d.text = "偷工減料";
                        }
                        else if (getRangeNum == 7)
                        {
                            player5Card4Number7 = 1;
                            text4d.text = "神之救濟";
                        }
                        else if (getRangeNum == 8)
                        {
                            player5Card4Number8 = 1;
                            text4d.text = "良心建築";
                        }
                        else if (getRangeNum == 9)
                        {
                            player5Card4Number9 = 1;
                            text4d.text = "小偷";
                        }
                        DiceNumberTextScript.player5Card4string = text4d.text;
                    }
                    else if (i == 5)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum == getRangeNum2 || getRangeNum == getRangeNum3 || getRangeNum == getRangeNum4 || getRangeNum == getRangeNum1);
                        getRangeNum5 = getRangeNum;
                        if (getRangeNum == 1)
                        {
                            player5Card5Number1 = 1;
                            text4e.text = "接受物業(低)";
                        }
                        else if (getRangeNum == 2)
                        {
                            player5Card5Number2 = 1;
                            text4e.text = "上級借款";
                        }
                        else if (getRangeNum == 3)
                        {
                            player5Card5Number3 = 1;
                            text4e.text = "隻資";
                        }
                        else if (getRangeNum == 4)
                        {
                            player5Card5Number4 = 1;
                            text4e.text = "眾集人口";
                        }
                        else if (getRangeNum == 5)
                        {
                            player5Card5Number5 = 1;
                            text4e.text = "共產主義";
                        }
                        else if (getRangeNum == 6)
                        {
                            player5Card5Number6 = 1;
                            text4e.text = "偷工減料";
                        }
                        else if (getRangeNum == 7)
                        {
                            player5Card5Number7 = 1;
                            text4e.text = "神之救濟";
                        }
                        else if (getRangeNum == 8)
                        {
                            player5Card5Number8 = 1;
                            text4e.text = "良心建築";
                        }
                        else if (getRangeNum == 9)
                        {
                            player5Card5Number9 = 1;
                            text4e.text = "小偷";
                        }
                        DiceNumberTextScript.player5Card5string = text4e.text;
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
                        while (getRangeNum == getRangeNum2 || getRangeNum == getRangeNum3 || getRangeNum == getRangeNum4 || getRangeNum == getRangeNum5);
                        getRangeNum1 = getRangeNum;
                        if (getRangeNum == 1)
                        {
                            player6Card1Number1 = 1;
                            text5a.text = "接受物業(低)";
                        }
                        else if (getRangeNum == 2)
                        {
                            player6Card1Number2 = 1;
                            text5a.text = "上級借貸";
                        }
                        else if (getRangeNum == 3)
                        {
                            player6Card1Number3 = 1;
                            text5a.text = "集資";
                        }
                        else if (getRangeNum == 4)
                        {
                            player6Card1Number4 = 1;
                            text5a.text = "眾集人口";
                        }
                        else if (getRangeNum == 5)
                        {
                            player6Card1Number5 = 1;
                            text5a.text = "共產主義";
                        }
                        else if (getRangeNum == 6)
                        {
                            player6Card1Number6 = 1;
                            text5a.text = "偷工減料";
                        }
                        else if (getRangeNum == 7)
                        {
                            player6Card1Number7 = 1;
                            text5a.text = "神之救濟";
                        }
                        else if (getRangeNum == 8)
                        {
                            player6Card1Number8 = 1;
                            text5a.text = "良心建築";
                        }
                        else if (getRangeNum == 9)
                        {
                            player6Card1Number9 = 1;
                            text5a.text = "小偷";
                        }
                        DiceNumberTextScript.player6Card1string = text5a.text;
                    }
                    else if (i == 2)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum == getRangeNum1 || getRangeNum == getRangeNum3 || getRangeNum == getRangeNum4 || getRangeNum == getRangeNum5);
                        getRangeNum2 = getRangeNum;
                        if (getRangeNum == 1)
                        {
                            player6Card2Number1 = 1;
                            text5b.text = "接受物業(低)";
                        }
                        else if (getRangeNum == 2)
                        {
                            player6Card2Number2 = 1;
                            text5b.text = "上級借貸";
                        }
                        else if (getRangeNum == 3)
                        {
                            player6Card2Number3 = 1;
                            text5b.text = "集資";
                        }
                        else if (getRangeNum == 4)
                        {
                            player6Card2Number4 = 1;
                            text5b.text = "眾集人口";
                        }
                        else if (getRangeNum == 5)
                        {
                            player6Card2Number5 = 1;
                            text5b.text = "共產主義";
                        }
                        else if (getRangeNum == 6)
                        {
                            player6Card2Number6 = 1;
                            text5b.text = "偷工減料";
                        }
                        else if (getRangeNum == 7)
                        {
                            player6Card2Number7 = 1;
                            text5b.text = "神之救濟";
                        }
                        else if (getRangeNum == 8)
                        {
                            player6Card2Number8 = 1;
                            text5b.text = "良心建築";
                        }
                        else if (getRangeNum == 9)
                        {
                            player6Card2Number9 = 1;
                            text5b.text = "小偷";
                        }
                        DiceNumberTextScript.player6Card2string = text5b.text;
                    }
                    else if (i == 3)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum == getRangeNum2 || getRangeNum == getRangeNum1 || getRangeNum == getRangeNum4 || getRangeNum == getRangeNum5);
                        getRangeNum3 = getRangeNum;
                        if (getRangeNum == 1)
                        {
                            player6Card3Number1 = 1;
                            text5c.text = "接受物業(低)";
                        }
                        else if (getRangeNum == 2)
                        {
                            player6Card3Number2 = 1;
                            text5c.text = "上級借貸";
                        }
                        else if (getRangeNum == 3)
                        {
                            player6Card3Number3 = 1;
                            text5c.text = "集資";
                        }
                        else if (getRangeNum == 4)
                        {
                            player6Card3Number4 = 1;
                            text5c.text = "眾集人口";
                        }
                        else if (getRangeNum == 5)
                        {
                            player6Card3Number5 = 1;
                            text5c.text = "共產主義";
                        }
                        else if (getRangeNum == 6)
                        {
                            player6Card3Number6 = 1;
                            text5c.text = "偷工減料";
                        }
                        else if (getRangeNum == 7)
                        {
                            player6Card3Number7 = 1;
                            text5c.text = "神之救濟";
                        }
                        else if (getRangeNum == 8)
                        {
                            player6Card3Number8 = 1;
                            text5c.text = "良心建築";
                        }
                        else if (getRangeNum == 9)
                        {
                            player6Card3Number9 = 1;
                            text5c.text = "小偷";
                        }
                        DiceNumberTextScript.player6Card3string = text5c.text;
                    }
                    else if (i == 4)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum == getRangeNum2 || getRangeNum == getRangeNum3 || getRangeNum == getRangeNum1 || getRangeNum == getRangeNum5);
                        getRangeNum4 = getRangeNum1;
                        if (getRangeNum == 1)
                        {
                            player6Card4Number1 = 1;
                            text5d.text = "接受物業(低)";
                        }
                        else if (getRangeNum == 2)
                        {
                            player6Card4Number2 = 1;
                            text5d.text = "上級借貸";
                        }
                        else if (getRangeNum == 3)
                        {
                            player6Card4Number3 = 1;
                            text5d.text = "集資";
                        }
                        else if (getRangeNum == 4)
                        {
                            player6Card4Number4 = 1;
                            text5d.text = "眾集人口";
                        }
                        else if (getRangeNum == 5)
                        {
                            player6Card4Number5 = 1;
                            text5d.text = "共產主義";
                        }
                        else if (getRangeNum == 6)
                        {
                            player6Card4Number6 = 1;
                            text5d.text = "偷工減料";
                        }
                        else if (getRangeNum == 7)
                        {
                            player6Card4Number7 = 1;
                            text5d.text = "神之救濟";
                        }
                        else if (getRangeNum == 8)
                        {
                            player6Card4Number8 = 1;
                            text5d.text = "良心建築";
                        }
                        else if (getRangeNum == 9)
                        {
                            player6Card4Number9 = 1;
                            text5d.text = "小偷";
                        }
                        DiceNumberTextScript.player6Card4string = text5d.text;
                    }
                    else if (i == 5)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum == getRangeNum2 || getRangeNum == getRangeNum3 || getRangeNum == getRangeNum4 || getRangeNum == getRangeNum1);
                        getRangeNum5 = getRangeNum;
                        if (getRangeNum == 1)
                        {
                            player6Card5Number1 = 1;
                            text5e.text = "接受物業(低)";
                        }
                        else if (getRangeNum == 2)
                        {
                            player6Card5Number2 = 1;
                            text5e.text = "上級借貸";
                        }
                        else if (getRangeNum == 3)
                        {
                            player6Card5Number3 = 1;
                            text5e.text = "集資";
                        }
                        else if (getRangeNum == 4)
                        {
                            player6Card5Number4 = 1;
                            text5e.text = "眾集人口";
                        }
                        else if (getRangeNum == 5)
                        {
                            player6Card5Number5 = 1;
                            text5e.text = "共產主義";
                        }
                        else if (getRangeNum == 6)
                        {
                            player6Card5Number6 = 1;
                            text5e.text = "偷工減料";
                        }
                        else if (getRangeNum == 7)
                        {
                            player6Card5Number7 = 1;
                            text5e.text = "神之救濟";
                        }
                        else if (getRangeNum == 8)
                        {
                            player6Card5Number8 = 1;
                            text5e.text = "良心建築";
                        }
                        else if (getRangeNum == 9)
                        {
                            player6Card5Number9 = 1;
                            text5e.text = "小偷";
                        }
                        DiceNumberTextScript.player6Card5string = text5e.text;
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
                        while (getRangeNum == getRangeNum2 || getRangeNum == getRangeNum3 || getRangeNum == getRangeNum4 || getRangeNum == getRangeNum5);
                        getRangeNum1 = getRangeNum;
                        if (getRangeNum == 1)
                        {
                            player7Card1Number1 = 1;
                            text6a.text = "接受物業(低)";
                        }
                        else if (getRangeNum == 2)
                        {
                            player7Card1Number2 = 1;
                            text6a.text = "上級借貸";
                        }
                        else if (getRangeNum == 3)
                        {
                            player7Card1Number3 = 1;
                            text6a.text = "集資";
                        }
                        else if (getRangeNum == 4)
                        {
                            player7Card1Number4 = 1;
                            text6a.text = "眾集人口";
                        }
                        else if (getRangeNum == 5)
                        {
                            player7Card1Number5 = 1;
                            text6a.text = "共產主義";
                        }
                        else if (getRangeNum == 6)
                        {
                            player7Card1Number6 = 1;
                            text6a.text = "偷工減料";
                        }
                        else if (getRangeNum == 7)
                        {
                            player7Card1Number7 = 1;
                            text6a.text = "神之救濟";
                        }
                        else if (getRangeNum == 8)
                        {
                            player7Card1Number8 = 1;
                            text6a.text = "良心建築";
                        }
                        else if (getRangeNum == 9)
                        {
                            player7Card1Number9 = 1;
                            text6a.text = "小偷";
                        }
                        DiceNumberTextScript.player7Card1string = text6a.text;
                    }
                    else if (i == 2)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum == getRangeNum1 || getRangeNum == getRangeNum3 || getRangeNum == getRangeNum4 || getRangeNum == getRangeNum5);
                        getRangeNum2 = getRangeNum;
                        if (getRangeNum == 1)
                        {
                            player7Card2Number1 = 1;
                            text6b.text = "接受物業(低)";
                        }
                        else if (getRangeNum == 2)
                        {
                            player7Card2Number2 = 1;
                            text6b.text = "上級借貸";
                        }
                        else if (getRangeNum == 3)
                        {
                            player7Card2Number3 = 1;
                            text6b.text = "集資";
                        }
                        else if (getRangeNum == 4)
                        {
                            player7Card2Number4 = 1;
                            text6b.text = "眾集人口";
                        }
                        else if (getRangeNum == 5)
                        {
                            player7Card2Number5 = 1;
                            text6b.text = "共產主義";
                        }
                        else if (getRangeNum == 6)
                        {
                            player7Card2Number6 = 1;
                            text6b.text = "偷工減料";
                        }
                        else if (getRangeNum == 7)
                        {
                            player7Card2Number7 = 1;
                            text6b.text = "神之救濟";
                        }
                        else if (getRangeNum == 8)
                        {
                            player7Card2Number8 = 1;
                            text6b.text = "良心建築";
                        }
                        else if (getRangeNum == 9)
                        {
                            player7Card2Number9 = 1;
                            text6b.text = "小偷";
                        }
                        DiceNumberTextScript.player7Card2string = text6b.text;
                    }
                    else if (i == 3)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum == getRangeNum2 || getRangeNum == getRangeNum1 || getRangeNum == getRangeNum4 || getRangeNum == getRangeNum5);
                        getRangeNum3 = getRangeNum;
                        if (getRangeNum == 1)
                        {
                            player7Card3Number1 = 1;
                            text6c.text = "接受物業(低)";
                        }
                        else if (getRangeNum == 2)
                        {
                            player7Card3Number2 = 1;
                            text6c.text = "上級借貸";
                        }
                        else if (getRangeNum == 3)
                        {
                            player7Card3Number3 = 1;
                            text6c.text = "集資";
                        }
                        else if (getRangeNum == 4)
                        {
                            player7Card3Number4 = 1;
                            text6c.text = "眾集人口";
                        }
                        else if (getRangeNum == 5)
                        {
                            player7Card3Number5 = 1;
                            text6c.text = "共產主義";
                        }
                        else if (getRangeNum == 6)
                        {
                            player7Card3Number6 = 1;
                            text6c.text = "偷工減料";
                        }
                        else if (getRangeNum == 7)
                        {
                            player7Card3Number7 = 1;
                            text6c.text = "神之救濟";
                        }
                        else if (getRangeNum == 8)
                        {
                            player7Card3Number8 = 1;
                            text6c.text = "良心建築";
                        }
                        else if (getRangeNum == 9)
                        {
                            player7Card3Number9 = 1;
                            text6c.text = "小偷";
                        }
                        DiceNumberTextScript.player7Card3string = text6c.text;
                    }
                    else if (i == 4)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum == getRangeNum2 || getRangeNum == getRangeNum3 || getRangeNum == getRangeNum1 || getRangeNum == getRangeNum5);
                        getRangeNum4 = getRangeNum;
                        if (getRangeNum == 1)
                        {
                            player7Card4Number1 = 1;
                            text6d.text = "接受物業(低)";
                        }
                        else if (getRangeNum == 2)
                        {
                            player7Card4Number2 = 1;
                            text6d.text = "上級借貸";
                        }
                        else if (getRangeNum == 3)
                        {
                            player7Card4Number3 = 1;
                            text6d.text = "集資";
                        }
                        else if (getRangeNum == 4)
                        {
                            player7Card4Number4 = 1;
                            text6d.text = "眾集人口";
                        }
                        else if (getRangeNum == 5)
                        {
                            player7Card4Number5 = 1;
                            text6d.text = "共產主義";
                        }
                        else if (getRangeNum == 6)
                        {
                            player7Card4Number6 = 1;
                            text6d.text = "偷工減料";
                        }
                        else if (getRangeNum == 7)
                        {
                            player7Card4Number7 = 1;
                            text6d.text = "神之救濟";
                        }
                        else if (getRangeNum == 8)
                        {
                            player7Card4Number8 = 1;
                            text6d.text = "良心建築";
                        }
                        else if (getRangeNum == 9)
                        {
                            player7Card4Number9 = 1;
                            text6d.text = "小偷";
                        }
                        DiceNumberTextScript.player7Card4string = text6d.text;
                    }
                    else if (i == 5)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum == getRangeNum2 || getRangeNum == getRangeNum3 || getRangeNum == getRangeNum4 || getRangeNum == getRangeNum1);
                        getRangeNum5 = getRangeNum1;
                        if (getRangeNum == 1)
                        {
                            player7Card5Number1 = 1;
                            text6e.text = "接受物業(低)";
                        }
                        else if (getRangeNum == 2)
                        {
                            player7Card5Number2 = 1;
                            text6e.text = "上級借貸";
                        }
                        else if (getRangeNum == 3)
                        {
                            player7Card5Number3 = 1;
                            text6e.text = "集資";
                        }
                        else if (getRangeNum == 4)
                        {
                            player7Card5Number4 = 1;
                            text6e.text = "眾集人口";
                        }
                        else if (getRangeNum == 5)
                        {
                            player7Card5Number5 = 1;
                            text6e.text = "共產主義";
                        }
                        else if (getRangeNum == 6)
                        {
                            player7Card5Number6 = 1;
                            text6e.text = "偷工減料";
                        }
                        else if (getRangeNum == 7)
                        {
                            player7Card5Number7 = 1;
                            text6e.text = "神之救濟";
                        }
                        else if (getRangeNum == 8)
                        {
                            player7Card5Number8 = 1;
                            text6e.text = "良心建築";
                        }
                        else if (getRangeNum == 9)
                        {
                            player7Card5Number9 = 1;
                            text6e.text = "小偷";
                        }
                        DiceNumberTextScript.player7Card5string = text6e.text;
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
                        while (getRangeNum == getRangeNum2 || getRangeNum == getRangeNum3 || getRangeNum == getRangeNum4 || getRangeNum == getRangeNum5);
                        getRangeNum1 = getRangeNum;
                        if (getRangeNum == 1)
                        {
                            player8Card1Number1 = 1;
                            text7a.text = "接受物業(低)";
                        }
                        else if (getRangeNum == 2)
                        {
                            player8Card1Number2 = 1;
                            text7a.text = "上級借貸";
                        }
                        else if (getRangeNum == 3)
                        {
                            player8Card1Number3 = 1;
                            text7a.text = "集資";
                        }
                        else if (getRangeNum == 4)
                        {
                            player8Card1Number4 = 1;
                            text7a.text = "眾集人口";
                        }
                        else if (getRangeNum == 5)
                        {
                            player8Card1Number5 = 1;
                            text7a.text = "共產主義";
                        }
                        else if (getRangeNum == 6)
                        {
                            player8Card1Number6 = 1;
                            text7a.text = "偷工減料";
                        }
                        else if (getRangeNum == 7)
                        {
                            player8Card1Number7 = 1;
                            text7a.text = "神之救濟";
                        }
                        else if (getRangeNum == 8)
                        {
                            player8Card1Number8 = 1;
                            text7a.text = "良心建築";
                        }
                        else if (getRangeNum == 9)
                        {
                            player8Card1Number9 = 1;
                            text7a.text = "小偷";
                        }
                        DiceNumberTextScript.player8Card1string = text7a.text;
                    }
                    else if (i == 2)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum == getRangeNum1 || getRangeNum == getRangeNum3 || getRangeNum == getRangeNum4 || getRangeNum == getRangeNum5);
                        getRangeNum2 = getRangeNum;
                        if (getRangeNum == 1)
                        {
                            player8Card2Number1 = 1;
                            text7b.text = "接受物業(低)";
                        }
                        else if (getRangeNum == 2)
                        {
                            player8Card2Number2 = 1;
                            text7b.text = "上級借貸";
                        }
                        else if (getRangeNum == 3)
                        {
                            player8Card2Number3 = 1;
                            text7b.text = "集資";
                        }
                        else if (getRangeNum == 4)
                        {
                            player8Card2Number4 = 1;
                            text7b.text = "眾集人口";
                        }
                        else if (getRangeNum == 5)
                        {
                            player8Card2Number5 = 1;
                            text7b.text = "共產主義";
                        }
                        else if (getRangeNum == 6)
                        {
                            player8Card2Number6 = 1;
                            text7b.text = "偷工減料";
                        }
                        else if (getRangeNum == 7)
                        {
                            player8Card2Number7 = 1;
                            text7b.text = "神之救濟";
                        }
                        else if (getRangeNum == 8)
                        {
                            player8Card2Number8 = 1;
                            text7b.text = "良心建築";
                        }
                        else if (getRangeNum == 9)
                        {
                            player8Card2Number9 = 1;
                            text7b.text = "小偷";
                        }
                        DiceNumberTextScript.player8Card2string = text7b.text;
                    }
                    else if (i == 3)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum == getRangeNum2 || getRangeNum == getRangeNum1 || getRangeNum == getRangeNum4 || getRangeNum == getRangeNum5);
                        getRangeNum3 = getRangeNum;
                        if (getRangeNum == 1)
                        {
                            player8Card3Number1 = 1;
                            text7c.text = "接受物業(低)";
                        }
                        else if (getRangeNum == 2)
                        {
                            player8Card3Number2 = 1;
                            text7c.text = "上級借貸";
                        }
                        else if (getRangeNum == 3)
                        {
                            player8Card3Number3 = 1;
                            text7c.text = "集資";
                        }
                        else if (getRangeNum == 4)
                        {
                            player8Card3Number4 = 1;
                            text7c.text = "眾集人口";
                        }
                        else if (getRangeNum == 5)
                        {
                            player8Card3Number5 = 1;
                            text7c.text = "共產主義";
                        }
                        else if (getRangeNum == 6)
                        {
                            player8Card3Number6 = 1;
                            text7c.text = "偷工減料";
                        }
                        else if (getRangeNum == 7)
                        {
                            player8Card3Number7 = 1;
                            text7c.text = "神之救濟";
                        }
                        else if (getRangeNum == 8)
                        {
                            player8Card3Number8 = 1;
                            text7c.text = "良心建築";
                        }
                        else if (getRangeNum == 9)
                        {
                            player8Card3Number9 = 1;
                            text7c.text = "小偷";
                        }
                        DiceNumberTextScript.player8Card3string = text7c.text;
                    }
                    else if (i == 4)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum == getRangeNum2 || getRangeNum == getRangeNum3 || getRangeNum == getRangeNum4 || getRangeNum == getRangeNum5);
                        getRangeNum4 = getRangeNum;
                        if (getRangeNum == 1)
                        {
                            player8Card4Number1 = 1;
                            text7d.text = "接受物業(低)";
                        }
                        else if (getRangeNum == 2)
                        {
                            player8Card4Number2 = 1;
                            text7d.text = "上級借貸";
                        }
                        else if (getRangeNum == 3)
                        {
                            player8Card4Number3 = 1;
                            text7d.text = "集資";
                        }
                        else if (getRangeNum == 4)
                        {
                            player8Card4Number4 = 1;
                            text7d.text = "眾集人口";
                        }
                        else if (getRangeNum == 5)
                        {
                            player8Card4Number5 = 1;
                            text7d.text = "共產主義";
                        }
                        else if (getRangeNum == 6)
                        {
                            player8Card4Number6 = 1;
                            text7d.text = "偷工減料";
                        }
                        else if (getRangeNum == 7)
                        {
                            player8Card4Number7 = 1;
                            text7d.text = "神之救濟";
                        }
                        else if (getRangeNum == 8)
                        {
                            player8Card4Number8 = 1;
                            text7d.text = "良心建築";
                        }
                        else if (getRangeNum == 9)
                        {
                            player8Card4Number9 = 1;
                            text7d.text = "小偷";
                        }
                        DiceNumberTextScript.player8Card4string = text7d.text;
                    }
                    else if (i == 5)
                    {
                        do
                        {
                            getRangeNum = Random.Range(1, 10);
                        }
                        while (getRangeNum == getRangeNum2 || getRangeNum == getRangeNum3 || getRangeNum == getRangeNum4 || getRangeNum == getRangeNum1);
                        getRangeNum5 = getRangeNum;
                        if (getRangeNum == 1)
                        {
                            player8Card5Number1 = 1;
                            text7e.text = "接受物業(低)";
                        }
                        else if (getRangeNum == 2)
                        {
                            player8Card5Number2 = 1;
                            text7e.text = "上級借貸";
                        }
                        else if (getRangeNum == 3)
                        {
                            player8Card5Number3 = 1;
                            text7e.text = "集資";
                        }
                        else if (getRangeNum == 4)
                        {
                            player8Card5Number4 = 1;
                            text7e.text = "眾集人口";
                        }
                        else if (getRangeNum == 5)
                        {
                            player8Card5Number5 = 1;
                            text7e.text = "共產主義";
                        }
                        else if (getRangeNum == 6)
                        {
                            player8Card5Number6 = 1;
                            text7e.text = "偷工減料";
                        }
                        else if (getRangeNum == 7)
                        {
                            player8Card5Number7 = 1;
                            text7e.text = "神之救濟";
                        }
                        else if (getRangeNum == 8)
                        {
                            player8Card5Number8 = 1;
                            text7e.text = "良心建築";
                        }
                        else if (getRangeNum == 9)
                        {
                            player8Card5Number9 = 1;
                            text7e.text = "小偷";
                        }
                        DiceNumberTextScript.player8Card5string = text7e.text;
                    }
                }
            }
        }

    }

}
