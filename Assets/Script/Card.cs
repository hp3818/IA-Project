using UnityEngine;
using UnityEngine.EventSystems;
using System.Collections;
using UnityEngine.UI;


public class Card : MonoBehaviour {

    public static GameObject children_gameObject;
    public static bool runOnce = false;
    public static int i = 0;
    public static GameObject Card1, Card2, Card3, Card4, Card5;
    public static GameObject dropzone;
    public Text skillName1, skillName2, skillName3, skillName4, skillName5;
    public Button dropButton;
    public static int show = 0;

    void Start()
    {
        Card1 = GameObject.Find("Card1");
        Card2 = GameObject.Find("Card2");
        Card3 = GameObject.Find("Card3");
        Card4 = GameObject.Find("Card4");
        Card5 = GameObject.Find("Card5");
        dropzone = GameObject.Find("Hand");
    }

	void Update () {

        if (show == 1)
        {
            Card1.gameObject.SetActive(false);
            Card2.gameObject.SetActive(false);
            Card3.gameObject.SetActive(false);
            Card4.gameObject.SetActive(false);
            Card5.gameObject.SetActive(false);
        }

        if (this.transform.childCount < 33)
            return;
        else {
            if (!runOnce && i == 1)
            {
                children_gameObject = Draggable.OP;
                ShowMessage();
                i = 0;
                runOnce = true;
            }
            
        }
    }

    void ShowMessage()
    {
        //dropButton.interactable = false;
        if (children_gameObject.name == "Card1")
        {
            if (DiceNumberTextScript.whosTurn == 1)
            {
                Card1.gameObject.SetActive(false);
                Card1.transform.parent = dropzone.transform;
                DiceNumberTextScript.hide11 = 1;
                if (skillName1.text == "強制入獄")
                {
                    GameControl.ImageForJailSkill.gameObject.SetActive(true);
                }
            }
            if (DiceNumberTextScript.whosTurn == 2)
            {
                Card1.gameObject.SetActive(false);
                Card1.transform.parent = dropzone.transform;
                DiceNumberTextScript.hide21 = 1;
            }
            if (DiceNumberTextScript.whosTurn == 3)
            {
                Card1.gameObject.SetActive(false);
                Card1.transform.parent = dropzone.transform;
                DiceNumberTextScript.hide31 = 1;
            }
            if (DiceNumberTextScript.whosTurn == 4)
            {
                Card1.gameObject.SetActive(false);
                Card1.transform.parent = dropzone.transform;
                DiceNumberTextScript.hide41 = 1;
            }
            if (DiceNumberTextScript.whosTurn == 5)
            {
                Card1.gameObject.SetActive(false);
                Card1.transform.parent = dropzone.transform;
                DiceNumberTextScript.hide51 = 1;
            }
            if (DiceNumberTextScript.whosTurn == 6)
            {
                Card1.gameObject.SetActive(false);
                Card1.transform.parent = dropzone.transform;
                DiceNumberTextScript.hide61 = 1;
            }
            if (DiceNumberTextScript.whosTurn == 7)
            {
                Card1.gameObject.SetActive(false);
                Card1.transform.parent = dropzone.transform;
                DiceNumberTextScript.hide71 = 1;
            }
            if (DiceNumberTextScript.whosTurn == 8)
            {
                Card1.gameObject.SetActive(false);
                Card1.transform.parent = dropzone.transform;
                DiceNumberTextScript.hide81 = 1;
            }

        }
        if (children_gameObject.name == "Card2")
        {
            if (DiceNumberTextScript.whosTurn == 1)
            {
                Card2.gameObject.SetActive(false);
                Card2.transform.parent = dropzone.transform;
                DiceNumberTextScript.hide12 = 1;
                if (skillName2.text == "強制入獄")
                {
                    GameControl.ImageForJailSkill.gameObject.SetActive(true);
                }
            }
            if (DiceNumberTextScript.whosTurn == 2)
            {
                Card2.gameObject.SetActive(false);
                Card2.transform.parent = dropzone.transform;
                DiceNumberTextScript.hide22 = 1;
            }
            if (DiceNumberTextScript.whosTurn == 3)
            {
                Card2.gameObject.SetActive(false);
                Card2.transform.parent = dropzone.transform;
                DiceNumberTextScript.hide32 = 1;
            }
            if (DiceNumberTextScript.whosTurn == 4)
            {
                Card2.gameObject.SetActive(false);
                Card2.transform.parent = dropzone.transform;
                DiceNumberTextScript.hide42 = 1;
            }
            if (DiceNumberTextScript.whosTurn == 5)
            {
                Card2.gameObject.SetActive(false);
                Card2.transform.parent = dropzone.transform;
                DiceNumberTextScript.hide52 = 1;
            }
            if (DiceNumberTextScript.whosTurn == 6)
            {
                Card2.gameObject.SetActive(false);
                Card2.transform.parent = dropzone.transform;
                DiceNumberTextScript.hide62 = 1;
            }
            if (DiceNumberTextScript.whosTurn == 7)
            {
                Card2.gameObject.SetActive(false);
                Card2.transform.parent = dropzone.transform;
                DiceNumberTextScript.hide72 = 1;
            }
            if (DiceNumberTextScript.whosTurn == 8)
            {
                Card2.gameObject.SetActive(false);
                Card2.transform.parent = dropzone.transform;
                DiceNumberTextScript.hide82 = 1;
            }
        }
        if (children_gameObject.name == "Card3")
        {
            if (DiceNumberTextScript.whosTurn == 1)
            {
                Card3.gameObject.SetActive(false);
                Card3.transform.parent = dropzone.transform;
                DiceNumberTextScript.hide13 = 1;
                if (skillName3.text == "強制入獄")
                {
                    GameControl.ImageForJailSkill.gameObject.SetActive(true);
                }
            }
            if (DiceNumberTextScript.whosTurn == 2)
            {
                Card3.gameObject.SetActive(false);
                Card3.transform.parent = dropzone.transform;
                DiceNumberTextScript.hide23 = 1;
            }
            if (DiceNumberTextScript.whosTurn == 3)
            {
                Card3.gameObject.SetActive(false);
                Card3.transform.parent = dropzone.transform;
                DiceNumberTextScript.hide33 = 1;
            }
            if (DiceNumberTextScript.whosTurn == 4)
            {
                Card3.gameObject.SetActive(false);
                Card3.transform.parent = dropzone.transform;
                DiceNumberTextScript.hide43 = 1;
            }
            if (DiceNumberTextScript.whosTurn == 5)
            {
                Card3.gameObject.SetActive(false);
                Card3.transform.parent = dropzone.transform;
                DiceNumberTextScript.hide53 = 1;
            }
            if (DiceNumberTextScript.whosTurn == 6)
            {
                Card3.gameObject.SetActive(false);
                Card3.transform.parent = dropzone.transform;
                DiceNumberTextScript.hide63 = 1;
            }
            if (DiceNumberTextScript.whosTurn == 7)
            {
                Card3.gameObject.SetActive(false);
                Card3.transform.parent = dropzone.transform;
                DiceNumberTextScript.hide73 = 1;
            }
            if (DiceNumberTextScript.whosTurn == 8)
            {
                Card3.gameObject.SetActive(false);
                Card3.transform.parent = dropzone.transform;
                DiceNumberTextScript.hide83 = 1;
            }
        }
        if (children_gameObject.name == "Card4")
        {
            if (DiceNumberTextScript.whosTurn == 1)
            {
                Card4.gameObject.SetActive(false);
                Card4.transform.parent = dropzone.transform;
                DiceNumberTextScript.hide14 = 1;
                if (skillName4.text == "強制入獄")
                {
                    GameControl.ImageForJailSkill.gameObject.SetActive(true);
                }
            }
            if (DiceNumberTextScript.whosTurn == 2)
            {
                Card4.gameObject.SetActive(false);
                Card4.transform.parent = dropzone.transform;
                DiceNumberTextScript.hide24 = 1;
            }
            if (DiceNumberTextScript.whosTurn == 3)
            {
                Card4.gameObject.SetActive(false);
                Card4.transform.parent = dropzone.transform;
                DiceNumberTextScript.hide34 = 1;
            }
            if (DiceNumberTextScript.whosTurn == 4)
            {
                Card4.gameObject.SetActive(false);
                Card4.transform.parent = dropzone.transform;
                DiceNumberTextScript.hide44 = 1;
            }
            if (DiceNumberTextScript.whosTurn == 5)
            {
                Card4.gameObject.SetActive(false);
                Card4.transform.parent = dropzone.transform;
                DiceNumberTextScript.hide54 = 1;
            }
            if (DiceNumberTextScript.whosTurn == 6)
            {
                Card4.gameObject.SetActive(false);
                Card4.transform.parent = dropzone.transform;
                DiceNumberTextScript.hide64 = 1;
            }
            if (DiceNumberTextScript.whosTurn == 7)
            {
                Card4.gameObject.SetActive(false);
                Card4.transform.parent = dropzone.transform;
                DiceNumberTextScript.hide74 = 1;
            }
            if (DiceNumberTextScript.whosTurn == 8)
            {
                Card4.gameObject.SetActive(false);
                Card4.transform.parent = dropzone.transform;
                DiceNumberTextScript.hide84 = 1;
            }
        }
        if (children_gameObject.name == "Card5")
        {
            if (DiceNumberTextScript.whosTurn == 1)
            {
                Card5.gameObject.SetActive(false);
                Card5.transform.parent = dropzone.transform;
                DiceNumberTextScript.hide15 = 1;
                if (skillName5.text == "強制入獄")
                {
                    GameControl.ImageForJailSkill.gameObject.SetActive(true);
                }
            }
            if (DiceNumberTextScript.whosTurn == 2)
            {
                Card5.gameObject.SetActive(false);
                Card5.transform.parent = dropzone.transform;
                DiceNumberTextScript.hide25 = 1;
            }
            if (DiceNumberTextScript.whosTurn == 3)
            {
                Card5.gameObject.SetActive(false);
                Card5.transform.parent = dropzone.transform;
                DiceNumberTextScript.hide35 = 1;
            }
            if (DiceNumberTextScript.whosTurn == 4)
            {
                Card5.gameObject.SetActive(false);
                Card5.transform.parent = dropzone.transform;
                DiceNumberTextScript.hide45 = 1;
            }
            if (DiceNumberTextScript.whosTurn == 5)
            {
                Card5.gameObject.SetActive(false);
                Card5.transform.parent = dropzone.transform;
                DiceNumberTextScript.hide55 = 1;
            }
            if (DiceNumberTextScript.whosTurn == 6)
            {
                Card5.gameObject.SetActive(false);
                Card5.transform.parent = dropzone.transform;
                DiceNumberTextScript.hide65 = 1;
            }
            if (DiceNumberTextScript.whosTurn == 7)
            {
                Card5.gameObject.SetActive(false);
                Card5.transform.parent = dropzone.transform;
                DiceNumberTextScript.hide75 = 1;
            }
            if (DiceNumberTextScript.whosTurn == 8)
            {
                Card5.gameObject.SetActive(false);
                Card5.transform.parent = dropzone.transform;
                DiceNumberTextScript.hide85 = 1;
            }
        }
    }

    public IEnumerator TemporarilyDeactivat(float duration)
    {
        yield return new WaitForSeconds(duration);
    }

}
