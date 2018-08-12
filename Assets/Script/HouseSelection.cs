using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HouseSelection : MonoBehaviour {

    public Button dropButton;
    public Camera[] camera;
    public Button buy, payMoney;
    public Text player1Cost, player2Cost, player3Cost, player4Cost, player5Cost, player6Cost, player7Cost, player8Cost;
	public static double sum1 = 500000, sum4 = 150000, sum5 = 150000, sum6 = 150000, sum7 = 150000, sum8= 150000;
    public static double sum2, sum3;
    public static GameObject player1, player2, player3, player4, player5, player6, player7, player8;
    public Transform[] waypoints;
    public static int whosTurn, geter;
    public GameObject ImageForJail;
    public GameObject Level1Building1, Level1Building2, Level1Building3, Level1Building4, Level1Building5, Level1Building7, Level1Building8, Level1Building9,
                                         Level1Building11, Level1Building13, Level1Building14, Level1Building15, Level1Building16, Level1Building17, Level1Building19,
                                         Level1Building20, Level1Building22, Level1Building23, Level1Building24, Level1Building26, Level1Building27, Level1Building28, Level1Building29,
                                         Level1Building31, Level1Building32, Level1Building33, Level1Building34, Level1Building36, Level1Building37, Level1Building39, Level1Building40,
                                         Level1Building42, Level1Building43, Level1Building44, Level1Building47, Level1Building48, Level1Building49,
                                         Level1Building51, Level1Building52, Level1Building55, Level1Building56, Level1Building57;
    public GameObject Level2Building1, Level2Building2, Level2Building3, Level2Building4, Level2Building5, Level2Building7, Level2Building8, Level2Building9,
                                         Level2Building11, Level2Building13, Level2Building14, Level2Building15, Level2Building16, Level2Building17, Level2Building19,
                                         Level2Building20, Level2Building22, Level2Building23, Level2Building24, Level2Building26, Level2Building27, Level2Building28, Level2Building29,
                                         Level2Building31, Level2Building32, Level2Building33, Level2Building34, Level2Building36, Level2Building37, Level2Building39, Level2Building40,
                                         Level2Building42, Level2Building43, Level2Building44, Level2Building47, Level2Building48, Level2Building49,
                                         Level2Building51, Level2Building52, Level2Building55, Level2Building56, Level2Building57;
    public GameObject Level3Building1, Level3Building2, Level3Building3, Level3Building4, Level3Building5, Level3Building7, Level3Building8, Level3Building9,
                                         Level3Building11, Level3Building13, Level3Building14, Level3Building15, Level3Building16, Level3Building17, Level3Building19,
                                         Level3Building20, Level3Building22, Level3Building23, Level3Building24, Level3Building26, Level3Building27, Level3Building28, Level3Building29,
                                         Level3Building31, Level3Building32, Level3Building33, Level3Building34, Level3Building36, Level3Building37, Level3Building39, Level3Building40,
                                         Level3Building42, Level3Building43, Level3Building44, Level3Building47, Level3Building48, Level3Building49,
                                         Level3Building51, Level3Building52, Level3Building55, Level3Building56, Level3Building57;


    public static int reduce;

    void Start()
    {
        player1Cost.text = "500000";

        if (GameControl.numberOfPlayer == 4 || GameControl.numberOfPlayer == 5)
        {
            sum2 = 500000; sum3 = 150000;
            player2Cost.text = "500000";
            player3Cost.text = "150000";
        }
        if (GameControl.numberOfPlayer == 6 || GameControl.numberOfPlayer == 7 || GameControl.numberOfPlayer == 8)
        {
            sum2 = 500000; sum3 = 500000;
            player2Cost.text = "500000";
            player3Cost.text = "500000";
        }
        player4Cost.text = "150000";
        player5Cost.text = "150000";
        player6Cost.text = "150000";
        player7Cost.text = "150000";
        player8Cost.text = "150000";
    }

    public void Buy()
    {
        player1 = GameObject.Find("player1");
        player2 = GameObject.Find("player2");
        player3 = GameObject.Find("player3");
        player4 = GameObject.Find("player4");
        player5 = GameObject.Find("player5");
        player6 = GameObject.Find("player6");
        player7 = GameObject.Find("player7");
        player8 = GameObject.Find("player8");

        if (GameControl.whoTurn == 1)
        {
            if (sum1 - reduce < 0)
            {
                sum1 = 0;
                buy.interactable = false;
            }
            else
            {
                sum1 -= reduce;
            }

            player1Cost.text = sum1.ToString();

			if (player1.GetComponent<FollowThePath> ().transform.position == waypoints [1].transform.position) {
				GameControl.count1++;
				GameControl.own1 = 1;
                if (GameControl.count1 == 1) 
                    Level1Building1.gameObject.SetActive(true);
                else if (GameControl.count1 == 2)
                {
                    Level1Building1.gameObject.SetActive(false);
                    Level2Building1.gameObject.SetActive(true);
                } else if (GameControl.count1 == 3)
                {
                    Level2Building1.gameObject.SetActive(false);
                    Level3Building1.gameObject.SetActive(true);
                }

            }
			if (player1.GetComponent<FollowThePath> ().transform.position == waypoints [2].transform.position) {
				GameControl.count2++;
				GameControl.own2 = 1;
                if (GameControl.count2 == 1)
                    Level1Building2.gameObject.SetActive(true);
                else if (GameControl.count2 == 2)
                {
                    Level1Building2.gameObject.SetActive(false);
                    Level2Building2.gameObject.SetActive(true);
                }
                else if (GameControl.count2 == 3)
                {
                    Level2Building2.gameObject.SetActive(false);
                    Level3Building2.gameObject.SetActive(true);
                }
            }   
			if (player1.GetComponent<FollowThePath> ().transform.position == waypoints [3].transform.position) {
				GameControl.count3++;
				GameControl.own3 = 1;
                if (GameControl.count3 == 1)
                    Level1Building3.gameObject.SetActive(true);
                else if (GameControl.count3 == 2)
                {
                    Level1Building3.gameObject.SetActive(false);
                    Level2Building3.gameObject.SetActive(true);
                }
                else if (GameControl.count3 == 3)
                {
                    Level2Building3.gameObject.SetActive(false);
                    Level3Building3.gameObject.SetActive(true);
                }
            }  
			if (player1.GetComponent<FollowThePath>().transform.position == waypoints[4].transform.position) {
				GameControl.count4++;
				GameControl.own4 = 1;
                if (GameControl.count4 == 1)
                    Level1Building4.gameObject.SetActive(true);
                else if (GameControl.count4 == 2)
                {
                    Level1Building4.gameObject.SetActive(false);
                    Level2Building4.gameObject.SetActive(true);
                }
                else if (GameControl.count4 == 3)
                {
                    Level2Building4.gameObject.SetActive(false);
                    Level3Building4.gameObject.SetActive(true);
                }
            }   
			if (player1.GetComponent<FollowThePath>().transform.position == waypoints[5].transform.position) {
				GameControl.count5++;
				GameControl.own5 = 1;
                if (GameControl.count5 == 1)
                    Level1Building5.gameObject.SetActive(true);
                else if (GameControl.count5 == 2)
                {
                    Level1Building5.gameObject.SetActive(false);
                    Level2Building5.gameObject.SetActive(true);
                }
                else if (GameControl.count5 == 3)
                {
                    Level2Building5.gameObject.SetActive(false);
                    Level3Building5.gameObject.SetActive(true);
                }
            }   
			if (player1.GetComponent<FollowThePath> ().transform.position == waypoints [7].transform.position) {
				GameControl.count6++;
				GameControl.own6 = 1;
                if (GameControl.count6 == 1)
                    Level1Building7.gameObject.SetActive(true);
                else if (GameControl.count6 == 2)
                {
                    Level1Building7.gameObject.SetActive(false);
                    Level2Building7.gameObject.SetActive(true);
                }
                else if (GameControl.count6 == 3)
                {
                    Level2Building7.gameObject.SetActive(false);
                    Level3Building7.gameObject.SetActive(true);
                }
            }
			if (player1.GetComponent<FollowThePath> ().transform.position == waypoints [8].transform.position) {
				GameControl.count7++;
				GameControl.own7 = 1;
                if (GameControl.count7 == 1)
                    Level1Building8.gameObject.SetActive(true);
                else if (GameControl.count7 == 2)
                {
                    Level1Building8.gameObject.SetActive(false);
                    Level2Building8.gameObject.SetActive(true);
                }
                else if (GameControl.count7 == 3)
                {
                    Level2Building8.gameObject.SetActive(false);
                    Level3Building8.gameObject.SetActive(true);
                }
            }
			if (player1.GetComponent<FollowThePath> ().transform.position == waypoints [9].transform.position) {
				GameControl.count8++;
				GameControl.own8 = 1;
                if (GameControl.count8 == 1)
                    Level1Building9.gameObject.SetActive(true);
                else if (GameControl.count8 == 2)
                {
                    Level1Building9.gameObject.SetActive(false);
                    Level2Building9.gameObject.SetActive(true);
                }
                else if (GameControl.count8 == 3)
                {
                    Level2Building9.gameObject.SetActive(false);
                    Level3Building9.gameObject.SetActive(true);
                }

            }
			if (player1.GetComponent<FollowThePath>().transform.position == waypoints[10].transform.position)
			{
				GameControl.count9++;
				GameControl.buyValue = 1;
				GameControl.own9 = 1;
            }        
			if (player1.GetComponent<FollowThePath>().transform.position == waypoints[11].transform.position) {
				GameControl.count10++;
				GameControl.own10 = 1;
                if (GameControl.count10 == 1)
                    Level1Building11.gameObject.SetActive(true);
                else if (GameControl.count10 == 2)
                {
                    Level1Building11.gameObject.SetActive(false);
                    Level2Building11.gameObject.SetActive(true);
                }
                else if (GameControl.count10 == 3)
                {
                    Level2Building11.gameObject.SetActive(false);
                    Level3Building11.gameObject.SetActive(true);
                }
            }  
			if (player1.GetComponent<FollowThePath>().transform.position == waypoints[13].transform.position) {
				GameControl.count11++;
				GameControl.own11 = 1;
                if (GameControl.count11 == 1)
                    Level1Building13.gameObject.SetActive(true);
                else if (GameControl.count11 == 2)
                {
                    Level1Building13.gameObject.SetActive(false);
                    Level2Building13.gameObject.SetActive(true);
                }
                else if (GameControl.count11 == 3)
                {
                    Level2Building13.gameObject.SetActive(false);
                    Level3Building13.gameObject.SetActive(true);
                }
            }
			if (player1.GetComponent<FollowThePath>().transform.position == waypoints[14].transform.position) {
				GameControl.count12++;
				GameControl.own12 = 1;
                if (GameControl.count12 == 1)
                    Level1Building14.gameObject.SetActive(true);
                else if (GameControl.count12 == 2)
                {
                    Level1Building14.gameObject.SetActive(false);
                    Level2Building14.gameObject.SetActive(true);
                }
                else if (GameControl.count12 == 3)
                {
                    Level2Building14.gameObject.SetActive(false);
                    Level3Building14.gameObject.SetActive(true);
                }
            }
			if (player1.GetComponent<FollowThePath>().transform.position == waypoints[15].transform.position) {
				GameControl.count13++;
				GameControl.own13 = 1;
                if (GameControl.count13 == 1)
                    Level1Building15.gameObject.SetActive(true);
                else if (GameControl.count13 == 2)
                {
                    Level1Building15.gameObject.SetActive(false);
                    Level2Building15.gameObject.SetActive(true);
                }
                else if (GameControl.count13 == 3)
                {
                    Level2Building15.gameObject.SetActive(false);
                    Level3Building15.gameObject.SetActive(true);
                }
            }
			if (player1.GetComponent<FollowThePath>().transform.position == waypoints[16].transform.position)  {
				GameControl.count14++;
				GameControl.own14 = 1;
                if (GameControl.count14 == 1)
                    Level1Building16.gameObject.SetActive(true);
                else if (GameControl.count14 == 2)
                {
                    Level1Building16.gameObject.SetActive(false);
                    Level2Building16.gameObject.SetActive(true);
                }
                else if (GameControl.count14 == 3)
                {
                    Level2Building16.gameObject.SetActive(false);
                    Level3Building16.gameObject.SetActive(true);
                }
            }
			if (player1.GetComponent<FollowThePath> ().transform.position == waypoints [17].transform.position) {
				GameControl.count15++;
				GameControl.own15 = 1;
                if (GameControl.count15 == 1)
                    Level1Building17.gameObject.SetActive(true);
                else if (GameControl.count15 == 2)
                {
                    Level1Building17.gameObject.SetActive(false);
                    Level2Building17.gameObject.SetActive(true);
                }
                else if (GameControl.count15 == 3)
                {
                    Level2Building17.gameObject.SetActive(false);
                    Level3Building17.gameObject.SetActive(true);
                }
            }  
			if (player1.GetComponent<FollowThePath> ().transform.position == waypoints [19].transform.position) {
				GameControl.count16++;
				GameControl.own16 = 1;
                if (GameControl.count16 == 1)
                    Level1Building19.gameObject.SetActive(true);
                else if (GameControl.count16 == 2)
                {
                    Level1Building19.gameObject.SetActive(false);
                    Level2Building19.gameObject.SetActive(true);
                }
                else if (GameControl.count16 == 3)
                {
                    Level2Building19.gameObject.SetActive(false);
                    Level3Building19.gameObject.SetActive(true);
                }
            }
			if (player1.GetComponent<FollowThePath>().transform.position == waypoints[20].transform.position) {
				GameControl.count17++;
				GameControl.own17 = 1;
                if (GameControl.count17 == 1)
                    Level1Building19.gameObject.SetActive(true);
                else if (GameControl.count17 == 2)
                {
                    Level1Building20.gameObject.SetActive(false);
                    Level2Building20.gameObject.SetActive(true);
                }
                else if (GameControl.count17 == 3)
                {
                    Level2Building20.gameObject.SetActive(false);
                    Level3Building20.gameObject.SetActive(true);
                }
            }
			if (player1.GetComponent<FollowThePath>().transform.position == waypoints[21].transform.position)
			{
				GameControl.count18++;
				GameControl.buyValue = 1;
				GameControl.own18 = 1;
			}
			if (player1.GetComponent<FollowThePath>().transform.position == waypoints[22].transform.position) {
				GameControl.count19++;
				GameControl.own19 = 1;
                if (GameControl.count19 == 1)
                    Level1Building22.gameObject.SetActive(true);
                else if (GameControl.count19 == 2)
                {
                    Level1Building22.gameObject.SetActive(false);
                    Level2Building22.gameObject.SetActive(true);
                }
                else if (GameControl.count19 == 3)
                {
                    Level2Building22.gameObject.SetActive(false);
                    Level3Building22.gameObject.SetActive(true);
                }
            }
			if (player1.GetComponent<FollowThePath>().transform.position == waypoints[23].transform.position) {
				GameControl.count20++;
				GameControl.own20 = 3;
                if (GameControl.count20 == 1)
                    Level1Building23.gameObject.SetActive(true);
                else if (GameControl.count20 == 2)
                {
                    Level1Building23.gameObject.SetActive(false);
                    Level2Building23.gameObject.SetActive(true);
                }
                else if (GameControl.count20 == 3)
                {
                    Level2Building23.gameObject.SetActive(false);
                    Level3Building23.gameObject.SetActive(true);
                }
            }
			if (player3.GetComponent<FollowThePath>().transform.position == waypoints[24].transform.position) {
				GameControl.count21++;
				GameControl.own21 = 1;
                if (GameControl.count21 == 1)
                    Level1Building24.gameObject.SetActive(true);
                else if (GameControl.count21 == 2)
                {
                    Level1Building24.gameObject.SetActive(false);
                    Level2Building24.gameObject.SetActive(true);
                }
                else if (GameControl.count21 == 3)
                {
                    Level2Building24.gameObject.SetActive(false);
                    Level3Building24.gameObject.SetActive(true);
                }
            }
			if (player1.GetComponent<FollowThePath>().transform.position == waypoints[26].transform.position) {
				GameControl.count22++;
				GameControl.own22 = 1;
                if (GameControl.count22 == 1)
                    Level1Building26.gameObject.SetActive(true);
                else if (GameControl.count22 == 2)
                {
                    Level1Building26.gameObject.SetActive(false);
                    Level2Building26.gameObject.SetActive(true);
                }
                else if (GameControl.count22 == 3)
                {
                    Level2Building26.gameObject.SetActive(false);
                    Level3Building26.gameObject.SetActive(true);
                }
            }
			if (player1.GetComponent<FollowThePath>().transform.position == waypoints[27].transform.position) {
				GameControl.count23++;
				GameControl.own23 = 1;
                if (GameControl.count23 == 1)
                    Level1Building27.gameObject.SetActive(true);
                else if (GameControl.count23 == 2)
                {
                    Level1Building27.gameObject.SetActive(false);
                    Level2Building27.gameObject.SetActive(true);
                }
                else if (GameControl.count23 == 3)
                {
                    Level2Building27.gameObject.SetActive(false);
                    Level3Building27.gameObject.SetActive(true);
                }
            }
			if (player1.GetComponent<FollowThePath>().transform.position == waypoints[28].transform.position) {
				GameControl.count24++;
				GameControl.own24 = 1;
                if (GameControl.count24 == 1)
                    Level1Building28.gameObject.SetActive(true);
                else if (GameControl.count24 == 2)
                {
                    Level1Building28.gameObject.SetActive(false);
                    Level2Building28.gameObject.SetActive(true);
                }
                else if (GameControl.count24 == 3)
                {
                    Level2Building28.gameObject.SetActive(false);
                    Level3Building28.gameObject.SetActive(true);
                }
            }
			if (player1.GetComponent<FollowThePath>().transform.position == waypoints[29].transform.position) {
				GameControl.count25++;
				GameControl.own25 = 1;
                if (GameControl.count25 == 1)
                    Level1Building29.gameObject.SetActive(true);
                else if (GameControl.count25 == 2)
                {
                    Level1Building29.gameObject.SetActive(false);
                    Level2Building29.gameObject.SetActive(true);
                }
                else if (GameControl.count25 == 3)
                {
                    Level2Building29.gameObject.SetActive(false);
                    Level3Building29.gameObject.SetActive(true);
                }
            }
			if (player1.GetComponent<FollowThePath>().transform.position == waypoints[31].transform.position) {
				GameControl.count26++;
				GameControl.own26 = 1;
                if (GameControl.count26 == 1)
                    Level1Building31.gameObject.SetActive(true);
                else if (GameControl.count26 == 2)
                {
                    Level1Building31.gameObject.SetActive(false);
                    Level2Building31.gameObject.SetActive(true);
                }
                else if (GameControl.count26 == 3)
                {
                    Level2Building31.gameObject.SetActive(false);
                    Level3Building31.gameObject.SetActive(true);
                }
            }
			if (player1.GetComponent<FollowThePath>().transform.position == waypoints[32].transform.position) {
				GameControl.count27++;
				GameControl.own27 = 1;
                if (GameControl.count27 == 1)
                    Level1Building32.gameObject.SetActive(true);
                else if (GameControl.count27 == 2)
                {
                    Level1Building32.gameObject.SetActive(false);
                    Level2Building32.gameObject.SetActive(true);
                }
                else if (GameControl.count27 == 3)
                {
                    Level2Building32.gameObject.SetActive(false);
                    Level3Building32.gameObject.SetActive(true);
                }
            }
			if (player1.GetComponent<FollowThePath>().transform.position == waypoints[33].transform.position) {
				GameControl.count28++;
				GameControl.own28 = 1;
                if (GameControl.count28 == 1)
                    Level1Building33.gameObject.SetActive(true);
                else if (GameControl.count28 == 2)
                {
                    Level1Building33.gameObject.SetActive(false);
                    Level2Building33.gameObject.SetActive(true);
                }
                else if (GameControl.count28 == 3)
                {
                    Level2Building33.gameObject.SetActive(false);
                    Level3Building33.gameObject.SetActive(true);
                }
            }
			if (player1.GetComponent<FollowThePath>().transform.position == waypoints[34].transform.position) {
				GameControl.count29++;
				GameControl.own29 = 1;
                if (GameControl.count29 == 1)
                    Level1Building34.gameObject.SetActive(true);
                else if (GameControl.count29 == 2)
                {
                    Level1Building34.gameObject.SetActive(false);
                    Level2Building34.gameObject.SetActive(true);
                }
                else if (GameControl.count29 == 3)
                {
                    Level2Building34.gameObject.SetActive(false);
                    Level3Building34.gameObject.SetActive(true);
                }
            }
			if (player1.GetComponent<FollowThePath>().transform.position == waypoints[36].transform.position) {
				GameControl.count30++;
				GameControl.own30 = 1;
                if (GameControl.count30 == 1)
                    Level1Building36.gameObject.SetActive(true);
                else if (GameControl.count30 == 2)
                {
                    Level1Building36.gameObject.SetActive(false);
                    Level2Building36.gameObject.SetActive(true);
                }
                else if (GameControl.count30 == 3)
                {
                    Level2Building36.gameObject.SetActive(false);
                    Level3Building36.gameObject.SetActive(true);
                }
            }
			if (player1.GetComponent<FollowThePath>().transform.position == waypoints[37].transform.position) {
				GameControl.count31++;
				GameControl.own31 = 1;
                if (GameControl.count31 == 1)
                    Level1Building37.gameObject.SetActive(true);
                else if (GameControl.count31 == 2)
                {
                    Level1Building37.gameObject.SetActive(false);
                    Level2Building37.gameObject.SetActive(true);
                }
                else if (GameControl.count31 == 3)
                {
                    Level2Building37.gameObject.SetActive(false);
                    Level3Building37.gameObject.SetActive(true);
                }
            }
			if (player1.GetComponent<FollowThePath>().transform.position == waypoints[38].transform.position)
			{
				GameControl.count32++;
				GameControl.buyValue = 1;
				GameControl.own32 = 1;
			}  
			if (player1.GetComponent<FollowThePath>().transform.position == waypoints[39].transform.position) {
				GameControl.count33++;
				GameControl.own33 = 1;
                if (GameControl.count33 == 1)
                    Level1Building39.gameObject.SetActive(true);
                else if (GameControl.count33 == 2)
                {
                    Level1Building39.gameObject.SetActive(false);
                    Level2Building39.gameObject.SetActive(true);
                }
                else if (GameControl.count33 == 3)
                {
                    Level2Building39.gameObject.SetActive(false);
                    Level3Building39.gameObject.SetActive(true);
                }
            }
			if (player1.GetComponent<FollowThePath>().transform.position == waypoints[40].transform.position) {
				GameControl.count34++;
				GameControl.own34 = 1;
                if (GameControl.count34 == 1)
                    Level1Building40.gameObject.SetActive(true);
                else if (GameControl.count34 == 2)
                {
                    Level1Building40.gameObject.SetActive(false);
                    Level2Building40.gameObject.SetActive(true);
                }
                else if (GameControl.count34 == 3)
                {
                    Level2Building40.gameObject.SetActive(false);
                    Level3Building40.gameObject.SetActive(true);
                }
            }
			if (player1.GetComponent<FollowThePath>().transform.position == waypoints[42].transform.position) {
				GameControl.count35++;
				GameControl.own35 = 1;
                if (GameControl.count35 == 1)
                    Level1Building42.gameObject.SetActive(true);
                else if (GameControl.count35 == 2)
                {
                    Level1Building42.gameObject.SetActive(false);
                    Level2Building42.gameObject.SetActive(true);
                }
                else if (GameControl.count35 == 3)
                {
                    Level2Building42.gameObject.SetActive(false);
                    Level3Building42.gameObject.SetActive(true);
                }
            }
			if (player1.GetComponent<FollowThePath>().transform.position == waypoints[43].transform.position) {
				GameControl.count36++;
				GameControl.own36 = 1;
                if (GameControl.count36 == 1)
                    Level1Building43.gameObject.SetActive(true);
                else if (GameControl.count36 == 2)
                {
                    Level1Building43.gameObject.SetActive(false);
                    Level2Building43.gameObject.SetActive(true);
                }
                else if (GameControl.count36 == 3)
                {
                    Level2Building43.gameObject.SetActive(false);
                    Level3Building43.gameObject.SetActive(true);
                }
            }
			if (player1.GetComponent<FollowThePath>().transform.position == waypoints[44].transform.position) {
				GameControl.count37++;
				GameControl.own37 = 1;
                if (GameControl.count37 == 1)
                    Level1Building44.gameObject.SetActive(true);
                else if (GameControl.count37 == 2)
                {
                    Level1Building44.gameObject.SetActive(false);
                    Level2Building44.gameObject.SetActive(true);
                }
                else if (GameControl.count37 == 3)
                {
                    Level2Building44.gameObject.SetActive(false);
                    Level3Building44.gameObject.SetActive(true);
                }
            }
			if (player1.GetComponent<FollowThePath>().transform.position == waypoints[47].transform.position) {
				GameControl.count38++;
				GameControl.own38 = 1;
                if (GameControl.count38 == 1)
                    Level1Building47.gameObject.SetActive(true);
                else if (GameControl.count38 == 2)
                {
                    Level1Building47.gameObject.SetActive(false);
                    Level2Building47.gameObject.SetActive(true);
                }
                else if (GameControl.count38 == 3)
                {
                    Level2Building47.gameObject.SetActive(false);
                    Level3Building47.gameObject.SetActive(true);
                }
            }
			if (player1.GetComponent<FollowThePath>().transform.position == waypoints[48].transform.position) {
				GameControl.count39++;
				GameControl.own39 = 1;
                if (GameControl.count39 == 1)
                    Level1Building48.gameObject.SetActive(true);
                else if (GameControl.count39 == 2)
                {
                    Level1Building48.gameObject.SetActive(false);
                    Level2Building48.gameObject.SetActive(true);
                }
                else if (GameControl.count39 == 3)
                {
                    Level2Building48.gameObject.SetActive(false);
                    Level3Building48.gameObject.SetActive(true);
                }
            }
			if (player1.GetComponent<FollowThePath>().transform.position == waypoints[49].transform.position) {
				GameControl.count40++;
				GameControl.own40 = 1;
                if (GameControl.count40 == 1)
                    Level1Building49.gameObject.SetActive(true);
                else if (GameControl.count40 == 2)
                {
                    Level1Building49.gameObject.SetActive(false);
                    Level2Building49.gameObject.SetActive(true);
                }
                else if (GameControl.count40 == 3)
                {
                    Level2Building49.gameObject.SetActive(false);
                    Level3Building49.gameObject.SetActive(true);
                }
            }
			if (player1.GetComponent<FollowThePath>().transform.position == waypoints[50].transform.position)
			{
				GameControl.count41++;
				GameControl.buyValue = 1;
				GameControl.own41 = 1;
			}
			if (player1.GetComponent<FollowThePath>().transform.position == waypoints[51].transform.position) {
				GameControl.count42++;
				GameControl.own42 = 1;
                if (GameControl.count42 == 1)
                    Level1Building51.gameObject.SetActive(true);
                else if (GameControl.count42 == 2)
                {
                    Level1Building51.gameObject.SetActive(false);
                    Level2Building51.gameObject.SetActive(true);
                }
                else if (GameControl.count42 == 3)
                {
                    Level2Building51.gameObject.SetActive(false);
                    Level3Building51.gameObject.SetActive(true);
                }
            }
			GameControl.count42++;
			if (player1.GetComponent<FollowThePath>().transform.position == waypoints[52].transform.position) {
				GameControl.count43++;
				GameControl.own43 = 1;
                if (GameControl.count43 == 1)
                    Level1Building52.gameObject.SetActive(true);
                else if (GameControl.count43 == 2)
                {
                    Level1Building52.gameObject.SetActive(false);
                    Level2Building52.gameObject.SetActive(true);
                }
                else if (GameControl.count43 == 3)
                {
                    Level2Building52.gameObject.SetActive(false);
                    Level3Building52.gameObject.SetActive(true);
                }
            }
			if (player1.GetComponent<FollowThePath>().transform.position == waypoints[55].transform.position) {
				GameControl.count44++;
				GameControl.own44 = 1;
                if (GameControl.count44 == 1)
                    Level1Building55.gameObject.SetActive(true);
                else if (GameControl.count44 == 2)
                {
                    Level1Building55.gameObject.SetActive(false);
                    Level2Building55.gameObject.SetActive(true);
                }
                else if (GameControl.count44 == 3)
                {
                    Level2Building55.gameObject.SetActive(false);
                    Level3Building55.gameObject.SetActive(true);
                }
            }
			if (player1.GetComponent<FollowThePath>().transform.position == waypoints[56].transform.position) {
				GameControl.count45++;
				GameControl.own45 = 1;
                if (GameControl.count45 == 1)
                    Level1Building56.gameObject.SetActive(true);
                else if (GameControl.count45 == 2)
                {
                    Level1Building56.gameObject.SetActive(false);
                    Level2Building56.gameObject.SetActive(true);
                }
                else if (GameControl.count45 == 3)
                {
                    Level2Building56.gameObject.SetActive(false);
                    Level3Building56.gameObject.SetActive(true);
                }
            }
			if (player1.GetComponent<FollowThePath>().transform.position == waypoints[57].transform.position) {
				GameControl.count46++;
				GameControl.own46 = 1;
                if (GameControl.count46 == 1)
                    Level1Building57.gameObject.SetActive(true);
                else if (GameControl.count46 == 2)
                {
                    Level1Building57.gameObject.SetActive(false);
                    Level2Building57.gameObject.SetActive(true);
                }
                else if (GameControl.count46 == 3)
                {
                    Level2Building57.gameObject.SetActive(false);
                    Level3Building57.gameObject.SetActive(true);
                }
            }
            GameControl.ImageForBuyHouse.gameObject.SetActive(false);
            camMain();
        }

        if (GameControl.whoTurn == 2)
        {
            if (sum2 - reduce < 0)
            {
                sum2 = 0;
                buy.interactable = false;
            }
            else
            {
                sum2 -= reduce;
            }
            player2Cost.text = sum2.ToString();
			if (player2.GetComponent<FollowThePath> ().transform.position == waypoints [1].transform.position) {
				GameControl.count1++;
				GameControl.own1 = 2;
                if (GameControl.count1 == 1)
                    Level1Building1.gameObject.SetActive(true);
                else if (GameControl.count1 == 2)
                {
                    Level1Building1.gameObject.SetActive(false);
                    Level2Building1.gameObject.SetActive(true);
                }
                else if (GameControl.count1 == 3)
                {
                    Level2Building1.gameObject.SetActive(false);
                    Level3Building1.gameObject.SetActive(true);
                }
            }
			if (player2.GetComponent<FollowThePath> ().transform.position == waypoints [2].transform.position) {
				GameControl.count2++;
				GameControl.own2 = 2;
                if (GameControl.count2 == 1)
                    Level1Building2.gameObject.SetActive(true);
                else if (GameControl.count2 == 2)
                {
                    Level1Building2.gameObject.SetActive(false);
                    Level2Building2.gameObject.SetActive(true);
                }
                else if (GameControl.count2 == 3)
                {
                    Level2Building2.gameObject.SetActive(false);
                    Level3Building2.gameObject.SetActive(true);
                }
            }   
			if (player2.GetComponent<FollowThePath> ().transform.position == waypoints [3].transform.position) {
				GameControl.count3++;
				GameControl.own3 = 2 ;
                if (GameControl.count3 == 1)
                    Level1Building3.gameObject.SetActive(true);
                else if (GameControl.count3 == 2)
                {
                    Level1Building3.gameObject.SetActive(false);
                    Level2Building3.gameObject.SetActive(true);
                }
                else if (GameControl.count3 == 3)
                {
                    Level2Building3.gameObject.SetActive(false);
                    Level3Building3.gameObject.SetActive(true);
                }

            }  
			if (player2.GetComponent<FollowThePath>().transform.position == waypoints[4].transform.position) {
				GameControl.count4++;
				GameControl.own4 = 2;
                if (GameControl.count4 == 1)
                    Level1Building4.gameObject.SetActive(true);
                else if (GameControl.count4 == 2)
                {
                    Level1Building4.gameObject.SetActive(false);
                    Level2Building4.gameObject.SetActive(true);
                }
                else if (GameControl.count4 == 3)
                {
                    Level2Building4.gameObject.SetActive(false);
                    Level3Building4.gameObject.SetActive(true);
                }
            }   
			if (player2.GetComponent<FollowThePath>().transform.position == waypoints[5].transform.position) {
				GameControl.count5++;
				GameControl.own5 = 2;
                if (GameControl.count5 == 1)
                    Level1Building5.gameObject.SetActive(true);
                else if (GameControl.count5 == 2)
                {
                    Level1Building5.gameObject.SetActive(false);
                    Level2Building5.gameObject.SetActive(true);
                }
                else if (GameControl.count5 == 3)
                {
                    Level2Building5.gameObject.SetActive(false);
                    Level3Building5.gameObject.SetActive(true);
                }
            }   
			if (player2.GetComponent<FollowThePath> ().transform.position == waypoints [7].transform.position) {
				GameControl.count6++;
				GameControl.own6 = 2;
                if (GameControl.count6 == 1)
                    Level1Building7.gameObject.SetActive(true);
                else if (GameControl.count6 == 2)
                {
                    Level1Building7.gameObject.SetActive(false);
                    Level2Building7.gameObject.SetActive(true);
                }
                else if (GameControl.count6 == 3)
                {
                    Level2Building7.gameObject.SetActive(false);
                    Level3Building7.gameObject.SetActive(true);
                }
            }
			if (player2.GetComponent<FollowThePath> ().transform.position == waypoints [8].transform.position) {
				GameControl.count7++;
				GameControl.own7 = 2;
                if (GameControl.count7 == 1)
                    Level1Building8.gameObject.SetActive(true);
                else if (GameControl.count7 == 2)
                {
                    Level1Building8.gameObject.SetActive(false);
                    Level2Building8.gameObject.SetActive(true);
                }
                else if (GameControl.count7 == 3)
                {
                    Level2Building8.gameObject.SetActive(false);
                    Level3Building8.gameObject.SetActive(true);
                }
            }
			if (player2.GetComponent<FollowThePath> ().transform.position == waypoints [9].transform.position) {
				GameControl.count8++;
				GameControl.own8 = 2;
                if (GameControl.count8 == 1)
                    Level1Building9.gameObject.SetActive(true);
                else if (GameControl.count8 == 2)
                {
                    Level1Building9.gameObject.SetActive(false);
                    Level2Building9.gameObject.SetActive(true);
                }
                else if (GameControl.count8 == 3)
                {
                    Level2Building9.gameObject.SetActive(false);
                    Level3Building9.gameObject.SetActive(true);
                }
            }
			if (player2.GetComponent<FollowThePath>().transform.position == waypoints[10].transform.position)
			{
				GameControl.count9++;
				GameControl.buyValue = 1;
				GameControl.own9 = 2;
			}        
			if (player2.GetComponent<FollowThePath>().transform.position == waypoints[11].transform.position) {
				GameControl.count10++;
				GameControl.own10 = 2;
                if (GameControl.count10 == 1)
                    Level1Building11.gameObject.SetActive(true);
                else if (GameControl.count10 == 2)
                {
                    Level1Building11.gameObject.SetActive(false);
                    Level2Building11.gameObject.SetActive(true);
                }
                else if (GameControl.count10 == 3)
                {
                    Level2Building11.gameObject.SetActive(false);
                    Level3Building11.gameObject.SetActive(true);
                }
            }  
			if (player2.GetComponent<FollowThePath>().transform.position == waypoints[13].transform.position) {
				GameControl.count11++;
				GameControl.own11 = 2;
                if (GameControl.count11 == 1)
                    Level1Building13.gameObject.SetActive(true);
                else if (GameControl.count11 == 2)
                {
                    Level1Building13.gameObject.SetActive(false);
                    Level2Building13.gameObject.SetActive(true);
                }
                else if (GameControl.count11 == 3)
                {
                    Level2Building13.gameObject.SetActive(false);
                    Level3Building13.gameObject.SetActive(true);
                }
            }
			if (player2.GetComponent<FollowThePath>().transform.position == waypoints[14].transform.position) {
				GameControl.count12++;
				GameControl.own12 = 2;
                if (GameControl.count12 == 1)
                    Level1Building14.gameObject.SetActive(true);
                else if (GameControl.count12 == 2)
                {
                    Level1Building14.gameObject.SetActive(false);
                    Level2Building14.gameObject.SetActive(true);
                }
                else if (GameControl.count12 == 3)
                {
                    Level2Building14.gameObject.SetActive(false);
                    Level3Building14.gameObject.SetActive(true);
                }
            }
			if (player2.GetComponent<FollowThePath>().transform.position == waypoints[15].transform.position) {
				GameControl.count13++;
				GameControl.own13 = 2;
                if (GameControl.count13 == 1)
                    Level1Building15.gameObject.SetActive(true);
                else if (GameControl.count13 == 2)
                {
                    Level1Building15.gameObject.SetActive(false);
                    Level2Building15.gameObject.SetActive(true);
                }
                else if (GameControl.count13 == 3)
                {
                    Level2Building15.gameObject.SetActive(false);
                    Level3Building15.gameObject.SetActive(true);
                }
            }
			if (player2.GetComponent<FollowThePath>().transform.position == waypoints[16].transform.position)  {
				GameControl.count14++;
				GameControl.own14 = 2;
                if (GameControl.count14 == 1)
                    Level1Building16.gameObject.SetActive(true);
                else if (GameControl.count14 == 2)
                {
                    Level1Building16.gameObject.SetActive(false);
                    Level2Building16.gameObject.SetActive(true);
                }
                else if (GameControl.count14 == 3)
                {
                    Level2Building16.gameObject.SetActive(false);
                    Level3Building16.gameObject.SetActive(true);
                }
            }
			if (player2.GetComponent<FollowThePath> ().transform.position == waypoints [17].transform.position) {
				GameControl.count15++;
				GameControl.own15 = 2;
                if (GameControl.count15 == 1)
                    Level1Building17.gameObject.SetActive(true);
                else if (GameControl.count15 == 2)
                {
                    Level1Building17.gameObject.SetActive(false);
                    Level2Building17.gameObject.SetActive(true);
                }
                else if (GameControl.count15 == 3)
                {
                    Level2Building17.gameObject.SetActive(false);
                    Level3Building17.gameObject.SetActive(true);
                }
            }  
			if (player2.GetComponent<FollowThePath> ().transform.position == waypoints [19].transform.position) {
				GameControl.count16++;
				GameControl.own16 = 2;
                if (GameControl.count16 == 1)
                    Level1Building19.gameObject.SetActive(true);
                else if (GameControl.count16 == 2)
                {
                    Level1Building19.gameObject.SetActive(false);
                    Level2Building19.gameObject.SetActive(true);
                }
                else if (GameControl.count16 == 3)
                {
                    Level2Building19.gameObject.SetActive(false);
                    Level3Building19.gameObject.SetActive(true);
                }
            }
			if (player2.GetComponent<FollowThePath>().transform.position == waypoints[20].transform.position) {
				GameControl.count17++;
				GameControl.own17 = 2;
                if (GameControl.count17 == 1)
                    Level1Building20.gameObject.SetActive(true);
                else if (GameControl.count17 == 2)
                {
                    Level1Building20.gameObject.SetActive(false);
                    Level2Building20.gameObject.SetActive(true);
                }
                else if (GameControl.count17 == 3)
                {
                    Level2Building20.gameObject.SetActive(false);
                    Level3Building20.gameObject.SetActive(true);
                }
            }
			if (player2.GetComponent<FollowThePath>().transform.position == waypoints[21].transform.position)
			{
				GameControl.count18++;
				GameControl.buyValue = 1;
				GameControl.own18 = 2;

			}
			if (player2.GetComponent<FollowThePath>().transform.position == waypoints[22].transform.position) {
				GameControl.count19++;
				GameControl.own19 = 2;
                if (GameControl.count19 == 1)
                    Level1Building22.gameObject.SetActive(true);
                else if (GameControl.count19 == 2)
                {
                    Level1Building22.gameObject.SetActive(false);
                    Level2Building22.gameObject.SetActive(true);
                }
                else if (GameControl.count19 == 3)
                {
                    Level2Building22.gameObject.SetActive(false);
                    Level3Building22.gameObject.SetActive(true);
                }
            }
			if (player2.GetComponent<FollowThePath>().transform.position == waypoints[23].transform.position) {
				GameControl.count20++;
				GameControl.own20 = 2;
                if (GameControl.count20 == 1)
                    Level1Building23.gameObject.SetActive(true);
                else if (GameControl.count20 == 2)
                {
                    Level1Building23.gameObject.SetActive(false);
                    Level2Building23.gameObject.SetActive(true);
                }
                else if (GameControl.count20 == 3)
                {
                    Level2Building23.gameObject.SetActive(false);
                    Level3Building23.gameObject.SetActive(true);
                }
            }
			if (player2.GetComponent<FollowThePath>().transform.position == waypoints[24].transform.position) {
				GameControl.count21++;
				GameControl.own21 = 2;
                if (GameControl.count21 == 1)
                    Level1Building24.gameObject.SetActive(true);
                else if (GameControl.count21 == 2)
                {
                    Level1Building24.gameObject.SetActive(false);
                    Level2Building24.gameObject.SetActive(true);
                }
                else if (GameControl.count21 == 3)
                {
                    Level2Building24.gameObject.SetActive(false);
                    Level3Building24.gameObject.SetActive(true);
                }
            }
			if (player2.GetComponent<FollowThePath>().transform.position == waypoints[26].transform.position) {
				GameControl.count22++;
				GameControl.own22 = 2;
                if (GameControl.count22 == 1)
                    Level1Building26.gameObject.SetActive(true);
                else if (GameControl.count22 == 2)
                {
                    Level1Building26.gameObject.SetActive(false);
                    Level2Building26.gameObject.SetActive(true);
                }
                else if (GameControl.count22 == 3)
                {
                    Level2Building26.gameObject.SetActive(false);
                    Level3Building26.gameObject.SetActive(true);
                }
            }
			if (player2.GetComponent<FollowThePath>().transform.position == waypoints[27].transform.position) {
				GameControl.count23++;
				GameControl.own23 = 2;
                if (GameControl.count23 == 1)
                    Level1Building27.gameObject.SetActive(true);
                else if (GameControl.count23 == 2)
                {
                    Level1Building27.gameObject.SetActive(false);
                    Level2Building27.gameObject.SetActive(true);
                }
                else if (GameControl.count23 == 3)
                {
                    Level2Building27.gameObject.SetActive(false);
                    Level3Building27.gameObject.SetActive(true);
                }
            }
			if (player2.GetComponent<FollowThePath>().transform.position == waypoints[28].transform.position) {
				GameControl.count24++;
				GameControl.own24 = 2;
                if (GameControl.count24 == 1)
                    Level1Building28.gameObject.SetActive(true);
                else if (GameControl.count24 == 2)
                {
                    Level1Building28.gameObject.SetActive(false);
                    Level2Building28.gameObject.SetActive(true);
                }
                else if (GameControl.count24 == 3)
                {
                    Level2Building28.gameObject.SetActive(false);
                    Level3Building28.gameObject.SetActive(true);
                }
            }
			if (player2.GetComponent<FollowThePath>().transform.position == waypoints[29].transform.position) {
				GameControl.count25++;
				GameControl.own25 = 2;
                if (GameControl.count25 == 1)
                    Level1Building29.gameObject.SetActive(true);
                else if (GameControl.count25 == 2)
                {
                    Level1Building29.gameObject.SetActive(false);
                    Level2Building29.gameObject.SetActive(true);
                }
                else if (GameControl.count25 == 3)
                {
                    Level2Building29.gameObject.SetActive(false);
                    Level3Building29.gameObject.SetActive(true);
                }
            }
			if (player2.GetComponent<FollowThePath>().transform.position == waypoints[31].transform.position) {
				GameControl.count26++;
				GameControl.own26 = 2;
                if (GameControl.count26 == 1)
                    Level1Building31.gameObject.SetActive(true);
                else if (GameControl.count26 == 2)
                {
                    Level1Building31.gameObject.SetActive(false);
                    Level2Building31.gameObject.SetActive(true);
                }
                else if (GameControl.count26 == 3)
                {
                    Level2Building31.gameObject.SetActive(false);
                    Level3Building31.gameObject.SetActive(true);
                }
            }
			if (player2.GetComponent<FollowThePath>().transform.position == waypoints[32].transform.position) {
				GameControl.count27++;
				GameControl.own27 = 2;
                if (GameControl.count27 == 1)
                    Level1Building32.gameObject.SetActive(true);
                else if (GameControl.count27 == 2)
                {
                    Level1Building32.gameObject.SetActive(false);
                    Level2Building32.gameObject.SetActive(true);
                }
                else if (GameControl.count27 == 3)
                {
                    Level2Building32.gameObject.SetActive(false);
                    Level3Building32.gameObject.SetActive(true);
                }
            }
			if (player2.GetComponent<FollowThePath>().transform.position == waypoints[33].transform.position) {
				GameControl.count28++;
				GameControl.own28 = 2;
                if (GameControl.count28 == 1)
                    Level1Building33.gameObject.SetActive(true);
                else if (GameControl.count28 == 2)
                {
                    Level1Building33.gameObject.SetActive(false);
                    Level2Building33.gameObject.SetActive(true);
                }
                else if (GameControl.count28 == 3)
                {
                    Level2Building33.gameObject.SetActive(false);
                    Level3Building33.gameObject.SetActive(true);
                }
            }
			if (player2.GetComponent<FollowThePath>().transform.position == waypoints[34].transform.position) {
				GameControl.count29++;
				GameControl.own29 = 2;
                if (GameControl.count29 == 1)
                    Level1Building34.gameObject.SetActive(true);
                else if (GameControl.count29 == 2)
                {
                    Level1Building34.gameObject.SetActive(false);
                    Level2Building34.gameObject.SetActive(true);
                }
                else if (GameControl.count29 == 3)
                {
                    Level2Building34.gameObject.SetActive(false);
                    Level3Building34.gameObject.SetActive(true);
                }
            }
			if (player2.GetComponent<FollowThePath>().transform.position == waypoints[36].transform.position) {
				GameControl.count30++;
				GameControl.own30 = 2;
                if (GameControl.count30 == 1)
                    Level1Building36.gameObject.SetActive(true);
                else if (GameControl.count30 == 2)
                {
                    Level1Building36.gameObject.SetActive(false);
                    Level2Building36.gameObject.SetActive(true);
                }
                else if (GameControl.count30 == 3)
                {
                    Level2Building36.gameObject.SetActive(false);
                    Level3Building36.gameObject.SetActive(true);
                }
            }
			if (player2.GetComponent<FollowThePath>().transform.position == waypoints[37].transform.position) {
				GameControl.count31++;
				GameControl.own31 = 2;
                if (GameControl.count31 == 1)
                    Level1Building37.gameObject.SetActive(true);
                else if (GameControl.count31 == 2)
                {
                    Level1Building37.gameObject.SetActive(false);
                    Level2Building37.gameObject.SetActive(true);
                }
                else if (GameControl.count31 == 3)
                {
                    Level2Building37.gameObject.SetActive(false);
                    Level3Building37.gameObject.SetActive(true);
                }
            }
			if (player2.GetComponent<FollowThePath>().transform.position == waypoints[38].transform.position)
			{
				GameControl.count32++;
				GameControl.buyValue = 1;
				GameControl.own32 = 2;
			}  
			if (player2.GetComponent<FollowThePath>().transform.position == waypoints[39].transform.position) {
				GameControl.count33++;
				GameControl.own33 = 2;
                if (GameControl.count33 == 1)
                    Level1Building39.gameObject.SetActive(true);
                else if (GameControl.count33 == 2)
                {
                    Level1Building39.gameObject.SetActive(false);
                    Level2Building39.gameObject.SetActive(true);
                }
                else if (GameControl.count33 == 3)
                {
                    Level2Building39.gameObject.SetActive(false);
                    Level3Building39.gameObject.SetActive(true);
                }
            }
			if (player2.GetComponent<FollowThePath>().transform.position == waypoints[40].transform.position) {
				GameControl.count34++;
				GameControl.own34 = 2;
                if (GameControl.count34 == 1)
                    Level1Building40.gameObject.SetActive(true);
                else if (GameControl.count34 == 2)
                {
                    Level1Building40.gameObject.SetActive(false);
                    Level2Building40.gameObject.SetActive(true);
                }
                else if (GameControl.count34 == 3)
                {
                    Level2Building40.gameObject.SetActive(false);
                    Level3Building40.gameObject.SetActive(true);
                }
            }
			if (player2.GetComponent<FollowThePath>().transform.position == waypoints[42].transform.position) {
				GameControl.count35++;
				GameControl.own35 = 2;
                if (GameControl.count35 == 1)
                    Level1Building42.gameObject.SetActive(true);
                else if (GameControl.count35 == 2)
                {
                    Level1Building42.gameObject.SetActive(false);
                    Level2Building42.gameObject.SetActive(true);
                }
                else if (GameControl.count35 == 3)
                {
                    Level2Building42.gameObject.SetActive(false);
                    Level3Building42.gameObject.SetActive(true);
                }
            }
			if (player2.GetComponent<FollowThePath>().transform.position == waypoints[43].transform.position) {
				GameControl.count36++;
				GameControl.own36 = 2;
                if (GameControl.count36 == 1)
                    Level1Building43.gameObject.SetActive(true);
                else if (GameControl.count36 == 2)
                {
                    Level1Building43.gameObject.SetActive(false);
                    Level2Building43.gameObject.SetActive(true);
                }
                else if (GameControl.count36 == 3)
                {
                    Level2Building43.gameObject.SetActive(false);
                    Level3Building43.gameObject.SetActive(true);
                }
            }
			if (player2.GetComponent<FollowThePath>().transform.position == waypoints[44].transform.position) {
				GameControl.count37++;
				GameControl.own37 = 2;
                if (GameControl.count37 == 1)
                    Level1Building44.gameObject.SetActive(true);
                else if (GameControl.count37 == 2)
                {
                    Level1Building44.gameObject.SetActive(false);
                    Level2Building44.gameObject.SetActive(true);
                }
                else if (GameControl.count37 == 3)
                {
                    Level2Building44.gameObject.SetActive(false);
                    Level3Building44.gameObject.SetActive(true);
                }
            }
			if (player2.GetComponent<FollowThePath>().transform.position == waypoints[47].transform.position) {
				GameControl.count38++;
				GameControl.own38 = 2;
                if (GameControl.count38 == 1)
                    Level1Building47.gameObject.SetActive(true);
                else if (GameControl.count38 == 2)
                {
                    Level1Building47.gameObject.SetActive(false);
                    Level2Building47.gameObject.SetActive(true);
                }
                else if (GameControl.count38 == 3)
                {
                    Level2Building47.gameObject.SetActive(false);
                    Level3Building47.gameObject.SetActive(true);
                }
            }
			if (player2.GetComponent<FollowThePath>().transform.position == waypoints[48].transform.position) {
				GameControl.count39++;
				GameControl.own39 = 2;
                if (GameControl.count39 == 1)
                    Level1Building48.gameObject.SetActive(true);
                else if (GameControl.count39 == 2)
                {
                    Level1Building48.gameObject.SetActive(false);
                    Level2Building48.gameObject.SetActive(true);
                }
                else if (GameControl.count39 == 3)
                {
                    Level2Building48.gameObject.SetActive(false);
                    Level3Building48.gameObject.SetActive(true);
                }
            }
			if (player2.GetComponent<FollowThePath>().transform.position == waypoints[49].transform.position) {
				GameControl.count40++;
				GameControl.own40 = 2;
                if (GameControl.count40 == 1)
                    Level1Building49.gameObject.SetActive(true);
                else if (GameControl.count40 == 2)
                {
                    Level1Building49.gameObject.SetActive(false);
                    Level2Building49.gameObject.SetActive(true);
                }
                else if (GameControl.count40 == 3)
                {
                    Level2Building49.gameObject.SetActive(false);
                    Level3Building49.gameObject.SetActive(true);
                }
            }
			if (player2.GetComponent<FollowThePath>().transform.position == waypoints[50].transform.position)
			{
				GameControl.count41++;
				GameControl.buyValue = 1;
				GameControl.own41 = 2;
			}
			if (player2.GetComponent<FollowThePath>().transform.position == waypoints[51].transform.position) {
				GameControl.count42++;
				GameControl.own42 = 2;
                if (GameControl.count42 == 1)
                    Level1Building51.gameObject.SetActive(true);
                else if (GameControl.count42 == 2)
                {
                    Level1Building51.gameObject.SetActive(false);
                    Level2Building51.gameObject.SetActive(true);
                }
                else if (GameControl.count42 == 3)
                {
                    Level2Building51.gameObject.SetActive(false);
                    Level3Building51.gameObject.SetActive(true);
                }
            }
			if (player2.GetComponent<FollowThePath>().transform.position == waypoints[52].transform.position) {
				GameControl.count43++;
				GameControl.own43 = 2;
                if (GameControl.count43 == 1)
                    Level1Building52.gameObject.SetActive(true);
                else if (GameControl.count43 == 2)
                {
                    Level1Building52.gameObject.SetActive(false);
                    Level2Building52.gameObject.SetActive(true);
                }
                else if (GameControl.count43 == 3)
                {
                    Level2Building52.gameObject.SetActive(false);
                    Level3Building52.gameObject.SetActive(true);
                }
            }
			if (player2.GetComponent<FollowThePath>().transform.position == waypoints[55].transform.position) {
				GameControl.count44++;
				GameControl.own44 = 2;
                if (GameControl.count44 == 1)
                    Level1Building55.gameObject.SetActive(true);
                else if (GameControl.count44 == 2)
                {
                    Level1Building55.gameObject.SetActive(false);
                    Level2Building55.gameObject.SetActive(true);
                }
                else if (GameControl.count44 == 3)
                {
                    Level2Building55.gameObject.SetActive(false);
                    Level3Building55.gameObject.SetActive(true);
                }
            }
			if (player2.GetComponent<FollowThePath>().transform.position == waypoints[56].transform.position) {
				GameControl.count45++;
				GameControl.own45 = 2;
                if (GameControl.count45 == 1)
                    Level1Building56.gameObject.SetActive(true);
                else if (GameControl.count45 == 2)
                {
                    Level1Building56.gameObject.SetActive(false);
                    Level2Building56.gameObject.SetActive(true);
                }
                else if (GameControl.count45 == 3)
                {
                    Level2Building56.gameObject.SetActive(false);
                    Level3Building56.gameObject.SetActive(true);
                }
            }
			if (player2.GetComponent<FollowThePath>().transform.position == waypoints[57].transform.position) {
				GameControl.count46++;
				GameControl.own46 = 2;
                if (GameControl.count46 == 1)
                    Level1Building57.gameObject.SetActive(true);
                else if (GameControl.count46 == 2)
                {
                    Level1Building57.gameObject.SetActive(false);
                    Level2Building57.gameObject.SetActive(true);
                }
                else if (GameControl.count46 == 3)
                {
                    Level2Building57.gameObject.SetActive(false);
                    Level3Building57.gameObject.SetActive(true);
                }

            }
            GameControl.ImageForBuyHouse.gameObject.SetActive(false);
            camMain();
        }

        if (GameControl.whoTurn == 3)
        {
            if (sum3 - reduce < 0)
            {
                sum3 = 0;
                buy.interactable = false;
            }
            else
            {
                sum3 -= reduce;
            }
            player3Cost.text = sum3.ToString();
			if (player3.GetComponent<FollowThePath> ().transform.position == waypoints [1].transform.position) {
				GameControl.count1++;
				GameControl.own1 = 3;
                if (GameControl.count1 == 1)
                    Level1Building1.gameObject.SetActive(true);
                else if (GameControl.count1 == 2)
                {
                    Level1Building1.gameObject.SetActive(false);
                    Level2Building1.gameObject.SetActive(true);
                }
                else if (GameControl.count1 == 3)
                {
                    Level2Building1.gameObject.SetActive(false);
                    Level3Building1.gameObject.SetActive(true);
                }
            }
			if (player3.GetComponent<FollowThePath> ().transform.position == waypoints [2].transform.position) {
				GameControl.count2++;
				GameControl.own2 = 3;
                if (GameControl.count2 == 1)
                    Level1Building2.gameObject.SetActive(true);
                else if (GameControl.count2 == 2)
                {
                    Level1Building2.gameObject.SetActive(false);
                    Level2Building2.gameObject.SetActive(true);
                }
                else if (GameControl.count2 == 3)
                {
                    Level2Building2.gameObject.SetActive(false);
                    Level3Building2.gameObject.SetActive(true);
                }
            }   
			if (player3.GetComponent<FollowThePath> ().transform.position == waypoints [3].transform.position) {
				GameControl.count3++;
				GameControl.own3 = 3 ;
                if (GameControl.count3 == 1)
                    Level1Building3.gameObject.SetActive(true);
                else if (GameControl.count3 == 2)
                {
                    Level1Building3.gameObject.SetActive(false);
                    Level2Building3.gameObject.SetActive(true);
                }
                else if (GameControl.count3 == 3)
                {
                    Level2Building3.gameObject.SetActive(false);
                    Level3Building3.gameObject.SetActive(true);
                }
            }  
			if (player3.GetComponent<FollowThePath>().transform.position == waypoints[4].transform.position) {
				GameControl.count4++;
				GameControl.own4 = 3;
                if (GameControl.count4 == 1)
                    Level1Building4.gameObject.SetActive(true);
                else if (GameControl.count4 == 2)
                {
                    Level1Building4.gameObject.SetActive(false);
                    Level2Building4.gameObject.SetActive(true);
                }
                else if (GameControl.count4 == 3)
                {
                    Level2Building4.gameObject.SetActive(false);
                    Level3Building4.gameObject.SetActive(true);
                }
            }   
			if (player3.GetComponent<FollowThePath>().transform.position == waypoints[5].transform.position) {
				GameControl.count5++;
				GameControl.own5 = 3;
                if (GameControl.count5 == 1)
                    Level1Building5.gameObject.SetActive(true);
                else if (GameControl.count5 == 2)
                {
                    Level1Building5.gameObject.SetActive(false);
                    Level2Building5.gameObject.SetActive(true);
                }
                else if (GameControl.count5 == 3)
                {
                    Level2Building5.gameObject.SetActive(false);
                    Level3Building5.gameObject.SetActive(true);
                }
            }   
			if (player3.GetComponent<FollowThePath> ().transform.position == waypoints [7].transform.position) {
				GameControl.count6++;
				GameControl.own6 = 3;
                if (GameControl.count6 == 1)
                    Level1Building7.gameObject.SetActive(true);
                else if (GameControl.count6 == 2)
                {
                    Level1Building7.gameObject.SetActive(false);
                    Level2Building7.gameObject.SetActive(true);
                }
                else if (GameControl.count6 == 3)
                {
                    Level2Building7.gameObject.SetActive(false);
                    Level3Building7.gameObject.SetActive(true);
                }
            }
			if (player3.GetComponent<FollowThePath> ().transform.position == waypoints [8].transform.position) {
				GameControl.count7++;
				GameControl.own7 = 3;
                if (GameControl.count7 == 1)
                    Level1Building8.gameObject.SetActive(true);
                else if (GameControl.count7 == 2)
                {
                    Level1Building8.gameObject.SetActive(false);
                    Level2Building8.gameObject.SetActive(true);
                }
                else if (GameControl.count7 == 3)
                {
                    Level2Building8.gameObject.SetActive(false);
                    Level3Building8.gameObject.SetActive(true);
                }
            }
			if (player3.GetComponent<FollowThePath> ().transform.position == waypoints [9].transform.position) {
				GameControl.count8++;
				GameControl.own8 = 3;
                if (GameControl.count8 == 1)
                    Level1Building9.gameObject.SetActive(true);
                else if (GameControl.count8 == 2)
                {
                    Level1Building9.gameObject.SetActive(false);
                    Level2Building9.gameObject.SetActive(true);
                }
                else if (GameControl.count8 == 3)
                {
                    Level2Building9.gameObject.SetActive(false);
                    Level3Building9.gameObject.SetActive(true);
                }
            }
			if (player3.GetComponent<FollowThePath>().transform.position == waypoints[10].transform.position)
			{
				GameControl.count9++;
				GameControl.buyValue = 1;
				GameControl.own9 = 3;
			}        
			if (player3.GetComponent<FollowThePath>().transform.position == waypoints[11].transform.position) {
				GameControl.count10++;
				GameControl.own10 = 3;
                if (GameControl.count10 == 1)
                    Level1Building11.gameObject.SetActive(true);
                else if (GameControl.count10 == 2)
                {
                    Level1Building11.gameObject.SetActive(false);
                    Level2Building11.gameObject.SetActive(true);
                }
                else if (GameControl.count10 == 3)
                {
                    Level2Building11.gameObject.SetActive(false);
                    Level3Building11.gameObject.SetActive(true);
                }
            }  
			if (player3.GetComponent<FollowThePath>().transform.position == waypoints[13].transform.position) {
				GameControl.count11++;
				GameControl.own11 = 3;
                if (GameControl.count11 == 1)
                    Level1Building13.gameObject.SetActive(true);
                else if (GameControl.count11 == 2)
                {
                    Level1Building13.gameObject.SetActive(false);
                    Level2Building13.gameObject.SetActive(true);
                }
                else if (GameControl.count11 == 3)
                {
                    Level2Building13.gameObject.SetActive(false);
                    Level3Building13.gameObject.SetActive(true);
                }
            }
			if (player3.GetComponent<FollowThePath>().transform.position == waypoints[14].transform.position) {
				GameControl.count12++;
				GameControl.own12 = 3;
                if (GameControl.count12 == 1)
                    Level1Building14.gameObject.SetActive(true);
                else if (GameControl.count12 == 2)
                {
                    Level1Building14.gameObject.SetActive(false);
                    Level2Building14.gameObject.SetActive(true);
                }
                else if (GameControl.count12 == 3)
                {
                    Level2Building14.gameObject.SetActive(false);
                    Level3Building14.gameObject.SetActive(true);
                }
            }
			if (player3.GetComponent<FollowThePath>().transform.position == waypoints[15].transform.position) {
				GameControl.count13++;
				GameControl.own13 = 3;
                if (GameControl.count13 == 1)
                    Level1Building15.gameObject.SetActive(true);
                else if (GameControl.count13 == 2)
                {
                    Level1Building15.gameObject.SetActive(false);
                    Level2Building15.gameObject.SetActive(true);
                }
                else if (GameControl.count13 == 3)
                {
                    Level2Building15.gameObject.SetActive(false);
                    Level3Building15.gameObject.SetActive(true);
                }
            }
			if (player3.GetComponent<FollowThePath>().transform.position == waypoints[16].transform.position)  {
				GameControl.count14++;
				GameControl.own14 = 3;
                if (GameControl.count14 == 1)
                    Level1Building16.gameObject.SetActive(true);
                else if (GameControl.count14 == 2)
                {
                    Level1Building16.gameObject.SetActive(false);
                    Level2Building16.gameObject.SetActive(true);
                }
                else if (GameControl.count14 == 3)
                {
                    Level2Building16.gameObject.SetActive(false);
                    Level3Building16.gameObject.SetActive(true);
                }
            }
			if (player3.GetComponent<FollowThePath> ().transform.position == waypoints [17].transform.position) {
				GameControl.count15++;
				GameControl.own15 = 3;
                if (GameControl.count15 == 1)
                    Level1Building17.gameObject.SetActive(true);
                else if (GameControl.count15 == 2)
                {
                    Level1Building17.gameObject.SetActive(false);
                    Level2Building17.gameObject.SetActive(true);
                }
                else if (GameControl.count15 == 3)
                {
                    Level2Building17.gameObject.SetActive(false);
                    Level3Building17.gameObject.SetActive(true);
                }
            }  
			if (player3.GetComponent<FollowThePath> ().transform.position == waypoints [19].transform.position) {
				GameControl.count16++;
				GameControl.own16 = 3;
                if (GameControl.count16 == 1)
                    Level1Building19.gameObject.SetActive(true);
                else if (GameControl.count16 == 2)
                {
                    Level1Building19.gameObject.SetActive(false);
                    Level2Building19.gameObject.SetActive(true);
                }
                else if (GameControl.count16 == 3)
                {
                    Level2Building19.gameObject.SetActive(false);
                    Level3Building19.gameObject.SetActive(true);
                }
            }
			if (player3.GetComponent<FollowThePath>().transform.position == waypoints[20].transform.position) {
				GameControl.count17++;
				GameControl.own17 = 3;
                if (GameControl.count17 == 1)
                    Level1Building20.gameObject.SetActive(true);
                else if (GameControl.count17 == 2)
                {
                    Level1Building20.gameObject.SetActive(false);
                    Level2Building20.gameObject.SetActive(true);
                }
                else if (GameControl.count17 == 3)
                {
                    Level2Building20.gameObject.SetActive(false);
                    Level3Building20.gameObject.SetActive(true);
                }
            }
			if (player3.GetComponent<FollowThePath>().transform.position == waypoints[21].transform.position)
			{
				GameControl.count18++;
				GameControl.buyValue = 1;
				GameControl.own18 = 3;
			}
			if (player3.GetComponent<FollowThePath>().transform.position == waypoints[22].transform.position) {
				GameControl.count19++;
				GameControl.own19 = 3;
                if (GameControl.count19 == 1)
                    Level1Building22.gameObject.SetActive(true);
                else if (GameControl.count19 == 2)
                {
                    Level1Building22.gameObject.SetActive(false);
                    Level2Building22.gameObject.SetActive(true);
                }
                else if (GameControl.count19 == 3)
                {
                    Level2Building22.gameObject.SetActive(false);
                    Level3Building22.gameObject.SetActive(true);
                }
            }
			if (player3.GetComponent<FollowThePath>().transform.position == waypoints[23].transform.position) {
				GameControl.count20++;
				GameControl.own20 = 3;
                if (GameControl.count20 == 1)
                    Level1Building23.gameObject.SetActive(true);
                else if (GameControl.count20 == 2)
                {
                    Level1Building23.gameObject.SetActive(false);
                    Level2Building23.gameObject.SetActive(true);
                }
                else if (GameControl.count20 == 3)
                {
                    Level2Building23.gameObject.SetActive(false);
                    Level3Building23.gameObject.SetActive(true);
                }
            }
			if (player3.GetComponent<FollowThePath>().transform.position == waypoints[24].transform.position) {
				GameControl.count21++;
				GameControl.own21 = 3;
                if (GameControl.count21 == 1)
                    Level1Building24.gameObject.SetActive(true);
                else if (GameControl.count21 == 2)
                {
                    Level1Building24.gameObject.SetActive(false);
                    Level2Building24.gameObject.SetActive(true);
                }
                else if (GameControl.count21 == 3)
                {
                    Level2Building24.gameObject.SetActive(false);
                    Level3Building24.gameObject.SetActive(true);
                }
            }
			if (player3.GetComponent<FollowThePath>().transform.position == waypoints[26].transform.position) {
				GameControl.count22++;
				GameControl.own22 = 3;
                if (GameControl.count22 == 1)
                    Level1Building26.gameObject.SetActive(true);
                else if (GameControl.count22 == 2)
                {
                    Level1Building26.gameObject.SetActive(false);
                    Level2Building26.gameObject.SetActive(true);
                }
                else if (GameControl.count22 == 3)
                {
                    Level2Building26.gameObject.SetActive(false);
                    Level3Building26.gameObject.SetActive(true);
                }
            }
			if (player3.GetComponent<FollowThePath>().transform.position == waypoints[27].transform.position) {
				GameControl.count23++;
				GameControl.own23 = 3;
                if (GameControl.count23 == 1)
                    Level1Building27.gameObject.SetActive(true);
                else if (GameControl.count23 == 2)
                {
                    Level1Building27.gameObject.SetActive(false);
                    Level2Building27.gameObject.SetActive(true);
                }
                else if (GameControl.count23 == 3)
                {
                    Level2Building27.gameObject.SetActive(false);
                    Level3Building27.gameObject.SetActive(true);
                }
            }
			if (player3.GetComponent<FollowThePath>().transform.position == waypoints[28].transform.position) {
				GameControl.count24++;
				GameControl.own24 = 3;
                if (GameControl.count24 == 1)
                    Level1Building28.gameObject.SetActive(true);
                else if (GameControl.count24 == 2)
                {
                    Level1Building28.gameObject.SetActive(false);
                    Level2Building28.gameObject.SetActive(true);
                }
                else if (GameControl.count24 == 3)
                {
                    Level2Building28.gameObject.SetActive(false);
                    Level3Building28.gameObject.SetActive(true);
                }
            }
			if (player3.GetComponent<FollowThePath>().transform.position == waypoints[29].transform.position) {
				GameControl.count25++;
				GameControl.own25 = 3;
                if (GameControl.count25 == 1)
                    Level1Building29.gameObject.SetActive(true);
                else if (GameControl.count25 == 2)
                {
                    Level1Building29.gameObject.SetActive(false);
                    Level2Building29.gameObject.SetActive(true);
                }
                else if (GameControl.count25 == 3)
                {
                    Level2Building29.gameObject.SetActive(false);
                    Level3Building29.gameObject.SetActive(true);
                }
            }
			if (player3.GetComponent<FollowThePath>().transform.position == waypoints[31].transform.position) {
				GameControl.count26++;
				GameControl.own26 = 3;
                if (GameControl.count26 == 1)
                    Level1Building31.gameObject.SetActive(true);
                else if (GameControl.count26 == 2)
                {
                    Level1Building31.gameObject.SetActive(false);
                    Level2Building31.gameObject.SetActive(true);
                }
                else if (GameControl.count26 == 3)
                {
                    Level2Building31.gameObject.SetActive(false);
                    Level3Building31.gameObject.SetActive(true);
                }
            }
			if (player3.GetComponent<FollowThePath>().transform.position == waypoints[32].transform.position) {
				GameControl.count27++;
				GameControl.own27 = 3;
                if (GameControl.count27 == 1)
                    Level1Building32.gameObject.SetActive(true);
                else if (GameControl.count27 == 2)
                {
                    Level1Building32.gameObject.SetActive(false);
                    Level2Building32.gameObject.SetActive(true);
                }
                else if (GameControl.count27 == 3)
                {
                    Level2Building32.gameObject.SetActive(false);
                    Level3Building32.gameObject.SetActive(true);
                }
            }
			if (player3.GetComponent<FollowThePath>().transform.position == waypoints[33].transform.position) {
				GameControl.count28++;
				GameControl.own28 = 3;
                if (GameControl.count28 == 1)
                    Level1Building33.gameObject.SetActive(true);
                else if (GameControl.count28 == 2)
                {
                    Level1Building33.gameObject.SetActive(false);
                    Level2Building33.gameObject.SetActive(true);
                }
                else if (GameControl.count28 == 3)
                {
                    Level2Building33.gameObject.SetActive(false);
                    Level3Building33.gameObject.SetActive(true);
                }
            }
			if (player3.GetComponent<FollowThePath>().transform.position == waypoints[34].transform.position) {
				GameControl.count29++;
				GameControl.own29 = 3;
                if (GameControl.count29 == 1)
                    Level1Building34.gameObject.SetActive(true);
                else if (GameControl.count29 == 2)
                {
                    Level1Building34.gameObject.SetActive(false);
                    Level2Building34.gameObject.SetActive(true);
                }
                else if (GameControl.count29 == 3)
                {
                    Level2Building34.gameObject.SetActive(false);
                    Level3Building34.gameObject.SetActive(true);
                }
            }
			if (player3.GetComponent<FollowThePath>().transform.position == waypoints[36].transform.position) {
				GameControl.count30++;
				GameControl.own30 = 3;
                if (GameControl.count30 == 1)
                    Level1Building36.gameObject.SetActive(true);
                else if (GameControl.count30 == 2)
                {
                    Level1Building36.gameObject.SetActive(false);
                    Level2Building36.gameObject.SetActive(true);
                }
                else if (GameControl.count30 == 3)
                {
                    Level2Building36.gameObject.SetActive(false);
                    Level3Building36.gameObject.SetActive(true);
                }
            }
			if (player3.GetComponent<FollowThePath>().transform.position == waypoints[37].transform.position) {
				GameControl.count31++;
				GameControl.own31 = 3;
                if (GameControl.count31 == 1)
                    Level1Building37.gameObject.SetActive(true);
                else if (GameControl.count31 == 2)
                {
                    Level1Building37.gameObject.SetActive(false);
                    Level2Building37.gameObject.SetActive(true);
                }
                else if (GameControl.count31 == 3)
                {
                    Level2Building37.gameObject.SetActive(false);
                    Level3Building37.gameObject.SetActive(true);
                }
            }
			if (player3.GetComponent<FollowThePath>().transform.position == waypoints[38].transform.position)
			{
				GameControl.count32++;
				GameControl.buyValue = 1;
				GameControl.own32 = 3;
            }  
			if (player3.GetComponent<FollowThePath>().transform.position == waypoints[39].transform.position) {
				GameControl.count33++;
				GameControl.own33 = 3;
                if (GameControl.count33 == 1)
                    Level1Building39.gameObject.SetActive(true);
                else if (GameControl.count33 == 2)
                {
                    Level1Building39.gameObject.SetActive(false);
                    Level2Building39.gameObject.SetActive(true);
                }
                else if (GameControl.count33 == 3)
                {
                    Level2Building39.gameObject.SetActive(false);
                    Level3Building39.gameObject.SetActive(true);
                }
            }
			if (player3.GetComponent<FollowThePath>().transform.position == waypoints[40].transform.position) {
				GameControl.count34++;
				GameControl.own34 = 3;
                if (GameControl.count34 == 1)
                    Level1Building40.gameObject.SetActive(true);
                else if (GameControl.count34 == 2)
                {
                    Level1Building40.gameObject.SetActive(false);
                    Level2Building40.gameObject.SetActive(true);
                }
                else if (GameControl.count34 == 3)
                {
                    Level2Building40.gameObject.SetActive(false);
                    Level3Building40.gameObject.SetActive(true);
                }

            }
			if (player3.GetComponent<FollowThePath>().transform.position == waypoints[42].transform.position) {
				GameControl.count35++;
				GameControl.own35 = 3;
                if (GameControl.count35 == 1)
                    Level1Building42.gameObject.SetActive(true);
                else if (GameControl.count35 == 2)
                {
                    Level1Building42.gameObject.SetActive(false);
                    Level2Building42.gameObject.SetActive(true);
                }
                else if (GameControl.count35 == 3)
                {
                    Level2Building42.gameObject.SetActive(false);
                    Level3Building42.gameObject.SetActive(true);
                }
            }
			if (player3.GetComponent<FollowThePath>().transform.position == waypoints[43].transform.position) {
				GameControl.count36++;
				GameControl.own36 = 3;
                if (GameControl.count36 == 1)
                    Level1Building43.gameObject.SetActive(true);
                else if (GameControl.count36 == 2)
                {
                    Level1Building43.gameObject.SetActive(false);
                    Level2Building43.gameObject.SetActive(true);
                }
                else if (GameControl.count36 == 3)
                {
                    Level2Building43.gameObject.SetActive(false);
                    Level3Building43.gameObject.SetActive(true);
                }
            }
			if (player3.GetComponent<FollowThePath>().transform.position == waypoints[44].transform.position) {
				GameControl.count37++;
				GameControl.own37 = 3;
                if (GameControl.count37 == 1)
                    Level1Building44.gameObject.SetActive(true);
                else if (GameControl.count37 == 2)
                {
                    Level1Building44.gameObject.SetActive(false);
                    Level2Building44.gameObject.SetActive(true);
                }
                else if (GameControl.count37 == 3)
                {
                    Level2Building44.gameObject.SetActive(false);
                    Level3Building44.gameObject.SetActive(true);
                }
            }
			if (player3.GetComponent<FollowThePath>().transform.position == waypoints[47].transform.position) {
				GameControl.count38++;
				GameControl.own38 = 3;
                if (GameControl.count38 == 1)
                    Level1Building47.gameObject.SetActive(true);
                else if (GameControl.count38 == 2)
                {
                    Level1Building47.gameObject.SetActive(false);
                    Level2Building47.gameObject.SetActive(true);
                }
                else if (GameControl.count38 == 3)
                {
                    Level2Building47.gameObject.SetActive(false);
                    Level3Building47.gameObject.SetActive(true);
                }
            }
			if (player3.GetComponent<FollowThePath>().transform.position == waypoints[48].transform.position) {
				GameControl.count39++;
				GameControl.own39 = 3;
                if (GameControl.count39 == 1)
                    Level1Building48.gameObject.SetActive(true);
                else if (GameControl.count39 == 2)
                {
                    Level1Building48.gameObject.SetActive(false);
                    Level2Building48.gameObject.SetActive(true);
                }
                else if (GameControl.count39 == 3)
                {
                    Level2Building48.gameObject.SetActive(false);
                    Level3Building48.gameObject.SetActive(true);
                }
            }
			if (player3.GetComponent<FollowThePath>().transform.position == waypoints[49].transform.position) {
				GameControl.count40++;
				GameControl.own40 = 3;
                if (GameControl.count40 == 1)
                    Level1Building49.gameObject.SetActive(true);
                else if (GameControl.count40 == 2)
                {
                    Level1Building49.gameObject.SetActive(false);
                    Level2Building49.gameObject.SetActive(true);
                }
                else if (GameControl.count40 == 3)
                {
                    Level2Building49.gameObject.SetActive(false);
                    Level3Building49.gameObject.SetActive(true);
                }
            }
			if (player3.GetComponent<FollowThePath>().transform.position == waypoints[50].transform.position)
			{
				GameControl.count41++;
				GameControl.buyValue = 1;
				GameControl.own41 = 3;
			}
			if (player3.GetComponent<FollowThePath>().transform.position == waypoints[51].transform.position) {
				GameControl.count42++;
				GameControl.own42 = 3;
                if (GameControl.count42 == 1)
                    Level1Building51.gameObject.SetActive(true);
                else if (GameControl.count42 == 2)
                {
                    Level1Building51.gameObject.SetActive(false);
                    Level2Building51.gameObject.SetActive(true);
                }
                else if (GameControl.count42 == 3)
                {
                    Level2Building51.gameObject.SetActive(false);
                    Level3Building51.gameObject.SetActive(true);
                }

            }
            if (player3.GetComponent<FollowThePath>().transform.position == waypoints[52].transform.position) {
				GameControl.count43++;
				GameControl.own43 = 3;
                if (GameControl.count43 == 1)
                    Level1Building52.gameObject.SetActive(true);
                else if (GameControl.count43 == 2)
                {
                    Level1Building52.gameObject.SetActive(false);
                    Level2Building52.gameObject.SetActive(true);
                }
                else if (GameControl.count43 == 3)
                {
                    Level2Building52.gameObject.SetActive(false);
                    Level3Building52.gameObject.SetActive(true);
                }
            }
			if (player3.GetComponent<FollowThePath>().transform.position == waypoints[55].transform.position) {
				GameControl.count44++;
				GameControl.own44 = 3;
                if (GameControl.count44 == 1)
                    Level1Building55.gameObject.SetActive(true);
                else if (GameControl.count44 == 2)
                {
                    Level1Building55.gameObject.SetActive(false);
                    Level2Building55.gameObject.SetActive(true);
                }
                else if (GameControl.count44 == 3)
                {
                    Level2Building55.gameObject.SetActive(false);
                    Level3Building55.gameObject.SetActive(true);
                }
            }
			if (player3.GetComponent<FollowThePath>().transform.position == waypoints[56].transform.position) {
				GameControl.count45++;
				GameControl.own46 = 3;
                if (GameControl.count45 == 1)
                    Level1Building56.gameObject.SetActive(true);
                else if (GameControl.count45 == 2)
                {
                    Level1Building56.gameObject.SetActive(false);
                    Level2Building56.gameObject.SetActive(true);
                }
                else if (GameControl.count45 == 3)
                {
                    Level2Building56.gameObject.SetActive(false);
                    Level3Building56.gameObject.SetActive(true);
                }
            }
			if (player3.GetComponent<FollowThePath>().transform.position == waypoints[57].transform.position) {
				GameControl.count46++;
				GameControl.own46 = 3;
                if (GameControl.count46 == 1)
                    Level1Building57.gameObject.SetActive(true);
                else if (GameControl.count46 == 2)
                {
                    Level1Building57.gameObject.SetActive(false);
                    Level2Building57.gameObject.SetActive(true);
                }
                else if (GameControl.count46 == 3)
                {
                    Level2Building57.gameObject.SetActive(false);
                    Level3Building57.gameObject.SetActive(true);
                }
            }
			GameControl.ImageForBuyHouse.gameObject.SetActive(false);
			camMain();
        }

        if (GameControl.whoTurn == 4)
        {
            if (sum4 - reduce < 0)
            {
                sum4 = 0;
                buy.interactable = false;
            }
            else
            {
                sum4 -= reduce;
            }
            player4Cost.text = sum4.ToString();
			if (player4.GetComponent<FollowThePath> ().transform.position == waypoints [1].transform.position) {
				GameControl.count1++;
				GameControl.own1 = 4;
                if (GameControl.count1 == 1)
                    Level1Building1.gameObject.SetActive(true);
                else if (GameControl.count1 == 2)
                {
                    Level1Building1.gameObject.SetActive(false);
                    Level2Building1.gameObject.SetActive(true);
                }
                else if (GameControl.count1 == 3)
                {
                    Level2Building1.gameObject.SetActive(false);
                    Level3Building1.gameObject.SetActive(true);
                }

            }
            if (player4.GetComponent<FollowThePath> ().transform.position == waypoints [2].transform.position) {
				GameControl.count2++;
				GameControl.own2 = 4;
                if (GameControl.count2 == 1)
                    Level1Building2.gameObject.SetActive(true);
                else if (GameControl.count2 == 2)
                {
                    Level1Building2.gameObject.SetActive(false);
                    Level2Building2.gameObject.SetActive(true);
                }
                else if (GameControl.count2 == 3)
                {
                    Level2Building2.gameObject.SetActive(false);
                    Level3Building2.gameObject.SetActive(true);
                }
            }   
			if (player4.GetComponent<FollowThePath> ().transform.position == waypoints [3].transform.position) {
				GameControl.count3++;
				GameControl.own3 = 4 ;
                if (GameControl.count3 == 1)
                    Level1Building3.gameObject.SetActive(true);
                else if (GameControl.count3 == 2)
                {
                    Level1Building3.gameObject.SetActive(false);
                    Level2Building3.gameObject.SetActive(true);
                }
                else if (GameControl.count3 == 3)
                {
                    Level2Building3.gameObject.SetActive(false);
                    Level3Building3.gameObject.SetActive(true);
                }
            }  
			if (player4.GetComponent<FollowThePath>().transform.position == waypoints[4].transform.position) {
				GameControl.count4++;
				GameControl.own4 = 4;
                if (GameControl.count4 == 1)
                    Level1Building4.gameObject.SetActive(true);
                else if (GameControl.count4 == 2)
                {
                    Level1Building4.gameObject.SetActive(false);
                    Level2Building4.gameObject.SetActive(true);
                }
                else if (GameControl.count4 == 3)
                {
                    Level2Building4.gameObject.SetActive(false);
                    Level3Building4.gameObject.SetActive(true);
                }
            }   
			if (player4.GetComponent<FollowThePath>().transform.position == waypoints[5].transform.position) {
				GameControl.count5++;
				GameControl.own5 = 4;
                if (GameControl.count5 == 1)
                    Level1Building5.gameObject.SetActive(true);
                else if (GameControl.count5 == 2)
                {
                    Level1Building5.gameObject.SetActive(false);
                    Level2Building5.gameObject.SetActive(true);
                }
                else if (GameControl.count5 == 3)
                {
                    Level2Building5.gameObject.SetActive(false);
                    Level3Building5.gameObject.SetActive(true);
                }
            }   
			if (player4.GetComponent<FollowThePath> ().transform.position == waypoints [7].transform.position) {
				GameControl.count6++;
				GameControl.own6 = 4;
                if (GameControl.count6 == 1)
                    Level1Building7.gameObject.SetActive(true);
                else if (GameControl.count6 == 2)
                {
                    Level1Building7.gameObject.SetActive(false);
                    Level2Building7.gameObject.SetActive(true);
                }
                else if (GameControl.count6 == 3)
                {
                    Level2Building7.gameObject.SetActive(false);
                    Level3Building7.gameObject.SetActive(true);
                }
            }
			if (player4.GetComponent<FollowThePath> ().transform.position == waypoints [8].transform.position) {
				GameControl.count7++;
				GameControl.own7 = 4;
                if (GameControl.count7 == 1)
                    Level1Building8.gameObject.SetActive(true);
                else if (GameControl.count7 == 2)
                {
                    Level1Building8.gameObject.SetActive(false);
                    Level2Building8.gameObject.SetActive(true);
                }
                else if (GameControl.count7 == 3)
                {
                    Level2Building8.gameObject.SetActive(false);
                    Level3Building8.gameObject.SetActive(true);
                }
            }
			if (player4.GetComponent<FollowThePath> ().transform.position == waypoints [9].transform.position) {
				GameControl.count8++;
				GameControl.own8 = 4;
                if (GameControl.count8 == 1)
                    Level1Building9.gameObject.SetActive(true);
                else if (GameControl.count8 == 2)
                {
                    Level1Building9.gameObject.SetActive(false);
                    Level2Building9.gameObject.SetActive(true);
                }
                else if (GameControl.count8 == 3)
                {
                    Level2Building9.gameObject.SetActive(false);
                    Level3Building9.gameObject.SetActive(true);
                }
            }
            if (player4.GetComponent<FollowThePath>().transform.position == waypoints[10].transform.position)
            {
                GameControl.count9++;
                GameControl.buyValue = 1;
				GameControl.own9 = 4;
            }        
			if (player4.GetComponent<FollowThePath>().transform.position == waypoints[11].transform.position) {
				GameControl.count10++;
				GameControl.own10 = 4;
                if (GameControl.count10 == 1)
                    Level1Building11.gameObject.SetActive(true);
                else if (GameControl.count10 == 2)
                {
                    Level1Building11.gameObject.SetActive(false);
                    Level2Building11.gameObject.SetActive(true);
                }
                else if (GameControl.count10 == 3)
                {
                    Level2Building11.gameObject.SetActive(false);
                    Level3Building11.gameObject.SetActive(true);
                }
            }  
			if (player4.GetComponent<FollowThePath>().transform.position == waypoints[13].transform.position) {
				GameControl.count11++;
				GameControl.own11 = 4;
                if (GameControl.count11 == 1)
                    Level1Building13.gameObject.SetActive(true);
                else if (GameControl.count11 == 2)
                {
                    Level1Building13.gameObject.SetActive(false);
                    Level2Building13.gameObject.SetActive(true);
                }
                else if (GameControl.count11 == 3)
                {
                    Level2Building13.gameObject.SetActive(false);
                    Level3Building13.gameObject.SetActive(true);
                }
            }
			if (player4.GetComponent<FollowThePath>().transform.position == waypoints[14].transform.position) {
				GameControl.count12++;
				GameControl.own12 = 4;
                if (GameControl.count12 == 1)
                    Level1Building14.gameObject.SetActive(true);
                else if (GameControl.count12 == 2)
                {
                    Level1Building14.gameObject.SetActive(false);
                    Level2Building14.gameObject.SetActive(true);
                }
                else if (GameControl.count12 == 3)
                {
                    Level2Building14.gameObject.SetActive(false);
                    Level3Building14.gameObject.SetActive(true);
                }
            }
			if (player4.GetComponent<FollowThePath>().transform.position == waypoints[15].transform.position) {
				GameControl.count13++;
				GameControl.own13 = 4;
                if (GameControl.count13 == 1)
                    Level1Building15.gameObject.SetActive(true);
                else if (GameControl.count13 == 2)
                {
                    Level1Building15.gameObject.SetActive(false);
                    Level2Building15.gameObject.SetActive(true);
                }
                else if (GameControl.count13 == 3)
                {
                    Level2Building15.gameObject.SetActive(false);
                    Level3Building15.gameObject.SetActive(true);
                }
            }
			if (player4.GetComponent<FollowThePath>().transform.position == waypoints[16].transform.position)  {
				GameControl.count14++;
				GameControl.own14 = 4;
                if (GameControl.count14 == 1)
                    Level1Building16.gameObject.SetActive(true);
                else if (GameControl.count14 == 2)
                {
                    Level1Building16.gameObject.SetActive(false);
                    Level2Building16.gameObject.SetActive(true);
                }
                else if (GameControl.count14 == 3)
                {
                    Level2Building16.gameObject.SetActive(false);
                    Level3Building16.gameObject.SetActive(true);
                }
            }
			if (player4.GetComponent<FollowThePath> ().transform.position == waypoints [17].transform.position) {
				GameControl.count15++;
				GameControl.own15 = 4;
                if (GameControl.count15 == 1)
                    Level1Building17.gameObject.SetActive(true);
                else if (GameControl.count15 == 2)
                {
                    Level1Building17.gameObject.SetActive(false);
                    Level2Building17.gameObject.SetActive(true);
                }
                else if (GameControl.count15 == 3)
                {
                    Level2Building17.gameObject.SetActive(false);
                    Level3Building17.gameObject.SetActive(true);
                }
            }  
			if (player4.GetComponent<FollowThePath> ().transform.position == waypoints [19].transform.position) {
				GameControl.count16++;
				GameControl.own16 = 4;
                if (GameControl.count16 == 1)
                    Level1Building19.gameObject.SetActive(true);
                else if (GameControl.count16 == 2)
                {
                    Level1Building19.gameObject.SetActive(false);
                    Level2Building19.gameObject.SetActive(true);
                }
                else if (GameControl.count16 == 3)
                {
                    Level2Building19.gameObject.SetActive(false);
                    Level3Building19.gameObject.SetActive(true);
                }
            }
			if (player4.GetComponent<FollowThePath>().transform.position == waypoints[20].transform.position) {
				GameControl.count17++;
				GameControl.own17 = 4;
                if (GameControl.count17 == 1)
                    Level1Building20.gameObject.SetActive(true);
                else if (GameControl.count17 == 2)
                {
                    Level1Building20.gameObject.SetActive(false);
                    Level2Building20.gameObject.SetActive(true);
                }
                else if (GameControl.count17 == 3)
                {
                    Level2Building20.gameObject.SetActive(false);
                    Level3Building20.gameObject.SetActive(true);
                }
            }
            if (player4.GetComponent<FollowThePath>().transform.position == waypoints[21].transform.position)
            {
                GameControl.count18++;
                GameControl.buyValue = 1;
				GameControl.own18 = 4;
            }
			if (player4.GetComponent<FollowThePath>().transform.position == waypoints[22].transform.position) {
				GameControl.count19++;
				GameControl.own19 = 4;
                if (GameControl.count19 == 1)
                    Level1Building22.gameObject.SetActive(true);
                else if (GameControl.count19 == 2)
                {
                    Level1Building22.gameObject.SetActive(false);
                    Level2Building22.gameObject.SetActive(true);
                }
                else if (GameControl.count19 == 3)
                {
                    Level2Building22.gameObject.SetActive(false);
                    Level3Building22.gameObject.SetActive(true);
                }
            }
			if (player4.GetComponent<FollowThePath>().transform.position == waypoints[23].transform.position) {
				GameControl.count20++;
				GameControl.own20 = 4;
                if (GameControl.count20 == 1)
                    Level1Building23.gameObject.SetActive(true);
                else if (GameControl.count20 == 2)
                {
                    Level1Building23.gameObject.SetActive(false);
                    Level2Building23.gameObject.SetActive(true);
                }
                else if (GameControl.count20 == 3)
                {
                    Level2Building23.gameObject.SetActive(false);
                    Level3Building23.gameObject.SetActive(true);
                }
            }
			if (player4.GetComponent<FollowThePath>().transform.position == waypoints[24].transform.position) {
				GameControl.count21++;
				GameControl.own21 = 4;
                if (GameControl.count21 == 1)
                    Level1Building24.gameObject.SetActive(true);
                else if (GameControl.count21 == 2)
                {
                    Level1Building24.gameObject.SetActive(false);
                    Level2Building24.gameObject.SetActive(true);
                }
                else if (GameControl.count21 == 3)
                {
                    Level2Building24.gameObject.SetActive(false);
                    Level3Building24.gameObject.SetActive(true);
                }
            }
			if (player4.GetComponent<FollowThePath>().transform.position == waypoints[26].transform.position) {
				GameControl.count22++;
				GameControl.own22 = 4;
                if (GameControl.count22 == 1)
                    Level1Building26.gameObject.SetActive(true);
                else if (GameControl.count22 == 2)
                {
                    Level1Building26.gameObject.SetActive(false);
                    Level2Building26.gameObject.SetActive(true);
                }
                else if (GameControl.count22 == 3)
                {
                    Level2Building26.gameObject.SetActive(false);
                    Level3Building26.gameObject.SetActive(true);
                }
            }
			if (player4.GetComponent<FollowThePath>().transform.position == waypoints[27].transform.position) {
				GameControl.count23++;
				GameControl.own23 = 4;
                if (GameControl.count23 == 1)
                    Level1Building27.gameObject.SetActive(true);
                else if (GameControl.count23 == 2)
                {
                    Level1Building27.gameObject.SetActive(false);
                    Level2Building27.gameObject.SetActive(true);
                }
                else if (GameControl.count23 == 3)
                {
                    Level2Building27.gameObject.SetActive(false);
                    Level3Building27.gameObject.SetActive(true);
                }
            }
			if (player4.GetComponent<FollowThePath>().transform.position == waypoints[28].transform.position) {
				GameControl.count24++;
				GameControl.own24 = 4;
                if (GameControl.count24 == 1)
                    Level1Building28.gameObject.SetActive(true);
                else if (GameControl.count24 == 2)
                {
                    Level1Building28.gameObject.SetActive(false);
                    Level2Building28.gameObject.SetActive(true);
                }
                else if (GameControl.count24 == 3)
                {
                    Level2Building28.gameObject.SetActive(false);
                    Level3Building28.gameObject.SetActive(true);
                }
            }
			if (player4.GetComponent<FollowThePath>().transform.position == waypoints[29].transform.position) {
				GameControl.count25++;
				GameControl.own25 = 4;
                if (GameControl.count25 == 1)
                    Level1Building29.gameObject.SetActive(true);
                else if (GameControl.count25 == 2)
                {
                    Level1Building29.gameObject.SetActive(false);
                    Level2Building29.gameObject.SetActive(true);
                }
                else if (GameControl.count25 == 3)
                {
                    Level2Building29.gameObject.SetActive(false);
                    Level3Building29.gameObject.SetActive(true);
                }
            }
			if (player4.GetComponent<FollowThePath>().transform.position == waypoints[31].transform.position) {
				GameControl.count26++;
				GameControl.own26 = 4;
                if (GameControl.count26 == 1)
                    Level1Building31.gameObject.SetActive(true);
                else if (GameControl.count26 == 2)
                {
                    Level1Building31.gameObject.SetActive(false);
                    Level2Building31.gameObject.SetActive(true);
                }
                else if (GameControl.count26 == 3)
                {
                    Level2Building31.gameObject.SetActive(false);
                    Level3Building31.gameObject.SetActive(true);
                }
            }
			if (player4.GetComponent<FollowThePath>().transform.position == waypoints[32].transform.position) {
				GameControl.count27++;
				GameControl.own27 = 4;
                if (GameControl.count27 == 1)
                    Level1Building32.gameObject.SetActive(true);
                else if (GameControl.count27 == 2)
                {
                    Level1Building32.gameObject.SetActive(false);
                    Level2Building32.gameObject.SetActive(true);
                }
                else if (GameControl.count27 == 3)
                {
                    Level2Building32.gameObject.SetActive(false);
                    Level3Building32.gameObject.SetActive(true);
                }
            }
			if (player4.GetComponent<FollowThePath>().transform.position == waypoints[33].transform.position) {
				GameControl.count28++;
				GameControl.own28 = 4;
                if (GameControl.count28 == 1)
                    Level1Building33.gameObject.SetActive(true);
                else if (GameControl.count28 == 2)
                {
                    Level1Building33.gameObject.SetActive(false);
                    Level2Building33.gameObject.SetActive(true);
                }
                else if (GameControl.count28 == 3)
                {
                    Level2Building33.gameObject.SetActive(false);
                    Level3Building33.gameObject.SetActive(true);
                }
            }
			if (player4.GetComponent<FollowThePath>().transform.position == waypoints[34].transform.position) {
				GameControl.count29++;
				GameControl.own29 = 4;
                if (GameControl.count29 == 1)
                    Level1Building34.gameObject.SetActive(true);
                else if (GameControl.count29 == 2)
                {
                    Level1Building34.gameObject.SetActive(false);
                    Level2Building34.gameObject.SetActive(true);
                }
                else if (GameControl.count29 == 3)
                {
                    Level2Building34.gameObject.SetActive(false);
                    Level3Building34.gameObject.SetActive(true);
                }
            }
			if (player4.GetComponent<FollowThePath>().transform.position == waypoints[36].transform.position) {
				GameControl.count30++;
				GameControl.own30 = 4;
                if (GameControl.count30 == 1)
                    Level1Building36.gameObject.SetActive(true);
                else if (GameControl.count30 == 2)
                {
                    Level1Building36.gameObject.SetActive(false);
                    Level2Building36.gameObject.SetActive(true);
                }
                else if (GameControl.count30 == 3)
                {
                    Level2Building36.gameObject.SetActive(false);
                    Level3Building36.gameObject.SetActive(true);
                }
            }
			if (player4.GetComponent<FollowThePath>().transform.position == waypoints[37].transform.position) {
				GameControl.count31++;
				GameControl.own31 = 4;
                if (GameControl.count31 == 1)
                    Level1Building37.gameObject.SetActive(true);
                else if (GameControl.count31 == 2)
                {
                    Level1Building37.gameObject.SetActive(false);
                    Level2Building37.gameObject.SetActive(true);
                }
                else if (GameControl.count31 == 3)
                {
                    Level2Building37.gameObject.SetActive(false);
                    Level3Building37.gameObject.SetActive(true);
                }
            }
            if (player4.GetComponent<FollowThePath>().transform.position == waypoints[38].transform.position)
            {
                GameControl.count32++;
                GameControl.buyValue = 1;
				GameControl.own32 = 4;
            }  
			if (player4.GetComponent<FollowThePath>().transform.position == waypoints[39].transform.position) {
				GameControl.count33++;
				GameControl.own33 = 4;
                if (GameControl.count33 == 1)
                    Level1Building39.gameObject.SetActive(true);
                else if (GameControl.count33 == 2)
                {
                    Level1Building39.gameObject.SetActive(false);
                    Level2Building39.gameObject.SetActive(true);
                }
                else if (GameControl.count33 == 3)
                {
                    Level2Building39.gameObject.SetActive(false);
                    Level3Building39.gameObject.SetActive(true);
                }
            }
			if (player4.GetComponent<FollowThePath>().transform.position == waypoints[40].transform.position) {
				GameControl.count34++;
				GameControl.own34 = 4;
                if (GameControl.count34 == 1)
                    Level1Building40.gameObject.SetActive(true);
                else if (GameControl.count34 == 2)
                {
                    Level1Building40.gameObject.SetActive(false);
                    Level2Building40.gameObject.SetActive(true);
                }
                else if (GameControl.count34 == 3)
                {
                    Level2Building40.gameObject.SetActive(false);
                    Level3Building40.gameObject.SetActive(true);
                }
            }
			if (player4.GetComponent<FollowThePath>().transform.position == waypoints[42].transform.position) {
				GameControl.count35++;
				GameControl.own35 = 4;
                if (GameControl.count35 == 1)
                    Level1Building42.gameObject.SetActive(true);
                else if (GameControl.count35 == 2)
                {
                    Level1Building42.gameObject.SetActive(false);
                    Level2Building42.gameObject.SetActive(true);
                }
                else if (GameControl.count35 == 3)
                {
                    Level2Building42.gameObject.SetActive(false);
                    Level3Building42.gameObject.SetActive(true);
                }
            }
			if (player4.GetComponent<FollowThePath>().transform.position == waypoints[43].transform.position) {
				GameControl.count36++;
				GameControl.own36 = 4;
                if (GameControl.count36 == 1)
                    Level1Building43.gameObject.SetActive(true);
                else if (GameControl.count36 == 2)
                {
                    Level1Building43.gameObject.SetActive(false);
                    Level2Building43.gameObject.SetActive(true);
                }
                else if (GameControl.count36 == 3)
                {
                    Level2Building43.gameObject.SetActive(false);
                    Level3Building43.gameObject.SetActive(true);
                }
            }
			if (player4.GetComponent<FollowThePath>().transform.position == waypoints[44].transform.position) {
				GameControl.count37++;
				GameControl.own37 = 4;
                if (GameControl.count37 == 1)
                    Level1Building44.gameObject.SetActive(true);
                else if (GameControl.count37 == 2)
                {
                    Level1Building44.gameObject.SetActive(false);
                    Level2Building44.gameObject.SetActive(true);
                }
                else if (GameControl.count37 == 3)
                {
                    Level2Building44.gameObject.SetActive(false);
                    Level3Building44.gameObject.SetActive(true);
                }
            }
			if (player4.GetComponent<FollowThePath>().transform.position == waypoints[47].transform.position) {
				GameControl.count38++;
				GameControl.own38 = 4;
                if (GameControl.count38 == 1)
                    Level1Building47.gameObject.SetActive(true);
                else if (GameControl.count38 == 2)
                {
                    Level1Building47.gameObject.SetActive(false);
                    Level2Building47.gameObject.SetActive(true);
                }
                else if (GameControl.count38 == 3)
                {
                    Level2Building47.gameObject.SetActive(false);
                    Level3Building47.gameObject.SetActive(true);
                }
            }
			if (player4.GetComponent<FollowThePath>().transform.position == waypoints[48].transform.position) {
				GameControl.count39++;
				GameControl.own39 = 4;
                if (GameControl.count39 == 1)
                    Level1Building48.gameObject.SetActive(true);
                else if (GameControl.count39 == 2)
                {
                    Level1Building48.gameObject.SetActive(false);
                    Level2Building48.gameObject.SetActive(true);
                }
                else if (GameControl.count39 == 3)
                {
                    Level2Building48.gameObject.SetActive(false);
                    Level3Building48.gameObject.SetActive(true);
                }
            }
			if (player4.GetComponent<FollowThePath>().transform.position == waypoints[49].transform.position) {
				GameControl.count40++;
				GameControl.own40 = 4;
                if (GameControl.count40 == 1)
                    Level1Building49.gameObject.SetActive(true);
                else if (GameControl.count40 == 2)
                {
                    Level1Building49.gameObject.SetActive(false);
                    Level2Building49.gameObject.SetActive(true);
                }
                else if (GameControl.count40 == 3)
                {
                    Level2Building49.gameObject.SetActive(false);
                    Level3Building49.gameObject.SetActive(true);
                }
            }
            if (player4.GetComponent<FollowThePath>().transform.position == waypoints[50].transform.position)
            {
                GameControl.count41++;
                GameControl.buyValue = 1;
				GameControl.own41 = 4;
            }
			if (player4.GetComponent<FollowThePath>().transform.position == waypoints[51].transform.position) {
				GameControl.count42++;
				GameControl.own42 = 4;
                if (GameControl.count42 == 1)
                    Level1Building51.gameObject.SetActive(true);
                else if (GameControl.count42 == 2)
                {
                    Level1Building51.gameObject.SetActive(false);
                    Level2Building51.gameObject.SetActive(true);
                }
                else if (GameControl.count42 == 3)
                {
                    Level2Building51.gameObject.SetActive(false);
                    Level3Building51.gameObject.SetActive(true);
                }
            }
			if (player4.GetComponent<FollowThePath>().transform.position == waypoints[52].transform.position) {
				GameControl.count43++;
				GameControl.own43 = 4;
                if (GameControl.count43 == 1)
                    Level1Building52.gameObject.SetActive(true);
                else if (GameControl.count43 == 2)
                {
                    Level1Building52.gameObject.SetActive(false);
                    Level2Building52.gameObject.SetActive(true);
                }
                else if (GameControl.count43 == 3)
                {
                    Level2Building52.gameObject.SetActive(false);
                    Level3Building52.gameObject.SetActive(true);
                }
            }
			if (player4.GetComponent<FollowThePath>().transform.position == waypoints[55].transform.position) {
				GameControl.count44++; 
				GameControl.own44 = 4;
                if (GameControl.count44 == 1)
                    Level1Building55.gameObject.SetActive(true);
                else if (GameControl.count44 == 2)
                {
                    Level1Building55.gameObject.SetActive(false);
                    Level2Building55.gameObject.SetActive(true);
                }
                else if (GameControl.count44 == 3)
                {
                    Level2Building55.gameObject.SetActive(false);
                    Level3Building55.gameObject.SetActive(true);
                }
            }
			if (player4.GetComponent<FollowThePath>().transform.position == waypoints[56].transform.position) {
				GameControl.count45++;
				GameControl.own45 = 4;
                if (GameControl.count45 == 1)
                    Level1Building56.gameObject.SetActive(true);
                else if (GameControl.count45 == 2)
                {
                    Level1Building56.gameObject.SetActive(false);
                    Level2Building56.gameObject.SetActive(true);
                }
                else if (GameControl.count45 == 3)
                {
                    Level2Building56.gameObject.SetActive(false);
                    Level3Building56.gameObject.SetActive(true);
                }
            }
			if (player4.GetComponent<FollowThePath>().transform.position == waypoints[57].transform.position) {
				GameControl.count46++;
				GameControl.own46 = 4;
                if (GameControl.count46 == 1)
                    Level1Building57.gameObject.SetActive(true);
                else if (GameControl.count46 == 2)
                {
                    Level1Building57.gameObject.SetActive(false);
                    Level2Building57.gameObject.SetActive(true);
                }
                else if (GameControl.count46 == 3)
                {
                    Level2Building57.gameObject.SetActive(false);
                    Level3Building57.gameObject.SetActive(true);
                }
            }
            GameControl.ImageForBuyHouse.gameObject.SetActive(false);
            camMain();
        }

        if (GameControl.whoTurn == 5)
        {
            if (sum5 - reduce < 0)
            {
                sum5 = 0;
                buy.interactable = false;
            }
            else
            {
                sum5 -= reduce;
            }
            player5Cost.text = sum5.ToString();
			if (player5.GetComponent<FollowThePath> ().transform.position == waypoints [1].transform.position) {
				GameControl.count1++;
				GameControl.own1 = 5;
                if (GameControl.count1 == 1)
                    Level1Building1.gameObject.SetActive(true);
                else if (GameControl.count1 == 2)
                {
                    Level1Building1.gameObject.SetActive(false);
                    Level2Building1.gameObject.SetActive(true);
                }
                else if (GameControl.count1 == 3)
                {
                    Level2Building1.gameObject.SetActive(false);
                    Level3Building1.gameObject.SetActive(true);
                }
            }
			if (player5.GetComponent<FollowThePath> ().transform.position == waypoints [2].transform.position) {
				GameControl.count2++;
				GameControl.own2 = 5;
                if (GameControl.count2 == 1)
                    Level1Building2.gameObject.SetActive(true);
                else if (GameControl.count2 == 2)
                {
                    Level1Building2.gameObject.SetActive(false);
                    Level2Building2.gameObject.SetActive(true);
                }
                else if (GameControl.count2 == 3)
                {
                    Level2Building2.gameObject.SetActive(false);
                    Level3Building2.gameObject.SetActive(true);
                }
            }   
			if (player5.GetComponent<FollowThePath> ().transform.position == waypoints [3].transform.position) {
				GameControl.count3++;
				GameControl.own3 = 5 ;
                if (GameControl.count3 == 1)
                    Level1Building3.gameObject.SetActive(true);
                else if (GameControl.count3 == 2)
                {
                    Level1Building3.gameObject.SetActive(false);
                    Level2Building3.gameObject.SetActive(true);
                }
                else if (GameControl.count3 == 3)
                {
                    Level2Building3.gameObject.SetActive(false);
                    Level3Building3.gameObject.SetActive(true);
                }
            }  
			if (player5.GetComponent<FollowThePath>().transform.position == waypoints[4].transform.position) {
				GameControl.count4++;
				GameControl.own4 = 5;
                if (GameControl.count4 == 1)
                    Level1Building4.gameObject.SetActive(true);
                else if (GameControl.count4 == 2)
                {
                    Level1Building4.gameObject.SetActive(false);
                    Level2Building4.gameObject.SetActive(true);
                }
                else if (GameControl.count4 == 3)
                {
                    Level2Building4.gameObject.SetActive(false);
                    Level3Building4.gameObject.SetActive(true);
                }
            }   
			if (player5.GetComponent<FollowThePath>().transform.position == waypoints[5].transform.position) {
				GameControl.count5++;
				GameControl.own5 = 5;
                if (GameControl.count5 == 1)
                    Level1Building5.gameObject.SetActive(true);
                else if (GameControl.count5 == 2)
                {
                    Level1Building5.gameObject.SetActive(false);
                    Level2Building5.gameObject.SetActive(true);
                }
                else if (GameControl.count5 == 3)
                {
                    Level2Building5.gameObject.SetActive(false);
                    Level3Building5.gameObject.SetActive(true);
                }
            }   
			if (player5.GetComponent<FollowThePath> ().transform.position == waypoints [7].transform.position) {
				GameControl.count6++;
				GameControl.own6 = 5;
                if (GameControl.count6 == 1)
                    Level1Building7.gameObject.SetActive(true);
                else if (GameControl.count6 == 2)
                {
                    Level1Building7.gameObject.SetActive(false);
                    Level2Building7.gameObject.SetActive(true);
                }
                else if (GameControl.count6 == 3)
                {
                    Level2Building7.gameObject.SetActive(false);
                    Level3Building7.gameObject.SetActive(true);
                }

            }
            if (player5.GetComponent<FollowThePath> ().transform.position == waypoints [8].transform.position) {
				GameControl.count7++;
				GameControl.own7 = 5;
                if (GameControl.count7 == 1)
                    Level1Building8.gameObject.SetActive(true);
                else if (GameControl.count7 == 2)
                {
                    Level1Building8.gameObject.SetActive(false);
                    Level2Building8.gameObject.SetActive(true);
                }
                else if (GameControl.count7 == 3)
                {
                    Level2Building8.gameObject.SetActive(false);
                    Level3Building8.gameObject.SetActive(true);
                }
            }
			if (player5.GetComponent<FollowThePath> ().transform.position == waypoints [9].transform.position) {
				GameControl.count8++;
				GameControl.own8 = 5;
                if (GameControl.count8 == 1)
                    Level1Building9.gameObject.SetActive(true);
                else if (GameControl.count8 == 2)
                {
                    Level1Building9.gameObject.SetActive(false);
                    Level2Building9.gameObject.SetActive(true);
                }
                else if (GameControl.count8 == 3)
                {
                    Level2Building9.gameObject.SetActive(false);
                    Level3Building9.gameObject.SetActive(true);
                }
            }
			if (player5.GetComponent<FollowThePath>().transform.position == waypoints[10].transform.position)
			{
				GameControl.count9++;
				GameControl.buyValue = 1;
				GameControl.own9 = 5;
			}        
			if (player5.GetComponent<FollowThePath>().transform.position == waypoints[11].transform.position) {
				GameControl.count10++;
				GameControl.own10 = 5;
                if (GameControl.count10 == 1)
                    Level1Building11.gameObject.SetActive(true);
                else if (GameControl.count10 == 2)
                {
                    Level1Building11.gameObject.SetActive(false);
                    Level2Building11.gameObject.SetActive(true);
                }
                else if (GameControl.count10 == 3)
                {
                    Level2Building11.gameObject.SetActive(false);
                    Level3Building11.gameObject.SetActive(true);
                }
            }  
			if (player5.GetComponent<FollowThePath>().transform.position == waypoints[13].transform.position) {
				GameControl.count11++;
				GameControl.own11 = 5;
                if (GameControl.count11 == 1)
                    Level1Building13.gameObject.SetActive(true);
                else if (GameControl.count11 == 2)
                {
                    Level1Building13.gameObject.SetActive(false);
                    Level2Building13.gameObject.SetActive(true);
                }
                else if (GameControl.count11 == 3)
                {
                    Level2Building13.gameObject.SetActive(false);
                    Level3Building13.gameObject.SetActive(true);
                }
            }
			if (player5.GetComponent<FollowThePath>().transform.position == waypoints[14].transform.position) {
				GameControl.count12++;
				GameControl.own12 = 5;
                if (GameControl.count12 == 1)
                    Level1Building14.gameObject.SetActive(true);
                else if (GameControl.count12 == 2)
                {
                    Level1Building14.gameObject.SetActive(false);
                    Level2Building14.gameObject.SetActive(true);
                }
                else if (GameControl.count12 == 3)
                {
                    Level2Building14.gameObject.SetActive(false);
                    Level3Building14.gameObject.SetActive(true);
                }
            }
			if (player5.GetComponent<FollowThePath>().transform.position == waypoints[15].transform.position) {
				GameControl.count13++;
				GameControl.own13 = 5;
                if (GameControl.count13 == 1)
                    Level1Building15.gameObject.SetActive(true);
                else if (GameControl.count13 == 2)
                {
                    Level1Building15.gameObject.SetActive(false);
                    Level2Building15.gameObject.SetActive(true);
                }
                else if (GameControl.count13 == 3)
                {
                    Level2Building15.gameObject.SetActive(false);
                    Level3Building15.gameObject.SetActive(true);
                }
            }
			if (player5.GetComponent<FollowThePath>().transform.position == waypoints[16].transform.position)  {
				GameControl.count14++;
				GameControl.own14 = 5;
                if (GameControl.count14 == 1)
                    Level1Building16.gameObject.SetActive(true);
                else if (GameControl.count14 == 2)
                {
                    Level1Building16.gameObject.SetActive(false);
                    Level2Building16.gameObject.SetActive(true);
                }
                else if (GameControl.count14 == 3)
                {
                    Level2Building16.gameObject.SetActive(false);
                    Level3Building16.gameObject.SetActive(true);
                }
            }
			if (player5.GetComponent<FollowThePath> ().transform.position == waypoints [17].transform.position) {
				GameControl.count15++;
				GameControl.own15 = 5;
                if (GameControl.count15 == 1)
                    Level1Building17.gameObject.SetActive(true);
                else if (GameControl.count15 == 2)
                {
                    Level1Building17.gameObject.SetActive(false);
                    Level2Building17.gameObject.SetActive(true);
                }
                else if (GameControl.count15 == 3)
                {
                    Level2Building17.gameObject.SetActive(false);
                    Level3Building17.gameObject.SetActive(true);
                }
            }  
			if (player5.GetComponent<FollowThePath> ().transform.position == waypoints [19].transform.position) {
				GameControl.count16++;
				GameControl.own16 = 5;
                if (GameControl.count16 == 1)
                    Level1Building19.gameObject.SetActive(true);
                else if (GameControl.count16 == 2)
                {
                    Level1Building19.gameObject.SetActive(false);
                    Level2Building19.gameObject.SetActive(true);
                }
                else if (GameControl.count16 == 3)
                {
                    Level2Building19.gameObject.SetActive(false);
                    Level3Building19.gameObject.SetActive(true);
                }
            }
			if (player5.GetComponent<FollowThePath>().transform.position == waypoints[20].transform.position) {
				GameControl.count17++;
				GameControl.own17 = 5;
                if (GameControl.count17 == 1)
                    Level1Building20.gameObject.SetActive(true);
                else if (GameControl.count17 == 2)
                {
                    Level1Building20.gameObject.SetActive(false);
                    Level2Building20.gameObject.SetActive(true);
                }
                else if (GameControl.count17 == 3)
                {
                    Level2Building20.gameObject.SetActive(false);
                    Level3Building20.gameObject.SetActive(true);
                }
            }
			if (player5.GetComponent<FollowThePath>().transform.position == waypoints[21].transform.position)
			{
				GameControl.count18++;
				GameControl.buyValue = 1;
				GameControl.own18 = 5;
			}
			if (player5.GetComponent<FollowThePath>().transform.position == waypoints[22].transform.position) {
				GameControl.count19++;
				GameControl.own19 = 5;
                if (GameControl.count19 == 1)
                    Level1Building22.gameObject.SetActive(true);
                else if (GameControl.count19 == 2)
                {
                    Level1Building22.gameObject.SetActive(false);
                    Level2Building22.gameObject.SetActive(true);
                }
                else if (GameControl.count19 == 3)
                {
                    Level2Building22.gameObject.SetActive(false);
                    Level3Building22.gameObject.SetActive(true);
                }
            }
			if (player5.GetComponent<FollowThePath>().transform.position == waypoints[23].transform.position) {
				GameControl.count20++;
				GameControl.own20 = 5;
                if (GameControl.count20 == 1)
                    Level1Building23.gameObject.SetActive(true);
                else if (GameControl.count20 == 2)
                {
                    Level1Building23.gameObject.SetActive(false);
                    Level2Building23.gameObject.SetActive(true);
                }
                else if (GameControl.count20 == 3)
                {
                    Level2Building23.gameObject.SetActive(false);
                    Level3Building23.gameObject.SetActive(true);
                }
            }
			if (player5.GetComponent<FollowThePath>().transform.position == waypoints[24].transform.position) {
				GameControl.count21++;
				GameControl.own21 = 5;
                if (GameControl.count21 == 1)
                    Level1Building24.gameObject.SetActive(true);
                else if (GameControl.count21 == 2)
                {
                    Level1Building24.gameObject.SetActive(false);
                    Level2Building24.gameObject.SetActive(true);
                }
                else if (GameControl.count21 == 3)
                {
                    Level2Building24.gameObject.SetActive(false);
                    Level3Building24.gameObject.SetActive(true);
                }
            }
			if (player5.GetComponent<FollowThePath>().transform.position == waypoints[26].transform.position) {
				GameControl.count22++;
				GameControl.own22 = 5;
                if (GameControl.count22 == 1)
                    Level1Building26.gameObject.SetActive(true);
                else if (GameControl.count22 == 2)
                {
                    Level1Building26.gameObject.SetActive(false);
                    Level2Building26.gameObject.SetActive(true);
                }
                else if (GameControl.count22 == 3)
                {
                    Level2Building26.gameObject.SetActive(false);
                    Level3Building26.gameObject.SetActive(true);
                }
            }
			if (player5.GetComponent<FollowThePath>().transform.position == waypoints[27].transform.position) {
				GameControl.count23++;
				GameControl.own23 = 5;
                if (GameControl.count23 == 1)
                    Level1Building27.gameObject.SetActive(true);
                else if (GameControl.count23 == 2)
                {
                    Level1Building27.gameObject.SetActive(false);
                    Level2Building27.gameObject.SetActive(true);
                }
                else if (GameControl.count23 == 3)
                {
                    Level2Building27.gameObject.SetActive(false);
                    Level3Building27.gameObject.SetActive(true);
                }
            }
			if (player5.GetComponent<FollowThePath>().transform.position == waypoints[28].transform.position) {
				GameControl.count24++;
				GameControl.own24 = 5;
                if (GameControl.count24 == 1)
                    Level1Building28.gameObject.SetActive(true);
                else if (GameControl.count24 == 2)
                {
                    Level1Building28.gameObject.SetActive(false);
                    Level2Building28.gameObject.SetActive(true);
                }
                else if (GameControl.count24 == 3)
                {
                    Level2Building28.gameObject.SetActive(false);
                    Level3Building28.gameObject.SetActive(true);
                }
            }
			if (player5.GetComponent<FollowThePath>().transform.position == waypoints[29].transform.position) {
				GameControl.count25++;
				GameControl.own25 = 5;
                if (GameControl.count25 == 1)
                    Level1Building29.gameObject.SetActive(true);
                else if (GameControl.count25 == 2)
                {
                    Level1Building29.gameObject.SetActive(false);
                    Level2Building29.gameObject.SetActive(true);
                }
                else if (GameControl.count25 == 3)
                {
                    Level2Building29.gameObject.SetActive(false);
                    Level3Building29.gameObject.SetActive(true);
                }
            }
			if (player5.GetComponent<FollowThePath>().transform.position == waypoints[31].transform.position) {
				GameControl.count26++;
				GameControl.own26 = 5;
                if (GameControl.count26 == 1)
                    Level1Building31.gameObject.SetActive(true);
                else if (GameControl.count26 == 2)
                {
                    Level1Building31.gameObject.SetActive(false);
                    Level2Building31.gameObject.SetActive(true);
                }
                else if (GameControl.count26 == 3)
                {
                    Level2Building31.gameObject.SetActive(false);
                    Level3Building31.gameObject.SetActive(true);
                }
            }
			if (player5.GetComponent<FollowThePath>().transform.position == waypoints[32].transform.position) {
				GameControl.count27++;
				GameControl.own27 = 5;
                if (GameControl.count27 == 1)
                    Level1Building32.gameObject.SetActive(true);
                else if (GameControl.count27 == 2)
                {
                    Level1Building32.gameObject.SetActive(false);
                    Level2Building32.gameObject.SetActive(true);
                }
                else if (GameControl.count27 == 3)
                {
                    Level2Building32.gameObject.SetActive(false);
                    Level3Building32.gameObject.SetActive(true);
                }
            }
			if (player5.GetComponent<FollowThePath>().transform.position == waypoints[33].transform.position) {
				GameControl.count28++;
				GameControl.own28 = 5;
                if (GameControl.count28 == 1)
                    Level1Building33.gameObject.SetActive(true);
                else if (GameControl.count28 == 2)
                {
                    Level1Building33.gameObject.SetActive(false);
                    Level2Building33.gameObject.SetActive(true);
                }
                else if (GameControl.count28 == 3)
                {
                    Level2Building33.gameObject.SetActive(false);
                    Level3Building33.gameObject.SetActive(true);
                }
            }
			if (player5.GetComponent<FollowThePath>().transform.position == waypoints[34].transform.position) {
				GameControl.count29++;
				GameControl.own29 = 5;
                if (GameControl.count29 == 1)
                    Level1Building34.gameObject.SetActive(true);
                else if (GameControl.count29 == 2)
                {
                    Level1Building34.gameObject.SetActive(false);
                    Level2Building34.gameObject.SetActive(true);
                }
                else if (GameControl.count29 == 3)
                {
                    Level2Building34.gameObject.SetActive(false);
                    Level3Building34.gameObject.SetActive(true);
                }
            }
			if (player5.GetComponent<FollowThePath>().transform.position == waypoints[36].transform.position) {
				GameControl.count30++;
				GameControl.own30 = 5;
                if (GameControl.count30 == 1)
                    Level1Building36.gameObject.SetActive(true);
                else if (GameControl.count30 == 2)
                {
                    Level1Building36.gameObject.SetActive(false);
                    Level2Building36.gameObject.SetActive(true);
                }
                else if (GameControl.count30 == 3)
                {
                    Level2Building36.gameObject.SetActive(false);
                    Level3Building36.gameObject.SetActive(true);
                }
            }
			if (player5.GetComponent<FollowThePath>().transform.position == waypoints[37].transform.position) {
				GameControl.count31++;
				GameControl.own31 = 5;
                if (GameControl.count31 == 1)
                    Level1Building37.gameObject.SetActive(true);
                else if (GameControl.count31 == 2)
                {
                    Level1Building37.gameObject.SetActive(false);
                    Level2Building37.gameObject.SetActive(true);
                }
                else if (GameControl.count31 == 3)
                {
                    Level2Building37.gameObject.SetActive(false);
                    Level3Building37.gameObject.SetActive(true);
                }
            }
			if (player5.GetComponent<FollowThePath>().transform.position == waypoints[38].transform.position)
			{
				GameControl.count32++;
				GameControl.buyValue = 1;
				GameControl.own32 = 5;
			}  
			if (player5.GetComponent<FollowThePath>().transform.position == waypoints[39].transform.position) {
				GameControl.count33++;
				GameControl.own33 = 5;
                if (GameControl.count33 == 1)
                    Level1Building39.gameObject.SetActive(true);
                else if (GameControl.count33 == 2)
                {
                    Level1Building39.gameObject.SetActive(false);
                    Level2Building39.gameObject.SetActive(true);
                }
                else if (GameControl.count33 == 3)
                {
                    Level2Building39.gameObject.SetActive(false);
                    Level3Building39.gameObject.SetActive(true);
                }
            }
			if (player5.GetComponent<FollowThePath>().transform.position == waypoints[40].transform.position) {
				GameControl.count34++;
				GameControl.own34 = 5;
                if (GameControl.count34 == 1)
                    Level1Building40.gameObject.SetActive(true);
                else if (GameControl.count34 == 2)
                {
                    Level1Building40.gameObject.SetActive(false);
                    Level2Building40.gameObject.SetActive(true);
                }
                else if (GameControl.count34 == 3)
                {
                    Level2Building40.gameObject.SetActive(false);
                    Level3Building40.gameObject.SetActive(true);
                }
            }
			if (player5.GetComponent<FollowThePath>().transform.position == waypoints[42].transform.position) {
				GameControl.count35++;
				GameControl.own35 = 5;
                if (GameControl.count35 == 1)
                    Level1Building42.gameObject.SetActive(true);
                else if (GameControl.count35 == 2)
                {
                    Level1Building42.gameObject.SetActive(false);
                    Level2Building42.gameObject.SetActive(true);
                }
                else if (GameControl.count35 == 3)
                {
                    Level2Building42.gameObject.SetActive(false);
                    Level3Building42.gameObject.SetActive(true);
                }
            }
			if (player5.GetComponent<FollowThePath>().transform.position == waypoints[43].transform.position) {
				GameControl.count36++;
				GameControl.own36 = 5;
                if (GameControl.count36 == 1)
                    Level1Building43.gameObject.SetActive(true);
                else if (GameControl.count36 == 2)
                {
                    Level1Building43.gameObject.SetActive(false);
                    Level2Building43.gameObject.SetActive(true);
                }
                else if (GameControl.count36 == 3)
                {
                    Level2Building43.gameObject.SetActive(false);
                    Level3Building43.gameObject.SetActive(true);
                }
            }
			if (player5.GetComponent<FollowThePath>().transform.position == waypoints[44].transform.position) {
				GameControl.count37++;
				GameControl.own37 = 5;
                if (GameControl.count37 == 1)
                    Level1Building44.gameObject.SetActive(true);
                else if (GameControl.count37 == 2)
                {
                    Level1Building44.gameObject.SetActive(false);
                    Level2Building44.gameObject.SetActive(true);
                }
                else if (GameControl.count37 == 3)
                {
                    Level2Building44.gameObject.SetActive(false);
                    Level3Building44.gameObject.SetActive(true);
                }
            }
			if (player5.GetComponent<FollowThePath>().transform.position == waypoints[47].transform.position) {
				GameControl.count38++;
				GameControl.own38 = 5;
                if (GameControl.count38 == 1)
                    Level1Building47.gameObject.SetActive(true);
                else if (GameControl.count38 == 2)
                {
                    Level1Building47.gameObject.SetActive(false);
                    Level2Building47.gameObject.SetActive(true);
                }
                else if (GameControl.count38 == 3)
                {
                    Level2Building47.gameObject.SetActive(false);
                    Level3Building47.gameObject.SetActive(true);
                }
            }
			if (player5.GetComponent<FollowThePath>().transform.position == waypoints[48].transform.position) {
				GameControl.count39++;
				GameControl.own39 = 5;
                if (GameControl.count39 == 1)
                    Level1Building48.gameObject.SetActive(true);
                else if (GameControl.count39 == 2)
                {
                    Level1Building48.gameObject.SetActive(false);
                    Level2Building48.gameObject.SetActive(true);
                }
                else if (GameControl.count39 == 3)
                {
                    Level2Building48.gameObject.SetActive(false);
                    Level3Building48.gameObject.SetActive(true);
                }
            }
			if (player5.GetComponent<FollowThePath>().transform.position == waypoints[49].transform.position) {
				GameControl.count40++;
				GameControl.own40 = 5;
                if (GameControl.count40 == 1)
                    Level1Building49.gameObject.SetActive(true);
                else if (GameControl.count40 == 2)
                {
                    Level1Building49.gameObject.SetActive(false);
                    Level2Building49.gameObject.SetActive(true);
                }
                else if (GameControl.count40 == 3)
                {
                    Level2Building49.gameObject.SetActive(false);
                    Level3Building49.gameObject.SetActive(true);
                }
            }
			if (player5.GetComponent<FollowThePath>().transform.position == waypoints[50].transform.position)
			{
				GameControl.count41++;
				GameControl.buyValue = 1;
				GameControl.own41 = 5;
			}
			if (player5.GetComponent<FollowThePath>().transform.position == waypoints[51].transform.position) {
				GameControl.count42++;
				GameControl.own42 = 5;
                if (GameControl.count42 == 1)
                    Level1Building51.gameObject.SetActive(true);
                else if (GameControl.count42 == 2)
                {
                    Level1Building51.gameObject.SetActive(false);
                    Level2Building51.gameObject.SetActive(true);
                }
                else if (GameControl.count42 == 3)
                {
                    Level2Building51.gameObject.SetActive(false);
                    Level3Building51.gameObject.SetActive(true);
                }
            }
			if (player5.GetComponent<FollowThePath>().transform.position == waypoints[52].transform.position) {
				GameControl.count43++;
				GameControl.own43 = 5;
                if (GameControl.count43 == 1)
                    Level1Building52.gameObject.SetActive(true);
                else if (GameControl.count43 == 2)
                {
                    Level1Building52.gameObject.SetActive(false);
                    Level2Building52.gameObject.SetActive(true);
                }
                else if (GameControl.count43 == 3)
                {
                    Level2Building52.gameObject.SetActive(false);
                    Level3Building52.gameObject.SetActive(true);
                }
            }
			if (player5.GetComponent<FollowThePath>().transform.position == waypoints[55].transform.position) {
				GameControl.count44++;
				GameControl.own44 = 5;
                if (GameControl.count44 == 1)
                    Level1Building55.gameObject.SetActive(true);
                else if (GameControl.count44 == 2)
                {
                    Level1Building55.gameObject.SetActive(false);
                    Level2Building55.gameObject.SetActive(true);
                }
                else if (GameControl.count44 == 3)
                {
                    Level2Building55.gameObject.SetActive(false);
                    Level3Building55.gameObject.SetActive(true);
                }
            }
			if (player5.GetComponent<FollowThePath>().transform.position == waypoints[56].transform.position) {
				GameControl.count45++;
				GameControl.own45 = 5;
                if (GameControl.count45 == 1)
                    Level1Building56.gameObject.SetActive(true);
                else if (GameControl.count45 == 2)
                {
                    Level1Building56.gameObject.SetActive(false);
                    Level2Building56.gameObject.SetActive(true);
                }
                else if (GameControl.count45 == 3)
                {
                    Level2Building56.gameObject.SetActive(false);
                    Level3Building56.gameObject.SetActive(true);
                }
            }
			if (player5.GetComponent<FollowThePath>().transform.position == waypoints[57].transform.position) {
				GameControl.count46++;
				GameControl.own46 = 5;
                if (GameControl.count46 == 1)
                    Level1Building57.gameObject.SetActive(true);
                else if (GameControl.count46 == 2)
                {
                    Level1Building57.gameObject.SetActive(false);
                    Level2Building57.gameObject.SetActive(true);
                }
                else if (GameControl.count46 == 3)
                {
                    Level2Building57.gameObject.SetActive(false);
                    Level3Building57.gameObject.SetActive(true);
                }
            }
            GameControl.ImageForBuyHouse.gameObject.SetActive(false);
            camMain();
        }

        if (GameControl.whoTurn == 6)
        {
            if (sum6 - reduce < 0)
            {
                sum6 = 0;
                buy.interactable = false;
            }
            else
            {
                sum6 -= reduce;
            }
            player6Cost.text = sum6.ToString();
			if (player6.GetComponent<FollowThePath> ().transform.position == waypoints [1].transform.position) {
				GameControl.count1++;
				GameControl.own1 = 6;
                if (GameControl.count == 1)
                    Level1Building1.gameObject.SetActive(true);
                else if (GameControl.count1 == 2)
                {
                    Level1Building1.gameObject.SetActive(false);
                    Level2Building1.gameObject.SetActive(true);
                }
                else if (GameControl.count1 == 3)
                {
                    Level2Building1.gameObject.SetActive(false);
                    Level3Building1.gameObject.SetActive(true);
                }
            }
			if (player6.GetComponent<FollowThePath> ().transform.position == waypoints [2].transform.position) {
				GameControl.count2++;
				GameControl.own2 = 6;
                if (GameControl.count2 == 1)
                    Level1Building2.gameObject.SetActive(true);
                else if (GameControl.count2 == 2)
                {
                    Level1Building2.gameObject.SetActive(false);
                    Level2Building2.gameObject.SetActive(true);
                }
                else if (GameControl.count2 == 3)
                {
                    Level2Building2.gameObject.SetActive(false);
                    Level3Building2.gameObject.SetActive(true);
                }
            }   
			if (player6.GetComponent<FollowThePath> ().transform.position == waypoints [3].transform.position) {
				GameControl.count3++;
				GameControl.own3 = 6 ;
                if (GameControl.count3 == 1)
                    Level1Building3.gameObject.SetActive(true);
                else if (GameControl.count3 == 2)
                {
                    Level1Building3.gameObject.SetActive(false);
                    Level2Building3.gameObject.SetActive(true);
                }
                else if (GameControl.count3 == 3)
                {
                    Level2Building3.gameObject.SetActive(false);
                    Level3Building3.gameObject.SetActive(true);
                }
            }  
			if (player6.GetComponent<FollowThePath>().transform.position == waypoints[4].transform.position) {
				GameControl.count4++;
				GameControl.own4 = 6;
                if (GameControl.count4 == 1)
                    Level1Building4.gameObject.SetActive(true);
                else if (GameControl.count4 == 2)
                {
                    Level1Building4.gameObject.SetActive(false);
                    Level2Building4.gameObject.SetActive(true);
                }
                else if (GameControl.count4 == 3)
                {
                    Level2Building4.gameObject.SetActive(false);
                    Level3Building4.gameObject.SetActive(true);
                }
            }   
			if (player6.GetComponent<FollowThePath>().transform.position == waypoints[5].transform.position) {
				GameControl.count5++;
				GameControl.own5 = 6;
                if (GameControl.count5 == 1)
                    Level1Building5.gameObject.SetActive(true);
                else if (GameControl.count5 == 2)
                {
                    Level1Building5.gameObject.SetActive(false);
                    Level2Building5.gameObject.SetActive(true);
                }
                else if (GameControl.count5 == 3)
                {
                    Level2Building5.gameObject.SetActive(false);
                    Level3Building5.gameObject.SetActive(true);
                }
            }   
			if (player6.GetComponent<FollowThePath> ().transform.position == waypoints [7].transform.position) {
				GameControl.count6++;
				GameControl.own6 = 6;
                if (GameControl.count6 == 1)
                    Level1Building7.gameObject.SetActive(true);
                else if (GameControl.count6 == 2)
                {
                    Level1Building7.gameObject.SetActive(false);
                    Level2Building7.gameObject.SetActive(true);
                }
                else if (GameControl.count6 == 3)
                {
                    Level2Building7.gameObject.SetActive(false);
                    Level3Building7.gameObject.SetActive(true);
                }
            }
			if (player6.GetComponent<FollowThePath> ().transform.position == waypoints [8].transform.position) {
				GameControl.count7++;
				GameControl.own7 = 6;
                if (GameControl.count7 == 1)
                    Level1Building8.gameObject.SetActive(true);
                else if (GameControl.count7 == 2)
                {
                    Level1Building8.gameObject.SetActive(false);
                    Level2Building8.gameObject.SetActive(true);
                }
                else if (GameControl.count7 == 3)
                {
                    Level2Building8.gameObject.SetActive(false);
                    Level3Building8.gameObject.SetActive(true);
                }
            }
			if (player6.GetComponent<FollowThePath> ().transform.position == waypoints [9].transform.position) {
				GameControl.count8++;
				GameControl.own8 = 6;
                if (GameControl.count8 == 1)
                    Level1Building9.gameObject.SetActive(true);
                else if (GameControl.count8 == 2)
                {
                    Level1Building9.gameObject.SetActive(false);
                    Level2Building9.gameObject.SetActive(true);
                }
                else if (GameControl.count8 == 3)
                {
                    Level2Building9.gameObject.SetActive(false);
                    Level3Building9.gameObject.SetActive(true);
                }
            }
			if (player6.GetComponent<FollowThePath>().transform.position == waypoints[10].transform.position)
			{
				GameControl.count9++;
				GameControl.buyValue = 1;
				GameControl.own9 = 6;
			}        
			if (player6.GetComponent<FollowThePath>().transform.position == waypoints[11].transform.position) {
				GameControl.count10++;
				GameControl.own10 = 6;
                if (GameControl.count10 == 1)
                    Level1Building11.gameObject.SetActive(true);
                else if (GameControl.count10 == 2)
                {
                    Level1Building11.gameObject.SetActive(false);
                    Level2Building11.gameObject.SetActive(true);
                }
                else if (GameControl.count10 == 3)
                {
                    Level2Building11.gameObject.SetActive(false);
                    Level3Building11.gameObject.SetActive(true);
                }
            }  
			if (player6.GetComponent<FollowThePath>().transform.position == waypoints[13].transform.position) {
				GameControl.count11++;
				GameControl.own11 = 6;
                if (GameControl.count11 == 1)
                    Level1Building13.gameObject.SetActive(true);
                else if (GameControl.count11 == 2)
                {
                    Level1Building13.gameObject.SetActive(false);
                    Level2Building13.gameObject.SetActive(true);
                }
                else if (GameControl.count11 == 3)
                {
                    Level2Building13.gameObject.SetActive(false);
                    Level3Building13.gameObject.SetActive(true);
                }
            }
			if (player6.GetComponent<FollowThePath>().transform.position == waypoints[14].transform.position) {
				GameControl.count12++;
				GameControl.own12 = 6;
                if (GameControl.count12 == 1)
                    Level1Building14.gameObject.SetActive(true);
                else if (GameControl.count12 == 2)
                {
                    Level1Building14.gameObject.SetActive(false);
                    Level2Building14.gameObject.SetActive(true);
                }
                else if (GameControl.count12 == 3)
                {
                    Level2Building14.gameObject.SetActive(false);
                    Level3Building14.gameObject.SetActive(true);
                }
            }
			if (player6.GetComponent<FollowThePath>().transform.position == waypoints[15].transform.position) {
				GameControl.count13++;
				GameControl.own13 = 6;
                if (GameControl.count13 == 1)
                    Level1Building15.gameObject.SetActive(true);
                else if (GameControl.count13 == 2)
                {
                    Level1Building15.gameObject.SetActive(false);
                    Level2Building15.gameObject.SetActive(true);
                }
                else if (GameControl.count13 == 3)
                {
                    Level2Building15.gameObject.SetActive(false);
                    Level3Building15.gameObject.SetActive(true);
                }
            }
			if (player6.GetComponent<FollowThePath>().transform.position == waypoints[16].transform.position)  {
				GameControl.count14++;
				GameControl.own14 = 6;
                if (GameControl.count14 == 1)
                    Level1Building16.gameObject.SetActive(true);
                else if (GameControl.count14 == 2)
                {
                    Level1Building16.gameObject.SetActive(false);
                    Level2Building16.gameObject.SetActive(true);
                }
                else if (GameControl.count14 == 3)
                {
                    Level2Building16.gameObject.SetActive(false);
                    Level3Building16.gameObject.SetActive(true);
                }
            }
			if (player6.GetComponent<FollowThePath> ().transform.position == waypoints [17].transform.position) {
				GameControl.count15++;
				GameControl.own15 = 6;
                if (GameControl.count15 == 1)
                    Level1Building17.gameObject.SetActive(true);
                else if (GameControl.count15 == 2)
                {
                    Level1Building17.gameObject.SetActive(false);
                    Level2Building17.gameObject.SetActive(true);
                }
                else if (GameControl.count15 == 3)
                {
                    Level2Building17.gameObject.SetActive(false);
                    Level3Building17.gameObject.SetActive(true);
                }
            }  
			if (player6.GetComponent<FollowThePath> ().transform.position == waypoints [19].transform.position) {
				GameControl.count16++;
				GameControl.own16 = 6;
                if (GameControl.count16 == 1)
                    Level1Building19.gameObject.SetActive(true);
                else if (GameControl.count16 == 2)
                {
                    Level1Building19.gameObject.SetActive(false);
                    Level2Building19.gameObject.SetActive(true);
                }
                else if (GameControl.count16 == 3)
                {
                    Level2Building19.gameObject.SetActive(false);
                    Level3Building19.gameObject.SetActive(true);
                }
            }
			if (player6.GetComponent<FollowThePath>().transform.position == waypoints[20].transform.position) {
				GameControl.count17++;
				GameControl.own17 = 6;
                if (GameControl.count17 == 1)
                    Level1Building20.gameObject.SetActive(true);
                else if (GameControl.count17 == 2)
                {
                    Level1Building20.gameObject.SetActive(false);
                    Level2Building20.gameObject.SetActive(true);
                }
                else if (GameControl.count17 == 3)
                {
                    Level2Building20.gameObject.SetActive(false);
                    Level3Building20.gameObject.SetActive(true);
                }
            }
			if (player6.GetComponent<FollowThePath>().transform.position == waypoints[21].transform.position)
			{
				GameControl.count18++;
				GameControl.buyValue = 1;
				GameControl.own18 = 6;
			}
			if (player6.GetComponent<FollowThePath>().transform.position == waypoints[22].transform.position) {
				GameControl.count19++;
				GameControl.own19 = 6;
                if (GameControl.count19 == 1)
                    Level1Building22.gameObject.SetActive(true);
                else if (GameControl.count19 == 2)
                {
                    Level1Building22.gameObject.SetActive(false);
                    Level2Building22.gameObject.SetActive(true);
                }
                else if (GameControl.count19 == 3)
                {
                    Level2Building22.gameObject.SetActive(false);
                    Level3Building22.gameObject.SetActive(true);
                }
            }
			if (player6.GetComponent<FollowThePath>().transform.position == waypoints[23].transform.position) {
				GameControl.count20++;
				GameControl.own20 = 6;
                if (GameControl.count20 == 1)
                    Level1Building23.gameObject.SetActive(true);
                else if (GameControl.count20 == 2)
                {
                    Level1Building23.gameObject.SetActive(false);
                    Level2Building23.gameObject.SetActive(true);
                }
                else if (GameControl.count20 == 3)
                {
                    Level2Building23.gameObject.SetActive(false);
                    Level3Building23.gameObject.SetActive(true);
                }
            }
			if (player6.GetComponent<FollowThePath>().transform.position == waypoints[24].transform.position) {
				GameControl.count21++;
				GameControl.own21 = 6;
                if (GameControl.count21 == 1)
                    Level1Building24.gameObject.SetActive(true);
                else if (GameControl.count21 == 2)
                {
                    Level1Building24.gameObject.SetActive(false);
                    Level2Building24.gameObject.SetActive(true);
                }
                else if (GameControl.count21 == 3)
                {
                    Level2Building24.gameObject.SetActive(false);
                    Level3Building24.gameObject.SetActive(true);
                }
            }
			if (player6.GetComponent<FollowThePath>().transform.position == waypoints[26].transform.position) {
				GameControl.count22++;
				GameControl.own22 = 6;
                if (GameControl.count22 == 1)
                    Level1Building26.gameObject.SetActive(true);
                else if (GameControl.count22 == 2)
                {
                    Level1Building26.gameObject.SetActive(false);
                    Level2Building26.gameObject.SetActive(true);
                }
                else if (GameControl.count22 == 3)
                {
                    Level2Building26.gameObject.SetActive(false);
                    Level3Building26.gameObject.SetActive(true);
                }
            }
			if (player6.GetComponent<FollowThePath>().transform.position == waypoints[27].transform.position) {
				GameControl.count23++;
				GameControl.own23 = 6;
                if (GameControl.count23 == 1)
                    Level1Building27.gameObject.SetActive(true);
                else if (GameControl.count23 == 2)
                {
                    Level1Building27.gameObject.SetActive(false);
                    Level2Building27.gameObject.SetActive(true);
                }
                else if (GameControl.count23 == 3)
                {
                    Level2Building27.gameObject.SetActive(false);
                    Level3Building27.gameObject.SetActive(true);
                }
            }
			if (player6.GetComponent<FollowThePath>().transform.position == waypoints[28].transform.position) {
				GameControl.count24++;
				GameControl.own24 = 6;
                if (GameControl.count24 == 1)
                    Level1Building28.gameObject.SetActive(true);
                else if (GameControl.count24 == 2)
                {
                    Level1Building28.gameObject.SetActive(false);
                    Level2Building28.gameObject.SetActive(true);
                }
                else if (GameControl.count24 == 3)
                {
                    Level2Building28.gameObject.SetActive(false);
                    Level3Building28.gameObject.SetActive(true);
                }
            }
			if (player6.GetComponent<FollowThePath>().transform.position == waypoints[29].transform.position) {
				GameControl.count25++;
				GameControl.own25 = 6;
                if (GameControl.count25 == 1)
                    Level1Building29.gameObject.SetActive(true);
                else if (GameControl.count25 == 2)
                {
                    Level1Building29.gameObject.SetActive(false);
                    Level2Building29.gameObject.SetActive(true);
                }
                else if (GameControl.count25 == 3)
                {
                    Level2Building29.gameObject.SetActive(false);
                    Level3Building29.gameObject.SetActive(true);
                }
            }
			if (player6.GetComponent<FollowThePath>().transform.position == waypoints[31].transform.position) {
				GameControl.count26++;
				GameControl.own26 = 6;
                if (GameControl.count26 == 1)
                    Level1Building31.gameObject.SetActive(true);
                else if (GameControl.count26 == 2)
                {
                    Level1Building31.gameObject.SetActive(false);
                    Level2Building31.gameObject.SetActive(true);
                }
                else if (GameControl.count26 == 3)
                {
                    Level2Building31.gameObject.SetActive(false);
                    Level3Building31.gameObject.SetActive(true);
                }
            }
			if (player6.GetComponent<FollowThePath>().transform.position == waypoints[32].transform.position) {
				GameControl.count27++;
				GameControl.own27 = 6;
                if (GameControl.count27 == 1)
                    Level1Building32.gameObject.SetActive(true);
                else if (GameControl.count27 == 2)
                {
                    Level1Building32.gameObject.SetActive(false);
                    Level2Building32.gameObject.SetActive(true);
                }
                else if (GameControl.count27 == 3)
                {
                    Level2Building32.gameObject.SetActive(false);
                    Level3Building32.gameObject.SetActive(true);
                }
            }
			if (player6.GetComponent<FollowThePath>().transform.position == waypoints[33].transform.position) {
				GameControl.count28++;
				GameControl.own28 = 6;
                if (GameControl.count28 == 1)
                    Level1Building33.gameObject.SetActive(true);
                else if (GameControl.count28 == 2)
                {
                    Level1Building33.gameObject.SetActive(false);
                    Level2Building33.gameObject.SetActive(true);
                }
                else if (GameControl.count28 == 3)
                {
                    Level2Building33.gameObject.SetActive(false);
                    Level3Building33.gameObject.SetActive(true);
                }
            }
			if (player5.GetComponent<FollowThePath>().transform.position == waypoints[34].transform.position) {
				GameControl.count29++;
				GameControl.own29 = 6;
                if (GameControl.count29 == 1)
                    Level1Building34.gameObject.SetActive(true);
                else if (GameControl.count29 == 2)
                {
                    Level1Building34.gameObject.SetActive(false);
                    Level2Building34.gameObject.SetActive(true);
                }
                else if (GameControl.count29 == 3)
                {
                    Level2Building34.gameObject.SetActive(false);
                    Level3Building34.gameObject.SetActive(true);
                }
            }
			if (player6.GetComponent<FollowThePath>().transform.position == waypoints[36].transform.position) {
				GameControl.count30++;
				GameControl.own30 = 6;
                if (GameControl.count20 == 1)
                    Level1Building36.gameObject.SetActive(true);
                else if (GameControl.count30 == 2)
                {
                    Level1Building36.gameObject.SetActive(false);
                    Level2Building36.gameObject.SetActive(true);
                }
                else if (GameControl.count30 == 3)
                {
                    Level2Building36.gameObject.SetActive(false);
                    Level3Building36.gameObject.SetActive(true);
                }
            }
			if (player6.GetComponent<FollowThePath>().transform.position == waypoints[37].transform.position) {
				GameControl.count31++;
				GameControl.own31 = 6;
                if (GameControl.count31 == 1)
                    Level1Building37.gameObject.SetActive(true);
                else if (GameControl.count31 == 2)
                {
                    Level1Building37.gameObject.SetActive(false);
                    Level2Building37.gameObject.SetActive(true);
                }
                else if (GameControl.count31 == 3)
                {
                    Level2Building37.gameObject.SetActive(false);
                    Level3Building37.gameObject.SetActive(true);
                }
            }
			if (player6.GetComponent<FollowThePath>().transform.position == waypoints[38].transform.position)
			{
				GameControl.count32++;
				GameControl.buyValue = 1;
				GameControl.own32 = 6;
            }  
			if (player6.GetComponent<FollowThePath>().transform.position == waypoints[39].transform.position) {
				GameControl.count33++;
				GameControl.own33 = 6;
                if (GameControl.count33 == 1)
                    Level1Building39.gameObject.SetActive(true);
                else if (GameControl.count33 == 2)
                {
                    Level1Building39.gameObject.SetActive(false);
                    Level2Building39.gameObject.SetActive(true);
                }
                else if (GameControl.count33 == 3)
                {
                    Level2Building39.gameObject.SetActive(false);
                    Level3Building39.gameObject.SetActive(true);
                }
            }
			if (player6.GetComponent<FollowThePath>().transform.position == waypoints[40].transform.position) {
				GameControl.count34++;
				GameControl.own34 = 6;
                if (GameControl.count34 == 1)
                    Level1Building40.gameObject.SetActive(true);
                else if (GameControl.count34 == 2)
                {
                    Level1Building40.gameObject.SetActive(false);
                    Level2Building40.gameObject.SetActive(true);
                }
                else if (GameControl.count34 == 3)
                {
                    Level2Building40.gameObject.SetActive(false);
                    Level3Building40.gameObject.SetActive(true);
                }
            }
			if (player6.GetComponent<FollowThePath>().transform.position == waypoints[42].transform.position) {
				GameControl.count35++;
				GameControl.own35 = 6;
                if (GameControl.count35 == 1)
                    Level1Building42.gameObject.SetActive(true);
                else if (GameControl.count35 == 2)
                {
                    Level1Building42.gameObject.SetActive(false);
                    Level2Building42.gameObject.SetActive(true);
                }
                else if (GameControl.count35 == 3)
                {
                    Level2Building42.gameObject.SetActive(false);
                    Level3Building42.gameObject.SetActive(true);
                }
            }
			if (player6.GetComponent<FollowThePath>().transform.position == waypoints[43].transform.position) {
				GameControl.count36++;
				GameControl.own36 = 6;
                if (GameControl.count36 == 1)
                    Level1Building43.gameObject.SetActive(true);
                else if (GameControl.count36 == 2)
                {
                    Level1Building43.gameObject.SetActive(false);
                    Level2Building43.gameObject.SetActive(true);
                }
                else if (GameControl.count36 == 3)
                {
                    Level2Building43.gameObject.SetActive(false);
                    Level3Building43.gameObject.SetActive(true);
                }
            }
			if (player6.GetComponent<FollowThePath>().transform.position == waypoints[44].transform.position) {
				GameControl.count37++;
				GameControl.own37 = 6;
                if (GameControl.count37 == 1)
                    Level1Building44.gameObject.SetActive(true);
                else if (GameControl.count37 == 2)
                {
                    Level1Building44.gameObject.SetActive(false);
                    Level2Building44.gameObject.SetActive(true);
                }
                else if (GameControl.count37 == 3)
                {
                    Level2Building44.gameObject.SetActive(false);
                    Level3Building44.gameObject.SetActive(true);
                }
            }
			if (player6.GetComponent<FollowThePath>().transform.position == waypoints[47].transform.position) {
				GameControl.count38++;
				GameControl.own38 = 6;
                if (GameControl.count38 == 1)
                    Level1Building47.gameObject.SetActive(true);
                else if (GameControl.count38 == 2)
                {
                    Level1Building47.gameObject.SetActive(false);
                    Level2Building47.gameObject.SetActive(true);
                }
                else if (GameControl.count38 == 3)
                {
                    Level2Building47.gameObject.SetActive(false);
                    Level3Building47.gameObject.SetActive(true);
                }
            }
			if (player6.GetComponent<FollowThePath>().transform.position == waypoints[48].transform.position) {
				GameControl.count39++;
				GameControl.own39 = 6;
                if (GameControl.count39 == 1)
                    Level1Building48.gameObject.SetActive(true);
                else if (GameControl.count39 == 2)
                {
                    Level1Building48.gameObject.SetActive(false);
                    Level2Building48.gameObject.SetActive(true);
                }
                else if (GameControl.count39 == 3)
                {
                    Level2Building48.gameObject.SetActive(false);
                    Level3Building48.gameObject.SetActive(true);
                }
            }
			if (player6.GetComponent<FollowThePath>().transform.position == waypoints[49].transform.position) {
				GameControl.count40++;
				GameControl.own40 = 6;
                if (GameControl.count40 == 1)
                    Level1Building49.gameObject.SetActive(true);
                else if (GameControl.count40 == 2)
                {
                    Level1Building49.gameObject.SetActive(false);
                    Level2Building49.gameObject.SetActive(true);
                }
                else if (GameControl.count40 == 3)
                {
                    Level2Building49.gameObject.SetActive(false);
                    Level3Building49.gameObject.SetActive(true);
                }
            }
			if (player6.GetComponent<FollowThePath>().transform.position == waypoints[50].transform.position)
			{
				GameControl.count41++;
				GameControl.buyValue = 1;
				GameControl.own41 = 6;
			}
			if (player6.GetComponent<FollowThePath>().transform.position == waypoints[51].transform.position) {
				GameControl.count42++;
				GameControl.own42 = 6;
                if (GameControl.count42 == 1)
                    Level1Building51.gameObject.SetActive(true);
                else if (GameControl.count42 == 2)
                {
                    Level1Building51.gameObject.SetActive(false);
                    Level2Building51.gameObject.SetActive(true);
                }
                else if (GameControl.count42 == 3)
                {
                    Level2Building51.gameObject.SetActive(false);
                    Level3Building51.gameObject.SetActive(true);
                }
            }
			if (player6.GetComponent<FollowThePath>().transform.position == waypoints[52].transform.position) {
				GameControl.count43++;
				GameControl.own43 = 6;
                if (GameControl.count43 == 1)
                    Level1Building52.gameObject.SetActive(true);
                else if (GameControl.count43 == 2)
                {
                    Level1Building52.gameObject.SetActive(false);
                    Level2Building52.gameObject.SetActive(true);
                }
                else if (GameControl.count43 == 3)
                {
                    Level2Building52.gameObject.SetActive(false);
                    Level3Building52.gameObject.SetActive(true);
                }
            }
			if (player6.GetComponent<FollowThePath>().transform.position == waypoints[55].transform.position) {
				GameControl.count44++;
				GameControl.own44 = 6;
                if (GameControl.count44 == 1)
                    Level1Building55.gameObject.SetActive(true);
                else if (GameControl.count44 == 2)
                {
                    Level1Building55.gameObject.SetActive(false);
                    Level2Building55.gameObject.SetActive(true);
                }
                else if (GameControl.count44 == 3)
                {
                    Level2Building55.gameObject.SetActive(false);
                    Level3Building55.gameObject.SetActive(true);
                }
            }
			if (player6.GetComponent<FollowThePath>().transform.position == waypoints[56].transform.position) {
				GameControl.count45++;
				GameControl.own45 = 6;
                if (GameControl.count45 == 1)
                    Level1Building56.gameObject.SetActive(true);
                else if (GameControl.count45 == 2)
                {
                    Level1Building56.gameObject.SetActive(false);
                    Level2Building56.gameObject.SetActive(true);
                }
                else if (GameControl.count45 == 3)
                {
                    Level2Building56.gameObject.SetActive(false);
                    Level3Building56.gameObject.SetActive(true);
                }
            }
			if (player6.GetComponent<FollowThePath>().transform.position == waypoints[57].transform.position) {
				GameControl.count46++;
				GameControl.own46 = 6;
                if (GameControl.count46 == 1)
                    Level1Building57.gameObject.SetActive(true);
                else if (GameControl.count46 == 2)
                {
                    Level1Building57.gameObject.SetActive(false);
                    Level2Building57.gameObject.SetActive(true);
                }
                else if (GameControl.count46 == 3)
                {
                    Level2Building57.gameObject.SetActive(false);
                    Level3Building57.gameObject.SetActive(true);
                }

            }
            GameControl.ImageForBuyHouse.gameObject.SetActive(false);
            camMain();
        }

        if (GameControl.whoTurn == 7)
        {
            if (sum7 - reduce < 0)
            {
                sum7 = 0;
                buy.interactable = false;
            }
            else
            {
                sum7 -= reduce;
            }
            player7Cost.text = sum7.ToString();
			if (player7.GetComponent<FollowThePath> ().transform.position == waypoints [1].transform.position) {
				GameControl.count1++;
				GameControl.own1 = 7;
                if (GameControl.count1 == 1)
                    Level1Building1.gameObject.SetActive(true);
                else if (GameControl.count1 == 2)
                {
                    Level1Building1.gameObject.SetActive(false);
                    Level2Building1.gameObject.SetActive(true);
                }
                else if (GameControl.count1 == 3)
                {
                    Level2Building1.gameObject.SetActive(false);
                    Level3Building1.gameObject.SetActive(true);
                }
            }
			if (player7.GetComponent<FollowThePath> ().transform.position == waypoints [2].transform.position) {
				GameControl.count2++;
				GameControl.own2 = 7;
                if (GameControl.count2 == 1)
                    Level1Building2.gameObject.SetActive(true);
                else if (GameControl.count2 == 2)
                {
                    Level1Building2.gameObject.SetActive(false);
                    Level2Building2.gameObject.SetActive(true);
                }
                else if (GameControl.count2 == 3)
                {
                    Level2Building2.gameObject.SetActive(false);
                    Level3Building2.gameObject.SetActive(true);
                }
            }   
			if (player7.GetComponent<FollowThePath> ().transform.position == waypoints [3].transform.position) {
				GameControl.count3++;
				GameControl.own3 = 7;
                if (GameControl.count3 == 1)
                    Level1Building3.gameObject.SetActive(true);
                else if (GameControl.count3 == 2)
                {
                    Level1Building3.gameObject.SetActive(false);
                    Level2Building3.gameObject.SetActive(true);
                }
                else if (GameControl.count3 == 3)
                {
                    Level2Building3.gameObject.SetActive(false);
                    Level3Building3.gameObject.SetActive(true);
                }
            }  
			if (player7.GetComponent<FollowThePath>().transform.position == waypoints[4].transform.position) {
				GameControl.count4++;
				GameControl.own4 = 7;
                if (GameControl.count4 == 1)
                    Level1Building4.gameObject.SetActive(true);
                else if (GameControl.count4 == 2)
                {
                    Level1Building4.gameObject.SetActive(false);
                    Level2Building4.gameObject.SetActive(true);
                }
                else if (GameControl.count4 == 3)
                {
                    Level2Building4.gameObject.SetActive(false);
                    Level3Building4.gameObject.SetActive(true);
                }
            }   
			if (player7.GetComponent<FollowThePath>().transform.position == waypoints[5].transform.position) {
				GameControl.count5++;
				GameControl.own5 = 7;
                if (GameControl.count5 == 1)
                    Level1Building5.gameObject.SetActive(true);
                else if (GameControl.count5 == 2)
                {
                    Level1Building5.gameObject.SetActive(false);
                    Level2Building5.gameObject.SetActive(true);
                }
                else if (GameControl.count5 == 3)
                {
                    Level2Building5.gameObject.SetActive(false);
                    Level3Building5.gameObject.SetActive(true);
                }
            }   
			if (player7.GetComponent<FollowThePath> ().transform.position == waypoints [7].transform.position) {
				GameControl.count6++;
				GameControl.own6 = 7;
                if (GameControl.count6 == 1)
                    Level1Building7.gameObject.SetActive(true);
                else if (GameControl.count6 == 2)
                {
                    Level1Building7.gameObject.SetActive(false);
                    Level2Building7.gameObject.SetActive(true);
                }
                else if (GameControl.count6 == 3)
                {
                    Level2Building7.gameObject.SetActive(false);
                    Level3Building7.gameObject.SetActive(true);
                }
            }
			if (player7.GetComponent<FollowThePath> ().transform.position == waypoints [8].transform.position) {
				GameControl.count7++;
				GameControl.own7 = 7;
                if (GameControl.count7 == 1)
                    Level1Building8.gameObject.SetActive(true);
                else if (GameControl.count7 == 2)
                {
                    Level1Building8.gameObject.SetActive(false);
                    Level2Building8.gameObject.SetActive(true);
                }
                else if (GameControl.count7 == 3)
                {
                    Level2Building8.gameObject.SetActive(false);
                    Level3Building8.gameObject.SetActive(true);
                }
            }
			if (player7.GetComponent<FollowThePath> ().transform.position == waypoints [9].transform.position) {
				GameControl.count8++;
				GameControl.own8 = 7;
                if (GameControl.count8 == 1)
                    Level1Building9.gameObject.SetActive(true);
                else if (GameControl.count8 == 2)
                {
                    Level1Building9.gameObject.SetActive(false);
                    Level2Building9.gameObject.SetActive(true);
                }
                else if (GameControl.count8 == 3)
                {
                    Level2Building9.gameObject.SetActive(false);
                    Level3Building9.gameObject.SetActive(true);
                }
            }
			if (player7.GetComponent<FollowThePath>().transform.position == waypoints[10].transform.position)
			{
				GameControl.count9++;
				GameControl.buyValue = 1;
				GameControl.own9 = 7;
			}        
			if (player7.GetComponent<FollowThePath>().transform.position == waypoints[11].transform.position) {
				GameControl.count10++;
				GameControl.own10 = 7;
                if (GameControl.count10 == 1)
                    Level1Building11.gameObject.SetActive(true);
                else if (GameControl.count10 == 2)
                {
                    Level1Building11.gameObject.SetActive(false);
                    Level2Building11.gameObject.SetActive(true);
                }
                else if (GameControl.count10 == 3)
                {
                    Level2Building11.gameObject.SetActive(false);
                    Level3Building11.gameObject.SetActive(true);
                }
            }  
			if (player7.GetComponent<FollowThePath>().transform.position == waypoints[13].transform.position) {
				GameControl.count11++;
				GameControl.own11 = 7;
                if (GameControl.count11 == 1)
                    Level1Building13.gameObject.SetActive(true);
                else if (GameControl.count11 == 2)
                {
                    Level1Building13.gameObject.SetActive(false);
                    Level2Building13.gameObject.SetActive(true);
                }
                else if (GameControl.count11 == 3)
                {
                    Level2Building13.gameObject.SetActive(false);
                    Level3Building13.gameObject.SetActive(true);
                }
            }
			if (player7.GetComponent<FollowThePath>().transform.position == waypoints[14].transform.position) {
				GameControl.count12++;
				GameControl.own12 = 7;
                if (GameControl.count12 == 1)
                    Level1Building14.gameObject.SetActive(true);
                else if (GameControl.count12 == 2)
                {
                    Level1Building14.gameObject.SetActive(false);
                    Level2Building14.gameObject.SetActive(true);
                }
                else if (GameControl.count12 == 3)
                {
                    Level2Building14.gameObject.SetActive(false);
                    Level3Building14.gameObject.SetActive(true);
                }
            }
			if (player7.GetComponent<FollowThePath>().transform.position == waypoints[15].transform.position) {
				GameControl.count13++;
				GameControl.own13 = 7;
                if (GameControl.count13 == 1)
                    Level1Building15.gameObject.SetActive(true);
                else if (GameControl.count13 == 2)
                {
                    Level1Building15.gameObject.SetActive(false);
                    Level2Building15.gameObject.SetActive(true);
                }
                else if (GameControl.count13 == 3)
                {
                    Level2Building15.gameObject.SetActive(false);
                    Level3Building15.gameObject.SetActive(true);
                }
            }
			if (player7.GetComponent<FollowThePath>().transform.position == waypoints[16].transform.position)  {
				GameControl.count14++;
				GameControl.own14 = 7;
                if (GameControl.count14 == 1)
                    Level1Building16.gameObject.SetActive(true);
                else if (GameControl.count14 == 2)
                {
                    Level1Building16.gameObject.SetActive(false);
                    Level2Building16.gameObject.SetActive(true);
                }
                else if (GameControl.count14 == 3)
                {
                    Level2Building16.gameObject.SetActive(false);
                    Level3Building16.gameObject.SetActive(true);
                }
            }
			if (player7.GetComponent<FollowThePath> ().transform.position == waypoints [17].transform.position) {
				GameControl.count15++;
				GameControl.own15 = 7;
                if (GameControl.count15 == 1)
                    Level1Building17.gameObject.SetActive(true);
                else if (GameControl.count15 == 2)
                {
                    Level1Building17.gameObject.SetActive(false);
                    Level2Building17.gameObject.SetActive(true);
                }
                else if (GameControl.count15 == 3)
                {
                    Level2Building17.gameObject.SetActive(false);
                    Level3Building17.gameObject.SetActive(true);
                }
            }  
			if (player7.GetComponent<FollowThePath> ().transform.position == waypoints [19].transform.position) {
				GameControl.count16++;
				GameControl.own16 = 7;
                if (GameControl.count16 == 1)
                    Level1Building19.gameObject.SetActive(true);
                else if (GameControl.count16 == 2)
                {
                    Level1Building19.gameObject.SetActive(false);
                    Level2Building19.gameObject.SetActive(true);
                }
                else if (GameControl.count16 == 3)
                {
                    Level2Building19.gameObject.SetActive(false);
                    Level3Building19.gameObject.SetActive(true);
                }
            }
			if (player7.GetComponent<FollowThePath>().transform.position == waypoints[20].transform.position) {
				GameControl.count17++;
				GameControl.own17 = 7;
                if (GameControl.count17 == 1)
                    Level1Building20.gameObject.SetActive(true);
                else if (GameControl.count17 == 2)
                {
                    Level1Building20.gameObject.SetActive(false);
                    Level2Building20.gameObject.SetActive(true);
                }
                else if (GameControl.count17 == 3)
                {
                    Level2Building20.gameObject.SetActive(false);
                    Level3Building20.gameObject.SetActive(true);
                }
            }
			if (player7.GetComponent<FollowThePath>().transform.position == waypoints[21].transform.position)
			{
				GameControl.count18++;
				GameControl.buyValue = 1;
				GameControl.own18 = 7;
            }
			if (player7.GetComponent<FollowThePath>().transform.position == waypoints[22].transform.position) {
				GameControl.count19++;
				GameControl.own19 = 7;
                if (GameControl.count19 == 1)
                    Level1Building22.gameObject.SetActive(true);
                else if (GameControl.count19 == 2)
                {
                    Level1Building22.gameObject.SetActive(false);
                    Level2Building22.gameObject.SetActive(true);
                }
                else if (GameControl.count19 == 3)
                {
                    Level2Building22.gameObject.SetActive(false);
                    Level3Building22.gameObject.SetActive(true);
                }
            }
			if (player7.GetComponent<FollowThePath>().transform.position == waypoints[23].transform.position) {
				GameControl.count20++;
				GameControl.own20 = 7;
                if (GameControl.count20 == 1)
                    Level1Building23.gameObject.SetActive(true);
                else if (GameControl.count20 == 2)
                {
                    Level1Building23.gameObject.SetActive(false);
                    Level2Building23.gameObject.SetActive(true);
                }
                else if (GameControl.count20 == 3)
                {
                    Level2Building23.gameObject.SetActive(false);
                    Level3Building23.gameObject.SetActive(true);
                }
            }
			if (player7.GetComponent<FollowThePath>().transform.position == waypoints[24].transform.position) {
				GameControl.count21++;
				GameControl.own21 = 7;
                if (GameControl.count21 == 1)
                    Level1Building24.gameObject.SetActive(true);
                else if (GameControl.count21 == 2)
                {
                    Level1Building24.gameObject.SetActive(false);
                    Level2Building24.gameObject.SetActive(true);
                }
                else if (GameControl.count21 == 3)
                {
                    Level2Building24.gameObject.SetActive(false);
                    Level3Building24.gameObject.SetActive(true);
                }
            }
			if (player7.GetComponent<FollowThePath>().transform.position == waypoints[26].transform.position) {
				GameControl.count22++;
				GameControl.own22 = 7;
                if (GameControl.count22 == 1)
                    Level1Building26.gameObject.SetActive(true);
                else if (GameControl.count22 == 2)
                {
                    Level1Building26.gameObject.SetActive(false);
                    Level2Building26.gameObject.SetActive(true);
                }
                else if (GameControl.count22 == 3)
                {
                    Level2Building26.gameObject.SetActive(false);
                    Level3Building26.gameObject.SetActive(true);
                }
            }
			if (player7.GetComponent<FollowThePath>().transform.position == waypoints[27].transform.position) {
				GameControl.count23++;
				GameControl.own23 = 7;
                if (GameControl.count23 == 1)
                    Level1Building27.gameObject.SetActive(true);
                else if (GameControl.count23 == 2)
                {
                    Level1Building27.gameObject.SetActive(false);
                    Level2Building27.gameObject.SetActive(true);
                }
                else if (GameControl.count23 == 3)
                {
                    Level2Building27.gameObject.SetActive(false);
                    Level3Building27.gameObject.SetActive(true);
                }
            }
			if (player7.GetComponent<FollowThePath>().transform.position == waypoints[28].transform.position) {
				GameControl.count24++;
				GameControl.own24 = 7;
                if (GameControl.count24 == 1)
                    Level1Building28.gameObject.SetActive(true);
                else if (GameControl.count24 == 2)
                {
                    Level1Building28.gameObject.SetActive(false);
                    Level2Building28.gameObject.SetActive(true);
                }
                else if (GameControl.count24 == 3)
                {
                    Level2Building28.gameObject.SetActive(false);
                    Level3Building28.gameObject.SetActive(true);
                }
            }
			if (player7.GetComponent<FollowThePath>().transform.position == waypoints[29].transform.position) {
				GameControl.count25++;
				GameControl.own25 = 7;
                if (GameControl.count25== 1)
                    Level1Building29.gameObject.SetActive(true);
                else if (GameControl.count25 == 2)
                {
                    Level1Building29.gameObject.SetActive(false);
                    Level2Building29.gameObject.SetActive(true);
                }
                else if (GameControl.count25 == 3)
                {
                    Level2Building29.gameObject.SetActive(false);
                    Level3Building29.gameObject.SetActive(true);
                }
            }
			if (player7.GetComponent<FollowThePath>().transform.position == waypoints[31].transform.position) {
				GameControl.count26++;
				GameControl.own26 = 7;
                if (GameControl.count26 == 1)
                    Level1Building31.gameObject.SetActive(true);
                else if (GameControl.count26 == 2)
                {
                    Level1Building31.gameObject.SetActive(false);
                    Level2Building31.gameObject.SetActive(true);
                }
                else if (GameControl.count26 == 3)
                {
                    Level2Building31.gameObject.SetActive(false);
                    Level3Building31.gameObject.SetActive(true);
                }
            }
			if (player7.GetComponent<FollowThePath>().transform.position == waypoints[32].transform.position) {
				GameControl.count27++;
				GameControl.own27 = 7;
                if (GameControl.count27 == 1)
                    Level1Building32.gameObject.SetActive(true);
                else if (GameControl.count27 == 2)
                {
                    Level1Building32.gameObject.SetActive(false);
                    Level2Building32.gameObject.SetActive(true);
                }
                else if (GameControl.count27 == 3)
                {
                    Level2Building32.gameObject.SetActive(false);
                    Level3Building32.gameObject.SetActive(true);
                }
            }
			if (player7.GetComponent<FollowThePath>().transform.position == waypoints[33].transform.position) {
				GameControl.count28++;
				GameControl.own28 = 7;
                if (GameControl.count28== 1)
                    Level1Building33.gameObject.SetActive(true);
                else if (GameControl.count28 == 2)
                {
                    Level1Building33.gameObject.SetActive(false);
                    Level2Building33.gameObject.SetActive(true);
                }
                else if (GameControl.count28 == 3)
                {
                    Level2Building33.gameObject.SetActive(false);
                    Level3Building33.gameObject.SetActive(true);
                }
            }
			if (player7.GetComponent<FollowThePath>().transform.position == waypoints[34].transform.position) {
				GameControl.count29++;
				GameControl.own29 = 7;
                if (GameControl.count29 == 1)
                    Level1Building34.gameObject.SetActive(true);
                else if (GameControl.count29 == 2)
                {
                    Level1Building34.gameObject.SetActive(false);
                    Level2Building34.gameObject.SetActive(true);
                }
                else if (GameControl.count29 == 3)
                {
                    Level2Building34.gameObject.SetActive(false);
                    Level3Building34.gameObject.SetActive(true);
                }
            }
			if (player7.GetComponent<FollowThePath>().transform.position == waypoints[36].transform.position) {
				GameControl.count30++;
				GameControl.own30 = 7;
                if (GameControl.count30 == 1)
                    Level1Building36.gameObject.SetActive(true);
                else if (GameControl.count30 == 2)
                {
                    Level1Building36.gameObject.SetActive(false);
                    Level2Building36.gameObject.SetActive(true);
                }
                else if (GameControl.count30 == 3)
                {
                    Level2Building36.gameObject.SetActive(false);
                    Level3Building36.gameObject.SetActive(true);
                }
            }
			if (player7.GetComponent<FollowThePath>().transform.position == waypoints[37].transform.position) {
				GameControl.count31++;
				GameControl.own31 = 7;
                if (GameControl.count31 == 1)
                    Level1Building37.gameObject.SetActive(true);
                else if (GameControl.count31 == 2)
                {
                    Level1Building37.gameObject.SetActive(false);
                    Level2Building37.gameObject.SetActive(true);
                }
                else if (GameControl.count31 == 3)
                {
                    Level2Building37.gameObject.SetActive(false);
                    Level3Building37.gameObject.SetActive(true);
                }
            }
			if (player7.GetComponent<FollowThePath>().transform.position == waypoints[38].transform.position)
			{
				GameControl.count32++;
				GameControl.buyValue = 1;
				GameControl.own32 = 7;
			}  
			if (player7.GetComponent<FollowThePath>().transform.position == waypoints[39].transform.position) {
				GameControl.count33++;
				GameControl.own33 = 7;
                if (GameControl.count33 == 1)
                    Level1Building39.gameObject.SetActive(true);
                else if (GameControl.count33 == 2)
                {
                    Level1Building39.gameObject.SetActive(false);
                    Level2Building39.gameObject.SetActive(true);
                }
                else if (GameControl.count33 == 3)
                {
                    Level2Building39.gameObject.SetActive(false);
                    Level3Building39.gameObject.SetActive(true);
                }
            }
			if (player7.GetComponent<FollowThePath>().transform.position == waypoints[40].transform.position) {
				GameControl.count34++;
				GameControl.own34 = 7;
                if (GameControl.count34 == 1)
                    Level1Building40.gameObject.SetActive(true);
                else if (GameControl.count34 == 2)
                {
                    Level1Building40.gameObject.SetActive(false);
                    Level2Building40.gameObject.SetActive(true);
                }
                else if (GameControl.count34 == 3)
                {
                    Level2Building40.gameObject.SetActive(false);
                    Level3Building40.gameObject.SetActive(true);
                }
            }
			if (player7.GetComponent<FollowThePath>().transform.position == waypoints[42].transform.position) {
				GameControl.count35++;
				GameControl.own35 = 7;
                if (GameControl.count35 == 1)
                    Level1Building42.gameObject.SetActive(true);
                else if (GameControl.count35 == 2)
                {
                    Level1Building42.gameObject.SetActive(false);
                    Level2Building42.gameObject.SetActive(true);
                }
                else if (GameControl.count35 == 3)
                {
                    Level2Building42.gameObject.SetActive(false);
                    Level3Building42.gameObject.SetActive(true);
                }
            }
			if (player7.GetComponent<FollowThePath>().transform.position == waypoints[43].transform.position) {
				GameControl.count36++;
				GameControl.own36 = 7;
                if (GameControl.count36 == 1)
                    Level1Building43.gameObject.SetActive(true);
                else if (GameControl.count36 == 2)
                {
                    Level1Building43.gameObject.SetActive(false);
                    Level2Building43.gameObject.SetActive(true);
                }
                else if (GameControl.count36 == 3)
                {
                    Level2Building43.gameObject.SetActive(false);
                    Level3Building43.gameObject.SetActive(true);
                }
            }
			if (player7.GetComponent<FollowThePath>().transform.position == waypoints[44].transform.position) {
				GameControl.count37++;
				GameControl.own37 = 7;
                if (GameControl.count37 == 1)
                    Level1Building44.gameObject.SetActive(true);
                else if (GameControl.count37 == 2)
                {
                    Level1Building44.gameObject.SetActive(false);
                    Level2Building44.gameObject.SetActive(true);
                }
                else if (GameControl.count37 == 3)
                {
                    Level2Building44.gameObject.SetActive(false);
                    Level3Building44.gameObject.SetActive(true);
                }
            }
			if (player7.GetComponent<FollowThePath>().transform.position == waypoints[47].transform.position) {
				GameControl.count38++;
				GameControl.own38 = 7;
                if (GameControl.count38 == 1)
                    Level1Building47.gameObject.SetActive(true);
                else if (GameControl.count38 == 2)
                {
                    Level1Building47.gameObject.SetActive(false);
                    Level2Building47.gameObject.SetActive(true);
                }
                else if (GameControl.count38 == 3)
                {
                    Level2Building47.gameObject.SetActive(false);
                    Level3Building47.gameObject.SetActive(true);
                }
            }
			if (player7.GetComponent<FollowThePath>().transform.position == waypoints[48].transform.position) {
				GameControl.count39++;
				GameControl.own39 = 7;
                if (GameControl.count39 == 1)
                    Level1Building48.gameObject.SetActive(true);
                else if (GameControl.count39 == 2)
                {
                    Level1Building48.gameObject.SetActive(false);
                    Level2Building48.gameObject.SetActive(true);
                }
                else if (GameControl.count39 == 3)
                {
                    Level2Building48.gameObject.SetActive(false);
                    Level3Building48.gameObject.SetActive(true);
                }
            }
			if (player7.GetComponent<FollowThePath>().transform.position == waypoints[49].transform.position) {
				GameControl.count40++;
				GameControl.own40 = 7;
                if (GameControl.count40 == 1)
                    Level1Building49.gameObject.SetActive(true);
                else if (GameControl.count40 == 2)
                {
                    Level1Building49.gameObject.SetActive(false);
                    Level2Building49.gameObject.SetActive(true);
                }
                else if (GameControl.count40 == 3)
                {
                    Level2Building49.gameObject.SetActive(false);
                    Level3Building49.gameObject.SetActive(true);
                }
            }
			if (player7.GetComponent<FollowThePath>().transform.position == waypoints[50].transform.position)
			{
				GameControl.count41++;
				GameControl.buyValue = 1;
				GameControl.own41 = 7;
            }
			if (player7.GetComponent<FollowThePath>().transform.position == waypoints[51].transform.position) {
				GameControl.count42++;
				GameControl.own42 = 7;
                if (GameControl.count42 == 1)
                    Level1Building51.gameObject.SetActive(true);
                else if (GameControl.count42 == 2)
                {
                    Level1Building51.gameObject.SetActive(false);
                    Level2Building51.gameObject.SetActive(true);
                }
                else if (GameControl.count42 == 3)
                {
                    Level2Building51.gameObject.SetActive(false);
                    Level3Building51.gameObject.SetActive(true);
                }
            }
			if (player7.GetComponent<FollowThePath>().transform.position == waypoints[52].transform.position) {
				GameControl.count43++;
				GameControl.own43 = 7;
                if (GameControl.count43 == 1)
                    Level1Building52.gameObject.SetActive(true);
                else if (GameControl.count43 == 2)
                {
                    Level1Building52.gameObject.SetActive(false);
                    Level2Building52.gameObject.SetActive(true);
                }
                else if (GameControl.count43 == 3)
                {
                    Level2Building52.gameObject.SetActive(false);
                    Level3Building52.gameObject.SetActive(true);
                }
            }
			if (player7.GetComponent<FollowThePath>().transform.position == waypoints[55].transform.position) {
				GameControl.count44++;
				GameControl.own44 = 7;
                if (GameControl.count44 == 1)
                    Level1Building55.gameObject.SetActive(true);
                else if (GameControl.count44 == 2)
                {
                    Level1Building55.gameObject.SetActive(false);
                    Level2Building55.gameObject.SetActive(true);
                }
                else if (GameControl.count44 == 3)
                {
                    Level2Building55.gameObject.SetActive(false);
                    Level3Building55.gameObject.SetActive(true);
                }
            }
			if (player7.GetComponent<FollowThePath>().transform.position == waypoints[56].transform.position) {
				GameControl.count45++;
				GameControl.own45 = 7;
                if (GameControl.count45 == 1)
                    Level1Building56.gameObject.SetActive(true);
                else if (GameControl.count45 == 2)
                {
                    Level1Building56.gameObject.SetActive(false);
                    Level2Building56.gameObject.SetActive(true);
                }
                else if (GameControl.count45 == 3)
                {
                    Level2Building56.gameObject.SetActive(false);
                    Level3Building56.gameObject.SetActive(true);
                }
            }
			if (player7.GetComponent<FollowThePath>().transform.position == waypoints[57].transform.position) {
				GameControl.count46++;
				GameControl.own46 = 7;
                if (GameControl.count46 == 1)
                    Level1Building57.gameObject.SetActive(true);

                else if (GameControl.count46 == 2)
                {
                    Level1Building57.gameObject.SetActive(false);
                    Level2Building57.gameObject.SetActive(true);
                }
                else if (GameControl.count46 == 3)
                {
                    Level2Building57.gameObject.SetActive(false);
                    Level3Building57.gameObject.SetActive(true);
                }
            }
            GameControl.ImageForBuyHouse.gameObject.SetActive(false);
            camMain();
        }

        if (GameControl.whoTurn == 8)
        {
            if (sum8 - reduce < 0)
            {
                sum8 = 0;
                buy.interactable = false;
            }
            else
            {
                sum8 -= reduce;
            }
            player8Cost.text = sum8.ToString();
			if (player8.GetComponent<FollowThePath> ().transform.position == waypoints [1].transform.position) {
				GameControl.count1++;
				GameControl.own1 = 8;
                if (GameControl.count1 == 1)
                    Level1Building1.gameObject.SetActive(true);
                else if (GameControl.count1 == 2)
                {
                    Level1Building1.gameObject.SetActive(false);
                    Level2Building1.gameObject.SetActive(true);
                }
                else if (GameControl.count1 == 3)
                {
                    Level2Building1.gameObject.SetActive(false);
                    Level3Building1.gameObject.SetActive(true);
                }
            }
			if (player8.GetComponent<FollowThePath> ().transform.position == waypoints [2].transform.position) {
				GameControl.count2++;
				GameControl.own2 = 8;
                if (GameControl.count2 == 1)
                    Level1Building2.gameObject.SetActive(true);
                else if (GameControl.count2 == 2)
                {
                    Level1Building2.gameObject.SetActive(false);
                    Level2Building2.gameObject.SetActive(true);
                }
                else if (GameControl.count2 == 3)
                {
                    Level2Building2.gameObject.SetActive(false);
                    Level3Building2.gameObject.SetActive(true);
                }
            }   
			if (player8.GetComponent<FollowThePath> ().transform.position == waypoints [3].transform.position) {
				GameControl.count3++;
				GameControl.own3 = 8;
                if (GameControl.count3 == 1)
                    Level1Building3.gameObject.SetActive(true);
                else if (GameControl.count3 == 2)
                {
                    Level1Building3.gameObject.SetActive(false);
                    Level2Building3.gameObject.SetActive(true);
                }
                else if (GameControl.count3 == 3)
                {
                    Level2Building3.gameObject.SetActive(false);
                    Level3Building3.gameObject.SetActive(true);
                }
            }  
			if (player8.GetComponent<FollowThePath>().transform.position == waypoints[4].transform.position) {
				GameControl.count4++;
				GameControl.own4 = 8;
                if (GameControl.count4 == 1)
                    Level1Building4.gameObject.SetActive(true);
                else if (GameControl.count4 == 2)
                {
                    Level1Building4.gameObject.SetActive(false);
                    Level2Building4.gameObject.SetActive(true);
                }
                else if (GameControl.count4 == 3)
                {
                    Level2Building4.gameObject.SetActive(false);
                    Level3Building4.gameObject.SetActive(true);
                }
            }   
			if (player8.GetComponent<FollowThePath>().transform.position == waypoints[5].transform.position) {
				GameControl.count5++;
				GameControl.own5 = 8;
                if (GameControl.count5 == 1)
                    Level1Building5.gameObject.SetActive(true);
                else if (GameControl.count5 == 2)
                {
                    Level1Building5.gameObject.SetActive(false);
                    Level2Building5.gameObject.SetActive(true);
                }
                else if (GameControl.count5 == 3)
                {
                    Level2Building5.gameObject.SetActive(false);
                    Level3Building5.gameObject.SetActive(true);
                }
            }   
			if (player8.GetComponent<FollowThePath> ().transform.position == waypoints [7].transform.position) {
				GameControl.count6++;
				GameControl.own6 = 8;
                if (GameControl.count6 == 1)
                    Level1Building7.gameObject.SetActive(true);
                else if (GameControl.count6 == 2)
                {
                    Level1Building7.gameObject.SetActive(false);
                    Level2Building7.gameObject.SetActive(true);
                }
                else if (GameControl.count6 == 3)
                {
                    Level2Building7.gameObject.SetActive(false);
                    Level3Building7.gameObject.SetActive(true);
                }
            }
			if (player8.GetComponent<FollowThePath> ().transform.position == waypoints [8].transform.position) {
				GameControl.count7++;
				GameControl.own7 = 8;
                if (GameControl.count7 == 1)
                    Level1Building8.gameObject.SetActive(true);
                else if (GameControl.count7 == 2)
                {
                    Level1Building8.gameObject.SetActive(false);
                    Level2Building8.gameObject.SetActive(true);
                }
                else if (GameControl.count7 == 3)
                {
                    Level2Building8.gameObject.SetActive(false);
                    Level3Building8.gameObject.SetActive(true);
                }
            }
			if (player8.GetComponent<FollowThePath> ().transform.position == waypoints [9].transform.position) {
				GameControl.count8++;
				GameControl.own8 = 8;
                if (GameControl.count8 == 1)
                    Level1Building9.gameObject.SetActive(true);
                else if (GameControl.count8 == 2)
                {
                    Level1Building9.gameObject.SetActive(false);
                    Level2Building9.gameObject.SetActive(true);
                }
                else if (GameControl.count8 == 3)
                {
                    Level2Building9.gameObject.SetActive(false);
                    Level3Building9.gameObject.SetActive(true);
                }
            }
			if (player8.GetComponent<FollowThePath>().transform.position == waypoints[10].transform.position)
			{
				GameControl.count9++;
				GameControl.buyValue = 1;
				GameControl.own9 = 8;

			}        
			if (player8.GetComponent<FollowThePath>().transform.position == waypoints[11].transform.position) {
				GameControl.count10++;
				GameControl.own10 = 8;
                if (GameControl.count10 == 1)
                    Level1Building11.gameObject.SetActive(true);
                else if (GameControl.count10 == 2)
                {
                    Level1Building11.gameObject.SetActive(false);
                    Level2Building11.gameObject.SetActive(true);
                }
                else if (GameControl.count10 == 3)
                {
                    Level2Building11.gameObject.SetActive(false);
                    Level3Building11.gameObject.SetActive(true);
                }
            }  
			if (player8.GetComponent<FollowThePath>().transform.position == waypoints[13].transform.position) {
				GameControl.count11++;
				GameControl.own11 = 8;
                if (GameControl.count11 == 1)
                    Level1Building13.gameObject.SetActive(true);
                else if (GameControl.count11 == 2)
                {
                    Level1Building13.gameObject.SetActive(false);
                    Level2Building13.gameObject.SetActive(true);
                }
                else if (GameControl.count11 == 3)
                {
                    Level2Building13.gameObject.SetActive(false);
                    Level3Building13.gameObject.SetActive(true);
                }
            }
			if (player8.GetComponent<FollowThePath>().transform.position == waypoints[14].transform.position) {
				GameControl.count12++;
				GameControl.own12 = 8;
                if (GameControl.count12 == 1)
                    Level1Building14.gameObject.SetActive(true);
                else if (GameControl.count12 == 2)
                {
                    Level1Building14.gameObject.SetActive(false);
                    Level2Building14.gameObject.SetActive(true);
                }
                else if (GameControl.count12 == 3)
                {
                    Level2Building14.gameObject.SetActive(false);
                    Level3Building14.gameObject.SetActive(true);
                }
            }
			if (player8.GetComponent<FollowThePath>().transform.position == waypoints[15].transform.position) {
				GameControl.count13++;
				GameControl.own13 = 8;
                if (GameControl.count13 == 1)
                    Level1Building15.gameObject.SetActive(true);
                else if (GameControl.count13 == 2)
                {
                    Level1Building15.gameObject.SetActive(false);
                    Level2Building15.gameObject.SetActive(true);
                }
                else if (GameControl.count13 == 3)
                {
                    Level2Building15.gameObject.SetActive(false);
                    Level3Building15.gameObject.SetActive(true);
                }
            }
			if (player8.GetComponent<FollowThePath>().transform.position == waypoints[16].transform.position)  {
				GameControl.count14++;
				GameControl.own14 = 8;
                if (GameControl.count14 == 1)
                    Level1Building16.gameObject.SetActive(true);
                else if (GameControl.count14 == 2)
                {
                    Level1Building16.gameObject.SetActive(false);
                    Level2Building16.gameObject.SetActive(true);
                }
                else if (GameControl.count14 == 3)
                {
                    Level2Building16.gameObject.SetActive(false);
                    Level3Building16.gameObject.SetActive(true);
                }

            }
			if (player8.GetComponent<FollowThePath> ().transform.position == waypoints [17].transform.position) {
				GameControl.count15++;
				GameControl.own15 = 8;
                if (GameControl.count15 == 1)
                    Level1Building17.gameObject.SetActive(true);
                else if (GameControl.count15 == 2)
                {
                    Level1Building17.gameObject.SetActive(false);
                    Level2Building17.gameObject.SetActive(true);
                }
                else if (GameControl.count15 == 3)
                {
                    Level2Building17.gameObject.SetActive(false);
                    Level3Building17.gameObject.SetActive(true);
                }
            }  
			if (player8.GetComponent<FollowThePath> ().transform.position == waypoints [19].transform.position) {
				GameControl.count16++;
				GameControl.own16 = 8;
                if (GameControl.count16 == 1)
                    Level1Building19.gameObject.SetActive(true);
                else if (GameControl.count16 == 2)
                {
                    Level1Building19.gameObject.SetActive(false);
                    Level2Building19.gameObject.SetActive(true);
                }
                else if (GameControl.count16 == 3)
                {
                    Level2Building19.gameObject.SetActive(false);
                    Level3Building19.gameObject.SetActive(true);
                }
            }
			if (player8.GetComponent<FollowThePath>().transform.position == waypoints[20].transform.position) {
				GameControl.count17++;
				GameControl.own17 = 8;
                if (GameControl.count17 == 1)
                    Level1Building20.gameObject.SetActive(true);
                else if (GameControl.count17 == 2)
                {
                    Level1Building20.gameObject.SetActive(false);
                    Level2Building20.gameObject.SetActive(true);
                }
                else if (GameControl.count17 == 3)
                {
                    Level2Building20.gameObject.SetActive(false);
                    Level3Building20.gameObject.SetActive(true);
                }
            }
			if (player8.GetComponent<FollowThePath>().transform.position == waypoints[21].transform.position)
			{
				GameControl.count18++;
				GameControl.buyValue = 1;
				GameControl.own18 = 8;
			}
			if (player8.GetComponent<FollowThePath>().transform.position == waypoints[22].transform.position) {
				GameControl.count19++;
				GameControl.own19 = 8;
                if (GameControl.count19 == 1)
                    Level1Building22.gameObject.SetActive(true);
                else if (GameControl.count19 == 2)
                {
                    Level1Building22.gameObject.SetActive(false);
                    Level2Building22.gameObject.SetActive(true);
                }
                else if (GameControl.count19 == 3)
                {
                    Level2Building22.gameObject.SetActive(false);
                    Level3Building22.gameObject.SetActive(true);
                }
            }
			if (player8.GetComponent<FollowThePath>().transform.position == waypoints[23].transform.position) {
				GameControl.count20++;
				GameControl.own20 = 8;
                if (GameControl.count20 == 1)
                    Level1Building23.gameObject.SetActive(true);
                else if (GameControl.count20 == 2)
                {
                    Level1Building23.gameObject.SetActive(false);
                    Level2Building23.gameObject.SetActive(true);
                }
                else if (GameControl.count20 == 3)
                {
                    Level2Building23.gameObject.SetActive(false);
                    Level3Building23.gameObject.SetActive(true);
                }
            }
			if (player8.GetComponent<FollowThePath>().transform.position == waypoints[24].transform.position) {
				GameControl.count21++;
				GameControl.own21 = 8;
                if (GameControl.count21 == 1)
                    Level1Building24.gameObject.SetActive(true);
                else if (GameControl.count21 == 2)
                {
                    Level1Building24.gameObject.SetActive(false);
                    Level2Building24.gameObject.SetActive(true);
                }
                else if (GameControl.count21 == 3)
                {
                    Level2Building24.gameObject.SetActive(false);
                    Level3Building24.gameObject.SetActive(true);
                }
            }
			if (player8.GetComponent<FollowThePath>().transform.position == waypoints[26].transform.position) {
				GameControl.count22++;
				GameControl.own22 = 8;
                if (GameControl.count22 == 1)
                    Level1Building26.gameObject.SetActive(true);
                else if (GameControl.count22 == 2)
                {
                    Level1Building26.gameObject.SetActive(false);
                    Level2Building26.gameObject.SetActive(true);
                }
                else if (GameControl.count22 == 3)
                {
                    Level2Building26.gameObject.SetActive(false);
                    Level3Building26.gameObject.SetActive(true);
                }
            }
			if (player8.GetComponent<FollowThePath>().transform.position == waypoints[27].transform.position) {
				GameControl.count23++;
				GameControl.own23 = 8;
                if (GameControl.count23 == 1)
                    Level1Building27.gameObject.SetActive(true);
                else if (GameControl.count23 == 2)
                {
                    Level1Building27.gameObject.SetActive(false);
                    Level2Building27.gameObject.SetActive(true);
                }
                else if (GameControl.count23 == 3)
                {
                    Level2Building27.gameObject.SetActive(false);
                    Level3Building27.gameObject.SetActive(true);
                }
            }
			if (player8.GetComponent<FollowThePath>().transform.position == waypoints[28].transform.position) {
				GameControl.count24++;
				GameControl.own24 = 8;
                if (GameControl.count24 == 1)
                    Level1Building28.gameObject.SetActive(true);
                else if (GameControl.count24 == 2)
                {
                    Level1Building28.gameObject.SetActive(false);
                    Level2Building28.gameObject.SetActive(true);
                }
                else if (GameControl.count24 == 3)
                {
                    Level2Building28.gameObject.SetActive(false);
                    Level3Building28.gameObject.SetActive(true);
                }
            }
			if (player8.GetComponent<FollowThePath>().transform.position == waypoints[29].transform.position) {
				GameControl.count25++;
				GameControl.own25 = 8;
                if (GameControl.count25 == 1)
                    Level1Building29.gameObject.SetActive(true);
                else if (GameControl.count25 == 2)
                {
                    Level1Building29.gameObject.SetActive(false);
                    Level2Building29.gameObject.SetActive(true);
                }
                else if (GameControl.count25 == 3)
                {
                    Level2Building29.gameObject.SetActive(false);
                    Level3Building29.gameObject.SetActive(true);
                }
            }
			if (player8.GetComponent<FollowThePath>().transform.position == waypoints[31].transform.position) {
				GameControl.count26++;
				GameControl.own26 = 8;
                if (GameControl.count26 == 1)
                    Level1Building31.gameObject.SetActive(true);
                else if (GameControl.count26 == 2)
                {
                    Level1Building31.gameObject.SetActive(false);
                    Level2Building31.gameObject.SetActive(true);
                }
                else if (GameControl.count26 == 3)
                {
                    Level2Building31.gameObject.SetActive(false);
                    Level3Building31.gameObject.SetActive(true);
                }
            }
			if (player8.GetComponent<FollowThePath>().transform.position == waypoints[32].transform.position) {
				GameControl.count27++;
				GameControl.own27 = 8;
                if (GameControl.count27 == 1)
                    Level1Building32.gameObject.SetActive(true);
                else if (GameControl.count27 == 2)
                {
                    Level1Building32.gameObject.SetActive(false);
                    Level2Building32.gameObject.SetActive(true);
                }
                else if (GameControl.count27 == 3)
                {
                    Level2Building32.gameObject.SetActive(false);
                    Level3Building32.gameObject.SetActive(true);
                }
            }
			if (player8.GetComponent<FollowThePath>().transform.position == waypoints[33].transform.position) {
				GameControl.count28++;
				GameControl.own28 = 8;
                if (GameControl.count28 == 1)
                    Level1Building33.gameObject.SetActive(true);
                else if (GameControl.count28 == 2)
                {
                    Level1Building33.gameObject.SetActive(false);
                    Level2Building33.gameObject.SetActive(true);
                }
                else if (GameControl.count28 == 3)
                {
                    Level2Building33.gameObject.SetActive(false);
                    Level3Building33.gameObject.SetActive(true);
                }
            }
			if (player8.GetComponent<FollowThePath>().transform.position == waypoints[34].transform.position) {
				GameControl.count29++;
				GameControl.own29 = 8;
                if (GameControl.count29 == 1)
                    Level1Building34.gameObject.SetActive(true);
                else if (GameControl.count29 == 2)
                {
                    Level1Building34.gameObject.SetActive(false);
                    Level2Building34.gameObject.SetActive(true);
                }
                else if (GameControl.count29 == 3)
                {
                    Level2Building34.gameObject.SetActive(false);
                    Level3Building34.gameObject.SetActive(true);
                }
            }
			if (player8.GetComponent<FollowThePath>().transform.position == waypoints[36].transform.position) {
				GameControl.count30++;
				GameControl.own30 = 8;
                if (GameControl.count30 == 1)
                    Level1Building36.gameObject.SetActive(true);
                else if (GameControl.count30 == 2)
                {
                    Level1Building36.gameObject.SetActive(false);
                    Level2Building36.gameObject.SetActive(true);
                }
                else if (GameControl.count30 == 3)
                {
                    Level2Building36.gameObject.SetActive(false);
                    Level3Building36.gameObject.SetActive(true);
                }
            }
			if (player8.GetComponent<FollowThePath>().transform.position == waypoints[37].transform.position) {
				GameControl.count31++;
				GameControl.own31 = 8;
                if (GameControl.count31 == 1)
                    Level1Building37.gameObject.SetActive(true);
                else if (GameControl.count31 == 2)
                {
                    Level1Building37.gameObject.SetActive(false);
                    Level2Building37.gameObject.SetActive(true);
                }
                else if (GameControl.count31 == 3)
                {
                    Level2Building37.gameObject.SetActive(false);
                    Level3Building37.gameObject.SetActive(true);
                }
            }
			if (player8.GetComponent<FollowThePath>().transform.position == waypoints[38].transform.position)
			{
				GameControl.count32++;
				GameControl.buyValue = 1;
				GameControl.own32 = 8;
			}  
			if (player8.GetComponent<FollowThePath>().transform.position == waypoints[39].transform.position) {
				GameControl.count33++;
				GameControl.own33 = 8;
                if (GameControl.count33== 1)
                    Level1Building39.gameObject.SetActive(true);
                else if (GameControl.count33 == 2)
                {
                    Level1Building39.gameObject.SetActive(false);
                    Level2Building39.gameObject.SetActive(true);
                }
                else if (GameControl.count33 == 3)
                {
                    Level2Building39.gameObject.SetActive(false);
                    Level3Building39.gameObject.SetActive(true);
                }
            }
			if (player8.GetComponent<FollowThePath>().transform.position == waypoints[40].transform.position) {
				GameControl.count34++;
				GameControl.own34 = 8;
                if (GameControl.count34 == 1)
                    Level1Building40.gameObject.SetActive(true);
                else if (GameControl.count34 == 2)
                {
                    Level1Building40.gameObject.SetActive(false);
                    Level2Building40.gameObject.SetActive(true);
                }
                else if (GameControl.count34 == 3)
                {
                    Level2Building40.gameObject.SetActive(false);
                    Level3Building40.gameObject.SetActive(true);
                }
            }
			if (player8.GetComponent<FollowThePath>().transform.position == waypoints[42].transform.position) {
				GameControl.count35++;
				GameControl.own35 = 8;
                if (GameControl.count35 == 1)
                    Level1Building42.gameObject.SetActive(true);
                else if (GameControl.count35 == 2)
                {
                    Level1Building42.gameObject.SetActive(false);
                    Level2Building42.gameObject.SetActive(true);
                }
                else if (GameControl.count35 == 3)
                {
                    Level2Building42.gameObject.SetActive(false);
                    Level3Building42.gameObject.SetActive(true);
                }
            }
			if (player8.GetComponent<FollowThePath>().transform.position == waypoints[43].transform.position) {
				GameControl.count36++;
				GameControl.own36 = 8;
                if (GameControl.count36 == 1)
                    Level1Building43.gameObject.SetActive(true);
                else if (GameControl.count36 == 2)
                {
                    Level1Building43.gameObject.SetActive(false);
                    Level2Building43.gameObject.SetActive(true);
                }
                else if (GameControl.count36 == 3)
                {
                    Level2Building43.gameObject.SetActive(false);
                    Level3Building43.gameObject.SetActive(true);
                }

            }
			if (player8.GetComponent<FollowThePath>().transform.position == waypoints[44].transform.position) {
				GameControl.count37++;
				GameControl.own37 = 8;
                if (GameControl.count37 == 1)
                    Level1Building44.gameObject.SetActive(true);
                else if (GameControl.count37 == 2)
                {
                    Level1Building44.gameObject.SetActive(false);
                    Level2Building44.gameObject.SetActive(true);
                }
                else if (GameControl.count37 == 3)
                {
                    Level2Building44.gameObject.SetActive(false);
                    Level3Building44.gameObject.SetActive(true);
                }
            }
			if (player8.GetComponent<FollowThePath>().transform.position == waypoints[47].transform.position) {
				GameControl.count38++;
				GameControl.own38 = 8;
                if (GameControl.count38 == 1)
                    Level1Building47.gameObject.SetActive(true);
                else if (GameControl.count38 == 2)
                {
                    Level1Building47.gameObject.SetActive(false);
                    Level2Building47.gameObject.SetActive(true);
                }
                else if (GameControl.count38 == 3)
                {
                    Level2Building47.gameObject.SetActive(false);
                    Level3Building47.gameObject.SetActive(true);
                }
            }
			if (player8.GetComponent<FollowThePath>().transform.position == waypoints[48].transform.position) {
				GameControl.count39++;
				GameControl.own39 = 8;
                if (GameControl.count39 == 1)
                    Level1Building48.gameObject.SetActive(true);
                else if (GameControl.count39 == 2)
                {
                    Level1Building48.gameObject.SetActive(false);
                    Level2Building48.gameObject.SetActive(true);
                }
                else if (GameControl.count39 == 3)
                {
                    Level2Building48.gameObject.SetActive(false);
                    Level3Building48.gameObject.SetActive(true);
                }
            }
			if (player8.GetComponent<FollowThePath>().transform.position == waypoints[49].transform.position) {
				GameControl.count40++;
				GameControl.own40 = 8;
                if (GameControl.count40 == 1)
                    Level1Building49.gameObject.SetActive(true);
                else if (GameControl.count40 == 2)
                {
                    Level1Building49.gameObject.SetActive(false);
                    Level2Building49.gameObject.SetActive(true);
                }
                else if (GameControl.count40 == 3)
                {
                    Level2Building49.gameObject.SetActive(false);
                    Level3Building49.gameObject.SetActive(true);
                }
            }
			if (player8.GetComponent<FollowThePath>().transform.position == waypoints[50].transform.position)
			{
				GameControl.count41++;
				GameControl.buyValue = 1;
				GameControl.own41 = 8;
            }
			if (player8.GetComponent<FollowThePath>().transform.position == waypoints[51].transform.position) {
				GameControl.count42++;
				GameControl.own42 = 8;
                if (GameControl.count42 == 1)
                    Level1Building51.gameObject.SetActive(true);
                else if (GameControl.count42 == 2)
                {
                    Level1Building51.gameObject.SetActive(false);
                    Level2Building51.gameObject.SetActive(true);
                }
                else if (GameControl.count42 == 3)
                {
                    Level2Building51.gameObject.SetActive(false);
                    Level3Building51.gameObject.SetActive(true);
                }
            }
			if (player8.GetComponent<FollowThePath>().transform.position == waypoints[52].transform.position) {
				GameControl.count43++;
				GameControl.own43 = 8;
                if (GameControl.count43 == 1)
                    Level1Building52.gameObject.SetActive(true);
                else if (GameControl.count43 == 2)
                {
                    Level1Building52.gameObject.SetActive(false);
                    Level2Building52.gameObject.SetActive(true);
                }
                else if (GameControl.count43 == 3)
                {
                    Level2Building52.gameObject.SetActive(false);
                    Level3Building52.gameObject.SetActive(true);
                }

            }
			if (player8.GetComponent<FollowThePath>().transform.position == waypoints[55].transform.position) {
				GameControl.count44++;
				GameControl.own44 = 8;
                if (GameControl.count44 == 1)
                    Level1Building55.gameObject.SetActive(true);
                else if (GameControl.count44 == 2)
                {
                    Level1Building55.gameObject.SetActive(false);
                    Level2Building55.gameObject.SetActive(true);
                }
                else if (GameControl.count44 == 3)
                {
                    Level2Building55.gameObject.SetActive(false);
                    Level3Building55.gameObject.SetActive(true);
                }
            }
			if (player8.GetComponent<FollowThePath>().transform.position == waypoints[56].transform.position) {
				GameControl.count45++;
				GameControl.own45 = 8;
                if (GameControl.count45 == 1)
                    Level1Building56.gameObject.SetActive(true);
                else if (GameControl.count45 == 2)
                {
                    Level1Building56.gameObject.SetActive(false);
                    Level2Building56.gameObject.SetActive(true);
                }
                else if (GameControl.count45 == 3)
                {
                    Level2Building56.gameObject.SetActive(false);
                    Level3Building56.gameObject.SetActive(true);
                }
            }
			if (player8.GetComponent<FollowThePath>().transform.position == waypoints[57].transform.position) {
				GameControl.count46++;
				GameControl.own46 = 8;
                if (GameControl.count46 == 1)
                    Level1Building57.gameObject.SetActive(true);
                else if (GameControl.count46 == 2)
                {
                    Level1Building57.gameObject.SetActive(false);
                    Level2Building57.gameObject.SetActive(true);
                }
                else if (GameControl.count46 == 3)
                {
                    Level2Building57.gameObject.SetActive(false);
                    Level3Building57.gameObject.SetActive(true);
                }
            }
            GameControl.ImageForBuyHouse.gameObject.SetActive(false);
            camMain();
        }

        dropButton.interactable = true;

    }

    public void Investment()
    {
            
    }

    public void EndTurn()
    {
        GameControl.ImageForBuyHouse.gameObject.SetActive(false);
        dropButton.interactable = true;
        camMain();
    }

    public void YesButton()
    {   
        Buy2();
        GameControl.ImageForBuyOtherHouse.gameObject.SetActive(false);
        dropButton.interactable = true;
        camMain();
    }

    public void Nobutton()
    {
        GameControl.ImageForBuyOtherHouse.gameObject.SetActive(false);
        dropButton.interactable = true;
        camMain();
    }

    public void camMain()
    {
        camera[0].enabled = true; //
        camera[1].enabled = false;
        camera[2].enabled = false;
        camera[3].enabled = false;
        camera[4].enabled = false;
        camera[5].enabled = false;
        camera[6].enabled = false;
        camera[7].enabled = false;
        camera[8].enabled = false;
    }

    public void Buy2()
    {
        player1 = GameObject.Find("player1");
        player2 = GameObject.Find("player2");
        player3 = GameObject.Find("player3");
        player4 = GameObject.Find("player4");
        player5 = GameObject.Find("player5");
        player6 = GameObject.Find("player6");
        player7 = GameObject.Find("player7");
        player8 = GameObject.Find("player8");

        if (GameControl.whoTurn == 1)
        {
            if (sum1 - GameControl.Reduce < 0)
            {
                sum1 = 0;
            }
            else
            {
                sum1 -= GameControl.Reduce;
            }

            player1Cost.text = sum1.ToString();

            if (player1.GetComponent<FollowThePath>().transform.position == waypoints[1].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own1);
                GameControl.own1 = 1;
            }
            if (player1.GetComponent<FollowThePath>().transform.position == waypoints[2].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own2);
                GameControl.own2 = 1;
            }
            if (player1.GetComponent<FollowThePath>().transform.position == waypoints[3].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own3);
                GameControl.own3 = 1;
            }
            if (player1.GetComponent<FollowThePath>().transform.position == waypoints[4].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own4);
                GameControl.own4 = 1;
            }
            if (player1.GetComponent<FollowThePath>().transform.position == waypoints[5].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own5);
                GameControl.own5 = 1;
            }
            if (player1.GetComponent<FollowThePath>().transform.position == waypoints[7].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own6);
                GameControl.own6 = 1;
            }
            if (player1.GetComponent<FollowThePath>().transform.position == waypoints[8].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own7);
                GameControl.own7 = 1;
            }
            if (player1.GetComponent<FollowThePath>().transform.position == waypoints[9].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own8);
                GameControl.own8 = 1;
            }
            if (player1.GetComponent<FollowThePath>().transform.position == waypoints[10].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own9);
                GameControl.buyValue = 1;
                GameControl.own9 = 1;
            }
            if (player1.GetComponent<FollowThePath>().transform.position == waypoints[11].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own10);
                GameControl.own10 = 1;
            }
            if (player1.GetComponent<FollowThePath>().transform.position == waypoints[13].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own11);
                GameControl.own11 = 1;
            }
            if (player1.GetComponent<FollowThePath>().transform.position == waypoints[14].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own12);
                GameControl.own12 = 1;
            }
            if (player1.GetComponent<FollowThePath>().transform.position == waypoints[15].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own13);
                GameControl.own13 = 1;
            }
            if (player1.GetComponent<FollowThePath>().transform.position == waypoints[16].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own14);
                GameControl.own14 = 1;
            }
            if (player1.GetComponent<FollowThePath>().transform.position == waypoints[17].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own15);
                GameControl.own15 = 1;
            }
            if (player1.GetComponent<FollowThePath>().transform.position == waypoints[19].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own16);
                GameControl.own16 = 1;
            }
            if (player1.GetComponent<FollowThePath>().transform.position == waypoints[20].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own17);
                GameControl.own17 = 1;
            }
            if (player1.GetComponent<FollowThePath>().transform.position == waypoints[21].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own18);
                GameControl.buyValue = 1;
                GameControl.own18 = 1;
            }
            if (player1.GetComponent<FollowThePath>().transform.position == waypoints[22].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own19);
                GameControl.own19 = 1;
            }
            if (player1.GetComponent<FollowThePath>().transform.position == waypoints[23].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own20);
                GameControl.own20 = 3;
            }
            if (player3.GetComponent<FollowThePath>().transform.position == waypoints[24].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own21);
                GameControl.own21 = 1;
            }
            if (player1.GetComponent<FollowThePath>().transform.position == waypoints[26].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own22);
                GameControl.own22 = 1;
            }
            if (player1.GetComponent<FollowThePath>().transform.position == waypoints[27].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own23);
                GameControl.own23 = 1;
            }
            if (player1.GetComponent<FollowThePath>().transform.position == waypoints[28].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own24);
                GameControl.own24 = 1;
            }
            if (player1.GetComponent<FollowThePath>().transform.position == waypoints[29].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own25);
                GameControl.own25 = 1;
            }
            if (player1.GetComponent<FollowThePath>().transform.position == waypoints[31].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own26);
                GameControl.own26 = 1;
            }
            if (player1.GetComponent<FollowThePath>().transform.position == waypoints[32].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own27);
                GameControl.own27 = 1;
            }
            if (player1.GetComponent<FollowThePath>().transform.position == waypoints[33].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own28);
                GameControl.own28 = 1;
            }
            if (player1.GetComponent<FollowThePath>().transform.position == waypoints[34].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own29);
                GameControl.own29 = 1;
            }
            if (player1.GetComponent<FollowThePath>().transform.position == waypoints[36].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own30);
                GameControl.own30 = 1;
            }
            if (player1.GetComponent<FollowThePath>().transform.position == waypoints[37].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own31);
                GameControl.own31 = 1;
            }
            if (player1.GetComponent<FollowThePath>().transform.position == waypoints[38].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own32);
                GameControl.buyValue = 1;
                GameControl.own32 = 1;
            }
            if (player1.GetComponent<FollowThePath>().transform.position == waypoints[39].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own33);
                GameControl.own33 = 1;
            }
            if (player1.GetComponent<FollowThePath>().transform.position == waypoints[40].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own34);
                GameControl.own34 = 1;
            }
            if (player1.GetComponent<FollowThePath>().transform.position == waypoints[42].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own35);
                GameControl.own35 = 1;
            }
            if (player1.GetComponent<FollowThePath>().transform.position == waypoints[43].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own36);

                GameControl.own36 = 1;
            }
            if (player1.GetComponent<FollowThePath>().transform.position == waypoints[44].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own37);

                GameControl.own37 = 1;
            }
            if (player1.GetComponent<FollowThePath>().transform.position == waypoints[47].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own38);
                GameControl.own38 = 1;
            }
            if (player1.GetComponent<FollowThePath>().transform.position == waypoints[48].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own39);

                GameControl.own39 = 1;
            }
            if (player1.GetComponent<FollowThePath>().transform.position == waypoints[49].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own40);

                GameControl.own40 = 1;
            }
            if (player1.GetComponent<FollowThePath>().transform.position == waypoints[50].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own41);

                GameControl.buyValue = 1;
                GameControl.own41 = 1;
            }
            if (player1.GetComponent<FollowThePath>().transform.position == waypoints[51].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own42);

                GameControl.own42 = 1;
            }
     
            if (player1.GetComponent<FollowThePath>().transform.position == waypoints[52].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own43);

                GameControl.own43 = 1;
            }
            if (player1.GetComponent<FollowThePath>().transform.position == waypoints[55].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own44);

                GameControl.own44 = 1;
            }
            if (player1.GetComponent<FollowThePath>().transform.position == waypoints[56].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own45);

                GameControl.own45 = 1;
            }
            if (player1.GetComponent<FollowThePath>().transform.position == waypoints[57].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own46);
                GameControl.own46 = 1;
            }
          
            camMain();

        }

        if (GameControl.whoTurn == 2)
        {
            if (sum2 - GameControl.Reduce < 0)
            {
                sum2 = 0;

            }
            else
            {

                sum2 -= GameControl.Reduce;
            }
            player2Cost.text = sum2.ToString();
            if (player2.GetComponent<FollowThePath>().transform.position == waypoints[1].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own1);
                GameControl.own1 = 2;
            }
            if (player2.GetComponent<FollowThePath>().transform.position == waypoints[2].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own2);
                GameControl.own2 = 2;
            }
            if (player2.GetComponent<FollowThePath>().transform.position == waypoints[3].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own3);

                GameControl.own3 = 2;
            }
            if (player2.GetComponent<FollowThePath>().transform.position == waypoints[4].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own4);

                GameControl.own4 = 2;
            }
            if (player2.GetComponent<FollowThePath>().transform.position == waypoints[5].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own5);

                GameControl.own5 = 2;
            }
            if (player2.GetComponent<FollowThePath>().transform.position == waypoints[7].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own6);

                GameControl.own6 = 2;
            }
            if (player2.GetComponent<FollowThePath>().transform.position == waypoints[8].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own7);

                GameControl.own7 = 2;
            }
            if (player2.GetComponent<FollowThePath>().transform.position == waypoints[9].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own8);

                GameControl.own8 = 2;
            }
            if (player2.GetComponent<FollowThePath>().transform.position == waypoints[10].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own9);

                GameControl.buyValue = 1;
                GameControl.own9 = 2;
            }
            if (player2.GetComponent<FollowThePath>().transform.position == waypoints[11].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own10);

                GameControl.own10 = 2;
            }
            if (player2.GetComponent<FollowThePath>().transform.position == waypoints[13].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own11);

                GameControl.own11 = 2;
            }
            if (player2.GetComponent<FollowThePath>().transform.position == waypoints[14].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own12);

                GameControl.own12 = 2;
            }
            if (player2.GetComponent<FollowThePath>().transform.position == waypoints[15].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own13);

                GameControl.own13 = 2;
            }
            if (player2.GetComponent<FollowThePath>().transform.position == waypoints[16].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own14);

                GameControl.own14 = 2;
            }
            if (player2.GetComponent<FollowThePath>().transform.position == waypoints[17].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own15);

                GameControl.own15 = 2;
            }
            if (player2.GetComponent<FollowThePath>().transform.position == waypoints[19].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own16);

                GameControl.own16 = 2;
            }
            if (player2.GetComponent<FollowThePath>().transform.position == waypoints[20].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own17);

                GameControl.own17 = 2;
            }
            if (player2.GetComponent<FollowThePath>().transform.position == waypoints[21].transform.position)
            {

                ReduceSum(GameControl.Reduce, GameControl.own18);

                GameControl.buyValue = 1;
                GameControl.own18 = 2;
            }
            if (player2.GetComponent<FollowThePath>().transform.position == waypoints[22].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own19);

                GameControl.own19 = 2;
            }
            if (player2.GetComponent<FollowThePath>().transform.position == waypoints[23].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own20);

                GameControl.own20 = 2;
            }
            if (player2.GetComponent<FollowThePath>().transform.position == waypoints[24].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own21);

                GameControl.own21 = 2;
            }
            if (player2.GetComponent<FollowThePath>().transform.position == waypoints[26].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own22);

                GameControl.own22 = 2;
            }
            if (player2.GetComponent<FollowThePath>().transform.position == waypoints[27].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own23);

                GameControl.own23 = 2;
            }
            if (player2.GetComponent<FollowThePath>().transform.position == waypoints[28].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own24);

                GameControl.own24 = 2;
            }
            if (player2.GetComponent<FollowThePath>().transform.position == waypoints[29].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own25);

                GameControl.own25 = 2;
            }
            if (player2.GetComponent<FollowThePath>().transform.position == waypoints[31].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own26);

                GameControl.own26 = 2;
            }
            if (player2.GetComponent<FollowThePath>().transform.position == waypoints[32].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own27);

                GameControl.own27 = 2;
            }
            if (player2.GetComponent<FollowThePath>().transform.position == waypoints[33].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own28);

                GameControl.own28 = 2;
            }
            if (player2.GetComponent<FollowThePath>().transform.position == waypoints[34].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own29);

                GameControl.own29 = 2;
            }
            if (player2.GetComponent<FollowThePath>().transform.position == waypoints[36].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own30);

                GameControl.own30 = 2;
            }
            if (player2.GetComponent<FollowThePath>().transform.position == waypoints[37].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own31);

                GameControl.own31 = 2;
            }
            if (player2.GetComponent<FollowThePath>().transform.position == waypoints[38].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own32);

                GameControl.buyValue = 1;
                GameControl.own32 = 2;
            }
            if (player2.GetComponent<FollowThePath>().transform.position == waypoints[39].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own33);

                GameControl.own33 = 2;
            }
            if (player2.GetComponent<FollowThePath>().transform.position == waypoints[40].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own34);

                GameControl.own34 = 2;
            }
            if (player2.GetComponent<FollowThePath>().transform.position == waypoints[42].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own35);

                GameControl.own35 = 2;
            }
            if (player2.GetComponent<FollowThePath>().transform.position == waypoints[43].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own36);

                GameControl.own36 = 2;
            }
            if (player2.GetComponent<FollowThePath>().transform.position == waypoints[44].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own37);

                GameControl.own37 = 2;
            }
            if (player2.GetComponent<FollowThePath>().transform.position == waypoints[47].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own38);

                GameControl.own38 = 2;
            }
            if (player2.GetComponent<FollowThePath>().transform.position == waypoints[48].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own39);

                GameControl.own39 = 2;
            }
            if (player2.GetComponent<FollowThePath>().transform.position == waypoints[49].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own40);

                GameControl.own40 = 2;
            }
            if (player2.GetComponent<FollowThePath>().transform.position == waypoints[50].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own41);

                GameControl.buyValue = 1;
                GameControl.own41 = 2;
            }
            if (player2.GetComponent<FollowThePath>().transform.position == waypoints[51].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own42);

                GameControl.own42 = 2;
            }
            if (player2.GetComponent<FollowThePath>().transform.position == waypoints[52].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own43);

                GameControl.own43 = 2;
            }
            if (player2.GetComponent<FollowThePath>().transform.position == waypoints[55].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own44);

                GameControl.own44 = 2;
            }
            if (player2.GetComponent<FollowThePath>().transform.position == waypoints[56].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own45);

                GameControl.own45 = 2;
            }
            if (player2.GetComponent<FollowThePath>().transform.position == waypoints[57].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own46);

                GameControl.own46 = 2;
            }

            camMain();
        }

        if (GameControl.whoTurn == 3)
        {
            if (sum3 - GameControl.Reduce < 0)
            {
                sum3 = 0;
            }
            else
            {
                sum3 -= GameControl.Reduce;
            }
            player3Cost.text = sum3.ToString();
            if (player3.GetComponent<FollowThePath>().transform.position == waypoints[1].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own1);
                GameControl.own1 = 3;
            }
            if (player3.GetComponent<FollowThePath>().transform.position == waypoints[2].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own2);

                GameControl.own2 = 3;
            }
            if (player3.GetComponent<FollowThePath>().transform.position == waypoints[3].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own3);

                GameControl.own3 = 3;
            }
            if (player3.GetComponent<FollowThePath>().transform.position == waypoints[4].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own4);
                GameControl.own4 = 3;
            }
            if (player3.GetComponent<FollowThePath>().transform.position == waypoints[5].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own5);

                GameControl.own5 = 3;
            }
            if (player3.GetComponent<FollowThePath>().transform.position == waypoints[7].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own6);

                GameControl.own6 = 3;
            }
            if (player3.GetComponent<FollowThePath>().transform.position == waypoints[8].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own7);

                GameControl.own7 = 3;
            }
            if (player3.GetComponent<FollowThePath>().transform.position == waypoints[9].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own8);

                GameControl.own8 = 3;
            }
            if (player3.GetComponent<FollowThePath>().transform.position == waypoints[10].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own9);

                GameControl.buyValue = 1;
                GameControl.own9 = 3;
            }
            if (player3.GetComponent<FollowThePath>().transform.position == waypoints[11].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own10);

                GameControl.own10 = 3;
            }
            if (player3.GetComponent<FollowThePath>().transform.position == waypoints[13].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own11);

                GameControl.own11 = 3;
            }
            if (player3.GetComponent<FollowThePath>().transform.position == waypoints[14].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own12);

                GameControl.own12 = 3;
            }
            if (player3.GetComponent<FollowThePath>().transform.position == waypoints[15].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own13);

                GameControl.own13 = 3;
            }
            if (player3.GetComponent<FollowThePath>().transform.position == waypoints[16].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own14);

                GameControl.own14 = 3;
            }
            if (player3.GetComponent<FollowThePath>().transform.position == waypoints[17].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own15);

                GameControl.own15 = 3;
            }
            if (player3.GetComponent<FollowThePath>().transform.position == waypoints[19].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own16);

                GameControl.own16 = 3;
            }
            if (player3.GetComponent<FollowThePath>().transform.position == waypoints[20].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own17);

                GameControl.own17 = 3;
            }
            if (player3.GetComponent<FollowThePath>().transform.position == waypoints[21].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own18);
                GameControl.buyValue = 1;
                GameControl.own18 = 3;
            }
            if (player3.GetComponent<FollowThePath>().transform.position == waypoints[22].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own19);

                GameControl.own19 = 3;
            }
            if (player3.GetComponent<FollowThePath>().transform.position == waypoints[23].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own20);

                GameControl.own20 = 3;
            }
            if (player3.GetComponent<FollowThePath>().transform.position == waypoints[24].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own21);

                GameControl.own21 = 3;
            }
            if (player3.GetComponent<FollowThePath>().transform.position == waypoints[26].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own22);

                GameControl.own22 = 3;
            }
            if (player3.GetComponent<FollowThePath>().transform.position == waypoints[27].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own23);

                GameControl.own23 = 3;
            }
            if (player3.GetComponent<FollowThePath>().transform.position == waypoints[28].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own24);

                GameControl.own24 = 3;
            }
            if (player3.GetComponent<FollowThePath>().transform.position == waypoints[29].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own25);
                GameControl.own25 = 3;
            }
            if (player3.GetComponent<FollowThePath>().transform.position == waypoints[31].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own26);

                GameControl.own26 = 3;
            }
            if (player3.GetComponent<FollowThePath>().transform.position == waypoints[32].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own27);

                GameControl.own27 = 3;
            }
            if (player3.GetComponent<FollowThePath>().transform.position == waypoints[33].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own28);

                GameControl.own28 = 3;
            }
            if (player3.GetComponent<FollowThePath>().transform.position == waypoints[34].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own29);

                GameControl.own29 = 3;
            }
            if (player3.GetComponent<FollowThePath>().transform.position == waypoints[36].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own30);

                GameControl.own30 = 3;
            }
            if (player3.GetComponent<FollowThePath>().transform.position == waypoints[37].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own31);

                GameControl.own31 = 3;
            }
            if (player3.GetComponent<FollowThePath>().transform.position == waypoints[38].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own32);

                GameControl.buyValue = 1;
                GameControl.own32 = 3;
            }
            if (player3.GetComponent<FollowThePath>().transform.position == waypoints[39].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own33);

                GameControl.own33 = 3;
            }
            if (player3.GetComponent<FollowThePath>().transform.position == waypoints[40].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own34);

                GameControl.own34 = 3;
            }
            if (player3.GetComponent<FollowThePath>().transform.position == waypoints[42].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own35);

                GameControl.own35 = 3;
            }
            if (player3.GetComponent<FollowThePath>().transform.position == waypoints[43].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own36);
                GameControl.own36 = 3;
            }
            if (player3.GetComponent<FollowThePath>().transform.position == waypoints[44].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own37);

                GameControl.own37 = 3;
            }
            if (player3.GetComponent<FollowThePath>().transform.position == waypoints[47].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own38);

                GameControl.own38 = 3;
            }
            if (player3.GetComponent<FollowThePath>().transform.position == waypoints[48].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own39);
                GameControl.own39 = 3;
            }
            if (player3.GetComponent<FollowThePath>().transform.position == waypoints[49].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own40);

                GameControl.own40 = 3;
            }
            if (player3.GetComponent<FollowThePath>().transform.position == waypoints[50].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own41);

                GameControl.buyValue = 1;
                GameControl.own41 = 3;
            }
            if (player3.GetComponent<FollowThePath>().transform.position == waypoints[51].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own42);

                GameControl.own42 = 3;
            }
            if (player3.GetComponent<FollowThePath>().transform.position == waypoints[52].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own43);

                GameControl.own43 = 3;
            }
            if (player3.GetComponent<FollowThePath>().transform.position == waypoints[55].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own44);

                GameControl.own44 = 3;
            }
            if (player3.GetComponent<FollowThePath>().transform.position == waypoints[56].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own45);

                GameControl.own45 = 3;
            }
            if (player3.GetComponent<FollowThePath>().transform.position == waypoints[57].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own46);
                GameControl.own46 = 3;
            }

            camMain();
        }

        if (GameControl.whoTurn == 4)
        {
            if (sum4 - GameControl.Reduce < 0)
            {
                sum4 = 0;
            }
            else
            {
                sum4 -= GameControl.Reduce;
            }
            player4Cost.text = sum4.ToString();
            if (player4.GetComponent<FollowThePath>().transform.position == waypoints[1].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own1);
                GameControl.own1 = 4;
            }
            if (player4.GetComponent<FollowThePath>().transform.position == waypoints[2].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own2);
                GameControl.own2 = 4;
            }
            if (player4.GetComponent<FollowThePath>().transform.position == waypoints[3].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own3);
                GameControl.own3 = 4;
            }
            if (player4.GetComponent<FollowThePath>().transform.position == waypoints[4].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own4);
                GameControl.own4 = 4;
            }
            if (player4.GetComponent<FollowThePath>().transform.position == waypoints[5].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own5);
                GameControl.own5 = 4;
            }
            if (player4.GetComponent<FollowThePath>().transform.position == waypoints[7].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own6);
                GameControl.own6 = 4;
            }
            if (player4.GetComponent<FollowThePath>().transform.position == waypoints[8].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own7);
                GameControl.own7 = 4;
            }
            if (player4.GetComponent<FollowThePath>().transform.position == waypoints[9].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own8);
                GameControl.own8 = 4;
            }
            if (player4.GetComponent<FollowThePath>().transform.position == waypoints[10].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own9);
                GameControl.buyValue = 1;
                GameControl.own9 = 4;
            }
            if (player4.GetComponent<FollowThePath>().transform.position == waypoints[11].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own10);
                GameControl.own10 = 4;
            }
            if (player4.GetComponent<FollowThePath>().transform.position == waypoints[13].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own11);
                GameControl.own11 = 4;
            }
            if (player4.GetComponent<FollowThePath>().transform.position == waypoints[14].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own12);
                GameControl.own12 = 4;
            }
            if (player4.GetComponent<FollowThePath>().transform.position == waypoints[15].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own13);
                GameControl.own13 = 4;
            }
            if (player4.GetComponent<FollowThePath>().transform.position == waypoints[16].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own14);
                GameControl.own14 = 4;
            }
            if (player4.GetComponent<FollowThePath>().transform.position == waypoints[17].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own15);
                GameControl.own15 = 4;
            }
            if (player4.GetComponent<FollowThePath>().transform.position == waypoints[19].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own16);
                GameControl.own16 = 4;
            }
            if (player4.GetComponent<FollowThePath>().transform.position == waypoints[20].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own17);
                GameControl.own17 = 4;
            }
            if (player4.GetComponent<FollowThePath>().transform.position == waypoints[21].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own18);
                GameControl.buyValue = 1;
                GameControl.own18 = 4;
            }
            if (player4.GetComponent<FollowThePath>().transform.position == waypoints[22].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own19);
                GameControl.own19 = 4;
            }
            if (player4.GetComponent<FollowThePath>().transform.position == waypoints[23].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own20);
                GameControl.own20 = 4;
            }
            if (player4.GetComponent<FollowThePath>().transform.position == waypoints[24].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own21);
                GameControl.own21 = 4;
            }
            if (player4.GetComponent<FollowThePath>().transform.position == waypoints[26].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own22);
                GameControl.own22 = 4;
            }
            if (player4.GetComponent<FollowThePath>().transform.position == waypoints[27].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own23);
                GameControl.own23 = 4;
            }
            if (player4.GetComponent<FollowThePath>().transform.position == waypoints[28].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own24);
                GameControl.own24 = 4;
            }
            if (player4.GetComponent<FollowThePath>().transform.position == waypoints[29].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own25);
                GameControl.own25 = 4;
            }
            if (player4.GetComponent<FollowThePath>().transform.position == waypoints[31].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own26);
                GameControl.own26 = 4;
            }
            if (player4.GetComponent<FollowThePath>().transform.position == waypoints[32].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own27);
                GameControl.own27 = 4;
            }
            if (player4.GetComponent<FollowThePath>().transform.position == waypoints[33].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own28);
                GameControl.own28 = 4;
            }
            if (player4.GetComponent<FollowThePath>().transform.position == waypoints[34].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own29);
                GameControl.own29 = 4;
            }
            if (player4.GetComponent<FollowThePath>().transform.position == waypoints[36].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own30);
                GameControl.own30 = 4;
            }
            if (player4.GetComponent<FollowThePath>().transform.position == waypoints[37].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own31);
                GameControl.own31 = 4;
            }
            if (player4.GetComponent<FollowThePath>().transform.position == waypoints[38].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own32);
                GameControl.buyValue = 1;
                GameControl.own32 = 4;
            }
            if (player4.GetComponent<FollowThePath>().transform.position == waypoints[39].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own33);
                GameControl.own33 = 4;
            }
            if (player4.GetComponent<FollowThePath>().transform.position == waypoints[40].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own34);
                GameControl.own34 = 4;
            }
            if (player4.GetComponent<FollowThePath>().transform.position == waypoints[42].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own35);
                GameControl.own35 = 4;
            }
            if (player4.GetComponent<FollowThePath>().transform.position == waypoints[43].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own36);
                GameControl.own36 = 4;
            }
            if (player4.GetComponent<FollowThePath>().transform.position == waypoints[44].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own37);
                GameControl.own37 = 4;
            }
            if (player4.GetComponent<FollowThePath>().transform.position == waypoints[47].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own38);
                GameControl.own38 = 4;
            }
            if (player4.GetComponent<FollowThePath>().transform.position == waypoints[48].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own39);
                GameControl.own39 = 4;
            }
            if (player4.GetComponent<FollowThePath>().transform.position == waypoints[49].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own40);
                GameControl.own40 = 4;
            }
            if (player4.GetComponent<FollowThePath>().transform.position == waypoints[50].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own41);
                GameControl.buyValue = 1;
                GameControl.own41 = 4;
            }
            if (player4.GetComponent<FollowThePath>().transform.position == waypoints[51].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own42);
                GameControl.own42 = 4;
            }
            if (player4.GetComponent<FollowThePath>().transform.position == waypoints[52].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own43);
                GameControl.own43 = 4;
            }
            if (player4.GetComponent<FollowThePath>().transform.position == waypoints[55].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own44);
                GameControl.own44 = 4; // GameControl.own44 = 4;
            }
            if (player4.GetComponent<FollowThePath>().transform.position == waypoints[56].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own45);
                GameControl.own45 = 4;
            }
            if (player4.GetComponent<FollowThePath>().transform.position == waypoints[57].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own46);
                GameControl.own46 = 4;
            }
            camMain();
        }

        if (GameControl.whoTurn == 5)
        {
            if (sum5 - GameControl.Reduce < 0)
            {
                sum5 = 0;
           
            }
            else
            {
                sum5 -= GameControl.Reduce;
            }
            player5Cost.text = sum5.ToString();
            if (player5.GetComponent<FollowThePath>().transform.position == waypoints[1].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own1);
                GameControl.own1 = 5;
            }
            if (player5.GetComponent<FollowThePath>().transform.position == waypoints[2].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own2);
                GameControl.own2 = 5;
            }
            if (player5.GetComponent<FollowThePath>().transform.position == waypoints[3].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own3);
                GameControl.own3 = 5;
            }
            if (player5.GetComponent<FollowThePath>().transform.position == waypoints[4].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own4);
                GameControl.own4 = 5;
            }
            if (player5.GetComponent<FollowThePath>().transform.position == waypoints[5].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own5);
                GameControl.own5 = 5;
            }
            if (player5.GetComponent<FollowThePath>().transform.position == waypoints[7].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own6);
                GameControl.own6 = 5;
            }
            if (player5.GetComponent<FollowThePath>().transform.position == waypoints[8].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own7);
                GameControl.own7 = 5;
            }
            if (player5.GetComponent<FollowThePath>().transform.position == waypoints[9].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own8);
                GameControl.own8 = 5;
            }
            if (player5.GetComponent<FollowThePath>().transform.position == waypoints[10].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own9);
                GameControl.buyValue = 1;
                GameControl.own9 = 5;
            }
            if (player5.GetComponent<FollowThePath>().transform.position == waypoints[11].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own10);
                GameControl.own10 = 5;
            }
            if (player5.GetComponent<FollowThePath>().transform.position == waypoints[13].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own11);
                GameControl.own11 = 5;
            }
            if (player5.GetComponent<FollowThePath>().transform.position == waypoints[14].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own12);
                GameControl.own12 = 5;
            }
            if (player5.GetComponent<FollowThePath>().transform.position == waypoints[15].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own13);
                GameControl.own13 = 5;
            }
            if (player5.GetComponent<FollowThePath>().transform.position == waypoints[16].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own14);
                GameControl.own14 = 5;
            }
            if (player5.GetComponent<FollowThePath>().transform.position == waypoints[17].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own15);
                GameControl.own15 = 5;
            }
            if (player5.GetComponent<FollowThePath>().transform.position == waypoints[19].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own16);
                GameControl.own16 = 5;
            }
            if (player5.GetComponent<FollowThePath>().transform.position == waypoints[20].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own17);
                GameControl.own17 = 5;
            }
            if (player5.GetComponent<FollowThePath>().transform.position == waypoints[21].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own18);
                GameControl.buyValue = 1;
                GameControl.own18 = 5;
            }
            if (player5.GetComponent<FollowThePath>().transform.position == waypoints[22].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own19);
                GameControl.own19 = 5;
            }
            if (player5.GetComponent<FollowThePath>().transform.position == waypoints[23].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own20);
                GameControl.own20 = 5;
            }
            if (player5.GetComponent<FollowThePath>().transform.position == waypoints[24].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own21);
                GameControl.own21 = 5;
            }
            if (player5.GetComponent<FollowThePath>().transform.position == waypoints[26].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own22);
                GameControl.own22 = 5;
            }
            if (player5.GetComponent<FollowThePath>().transform.position == waypoints[27].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own23);
                GameControl.own23 = 5;
            }
            if (player5.GetComponent<FollowThePath>().transform.position == waypoints[28].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own24);
                GameControl.own24 = 5;
            }
            if (player5.GetComponent<FollowThePath>().transform.position == waypoints[29].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own25);
                GameControl.own25 = 5;
            }
            if (player5.GetComponent<FollowThePath>().transform.position == waypoints[31].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own26);
                GameControl.own26 = 5;
            }
            if (player5.GetComponent<FollowThePath>().transform.position == waypoints[32].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own27);
                GameControl.own27 = 5;
            }
            if (player5.GetComponent<FollowThePath>().transform.position == waypoints[33].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own28);
                GameControl.own28 = 5;
            }
            if (player5.GetComponent<FollowThePath>().transform.position == waypoints[34].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own29);
                GameControl.own29 = 5;
            }
            if (player5.GetComponent<FollowThePath>().transform.position == waypoints[36].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own30);
                GameControl.own30 = 5;
            }
            if (player5.GetComponent<FollowThePath>().transform.position == waypoints[37].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own31);
                GameControl.own31 = 5;
            }
            if (player5.GetComponent<FollowThePath>().transform.position == waypoints[38].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own32);
                GameControl.buyValue = 1;
                GameControl.own32 = 5;
            }
            if (player5.GetComponent<FollowThePath>().transform.position == waypoints[39].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own33);
                GameControl.own33 = 5;
            }
            if (player5.GetComponent<FollowThePath>().transform.position == waypoints[40].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own34);
                GameControl.own34 = 5;
            }
            if (player5.GetComponent<FollowThePath>().transform.position == waypoints[42].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own35);
                GameControl.own35 = 5;
            }
            if (player5.GetComponent<FollowThePath>().transform.position == waypoints[43].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own36);
                GameControl.own36 = 5;
            }
            if (player5.GetComponent<FollowThePath>().transform.position == waypoints[44].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own37);
                GameControl.own37 = 5;
            }
            if (player5.GetComponent<FollowThePath>().transform.position == waypoints[47].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own38);
                GameControl.own38 = 5;
            }
            if (player5.GetComponent<FollowThePath>().transform.position == waypoints[48].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own39);
                GameControl.own39 = 5;
            }
            if (player5.GetComponent<FollowThePath>().transform.position == waypoints[49].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own40);
                GameControl.own40 = 5;
            }
            if (player5.GetComponent<FollowThePath>().transform.position == waypoints[50].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own41);
                GameControl.buyValue = 1;
                GameControl.own41 = 5;
            }
            if (player5.GetComponent<FollowThePath>().transform.position == waypoints[51].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own42);
                GameControl.own42 = 5;
            }
            if (player5.GetComponent<FollowThePath>().transform.position == waypoints[52].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own43);
                GameControl.own43 = 5;
            }
            if (player5.GetComponent<FollowThePath>().transform.position == waypoints[55].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own44);
                GameControl.own44 = 5;
            }
            if (player5.GetComponent<FollowThePath>().transform.position == waypoints[56].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own45);
                GameControl.own45 = 5;
            }
            if (player5.GetComponent<FollowThePath>().transform.position == waypoints[57].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own46);
                GameControl.own46 = 5;
            }

            camMain();
        }

        if (GameControl.whoTurn == 6)
        {
            if (sum6 - GameControl.Reduce < 0)
            {
                sum6 = 0;
            }
            else
            {
                sum6 -= GameControl.Reduce;
            }
            player6Cost.text = sum6.ToString();
            if (player6.GetComponent<FollowThePath>().transform.position == waypoints[1].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own1);
                GameControl.own1 = 6;
            }
            if (player6.GetComponent<FollowThePath>().transform.position == waypoints[2].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own2);
                GameControl.own2 = 6;
            }
            if (player6.GetComponent<FollowThePath>().transform.position == waypoints[3].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own3);
                GameControl.own3 = 6;
            }
            if (player6.GetComponent<FollowThePath>().transform.position == waypoints[4].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own4);
                GameControl.own4 = 6;
            }
            if (player6.GetComponent<FollowThePath>().transform.position == waypoints[5].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own5);
                GameControl.own5 = 6;
            }
            if (player6.GetComponent<FollowThePath>().transform.position == waypoints[7].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own6);
                GameControl.own6 = 6;
            }
            if (player6.GetComponent<FollowThePath>().transform.position == waypoints[8].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own7);
                GameControl.own7 = 6;
            }
            if (player6.GetComponent<FollowThePath>().transform.position == waypoints[9].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own8);
                GameControl.own8 = 6;
            }
            if (player6.GetComponent<FollowThePath>().transform.position == waypoints[10].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own9);
                GameControl.buyValue = 1;
                GameControl.own9 = 6;
            }
            if (player6.GetComponent<FollowThePath>().transform.position == waypoints[11].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own10);
                GameControl.own10 = 6;
            }
            if (player6.GetComponent<FollowThePath>().transform.position == waypoints[13].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own11);
                GameControl.own11 = 6;
            }
            if (player6.GetComponent<FollowThePath>().transform.position == waypoints[14].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own12);
                GameControl.own12 = 6;
            }
            if (player6.GetComponent<FollowThePath>().transform.position == waypoints[15].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own13);
                GameControl.own13 = 6;
            }
            if (player6.GetComponent<FollowThePath>().transform.position == waypoints[16].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own14);
                GameControl.own14 = 6;
            }
            if (player6.GetComponent<FollowThePath>().transform.position == waypoints[17].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own15);
                GameControl.own15 = 6;
            }
            if (player6.GetComponent<FollowThePath>().transform.position == waypoints[19].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own16);
                GameControl.own16 = 6;
            }
            if (player6.GetComponent<FollowThePath>().transform.position == waypoints[20].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own17);
                GameControl.own17 = 6;
            }
            if (player6.GetComponent<FollowThePath>().transform.position == waypoints[21].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own18);
                GameControl.buyValue = 1;
                GameControl.own18 = 6;
            }
            if (player6.GetComponent<FollowThePath>().transform.position == waypoints[22].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own19);
                GameControl.own19 = 6;
            }
            if (player6.GetComponent<FollowThePath>().transform.position == waypoints[23].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own20);
                GameControl.own20 = 6;
            }
            if (player6.GetComponent<FollowThePath>().transform.position == waypoints[24].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own21);
                GameControl.own21 = 6;
            }
            if (player6.GetComponent<FollowThePath>().transform.position == waypoints[26].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own22);
                GameControl.own22 = 6;
            }
            if (player6.GetComponent<FollowThePath>().transform.position == waypoints[27].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own23);
                GameControl.own23 = 6;
            }
            if (player6.GetComponent<FollowThePath>().transform.position == waypoints[28].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own24);
                GameControl.own24 = 6;
            }
            if (player6.GetComponent<FollowThePath>().transform.position == waypoints[29].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own25);
                GameControl.own25 = 6;
            }
            if (player6.GetComponent<FollowThePath>().transform.position == waypoints[31].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own26);
                GameControl.own26 = 6;
            }
            if (player6.GetComponent<FollowThePath>().transform.position == waypoints[32].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own27);
                GameControl.own27 = 6;
            }
            if (player6.GetComponent<FollowThePath>().transform.position == waypoints[33].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own28);
                GameControl.own28 = 6;
            }
            if (player5.GetComponent<FollowThePath>().transform.position == waypoints[34].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own29);
                GameControl.own29 = 6;
            }
            if (player6.GetComponent<FollowThePath>().transform.position == waypoints[36].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own30);
                GameControl.own30 = 6;
            }
            if (player6.GetComponent<FollowThePath>().transform.position == waypoints[37].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own31);
                GameControl.own31 = 6;
            }
            if (player6.GetComponent<FollowThePath>().transform.position == waypoints[38].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own32);
                GameControl.buyValue = 1;
                GameControl.own32 = 6;
            }
            if (player6.GetComponent<FollowThePath>().transform.position == waypoints[39].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own33);
                GameControl.own33 = 6;
            }
            if (player6.GetComponent<FollowThePath>().transform.position == waypoints[40].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own34);
                GameControl.own34 = 6;
            }
            if (player6.GetComponent<FollowThePath>().transform.position == waypoints[42].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own35);
                GameControl.own35 = 6;
            }
            if (player6.GetComponent<FollowThePath>().transform.position == waypoints[43].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own36);
                GameControl.own36 = 6;
            }
            if (player6.GetComponent<FollowThePath>().transform.position == waypoints[44].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own37);
                GameControl.own37 = 6;
            }
            if (player6.GetComponent<FollowThePath>().transform.position == waypoints[47].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own38);
                GameControl.own38 = 6;
            }
            if (player6.GetComponent<FollowThePath>().transform.position == waypoints[48].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own39);
                GameControl.own39 = 6;
            }
            if (player6.GetComponent<FollowThePath>().transform.position == waypoints[49].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own40);
                GameControl.own40 = 6;
            }
            if (player6.GetComponent<FollowThePath>().transform.position == waypoints[50].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own41);
                GameControl.buyValue = 1;
                GameControl.own41 = 6;
            }
            if (player6.GetComponent<FollowThePath>().transform.position == waypoints[51].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own42);
                GameControl.own42 = 6;
            }
            if (player6.GetComponent<FollowThePath>().transform.position == waypoints[52].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own43);
                GameControl.own43 = 6;
            }
            if (player6.GetComponent<FollowThePath>().transform.position == waypoints[55].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own44);
                GameControl.own44 = 6;
            }
            if (player6.GetComponent<FollowThePath>().transform.position == waypoints[56].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own45);
                GameControl.own45 = 6;
            }
            if (player6.GetComponent<FollowThePath>().transform.position == waypoints[57].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own46);
                GameControl.own46 = 6;
            }
 
            camMain();
        }

        if (GameControl.whoTurn == 7)
        {
            if (sum7 - GameControl.Reduce < 0)
            {
                sum7 = 0;

            }
            else
            {
                sum7 -= GameControl.Reduce;
            }
            player7Cost.text = sum7.ToString();
            if (player7.GetComponent<FollowThePath>().transform.position == waypoints[1].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own1);
                GameControl.own1 = 7;
            }
            if (player7.GetComponent<FollowThePath>().transform.position == waypoints[2].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own2);
                GameControl.own2 = 7;
            }
            if (player7.GetComponent<FollowThePath>().transform.position == waypoints[3].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own3);
                GameControl.own3 = 7;
            }
            if (player7.GetComponent<FollowThePath>().transform.position == waypoints[4].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own4);
                GameControl.own4 = 7;
            }
            if (player7.GetComponent<FollowThePath>().transform.position == waypoints[5].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own5);
                GameControl.own5 = 7;
            }
            if (player7.GetComponent<FollowThePath>().transform.position == waypoints[7].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own6);
                GameControl.own6 = 7;
            }
            if (player7.GetComponent<FollowThePath>().transform.position == waypoints[8].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own7);
                GameControl.own7 = 7;
            }
            if (player7.GetComponent<FollowThePath>().transform.position == waypoints[9].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own8);
                GameControl.own8 = 7;
            }
            if (player7.GetComponent<FollowThePath>().transform.position == waypoints[10].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own9);
                GameControl.buyValue = 1;
                GameControl.own9 = 7;
            }
            if (player7.GetComponent<FollowThePath>().transform.position == waypoints[11].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own10);
                GameControl.own10 = 7;
            }
            if (player7.GetComponent<FollowThePath>().transform.position == waypoints[13].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own11);
                GameControl.own11 = 7;
            }
            if (player7.GetComponent<FollowThePath>().transform.position == waypoints[14].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own12);
                GameControl.own12 = 7;
            }
            if (player7.GetComponent<FollowThePath>().transform.position == waypoints[15].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own13);
                GameControl.own13 = 7;
            }
            if (player7.GetComponent<FollowThePath>().transform.position == waypoints[16].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own14);
                GameControl.own14 = 7;
            }
            if (player7.GetComponent<FollowThePath>().transform.position == waypoints[17].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own15);
                GameControl.own15 = 7;
            }
            if (player7.GetComponent<FollowThePath>().transform.position == waypoints[19].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own16);

                GameControl.own16 = 7;
            }
            if (player7.GetComponent<FollowThePath>().transform.position == waypoints[20].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own17);
                GameControl.own17 = 7;
            }
            if (player7.GetComponent<FollowThePath>().transform.position == waypoints[21].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own18);
                GameControl.buyValue = 1;
                GameControl.own18 = 7;
            }
            if (player7.GetComponent<FollowThePath>().transform.position == waypoints[22].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own19);
                GameControl.own19 = 7;
            }
            if (player7.GetComponent<FollowThePath>().transform.position == waypoints[23].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own20);
                GameControl.own20 = 7;
            }
            if (player7.GetComponent<FollowThePath>().transform.position == waypoints[24].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own21);
                GameControl.own21 = 7;
            }
            if (player7.GetComponent<FollowThePath>().transform.position == waypoints[26].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own22);
                GameControl.own22 = 7;
            }
            if (player7.GetComponent<FollowThePath>().transform.position == waypoints[27].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own23);
                GameControl.own23 = 7;
            }
            if (player7.GetComponent<FollowThePath>().transform.position == waypoints[28].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own24);
                GameControl.own24 = 7;
            }
            if (player7.GetComponent<FollowThePath>().transform.position == waypoints[29].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own25);
                GameControl.own25 = 7;
            }
            if (player7.GetComponent<FollowThePath>().transform.position == waypoints[31].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own26);
                GameControl.own26 = 7;
            }
            if (player7.GetComponent<FollowThePath>().transform.position == waypoints[32].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own27);
                GameControl.own27 = 7;
            }
            if (player7.GetComponent<FollowThePath>().transform.position == waypoints[33].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own28);
                GameControl.own28 = 7;
            }
            if (player7.GetComponent<FollowThePath>().transform.position == waypoints[34].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own29);
                GameControl.own29 = 7;
            }
            if (player7.GetComponent<FollowThePath>().transform.position == waypoints[36].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own30);
                GameControl.own30 = 7;
            }
            if (player7.GetComponent<FollowThePath>().transform.position == waypoints[37].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own31);
                GameControl.own31 = 7;
            }
            if (player7.GetComponent<FollowThePath>().transform.position == waypoints[38].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own32);
                GameControl.buyValue = 1;
                GameControl.own32 = 7;
            }
            if (player7.GetComponent<FollowThePath>().transform.position == waypoints[39].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own33);
                GameControl.own33 = 7;
            }
            if (player7.GetComponent<FollowThePath>().transform.position == waypoints[40].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own34);
                GameControl.own34 = 7;
            }
            if (player7.GetComponent<FollowThePath>().transform.position == waypoints[42].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own35);
                GameControl.own35 = 7;
            }
            if (player7.GetComponent<FollowThePath>().transform.position == waypoints[43].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own36);
                GameControl.own36 = 7;
            }
            if (player7.GetComponent<FollowThePath>().transform.position == waypoints[44].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own37);
                GameControl.own37 = 7;
            }
            if (player7.GetComponent<FollowThePath>().transform.position == waypoints[47].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own38);
                GameControl.own38 = 7;
            }
            if (player7.GetComponent<FollowThePath>().transform.position == waypoints[48].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own39);
                GameControl.own39 = 7;
            }
            if (player7.GetComponent<FollowThePath>().transform.position == waypoints[49].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own40);
                GameControl.own40 = 7;
            }
            if (player7.GetComponent<FollowThePath>().transform.position == waypoints[50].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own41);
                GameControl.buyValue = 1;
                GameControl.own41 = 7;
            }
            if (player7.GetComponent<FollowThePath>().transform.position == waypoints[51].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own42);
                GameControl.own42 = 7;
            }
            if (player7.GetComponent<FollowThePath>().transform.position == waypoints[52].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own43);
                GameControl.own43 = 7;
            }
            if (player7.GetComponent<FollowThePath>().transform.position == waypoints[55].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own44);
                GameControl.own44 = 7;
            }
            if (player7.GetComponent<FollowThePath>().transform.position == waypoints[56].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own45);
                GameControl.own45 = 7;
            }
            if (player7.GetComponent<FollowThePath>().transform.position == waypoints[57].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own46);
                GameControl.own46 = 7;
            }
            camMain();
        }

        if (GameControl.whoTurn == 8)
        {
            if (sum8 - GameControl.Reduce < 0)
            {
                sum8 = 0;
            }
            else
            {
                sum8 -= GameControl.Reduce;
            }
            player8Cost.text = sum8.ToString();
            if (player8.GetComponent<FollowThePath>().transform.position == waypoints[1].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own1);
                GameControl.own1 = 8;
            }
            if (player8.GetComponent<FollowThePath>().transform.position == waypoints[2].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own2);
                GameControl.own2 = 8;
            }
            if (player8.GetComponent<FollowThePath>().transform.position == waypoints[3].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own3);
                GameControl.own3 = 8;
            }
            if (player8.GetComponent<FollowThePath>().transform.position == waypoints[4].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own4);
                GameControl.own4 = 8;
            }
            if (player8.GetComponent<FollowThePath>().transform.position == waypoints[5].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own5);
                GameControl.own5 = 8;
            }
            if (player8.GetComponent<FollowThePath>().transform.position == waypoints[7].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own6);
                GameControl.own6 = 8;
            }
            if (player8.GetComponent<FollowThePath>().transform.position == waypoints[8].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own7);
                GameControl.own7 = 8;
            }
            if (player8.GetComponent<FollowThePath>().transform.position == waypoints[9].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own8);
                GameControl.own8 = 8;
            }
            if (player8.GetComponent<FollowThePath>().transform.position == waypoints[10].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own9);
                GameControl.buyValue = 1;
                GameControl.own9 = 8;
            }
            if (player8.GetComponent<FollowThePath>().transform.position == waypoints[11].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own10);
                GameControl.own10 = 8;
            }
            if (player8.GetComponent<FollowThePath>().transform.position == waypoints[13].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own11);
                GameControl.own11 = 8;
            }
            if (player8.GetComponent<FollowThePath>().transform.position == waypoints[14].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own12);
                GameControl.own12 = 8;
            }
            if (player8.GetComponent<FollowThePath>().transform.position == waypoints[15].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own13);
                GameControl.own13 = 8;
            }
            if (player8.GetComponent<FollowThePath>().transform.position == waypoints[16].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own14);
                GameControl.own14 = 8;
            }
            if (player8.GetComponent<FollowThePath>().transform.position == waypoints[17].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own15);
                GameControl.own15 = 8;
            }
            if (player8.GetComponent<FollowThePath>().transform.position == waypoints[19].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own16);
                GameControl.own16 = 8;
            }
            if (player8.GetComponent<FollowThePath>().transform.position == waypoints[20].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own17);
                GameControl.own17 = 8;
            }
            if (player8.GetComponent<FollowThePath>().transform.position == waypoints[21].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own18);
                GameControl.buyValue = 1;
                GameControl.own18 = 8;
            }
            if (player8.GetComponent<FollowThePath>().transform.position == waypoints[22].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own19);
                GameControl.own19 = 8;
            }
            if (player8.GetComponent<FollowThePath>().transform.position == waypoints[23].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own20);
                GameControl.own20 = 8;
            }
            if (player8.GetComponent<FollowThePath>().transform.position == waypoints[24].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own21);
                GameControl.own21 = 8;
            }
            if (player8.GetComponent<FollowThePath>().transform.position == waypoints[26].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own22);
                GameControl.own22 = 8;
            }
            if (player8.GetComponent<FollowThePath>().transform.position == waypoints[27].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own23);
                GameControl.own23 = 8;
            }
            if (player8.GetComponent<FollowThePath>().transform.position == waypoints[28].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own24);
                GameControl.own24 = 8;
            }
            if (player8.GetComponent<FollowThePath>().transform.position == waypoints[29].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own25);
                GameControl.own25 = 8;
            }
            if (player8.GetComponent<FollowThePath>().transform.position == waypoints[31].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own26);
                GameControl.own26 = 8;
            }
            if (player8.GetComponent<FollowThePath>().transform.position == waypoints[32].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own27);
                GameControl.own27 = 8;
            }
            if (player8.GetComponent<FollowThePath>().transform.position == waypoints[33].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own28);
                GameControl.own28 = 8;
            }
            if (player8.GetComponent<FollowThePath>().transform.position == waypoints[34].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own29);
                GameControl.own29 = 8;
            }
            if (player8.GetComponent<FollowThePath>().transform.position == waypoints[36].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own30);
                GameControl.own30 = 8;
            }
            if (player8.GetComponent<FollowThePath>().transform.position == waypoints[37].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own31);
                GameControl.own31 = 8;
            }
            if (player8.GetComponent<FollowThePath>().transform.position == waypoints[38].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own32);
                GameControl.buyValue = 1;
                GameControl.own32 = 8;
            }
            if (player8.GetComponent<FollowThePath>().transform.position == waypoints[39].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own33);
                GameControl.own33 = 8;
            }
            if (player8.GetComponent<FollowThePath>().transform.position == waypoints[40].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own34);
                GameControl.own34 = 8;
            }
            if (player8.GetComponent<FollowThePath>().transform.position == waypoints[42].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own35);
                GameControl.own35 = 8;
            }
            if (player8.GetComponent<FollowThePath>().transform.position == waypoints[43].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own36);
                GameControl.own36 = 8;
            }
            if (player8.GetComponent<FollowThePath>().transform.position == waypoints[44].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own37);
                GameControl.own37 = 8;
            }
            if (player8.GetComponent<FollowThePath>().transform.position == waypoints[47].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own38);
                GameControl.own38 = 8;
            }
            if (player8.GetComponent<FollowThePath>().transform.position == waypoints[48].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own39);
                GameControl.own39 = 8;
            }
            if (player8.GetComponent<FollowThePath>().transform.position == waypoints[49].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own40);
                GameControl.own40 = 8;
            }
            if (player8.GetComponent<FollowThePath>().transform.position == waypoints[50].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own41);
                GameControl.buyValue = 1;
                GameControl.own41 = 8;
            }
            if (player8.GetComponent<FollowThePath>().transform.position == waypoints[51].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own42);
                GameControl.own42 = 8;
            }
            if (player8.GetComponent<FollowThePath>().transform.position == waypoints[52].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own43);
                GameControl.own43 = 8;
            }
            if (player8.GetComponent<FollowThePath>().transform.position == waypoints[55].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own44);
                GameControl.own44 = 8;
            }
            if (player8.GetComponent<FollowThePath>().transform.position == waypoints[56].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own45);
                GameControl.own45 = 8;
            }
            if (player8.GetComponent<FollowThePath>().transform.position == waypoints[57].transform.position)
            {
                ReduceSum(GameControl.Reduce, GameControl.own46);
                GameControl.own46 = 8;
            }
            camMain();
        }

        dropButton.interactable = true;

    }

    void ReduceSum(int plus, int player)
    {
        switch(player)
        {
            case 1:
                sum1 += GameControl.Reduce;
                player1Cost.text = sum1.ToString();
                break;
            case 2:
                sum2 += GameControl.Reduce;
                player2Cost.text = sum2.ToString();
                break;
            case 3:
                sum3 += GameControl.Reduce;
                player3Cost.text = sum3.ToString();
                break;
            case 4:
                sum4 += GameControl.Reduce;
                player4Cost.text = sum4.ToString();
                break;
            case 5:
                sum5 += GameControl.Reduce;
                player5Cost.text = sum5.ToString();
                break;
            case 6:
                sum6 += GameControl.Reduce;
                player6Cost.text = sum6.ToString();
                break;
            case 7:
                sum7 += GameControl.Reduce;
                player7Cost.text = sum7.ToString();
                break;
            case 8:
                sum8 += GameControl.Reduce;
                player8Cost.text = sum8.ToString();
                break;
        }

    }

    public void Confirm()
    {
        ImageForJail = GameObject.Find("ImageForJail");

        ImageForJail.gameObject.SetActive(false);
        dropButton.interactable = true;
        camMain();
    }

}
