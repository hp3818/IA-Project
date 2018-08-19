using UnityEngine;
using UnityEngine.UI;

public class AllSkillScript : MonoBehaviour {

    public Transform[] waypoints;
    public static GameObject player1, player2, player3, player4, player5, player6, player7, player8;
    public Text player1Cost, player2Cost, player3Cost, player4Cost, player5Cost, player6Cost, player7Cost, player8Cost;

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

    public void choosePeople1ForHospital()
    {
        player1.GetComponent<FollowThePath>().transform.position = waypoints[46].transform.position;
        player1.GetComponent<FollowThePath>().wayPointIndex = 46;
        GameControl.player1Waypoint = 46;
        DiceNumberTextScript.injure1 = 1;
        GameControl.ImageForHospitalSkill.gameObject.SetActive(false);
        DropZone1.doing = 0;
    }

    public void choosePeople2ForHospital()
    {
        player2.GetComponent<FollowThePath>().transform.position = waypoints[46].transform.position;
        player2.GetComponent<FollowThePath>().wayPointIndex = 46;
        GameControl.player2Waypoint = 46;
        DiceNumberTextScript.injure2 = 1;
        GameControl.ImageForHospitalSkill.gameObject.SetActive(false);
        DropZone1.doing = 0;
    }

    public void choosePeople3ForHospital()
    {
        player3.GetComponent<FollowThePath>().transform.position = waypoints[46].transform.position;
        player3.GetComponent<FollowThePath>().wayPointIndex = 46;
        GameControl.player3Waypoint = 46;
        DiceNumberTextScript.injure3 = 1;
        GameControl.ImageForHospitalSkill.gameObject.SetActive(false);
        DropZone1.doing = 0;
    }

    public void choosePeople4ForHospital()
    {
        player4.GetComponent<FollowThePath>().transform.position = waypoints[46].transform.position;
        player4.GetComponent<FollowThePath>().wayPointIndex = 46;
        GameControl.player4Waypoint = 46;
        DiceNumberTextScript.injure4 = 1;
        GameControl.ImageForHospitalSkill.gameObject.SetActive(false);
        DropZone1.doing = 0;
    }

    public void choosePeople5ForHospital()
    {
        player5.GetComponent<FollowThePath>().transform.position = waypoints[46].transform.position;
        player5.GetComponent<FollowThePath>().wayPointIndex = 46;
        GameControl.player5Waypoint = 46;
        DiceNumberTextScript.injure5 = 1;
        GameControl.ImageForHospitalSkill.gameObject.SetActive(false);
        DropZone1.doing = 0;
    }

    public void choosePeople6ForHospital()
    {
        player6.GetComponent<FollowThePath>().transform.position = waypoints[46].transform.position;
        player6.GetComponent<FollowThePath>().wayPointIndex = 46;
        GameControl.player6Waypoint = 46;
        DiceNumberTextScript.injure6 = 1;
        GameControl.ImageForHospitalSkill.gameObject.SetActive(false);
        DropZone1.doing = 0;
    }

    public void choosePeople7ForHospital()
    {
        player7.GetComponent<FollowThePath>().transform.position = waypoints[46].transform.position;
        player7.GetComponent<FollowThePath>().wayPointIndex = 46;
        GameControl.player7Waypoint = 46;
        DiceNumberTextScript.injure7 = 1;
        GameControl.ImageForHospitalSkill.gameObject.SetActive(false);
        DropZone1.doing = 0;
    }

    public void choosePeople8ForHospital()
    {
        player8.GetComponent<FollowThePath>().transform.position = waypoints[46].transform.position;
        player8.GetComponent<FollowThePath>().wayPointIndex = 46;
        GameControl.player8Waypoint = 46;
        DiceNumberTextScript.injure8 = 1;
        GameControl.ImageForHospitalSkill.gameObject.SetActive(false);
        DropZone1.doing = 0;
    }

    public void choosePoor()
    {
        if (GameControl.numberOfPlayer == 4)
        {
            HouseSelection.sum3 *= 0.9;
            player3Cost.text = HouseSelection.sum3.ToString();
            HouseSelection.sum4 *= 0.9;
            player4Cost.text = HouseSelection.sum4.ToString();

            double A = HouseSelection.sum3 *= 0.1; double B = HouseSelection.sum4 *= 0.1;
            HouseSelection.sum1 += (A + B);
            player1Cost.text = HouseSelection.sum1.ToString();
        }
        else if (GameControl.numberOfPlayer == 5) 
        {
            HouseSelection.sum3 *= 0.9;
            player3Cost.text = HouseSelection.sum3.ToString();
            HouseSelection.sum4 *= 0.9;
            player4Cost.text = HouseSelection.sum4.ToString();
            HouseSelection.sum5 *= 0.9;
            player5Cost.text = HouseSelection.sum5.ToString();

            double A = HouseSelection.sum3 *= 0.1; double B = HouseSelection.sum4 *= 0.1; double C = HouseSelection.sum4 *= 0.1;
            HouseSelection.sum1 += (A + B + C);
            player1Cost.text = HouseSelection.sum1.ToString();
        }
        else if (GameControl.numberOfPlayer == 6)
        {
            HouseSelection.sum4 *= 0.9;
            player4Cost.text = HouseSelection.sum4.ToString();
            HouseSelection.sum5 *= 0.9;
            player5Cost.text = HouseSelection.sum5.ToString();
            HouseSelection.sum6 *= 0.9;
            player6Cost.text = HouseSelection.sum6.ToString();
            double A = HouseSelection.sum4 *= 0.1; double B = HouseSelection.sum5 *= 0.1; double C = HouseSelection.sum6 *= 0.1;
            HouseSelection.sum1 += (A + B + C);
            player1Cost.text = HouseSelection.sum1.ToString();
        }
        else if (GameControl.numberOfPlayer == 7)
        {
            HouseSelection.sum4 *= 0.9;
            player4Cost.text = HouseSelection.sum4.ToString();
            HouseSelection.sum5 *= 0.9;
            player5Cost.text = HouseSelection.sum5.ToString();
            HouseSelection.sum6 *= 0.9;
            player6Cost.text = HouseSelection.sum6.ToString();
            HouseSelection.sum7 *= 0.9;
            player7Cost.text = HouseSelection.sum7.ToString();
            double A = HouseSelection.sum4 *= 0.1; double B = HouseSelection.sum5 *= 0.1; double C = HouseSelection.sum6 *= 0.1; double D = HouseSelection.sum7 *= 0.1;
            HouseSelection.sum1 += (A + B + C + D);
            player1Cost.text = HouseSelection.sum1.ToString();
        }
        else if (GameControl.numberOfPlayer == 8)
        {
            HouseSelection.sum4 *= 0.9;
            player4Cost.text = HouseSelection.sum4.ToString();
            HouseSelection.sum5 *= 0.9;
            player5Cost.text = HouseSelection.sum5.ToString();
            HouseSelection.sum6 *= 0.9;
            player6Cost.text = HouseSelection.sum6.ToString();
            HouseSelection.sum7 *= 0.9;
            player7Cost.text = HouseSelection.sum7.ToString();
            HouseSelection.sum8 *= 0.9;
            player8Cost.text = HouseSelection.sum8.ToString();
            double A = HouseSelection.sum4 *= 0.1; double B = HouseSelection.sum5 *= 0.1; double C = HouseSelection.sum6 *= 0.1; double D = HouseSelection.sum7 *= 0.1; double E = HouseSelection.sum8 *= 0.1;
            HouseSelection.sum1 += (A + B + C + D + E);
            player1Cost.text = HouseSelection.sum1.ToString();
        }
        GameControl.ImageForMonopoly.gameObject.SetActive(false);
        DropZone1.doing = 0;
    }

    public void chooseMiddle()
    {
        if (GameControl.numberOfPlayer == 4 || GameControl.numberOfPlayer == 5)
        {
            HouseSelection.sum2 *= 0.9;
            player2Cost.text = HouseSelection.sum2.ToString();
            double A = HouseSelection.sum2 *= 0.1;
            HouseSelection.sum1 += A;
            player1Cost.text = HouseSelection.sum1.ToString();
        }
        else if (GameControl.numberOfPlayer == 6 || GameControl.numberOfPlayer == 7 || GameControl.numberOfPlayer == 8)
        {
            HouseSelection.sum2 *= 0.9;
            player2Cost.text = HouseSelection.sum2.ToString();
            HouseSelection.sum3 *= 0.9;
            player3Cost.text = HouseSelection.sum3.ToString();
            double A = HouseSelection.sum2 *= 0.1; double B = HouseSelection.sum3 *= 0.1;
            HouseSelection.sum1 += (A + B);
            player1Cost.text = HouseSelection.sum1.ToString();
        }
        GameControl.ImageForMonopoly.gameObject.SetActive(false);
        DropZone1.doing = 0;
    }

}
