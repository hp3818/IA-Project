using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiceNumberSelection : MonoBehaviour {

    public Button dropButton;

    public void ClickedOneChoice () {
        DiceNumberTextScript.dice1.gameObject.SetActive(true);
        DiceNumberTextScript.dice2.gameObject.SetActive(false);
        DiceNumberTextScript.dice3.gameObject.SetActive(false);
        DiceNumberTextScript.dice2Number = 0; GameControl.diceSide2Thrown = 0;
        DiceNumberTextScript.dice3Number = 0; GameControl.diceSide3Thrown = 0;
        GameControl.ImageForMid.gameObject.SetActive(false);
        GameControl.ImageForRich.gameObject.SetActive(false);
        DiceScript.Vaild = 1;
        DiceScript2.Vaild = 1;
        DiceScript3.Vaild = 1;
        dropButton.interactable = false; 
    }

   public void ClickTwoChoice()
    {
        DiceNumberTextScript.dice1.gameObject.SetActive(true);
        DiceNumberTextScript.dice2.gameObject.SetActive(true);
        DiceNumberTextScript.dice3.gameObject.SetActive(false);
        DiceNumberTextScript.dice3Number = 0; GameControl.diceSide3Thrown = 0;
        GameControl.ImageForMid.gameObject.SetActive(false);
        GameControl.ImageForRich.gameObject.SetActive(false);
        DiceScript.Vaild = 1;
        DiceScript2.Vaild = 1;
        DiceScript3.Vaild = 1;
        dropButton.interactable = false;
    }

    public void ClickThreeChoic ()
    {
        DiceNumberTextScript.dice1.gameObject.SetActive(true);
        DiceNumberTextScript.dice2.gameObject.SetActive(true);
        DiceNumberTextScript.dice3.gameObject.SetActive(true);
        GameControl.ImageForMid.gameObject.SetActive(false);
        GameControl.ImageForRich.gameObject.SetActive(false);
        DiceScript.Vaild = 1;
        DiceScript2.Vaild = 1;
        DiceScript3.Vaild = 1;
        dropButton.interactable = false;
    }

}
