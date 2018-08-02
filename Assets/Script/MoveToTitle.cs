using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToTitle : MonoBehaviour {

	public void Clicked()
    {
        SceneManager.LoadScene("Title");
    }
}
