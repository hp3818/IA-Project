using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

	public void Clicked() {
        //Application.LoadLevel("Hong Shing Monopoly");
        SceneManager.LoadScene("Player selection");
	}

}
