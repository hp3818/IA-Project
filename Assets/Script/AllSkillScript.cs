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
        GameControl.player1Waypoint = 30;
        DiceNumberTextScript.jail1 = 1;
        GameControl.ImageForJailSkill.gameObject.SetActive(false);
        DropZone1.doing = 0;
    }

    public void choosePeople2ForJail()
    {
        player2.GetComponent<FollowThePath>().transform.position = waypoints[30].transform.position;
        player1.GetComponent<FollowThePath>().wayPointIndex = 30;
        GameControl.ImageForJailSkill.gameObject.SetActive(false);
        DiceNumberTextScript.jail2 = 1; 
        DropZone1.doing = 0;
    }

    public void choosePeople3ForJail()
    {
        player3.GetComponent<FollowThePath>().transform.position = waypoints[30].transform.position;
        if (GameControl.numberOfPlayer ==4 || GameControl.numberOfPlayer == 5)
        {
            DiceNumberTextScript.jail4 = 1; 
        }
        else
        {
            DiceNumberTextScript.jail3 = 1; 
        }
        GameControl.ImageForJailSkill.gameObject.SetActive(false);
        DropZone1.doing = 0;
    } 

    public void choosePeople4ForJail()
    {
        if (GameControl.numberOfPlayer == 4 || GameControl.numberOfPlayer == 5)
        {
            player4.GetComponent<FollowThePath>().transform.position = waypoints[30].transform.position;
            DiceNumberTextScript.jail4 = 1; 
        }
        else
        {
            player3.GetComponent<FollowThePath>().transform.position = waypoints[30].transform.position;
            DiceNumberTextScript.jail3 = 1; 
        }
        GameControl.ImageForJailSkill.gameObject.SetActive(false);
        DropZone1.doing = 0;
    }

    public void choosePeople5ForJail()
    {
        if (GameControl.numberOfPlayer == 4 || GameControl.numberOfPlayer == 5)
        {
            player4.GetComponent<FollowThePath>().transform.position = waypoints[30].transform.position;
            DiceNumberTextScript.jail4 = 1; 
        }
        else
        {
            player5.GetComponent<FollowThePath>().transform.position = waypoints[30].transform.position;
            DiceNumberTextScript.jail5 = 1; 
        }
        GameControl.ImageForJailSkill.gameObject.SetActive(false);
        DropZone1.doing = 0;
    }

    public void choosePeople6ForJail()
    {
        player6.GetComponent<FollowThePath>().transform.position = waypoints[30].transform.position;
        GameControl.ImageForJailSkill.gameObject.SetActive(false);
        DiceNumberTextScript.jail6 = 1; 
        DropZone1.doing = 0;
    }

    public void choosePeople7ForJail()
    {
        player7.GetComponent<FollowThePath>().transform.position = waypoints[30].transform.position;
        GameControl.ImageForJailSkill.gameObject.SetActive(false);
        DiceNumberTextScript.jail7 = 1; 
        DropZone1.doing = 0;
    }

    public void choosePeople8ForJail()
    {
        player8.GetComponent<FollowThePath>().transform.position = waypoints[30].transform.position;
        GameControl.ImageForJailSkill.gameObject.SetActive(false);
        DiceNumberTextScript.jail8 = 1;
        DropZone1.doing = 0;
    }


}
