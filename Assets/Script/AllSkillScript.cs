using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllSkillScript : MonoBehaviour {

    public Transform[] waypoints;
    public static GameObject player1, player2, player3, player4, player5, player6, player7, player8;

    void Start()
    {
        player1 = GameObject.Find("player1");
        player2 = GameObject.Find("player2");
        player3 = GameObject.Find("player3");
        player4 = GameObject.Find("player4");
        player5 = GameObject.Find("player5");
        player6 = GameObject.Find("player6");
        player7 = GameObject.Find("player7");
        player8 = GameObject.Find("player8");
    }

    // All skills for Rich
    public void choosePeople1ForJail()
    {
        player1.GetComponent<FollowThePath>().transform.position = waypoints[30].transform.position;
        player1.GetComponent<FollowThePath>().wayPointIndex = 30;
        GameControl.ImageForJailSkill.gameObject.SetActive(false);
        DiceNumberTextScript.whosTurn++;
        DiceNumberTextScript.jail1 = 1;
        Debug.Log(DiceNumberTextScript.whosTurn);
    }

    public void choosePeople2ForJail()
    {
        player2.GetComponent<FollowThePath>().transform.position = waypoints[30].transform.position;
        player1.GetComponent<FollowThePath>().wayPointIndex = 30;
        GameControl.ImageForJailSkill.gameObject.SetActive(false);
        DiceNumberTextScript.jail1 = 2; DiceNumberTextScript.whosTurn++;
    }

    public void choosePeople3ForJail()
    {
        player3.GetComponent<FollowThePath>().transform.position = waypoints[30].transform.position;
        GameControl.ImageForJailSkill.gameObject.SetActive(false);
        DiceNumberTextScript.jail1 = 3; DiceNumberTextScript.whosTurn++;
    } 

    public void choosePeople4ForJail()
    {
        if (GameControl.numberOfPlayer == 4 || GameControl.numberOfPlayer == 5)
        {
            player3.GetComponent<FollowThePath>().transform.position = waypoints[30].transform.position;
            DiceNumberTextScript.jail3 = 1; DiceNumberTextScript.whosTurn++;
        }
        else
        {
            player4.GetComponent<FollowThePath>().transform.position = waypoints[30].transform.position;
            DiceNumberTextScript.jail4 = 1; DiceNumberTextScript.whosTurn++;
        }
        GameControl.ImageForJailSkill.gameObject.SetActive(false);

    }

    public void choosePeople5ForJail()
    {
        if (GameControl.numberOfPlayer == 4 || GameControl.numberOfPlayer == 5)
        {
            player4.GetComponent<FollowThePath>().transform.position = waypoints[30].transform.position;
            DiceNumberTextScript.jail4 = 1; DiceNumberTextScript.whosTurn++;
        }
        else
        {
            player5.GetComponent<FollowThePath>().transform.position = waypoints[30].transform.position;
            DiceNumberTextScript.jail5 = 1; DiceNumberTextScript.whosTurn++;
        }
        GameControl.ImageForJailSkill.gameObject.SetActive(false);
    }

    public void choosePeople6ForJail()
    {
        player6.GetComponent<FollowThePath>().transform.position = waypoints[30].transform.position;
        GameControl.ImageForJailSkill.gameObject.SetActive(false);
        DiceNumberTextScript.jail6 = 1; DiceNumberTextScript.whosTurn++;
    }

    public void choosePeople7ForJail()
    {
        player7.GetComponent<FollowThePath>().transform.position = waypoints[30].transform.position;
        GameControl.ImageForJailSkill.gameObject.SetActive(false);
        DiceNumberTextScript.jail7 = 1; DiceNumberTextScript.whosTurn++;
    }

    public void choosePeople8ForJail()
    {
        player8.GetComponent<FollowThePath>().transform.position = waypoints[30].transform.position;
        GameControl.ImageForJailSkill.gameObject.SetActive(false);
        DiceNumberTextScript.jail8 = 1; DiceNumberTextScript.whosTurn++;
    }


}
