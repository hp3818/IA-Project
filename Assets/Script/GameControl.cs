 using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {

    public Transform[] waypoints;
    public Button payMoney, buy;
    public Text cost1, cost2, cost3, houseName, owner, JailTurn;
    public static int count1 = 0, count2 = 0, count3 = 0, count4 = 0, count5 = 0, count6 = 0, count7 = 0, count8 = 0, count9 = 0, count10 = 0, count11 = 0,
                                  count12 = 0, count13 = 0, count14 = 0, count15 = 0, count16 = 0, count17 = 0, count18 = 0, count19 = 0, count20 = 0, count21 = 0, count22 = 0,
                                  count23 = 0, count24 = 0, count25 = 0, count26 = 0, count27 = 0, count28 = 0, count29 = 0, count30 = 0, count31 = 0, count32 = 0, count33 = 0,
                                  count34 = 0, count35 = 0, count36 = 0, count37 = 0, count38 = 0, count39 = 0, count40 = 0, count41 = 0, count42 = 0, count43 = 0, count44 = 0,
								  count45 = 0, count46 = 0;

	public static int own1 = 0, own2 = 0, own3 = 0, own4 = 0, own5 = 0, own6 = 0, own7 = 0, own8 = 0,  own9 = 0, own10 = 0, own11 = 0, own12 = 0, own13 = 0, own14 = 0, own15 = 0, own16 = 0, own17 = 0,  own18 = 0, own19 = 0, own20 = 0,
	own21 = 0, own22 = 0, own23 = 0, own24 = 0, own25 = 0, own26 = 0, own27 = 0, own28 = 0, own29 = 0, own30 = 0, own31 = 0, own32 = 0, own33 = 0, own34 = 0, own35 = 0, own36 = 0, own37 = 0, own38 = 0, own39 = 0, own40 = 0, own41 = 0,
	own42 = 0, own43 = 0, own44 = 0, own45 = 0, own46 = 0;

    public Text player1Cost, player2Cost, player3Cost, player4Cost, player5Cost, player6Cost, player7Cost, player8Cost, text5, text6, text7, text8;
    public static int jail1turn =3, jail2turn = 3, jail3turn = 3, jail4turn = 3, jail5turn = 3, jail6turn = 3, jail7turn = 3, jail8turn = 3; 
    public static int detect, count;
    public static int buyValue;
	public static int Reduce;
	public static int own;
	public static int whoAreYou;
    public static int Go1 = 0, Go2 = 0, Go3 = 0, Go4 = 0, Go5 = 0, Go6 = 0, Go7 = 0, Go8 = 0;
    
    public static int whoTurn;
    public Button dropButton;
    public static int numberOfPlayer = 4;
    public Camera[] camera;
    public static GameObject ImageForMid, ImageForRich;
    public static GameObject ImageForBuyHouse;
	public static GameObject ImageForBuyOtherHouse;

    public static GameObject player1, player2, player3, player4, player5, player6, player7, player8;
    public GameObject ImageForJail;

    public static int diceSide1Thrown = 0;
    public static int diceSide2Thrown = 0;
	public static int diceSide3Thrown = 0;

    public static int player1Waypoint = 0;
    public static int player2Waypoint = 0;
    public static int player3Waypoint = 0;
    public static int player4Waypoint = 0;
    public static int player5Waypoint = 0;
    public static int player6Waypoint = 0;
    public static int player7Waypoint = 0;
    public static int player8Waypoint = 0;

    void Start () {

        payMoney.interactable = false;

        player1 = GameObject.Find("player1");
        player2 = GameObject.Find("player2");
        player3 = GameObject.Find("player3");
        player4 = GameObject.Find("player4");
        player5 = GameObject.Find("player5");
        player6 = GameObject.Find("player6");
        player7 = GameObject.Find("player7");
        player8 = GameObject.Find("player8");
        

        ImageForMid = GameObject.Find("ImageForMiddle");
        ImageForRich = GameObject.Find("ImageForRicher");
        ImageForMid.gameObject.SetActive(false);
        ImageForRich.gameObject.SetActive(false);

        ImageForBuyHouse = GameObject.Find("ImageForBuyingHouse");
        ImageForBuyHouse.gameObject.SetActive(false);

		ImageForBuyOtherHouse = GameObject.Find ("ImageForBuyingOtherHouse");
		ImageForBuyOtherHouse.gameObject.SetActive (false);

        ImageForJail = GameObject.Find("ImageForJail");
        ImageForJail.gameObject.SetActive(false);

        if (numberOfPlayer == 4)
        {
            player5.gameObject.SetActive(false);
            player6.gameObject.SetActive(false);
            player7.gameObject.SetActive(false);
            player8.gameObject.SetActive(false);
            text5.gameObject.SetActive(false);
            text6.gameObject.SetActive(false);
            text7.gameObject.SetActive(false);
            text8.gameObject.SetActive(false);
            player5Cost.gameObject.SetActive(false);
            player6Cost.gameObject.SetActive(false);
            player7Cost.gameObject.SetActive(false);
            player8Cost.gameObject.SetActive(false);
        }

        if(numberOfPlayer == 5)
        {
            player6.gameObject.SetActive(false);
            player7.gameObject.SetActive(false);
            player8.gameObject.SetActive(false);
            text6.gameObject.SetActive(false);
            text7.gameObject.SetActive(false);
            text8.gameObject.SetActive(false);
            player6Cost.gameObject.SetActive(false);
            player7Cost.gameObject.SetActive(false);
            player8Cost.gameObject.SetActive(false);
        }

        if (numberOfPlayer == 6)
        {
            player7.gameObject.SetActive(false);
            player8.gameObject.SetActive(false);
            text7.gameObject.SetActive(false);
            text8.gameObject.SetActive(false);
            player7Cost.gameObject.SetActive(false);
            player8Cost.gameObject.SetActive(false);
        }

        if (numberOfPlayer == 7)
        {
            player8.gameObject.SetActive(false);
            text8.gameObject.SetActive(false);
            player8Cost.gameObject.SetActive(false);
        }

        player1.GetComponent<FollowThePath>().moveAllowed = false;
        player2.GetComponent<FollowThePath>().moveAllowed = false;
        player3.GetComponent<FollowThePath>().moveAllowed = false;
        player4.GetComponent<FollowThePath>().moveAllowed = false;
        player5.GetComponent<FollowThePath>().moveAllowed = false;
        player6.GetComponent<FollowThePath>().moveAllowed = false;
        player7.GetComponent<FollowThePath>().moveAllowed = false;
        player8.GetComponent<FollowThePath>().moveAllowed = false;
    }

    void Update()
    {
        if (detect != 0)
        {
            payMoney.interactable = true;
        }

        if (detect >= 3)
        {
            buy.interactable = false;
        }

        if (Go1 == 1 || Go2 == 1 || Go3 == 1 || Go4 == 1 || Go5 == 1 || Go6 == 1 || Go7 == 1 || Go8 == 1)
        {
            if (Go1 == 1)
            {
                HouseSelection.sum1 += 200000;
                player1Cost.text = HouseSelection.sum1.ToString();
                Go1 = 0;
            }
            if (Go2 == 1)
            {
                HouseSelection.sum2 += 100000;
                player2Cost.text = HouseSelection.sum2.ToString();
                Go2 = 0;
            }
            if (Go3 == 1)
            {
                HouseSelection.sum3 += 100000;
                player3Cost.text = HouseSelection.sum3.ToString();
                Go3 = 0;
            }
            if (Go4 == 1)
            {
                HouseSelection.sum4 += 50000;
                player4Cost.text = HouseSelection.sum4.ToString();
                Go4 = 0;
            }
            if (Go5 == 1)
            {
                HouseSelection.sum5 += 50000;
                player5Cost.text = HouseSelection.sum5.ToString();
                Go5 = 0;
            }
            if (Go6 == 1)
            {
                HouseSelection.sum6 += 50000;
                player6Cost.text = HouseSelection.sum6.ToString();
            }
            if (Go7 == 1)
            {
                HouseSelection.sum7 += 50000;
                player7Cost.text = HouseSelection.sum7.ToString();
            }
            if (Go8 == 1)
            {
                HouseSelection.sum8 += 50000;
                player8Cost.text = HouseSelection.sum8.ToString();
            }
        }

        if (player1.GetComponent<FollowThePath>().wayPointIndex > player1Waypoint + diceSide1Thrown + diceSide2Thrown + diceSide3Thrown - player1.GetComponent<FollowThePath>().Accept)                                                                                                                                                              
        {
            whoTurn = 1;
            player1.GetComponent<FollowThePath>().moveAllowed = false;
            player1Waypoint = player1.GetComponent<FollowThePath>().wayPointIndex - 1;
            player1.GetComponent<FollowThePath>().Movement = 0;
            player1.GetComponent<FollowThePath>().Accept = 0;

            if(player1.GetComponent<FollowThePath>().transform.position == waypoints[1].transform.position)
            {
                detect = count1;
                houseName.text = "紅1";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count1 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }

				if (detect == 0) {
					ImageForBuyHouse.gameObject.SetActive (true);	
				} else {
					own = own1;
					if (detect == 1)
						Reduce = 10000;
					else if (detect == 2)
						Reduce = 15000;
					else if (detect == 3)
						Reduce = 20000;
					ReduceSum (1, Reduce, own);

                    if (own1 > 1)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }

                }

            }
            else if (player1.GetComponent<FollowThePath>().transform.position == waypoints[2].transform.position)
            {
                detect = count2;
                houseName.text = "紅2";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count2 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
				if (detect == 0) {
					ImageForBuyHouse.gameObject.SetActive (true);	
				} else {
					own = own2;
					if (detect == 1)
						Reduce = 10000;
					else if (detect == 2)
						Reduce = 15000;
					else if (detect == 3)
						Reduce = 20000;
					ReduceSum (1, Reduce, own);

					if (own2 > 1)
						ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player1.GetComponent<FollowThePath>().transform.position == waypoints[3].transform.position)
            {
                detect = count3;
                houseName.text = "紅3";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count3 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
				if (detect == 0) {
					ImageForBuyHouse.gameObject.SetActive (true);	
				} else {
					own = own3;
					if (detect == 1)
						Reduce = 10000;
					else if (detect == 2)
						Reduce = 15000;
					else if (detect == 3)
						Reduce = 20000;
					ReduceSum (1, Reduce, own);

					if (own3 > 1)
						ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player1.GetComponent<FollowThePath>().transform.position == waypoints[4].transform.position)
            {
                detect = count4;
                houseName.text = "紅4";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count4 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
				if (detect == 0) {
					ImageForBuyHouse.gameObject.SetActive (true);	
				} else {
					own = own4;
					if (detect == 1)
						Reduce = 10000;
					else if (detect == 2)
						Reduce = 15000;
					else if (detect == 3)
						Reduce = 20000;
					ReduceSum (1, Reduce, own);

					if (own4 > 1)
						ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player1.GetComponent<FollowThePath>().transform.position == waypoints[5].transform.position)
            {
                detect = count5;
                houseName.text = "紅5";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count5 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
				if (detect == 0) {
					ImageForBuyHouse.gameObject.SetActive (true);	
				} else {
					own = own5;
					if (detect == 1)
						Reduce = 10000;
					else if (detect == 2)
						Reduce = 15000;
					else if (detect == 3)
						Reduce = 20000;
					ReduceSum (1, Reduce, own);

					if (own5 > 1)
						ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player1.GetComponent<FollowThePath>().transform.position == waypoints[7].transform.position)
            {
                detect = count6;
                houseName.text = "紅6";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count6 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
				if (detect == 0) {
					ImageForBuyHouse.gameObject.SetActive (true);	
				} else {
					own = own6;
					if (detect == 1)
						Reduce = 10000;
					else if (detect == 2)
						Reduce = 15000;
					else if (detect == 3)
						Reduce = 20000;
					ReduceSum (1, Reduce, own);

					if (own6 > 1)
						ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player1.GetComponent<FollowThePath>().transform.position == waypoints[8].transform.position)
            {
                detect = count7;
                houseName.text = "紅7";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if(count7 == 0)
                {
                    HouseSelection.reduce = 10000;
                } else
                {
                    HouseSelection.reduce = 5000;
                }
				if (detect == 0) {
					ImageForBuyHouse.gameObject.SetActive (true);	
				} else {
					own = own7;
					if (detect == 1)
						Reduce = 10000;
					else if (detect == 2)
						Reduce = 15000;
					else if (detect == 3)
						Reduce = 20000;
					ReduceSum (1, Reduce, own);

					if (own7 > 1)
						ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player1.GetComponent<FollowThePath>().transform.position == waypoints[9].transform.position)
            {
                detect = count8;
                houseName.text = "橙1";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if(count8 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
				if (detect == 0) {
					ImageForBuyHouse.gameObject.SetActive (true);	
				} else {
					own = own8;
					if (detect == 1)
						Reduce = 15000;
					else if (detect == 2)
						Reduce = 21000;
					else if (detect == 3)
						Reduce = 27000;
					ReduceSum (1, Reduce, own);

					if (own8 > 1)
						ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player1.GetComponent<FollowThePath>().transform.position == waypoints[10].transform.position)
            {
                if(GameControl.count9 == 1) 
                {
                    buy.interactable = false;
                }
                detect = count9;
                houseName.text = "公共物業1";
                cost1.text = "$30000"; cost2.text = "+ NULL"; cost3.text = "+ $NULL";
                if (count9 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
				if (detect == 0) {
					ImageForBuyHouse.gameObject.SetActive (true);	
				} else {
					own = own9;
					if (detect == 1)
						Reduce = 30000;
					ReduceSum (1, Reduce, own);

                    dropButton.interactable = true;
                    camMain();
                    
                }
            }
            else if (player1.GetComponent<FollowThePath>().transform.position == waypoints[11].transform.position)
            {
                detect = count10;
                houseName.text = "橙2";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count10 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
				if (detect == 0) {
					ImageForBuyHouse.gameObject.SetActive (true);	
				} else {
					own = own10;
					if (detect == 1)
						Reduce = 15000;
					else if (detect == 2)
						Reduce = 21000;
					else if (detect == 3)
						Reduce = 27000;
					ReduceSum (1, Reduce, own);

					if (own10 > 1)
						ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player1.GetComponent<FollowThePath>().transform.position == waypoints[13].transform.position)
            {
                detect = count11;
                houseName.text = "橙3";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count11 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
				if (detect == 0) {
					ImageForBuyHouse.gameObject.SetActive (true);	
				} else {
					own = own11;
					if (detect == 1)
						Reduce = 15000;
					else if (detect == 2)
						Reduce = 21000;
					else if (detect == 3)
						Reduce = 27000;
					ReduceSum (1, Reduce, own);

					if (own11 > 1)
						ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player1.GetComponent<FollowThePath>().transform.position == waypoints[14].transform.position)
            {
                detect = count12;
                houseName.text = "橙4";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count12 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
				if (detect == 0) {
					ImageForBuyHouse.gameObject.SetActive (true);	
				} else {
					own = own12;
					if (detect == 1)
						Reduce = 15000;
					else if (detect == 2)
						Reduce = 21000;
					else if (detect == 3)
						Reduce = 27000;
					ReduceSum (1, Reduce, own);

					if (own12 > 1)
						ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player1.GetComponent<FollowThePath>().transform.position == waypoints[15].transform.position)
            {
                detect = count13;
                houseName.text = "橙5";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count13 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
				if (detect == 0) {
					ImageForBuyHouse.gameObject.SetActive (true);	
				} else {
					own = own13;
					if (detect == 1)
						Reduce = 15000;
					else if (detect == 2)
						Reduce = 21000;
					else if (detect == 3)
						Reduce = 27000;
					ReduceSum (1, Reduce, own);

					if (own13 > 1)
						ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player1.GetComponent<FollowThePath>().transform.position == waypoints[16].transform.position)
            {
                detect = count14;
                houseName.text = "橙6";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count14 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
				if (detect == 0) {
					ImageForBuyHouse.gameObject.SetActive (true);	
				} else {
					own = own14;
					if (detect == 1)
						Reduce = 15000;
					else if (detect == 2)
						Reduce = 21000;
					else if (detect == 3)
						Reduce = 27000;
					ReduceSum (1, Reduce, own);

					if (own14 > 1)
						ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player1.GetComponent<FollowThePath>().transform.position == waypoints[17].transform.position)
            {
                detect = count15;
                houseName.text = "橙7";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count15 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
				if (detect == 0) {
					ImageForBuyHouse.gameObject.SetActive (true);	
				} else {
					own = own15;
					if (detect == 1)
						Reduce = 15000;
					else if (detect == 2)
						Reduce = 21000;
					else if (detect == 3)
						Reduce = 27000;
					ReduceSum (1, Reduce, own);

					if (own15 > 1)
						ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player1.GetComponent<FollowThePath>().transform.position == waypoints[19].transform.position)
            {
                detect = count16;
                houseName.text = "黃1";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count16 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
				if (detect == 0) {
					ImageForBuyHouse.gameObject.SetActive (true);	
				} else {
					own = own16;
					if (detect == 1)
						Reduce = 20000;
					else if (detect == 2)
						Reduce = 27000;
					else if (detect == 3)
						Reduce = 34000;
					ReduceSum (1, Reduce, own);

					if (own16 > 1)
						ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player1.GetComponent<FollowThePath>().transform.position == waypoints[20].transform.position)
            {
                detect = count17;
                houseName.text = "黃2";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count17 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
				if (detect == 0) {
					ImageForBuyHouse.gameObject.SetActive (true);	
				} else {
					own = own17;
					if (detect == 1)
						Reduce = 20000;
					else if (detect == 2)
						Reduce = 27000;
					else if (detect == 3)
						Reduce = 34000;
					ReduceSum (1, Reduce, own);

					if (own17 > 1)
						ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player1.GetComponent<FollowThePath>().transform.position == waypoints[21].transform.position)
            {
                if (GameControl.count18 == 1)
                {
                    buy.interactable = false;
                }
                detect = count18;
                houseName.text = "公共物業2";
                cost1.text = "$30000"; cost2.text = "+ $NULL"; cost3.text = "+ $NULL";
                if (count18 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
				if (detect == 0) {
					ImageForBuyHouse.gameObject.SetActive (true);	
				} else {
					own = own18;
					if (detect == 1)
						Reduce = 30000;
					ReduceSum (1, Reduce, own);

                    dropButton.interactable = true;
                    camMain();
                    
                }
            }
            else if (player1.GetComponent<FollowThePath>().transform.position == waypoints[22].transform.position)
            {
                detect = count19;
                houseName.text = "黃3";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count19 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
				if (detect == 0) {
					ImageForBuyHouse.gameObject.SetActive (true);	
				} else {
					own = own19;
					if (detect == 1)
						Reduce = 20000;
					else if (detect == 2)
						Reduce = 27000;
					else if (detect == 3)
						Reduce = 34000;
					ReduceSum (1, Reduce, own);

					if (own19 > 1)
						ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player1.GetComponent<FollowThePath>().transform.position == waypoints[23].transform.position)
            {
                detect = count20;
                houseName.text = "黃4";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count20 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
				if (detect == 0) {
					ImageForBuyHouse.gameObject.SetActive (true);	
				} else {
					own = own20;
					if (detect == 1)
						Reduce = 20000;
					else if (detect == 2)
						Reduce = 27000;
					else if (detect == 3)
						Reduce = 34000;
					ReduceSum (1, Reduce, own);

					if (own20 > 1)
						ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player1.GetComponent<FollowThePath>().transform.position == waypoints[24].transform.position)
            {
                detect = count21;
                houseName.text = "黃5";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count21 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
				if (detect == 0) {
					ImageForBuyHouse.gameObject.SetActive (true);	
				} else {
					own = own21;
					if (detect == 1)
						Reduce = 20000;
					else if (detect == 2)
						Reduce = 27000;
					else if (detect == 3)
						Reduce = 34000;
					ReduceSum (1, Reduce, own);

					if (own21 > 1)
						ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player1.GetComponent<FollowThePath>().transform.position == waypoints[26].transform.position)
            {
                detect = count22;
                houseName.text = "黃6";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count22 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
				if (detect == 0) {
					ImageForBuyHouse.gameObject.SetActive (true);	
				} else {
					own = own22;
					if (detect == 1)
						Reduce = 20000;
					else if (detect == 2)
						Reduce = 27000;
					else if (detect == 3)
						Reduce = 34000;
					ReduceSum (1, Reduce, own);

					if (own22 > 1)
						ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player1.GetComponent<FollowThePath>().transform.position == waypoints[27].transform.position)
            {
                detect = count23;
                houseName.text = "黃7";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count23 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
				if (detect == 0) {
					ImageForBuyHouse.gameObject.SetActive (true);	
				} else {
					own = own23;
					if (detect == 1)
						Reduce = 20000;
					else if (detect == 2)
						Reduce = 27000;
					else if (detect == 3)
						Reduce = 34000;
					ReduceSum (1, Reduce, own);

					if (own23 > 1)
						ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player1.GetComponent<FollowThePath>().transform.position == waypoints[28].transform.position)
            {
                detect = count24;
                houseName.text = "綠1";
                cost1.text = "$30000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count24 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
				if (detect == 0) {
					ImageForBuyHouse.gameObject.SetActive (true);	
				} else {
					own = own24;
					if (detect == 1)
						Reduce = 30000;
					else if (detect == 2)
						Reduce = 38500;
					else if (detect == 3)
						Reduce = 47000;
					ReduceSum (1, Reduce, own);

					if (own24 > 1)
						ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player1.GetComponent<FollowThePath>().transform.position == waypoints[29].transform.position)
            {
                detect = count25;
                houseName.text = "綠2";
                cost1.text = "$30000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count25 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
				if (detect == 0) {
					ImageForBuyHouse.gameObject.SetActive (true);	
				} else {
					own = own25;
					if (detect == 1)
						Reduce = 30000;
					else if (detect == 2)
						Reduce = 38500;
					else if (detect == 3)
						Reduce = 47000;
					ReduceSum (1, Reduce, own);

					if (own25 > 1)
						ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player1.GetComponent<FollowThePath>().transform.position == waypoints[30].transform.position)
            {

                if (DiceNumberTextScript.jail2 == 1 || DiceNumberTextScript.jail3 == 1 || DiceNumberTextScript.jail4 == 1 || DiceNumberTextScript.jail5 == 1 || DiceNumberTextScript.jail6 == 1
                    || DiceNumberTextScript.jail7 == 1 || DiceNumberTextScript.jail8 == 1)
                {
                    if (DiceNumberTextScript.jail2 == 1)
                    {
                        jail2turn = 3;
                        DiceNumberTextScript.jail2 = 0;
                    }
                    if (DiceNumberTextScript.jail3 == 1)
                    {
                        jail3turn = 3;
                        DiceNumberTextScript.jail3 = 0;
                    }
                    if (DiceNumberTextScript.jail4 == 1)
                    {
                        jail4turn = 3;
                        DiceNumberTextScript.jail4 = 0;
                    }
                    if (DiceNumberTextScript.jail5 == 1)
                    {
                        jail5turn = 3;
                        DiceNumberTextScript.jail5 = 0;
                    }
                    if (DiceNumberTextScript.jail6 == 1)
                    {
                        jail6turn = 3;
                        DiceNumberTextScript.jail6 = 0;
                    }
                    if (DiceNumberTextScript.jail7 == 1)
                    {
                        jail7turn = 3;
                        DiceNumberTextScript.jail7 = 0;
                    }
                    if (DiceNumberTextScript.jail8 == 1)
                    {
                        jail8turn = 3;
                        DiceNumberTextScript.jail8 = 0;
                    }
                }

                DiceNumberTextScript.jail1 = 1;
                JailTurn.text = jail1turn.ToString();
                ImageForJail.gameObject.SetActive(true);

            }
            else if (player1.GetComponent<FollowThePath>().transform.position == waypoints[31].transform.position)
            {
                detect = count26;
                houseName.text = "綠3";
                cost1.text = "$30000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count26 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
				if (detect == 0) {
					ImageForBuyHouse.gameObject.SetActive (true);	
				} else {
					own = own26;
					if (detect == 1)
						Reduce = 30000;
					else if (detect == 2)
						Reduce = 38500;
					else if (detect == 3)
						Reduce = 47000;
					ReduceSum (1, Reduce, own);

					if (own26 > 1)
						ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player1.GetComponent<FollowThePath>().transform.position == waypoints[32].transform.position)
            {
                detect = count27;
                houseName.text = "綠4";
                cost1.text = "$30000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count27 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
				if (detect == 0) {
					ImageForBuyHouse.gameObject.SetActive (true);	
				} else {
					own = own27;
					if (detect == 1)
						Reduce = 30000;
					else if (detect == 2)
						Reduce = 38500;
					else if (detect == 3)
						Reduce = 47000;
					ReduceSum (1, Reduce, own);

					if (own27 > 1)
						ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player1.GetComponent<FollowThePath>().transform.position == waypoints[33].transform.position)
            {
                detect = count28;
                houseName.text = "綠5";
                cost1.text = "$30000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count28 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
				if (detect == 0) {
					ImageForBuyHouse.gameObject.SetActive (true);	
				} else {
					own = own28;
					if (detect == 1)
						Reduce = 30000;
					else if (detect == 2)
						Reduce = 38500;
					else if (detect == 3)
						Reduce = 47000;
					ReduceSum (1, Reduce, own);

					if (own28 > 1)
						ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player1.GetComponent<FollowThePath>().transform.position == waypoints[34].transform.position)
            {
                detect = count29;
                houseName.text = "綠6";
                cost1.text = "$30000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count29 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
				if (detect == 0) {
					ImageForBuyHouse.gameObject.SetActive (true);	
				} else {
					own = own29;
					if (detect == 1)
						Reduce = 30000;
					else if (detect == 2)
						Reduce = 38500;
					else if (detect == 3)
						Reduce = 47000;
					ReduceSum (1, Reduce, own);

					if (own29 > 1)
						ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player1.GetComponent<FollowThePath>().transform.position == waypoints[36].transform.position)
            {
                detect = count30;
                houseName.text = "藍1";
                cost1.text = "$50000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count30 == 0)
                {
                    HouseSelection.reduce = 50000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
				if (detect == 0) {
					ImageForBuyHouse.gameObject.SetActive (true);	
				} else {
					own = own30;
					if (detect == 1)
						Reduce = 50000;
					else if (detect == 2)
						Reduce = 58500;
					else if (detect == 3)
						Reduce = 67000;
					ReduceSum (1, Reduce, own);

					if (own30 > 1)
						ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player1.GetComponent<FollowThePath>().transform.position == waypoints[37].transform.position)
            {
                detect = count31;
                houseName.text = "藍2";
                cost1.text = "$50000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count31 == 0)
                {
                    HouseSelection.reduce = 50000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
				if (detect == 0) {
					ImageForBuyHouse.gameObject.SetActive (true);	
				} else {
					own = own31;
					if (detect == 1)
						Reduce = 50000;
					else if (detect == 2)
						Reduce = 58500;
					else if (detect == 3)
						Reduce = 67000;
					ReduceSum (1, Reduce, own);

					if (own31 > 1)
						ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player1.GetComponent<FollowThePath>().transform.position == waypoints[38].transform.position)
            {
                if (GameControl.count32 == 1)
                {
                    buy.interactable = false;
                }
                detect = count32;
                houseName.text = "公共物業3";
                cost1.text = "$30000"; cost2.text = "+ $NULL"; cost3.text = "+ $NULL";
                if (count32 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
				if (detect == 0) {
					ImageForBuyHouse.gameObject.SetActive (true);	
				} else {
					own = own32;
					if (detect == 1)
						Reduce = 30000;
					ReduceSum (1, Reduce, own);

                    dropButton.interactable = true;
                    camMain();

                }
            }
            else if (player1.GetComponent<FollowThePath>().transform.position == waypoints[39].transform.position)
            {
                detect = count33;
                houseName.text = "藍3";
                cost1.text = "$50000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count33 == 0)
                {
                    HouseSelection.reduce = 50000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
				if (detect == 0) {
					ImageForBuyHouse.gameObject.SetActive (true);	
				} else {
					own = own33;
					if (detect == 1)
						Reduce = 50000;
					else if (detect == 2)
						Reduce = 58500;
					else if (detect == 3)
						Reduce = 67000;
					ReduceSum (1, Reduce, own);

					if (own33 > 1)
						ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player1.GetComponent<FollowThePath>().transform.position == waypoints[40].transform.position)
            {
                detect = count34;
                houseName.text = "藍4";
                cost1.text = "$50000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count34 == 0)
                {
                    HouseSelection.reduce = 50000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
				if (detect == 0) {
					ImageForBuyHouse.gameObject.SetActive (true);	
				} else {
					own = own34;
					if (detect == 1)
						Reduce = 50000;
					else if (detect == 2)
						Reduce = 58500;
					else if (detect == 3)
						Reduce = 67000;
					ReduceSum (1, Reduce, own);

					if (own34 > 1)
						ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player1.GetComponent<FollowThePath>().transform.position == waypoints[42].transform.position)
            {
                detect = count35;
                houseName.text = "紫1";
                cost1.text = "$70000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count35 == 0)
                {
                    HouseSelection.reduce = 70000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
				if (detect == 0) {
					ImageForBuyHouse.gameObject.SetActive (true);	
				} else {
					own = own35;
					if (detect == 1)
						Reduce = 70000;
					else if (detect == 2)
						Reduce = 79000;
					else if (detect == 3)
						Reduce = 88000;
					ReduceSum (1, Reduce, own);

					if (own35 > 1)
						ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player1.GetComponent<FollowThePath>().transform.position == waypoints[43].transform.position)
            {
                detect = count36;
                houseName.text = "紫2";
                cost1.text = "$70000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count36 == 0)
                {
                    HouseSelection.reduce = 70000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
				if (detect == 0) {
					ImageForBuyHouse.gameObject.SetActive (true);	
				} else {
					own = own36;
					if (detect == 1)
						Reduce = 70000;
					else if (detect == 2)
						Reduce = 79000;
					else if (detect == 3)
						Reduce = 88000;
					ReduceSum (1, Reduce, own);

					if (own36 > 1)
						ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player1.GetComponent<FollowThePath>().transform.position == waypoints[44].transform.position)
            {
                detect = count37;
                houseName.text = "紫3";
                cost1.text = "$70000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count37 == 0)
                {
                    HouseSelection.reduce = 70000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
				if (detect == 0) {
					ImageForBuyHouse.gameObject.SetActive (true);	
				} else {
					own = own37;
					if (detect == 1)
						Reduce = 70000;
					else if (detect == 2)
						Reduce = 79000;
					else if (detect == 3)
						Reduce = 88000;
					ReduceSum (1, Reduce, own);

					if (own37 > 1)
						ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player1.GetComponent<FollowThePath>().transform.position == waypoints[47].transform.position)
            {
                detect = count38;
                houseName.text = "紫4";
                cost1.text = "$70000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count38 == 0)
                {
                    HouseSelection.reduce = 70000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
				if (detect == 0) {
					ImageForBuyHouse.gameObject.SetActive (true);	
				} else {
					own = own38;
					if (detect == 1)
						Reduce = 70000;
					else if (detect == 2)
						Reduce = 79000;
					else if (detect == 3)
						Reduce = 88000;
					ReduceSum (1, Reduce, own);

					if (own38 > 1)
						ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player1.GetComponent<FollowThePath>().transform.position == waypoints[48].transform.position)
            {
                detect = count39;
                houseName.text = "紫5";
                cost1.text = "$70000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count39 == 0)
                {
                    HouseSelection.reduce = 70000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
				if (detect == 0) {
					ImageForBuyHouse.gameObject.SetActive (true);	
				} else {
					own = own39;
					if (detect == 1)
						Reduce = 70000;
					else if (detect == 2)
						Reduce = 79000;
					else if (detect == 3)
						Reduce = 88000;
					ReduceSum (1, Reduce, own);

					if (own39 > 1)
						ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player1.GetComponent<FollowThePath>().transform.position == waypoints[49].transform.position)
            {
                detect = count40;
                houseName.text = "啡1";
                cost1.text = "$85000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count40 == 0)
                {
                    HouseSelection.reduce = 85000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
				if (detect == 0) {
					ImageForBuyHouse.gameObject.SetActive (true);	
				} else {
					own = own40;
					if (detect == 1)
						Reduce = 85000;
					else if (detect == 2)
						Reduce = 94000;
					else if (detect == 3)
						Reduce = 108000;
					ReduceSum (1, Reduce, own);
					if (own40 > 1)
						ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player1.GetComponent<FollowThePath>().transform.position == waypoints[50].transform.position)
            {
                detect = count41;
                houseName.text = "公共物業4";
                cost1.text = "$30000"; cost2.text = "+ $NULL"; cost3.text = "+ $NULL";
                if (count41 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
				if (detect == 0) {
					ImageForBuyHouse.gameObject.SetActive (true);	
				} else {
					own = own41;
					if (detect == 1)
						Reduce = 30000;
					ReduceSum (1, Reduce, own);

                   dropButton.interactable = true;
                   camMain();
                }
            }
            else if (player1.GetComponent<FollowThePath>().transform.position == waypoints[51].transform.position)
            {
                if (GameControl.count42 == 1)
                {
                    buy.interactable = false;
                }
                detect = count42;
                houseName.text = "啡2";
                cost1.text = "$85000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count42 == 0)
                {
                    HouseSelection.reduce = 85000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
				if (detect == 0) {
					ImageForBuyHouse.gameObject.SetActive (true);	
				} else {
					own = own42;
					if (detect == 1)
						Reduce = 85000;
					else if (detect == 2)
						Reduce = 94000;
					else if (detect == 3)
						Reduce = 108000;
					ReduceSum (1, Reduce, own);

					if (own42 > 1)
						ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player1.GetComponent<FollowThePath>().transform.position == waypoints[52].transform.position)
            {
                detect = count43;
                houseName.text = "啡3";
                cost1.text = "$85000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count43 == 0)
                {
                    HouseSelection.reduce = 85000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
				if (detect == 0) {
					ImageForBuyHouse.gameObject.SetActive (true);	
				} else {
					own = own43;
					if (detect == 1)
						Reduce = 85000;
					else if (detect == 2)
						Reduce = 94000;
					else if (detect == 3)
						Reduce = 108000;
					ReduceSum (1, Reduce, own);

					if (own43 > 1)
						ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player1.GetComponent<FollowThePath>().transform.position == waypoints[55].transform.position)
            {
                detect = count44;
                houseName.text = "黑1";
                cost1.text = "$100000"; cost2.text = "+ $10000"; cost3.text = "+ $10000";
                if (count44 == 0)
                {
                    HouseSelection.reduce = 100000;
                }
                else
                {
                    HouseSelection.reduce = 10000;
                }
				if (detect == 0) {
					ImageForBuyHouse.gameObject.SetActive (true);	
				} else {
					own = own44;
					if (detect == 1)
						Reduce = 100000;
					else if (detect == 2)
						Reduce = 110000;
					else if (detect == 3)
						Reduce = 120000;
					ReduceSum (1, Reduce, own);

					if (own44 > 1)
						ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player1.GetComponent<FollowThePath>().transform.position == waypoints[56].transform.position)
            {
                detect = count45;
                houseName.text = "黑2";
                cost1.text = "$100000"; cost2.text = "+ $10000"; cost3.text = "+ $10000";
                if (count45 == 0)
                {
                    HouseSelection.reduce = 100000;
                }
                else
                {
                    HouseSelection.reduce = 10000;
                }
				if (detect == 0) {
					ImageForBuyHouse.gameObject.SetActive (true);	
				} else {
					own = own45;
					if (detect == 1)
						Reduce = 100000;
					else if (detect == 2)
						Reduce = 110000;
					else if (detect == 3)
						Reduce = 120000;
					ReduceSum (1, Reduce, own);

					if (own45 > 1)
						ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player1.GetComponent<FollowThePath>().transform.position == waypoints[57].transform.position)
            {
                detect = count46;
                houseName.text = "黑3";
                cost1.text = "$100000"; cost2.text = "+ $10000"; cost3.text = "+ $10000";
                if (count46 == 0)
                {
                    HouseSelection.reduce = 100000;
                }
                else
                {
                    HouseSelection.reduce = 10000;
                }
				if (detect == 0) {
					ImageForBuyHouse.gameObject.SetActive (true);	
				} else {
					own = own46;
					if (detect == 1)
						Reduce = 100000;
					else if (detect == 2)
						Reduce = 110000;
					else if (detect == 3)
						Reduce = 110000;
					ReduceSum (1, Reduce, own);

					if (own46 > 1)
						ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else
            {
                dropButton.interactable = true;
                camMain();
            }

        }
                                                                                                        
		if (player2.GetComponent<FollowThePath>().wayPointIndex > player2Waypoint + diceSide1Thrown + diceSide2Thrown + diceSide3Thrown - player2.GetComponent<FollowThePath>().Accept)
        {
            whoTurn = 2;
            player2.GetComponent<FollowThePath>().moveAllowed = false;
            player2Waypoint = player2.GetComponent<FollowThePath>().wayPointIndex - 1;
            player2.GetComponent<FollowThePath>().Movement = 0;
            player2.GetComponent<FollowThePath>().Accept = 0;

            if (player2.GetComponent<FollowThePath>().transform.position == waypoints[1].transform.position)
            {
                detect = count1;
                houseName.text = "紅1";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count1 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own1;
                    if (detect == 1)
                        Reduce = 10000;
                    else if (detect == 2)
                        Reduce = 15000;
                    else if (detect == 3)
                        Reduce = 20000;
                    ReduceSum(2, Reduce, own);
                    if (own1 >= 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player2.GetComponent<FollowThePath>().transform.position == waypoints[2].transform.position)
            {
                detect = count2;
                houseName.text = "紅2";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count2 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own2;
                    if (detect == 1)
                        Reduce = 10000;
                    else if (detect == 2)
                        Reduce = 15000;
                    else if (detect == 3)
                        Reduce = 20000;
                    ReduceSum(2, Reduce, own);

                    if (own2 >= 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player2.GetComponent<FollowThePath>().transform.position == waypoints[3].transform.position)
            {
                detect = count3;
                houseName.text = "紅3";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count3 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own3;
                    if (detect == 1)
                        Reduce = 10000;
                    else if (detect == 2)
                        Reduce = 15000;
                    else if (detect == 3)
                        Reduce = 20000;
                    ReduceSum(2, Reduce, own);

                    if (own3 >= 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player2.GetComponent<FollowThePath>().transform.position == waypoints[4].transform.position)
            {
                detect = count4;
                houseName.text = "紅4";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count4 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own4;
                    if (detect == 1)
                        Reduce = 10000;
                    else if (detect == 2)
                        Reduce = 15000;
                    else if (detect == 3)
                        Reduce = 20000;
                    ReduceSum(2, Reduce, own);

                    if (own4 >= 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player2.GetComponent<FollowThePath>().transform.position == waypoints[5].transform.position)
            {
                detect = count5;
                houseName.text = "紅5";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count5 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own5;
                    if (detect == 1)
                        Reduce = 10000;
                    else if (detect == 2)
                        Reduce = 15000;
                    else if (detect == 3)
                        Reduce = 20000;
                    ReduceSum(2, Reduce, own);

                    if (own5 >= 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player2.GetComponent<FollowThePath>().transform.position == waypoints[7].transform.position)
            {
                detect = count6;
                houseName.text = "紅6";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count6 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own6;
                    if (detect == 1)
                        Reduce = 10000;
                    else if (detect == 2)
                        Reduce = 15000;
                    else if (detect == 3)
                        Reduce = 20000;
                    ReduceSum(2, Reduce, own);

                    if (own6 >= 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player2.GetComponent<FollowThePath>().transform.position == waypoints[8].transform.position)
            {
                detect = count7;
                houseName.text = "紅7";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count7 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own7;
                    if (detect == 1)
                        Reduce = 10000;
                    else if (detect == 2)
                        Reduce = 15000;
                    else if (detect == 3)
                        Reduce = 20000;
                    ReduceSum(2, Reduce, own);

                    if (own7 >= 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player2.GetComponent<FollowThePath>().transform.position == waypoints[9].transform.position)
            {
                detect = count8;
                houseName.text = "橙1";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count8 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own8;
                    if (detect == 1)
                        Reduce = 15000;
                    else if (detect == 2)
                        Reduce = 21000;
                    else if (detect == 3)
                        Reduce = 27000;
                    ReduceSum(2, Reduce, own);

                    if (own8 >= 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player2.GetComponent<FollowThePath>().transform.position == waypoints[10].transform.position)
            {
                if (GameControl.count9 == 1)
                {
                    buy.interactable = false;
                }
                detect = count9;
                houseName.text = "公共物業1";
                cost1.text = "$30000"; cost2.text = "+ NULL"; cost3.text = "+ $NULL";
                if (count9 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own9;
                    if (detect == 1)
                        Reduce = 30000;
                    ReduceSum(2, Reduce, own);

                    dropButton.interactable = true;
                    camMain();
                }
            }
            else if (player2.GetComponent<FollowThePath>().transform.position == waypoints[11].transform.position)
            {
                detect = count10;
                houseName.text = "橙2";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count10 == 0)
                {
                    HouseSelection.reduce = 150000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
                                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own10;
                    if (detect == 1)
                        Reduce = 15000;
                    else if (detect == 2)
                        Reduce = 21000;
                    else if (detect == 3)
                        Reduce = 27000;
                    ReduceSum(2, Reduce, own);

                    if (own10 >= 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player2.GetComponent<FollowThePath>().transform.position == waypoints[13].transform.position)
            {
                detect = count11;
                houseName.text = "橙3";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count11 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own11;
                    if (detect == 1)
                        Reduce = 15000;
                    else if (detect == 2)
                        Reduce = 21000;
                    else if (detect == 3)
                        Reduce = 27000;
                    ReduceSum(2, Reduce, own);

                    if (own11 >= 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player2.GetComponent<FollowThePath>().transform.position == waypoints[14].transform.position)
            {
                detect = count12;
                houseName.text = "橙4";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count12 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own12;
                    if (detect == 1)
                        Reduce = 15000;
                    else if (detect == 2)
                        Reduce = 21000;
                    else if (detect == 3)
                        Reduce = 27000;
                    ReduceSum(2, Reduce, own);

                    if (own12 >= 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player2.GetComponent<FollowThePath>().transform.position == waypoints[15].transform.position)
            {
                detect = count13;
                houseName.text = "橙5";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count13 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own13;
                    if (detect == 1)
                        Reduce = 15000;
                    else if (detect == 2)
                        Reduce = 21000;
                    else if (detect == 3)
                        Reduce = 27000;
                    ReduceSum(2, Reduce, own);

                    if (own13 >= 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player2.GetComponent<FollowThePath>().transform.position == waypoints[16].transform.position)
            {
                detect = count14;
                houseName.text = "橙6";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count14 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own14;
                    if (detect == 1)
                        Reduce = 15000;
                    else if (detect == 2)
                        Reduce = 21000;
                    else if (detect == 3)
                        Reduce = 27000;
                    ReduceSum(2, Reduce, own);

                    if (own14 >= 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player2.GetComponent<FollowThePath>().transform.position == waypoints[17].transform.position)
            {
                detect = count15;
                houseName.text = "橙7";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count15 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own15;
                    if (detect == 1)
                        Reduce = 15000;
                    else if (detect == 2)
                        Reduce = 21000;
                    else if (detect == 3)
                        Reduce = 27000;
                    ReduceSum(2, Reduce, own);

                    if (own15 >= 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player2.GetComponent<FollowThePath>().transform.position == waypoints[19].transform.position)
            {
                detect = count16;
                houseName.text = "黃1";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count16 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own16;
                    if (detect == 1)
                        Reduce = 20000;
                    else if (detect == 2)
                        Reduce = 27000;
                    else if (detect == 3)
                        Reduce = 34000;
                    ReduceSum(2, Reduce, own);

                    if (own16 >= 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player2.GetComponent<FollowThePath>().transform.position == waypoints[20].transform.position)
            {
                detect = count17;
                houseName.text = "黃2";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count17 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own17;
                    if (detect == 1)
                        Reduce = 20000;
                    else if (detect == 2)
                        Reduce = 27000;
                    else if (detect == 3)
                        Reduce = 34000;
                    ReduceSum(2, Reduce, own);

                    if (own17 >= 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player2.GetComponent<FollowThePath>().transform.position == waypoints[21].transform.position)
            {
                if (GameControl.count18 == 1)
                {
                    buy.interactable = false;
                }
                detect = count18;
                houseName.text = "公共物業2";
                cost1.text = "$30000"; cost2.text = "+ $NULL"; cost3.text = "+ $NULL";
                if (count18 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own18;
                    if (detect == 1)
                        Reduce = 20000;
                    ReduceSum(2, Reduce, own);

                    dropButton.interactable = true;
                    camMain();

                }
            }
            else if (player2.GetComponent<FollowThePath>().transform.position == waypoints[22].transform.position)
            {
                detect = count19;
                houseName.text = "黃3";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count19 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own19;
                    if (detect == 1)
                        Reduce = 20000;
                    else if (detect == 2)
                        Reduce = 27000;
                    else if (detect == 3)
                        Reduce = 34000;
                    ReduceSum(2, Reduce, own);

                    if (own19 >= 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player2.GetComponent<FollowThePath>().transform.position == waypoints[23].transform.position)
            {
                detect = count20;
                houseName.text = "黃4";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count20 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own20;
                    if (detect == 1)
                        Reduce = 20000;
                    else if (detect == 2)
                        Reduce = 27000;
                    else if (detect == 3)
                        Reduce = 34000;
                    ReduceSum(2, Reduce, own);

                    if (own20 >= 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player2.GetComponent<FollowThePath>().transform.position == waypoints[24].transform.position)
            {
                detect = count21;
                houseName.text = "黃5";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count21 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own21;
                    if (detect == 1)
                        Reduce = 20000;
                    else if (detect == 2)
                        Reduce = 27000;
                    else if (detect == 3)
                        Reduce = 34000;
                    ReduceSum(2, Reduce, own);

                    if (own21 >= 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player2.GetComponent<FollowThePath>().transform.position == waypoints[26].transform.position)
            {
                detect = count22;
                houseName.text = "黃6";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count22 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own22;
                    if (detect == 1)
                        Reduce = 20000;
                    else if (detect == 2)
                        Reduce = 27000;
                    else if (detect == 3)
                        Reduce = 34000;
                    ReduceSum(2, Reduce, own);

                    if (own22 >= 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player2.GetComponent<FollowThePath>().transform.position == waypoints[27].transform.position)
            {
                detect = count23;
                houseName.text = "黃7";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count23 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own23;
                    if (detect == 1)
                        Reduce = 20000;
                    else if (detect == 2)
                        Reduce = 27000;
                    else if (detect == 3)
                        Reduce = 34000;
                    ReduceSum(2, Reduce, own);

                    if (own23 >= 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player2.GetComponent<FollowThePath>().transform.position == waypoints[28].transform.position)
            {
                detect = count24;
                houseName.text = "綠1";
                cost1.text = "$30000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count24 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own24;
                    if (detect == 1)
                        Reduce = 30000;
                    else if (detect == 2)
                        Reduce = 38500;
                    else if (detect == 3)
                        Reduce = 47000;
                    ReduceSum(2, Reduce, own);

                    if (own24 >= 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player2.GetComponent<FollowThePath>().transform.position == waypoints[29].transform.position)
            {
                detect = count25;
                houseName.text = "綠2";
                cost1.text = "$30000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count25 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own25;
                    if (detect == 1)
                        Reduce = 30000;
                    else if (detect == 2)
                        Reduce = 38500;
                    else if (detect == 3)
                        Reduce = 47000;
                    ReduceSum(2, Reduce, own);

                    if (own25 >= 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player2.GetComponent<FollowThePath>().transform.position == waypoints[30].transform.position)
            {
                if (DiceNumberTextScript.jail1 == 1 || DiceNumberTextScript.jail3 == 1 || DiceNumberTextScript.jail4 == 1 || DiceNumberTextScript.jail5 == 1 || DiceNumberTextScript.jail6 == 1
                    || DiceNumberTextScript.jail7 == 1 || DiceNumberTextScript.jail8 == 1)
                {
                    if (DiceNumberTextScript.jail1 == 1)
                    {
                        jail1turn = 3;
                        DiceNumberTextScript.jail1 = 0;
                    }
                    if (DiceNumberTextScript.jail3 == 1)
                    {
                        jail3turn = 3;
                        DiceNumberTextScript.jail3 = 0;
                    }
                    if (DiceNumberTextScript.jail4 == 1)
                    {
                        jail4turn = 3;
                        DiceNumberTextScript.jail4 = 0;
                    }
                    if (DiceNumberTextScript.jail5 == 1)
                    {
                        jail5turn = 3;
                        DiceNumberTextScript.jail5 = 0;
                    }
                    if (DiceNumberTextScript.jail6 == 1)
                    {
                        jail6turn = 3;
                        DiceNumberTextScript.jail6 = 0;
                    }
                    if (DiceNumberTextScript.jail7 == 1)
                    {
                        jail7turn = 3;
                        DiceNumberTextScript.jail7 = 0;
                    }
                    if (DiceNumberTextScript.jail8 == 1)
                    {
                        jail8turn = 3;
                        DiceNumberTextScript.jail8 = 0;
                    }

                }

                DiceNumberTextScript.jail2 = 1;
                JailTurn.text = jail2turn.ToString();
                ImageForJail.gameObject.SetActive(true);
            }
            else if (player2.GetComponent<FollowThePath>().transform.position == waypoints[31].transform.position)
            {
                detect = count26;
                houseName.text = "綠3";
                cost1.text = "$30000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count26 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own26;
                    if (detect == 1)
                        Reduce = 30000;
                    else if (detect == 2)
                        Reduce = 38500;
                    else if (detect == 3)
                        Reduce = 47000;
                    ReduceSum(2, Reduce, own);

                    if (own26 >= 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player2.GetComponent<FollowThePath>().transform.position == waypoints[32].transform.position)
            {
                detect = count27;
                houseName.text = "綠4";
                cost1.text = "$30000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count27 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own27;
                    if (detect == 1)
                        Reduce = 30000;
                    else if (detect == 2)
                        Reduce = 38500;
                    else if (detect == 3)
                        Reduce = 47000;
                    ReduceSum(2, Reduce, own);

                    if (own27 >= 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player2.GetComponent<FollowThePath>().transform.position == waypoints[33].transform.position)
            {
                detect = count28;
                houseName.text = "綠5";
                cost1.text = "$30000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count28 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own28;
                    if (detect == 1)
                        Reduce = 30000;
                    ReduceSum(2, Reduce, own);

                    if (own28 >= 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }

                }
            }
            else if (player2.GetComponent<FollowThePath>().transform.position == waypoints[34].transform.position)
            {
                detect = count29;
                houseName.text = "綠6";
                cost1.text = "$30000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count29 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own29;
                    if (detect == 1)
                        Reduce = 30000;
                    else if (detect == 2)
                        Reduce = 38500;
                    else if (detect == 3)
                        Reduce = 47000;
                    ReduceSum(2, Reduce, own);

                    if (own29 >= 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player2.GetComponent<FollowThePath>().transform.position == waypoints[36].transform.position)
            {
                detect = count30;
                houseName.text = "藍1";
                cost1.text = "$50000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count30 == 0)
                {
                    HouseSelection.reduce = 50000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own30;
                    if (detect == 1)
                        Reduce = 50000;
                    else if (detect == 2)
                        Reduce = 58500;
                    else if (detect == 3)
                        Reduce = 67000;
                    ReduceSum(2, Reduce, own);

                    if (own30 >= 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player2.GetComponent<FollowThePath>().transform.position == waypoints[37].transform.position)
            {
                detect = count31;
                houseName.text = "藍2";
                cost1.text = "$50000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count31 == 0)
                {
                    HouseSelection.reduce = 50000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own31;
                    if (detect == 1)
                        Reduce = 50000;
                    else if (detect == 2)
                        Reduce = 58500;
                    else if (detect == 3)
                        Reduce = 67000;
                    ReduceSum(2, Reduce, own);

                    if (own31 >= 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player2.GetComponent<FollowThePath>().transform.position == waypoints[38].transform.position)
            {
                if (GameControl.count32 == 1)
                {
                    buy.interactable = false;
                }
                detect = count32;
                houseName.text = "公共物業3";
                cost1.text = "$30000"; cost2.text = "+ $NULL"; cost3.text = "+ $NULL";
                if (count32 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own32;
                    if (detect == 1)
                        Reduce = 30000;
                    ReduceSum(2, Reduce, own);

                    dropButton.interactable = true;
                    camMain();

                }
            }
            else if (player2.GetComponent<FollowThePath>().transform.position == waypoints[39].transform.position)
            {
                detect = count33;
                houseName.text = "藍3";
                cost1.text = "$50000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count33 == 0)
                {
                    HouseSelection.reduce = 50000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own33;
                    if (detect == 1)
                        Reduce = 50000;
                    else if (detect == 2)
                        Reduce = 58500;
                    else if (detect == 3)
                        Reduce = 67000;
                    ReduceSum(2, Reduce, own);

                    if (own33 >= 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player2.GetComponent<FollowThePath>().transform.position == waypoints[40].transform.position)
            {
                detect = count34;
                houseName.text = "藍4";
                cost1.text = "$50000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count34 == 0)
                {
                    HouseSelection.reduce = 50000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own34;
                    if (detect == 1)
                        Reduce = 50000;
                    else if (detect == 2)
                        Reduce = 58500;
                    else if (detect == 3)
                        Reduce = 67000;
                    ReduceSum(2, Reduce, own);

                    if (own34 >= 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player2.GetComponent<FollowThePath>().transform.position == waypoints[42].transform.position)
            {
                detect = count35;
                houseName.text = "紫1";
                cost1.text = "$70000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count35 == 0)
                {
                    HouseSelection.reduce = 70000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own35;
                    if (detect == 1)
                        Reduce = 70000;
                    else if (detect == 2)
                        Reduce = 79000;
                    else if (detect == 3)
                        Reduce = 88000;
                    ReduceSum(2, Reduce, own);

                    if (own35 >= 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player2.GetComponent<FollowThePath>().transform.position == waypoints[43].transform.position)
            {
                detect = count36;
                houseName.text = "紫2";
                cost1.text = "$70000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count36 == 0)
                {
                    HouseSelection.reduce = 70000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own36;
                    if (detect == 1)
                        Reduce = 70000;
                    else if (detect == 2)
                        Reduce = 79000;
                    else if (detect == 3)
                        Reduce = 88000;
                    ReduceSum(2, Reduce, own);

                    if (own36 >= 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player2.GetComponent<FollowThePath>().transform.position == waypoints[44].transform.position)
            {
                detect = count37;
                houseName.text = "紫3";
                cost1.text = "$70000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count37 == 0)
                {
                    HouseSelection.reduce = 70000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own37;
                    if (detect == 1)
                        Reduce = 70000;
                    else if (detect == 2)
                        Reduce = 79000;
                    else if (detect == 3)
                        Reduce = 88000;
                    ReduceSum(2, Reduce, own);

                    if (own37 >= 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player2.GetComponent<FollowThePath>().transform.position == waypoints[47].transform.position)
            {
                detect = count38;
                houseName.text = "紫4";
                cost1.text = "$70000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count38 == 0)
                {
                    HouseSelection.reduce = 70000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own38;
                    if (detect == 1)
                        Reduce = 70000;
                    else if (detect == 2)
                        Reduce = 79000;
                    else if (detect == 3)
                        Reduce = 88000;
                    ReduceSum(2, Reduce, own);

                    if (own38 >= 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player2.GetComponent<FollowThePath>().transform.position == waypoints[48].transform.position)
            {
                detect = count39;
                houseName.text = "紫5";
                cost1.text = "$70000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count39 == 0)
                {
                    HouseSelection.reduce = 70000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own39;
                    if (detect == 1)
                        Reduce = 70000;
                    else if (detect == 2)
                        Reduce = 79000;
                    else if (detect == 3)
                        Reduce = 88000;
                    ReduceSum(2, Reduce, own);

                    if (own39 >= 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player2.GetComponent<FollowThePath>().transform.position == waypoints[49].transform.position)
            {
                detect = count40;
                houseName.text = "啡1";
                cost1.text = "$85000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count40 == 0)
                {
                    HouseSelection.reduce = 85000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own40;
                    if (detect == 1)
                        Reduce = 85000;
                    else if (detect == 2)
                        Reduce = 94000;
                    else if (detect == 3)
                        Reduce = 108000;
                    ReduceSum(2, Reduce, own);

                    if (own40 >= 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player2.GetComponent<FollowThePath>().transform.position == waypoints[50].transform.position)
            {
                detect = count41;
                houseName.text = "公共物業4";
                cost1.text = "$30000"; cost2.text = "+ $NULL"; cost3.text = "+ $NULL";
                if (count41 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own36;
                    if (detect == 1)
                        Reduce = 30000;
                    ReduceSum(2, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                

                }
            }
            else if (player2.GetComponent<FollowThePath>().transform.position == waypoints[51].transform.position)
            {
                if (GameControl.count42 == 1)
                {
                    buy.interactable = false;
                }
                detect = count42;
                houseName.text = "啡2";
                cost1.text = "$85000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count42 == 0)
                {
                    HouseSelection.reduce = 85000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own42;
                    if (detect == 1)
                        Reduce = 85000;
                    else if (detect == 2)
                        Reduce = 94000;
                    else if (detect == 3)
                        Reduce = 108000;
                    ReduceSum(2, Reduce, own);

                    if (own42 >= 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player2.GetComponent<FollowThePath>().transform.position == waypoints[52].transform.position)
            {
                detect = count43;
                houseName.text = "啡3";
                cost1.text = "$85000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count43 == 0)
                {
                    HouseSelection.reduce = 85000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own43;
                    if (detect == 1)
                        Reduce = 85000;
                    else if (detect == 2)
                        Reduce = 94000;
                    else if (detect == 3)
                        Reduce = 108000;
                    ReduceSum(2, Reduce, own);

                    if (own43 >= 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player2.GetComponent<FollowThePath>().transform.position == waypoints[55].transform.position)
            {
                detect = count44;
                houseName.text = "黑1";
                cost1.text = "$100000"; cost2.text = "+ $10000"; cost3.text = "+ $10000";
                if (count44 == 0)
                {
                    HouseSelection.reduce = 100000;
                }
                else
                {
                    HouseSelection.reduce = 10000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own44;
                    if (detect == 1)
                        Reduce = 100000;
                    else if (detect == 2)
                        Reduce = 110000;
                    else if (detect == 3)
                        Reduce = 120000;
                    ReduceSum(2, Reduce, own);

                    if (own44 >= 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player2.GetComponent<FollowThePath>().transform.position == waypoints[56].transform.position)
            {
                detect = count45;
                houseName.text = "黑2";
                cost1.text = "$100000"; cost2.text = "+ $10000"; cost3.text = "+ $10000";
                if (count45 == 0)
                {
                    HouseSelection.reduce = 100000;
                }
                else
                {
                    HouseSelection.reduce = 10000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own45;
                    if (detect == 1)
                        Reduce = 100000;
                    else if (detect == 2)
                        Reduce = 110000;
                    else if (detect == 3)
                        Reduce = 120000;
                    ReduceSum(2, Reduce, own);

                    if (own45 >= 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player2.GetComponent<FollowThePath>().transform.position == waypoints[57].transform.position)
            {
                detect = count46;
                houseName.text = "黑3";
                cost1.text = "$100000"; cost2.text = "+ $10000"; cost3.text = "+ $10000";
                if (count46 == 0)
                {
                    HouseSelection.reduce = 100000;
                }
                else
                {
                    HouseSelection.reduce = 10000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own46;
                    if (detect == 1)
                        Reduce = 100000;
                    else if (detect == 2)
                        Reduce = 110000;
                    else if (detect == 3)
                        Reduce = 120000;
                    ReduceSum(2, Reduce, own);

                    if (own46 >= 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else
            {
                dropButton.interactable = true;
                camMain();
            }
        }

        if (player3.GetComponent<FollowThePath>().wayPointIndex > player3Waypoint + diceSide1Thrown + diceSide2Thrown + diceSide3Thrown - player3.GetComponent<FollowThePath>().Accept)
        {
            whoTurn = 3;
            player3.GetComponent<FollowThePath>().moveAllowed = false;
            player3Waypoint = player3.GetComponent<FollowThePath>().wayPointIndex - 1;
            player3.GetComponent<FollowThePath>().Movement = 0;
            player3.GetComponent<FollowThePath>().Accept = 0;

            if (player3.GetComponent<FollowThePath>().transform.position == waypoints[1].transform.position)
            {
                detect = count1;
                houseName.text = "紅1";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count1 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own1;
                    if (detect == 1)
                        Reduce = 10000;
                    else if (detect == 2)
                        Reduce = 15000;
                    else if (detect == 3)
                        Reduce = 20000;
                    ReduceSum(3, Reduce, own);

                    if (own1 >= 3 || own1 == 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player3.GetComponent<FollowThePath>().transform.position == waypoints[2].transform.position)
            {
                detect = count2;
                houseName.text = "紅2";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count2 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own2;
                    if (detect == 1)
                        Reduce = 10000;
                    else if (detect == 2)
                        Reduce = 15000;
                    else if (detect == 3)
                        Reduce = 20000;
                    ReduceSum(3, Reduce, own);

                    if (own2 >= 3 || own2 == 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player3.GetComponent<FollowThePath>().transform.position == waypoints[3].transform.position)
            {
                detect = count3;
                houseName.text = "紅3";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count3 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own3;
                    if (detect == 1)
                        Reduce = 10000;
                    else if (detect == 2)
                        Reduce = 15000;
                    else if (detect == 3)
                        Reduce = 20000;
                    ReduceSum(3, Reduce, own);

                    if (own3 >= 3 || own3 == 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player3.GetComponent<FollowThePath>().transform.position == waypoints[4].transform.position)
            {
                detect = count4;
                houseName.text = "紅4";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count4 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own4;
                    if (detect == 1)
                        Reduce = 10000;
                    else if (detect == 2)
                        Reduce = 15000;
                    else if (detect == 3)
                        Reduce = 20000;
                    ReduceSum(3, Reduce, own);

                    if (own4 >= 3 || own4 == 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player3.GetComponent<FollowThePath>().transform.position == waypoints[5].transform.position)
            {
                detect = count5;
                houseName.text = "紅5";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count5 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own5;
                    if (detect == 1)
                        Reduce = 10000;
                    else if (detect == 2)
                        Reduce = 15000;
                    else if (detect == 3)
                        Reduce = 20000;
                    ReduceSum(3, Reduce, own);

                    if (own5 >= 3 || own5 == 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player3.GetComponent<FollowThePath>().transform.position == waypoints[7].transform.position)
            {
                detect = count6;
                houseName.text = "紅6";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count6 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own6;
                    if (detect == 1)
                        Reduce = 10000;
                    else if (detect == 2)
                        Reduce = 15000;
                    else if (detect == 3)
                        Reduce = 20000;
                    ReduceSum(3, Reduce, own);

                    if (own6 >= 3 || own6 == 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player3.GetComponent<FollowThePath>().transform.position == waypoints[8].transform.position)
            {
                detect = count7;
                houseName.text = "紅7";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count7 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own7;
                    if (detect == 1)
                        Reduce = 10000;
                    else if (detect == 2)
                        Reduce = 15000;
                    else if (detect == 3)
                        Reduce = 20000;
                    ReduceSum(3, Reduce, own);

                    if (own7 >= 3 || own7 == 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player3.GetComponent<FollowThePath>().transform.position == waypoints[9].transform.position)
            {
                detect = count8;
                houseName.text = "橙1";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count8 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own8;
                    if (detect == 1)
                        Reduce = 15000;
                    else if (detect == 2)
                        Reduce = 21000;
                    else if (detect == 3)
                        Reduce = 27000;
                    ReduceSum(3, Reduce, own);

                    if (own8 >= 3 || own8 == 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player3.GetComponent<FollowThePath>().transform.position == waypoints[10].transform.position)
            {
                if (GameControl.count9 == 1)
                {
                    buy.interactable = false;
                }
                detect = count9;
                houseName.text = "公共物業1";
                cost1.text = "$30000"; cost2.text = "+ NULL"; cost3.text = "+ $NULL";
                if (count9 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own9;
                    if (detect == 1)
                        Reduce = 35000;
                    ReduceSum(3, Reduce, own);

                    dropButton.interactable = true;
                    camMain();

                }
            }
            else if (player3.GetComponent<FollowThePath>().transform.position == waypoints[11].transform.position)
            {
                detect = count10;
                houseName.text = "橙2";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count10 == 0)
                {
                    HouseSelection.reduce = 150000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own10;
                    if (detect == 1)
                        Reduce = 15000;
                    else if (detect == 2)
                        Reduce = 21000;
                    else if (detect == 3)
                        Reduce = 27000;
                    ReduceSum(3, Reduce, own);

                    if (own10 >= 3 || own10 == 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player3.GetComponent<FollowThePath>().transform.position == waypoints[13].transform.position)
            {
                detect = count11;
                houseName.text = "橙3";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count11 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own11;
                    if (detect == 1)
                        Reduce = 15000;
                    else if (detect == 2)
                        Reduce = 21000;
                    else if (detect == 3)
                        Reduce = 27000;
                    ReduceSum(3, Reduce, own);

                    if (own11 >= 3 || own11 == 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player3.GetComponent<FollowThePath>().transform.position == waypoints[14].transform.position)
            {
                detect = count12;
                houseName.text = "橙4";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count12 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own12;
                    if (detect == 1)
                        Reduce = 15000;
                    else if (detect == 2)
                        Reduce = 21000;
                    else if (detect == 3)
                        Reduce = 27000;
                    ReduceSum(3, Reduce, own);

                    if (own12 >= 3 || own12 == 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player3.GetComponent<FollowThePath>().transform.position == waypoints[15].transform.position)
            {
                detect = count13;
                houseName.text = "橙5";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count13 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own13;
                    if (detect == 1)
                        Reduce = 15000;
                    else if (detect == 2)
                        Reduce = 21000;
                    else if (detect == 3)
                        Reduce = 27000;
                    ReduceSum(3, Reduce, own);

                    if (own13 >= 3 || own13 == 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player3.GetComponent<FollowThePath>().transform.position == waypoints[16].transform.position)
            {
                detect = count14;
                houseName.text = "橙6";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count14 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own14;
                    if (detect == 1)
                        Reduce = 15000;
                    else if (detect == 2)
                        Reduce = 21000;
                    else if (detect == 3)
                        Reduce = 27000;
                    ReduceSum(3, Reduce, own);

                    if (own14 >= 3 || own14 == 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player3.GetComponent<FollowThePath>().transform.position == waypoints[17].transform.position)
            {
                detect = count15;
                houseName.text = "橙7";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count15 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own15;
                    if (detect == 1)
                        Reduce = 15000;
                    else if (detect == 2)
                        Reduce = 21000;
                    else if (detect == 3)
                        Reduce = 27000;
                    ReduceSum(3, Reduce, own);

                    if (own15 >= 3 || own15 == 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player3.GetComponent<FollowThePath>().transform.position == waypoints[19].transform.position)
            {
                detect = count16;
                houseName.text = "黃1";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count16 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own16;
                    if (detect == 1)
                        Reduce = 20000;
                    else if (detect == 2)
                        Reduce = 27000;
                    else if (detect == 3)
                        Reduce = 34000;
                    ReduceSum(3, Reduce, own);

                    if (own16 >= 3 || own16 == 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player3.GetComponent<FollowThePath>().transform.position == waypoints[20].transform.position)
            {
                detect = count17;
                houseName.text = "黃2";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count17 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own17;
                    if (detect == 1)
                        Reduce = 20000;
                    else if (detect == 2)
                        Reduce = 27000;
                    else if (detect == 3)
                        Reduce = 34000;
                    ReduceSum(3, Reduce, own);

                    if (own17 >= 3 || own17 == 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player3.GetComponent<FollowThePath>().transform.position == waypoints[21].transform.position)
            {
                if (GameControl.count18 == 1)
                {
                    buy.interactable = false;
                }
                detect = count18;
                houseName.text = "公共物業2";
                cost1.text = "$30000"; cost2.text = "+ $NULL"; cost3.text = "+ $NULL";
                if (count18 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own18;
                    if (detect == 1)
                        Reduce = 30000;
                    ReduceSum(3, Reduce, own);

                    dropButton.interactable = true;
                    camMain();
 

                }
            }
            else if (player3.GetComponent<FollowThePath>().transform.position == waypoints[22].transform.position)
            {
                detect = count19;
                houseName.text = "黃3";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count19 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own19;
                    if (detect == 1)
                        Reduce = 20000;
                    else if (detect == 2)
                        Reduce = 27000;
                    else if (detect == 3)
                        Reduce = 34000;
                    ReduceSum(3, Reduce, own);

                    if (own19 >= 3 || own19 == 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player3.GetComponent<FollowThePath>().transform.position == waypoints[23].transform.position)
            {
                detect = count20;
                houseName.text = "黃4";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count20 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own20;
                    if (detect == 1)
                        Reduce = 20000;
                    else if (detect == 2)
                        Reduce = 27000;
                    else if (detect == 3)
                        Reduce = 34000;
                    ReduceSum(3, Reduce, own);

                    if (own20 >= 3 || own20 == 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player3.GetComponent<FollowThePath>().transform.position == waypoints[24].transform.position)
            {
                detect = count21;
                houseName.text = "黃5";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count21 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own21;
                    if (detect == 1)
                        Reduce = 20000;
                    else if (detect == 2)
                        Reduce = 27000;
                    else if (detect == 3)
                        Reduce = 34000;
                    ReduceSum(3, Reduce, own);

                    if (own21 >= 3 || own21 == 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player3.GetComponent<FollowThePath>().transform.position == waypoints[26].transform.position)
            {
                detect = count22;
                houseName.text = "黃6";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count22 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own22;
                    if (detect == 1)
                        Reduce = 20000;
                    else if (detect == 2)
                        Reduce = 27000;
                    else if (detect == 3)
                        Reduce = 34000;
                    ReduceSum(3, Reduce, own);

                    if (own22 >= 3 || own22 == 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player3.GetComponent<FollowThePath>().transform.position == waypoints[27].transform.position)
            {
                detect = count23;
                houseName.text = "黃7";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count23 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own23;
                    if (detect == 1)
                        Reduce = 20000;
                    else if (detect == 2)
                        Reduce = 27000;
                    else if (detect == 3)
                        Reduce = 34000;
                    ReduceSum(3, Reduce, own);

                    if (own23 >= 3 || own23 == 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player3.GetComponent<FollowThePath>().transform.position == waypoints[28].transform.position)
            {
                detect = count24;
                houseName.text = "綠1";
                cost1.text = "$30000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count24 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own24;
                    if (detect == 1)
                        Reduce = 30000;
                    else if (detect == 2)
                        Reduce = 38500;
                    else if (detect == 3)
                        Reduce = 47000;
                    ReduceSum(3, Reduce, own);

                    if (own24 >= 3 || own24 == 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player3.GetComponent<FollowThePath>().transform.position == waypoints[29].transform.position)
            {
                detect = count25;
                houseName.text = "綠2";
                cost1.text = "$30000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count25 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own25;
                    if (detect == 1)
                        Reduce = 30000;
                    else if (detect == 2)
                        Reduce = 38500;
                    else if (detect == 3)
                        Reduce = 47000;
                    ReduceSum(3, Reduce, own);

                    if (own25 >= 3 || own25 == 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player3.GetComponent<FollowThePath>().transform.position == waypoints[30].transform.position)
            {
                if (DiceNumberTextScript.jail1 == 1 || DiceNumberTextScript.jail2 == 1 || DiceNumberTextScript.jail4 == 1 || DiceNumberTextScript.jail5 == 1 || DiceNumberTextScript.jail6 == 1
                    || DiceNumberTextScript.jail7 == 1 || DiceNumberTextScript.jail8 == 1)
                {
                    if (DiceNumberTextScript.jail1 == 1)
                    {
                        jail1turn = 3;
                        DiceNumberTextScript.jail1 = 0;
                    }
                    if (DiceNumberTextScript.jail2 == 1)
                    {
                        jail2turn = 3;
                        DiceNumberTextScript.jail2 = 0;
                    }
                    if (DiceNumberTextScript.jail4 == 1)
                    {
                        jail4turn = 3;
                        DiceNumberTextScript.jail4 = 0;
                    }
                    if (DiceNumberTextScript.jail5 == 1)
                    {
                        jail5turn = 3;
                        DiceNumberTextScript.jail5 = 0;
                    }
                    if (DiceNumberTextScript.jail6 == 1)
                    {
                        jail6turn = 3;
                        DiceNumberTextScript.jail6 = 0;
                    }
                    if (DiceNumberTextScript.jail7 == 1)
                    {
                        jail7turn = 3;
                        DiceNumberTextScript.jail7 = 0;
                    }
                    if (DiceNumberTextScript.jail8 == 1)
                    {
                        jail8turn = 3;
                        DiceNumberTextScript.jail8 = 0;
                    }

                }

                DiceNumberTextScript.jail3 = 1;
                JailTurn.text = jail3turn.ToString();
                ImageForJail.gameObject.SetActive(true);
            }
            else if (player3.GetComponent<FollowThePath>().transform.position == waypoints[31].transform.position)
            {
                detect = count26;
                houseName.text = "綠3";
                cost1.text = "$30000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count26 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own26;
                    if (detect == 1)
                        Reduce = 30000;
                    else if (detect == 2)
                        Reduce = 38500;
                    else if (detect == 3)
                        Reduce = 47000;
                    ReduceSum(3, Reduce, own);

                    if (own26 >=3 || own26 == 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player3.GetComponent<FollowThePath>().transform.position == waypoints[32].transform.position)
            {
                detect = count27;
                houseName.text = "綠4";
                cost1.text = "$30000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count27 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own27;
                    if (detect == 1)
                        Reduce = 30000;
                    else if (detect == 2)
                        Reduce = 38500;
                    else if (detect == 3)
                        Reduce = 47000;
                    ReduceSum(3, Reduce, own);

                    if (own27 >= 3 || own27 == 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player3.GetComponent<FollowThePath>().transform.position == waypoints[33].transform.position)
            {
                detect = count28;
                houseName.text = "綠5";
                cost1.text = "$30000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count28 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own28;
                    if (detect == 1)
                        Reduce = 30000;
                    else if (detect == 2)
                        Reduce = 38500;
                    else if (detect == 3)
                        Reduce = 47000;
                    ReduceSum(3, Reduce, own);

                    if (own28 >= 3 || own29 == 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player3.GetComponent<FollowThePath>().transform.position == waypoints[34].transform.position)
            {
                detect = count29;
                houseName.text = "綠6";
                cost1.text = "$30000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count29 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own29;
                    if (detect == 1)
                        Reduce = 30000;
                    else if (detect == 2)
                        Reduce = 38500;
                    else if (detect == 3)
                        Reduce = 47000;
                    ReduceSum(3, Reduce, own);

                    if (own29 >= 3 || own29 == 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player3.GetComponent<FollowThePath>().transform.position == waypoints[36].transform.position)
            {
                detect = count30;
                houseName.text = "藍1";
                cost1.text = "$50000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count30 == 0)
                {
                    HouseSelection.reduce = 50000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own30;
                    if (detect == 1)
                        Reduce = 50000;
                    else if (detect == 2)
                        Reduce = 58500;
                    else if (detect == 3)
                        Reduce = 67000;
                    ReduceSum(3, Reduce, own);

                    if (own30 >= 3 || own30 == 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player3.GetComponent<FollowThePath>().transform.position == waypoints[37].transform.position)
            {
                detect = count31;
                houseName.text = "藍2";
                cost1.text = "$50000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count31 == 0)
                {
                    HouseSelection.reduce = 50000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own31;
                    if (detect == 1)
                        Reduce = 50000;
                    else if (detect == 2)
                        Reduce = 58500;
                    else if (detect == 3)
                        Reduce = 67000;
                    ReduceSum(3, Reduce, own);

                    if (own31 >= 3 || own31 == 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player3.GetComponent<FollowThePath>().transform.position == waypoints[38].transform.position)
            {
                if (GameControl.count32 == 1)
                {
                    buy.interactable = false;
                }
                detect = count32;
                houseName.text = "公共物業3";
                cost1.text = "$30000"; cost2.text = "+ $NULL"; cost3.text = "+ $NULL";
                if (count32 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own32;
                    if (detect == 1)
                        Reduce = 30000;
                    ReduceSum(3, Reduce, own);

                        dropButton.interactable = true;
                        camMain();
               
                }
            }
            else if (player3.GetComponent<FollowThePath>().transform.position == waypoints[39].transform.position)
            {
                detect = count33;
                houseName.text = "藍3";
                cost1.text = "$50000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count33 == 0)
                {
                    HouseSelection.reduce = 50000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own33;
                    if (detect == 1)
                        Reduce = 50000;
                    else if (detect == 2)
                        Reduce = 58500;
                    else if (detect == 3)
                        Reduce = 67000;
                    ReduceSum(3, Reduce, own);

                    if (own33 >= 3 || own33 == 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player3.GetComponent<FollowThePath>().transform.position == waypoints[40].transform.position)
            {
                detect = count34;
                houseName.text = "藍4";
                cost1.text = "$50000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count34 == 0)
                {
                    HouseSelection.reduce = 50000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own34;
                    if (detect == 1)
                        Reduce = 50000;
                    else if (detect == 2)
                        Reduce = 58500;
                    else if (detect == 3)
                        Reduce = 67000;
                    ReduceSum(3, Reduce, own);

                    if (own34 >=3 || own34 == 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player3.GetComponent<FollowThePath>().transform.position == waypoints[42].transform.position)
            {
                detect = count35;
                houseName.text = "紫1";
                cost1.text = "$70000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count35 == 0)
                {
                    HouseSelection.reduce = 70000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own35;
                    if (detect == 1)
                        Reduce = 70000;
                    else if (detect == 2)
                        Reduce = 79000;
                    else if (detect == 3)
                        Reduce = 88000;
                    ReduceSum(3, Reduce, own);

                    if (own35 >= 3 || own35 == 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player3.GetComponent<FollowThePath>().transform.position == waypoints[43].transform.position)
            {
                detect = count36;
                houseName.text = "紫2";
                cost1.text = "$70000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count36 == 0)
                {
                    HouseSelection.reduce = 70000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own36;
                    if (detect == 1)
                        Reduce = 70000;
                    else if (detect == 2)
                        Reduce = 79000;
                    else if (detect == 3)
                        Reduce = 88000;
                    ReduceSum(3, Reduce, own);

                    if (own36 >=3 || own36 == 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player3.GetComponent<FollowThePath>().transform.position == waypoints[44].transform.position)
            {
                detect = count37;
                houseName.text = "紫3";
                cost1.text = "$70000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count37 == 0)
                {
                    HouseSelection.reduce = 70000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own37;
                    if (detect == 1)
                        Reduce = 70000;
                    else if (detect == 2)
                        Reduce = 79000;
                    else if (detect == 3)
                        Reduce = 88000;
                    ReduceSum(3, Reduce, own);

                    if (own37 >= 3 || own37 == 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player3.GetComponent<FollowThePath>().transform.position == waypoints[47].transform.position)
            {
                detect = count38;
                houseName.text = "紫4";
                cost1.text = "$70000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count38 == 0)
                {
                    HouseSelection.reduce = 70000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own38;
                    if (detect == 1)
                        Reduce = 70000;
                    else if (detect == 2)
                        Reduce = 79000;
                    else if (detect == 3)
                        Reduce = 88000;
                    ReduceSum(3, Reduce, own);

                    if (own38 >= 3 || own38 == 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player3.GetComponent<FollowThePath>().transform.position == waypoints[48].transform.position)
            {
                detect = count39;
                houseName.text = "紫5";
                cost1.text = "$70000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count39 == 0)
                {
                    HouseSelection.reduce = 70000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own39;
                    if (detect == 1)
                        Reduce = 70000;
                    else if (detect == 2)
                        Reduce = 79000;
                    else if (detect == 3)
                        Reduce = 88000;
                    ReduceSum(3, Reduce, own);

                    if (own39 >= 3 || own39 == 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player3.GetComponent<FollowThePath>().transform.position == waypoints[49].transform.position)
            {
                detect = count40;
                houseName.text = "啡1";
                cost1.text = "$85000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count40 == 0)
                {
                    HouseSelection.reduce = 85000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own40;
                    if (detect == 1)
                        Reduce = 85000;
                    else if (detect == 2)
                        Reduce = 94000;
                    else if (detect == 3)
                        Reduce = 108000;
                    ReduceSum(3, Reduce, own);

                    if (own40 >= 3 || own40 == 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player3.GetComponent<FollowThePath>().transform.position == waypoints[50].transform.position)
            {
                detect = count41;
                houseName.text = "公共物業4";
                cost1.text = "$30000"; cost2.text = "+ $NULL"; cost3.text = "+ $NULL";
                if (count41 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own41;
                    if (detect == 1)
                        Reduce = 85000;
                    ReduceSum(3, Reduce, own);

                    dropButton.interactable = true;
                    camMain();
                   
                }
            }
            else if (player3.GetComponent<FollowThePath>().transform.position == waypoints[51].transform.position)
            {
                if (GameControl.count42 == 1)
                {
                    buy.interactable = false;
                }
                detect = count42;
                houseName.text = "啡2";
                cost1.text = "$85000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count42 == 0)
                {
                    HouseSelection.reduce = 85000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own42;
                    if (detect == 1)
                        Reduce = 85000;
                    else if (detect == 2)
                        Reduce = 94000;
                    else if (detect == 3)
                        Reduce = 108000;
                    ReduceSum(3, Reduce, own);

                    if (own42 >= 3 || own42 == 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player3.GetComponent<FollowThePath>().transform.position == waypoints[52].transform.position)
            {
                detect = count43;
                houseName.text = "啡3";
                cost1.text = "$85000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count43 == 0)
                {
                    HouseSelection.reduce = 85000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);

                }
                else
                {
                    own = own43;
                    if (detect == 1)
                        Reduce = 85000;
                    else if (detect == 2)
                        Reduce = 94000;
                    else if (detect == 3)
                        Reduce = 108000;
                    ReduceSum(3, Reduce, own);

                    if (own43 >= 3 || own43 == 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player3.GetComponent<FollowThePath>().transform.position == waypoints[55].transform.position)
            {
                detect = count44;
                houseName.text = "黑1";
                cost1.text = "$100000"; cost2.text = "+ $10000"; cost3.text = "+ $10000";
                if (count44 == 0)
                {
                    HouseSelection.reduce = 100000;
                }
                else
                {
                    HouseSelection.reduce = 10000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own44;
                    if (detect == 1)
                        Reduce = 100000;
                    else if (detect == 2)
                        Reduce = 110000;
                    else if (detect == 3)
                        Reduce = 120000;
                    ReduceSum(3, Reduce, own);

                    if (own44 >= 3 || own44 == 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player3.GetComponent<FollowThePath>().transform.position == waypoints[56].transform.position)
            {
                detect = count45;
                houseName.text = "黑2";
                cost1.text = "$100000"; cost2.text = "+ $10000"; cost3.text = "+ $10000";
                if (count45 == 0)
                {
                    HouseSelection.reduce = 100000;
                }
                else
                {
                    HouseSelection.reduce = 10000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own45;
                    if (detect == 1)
                        Reduce = 100000;
                    else if (detect == 2)
                        Reduce = 110000;
                    else if (detect == 3)
                        Reduce = 120000;
                    ReduceSum(3, Reduce, own);

                    if (own45 >= 3 || own45 == 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else if (player3.GetComponent<FollowThePath>().transform.position == waypoints[57].transform.position)
            {
                detect = count46;
                houseName.text = "黑3";
                cost1.text = "$100000"; cost2.text = "+ $10000"; cost3.text = "+ $10000";
                if (count46 == 0)
                {
                    HouseSelection.reduce = 100000;
                }
                else
                {
                    HouseSelection.reduce = 10000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own46;
                    if (detect == 1)
                        Reduce = 100000;
                    else if (detect == 2)
                        Reduce = 110000;
                    else if (detect == 3)
                        Reduce = 120000;
                    ReduceSum(3, Reduce, own);

                    if (own46 >= 3 || own46 == 2)
                        ImageForBuyOtherHouse.gameObject.SetActive(true);
                    else
                    {
                        dropButton.interactable = true;
                        camMain();
                    }
                }
            }
            else
            {
                dropButton.interactable = true;
                camMain();
            }
        }
                                                                                           
        if (player4.GetComponent<FollowThePath>().wayPointIndex > player4Waypoint + diceSide1Thrown + diceSide2Thrown + diceSide3Thrown - player4.GetComponent<FollowThePath>().Accept)
        {
            whoTurn = 4;
            player4.GetComponent<FollowThePath>().moveAllowed = false;
            player4Waypoint = player4.GetComponent<FollowThePath>().wayPointIndex - 1;
            player4.GetComponent<FollowThePath>().Movement = 0;
            player4.GetComponent<FollowThePath>().Accept = 0;

            if (player4.GetComponent<FollowThePath>().transform.position == waypoints[1].transform.position)
            {
                detect = count1;
                houseName.text = "紅1";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count1 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own1;
                    if (detect == 1)
                        Reduce = 10000;
                    else if (detect == 2)
                        Reduce = 15000;
                    else if (detect == 3)
                        Reduce = 20000;
                    ReduceSum(4, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player4.GetComponent<FollowThePath>().transform.position == waypoints[2].transform.position)
            {
                detect = count2;
                houseName.text = "紅2";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count2 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own2;
                    if (detect == 1)
                        Reduce = 10000;
                    else if (detect == 2)
                        Reduce = 15000;
                    else if (detect == 3)
                        Reduce = 20000;
                    ReduceSum(4, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player4.GetComponent<FollowThePath>().transform.position == waypoints[3].transform.position)
            {
                detect = count3;
                houseName.text = "紅3";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count3 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own3;
                    if (detect == 1)
                        Reduce = 10000;
                    else if (detect == 2)
                        Reduce = 15000;
                    else if (detect == 3)
                        Reduce = 20000;
                    ReduceSum(4, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player4.GetComponent<FollowThePath>().transform.position == waypoints[4].transform.position)
            {
                detect = count4;
                houseName.text = "紅4";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count4 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own4;
                    if (detect == 1)
                        Reduce = 10000;
                    else if (detect == 2)
                        Reduce = 15000;
                    else if (detect == 3)
                        Reduce = 20000;
                    ReduceSum(4, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player4.GetComponent<FollowThePath>().transform.position == waypoints[5].transform.position)
            {
                detect = count5;
                houseName.text = "紅5";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count5 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own5;
                    if (detect == 1)
                        Reduce = 10000;
                    else if (detect == 2)
                        Reduce = 15000;
                    else if (detect == 3)
                        Reduce = 20000;
                    ReduceSum(4, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player4.GetComponent<FollowThePath>().transform.position == waypoints[7].transform.position)
            {
                detect = count6;
                houseName.text = "紅6";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count6 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own6;
                    if (detect == 1)
                        Reduce = 10000;
                    else if (detect == 2)
                        Reduce = 15000;
                    else if (detect == 3)
                        Reduce = 20000;
                    ReduceSum(4, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player4.GetComponent<FollowThePath>().transform.position == waypoints[8].transform.position)
            {
                detect = count7;
                houseName.text = "紅7";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count7 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own7;
                    if (detect == 1)
                        Reduce = 10000;
                    else if (detect == 2)
                        Reduce = 15000;
                    else if (detect == 3)
                        Reduce = 20000;
                    ReduceSum(4, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player4.GetComponent<FollowThePath>().transform.position == waypoints[9].transform.position)
            {
                detect = count8;
                houseName.text = "橙1";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count8 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own8;
                    if (detect == 1)
                        Reduce = 15000;
                    else if (detect == 2)
                        Reduce = 21000;
                    else if (detect == 3)
                        Reduce = 27000;
                    ReduceSum(4, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player4.GetComponent<FollowThePath>().transform.position == waypoints[10].transform.position)
            {
                if (GameControl.count9 == 1)
                {
                    buy.interactable = false;
                }
                detect = count9;
                houseName.text = "公共物業1";
                cost1.text = "$30000"; cost2.text = "+ NULL"; cost3.text = "+ $NULL";
                if (count9 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own9;
                    if (detect == 1)
                        Reduce = 30000;
                    ReduceSum(4, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player4.GetComponent<FollowThePath>().transform.position == waypoints[11].transform.position)
            {
                detect = count10;
                houseName.text = "橙2";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count10 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own10;
                    if (detect == 1)
                        Reduce = 15000;
                    else if (detect == 2)
                        Reduce = 21000;
                    else if (detect == 3)
                        Reduce = 27000;
                    ReduceSum(4, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player4.GetComponent<FollowThePath>().transform.position == waypoints[13].transform.position)
            {
                detect = count11;
                houseName.text = "橙3";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count11 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own11;
                    if (detect == 1)
                        Reduce = 15000;
                    else if (detect == 2)
                        Reduce = 21000;
                    else if (detect == 3)
                        Reduce = 27000;
                    ReduceSum(4, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player4.GetComponent<FollowThePath>().transform.position == waypoints[14].transform.position)
            {
                detect = count12;
                houseName.text = "橙4";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count12 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own12;
                    if (detect == 1)
                        Reduce = 15000;
                    else if (detect == 2)
                        Reduce = 21000;
                    else if (detect == 3)
                        Reduce = 27000;
                    ReduceSum(4, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player4.GetComponent<FollowThePath>().transform.position == waypoints[15].transform.position)
            {
                detect = count13;
                houseName.text = "橙5";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count13 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own13;
                    if (detect == 1)
                        Reduce = 15000;
                    else if (detect == 2)
                        Reduce = 21000;
                    else if (detect == 3)
                        Reduce = 27000;
                    ReduceSum(4, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player4.GetComponent<FollowThePath>().transform.position == waypoints[16].transform.position)
            {
                detect = count14;
                houseName.text = "橙6";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count14 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own14;
                    if (detect == 1)
                        Reduce = 15000;
                    else if (detect == 2)
                        Reduce = 21000;
                    else if (detect == 3)
                        Reduce = 27000;
                    ReduceSum(4, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player4.GetComponent<FollowThePath>().transform.position == waypoints[17].transform.position)
            {
                detect = count15;
                houseName.text = "橙6";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count15 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own15;
                    if (detect == 1)
                        Reduce = 15000;
                    else if (detect == 2)
                        Reduce = 21000;
                    else if (detect == 3)
                        Reduce = 27000;
                    ReduceSum(4, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player4.GetComponent<FollowThePath>().transform.position == waypoints[19].transform.position)
            {
                detect = count16;
                houseName.text = "黃1";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count16 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own16;
                    if (detect == 1)
                        Reduce = 20000;
                    else if (detect == 2)
                        Reduce = 27000;
                    else if (detect == 3)
                        Reduce = 34000;
                    ReduceSum(4, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player4.GetComponent<FollowThePath>().transform.position == waypoints[20].transform.position)
            {
                detect = count17;
                houseName.text = "黃2";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count17 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own17;
                    if (detect == 1)
                        Reduce = 20000;
                    else if (detect == 2)
                        Reduce = 27000;
                    else if (detect == 3)
                        Reduce = 34000;
                    ReduceSum(4, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player4.GetComponent<FollowThePath>().transform.position == waypoints[21].transform.position)
            {
                if (GameControl.count18 == 1)
                {
                    buy.interactable = false;
                }
                detect = count18;
                houseName.text = "公共物業2";
                cost1.text = "$30000"; cost2.text = "+ $NULL"; cost3.text = "+ $NULL";
                if (count18 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own18;
                    if (detect == 1)
                        Reduce = 30000;
                    ReduceSum(4, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player4.GetComponent<FollowThePath>().transform.position == waypoints[22].transform.position)
            {
                detect = count19;
                houseName.text = "黃3";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count19 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own19;
                    if (detect == 1)
                        Reduce = 20000;
                    else if (detect == 2)
                        Reduce = 27000;
                    else if (detect == 3)
                        Reduce = 34000;
                    ReduceSum(4, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player4.GetComponent<FollowThePath>().transform.position == waypoints[23].transform.position)
            {
                detect = count20;
                houseName.text = "黃4";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count20 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own20;
                    if (detect == 1)
                        Reduce = 20000;
                    else if (detect == 2)
                        Reduce = 27000;
                    else if (detect == 3)
                        Reduce = 34000;
                    ReduceSum(4, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player4.GetComponent<FollowThePath>().transform.position == waypoints[24].transform.position)
            {
                detect = count21;
                houseName.text = "黃5";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count21 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own21;
                    if (detect == 1)
                        Reduce = 20000;
                    else if (detect == 2)
                        Reduce = 27000;
                    else if (detect == 3)
                        Reduce = 34000;
                    ReduceSum(4, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }
            else if (player4.GetComponent<FollowThePath>().transform.position == waypoints[26].transform.position)
            {
                detect = count22;
                houseName.text = "黃6";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count22 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own22;
                    if (detect == 1)
                        Reduce = 20000;
                    else if (detect == 2)
                        Reduce = 27000;
                    else if (detect == 3)
                        Reduce = 34000;
                    ReduceSum(4, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player4.GetComponent<FollowThePath>().transform.position == waypoints[27].transform.position)
            {
                detect = count23;
                houseName.text = "黃7";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count23 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own23;
                    if (detect == 1)
                        Reduce = 20000;
                    else if (detect == 2)
                        Reduce = 27000;
                    else if (detect == 3)
                        Reduce = 34000;
                    ReduceSum(4, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player4.GetComponent<FollowThePath>().transform.position == waypoints[28].transform.position)
            {
                detect = count24;
                houseName.text = "綠1";
                cost1.text = "$30000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count24 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own24;
                    if (detect == 1)
                        Reduce = 30000;
                    else if (detect == 2)
                        Reduce = 38500;
                    else if (detect == 3)
                        Reduce = 47000;
                    ReduceSum(4, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player4.GetComponent<FollowThePath>().transform.position == waypoints[29].transform.position)
            {
                detect = count25;
                houseName.text = "綠2";
                cost1.text = "$30000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count25 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own25;
                    if (detect == 1)
                        Reduce = 30000;
                    else if (detect == 2)
                        Reduce = 38500;
                    else if (detect == 3)
                        Reduce = 47000;
                    ReduceSum(4, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }
            else if (player4.GetComponent<FollowThePath>().transform.position == waypoints[30].transform.position)
            {
                if (DiceNumberTextScript.jail1 == 1 || DiceNumberTextScript.jail2 == 1 || DiceNumberTextScript.jail3 == 1 || DiceNumberTextScript.jail5 == 1 || DiceNumberTextScript.jail6 == 1
                    || DiceNumberTextScript.jail7 == 1 || DiceNumberTextScript.jail8 == 1)
                {
                    if (DiceNumberTextScript.jail1 == 1)
                    {
                        jail1turn = 3;
                        DiceNumberTextScript.jail1 = 0;
                    }
                    if (DiceNumberTextScript.jail2 == 1)
                    {
                        jail2turn = 3;
                        DiceNumberTextScript.jail2 = 0;
                    }
                    if (DiceNumberTextScript.jail3 == 1)
                    {
                        jail3turn = 3;
                        DiceNumberTextScript.jail3 = 0;
                    }
                    if (DiceNumberTextScript.jail5 == 1)
                    {
                        jail5turn = 3;
                        DiceNumberTextScript.jail5 = 0;
                    } 
                    if (DiceNumberTextScript.jail6 == 1)
                    {
                        jail6turn = 3;
                        DiceNumberTextScript.jail6 = 0;
                    }
                    if (DiceNumberTextScript.jail7 == 1)
                    {
                        jail7turn = 3;
                        DiceNumberTextScript.jail7 = 0;
                    }
                    if (DiceNumberTextScript.jail8 == 1)
                    {
                        jail8turn = 3;
                        DiceNumberTextScript.jail8 = 0;
                    }
 
                    
                }

                DiceNumberTextScript.jail4 = 1;
                JailTurn.text = jail4turn.ToString();
                ImageForJail.gameObject.SetActive(true);
            }

            else if (player4.GetComponent<FollowThePath>().transform.position == waypoints[31].transform.position)
            {
                detect = count26;
                houseName.text = "綠3";
                cost1.text = "$30000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count26 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own26;
                    if (detect == 1)
                        Reduce = 30000;
                    else if (detect == 2)
                        Reduce = 38500;
                    else if (detect == 3)
                        Reduce = 47000;
                    ReduceSum(4, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player4.GetComponent<FollowThePath>().transform.position == waypoints[32].transform.position)
            {
                detect = count27;
                houseName.text = "綠4";
                cost1.text = "$30000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count27 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own27;
                    if (detect == 1)
                        Reduce = 30000;
                    else if (detect == 2)
                        Reduce = 38500;
                    else if (detect == 3)
                        Reduce = 47000;
                    ReduceSum(4, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player4.GetComponent<FollowThePath>().transform.position == waypoints[33].transform.position)
            {
                detect = count28;
                houseName.text = "綠5";
                cost1.text = "$30000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count28 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own28;
                    if (detect == 1)
                        Reduce = 30000;
                    else if (detect == 2)
                        Reduce = 38500;
                    else if (detect == 3)
                        Reduce = 47000;
                    ReduceSum(4, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player4.GetComponent<FollowThePath>().transform.position == waypoints[34].transform.position)
            {
                detect = count29;
                houseName.text = "綠6";
                cost1.text = "$30000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count29 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own29;
                    if (detect == 1)
                        Reduce = 30000;
                    else if (detect == 2)
                        Reduce = 38500;
                    else if (detect == 3)
                        Reduce = 47000;
                    ReduceSum(4, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player4.GetComponent<FollowThePath>().transform.position == waypoints[36].transform.position)
            {
                detect = count30;
                houseName.text = "藍1";
                cost1.text = "$50000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count30 == 0)
                {
                    HouseSelection.reduce = 50000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own30;
                    if (detect == 1)
                        Reduce = 50000;
                    else if (detect == 2)
                        Reduce = 58500;
                    else if (detect == 3)
                        Reduce = 67000;
                    ReduceSum(4, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player4.GetComponent<FollowThePath>().transform.position == waypoints[37].transform.position)
            {
                detect = count31;
                houseName.text = "藍2";
                cost1.text = "$50000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count31 == 0)
                {
                    HouseSelection.reduce = 50000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own31;
                    if (detect == 1)
                        Reduce = 50000;
                    else if (detect == 2)
                        Reduce = 58500;
                    else if (detect == 3)
                        Reduce = 67000;
                    ReduceSum(4, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player4.GetComponent<FollowThePath>().transform.position == waypoints[38].transform.position)
            {
                if (GameControl.count32 == 1)
                {
                    buy.interactable = false;
                }
                detect = count32;
                houseName.text = "公共物業3";
                cost1.text = "$30000"; cost2.text = "+ $NULL"; cost3.text = "+ $NULL";
                if (count32 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own32;
                    if (detect == 1)
                        Reduce = 30000;
                    ReduceSum(4, Reduce, own);
                    dropButton.interactable = true;
                    camMain();

                }
            }

            else if (player4.GetComponent<FollowThePath>().transform.position == waypoints[39].transform.position)
            {
                detect = count33;
                houseName.text = "藍3";
                cost1.text = "$50000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count33 == 0)
                {
                    HouseSelection.reduce = 50000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own33;
                    if (detect == 1)
                        Reduce = 50000;
                    else if (detect == 2)
                        Reduce = 58500;
                    else if (detect == 3)
                        Reduce = 67000;
                    ReduceSum(4, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player4.GetComponent<FollowThePath>().transform.position == waypoints[40].transform.position)
            {
                detect = count34;
                houseName.text = "藍4";
                cost1.text = "$50000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count34 == 0)
                {
                    HouseSelection.reduce = 50000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own34;
                    if (detect == 1)
                        Reduce = 50000;
                    else if (detect == 2)
                        Reduce = 58500;
                    else if (detect == 3)
                        Reduce = 67000;
                    ReduceSum(4, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player4.GetComponent<FollowThePath>().transform.position == waypoints[42].transform.position)
            {
                detect = count35;
                houseName.text = "紫1";
                cost1.text = "$70000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count35 == 0)
                {
                    HouseSelection.reduce = 70000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own35;
                    if (detect == 1)
                        Reduce = 70000;
                    else if (detect == 2)
                        Reduce = 79000;
                    else if (detect == 3)
                        Reduce = 88000;
                    ReduceSum(4, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player4.GetComponent<FollowThePath>().transform.position == waypoints[43].transform.position)
            {
                detect = count36;
                houseName.text = "紫2";
                cost1.text = "$70000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count36 == 0)
                {
                    HouseSelection.reduce = 70000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own36;
                    if (detect == 1)
                        Reduce = 70000;
                    else if (detect == 2)
                        Reduce = 79000;
                    else if (detect == 3)
                        Reduce = 88000;
                    ReduceSum(4, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player4.GetComponent<FollowThePath>().transform.position == waypoints[44].transform.position)
            {
                detect = count37;
                houseName.text = "紫3";
                cost1.text = "$70000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count37 == 0)
                {
                    HouseSelection.reduce = 70000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own37;
                    if (detect == 1)
                        Reduce = 70000;
                    else if (detect == 2)
                        Reduce = 79000;
                    else if (detect == 3)
                        Reduce = 88000;
                    ReduceSum(4, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player4.GetComponent<FollowThePath>().transform.position == waypoints[47].transform.position)
            {
                detect = count38;
                houseName.text = "紫4";
                cost1.text = "$70000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count38 == 0)
                {
                    HouseSelection.reduce = 70000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own38;
                    if (detect == 1)
                        Reduce = 70000;
                    else if (detect == 2)
                        Reduce = 79000;
                    else if (detect == 3)
                        Reduce = 88000;
                    ReduceSum(4, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player4.GetComponent<FollowThePath>().transform.position == waypoints[48].transform.position)
            {
                detect = count39;
                houseName.text = "紫5";
                cost1.text = "$70000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count39 == 0)
                {
                    HouseSelection.reduce = 70000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own39;
                    if (detect == 1)
                        Reduce = 70000;
                    else if (detect == 2)
                        Reduce = 79000;
                    else if (detect == 3)
                        Reduce = 88000;
                    ReduceSum(4, Reduce, own);
                    dropButton.interactable = true;
                    camMain();

                }
            }

            else if (player4.GetComponent<FollowThePath>().transform.position == waypoints[49].transform.position)
            {
                detect = count40;
                houseName.text = "啡1";
                cost1.text = "$85000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count40 == 0)
                {
                    HouseSelection.reduce = 85000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own40;
                    if (detect == 1)
                        Reduce = 85000;
                    else if (detect == 2)
                        Reduce = 94000;
                    else if (detect == 3)
                        Reduce = 108000;
                    ReduceSum(4, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player4.GetComponent<FollowThePath>().transform.position == waypoints[50].transform.position)
            {
                detect = count41;
                houseName.text = "公共物業4";
                cost1.text = "$30000"; cost2.text = "+ $NULL"; cost3.text = "+ $NULL";
                if (count41 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own41;
                    if (detect == 1)
                        Reduce = 35000;
                    ReduceSum(4, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player4.GetComponent<FollowThePath>().transform.position == waypoints[51].transform.position)
            {
                if (GameControl.count42 == 1)
                {
                    buy.interactable = false;
                }
                detect = count42;
                houseName.text = "啡2";
                cost1.text = "$85000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count42 == 0)
                {
                    HouseSelection.reduce = 85000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own42;
                    if (detect == 1)
                        Reduce = 85000;
                    else if (detect == 2)
                        Reduce = 94000;
                    else if (detect == 3)
                        Reduce = 108000;
                    ReduceSum(4, Reduce, own);
                    dropButton.interactable = true;
                    camMain();

                }
            }

            else if (player4.GetComponent<FollowThePath>().transform.position == waypoints[52].transform.position)
            {
                detect = count43;
                houseName.text = "啡3";
                cost1.text = "$85000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count43 == 0)
                {
                    HouseSelection.reduce = 85000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own43;
                    if (detect == 1)
                        Reduce = 85000;
                    else if (detect == 2)
                        Reduce = 94000;
                    else if (detect == 3)
                        Reduce = 108000;
                    ReduceSum(4, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player4.GetComponent<FollowThePath>().transform.position == waypoints[55].transform.position)
            {
                detect = count44;
                houseName.text = "黑1";
                cost1.text = "$100000"; cost2.text = "+ $10000"; cost3.text = "+ $10000";
                if (count44 == 0)
                {
                    HouseSelection.reduce = 100000;
                }
                else
                {
                    HouseSelection.reduce = 10000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own44;
                    if (detect == 1)
                        Reduce = 100000;
                    else if (detect == 2)
                        Reduce = 110000;
                    else if (detect == 3)
                        Reduce = 112000;
                    ReduceSum(4, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player4.GetComponent<FollowThePath>().transform.position == waypoints[56].transform.position)
            {
                detect = count45;
                houseName.text = "黑2";
                cost1.text = "$100000"; cost2.text = "+ $10000"; cost3.text = "+ $10000";
                if (count45 == 0)
                {
                    HouseSelection.reduce = 100000;
                }
                else
                {
                    HouseSelection.reduce = 10000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own45;
                    if (detect == 1)
                        Reduce = 100000;
                    else if (detect == 2)
                        Reduce = 110000;
                    else if (detect == 3)
                        Reduce = 120000;
                    ReduceSum(4, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player4.GetComponent<FollowThePath>().transform.position == waypoints[57].transform.position)
            {
                detect = count46;
                houseName.text = "黑3";
                cost1.text = "$100000"; cost2.text = "+ $10000"; cost3.text = "+ $10000";
                if (count46 == 0)
                {
                    HouseSelection.reduce = 100000;
                }
                else
                {
                    HouseSelection.reduce = 10000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own46;
                    if (detect == 1)
                        Reduce = 100000;
                    else if (detect == 2)
                        Reduce = 110000;
                    else if (detect == 3)
                        Reduce = 120000;
                    ReduceSum(4, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }
            else
            {
                dropButton.interactable = true;
                camMain();
            }
        }

        if (player5.GetComponent<FollowThePath>().wayPointIndex >player5Waypoint + diceSide1Thrown + diceSide2Thrown + diceSide3Thrown - player5.GetComponent<FollowThePath>().Accept)
        {
            whoTurn = 5;
            player5.GetComponent<FollowThePath>().moveAllowed = false;
            player5Waypoint = player5.GetComponent<FollowThePath>().wayPointIndex - 1;
            player5.GetComponent<FollowThePath>().Movement = 0;
            player5.GetComponent<FollowThePath>().Accept = 0;

            if (player5.GetComponent<FollowThePath>().transform.position == waypoints[1].transform.position)
            {
                detect = count1;
                houseName.text = "紅1";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count1 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own1;
                    if (detect == 1)
                        Reduce = 10000;
                    else if (detect == 2)
                        Reduce = 15000;
                    else if (detect == 3)
                        Reduce = 20000;
                    ReduceSum(5, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player5.GetComponent<FollowThePath>().transform.position == waypoints[2].transform.position)
            {
                detect = count2;
                houseName.text = "紅2";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count2 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own2;
                    if (detect == 1)
                        Reduce = 10000;
                    else if (detect == 2)
                        Reduce = 15000;
                    else if (detect == 3)
                        Reduce = 20000;
                    ReduceSum(5, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player5.GetComponent<FollowThePath>().transform.position == waypoints[3].transform.position)
            {
                detect = count3;
                houseName.text = "紅3";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count3 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own3;
                    if (detect == 1)
                        Reduce = 10000;
                    else if (detect == 2)
                        Reduce = 15000;
                    else if (detect == 3)
                        Reduce = 20000;
                    ReduceSum(5, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player5.GetComponent<FollowThePath>().transform.position == waypoints[4].transform.position)
            {
                detect = count4;
                houseName.text = "紅4";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count4 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own4;
                    if (detect == 1)
                        Reduce = 10000;
                    else if (detect == 2)
                        Reduce = 15000;
                    else if (detect == 3)
                        Reduce = 20000;
                    ReduceSum(5, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player5.GetComponent<FollowThePath>().transform.position == waypoints[5].transform.position)
            {
                detect = count5;
                houseName.text = "紅5";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count5 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own5;
                    if (detect == 1)
                        Reduce = 10000;
                    else if (detect == 2)
                        Reduce = 15000;
                    else if (detect == 3)
                        Reduce = 20000;
                    ReduceSum(5, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player5.GetComponent<FollowThePath>().transform.position == waypoints[7].transform.position)
            {
                detect = count6;
                houseName.text = "紅6";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count6 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own6;
                    if (detect == 1)
                        Reduce = 10000;
                    else if (detect == 2)
                        Reduce = 15000;
                    else if (detect == 3)
                        Reduce = 20000;
                    ReduceSum(5, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player5.GetComponent<FollowThePath>().transform.position == waypoints[8].transform.position)
            {
                detect = count7;
                houseName.text = "紅7";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count7 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own7;
                    if (detect == 1)
                        Reduce = 10000;
                    else if (detect == 2)
                        Reduce = 15000;
                    else if (detect == 3)
                        Reduce = 20000;
                    ReduceSum(5, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player5.GetComponent<FollowThePath>().transform.position == waypoints[9].transform.position)
            {
                detect = count8;
                houseName.text = "橙1";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count8 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own8;
                    if (detect == 1)
                        Reduce = 15000;
                    else if (detect == 2)
                        Reduce = 21000;
                    else if (detect == 3)
                        Reduce = 27000;
                    ReduceSum(5, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player5.GetComponent<FollowThePath>().transform.position == waypoints[10].transform.position)
            {
                if (GameControl.count9 == 1)
                {
                    buy.interactable = false;
                }
                detect = count9;
                houseName.text = "公共物業1";
                cost1.text = "$30000"; cost2.text = "+ NULL"; cost3.text = "+ $NULL";
                if (count9 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own9;
                    if (detect == 1)
                        Reduce = 30000;
                    ReduceSum(5, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if(player5.GetComponent<FollowThePath>().transform.position == waypoints[11].transform.position)
            {
                detect = count10;
                houseName.text = "橙2";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count10 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own10;
                    if (detect == 1)
                        Reduce = 15000;
                    else if (detect == 2)
                        Reduce = 21000;
                    else if (detect == 3)
                        Reduce = 27000;
                    ReduceSum(5, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if(player5.GetComponent<FollowThePath>().transform.position == waypoints[13].transform.position)
            {
                detect = count11;
                houseName.text = "橙3";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count11 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own11;
                    if (detect == 1)
                        Reduce = 15000;
                    else if (detect == 2)
                        Reduce = 21000;
                    else if (detect == 3)
                        Reduce = 27000;
                    ReduceSum(5, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if(player5.GetComponent<FollowThePath>().transform.position == waypoints[14].transform.position)
            {
                detect = count12;
                houseName.text = "橙4";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count12 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own12;
                    if (detect == 1)
                        Reduce = 15000;
                    else if (detect == 2)
                        Reduce = 21000;
                    else if (detect == 3)
                        Reduce = 27000;
                    ReduceSum(5, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if(player5.GetComponent<FollowThePath>().transform.position == waypoints[15].transform.position)
            {
                detect = count13;
                houseName.text = "橙5";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count13 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own13;
                    if (detect == 1)
                        Reduce = 15000;
                    else if (detect == 2)
                        Reduce = 21000;
                    else if (detect == 3)
                        Reduce = 27000;
                    ReduceSum(5, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if(player5.GetComponent<FollowThePath>().transform.position == waypoints[16].transform.position)
            {
                detect = count14;
                houseName.text = "橙6";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count14 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own14;
                    if (detect == 1)
                        Reduce = 15000;
                    else if (detect == 2)
                        Reduce = 21000;
                    else if (detect == 3)
                        Reduce = 27000;
                    ReduceSum(5, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if(player5.GetComponent<FollowThePath>().transform.position == waypoints[17].transform.position)
            {
                detect = count15;
                houseName.text = "橙7";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count15 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own15;
                    if (detect == 1)
                        Reduce = 15000;
                    else if (detect == 2)
                        Reduce = 21000;
                    else if (detect == 3)
                        Reduce = 27000;
                    ReduceSum(5, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if(player5.GetComponent<FollowThePath>().transform.position == waypoints[19].transform.position)
            {
                detect = count16;
                houseName.text = "黃1";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count16 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own16;
                    if (detect == 1)
                        Reduce = 20000;
                    else if (detect == 2)
                        Reduce = 27000;
                    else if (detect == 3)
                        Reduce = 34000;
                    ReduceSum(5, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if(player5.GetComponent<FollowThePath>().transform.position == waypoints[20].transform.position)
            {
                detect = count17;
                houseName.text = "黃2";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count17 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own17;
                    if (detect == 1)
                        Reduce = 20000;
                    else if (detect == 2)
                        Reduce = 27000;
                    else if (detect == 3)
                        Reduce = 34000;
                    ReduceSum(5, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if(player5.GetComponent<FollowThePath>().transform.position == waypoints[21].transform.position)
            {
                if (GameControl.count18 == 1)
                {
                    buy.interactable = false;
                }
                detect = count18;
                houseName.text = "公共物業2";
                cost1.text = "$30000"; cost2.text = "+ $NULL"; cost3.text = "+ $NULL";
                if (count18 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own19;
                    if (detect == 1)
                        Reduce = 30000;
                    ReduceSum(5, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if(player5.GetComponent<FollowThePath>().transform.position == waypoints[22].transform.position)
            {
                detect = count19;
                houseName.text = "黃3";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count19 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own19;
                    if (detect == 1)
                        Reduce = 20000;
                    else if (detect == 2)
                        Reduce = 27000;
                    else if (detect == 3)
                        Reduce = 34000;
                    ReduceSum(5, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if(player5.GetComponent<FollowThePath>().transform.position == waypoints[23].transform.position)
            {
                detect = count20;
                houseName.text = "黃4";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count20 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own20;
                    if (detect == 1)
                        Reduce = 20000;
                    else if (detect == 2)
                        Reduce = 27000;
                    else if (detect == 3)
                        Reduce = 34000;
                    ReduceSum(5, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if(player5.GetComponent<FollowThePath>().transform.position == waypoints[24].transform.position)
            {
                detect = count21;
                houseName.text = "黃5";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count21 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own21;
                    if (detect == 1)
                        Reduce = 20000;
                    else if (detect == 2)
                        Reduce = 27000;
                    else if (detect == 3)
                        Reduce = 34000;
                    ReduceSum(5, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }
            else if(player5.GetComponent<FollowThePath>().transform.position == waypoints[26].transform.position)
            {
                detect = count22;
                houseName.text = "黃6";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count22 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own22;
                    if (detect == 1)
                        Reduce = 20000;
                    else if (detect == 2)
                        Reduce = 27000;
                    else if (detect == 3)
                        Reduce = 34000;
                    ReduceSum(5, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if(player5.GetComponent<FollowThePath>().transform.position == waypoints[27].transform.position)
            {
                detect = count23;
                houseName.text = "黃7";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count23 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own23;
                    if (detect == 1)
                        Reduce = 20000;
                    else if (detect == 2)
                        Reduce = 27000;
                    else if (detect == 3)
                        Reduce = 34000;
                    ReduceSum(5, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if(player5.GetComponent<FollowThePath>().transform.position == waypoints[28].transform.position)
            {
                detect = count24;
                houseName.text = "綠1";
                cost1.text = "$30000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count24 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own24;
                    if (detect == 1)
                        Reduce = 30000;
                    else if (detect == 2)
                        Reduce = 38500;
                    else if (detect == 3)
                        Reduce = 47000;
                    ReduceSum(5, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if(player5.GetComponent<FollowThePath>().transform.position == waypoints[29].transform.position)
            {
                detect = count25;
                houseName.text = "綠2";
                cost1.text = "$30000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count25 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own25;
                    if (detect == 1)
                        Reduce = 30000;
                    else if (detect == 2)
                        Reduce = 38500;
                    else if (detect == 3)
                        Reduce = 47000;
                    ReduceSum(5, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }
            else if(player5.GetComponent<FollowThePath>().transform.position == waypoints[30].transform.position)
            {
                if (DiceNumberTextScript.jail2 == 1 || DiceNumberTextScript.jail3 == 1 || DiceNumberTextScript.jail4 == 1 || DiceNumberTextScript.jail1 == 1 || DiceNumberTextScript.jail6 == 1
                    || DiceNumberTextScript.jail7 == 1 || DiceNumberTextScript.jail8 == 1)
                {
                    if (DiceNumberTextScript.jail2 == 1)
                    {
                        jail2turn = 3;
                        DiceNumberTextScript.jail2 = 0;
                    }
                    if (DiceNumberTextScript.jail3 == 1)
                    {
                        jail3turn = 3;
                        DiceNumberTextScript.jail3 = 0;
                    }
                    if (DiceNumberTextScript.jail4 == 1)
                    {
                        jail4turn = 3;
                        DiceNumberTextScript.jail4 = 0;
                    }
                    if (DiceNumberTextScript.jail1 == 1)
                    {
                        jail1turn = 3;
                        DiceNumberTextScript.jail1 = 1;
                    }
                    if (DiceNumberTextScript.jail6 == 1)
                    {
                        jail6turn = 3;
                        DiceNumberTextScript.jail6 = 0;
                    }
                    if (DiceNumberTextScript.jail7 == 1)
                    {
                        jail7turn = 3;
                        DiceNumberTextScript.jail7 = 0;
                    }
                    if (DiceNumberTextScript.jail8 == 1)
                    {
                        jail8turn = 3;
                        DiceNumberTextScript.jail8 = 0;
                    }

                }

                DiceNumberTextScript.jail5 = 1;
                JailTurn.text = jail5turn.ToString();
                ImageForJail.gameObject.SetActive(true);
            }        
            else if(player5.GetComponent<FollowThePath>().transform.position == waypoints[31].transform.position)
            {
                detect = count26;
                houseName.text = "綠3";
                cost1.text = "$30000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count26 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own26;
                    if (detect == 1)
                        Reduce = 30000;
                    else if (detect == 2)
                        Reduce = 38500;
                    else if (detect == 3)
                        Reduce = 47000;
                    ReduceSum(5, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if(player5.GetComponent<FollowThePath>().transform.position == waypoints[32].transform.position)
            {
                if (GameControl.count32 == 1)
                {
                    buy.interactable = false;
                }
                detect = count27;
                houseName.text = "綠4";
                cost1.text = "$30000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count27 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own27;
                    if (detect == 1)
                        Reduce = 30000;
                    else if (detect == 2)
                        Reduce = 38500;
                    else if (detect == 3)
                        Reduce = 47000;
                    ReduceSum(5, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if(player5.GetComponent<FollowThePath>().transform.position == waypoints[33].transform.position)
            {
                detect = count28;
                houseName.text = "綠5";
                cost1.text = "$30000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count28 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own28;
                    if (detect == 1)
                        Reduce = 30000;
                    else if (detect == 2)
                        Reduce = 38500;
                    else if (detect == 3)
                        Reduce = 47000;
                    ReduceSum(5, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if(player5.GetComponent<FollowThePath>().transform.position == waypoints[34].transform.position)
            {
                detect = count29;
                houseName.text = "綠6";
                cost1.text = "$30000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count29 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own29;
                    if (detect == 1)
                        Reduce = 30000;
                    else if (detect == 2)
                        Reduce = 38500;
                    else if (detect == 3)
                        Reduce = 47000;
                    ReduceSum(5, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if(player5.GetComponent<FollowThePath>().transform.position == waypoints[36].transform.position)
            {
                detect = count30;
                houseName.text = "藍1";
                cost1.text = "$50000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count30 == 0)
                {
                    HouseSelection.reduce = 50000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own30;
                    if (detect == 1)
                        Reduce = 50000;
                    else if (detect == 2)
                        Reduce = 58500;
                    else if (detect == 3)
                        Reduce = 67000;
                    ReduceSum(5, Reduce, own);
                    dropButton.interactable = true;
                    camMain();

                }
            }

            else if(player5.GetComponent<FollowThePath>().transform.position == waypoints[37].transform.position)
            {
                detect = count31;
                houseName.text = "藍2";
                cost1.text = "$50000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count31 == 0)
                {
                    HouseSelection.reduce = 50000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own31;
                    if (detect == 1)
                        Reduce = 50000;
                    else if (detect == 2)
                        Reduce = 58500;
                    else if (detect == 3)
                        Reduce = 67000;
                    ReduceSum(5, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
               
            }

            else if(player5.GetComponent<FollowThePath>().transform.position == waypoints[38].transform.position)
            {
                detect = count32;
                houseName.text = "公共物業3";
                cost1.text = "$30000"; cost2.text = "+ $NULL"; cost3.text = "+ $NULL";
                if (count32 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own30;
                    if (detect == 1)
                        Reduce = 30000;
                    ReduceSum(5, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if(player5.GetComponent<FollowThePath>().transform.position == waypoints[39].transform.position)
            {
                detect = count33;
                houseName.text = "藍3";
                cost1.text = "$50000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count33 == 0)
                {
                    HouseSelection.reduce = 50000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own33;
                    if (detect == 1)
                        Reduce = 50000;
                    else if (detect == 2)
                        Reduce = 58500;
                    else if (detect == 3)
                        Reduce = 67000;
                    ReduceSum(5, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if(player5.GetComponent<FollowThePath>().transform.position == waypoints[40].transform.position)
            {
                detect = count34;
                houseName.text = "藍4";
                cost1.text = "$50000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count34 == 0)
                {
                    HouseSelection.reduce = 50000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own34;
                    if (detect == 1)
                        Reduce = 50000;
                    else if (detect == 2)
                        Reduce = 58500;
                    else if (detect == 3)
                        Reduce = 67000;
                    ReduceSum(5, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if(player5.GetComponent<FollowThePath>().transform.position == waypoints[42].transform.position)
            {
                detect = count35;
                houseName.text = "紫1";
                cost1.text = "$70000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count35 == 0)
                {
                    HouseSelection.reduce = 70000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own35;
                    if (detect == 1)
                        Reduce = 70000;
                    else if (detect == 2)
                        Reduce = 79000;
                    else if (detect == 3)
                        Reduce = 88000;
                    ReduceSum(5, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if(player5.GetComponent<FollowThePath>().transform.position == waypoints[43].transform.position)
            {
                detect = count36;
                houseName.text = "紫2";
                cost1.text = "$70000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count36 == 0)
                {
                    HouseSelection.reduce = 70000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own36;
                    if (detect == 1)
                        Reduce = 70000;
                    else if (detect == 2)
                        Reduce = 79000;
                    else if (detect == 3)
                        Reduce = 88000;
                    ReduceSum(5, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if(player5.GetComponent<FollowThePath>().transform.position == waypoints[44].transform.position)
            {
                detect = count37;
                houseName.text = "紫3";
                cost1.text = "$70000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count37 == 0)
                {
                    HouseSelection.reduce = 70000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own37;
                    if (detect == 1)
                        Reduce = 70000;
                    else if (detect == 2)
                        Reduce = 79000;
                    else if (detect == 3)
                        Reduce = 88000;
                    ReduceSum(5, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if(player5.GetComponent<FollowThePath>().transform.position == waypoints[47].transform.position)
            {
                detect = count38;
                houseName.text = "紫4";
                cost1.text = "$70000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count38 == 0)
                {
                    HouseSelection.reduce = 70000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own38;
                    if (detect == 1)
                        Reduce = 70000;
                    else if (detect == 2)
                        Reduce = 79000;
                    else if (detect == 3)
                        Reduce = 88000;
                    ReduceSum(5, Reduce, own);
                    dropButton.interactable = true;
                    camMain();

                }
            }

            else if(player5.GetComponent<FollowThePath>().transform.position == waypoints[48].transform.position)
            {
                detect = count39;
                houseName.text = "紫5";
                cost1.text = "$70000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count39 == 0)
                {
                    HouseSelection.reduce = 70000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own39;
                    if (detect == 1)
                        Reduce = 70000;
                    else if (detect == 2)
                        Reduce = 79000;
                    else if (detect == 3)
                        Reduce = 88000;
                    ReduceSum(5, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if(player5.GetComponent<FollowThePath>().transform.position == waypoints[49].transform.position)
            {
                detect = count40;
                houseName.text = "啡1";
                cost1.text = "$85000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count40 == 0)
                {
                    HouseSelection.reduce = 85000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own40;
                    if (detect == 1)
                        Reduce = 85000;
                    else if (detect == 2)
                        Reduce = 94000;
                    else if (detect == 3)
                        Reduce = 108000;
                    ReduceSum(5, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if(player5.GetComponent<FollowThePath>().transform.position == waypoints[50].transform.position)
            {
                detect = count41;
                houseName.text = "公共物業4";
                cost1.text = "$30000"; cost2.text = "+ $NULL"; cost3.text = "+ $NULL";
                if (count41 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own41;
                    if (detect == 1)
                        Reduce = 35000;
                    ReduceSum(5, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if(player5.GetComponent<FollowThePath>().transform.position == waypoints[51].transform.position)
            {
                if (GameControl.count42 == 1)
                {
                    buy.interactable = false;
                }
                detect = count42;
                houseName.text = "啡2";
                cost1.text = "$85000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count42 == 0)
                {
                    HouseSelection.reduce = 85000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own42;
                    if (detect == 1)
                        Reduce = 85000;
                    else if (detect == 2)
                        Reduce = 94000;
                    else if (detect == 3)
                        Reduce = 108000;
                    ReduceSum(5, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if(player5.GetComponent<FollowThePath>().transform.position == waypoints[52].transform.position)
            {
                detect = count43;
                houseName.text = "啡3";
                cost1.text = "$85000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count43 == 0)
                {
                    HouseSelection.reduce = 85000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own43;
                    if (detect == 1)
                        Reduce = 85000;
                    else if (detect == 2)
                        Reduce = 94000;
                    else if (detect == 3)
                        Reduce = 108000;
                    ReduceSum(5, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if(player5.GetComponent<FollowThePath>().transform.position == waypoints[55].transform.position)
            {
                detect = count44;
                houseName.text = "黑1";
                cost1.text = "$100000"; cost2.text = "+ $10000"; cost3.text = "+ $10000";
                if (count44 == 0)
                {
                    HouseSelection.reduce = 100000;
                }
                else
                {
                    HouseSelection.reduce = 10000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own44;
                    if (detect == 1)
                        Reduce = 100000;
                    else if (detect == 2)
                        Reduce = 110000;
                    else if (detect == 3)
                        Reduce = 120000;
                    ReduceSum(5, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if(player5.GetComponent<FollowThePath>().transform.position == waypoints[56].transform.position)
            {
                detect = count45;
                houseName.text = "黑2";
                cost1.text = "$100000"; cost2.text = "+ $10000"; cost3.text = "+ $10000";
                if (count45 == 0)
                {
                    HouseSelection.reduce = 100000;
                }
                else
                {
                    HouseSelection.reduce = 10000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own45;
                    if (detect == 1)
                        Reduce = 100000;
                    else if (detect == 2)
                        Reduce = 110000;
                    else if (detect == 3)
                        Reduce = 120000;
                    ReduceSum(5, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if(player5.GetComponent<FollowThePath>().transform.position == waypoints[57].transform.position)
            {
                detect = count46;
                houseName.text = "黑3";
                cost1.text = "$100000"; cost2.text = "+ $10000"; cost3.text = "+ $10000";
                if (count46 == 0)
                {
                    HouseSelection.reduce = 100000;
                }
                else
                {
                    HouseSelection.reduce = 10000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own46;
                    if (detect == 1)
                        Reduce = 100000;
                    else if (detect == 2)
                        Reduce = 110000;
                    else if (detect == 3)
                        Reduce = 120000;
                    ReduceSum(5, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }
            else
            {
                dropButton.interactable = true;
                camMain();
            }

        }

        if (player6.GetComponent<FollowThePath>().wayPointIndex >player6Waypoint + diceSide1Thrown + diceSide2Thrown + diceSide3Thrown - player6.GetComponent<FollowThePath>().Accept)
        {
            whoTurn = 6;
            player6.GetComponent<FollowThePath>().moveAllowed = false;

            player6Waypoint = player6.GetComponent<FollowThePath>().wayPointIndex - 1;
            player6.GetComponent<FollowThePath>().Movement = 0;
            player6.GetComponent<FollowThePath>().Accept = 0;

            if (player6.GetComponent<FollowThePath>().transform.position == waypoints[1].transform.position)
            {
                detect = count1;
                houseName.text = "紅1";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count1 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own1;
                    if (detect == 1)
                        Reduce = 10000;
                    else if (detect == 2)
                        Reduce = 15000;
                    else if (detect == 3)
                        Reduce = 20000;
                    ReduceSum(6, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player6.GetComponent<FollowThePath>().transform.position == waypoints[2].transform.position)
            {
                detect = count2;
                houseName.text = "紅2";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count2 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own2;
                    if (detect == 1)
                        Reduce = 10000;
                    else if (detect == 2)
                        Reduce = 15000;
                    else if (detect == 3)
                        Reduce = 20000;
                    ReduceSum(6, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player6.GetComponent<FollowThePath>().transform.position == waypoints[3].transform.position)
            {
                detect = count3;
                houseName.text = "紅3";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count3 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own3;
                    if (detect == 1)
                        Reduce = 10000;
                    else if (detect == 2)
                        Reduce = 15000;
                    else if (detect == 3)
                        Reduce = 20000;
                    ReduceSum(6, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player6.GetComponent<FollowThePath>().transform.position == waypoints[4].transform.position)
            {
                detect = count4;
                houseName.text = "紅4";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count4 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own4;
                    if (detect == 1)
                        Reduce = 10000;
                    else if (detect == 2)
                        Reduce = 15000;
                    else if (detect == 3)
                        Reduce = 20000;
                    ReduceSum(6, Reduce, own);
                    dropButton.interactable = true;
                    camMain();

                }
            }

            else if (player6.GetComponent<FollowThePath>().transform.position == waypoints[5].transform.position)
            {
                detect = count5;
                houseName.text = "紅5";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count5 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own5;
                    if (detect == 1)
                        Reduce = 10000;
                    else if (detect == 2)
                        Reduce = 15000;
                    else if (detect == 3)
                        Reduce = 20000;
                    ReduceSum(6, Reduce, own);
                    dropButton.interactable = true;
                    camMain();

                }
            }

            else if (player6.GetComponent<FollowThePath>().transform.position == waypoints[7].transform.position)
            {
                detect = count6;
                houseName.text = "紅6";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count6 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own6;
                    if (detect == 1)
                        Reduce = 10000;
                    else if (detect == 2)
                        Reduce = 15000;
                    else if (detect == 3)
                        Reduce = 20000;
                    ReduceSum(6, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player6.GetComponent<FollowThePath>().transform.position == waypoints[8].transform.position)
            {
                detect = count7;
                houseName.text = "紅7";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count7 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own7;
                    if (detect == 1)
                        Reduce = 10000;
                    else if (detect == 2)
                        Reduce = 15000;
                    else if (detect == 3)
                        Reduce = 20000;
                    ReduceSum(6, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player6.GetComponent<FollowThePath>().transform.position == waypoints[9].transform.position)
            {
                detect = count8;
                houseName.text = "橙1";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count8 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own8;
                    if (detect == 1)
                        Reduce = 15000;
                    else if (detect == 2)
                        Reduce = 21000;
                    else if (detect == 3)
                        Reduce = 27000;
                    ReduceSum(6, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player6.GetComponent<FollowThePath>().transform.position == waypoints[10].transform.position)
            {
                if (GameControl.count9 == 1)
                {
                    buy.interactable = false;
                }
                detect = count9;
                houseName.text = "公共物業1";
                cost1.text = "$30000"; cost2.text = "+ NULL"; cost3.text = "+ $NULL";
                if (count9 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own9;
                    if (detect == 1)
                        Reduce = 30000;
                    ReduceSum(6, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player6.GetComponent<FollowThePath>().transform.position == waypoints[11].transform.position)
            {
                detect = count10;
                houseName.text = "橙2";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count10 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own10;
                    if (detect == 1)
                        Reduce = 15000;
                    else if (detect == 2)
                        Reduce = 21000;
                    else if (detect == 3)
                        Reduce = 27000;
                    ReduceSum(6, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player6.GetComponent<FollowThePath>().transform.position == waypoints[13].transform.position)
            {
                detect = count11;
                houseName.text = "橙3";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count11 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own11;
                    if (detect == 1)
                        Reduce = 15000;
                    else if (detect == 2)
                        Reduce = 21000;
                    else if (detect == 3)
                        Reduce = 27000;
                    ReduceSum(6, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player6.GetComponent<FollowThePath>().transform.position == waypoints[14].transform.position)
            {
                detect = count12;
                houseName.text = "橙4";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count12 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own12;
                    if (detect == 1)
                        Reduce = 15000;
                    else if (detect == 2)
                        Reduce = 21000;
                    else if (detect == 3)
                        Reduce = 27000;
                    ReduceSum(6, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player6.GetComponent<FollowThePath>().transform.position == waypoints[15].transform.position)
            {
                detect = count13;
                houseName.text = "橙5";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count13 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own13;
                    if (detect == 1)
                        Reduce = 15000;
                    else if (detect == 2)
                        Reduce = 21000;
                    else if (detect == 3)
                        Reduce = 27000;
                    ReduceSum(6, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player6.GetComponent<FollowThePath>().transform.position == waypoints[16].transform.position)
            {
                detect = count14;
                houseName.text = "橙6";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count14 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own14;
                    if (detect == 1)
                        Reduce = 15000;
                    else if (detect == 2)
                        Reduce = 21000;
                    else if (detect == 3)
                        Reduce = 27000;
                    ReduceSum(6, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player6.GetComponent<FollowThePath>().transform.position == waypoints[17].transform.position)
            {
                detect = count15;
                houseName.text = "橙7";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count15 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own15;
                    if (detect == 1)
                        Reduce = 15000;
                    else if (detect == 2)
                        Reduce = 21000;
                    else if (detect == 3)
                        Reduce = 27000;
                    ReduceSum(6, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player6.GetComponent<FollowThePath>().transform.position == waypoints[19].transform.position)
            {
                detect = count16;
                houseName.text = "黃1";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count16 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own16;
                    if (detect == 1)
                        Reduce = 20000;
                    else if (detect == 2)
                        Reduce = 27000;
                    else if (detect == 3)
                        Reduce = 34000;
                    ReduceSum(6, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player6.GetComponent<FollowThePath>().transform.position == waypoints[20].transform.position)
            {
                detect = count17;
                houseName.text = "黃2";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count17 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own17;
                    if (detect == 1)
                        Reduce = 20000;
                    else if (detect == 2)
                        Reduce = 27000;
                    else if (detect == 3)
                        Reduce = 34000;
                    ReduceSum(6, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player6.GetComponent<FollowThePath>().transform.position == waypoints[21].transform.position)
            {
                if (GameControl.count18 == 1)
                {
                    buy.interactable = false;
                }
                detect = count18;
                houseName.text = "公共物業2";
                cost1.text = "$30000"; cost2.text = "+ $NULL"; cost3.text = "+ $NULL";
                if (count18 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own18;
                    if (detect == 1)
                        Reduce = 30000;
                    ReduceSum(6, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player6.GetComponent<FollowThePath>().transform.position == waypoints[22].transform.position)
            {
                detect = count19;
                houseName.text = "黃3";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count19 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own19;
                    if (detect == 1)
                        Reduce = 20000;
                    else if (detect == 2)
                        Reduce = 27000;
                    else if (detect == 3)
                        Reduce = 34000;
                    ReduceSum(6, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player6.GetComponent<FollowThePath>().transform.position == waypoints[23].transform.position)
            {
                detect = count20;
                houseName.text = "黃4";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count20 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own20;
                    if (detect == 1)
                        Reduce = 20000;
                    else if (detect == 2)
                        Reduce = 27000;
                    else if (detect == 3)
                        Reduce = 34000;
                    ReduceSum(6, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player6.GetComponent<FollowThePath>().transform.position == waypoints[24].transform.position)
            {
                detect = count21;
                houseName.text = "黃5";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count21 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own21;
                    if (detect == 1)
                        Reduce = 20000;
                    else if (detect == 2)
                        Reduce = 27000;
                    else if (detect == 3)
                        Reduce = 34000;
                    ReduceSum(6, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player6.GetComponent<FollowThePath>().transform.position == waypoints[26].transform.position)
            {
                detect = count22;
                houseName.text = "黃6";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count22 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own22;
                    if (detect == 1)
                        Reduce = 20000;
                    else if (detect == 2)
                        Reduce = 27000;
                    else if (detect == 3)
                        Reduce = 34000;
                    ReduceSum(6, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player6.GetComponent<FollowThePath>().transform.position == waypoints[27].transform.position)
            {
                detect = count23;
                houseName.text = "黃7";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count23 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own23;
                    if (detect == 1)
                        Reduce = 20000;
                    else if (detect == 2)
                        Reduce = 27000;
                    else if (detect == 3)
                        Reduce = 34000;
                    ReduceSum(6, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player6.GetComponent<FollowThePath>().transform.position == waypoints[28].transform.position)
            {
                detect = count24;
                houseName.text = "綠1";
                cost1.text = "$30000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count24 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own24;
                    if (detect == 1)
                        Reduce = 30000;
                    else if (detect == 2)
                        Reduce = 38500;
                    else if (detect == 3)
                        Reduce = 47000;
                    ReduceSum(6, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player6.GetComponent<FollowThePath>().transform.position == waypoints[29].transform.position)
            {
                detect = count25;
                houseName.text = "綠2";
                cost1.text = "$30000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count25 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own25;
                    if (detect == 1)
                        Reduce = 30000;
                    else if (detect == 2)
                        Reduce = 38500;
                    else if (detect == 3)
                        Reduce = 47000;
                    ReduceSum(6, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }
            else if (player6.GetComponent<FollowThePath>().transform.position == waypoints[30].transform.position)
            {
                if (DiceNumberTextScript.jail2 == 1 || DiceNumberTextScript.jail3 == 1 || DiceNumberTextScript.jail4 == 1 || DiceNumberTextScript.jail5 == 1 || DiceNumberTextScript.jail1 == 1
                    || DiceNumberTextScript.jail7 == 1 || DiceNumberTextScript.jail8 == 1)
                {
                    if (DiceNumberTextScript.jail2 == 1)
                    {
                        jail2turn = 3;
                        DiceNumberTextScript.jail2 = 0;
                    }
                    if (DiceNumberTextScript.jail3 == 1)
                    {
                        jail3turn = 3;
                        DiceNumberTextScript.jail3 = 0;
                    }
                    if (DiceNumberTextScript.jail4 == 1)
                    {
                        jail4turn = 3;
                        DiceNumberTextScript.jail4 = 0;
                    }
                    if (DiceNumberTextScript.jail5 == 1)
                    {
                        jail5turn = 3;
                        DiceNumberTextScript.jail5 = 0;
                    }
                    if (DiceNumberTextScript.jail1 == 1)
                    {
                        jail1turn = 3;
                        DiceNumberTextScript.jail1 = 0;
                    }
                    if (DiceNumberTextScript.jail7 == 1)
                    {
                        jail7turn = 3;
                        DiceNumberTextScript.jail7 = 0;
                    }
                    if (DiceNumberTextScript.jail8 == 1)
                    {
                        jail8turn = 3;
                        DiceNumberTextScript.jail8 = 0;
                    }
                     
                }

                DiceNumberTextScript.jail6 = 1;
                JailTurn.text = jail6turn.ToString();
                ImageForJail.gameObject.SetActive(true);
            }

            else if (player6.GetComponent<FollowThePath>().transform.position == waypoints[31].transform.position)
            {
                detect = count26;
                houseName.text = "綠3";
                cost1.text = "$30000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count26 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own26;
                    if (detect == 1)
                        Reduce = 30000;
                    else if (detect == 2)
                        Reduce = 38500;
                    else if (detect == 3)
                        Reduce = 47000;
                    ReduceSum(6, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player6.GetComponent<FollowThePath>().transform.position == waypoints[32].transform.position)
            {
                detect = count27;
                houseName.text = "綠4";
                cost1.text = "$30000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count27 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own27;
                    if (detect == 1)
                        Reduce = 30000;
                    else if (detect == 2)
                        Reduce = 38500;
                    else if (detect == 3)
                        Reduce = 47000;
                    ReduceSum(6, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player6.GetComponent<FollowThePath>().transform.position == waypoints[33].transform.position)
            {
                detect = count28;
                houseName.text = "綠5";
                cost1.text = "$30000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count28 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own28;
                    if (detect == 1)
                        Reduce = 30000;
                    else if (detect == 2)
                        Reduce = 38500;
                    else if (detect == 3)
                        Reduce = 47000;
                    ReduceSum(6, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player6.GetComponent<FollowThePath>().transform.position == waypoints[34].transform.position)
            {
                detect = count29;
                houseName.text = "綠6";
                cost1.text = "$30000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count29 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own29;
                    if (detect == 1)
                        Reduce = 30000;
                    else if (detect == 2)
                        Reduce = 38500;
                    else if (detect == 3)
                        Reduce = 47000;
                    ReduceSum(6, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player6.GetComponent<FollowThePath>().transform.position == waypoints[36].transform.position)
            {
                detect = count30;
                houseName.text = "藍1";
                cost1.text = "$50000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count30 == 0)
                {
                    HouseSelection.reduce = 50000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own30;
                    if (detect == 1)
                        Reduce = 50000;
                    else if (detect == 2)
                        Reduce = 58500;
                    else if (detect == 3)
                        Reduce = 67000;
                    ReduceSum(6, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player6.GetComponent<FollowThePath>().transform.position == waypoints[37].transform.position)
            {
                detect = count31;
                houseName.text = "藍2";
                cost1.text = "$50000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count31 == 0)
                {
                    HouseSelection.reduce = 50000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own31;
                    if (detect == 1)
                        Reduce = 50000;
                    else if (detect == 2)
                        Reduce = 58500;
                    else if (detect == 3)
                        Reduce = 67000;
                    ReduceSum(6, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player6.GetComponent<FollowThePath>().transform.position == waypoints[38].transform.position)
            {
                if (GameControl.count32 == 1)
                {
                    buy.interactable = false;
                }
                detect = count32;
                houseName.text = "公共物業3";
                cost1.text = "$30000"; cost2.text = "+ $NULL"; cost3.text = "+ $NULL";
                if (count32 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own32;
                    if (detect == 1)
                        Reduce = 30000;
                    ReduceSum(6, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player6.GetComponent<FollowThePath>().transform.position == waypoints[39].transform.position)
            {
                detect = count33;
                houseName.text = "藍3";
                cost1.text = "$50000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count33 == 0)
                {
                    HouseSelection.reduce = 50000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own33;
                    if (detect == 1)
                        Reduce = 50000;
                    else if (detect == 2)
                        Reduce = 58500;
                    else if (detect == 3)
                        Reduce = 67000;
                    ReduceSum(6, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player6.GetComponent<FollowThePath>().transform.position == waypoints[40].transform.position)
            {
                detect = count34;
                houseName.text = "藍4";
                cost1.text = "$50000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count34 == 0)
                {
                    HouseSelection.reduce = 50000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own34;
                    if (detect == 1)
                        Reduce = 50000;
                    else if (detect == 2)
                        Reduce = 58500;
                    else if (detect == 3)
                        Reduce = 67000;
                    ReduceSum(6, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player6.GetComponent<FollowThePath>().transform.position == waypoints[42].transform.position)
            {
                detect = count35;
                houseName.text = "紫1";
                cost1.text = "$70000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count35 == 0)
                {
                    HouseSelection.reduce = 70000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own35;
                    if (detect == 1)
                        Reduce = 70000;
                    else if (detect == 2)
                        Reduce = 79000;
                    else if (detect == 3)
                        Reduce = 88000;
                    ReduceSum(6, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player6.GetComponent<FollowThePath>().transform.position == waypoints[43].transform.position)
            {
                detect = count36;
                houseName.text = "紫2";
                cost1.text = "$70000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count36 == 0)
                {
                    HouseSelection.reduce = 70000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own36;
                    if (detect == 1)
                        Reduce = 70000;
                    else if (detect == 2)
                        Reduce = 79000;
                    else if (detect == 3)
                        Reduce = 88000;
                    ReduceSum(6, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player6.GetComponent<FollowThePath>().transform.position == waypoints[44].transform.position)
            {
                detect = count37;
                houseName.text = "紫3";
                cost1.text = "$70000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count37 == 0)
                {
                    HouseSelection.reduce = 70000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own37;
                    if (detect == 1)
                        Reduce = 70000;
                    else if (detect == 2)
                        Reduce = 79000;
                    else if (detect == 3)
                        Reduce = 88000;
                    ReduceSum(6, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player6.GetComponent<FollowThePath>().transform.position == waypoints[47].transform.position)
            {
                detect = count38;
                houseName.text = "紫4";
                cost1.text = "$70000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count38 == 0)
                {
                    HouseSelection.reduce = 70000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own38;
                    if (detect == 1)
                        Reduce = 70000;
                    else if (detect == 2)
                        Reduce = 79000;
                    else if (detect == 3)
                        Reduce = 88000;
                    ReduceSum(6, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player6.GetComponent<FollowThePath>().transform.position == waypoints[48].transform.position)
            {
                detect = count39;
                houseName.text = "紫5";
                cost1.text = "$70000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count39 == 0)
                {
                    HouseSelection.reduce = 70000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own39;
                    if (detect == 1)
                        Reduce = 70000;
                    else if (detect == 2)
                        Reduce = 79000;
                    else if (detect == 3)
                        Reduce = 88000;
                    ReduceSum(6, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player6.GetComponent<FollowThePath>().transform.position == waypoints[49].transform.position)
            {
                detect = count40;
                houseName.text = "啡1";
                cost1.text = "$85000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count40 == 0)
                {
                    HouseSelection.reduce = 85000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own40;
                    if (detect == 1)
                        Reduce = 85000;
                    else if (detect == 2)
                        Reduce = 94000;
                    else if (detect == 3)
                        Reduce = 108000;
                    ReduceSum(6, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player6.GetComponent<FollowThePath>().transform.position == waypoints[50].transform.position)
            {
                detect = count41;
                houseName.text = "公共物業4";
                cost1.text = "$30000"; cost2.text = "+ $NULL"; cost3.text = "+ $NULL";
                if (count41 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own41;
                    if (detect == 1)
                        Reduce = 30000;
                    ReduceSum(6, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player6.GetComponent<FollowThePath>().transform.position == waypoints[51].transform.position)
            {
                if (GameControl.count42 == 1)
                {
                    buy.interactable = false;
                }
                detect = count42;
                houseName.text = "啡2";
                cost1.text = "$85000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count42 == 0)
                {
                    HouseSelection.reduce = 85000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own42;
                    if (detect == 1)
                        Reduce = 85000;
                    else if (detect == 2)
                        Reduce = 94000;
                    else if (detect == 3)
                        Reduce = 108000;
                    ReduceSum(6, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player6.GetComponent<FollowThePath>().transform.position == waypoints[52].transform.position)
            {
                detect = count43;
                houseName.text = "啡3";
                cost1.text = "$85000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count43 == 0)
                {
                    HouseSelection.reduce = 85000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own43;
                    if (detect == 1)
                        Reduce = 85000;
                    else if (detect == 2)
                        Reduce = 94000;
                    else if (detect == 3)
                        Reduce = 108000;
                    ReduceSum(6, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player6.GetComponent<FollowThePath>().transform.position == waypoints[55].transform.position)
            {
                detect = count44;
                houseName.text = "黑1";
                cost1.text = "$100000"; cost2.text = "+ $10000"; cost3.text = "+ $10000";
                if (count44 == 0)
                {
                    HouseSelection.reduce = 100000;
                }
                else
                {
                    HouseSelection.reduce = 10000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own44;
                    if (detect == 1)
                        Reduce = 100000;
                    else if (detect == 2)
                        Reduce = 110000;
                    else if (detect == 3)
                        Reduce = 120000;
                    ReduceSum(6, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player6.GetComponent<FollowThePath>().transform.position == waypoints[56].transform.position)
            {
                detect = count45;
                houseName.text = "黑2";
                cost1.text = "$100000"; cost2.text = "+ $10000"; cost3.text = "+ $10000";
                if (count45 == 0)
                {
                    HouseSelection.reduce = 100000;
                }
                else
                {
                    HouseSelection.reduce = 10000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own45;
                    if (detect == 1)
                        Reduce = 85000;
                    else if (detect == 2)
                        Reduce = 94000;
                    else if (detect == 3)
                        Reduce = 108000;
                    ReduceSum(6, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player6.GetComponent<FollowThePath>().transform.position == waypoints[57].transform.position)
            {
                detect = count46;
                houseName.text = "黑3";
                cost1.text = "$100000"; cost2.text = "+ $10000"; cost3.text = "+ $10000";
                if (count46 == 0)
                {
                    HouseSelection.reduce = 100000;
                }
                else
                {
                    HouseSelection.reduce = 10000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own46;
                    if (detect == 1)
                        Reduce = 85000;
                    else if (detect == 2)
                        Reduce = 94000;
                    else if (detect == 3)
                        Reduce = 108000;
                    ReduceSum(6, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }
            else
            {
                dropButton.interactable = true;
                camMain();
            }
        }

        if (player7.GetComponent<FollowThePath>().wayPointIndex >player7Waypoint + diceSide1Thrown + diceSide2Thrown + diceSide3Thrown - player7.GetComponent<FollowThePath>().Accept)
        {
            whoTurn = 7;
            player7.GetComponent<FollowThePath>().moveAllowed = false;
            player7Waypoint = player7.GetComponent<FollowThePath>().wayPointIndex - 1;
            player7.GetComponent<FollowThePath>().Movement = 0;
            player7.GetComponent<FollowThePath>().Accept = 0;

            if (player7.GetComponent<FollowThePath>().transform.position == waypoints[1].transform.position)
            {
                detect = count1;
                houseName.text = "紅1";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count1 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own1;
                    if (detect == 1)
                        Reduce = 10000;
                    else if (detect == 2)
                        Reduce = 15000;
                    else if (detect == 3)
                        Reduce = 20000;
                    ReduceSum(7, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player7.GetComponent<FollowThePath>().transform.position == waypoints[2].transform.position)
            {
                detect = count2;
                houseName.text = "紅2";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count2 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own2;
                    if (detect == 1)
                        Reduce = 10000;
                    else if (detect == 2)
                        Reduce = 15000;
                    else if (detect == 3)
                        Reduce = 20000;
                    ReduceSum(7, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player7.GetComponent<FollowThePath>().transform.position == waypoints[3].transform.position)
            {
                detect = count3;
                houseName.text = "紅3";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count3 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own3;
                    if (detect == 1)
                        Reduce = 10000;
                    else if (detect == 2)
                        Reduce = 15000;
                    else if (detect == 3)
                        Reduce = 20000;
                    ReduceSum(7, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player7.GetComponent<FollowThePath>().transform.position == waypoints[4].transform.position)
            {
                detect = count4;
                houseName.text = "紅4";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count4 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own4;
                    if (detect == 1)
                        Reduce = 10000;
                    else if (detect == 2)
                        Reduce = 15000;
                    else if (detect == 3)
                        Reduce = 20000;
                    ReduceSum(7, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player7.GetComponent<FollowThePath>().transform.position == waypoints[5].transform.position)
            {
                detect = count5;
                houseName.text = "紅5";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count5 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own5;
                    if (detect == 1)
                        Reduce = 10000;
                    else if (detect == 2)
                        Reduce = 15000;
                    else if (detect == 3)
                        Reduce = 20000;
                    ReduceSum(7, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player7.GetComponent<FollowThePath>().transform.position == waypoints[7].transform.position)
            {
                detect = count6;
                houseName.text = "紅6";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count6 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own6;
                    if (detect == 1)
                        Reduce = 10000;
                    else if (detect == 2)
                        Reduce = 15000;
                    else if (detect == 3)
                        Reduce = 20000;
                    ReduceSum(7, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player7.GetComponent<FollowThePath>().transform.position == waypoints[8].transform.position)
            {
                detect = count7;
                houseName.text = "紅7";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count7 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own7;
                    if (detect == 1)
                        Reduce = 10000;
                    else if (detect == 2)
                        Reduce = 15000;
                    else if (detect == 3)
                        Reduce = 20000;
                    ReduceSum(7, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player7.GetComponent<FollowThePath>().transform.position == waypoints[9].transform.position)
            {
                detect = count8;
                houseName.text = "橙1";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count8 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own8;
                    if (detect == 1)
                        Reduce = 15000;
                    else if (detect == 2)
                        Reduce = 21000;
                    else if (detect == 3)
                        Reduce = 27000;
                    ReduceSum(7, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player7.GetComponent<FollowThePath>().transform.position == waypoints[10].transform.position)
            {
                if (GameControl.count9 == 1)
                {
                    buy.interactable = false;
                }
                detect = count9;
                houseName.text = "公共物業1";
                cost1.text = "$30000"; cost2.text = "+ NULL"; cost3.text = "+ $NULL";
                if (count9 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own9;
                    if (detect == 1)
                        Reduce = 30000;
                    ReduceSum(7, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player7.GetComponent<FollowThePath>().transform.position == waypoints[11].transform.position)
            {
                detect = count10;
                houseName.text = "橙2";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count10 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own10;
                    if (detect == 1)
                        Reduce = 15000;
                    else if (detect == 2)
                        Reduce = 21000;
                    else if (detect == 3)
                        Reduce = 27000;
                    ReduceSum(7, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player7.GetComponent<FollowThePath>().transform.position == waypoints[13].transform.position)
            {
                detect = count11;
                houseName.text = "橙3";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count11 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own11;
                    if (detect == 1)
                        Reduce = 15000;
                    else if (detect == 2)
                        Reduce = 21000;
                    else if (detect == 3)
                        Reduce = 27000;
                    ReduceSum(7, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player7.GetComponent<FollowThePath>().transform.position == waypoints[14].transform.position)
            {
                detect = count12;
                houseName.text = "橙4";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count12 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own12;
                    if (detect == 1)
                        Reduce = 15000;
                    else if (detect == 2)
                        Reduce = 21000;
                    else if (detect == 3)
                        Reduce = 27000;
                    ReduceSum(7, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player7.GetComponent<FollowThePath>().transform.position == waypoints[15].transform.position)
            {
                detect = count13;
                houseName.text = "橙5";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count13 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own13;
                    if (detect == 1)
                        Reduce = 15000;
                    else if (detect == 2)
                        Reduce = 21000;
                    else if (detect == 3)
                        Reduce = 27000;
                    ReduceSum(7, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player7.GetComponent<FollowThePath>().transform.position == waypoints[16].transform.position)
            {
                detect = count14;
                houseName.text = "橙6";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count14 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own14;
                    if (detect == 1)
                        Reduce = 15000;
                    else if (detect == 2)
                        Reduce = 21000;
                    else if (detect == 3)
                        Reduce = 27000;
                    ReduceSum(7, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player7.GetComponent<FollowThePath>().transform.position == waypoints[17].transform.position)
            {
                detect = count15;
                houseName.text = "橙7";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count15 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own15;
                    if (detect == 1)
                        Reduce = 15000;
                    else if (detect == 2)
                        Reduce = 21000;
                    else if (detect == 3)
                        Reduce = 27000;
                    ReduceSum(7, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player7.GetComponent<FollowThePath>().transform.position == waypoints[19].transform.position)
            {
                detect = count16;
                houseName.text = "黃1";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count16 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own16;
                    if (detect == 1)
                        Reduce = 20000;
                    else if (detect == 2)
                        Reduce = 27000;
                    else if (detect == 3)
                        Reduce = 34000;
                    ReduceSum(7, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player7.GetComponent<FollowThePath>().transform.position == waypoints[20].transform.position)
            {
                detect = count17;
                houseName.text = "黃2";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count17 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own17;
                    if (detect == 1)
                        Reduce = 20000;
                    else if (detect == 2)
                        Reduce = 27000;
                    else if (detect == 3)
                        Reduce = 34000;
                    ReduceSum(7, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player7.GetComponent<FollowThePath>().transform.position == waypoints[21].transform.position)
            {
                if (GameControl.count18 == 1)
                {
                    buy.interactable = false;
                }
                detect = count18;
                houseName.text = "公共物業2";
                cost1.text = "$30000"; cost2.text = "+ $NULL"; cost3.text = "+ $NULL";
                if (count18 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own18;
                    if (detect == 1)
                        Reduce = 30000;
                    ReduceSum(7, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player7.GetComponent<FollowThePath>().transform.position == waypoints[22].transform.position)
            {
                detect = count19;
                houseName.text = "黃3";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count19 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own19;
                    if (detect == 1)
                        Reduce = 20000;
                    else if (detect == 2)
                        Reduce = 27000;
                    else if (detect == 3)
                        Reduce = 34000;
                    ReduceSum(7, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player7.GetComponent<FollowThePath>().transform.position == waypoints[23].transform.position)
            {
                detect = count20;
                houseName.text = "黃4";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count20 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own20;
                    if (detect == 1)
                        Reduce = 20000;
                    else if (detect == 2)
                        Reduce = 27000;
                    else if (detect == 3)
                        Reduce = 34000;
                    ReduceSum(7, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player7.GetComponent<FollowThePath>().transform.position == waypoints[24].transform.position)
            {
                detect = count21;
                houseName.text = "黃5";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count21 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own21;
                    if (detect == 1)
                        Reduce = 20000;
                    else if (detect == 2)
                        Reduce = 27000;
                    else if (detect == 3)
                        Reduce = 34000;
                    ReduceSum(7, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player7.GetComponent<FollowThePath>().transform.position == waypoints[26].transform.position)
            {
                detect = count22;
                houseName.text = "黃6";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count22 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own22;
                    if (detect == 1)
                        Reduce = 20000;
                    else if (detect == 2)
                        Reduce = 27000;
                    else if (detect == 3)
                        Reduce = 34000;
                    ReduceSum(7, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player7.GetComponent<FollowThePath>().transform.position == waypoints[27].transform.position)
            {
                detect = count23;
                houseName.text = "黃7";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count23 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own23;
                    if (detect == 1)
                        Reduce = 20000;
                    else if (detect == 2)
                        Reduce = 27000;
                    else if (detect == 3)
                        Reduce = 34000;
                    ReduceSum(7, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player7.GetComponent<FollowThePath>().transform.position == waypoints[28].transform.position)
            {
                detect = count24;
                houseName.text = "綠1";
                cost1.text = "$30000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count24 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own24;
                    if (detect == 1)
                        Reduce = 30000;
                    else if (detect == 2)
                        Reduce = 38500;
                    else if (detect == 3)
                        Reduce = 47000;
                    ReduceSum(7, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player7.GetComponent<FollowThePath>().transform.position == waypoints[29].transform.position)
            {
                detect = count25;
                houseName.text = "綠2";
                cost1.text = "$30000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count25 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own25;
                    if (detect == 1)
                        Reduce = 30000;
                    else if (detect == 2)
                        Reduce = 38500;
                    else if (detect == 3)
                        Reduce = 47000;
                    ReduceSum(7, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }
            else if (player7.GetComponent<FollowThePath>().transform.position == waypoints[30].transform.position)
            {
                if (DiceNumberTextScript.jail2 == 1 || DiceNumberTextScript.jail3 == 1 || DiceNumberTextScript.jail4 == 1 || DiceNumberTextScript.jail5 == 1 || DiceNumberTextScript.jail6 == 1
                    || DiceNumberTextScript.jail1 == 1 || DiceNumberTextScript.jail8 == 1)
                {
                    if (DiceNumberTextScript.jail2 == 1)
                    {
                        jail2turn = 3;
                        DiceNumberTextScript.jail2 = 0;
                    }
                    if (DiceNumberTextScript.jail3 == 1)
                    {
                        jail3turn = 3;
                        DiceNumberTextScript.jail3 = 0;
                    }
                    if (DiceNumberTextScript.jail4 == 1)
                    {
                        jail4turn = 3;
                        DiceNumberTextScript.jail4 = 0;
                    }
                    if (DiceNumberTextScript.jail5 == 1)
                    {
                        jail5turn = 3;
                        DiceNumberTextScript.jail5 = 0;
                    }
                    if (DiceNumberTextScript.jail6 == 1)
                    {
                        jail6turn = 3;
                        DiceNumberTextScript.jail6 = 0;
                    }
                    if (DiceNumberTextScript.jail1 == 1)
                    {
                        jail1turn = 3;
                        DiceNumberTextScript.jail1 = 0;
                    }
                    if (DiceNumberTextScript.jail8 == 1)
                    {
                        jail8turn = 3;
                        DiceNumberTextScript.jail8 = 0;
                    }
                }

                DiceNumberTextScript.jail7 = 1;
                JailTurn.text = jail7turn.ToString();
                ImageForJail.gameObject.SetActive(true);
            }

            else if (player7.GetComponent<FollowThePath>().transform.position == waypoints[31].transform.position)
            {
                detect = count26;
                houseName.text = "綠3";
                cost1.text = "$30000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count26 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own26;
                    if (detect == 1)
                        Reduce = 30000;
                    else if (detect == 2)
                        Reduce = 38500;
                    else if (detect == 3)
                        Reduce = 47000;
                    ReduceSum(7, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player7.GetComponent<FollowThePath>().transform.position == waypoints[32].transform.position)
            {
                detect = count27;
                houseName.text = "綠4";
                cost1.text = "$30000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count27 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own27;
                    if (detect == 1)
                        Reduce = 30000;
                    else if (detect == 2)
                        Reduce = 38500;
                    else if (detect == 3)
                        Reduce = 47000;
                    ReduceSum(7, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player7.GetComponent<FollowThePath>().transform.position == waypoints[33].transform.position)
            {
                detect = count28;
                houseName.text = "綠5";
                cost1.text = "$30000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count28 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own28;
                    if (detect == 1)
                        Reduce = 30000;
                    else if (detect == 2)
                        Reduce = 38500;
                    else if (detect == 3)
                        Reduce = 47000;
                    ReduceSum(7, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player7.GetComponent<FollowThePath>().transform.position == waypoints[34].transform.position)
            {
                detect = count29;
                houseName.text = "綠6";
                cost1.text = "$30000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count29 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own29;
                    if (detect == 1)
                        Reduce = 30000;
                    else if (detect == 2)
                        Reduce = 38500;
                    else if (detect == 3)
                        Reduce = 47000;
                    ReduceSum(7, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player7.GetComponent<FollowThePath>().transform.position == waypoints[36].transform.position)
            {
                detect = count30;
                houseName.text = "藍1";
                cost1.text = "$50000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count30 == 0)
                {
                    HouseSelection.reduce = 50000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own30;
                    if (detect == 1)
                        Reduce = 50000;
                    else if (detect == 2)
                        Reduce = 58500;
                    else if (detect == 3)
                        Reduce = 67000;
                    ReduceSum(7, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player7.GetComponent<FollowThePath>().transform.position == waypoints[37].transform.position)
            {
                detect = count31;
                houseName.text = "藍2";
                cost1.text = "$50000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count31 == 0)
                {
                    HouseSelection.reduce = 50000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own31;
                    if (detect == 1)
                        Reduce = 50000;
                    else if (detect == 2)
                        Reduce = 58500;
                    else if (detect == 3)
                        Reduce = 67000;
                    ReduceSum(7, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player7.GetComponent<FollowThePath>().transform.position == waypoints[38].transform.position)
            {
                if (GameControl.count32 == 1)
                {
                    buy.interactable = false;
                }
                detect = count32;
                houseName.text = "公共物業3";
                cost1.text = "$30000"; cost2.text = "+ $NULL"; cost3.text = "+ $NULL";
                if (count32 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own32;
                    if (detect == 1)
                        Reduce = 30000;
                    ReduceSum(7, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player7.GetComponent<FollowThePath>().transform.position == waypoints[39].transform.position)
            {
                detect = count33;
                houseName.text = "藍3";
                cost1.text = "$50000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count33 == 0)
                {
                    HouseSelection.reduce = 50000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own33;
                    if (detect == 1)
                        Reduce = 50000;
                    else if (detect == 2)
                        Reduce = 58500;
                    else if (detect == 3)
                        Reduce = 67000;
                    ReduceSum(7, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player7.GetComponent<FollowThePath>().transform.position == waypoints[40].transform.position)
            {
                detect = count34;
                houseName.text = "藍4";
                cost1.text = "$50000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count34 == 0)
                {
                    HouseSelection.reduce = 50000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own34;
                    if (detect == 1)
                        Reduce = 50000;
                    else if (detect == 2)
                        Reduce = 58500;
                    else if (detect == 3)
                        Reduce = 67000;
                    ReduceSum(7, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player7.GetComponent<FollowThePath>().transform.position == waypoints[42].transform.position)
            {
                detect = count35;
                houseName.text = "紫1";
                cost1.text = "$70000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count35 == 0)
                {
                    HouseSelection.reduce = 70000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own35;
                    if (detect == 1)
                        Reduce = 70000;
                    else if (detect == 2)
                        Reduce = 79000;
                    else if (detect == 3)
                        Reduce = 88000;
                    ReduceSum(7, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player7.GetComponent<FollowThePath>().transform.position == waypoints[43].transform.position)
            {
                detect = count36;
                houseName.text = "紫2";
                cost1.text = "$70000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count36 == 0)
                {
                    HouseSelection.reduce = 70000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own36;
                    if (detect == 1)
                        Reduce = 70000;
                    else if (detect == 2)
                        Reduce = 79000;
                    else if (detect == 3)
                        Reduce = 88000;
                    ReduceSum(7, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player7.GetComponent<FollowThePath>().transform.position == waypoints[44].transform.position)
            {
                detect = count37;
                houseName.text = "紫3";
                cost1.text = "$70000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count37 == 0)
                {
                    HouseSelection.reduce = 70000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own37;
                    if (detect == 1)
                        Reduce = 70000;
                    else if (detect == 2)
                        Reduce = 79000;
                    else if (detect == 3)
                        Reduce = 88000;
                    ReduceSum(7, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player7.GetComponent<FollowThePath>().transform.position == waypoints[47].transform.position)
            {
                detect = count38;
                houseName.text = "紫4";
                cost1.text = "$70000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count38 == 0)
                {
                    HouseSelection.reduce = 70000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own38;
                    if (detect == 1)
                        Reduce = 70000;
                    else if (detect == 2)
                        Reduce = 79000;
                    else if (detect == 3)
                        Reduce = 88000;
                    ReduceSum(7, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player7.GetComponent<FollowThePath>().transform.position == waypoints[48].transform.position)
            {
                detect = count39;
                houseName.text = "紫5";
                cost1.text = "$70000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count39 == 0)
                {
                    HouseSelection.reduce = 70000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own39;
                    if (detect == 1)
                        Reduce = 70000;
                    else if (detect == 2)
                        Reduce = 79000;
                    else if (detect == 3)
                        Reduce = 88000;
                    ReduceSum(7, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player7.GetComponent<FollowThePath>().transform.position == waypoints[49].transform.position)
            {
                detect = count40;
                houseName.text = "啡1";
                cost1.text = "$85000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count40 == 0)
                {
                    HouseSelection.reduce = 85000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own45;
                    if (detect == 1)
                        Reduce = 85000;
                    else if (detect == 2)
                        Reduce = 94000;
                    else if (detect == 3)
                        Reduce = 108000;
                    ReduceSum(7, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player7.GetComponent<FollowThePath>().transform.position == waypoints[50].transform.position)
            {
                detect = count41;
                houseName.text = "公共物業4";
                cost1.text = "$30000"; cost2.text = "+ $NULL"; cost3.text = "+ $NULL";
                if (count41 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own41;
                    if (detect == 1)
                        Reduce = 30000;
                    ReduceSum(7, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player7.GetComponent<FollowThePath>().transform.position == waypoints[51].transform.position)
            {
                if (GameControl.count42 == 1)
                {
                    buy.interactable = false;
                }
                detect = count42;
                houseName.text = "啡2";
                cost1.text = "$85000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count42 == 0)
                {
                    HouseSelection.reduce = 85000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own42;
                    if (detect == 1)
                        Reduce = 85000;
                    else if (detect == 2)
                        Reduce = 94000;
                    else if (detect == 3)
                        Reduce = 108000;
                    ReduceSum(7, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player7.GetComponent<FollowThePath>().transform.position == waypoints[52].transform.position)
            {
                detect = count43;
                houseName.text = "啡3";
                cost1.text = "$85000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count43 == 0)
                {
                    HouseSelection.reduce = 85000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own43;
                    if (detect == 1)
                        Reduce = 85000;
                    else if (detect == 2)
                        Reduce = 94000;
                    else if (detect == 3)
                        Reduce = 108000;
                    ReduceSum(7, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player7.GetComponent<FollowThePath>().transform.position == waypoints[55].transform.position)
            {
                detect = count44;
                houseName.text = "黑1";
                cost1.text = "$100000"; cost2.text = "+ $10000"; cost3.text = "+ $10000";
                if (count44 == 0)
                {
                    HouseSelection.reduce = 100000;
                }
                else
                {
                    HouseSelection.reduce = 10000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own44;
                    if (detect == 1)
                        Reduce = 100000;
                    else if (detect == 2)
                        Reduce = 110000;
                    else if (detect == 3)
                        Reduce = 120000;
                    ReduceSum(7, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player7.GetComponent<FollowThePath>().transform.position == waypoints[56].transform.position)
            {
                detect = count45;
                houseName.text = "黑2";
                cost1.text = "$100000"; cost2.text = "+ $10000"; cost3.text = "+ $10000";
                if (count45 == 0)
                {
                    HouseSelection.reduce = 100000;
                }
                else
                {
                    HouseSelection.reduce = 10000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own45;
                    if (detect == 1)
                        Reduce = 100000;
                    else if (detect == 2)
                        Reduce = 110000;
                    else if (detect == 3)
                        Reduce = 120000;
                    ReduceSum(7, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player7.GetComponent<FollowThePath>().transform.position == waypoints[57].transform.position)
            {
                detect = count46;
                houseName.text = "黑3";
                cost1.text = "$100000"; cost2.text = "+ $10000"; cost3.text = "+ $10000";
                if (count46 == 0)
                {
                    HouseSelection.reduce = 100000;
                }
                else
                {
                    HouseSelection.reduce = 10000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own46;
                    if (detect == 1)
                        Reduce = 100000;
                    else if (detect == 2)
                        Reduce = 110000;
                    else if (detect == 3)
                        Reduce = 120000;
                    ReduceSum(7, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }
            else
            {
                dropButton.interactable = true;
                camMain();
            }

        }

        if (player8.GetComponent<FollowThePath>().wayPointIndex >player8Waypoint + diceSide1Thrown + diceSide2Thrown + diceSide3Thrown - player8.GetComponent<FollowThePath>().Accept)
        {
            whoTurn = 8;
            player8.GetComponent<FollowThePath>().moveAllowed = false;
            player8Waypoint = player8.GetComponent<FollowThePath>().wayPointIndex - 1;
            player8.GetComponent<FollowThePath>().Movement = 0;
            player8.GetComponent<FollowThePath>().Accept = 0;

            if (player8.GetComponent<FollowThePath>().transform.position == waypoints[1].transform.position)
            {
                detect = count1;
                houseName.text = "紅1";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count1 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own1;
                    if (detect == 1)
                        Reduce = 10000;
                    else if (detect == 2)
                        Reduce = 15000;
                    else if (detect == 3)
                        Reduce = 20000;
                    ReduceSum(8, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player8.GetComponent<FollowThePath>().transform.position == waypoints[2].transform.position)
            {
                detect = count2;
                houseName.text = "紅2";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count2 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own2;
                    if (detect == 1)
                        Reduce = 10000;
                    else if (detect == 2)
                        Reduce = 15000;
                    else if (detect == 3)
                        Reduce = 20000;
                    ReduceSum(8, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player8.GetComponent<FollowThePath>().transform.position == waypoints[3].transform.position)
            {
                detect = count3;
                houseName.text = "紅3";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count3 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own3;
                    if (detect == 1)
                        Reduce = 10000;
                    else if (detect == 2)
                        Reduce = 15000;
                    else if (detect == 3)
                        Reduce = 20000;
                    ReduceSum(8, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player8.GetComponent<FollowThePath>().transform.position == waypoints[4].transform.position)
            {
                detect = count4;
                houseName.text = "紅4";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count4 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own4;
                    if (detect == 1)
                        Reduce = 10000;
                    else if (detect == 2)
                        Reduce = 15000;
                    else if (detect == 3)
                        Reduce = 20000;
                    ReduceSum(8, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player8.GetComponent<FollowThePath>().transform.position == waypoints[5].transform.position)
            {
                detect = count5;
                houseName.text = "紅5";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count5 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own5;
                    if (detect == 1)
                        Reduce = 10000;
                    else if (detect == 2)
                        Reduce = 15000;
                    else if (detect == 3)
                        Reduce = 20000;
                    ReduceSum(8, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player8.GetComponent<FollowThePath>().transform.position == waypoints[7].transform.position)
            {
                detect = count6;
                houseName.text = "紅6";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count6 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own6;
                    if (detect == 1)
                        Reduce = 10000;
                    else if (detect == 2)
                        Reduce = 15000;
                    else if (detect == 3)
                        Reduce = 20000;
                    ReduceSum(8, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player8.GetComponent<FollowThePath>().transform.position == waypoints[8].transform.position)
            {
                detect = count7;
                houseName.text = "紅7";
                cost1.text = "$10000"; cost2.text = "+ $5000"; cost3.text = "+ $5000";
                if (count7 == 0)
                {
                    HouseSelection.reduce = 10000;
                }
                else
                {
                    HouseSelection.reduce = 5000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own7;
                    if (detect == 1)
                        Reduce = 10000;
                    else if (detect == 2)
                        Reduce = 15000;
                    else if (detect == 3)
                        Reduce = 20000;
                    ReduceSum(8, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player8.GetComponent<FollowThePath>().transform.position == waypoints[9].transform.position)
            {
                detect = count8;
                houseName.text = "橙1";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count8 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own8;
                    if (detect == 1)
                        Reduce = 15000;
                    else if (detect == 2)
                        Reduce = 21000;
                    else if (detect == 3)
                        Reduce = 27000;
                    ReduceSum(8, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player8.GetComponent<FollowThePath>().transform.position == waypoints[10].transform.position)
            {
                if (GameControl.count9 == 1)
                {
                    buy.interactable = false;
                }
                detect = count9;
                houseName.text = "公共物業1";
                cost1.text = "$30000"; cost2.text = "+ NULL"; cost3.text = "+ $NULL";
                if (count9 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own9;
                    if (detect == 1)
                        Reduce = 30000;
                    ReduceSum(8, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player8.GetComponent<FollowThePath>().transform.position == waypoints[11].transform.position)
            {
                detect = count10;
                houseName.text = "橙2";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count10 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own10;
                    if (detect == 1)
                        Reduce = 15000;
                    else if (detect == 2)
                        Reduce = 21000;
                    else if (detect == 3)
                        Reduce = 27000;
                    ReduceSum(8, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player8.GetComponent<FollowThePath>().transform.position == waypoints[13].transform.position)
            {
                detect = count11;
                houseName.text = "橙3";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count11 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own11;
                    if (detect == 1)
                        Reduce = 15000;
                    else if (detect == 2)
                        Reduce = 21000;
                    else if (detect == 3)
                        Reduce = 27000;
                    ReduceSum(8, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player8.GetComponent<FollowThePath>().transform.position == waypoints[14].transform.position)
            {
                detect = count12;
                houseName.text = "橙4";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count12 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own12;
                    if (detect == 1)
                        Reduce = 15000;
                    else if (detect == 2)
                        Reduce = 21000;
                    else if (detect == 3)
                        Reduce = 27000;
                    ReduceSum(8, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player8.GetComponent<FollowThePath>().transform.position == waypoints[15].transform.position)
            {
                detect = count13;
                houseName.text = "橙5";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count13 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own13;
                    if (detect == 1)
                        Reduce = 15000;
                    else if (detect == 2)
                        Reduce = 21000;
                    else if (detect == 3)
                        Reduce = 27000;
                    ReduceSum(8, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player8.GetComponent<FollowThePath>().transform.position == waypoints[16].transform.position)
            {
                detect = count14;
                houseName.text = "橙6";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count14 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own14;
                    if (detect == 1)
                        Reduce = 15000;
                    else if (detect == 2)
                        Reduce = 21000;
                    else if (detect == 3)
                        Reduce = 27000;
                    ReduceSum(8, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player8.GetComponent<FollowThePath>().transform.position == waypoints[17].transform.position)
            {
                detect = count15;
                houseName.text = "橙7";
                cost1.text = "$15000"; cost2.text = "+ $6000"; cost3.text = "+ $6000";
                if (count15 == 0)
                {
                    HouseSelection.reduce = 15000;
                }
                else
                {
                    HouseSelection.reduce = 6000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own15;
                    if (detect == 1)
                        Reduce = 15000;
                    else if (detect == 2)
                        Reduce = 21000;
                    else if (detect == 3)
                        Reduce = 27000;
                    ReduceSum(8, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player8.GetComponent<FollowThePath>().transform.position == waypoints[19].transform.position)
            {
                detect = count16;
                houseName.text = "黃1";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count16 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own16;
                    if (detect == 1)
                        Reduce = 20000;
                    else if (detect == 2)
                        Reduce = 27000;
                    else if (detect == 3)
                        Reduce = 34000;
                    ReduceSum(8, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player8.GetComponent<FollowThePath>().transform.position == waypoints[20].transform.position)
            {
                detect = count17;
                houseName.text = "黃2";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count17 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own17;
                    if (detect == 1)
                        Reduce = 20000;
                    else if (detect == 2)
                        Reduce = 27000;
                    else if (detect == 3)
                        Reduce = 34000;
                    ReduceSum(8, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player8.GetComponent<FollowThePath>().transform.position == waypoints[21].transform.position)
            {
                if (GameControl.count18 == 1)
                {
                    buy.interactable = false;
                }
                detect = count18;
                houseName.text = "公共物業2";
                cost1.text = "$30000"; cost2.text = "+ $NULL"; cost3.text = "+ $NULL";
                if (count18 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own18;
                    if (detect == 1)
                        Reduce = 30000;
                    ReduceSum(8, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player8.GetComponent<FollowThePath>().transform.position == waypoints[22].transform.position)
            {
                detect = count19;
                houseName.text = "黃3";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count19 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own19;
                    if (detect == 1)
                        Reduce = 20000;
                    else if (detect == 2)
                        Reduce = 27000;
                    else if (detect == 3)
                        Reduce = 34000;
                    ReduceSum(8, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player8.GetComponent<FollowThePath>().transform.position == waypoints[23].transform.position)
            {
                detect = count20;
                houseName.text = "黃4";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count20 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own20;
                    if (detect == 1)
                        Reduce = 20000;
                    else if (detect == 2)
                        Reduce = 27000;
                    else if (detect == 3)
                        Reduce = 34000;
                    ReduceSum(8, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player8.GetComponent<FollowThePath>().transform.position == waypoints[24].transform.position)
            {
                detect = count21;
                houseName.text = "黃5";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count21 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own21;
                    if (detect == 1)
                        Reduce = 20000;
                    else if (detect == 2)
                        Reduce = 27000;
                    else if (detect == 3)
                        Reduce = 34000;
                    ReduceSum(8, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }
            else if (player8.GetComponent<FollowThePath>().transform.position == waypoints[26].transform.position)
            {
                detect = count22;
                houseName.text = "黃6";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count22 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own22;
                    if (detect == 1)
                        Reduce = 20000;
                    else if (detect == 2)
                        Reduce = 27000;
                    else if (detect == 3)
                        Reduce = 34000;
                    ReduceSum(8, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player8.GetComponent<FollowThePath>().transform.position == waypoints[27].transform.position)
            {
                detect = count23;
                houseName.text = "黃7";
                cost1.text = "$20000"; cost2.text = "+ $7000"; cost3.text = "+ $7000";
                if (count23 == 0)
                {
                    HouseSelection.reduce = 20000;
                }
                else
                {
                    HouseSelection.reduce = 7000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own23;
                    if (detect == 1)
                        Reduce = 20000;
                    else if (detect == 2)
                        Reduce = 27000;
                    else if (detect == 3)
                        Reduce = 34000;
                    ReduceSum(8, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player8.GetComponent<FollowThePath>().transform.position == waypoints[28].transform.position)
            {
                detect = count24;
                houseName.text = "綠1";
                cost1.text = "$30000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count24 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own24;
                    if (detect == 1)
                        Reduce = 30000;
                    else if (detect == 2)
                        Reduce = 38500;
                    else if (detect == 3)
                        Reduce = 47000;
                    ReduceSum(8, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player8.GetComponent<FollowThePath>().transform.position == waypoints[29].transform.position)
            {
                detect = count25;
                houseName.text = "綠2";
                cost1.text = "$30000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count25 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own25;
                    if (detect == 1)
                        Reduce = 30000;
                    else if (detect == 2)
                        Reduce = 38500;
                    else if (detect == 3)
                        Reduce = 47000;
                    ReduceSum(8, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }
            else if (player8.GetComponent<FollowThePath>().transform.position == waypoints[30].transform.position)
            {
                if (DiceNumberTextScript.jail2 == 1 || DiceNumberTextScript.jail3 == 1 || DiceNumberTextScript.jail4 == 1 || DiceNumberTextScript.jail5 == 1 || DiceNumberTextScript.jail6 == 1
                    || DiceNumberTextScript.jail7 == 1 || DiceNumberTextScript.jail1 == 1)
                {
                    if (DiceNumberTextScript.jail2 == 1)
                    {
                        jail2turn = 3;
                        DiceNumberTextScript.jail2 = 0;
                    }
                    if (DiceNumberTextScript.jail3 == 1)
                    {
                        jail3turn = 3;
                        DiceNumberTextScript.jail3 = 0;
                    }
                    if (DiceNumberTextScript.jail4 == 1)
                    {
                        jail4turn = 3;
                        DiceNumberTextScript.jail4 = 0;
                    }
                    if (DiceNumberTextScript.jail5 == 1)
                    {
                        jail5turn = 3;
                        DiceNumberTextScript.jail5 = 0;
                    }
                    if (DiceNumberTextScript.jail6 == 1)
                    {
                        jail6turn = 3;
                        DiceNumberTextScript.jail6 = 0;
                    }
                    if (DiceNumberTextScript.jail7 == 1)
                    {
                        jail7turn = 3;
                        DiceNumberTextScript.jail7 = 0;
                    }
                    if (DiceNumberTextScript.jail1 == 1)
                    {
                        jail8turn = 3;
                        DiceNumberTextScript.jail8 = 0;
                    }

                }

                DiceNumberTextScript.jail8 = 1;
                JailTurn.text = jail8turn.ToString();
                ImageForJail.gameObject.SetActive(true);
            }

            else if (player8.GetComponent<FollowThePath>().transform.position == waypoints[31].transform.position)
            {
                detect = count26;
                houseName.text = "綠3";
                cost1.text = "$30000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count26 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own26;
                    if (detect == 1)
                        Reduce = 30000;
                    else if (detect == 2)
                        Reduce = 38500;
                    else if (detect == 3)
                        Reduce = 47000;
                    ReduceSum(8, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player8.GetComponent<FollowThePath>().transform.position == waypoints[32].transform.position)
            {
                detect = count27;
                houseName.text = "綠4";
                cost1.text = "$30000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count27 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own27;
                    if (detect == 1)
                        Reduce = 30000;
                    else if (detect == 2)
                        Reduce = 38500;
                    else if (detect == 3)
                        Reduce = 47000;
                    ReduceSum(8, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player8.GetComponent<FollowThePath>().transform.position == waypoints[33].transform.position)
            {
                detect = count28;
                houseName.text = "綠5";
                cost1.text = "$30000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count28 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own28;
                    if (detect == 1)
                        Reduce = 30000;
                    else if (detect == 2)
                        Reduce = 38500;
                    else if (detect == 3)
                        Reduce = 47000;
                    ReduceSum(8, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player8.GetComponent<FollowThePath>().transform.position == waypoints[34].transform.position)
            {
                detect = count29;
                houseName.text = "綠6";
                cost1.text = "$30000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count29 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own29;
                    if (detect == 1)
                        Reduce = 30000;
                    else if (detect == 2)
                        Reduce = 38500;
                    else if (detect == 3)
                        Reduce = 47000;
                    ReduceSum(8, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player8.GetComponent<FollowThePath>().transform.position == waypoints[36].transform.position)
            {
                detect = count30;
                houseName.text = "藍1";
                cost1.text = "$50000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count30 == 0)
                {
                    HouseSelection.reduce = 50000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own30;
                    if (detect == 1)
                        Reduce = 50000;
                    else if (detect == 2)
                        Reduce = 58500;
                    else if (detect == 3)
                        Reduce = 67000;
                    ReduceSum(8, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player8.GetComponent<FollowThePath>().transform.position == waypoints[37].transform.position)
            {
                detect = count31;
                houseName.text = "藍2";
                cost1.text = "$50000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count31 == 0)
                {
                    HouseSelection.reduce = 50000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own31;
                    if (detect == 1)
                        Reduce = 50000;
                    else if (detect == 2)
                        Reduce = 58500;
                    else if (detect == 3)
                        Reduce = 67000;
                    ReduceSum(8, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player8.GetComponent<FollowThePath>().transform.position == waypoints[38].transform.position)
            {
                if (GameControl.count32 == 1)
                {
                    buy.interactable = false;
                }
                detect = count32;
                houseName.text = "公共物業3";
                cost1.text = "$30000"; cost2.text = "+ $NULL"; cost3.text = "+ $NULL";
                if (count32 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own32;
                    if (detect == 1)
                        Reduce = 30000;
                    ReduceSum(8, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player8.GetComponent<FollowThePath>().transform.position == waypoints[39].transform.position)
            {
                detect = count33;
                houseName.text = "藍3";
                cost1.text = "$50000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count33 == 0)
                {
                    HouseSelection.reduce = 50000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own33;
                    if (detect == 1)
                        Reduce = 50000;
                    else if (detect == 2)
                        Reduce = 58500;
                    else if (detect == 3)
                        Reduce = 67000;
                    ReduceSum(8, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player8.GetComponent<FollowThePath>().transform.position == waypoints[40].transform.position)
            {
                detect = count34;
                houseName.text = "藍4";
                cost1.text = "$50000"; cost2.text = "+ $8500"; cost3.text = "+ $8500";
                if (count34 == 0)
                {
                    HouseSelection.reduce = 50000;
                }
                else
                {
                    HouseSelection.reduce = 8500;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own34;
                    if (detect == 1)
                        Reduce = 50000;
                    else if (detect == 2)
                        Reduce = 58500;
                    else if (detect == 3)
                        Reduce = 67000;
                    ReduceSum(8, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player8.GetComponent<FollowThePath>().transform.position == waypoints[42].transform.position)
            {
                detect = count35;
                houseName.text = "紫1";
                cost1.text = "$70000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count35 == 0)
                {
                    HouseSelection.reduce = 70000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own35;
                    if (detect == 1)
                        Reduce = 70000;
                    else if (detect == 2)
                        Reduce = 79000;
                    else if (detect == 3)
                        Reduce = 88000;
                    ReduceSum(8, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player8.GetComponent<FollowThePath>().transform.position == waypoints[43].transform.position)
            {
                detect = count36;
                houseName.text = "紫2";
                cost1.text = "$70000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count36 == 0)
                {
                    HouseSelection.reduce = 70000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own36;
                    if (detect == 1)
                        Reduce = 70000;
                    else if (detect == 2)
                        Reduce = 79000;
                    else if (detect == 3)
                        Reduce = 88000;
                    ReduceSum(8, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player8.GetComponent<FollowThePath>().transform.position == waypoints[44].transform.position)
            {
                detect = count37;
                houseName.text = "紫3";
                cost1.text = "$70000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count37 == 0)
                {
                    HouseSelection.reduce = 70000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own37;
                    if (detect == 1)
                        Reduce = 70000;
                    else if (detect == 2)
                        Reduce = 79000;
                    else if (detect == 3)
                        Reduce = 88000;
                    ReduceSum(8, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player8.GetComponent<FollowThePath>().transform.position == waypoints[47].transform.position)
            {
                detect = count38;
                houseName.text = "紫4";
                cost1.text = "$70000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count38 == 0)
                {
                    HouseSelection.reduce = 70000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own38;
                    if (detect == 1)
                        Reduce = 70000;
                    else if (detect == 2)
                        Reduce = 79000;
                    else if (detect == 3)
                        Reduce = 88000;
                    ReduceSum(8, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player8.GetComponent<FollowThePath>().transform.position == waypoints[48].transform.position)
            {
                detect = count39;
                houseName.text = "紫5";
                cost1.text = "$70000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count39 == 0)
                {
                    HouseSelection.reduce = 70000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own39;
                    if (detect == 1)
                        Reduce = 70000;
                    else if (detect == 2)
                        Reduce = 79000;
                    else if (detect == 3)
                        Reduce = 88000;
                    ReduceSum(8, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player8.GetComponent<FollowThePath>().transform.position == waypoints[49].transform.position)
            {
                detect = count40;
                houseName.text = "啡1";
                cost1.text = "$85000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count40 == 0)
                {
                    HouseSelection.reduce = 85000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own40;
                    if (detect == 1)
                        Reduce = 85000;
                    else if (detect == 2)
                        Reduce = 94000;
                    else if (detect == 3)
                        Reduce = 108000;
                    ReduceSum(8, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player8.GetComponent<FollowThePath>().transform.position == waypoints[50].transform.position)
            {
                detect = count41;
                houseName.text = "公共物業4";
                cost1.text = "$30000"; cost2.text = "+ $NULL"; cost3.text = "+ $NULL";
                if (count41 == 0)
                {
                    HouseSelection.reduce = 30000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own41;
                    if (detect == 1)
                        Reduce = 30000;
                    ReduceSum(8, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player8.GetComponent<FollowThePath>().transform.position == waypoints[51].transform.position)
            {
                if (GameControl.count42 == 1)
                {
                    buy.interactable = false;
                }
                detect = count42;
                houseName.text = "啡2";
                cost1.text = "$85000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count42 == 0)
                {
                    HouseSelection.reduce = 85000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own42;
                    if (detect == 1)
                        Reduce = 85000;
                    else if (detect == 2)
                        Reduce = 94000;
                    else if (detect == 3)
                        Reduce = 108000;
                    ReduceSum(8, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player8.GetComponent<FollowThePath>().transform.position == waypoints[52].transform.position)
            {
                detect = count43;
                houseName.text = "啡3";
                cost1.text = "$85000"; cost2.text = "+ $9000"; cost3.text = "+ $9000";
                if (count43 == 0)
                {
                    HouseSelection.reduce = 85000;
                }
                else
                {
                    HouseSelection.reduce = 9000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own43;
                    if (detect == 1)
                        Reduce = 85000;
                    else if (detect == 2)
                        Reduce = 94000;
                    else if (detect == 3)
                        Reduce = 108000;
                    ReduceSum(8, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player8.GetComponent<FollowThePath>().transform.position == waypoints[55].transform.position)
            {
                detect = count44;
                houseName.text = "黑1";
                cost1.text = "$100000"; cost2.text = "+ $10000"; cost3.text = "+ $10000";
                if (count44 == 0)
                {
                    HouseSelection.reduce = 100000;
                }
                else
                {
                    HouseSelection.reduce = 10000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own44;
                    if (detect == 1)
                        Reduce = 100000;
                    else if (detect == 2)
                        Reduce = 110000;
                    else if (detect == 3)
                        Reduce = 120000;
                    ReduceSum(8, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player8.GetComponent<FollowThePath>().transform.position == waypoints[56].transform.position)
            {
                detect = count45;
                houseName.text = "黑2";
                cost1.text = "$100000"; cost2.text = "+ $10000"; cost3.text = "+ $10000";
                if (count45 == 0)
                {
                    HouseSelection.reduce = 100000;
                }
                else
                {
                    HouseSelection.reduce = 10000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own45;
                    if (detect == 1)
                        Reduce = 100000;
                    else if (detect == 2)
                        Reduce = 110000;
                    else if (detect == 3)
                        Reduce = 120000;
                    ReduceSum(8, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }

            else if (player8.GetComponent<FollowThePath>().transform.position == waypoints[57].transform.position)
            {
                detect = count46;
                houseName.text = "黑3";
                cost1.text = "$100000"; cost2.text = "+ $10000"; cost3.text = "+ $10000";
                if (count46 == 0)
                {
                    HouseSelection.reduce = 100000;
                }
                else
                {
                    HouseSelection.reduce = 10000;
                }
                if (detect == 0)
                {
                    ImageForBuyHouse.gameObject.SetActive(true);
                }
                else
                {
                    own = own46;
                    if (detect == 1)
                        Reduce = 100000;
                    else if (detect == 2)
                        Reduce = 110000;
                    else if (detect == 3)
                        Reduce = 120000;
                    ReduceSum(8, Reduce, own);
                    dropButton.interactable = true;
                    camMain();
                }
            }   
            else
            {
                dropButton.interactable = true;
                camMain();
            }
        }
        

    }

    public static void MovePlayer(int playerToMove)
    {
        switch (playerToMove) { 
            case 1:
                player1.GetComponent<FollowThePath>().moveAllowed = true;
                break;
            case 2:
                player2.GetComponent<FollowThePath>().moveAllowed = true;
                break;
            case 3:
                player3.GetComponent<FollowThePath>().moveAllowed = true;
                break;
            case 4:
                player4.GetComponent<FollowThePath>().moveAllowed = true;
                break;
            case 5:
                player5.GetComponent<FollowThePath>().moveAllowed = true;
                break;
            case 6:
                player6.GetComponent<FollowThePath>().moveAllowed = true;
                break;
            case 7:
                player7.GetComponent<FollowThePath>().moveAllowed = true;
                break;
            case 8:
                player8.GetComponent<FollowThePath>().moveAllowed = true;
                break;
        }
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

	public void ReduceSum(int player, int x, int geter)
	{
        count = x / numberOfPlayer;
        switch (player) {
            case 1:
                HouseSelection.sum1 -= x;
                player1Cost.text = HouseSelection.sum1.ToString();
                switch (geter)
                {
                    case 2:
                        HouseSelection.sum2 += x;
                        player2Cost.text = HouseSelection.sum2.ToString();
                        break;
                    case 3:
                        HouseSelection.sum3 += x;
                        player3Cost.text = HouseSelection.sum3.ToString();
                        break;
                    case 4:
                        HouseSelection.sum4 += count;
                        player4Cost.text = HouseSelection.sum4.ToString();
                        break;
                    case 5:
                        HouseSelection.sum5 += count;
                        player5Cost.text = HouseSelection.sum5.ToString();
                        break;
                    case 6:
                        HouseSelection.sum6 += count;
                        player6Cost.text = HouseSelection.sum6.ToString();
                        break;
                    case 7:
                        HouseSelection.sum7 += count;
                        player7Cost.text = HouseSelection.sum7.ToString();
                        break;
                    case 8:
                        HouseSelection.sum8 += count;
                        player8Cost.text = HouseSelection.sum8.ToString();
                        break;
                }
                break;
		case 2:
                HouseSelection.sum2 -= x;
                player2Cost.text = HouseSelection.sum2.ToString();
                switch (geter)
                {
                    case 1:
                        HouseSelection.sum1 += x;
                        player1Cost.text = HouseSelection.sum1.ToString();
                        break;
                    case 3:
                        HouseSelection.sum3 += x;
                        player3Cost.text = HouseSelection.sum3.ToString();
                        break;
                    case 4:
                        HouseSelection.sum4 += count;
                        player4Cost.text = HouseSelection.sum4.ToString();
                        break;
                    case 5:
                        HouseSelection.sum5 += count;
                        player5Cost.text = HouseSelection.sum5.ToString();
                        break;
                    case 6:
                        HouseSelection.sum6 += count;
                        player6Cost.text = HouseSelection.sum6.ToString();
                        break;
                    case 7:
                        HouseSelection.sum7 += count;
                        player7Cost.text = HouseSelection.sum7.ToString();
                        break;
                    case 8:
                        HouseSelection.sum8 += count;
                        player8Cost.text = HouseSelection.sum8.ToString();
                        break;
                }
		        break;
		case 3:
                HouseSelection.sum3 -= x;
                player3Cost.text = HouseSelection.sum3.ToString();
                switch (geter)
                {
                    case 1:
                        HouseSelection.sum1 += x;
						player1Cost.text = HouseSelection.sum1.ToString();
                        break;
                    case 2:
                        HouseSelection.sum2 += x;
						player2Cost.text = HouseSelection.sum2.ToString();
                        break;
                    case 4:
                        HouseSelection.sum4 += count;
						player4Cost.text = HouseSelection.sum4.ToString();
                        break;
                    case 5:
                        HouseSelection.sum5 += count;
						player5Cost.text = HouseSelection.sum5.ToString();
                        break;
                    case 6:
                        HouseSelection.sum6 += count;
						player6Cost.text = HouseSelection.sum6.ToString();
                        break;
                    case 7:
                        HouseSelection.sum7 += count;
						player7Cost.text = HouseSelection.sum7.ToString();
                        break;
                    case 8:
                        HouseSelection.sum8 += count;
						player8Cost.text = HouseSelection.sum8.ToString();
                        break;
                }
                break;
        case 4:
                switch (geter)
                {
                    case 1:
                        HouseSelection.sum1 += x;
                        HouseSelection.sum4 -= x;
                        player1Cost.text = HouseSelection.sum1.ToString();
                        player4Cost.text = HouseSelection.sum4.ToString();
                        break;
                    case 2:
                        HouseSelection.sum1 += x;
                        HouseSelection.sum2 += x;
                        player1Cost.text = HouseSelection.sum1.ToString();
                        player2Cost.text = HouseSelection.sum2.ToString();
                        break;
                    case 3:
                        HouseSelection.sum1 += x;
                        HouseSelection.sum3 += x;
                        player1Cost.text = HouseSelection.sum1.ToString();
                        player3Cost.text = HouseSelection.sum3.ToString();
                        break;
                }
                break;

        case 5:
                switch (geter)
                {
                    case 1:
                        HouseSelection.sum1 += x;
						player1Cost.text = HouseSelection.sum1.ToString();
                        HouseSelection.sum5 -= x;
                        player5Cost.text = HouseSelection.sum5.ToString();
                        break;
                    case 2:
                        HouseSelection.sum2 += x;
						player2Cost.text = HouseSelection.sum2.ToString();
                        HouseSelection.sum5 -= x;
                        player5Cost.text = HouseSelection.sum5.ToString();
                        break;
                    case 3:
                        HouseSelection.sum3 += x;
						player3Cost.text = HouseSelection.sum3.ToString();
                        HouseSelection.sum5 -= x;
                        player5Cost.text = HouseSelection.sum5.ToString();
                        break;
                }
                break;

        case 6:
                switch (geter)
                {
                    case 1:
                        HouseSelection.sum1 += x;
						player1Cost.text = HouseSelection.sum1.ToString();
                        HouseSelection.sum6 -= x;
                        player6Cost.text = HouseSelection.sum6.ToString();
                        break;
                    case 2:
                        HouseSelection.sum2 += x;
						player2Cost.text = HouseSelection.sum2.ToString();
                        HouseSelection.sum6 -= x;
                        player6Cost.text = HouseSelection.sum6.ToString();
                        break;
                    case 3:
                        HouseSelection.sum3 += x;
						player3Cost.text = HouseSelection.sum3.ToString();
                        HouseSelection.sum6 -= x;
                        player6Cost.text = HouseSelection.sum6.ToString();
                        break;
                }
                break;

        case 7:
                switch (geter)
                {
                    case 1:
                        HouseSelection.sum1 += x;
						player1Cost.text = HouseSelection.sum1.ToString();
                        HouseSelection.sum7 -= x;
                        player7Cost.text = HouseSelection.sum7.ToString();
                        break;
                    case 2:
                        HouseSelection.sum2 += x;
						player2Cost.text = HouseSelection.sum2.ToString();
                        HouseSelection.sum7 -= x;
                        player7Cost.text = HouseSelection.sum7.ToString();
                        break;
                    case 3:
                        HouseSelection.sum3 += x;
						player3Cost.text = HouseSelection.sum3.ToString();
                        HouseSelection.sum7 -= x;
                        player7Cost.text = HouseSelection.sum7.ToString();
                        break;
                }
                break;

        case 8:
                switch (geter)
                {
                    case 1:
                        HouseSelection.sum1 += x;
						player1Cost.text = HouseSelection.sum1.ToString();
                        HouseSelection.sum8 -= x;
                        player8Cost.text = HouseSelection.sum8.ToString();
                        break;
                    case 2:
                        HouseSelection.sum2 += x;
						player2Cost.text = HouseSelection.sum2.ToString();
                        HouseSelection.sum8 -= x;
                        player8Cost.text = HouseSelection.sum8.ToString();
                        break;
                    case 3:
                        HouseSelection.sum3 += x;
						player3Cost.text = HouseSelection.sum3.ToString();
                        HouseSelection.sum8 -= x;
                        player8Cost.text = HouseSelection.sum8.ToString();
                        break;
                }
                break;

        }
	}

}
