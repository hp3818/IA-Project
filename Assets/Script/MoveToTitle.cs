using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MoveToTitle : MonoBehaviour {

    public Button online;

    void Start()
    {
        online.interactable = false;
    }

	public void Clicked()
    {
        SceneManager.LoadScene("Title");
    }

    public void loadplayerSelecion()
    {
        SceneManager.LoadScene("Player selection");
    }

    public void loadNewtwork()
    {
        SceneManager.LoadScene("Online");
    }


}
