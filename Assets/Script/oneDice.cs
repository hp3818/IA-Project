using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oneDice : MonoBehaviour {

    public static AudioSource play;

    void Start()
    {
        play = gameObject.GetComponent<AudioSource>();
    }

    public static void OneDice()
    {
        play.Play();
    }

}
