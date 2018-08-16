using UnityEngine;
using UnityEngine.UI;

public class Skill : MonoBehaviour {

    public Button dropButton;
    public static int luckydraw = 0;

    public void NoClicked()
    {
        GameControl.ImageForMidSkill.gameObject.SetActive(false);
        GameControl.ImageForMid.gameObject.SetActive(true);
    }

    public void YesButton()
    {
        DiceNumberTextScript.OK = 0; // no animation
        GameControl.ImageForMidSkill.gameObject.SetActive(false);
        DiceNumberTextScript.dice1.gameObject.SetActive(true);
        DiceNumberTextScript.dice2.gameObject.SetActive(false);
        DiceNumberTextScript.dice3.gameObject.SetActive(false);
        DiceNumberTextScript.dice2Number = 0;
        GameControl.diceSide2Thrown = 0;
        DiceNumberTextScript.dice3Number = 0;
        GameControl.diceSide3Thrown = 0;
        DiceScript.Vaild = 1;
        DiceScript2.Vaild = 1;
        DiceScript3.Vaild = 1;
        dropButton.interactable = false;
        luckydraw = 1;
    }

}
