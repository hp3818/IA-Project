using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerSelectionConfirm : MonoBehaviour {

    public Text text;

    public int numberOfPlayer;

	public void Clicked()
    {
        numberOfPlayer = int.Parse(text.text);
        GameControl.numberOfPlayer = numberOfPlayer;
        //Debug.Log(numberOfPlayer);
        SceneManager.LoadScene("Hong Shing Monopoly");
    }

}
