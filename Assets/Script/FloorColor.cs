using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorColor : MonoBehaviour {

    public static GameObject
        Cube1, Cube2, Cube3, Cube4, Cube5, Cube6, Cube7, Cube8, Cube9, Cube10,
        Cube11, Cube12, Cube13, Cube14, Cube15, Cube16, Cube17, Cube18, Cube19, Cube20,
        Cube21, Cube22, Cube23, Cube24, Cube25, Cube26, Cube27, Cube28, Cube29, Cube30,
        Cube31, Cube32, Cube33, Cube34, Cube35, Cube36, Cube37, Cube38, Cube39, Cube40,
        Cube41, Cube42, Cube43, Cube44, Cube45, Cube46;

    public Color32 orange = new Color32(254, 161, 0, 1);
    public Color32 purple = new Color32(147, 112, 219, 255);
    public Color32 brown = new Color32(165, 42, 42, 255);

    void Start () {
        Cube1 = GameObject.Find("Cube1");
        Cube2 = GameObject.Find("Cube2");
        Cube3 = GameObject.Find("Cube3");
        Cube4 = GameObject.Find("Cube4");
        Cube5 = GameObject.Find("Cube5");
        Cube6 = GameObject.Find("Cube6");
        Cube7 = GameObject.Find("Cube7");
        Cube8 = GameObject.Find("Cube8");
        Cube9 = GameObject.Find("Cube9");
        Cube10 = GameObject.Find("Cube10");
        Cube11 = GameObject.Find("Cube11");
        Cube12 = GameObject.Find("Cube12");
        Cube13 = GameObject.Find("Cube13");
        Cube14 = GameObject.Find("Cube14");
        Cube15 = GameObject.Find("Cube15");
        Cube16 = GameObject.Find("Cube16");
        Cube17 = GameObject.Find("Cube17");
        Cube18 = GameObject.Find("Cube18");
        Cube19 = GameObject.Find("Cube19");
        Cube20 = GameObject.Find("Cube20");
        Cube21 = GameObject.Find("Cube21");
        Cube22 = GameObject.Find("Cube22");
        Cube23 = GameObject.Find("Cube23");
        Cube24 = GameObject.Find("Cube24");
        Cube25 = GameObject.Find("Cube25");
        Cube26 = GameObject.Find("Cube26");
        Cube27 = GameObject.Find("Cube27");
        Cube28 = GameObject.Find("Cube28");
        Cube29 = GameObject.Find("Cube29");
        Cube30 = GameObject.Find("Cube30");
        Cube31 = GameObject.Find("Cube31");
        Cube32 = GameObject.Find("Cube32");
        Cube33 = GameObject.Find("Cube33");
        Cube34 = GameObject.Find("Cube34");
        Cube35 = GameObject.Find("Cube35");
        Cube36 = GameObject.Find("Cube36");
        Cube37 = GameObject.Find("Cube37");
        Cube38 = GameObject.Find("Cube38");
        Cube39 = GameObject.Find("Cube39");
        Cube40 = GameObject.Find("Cube40");
        Cube41 = GameObject.Find("Cube41");
        Cube42 = GameObject.Find("Cube42");
        Cube43 = GameObject.Find("Cube43");
        Cube44 = GameObject.Find("Cube44");
        Cube45 = GameObject.Find("Cube45");
        Cube46 = GameObject.Find("Cube46");
    }
	
	// Update is called once per frame
	void Update () {

        if (GameControl.own1 == 1)
            Cube1.gameObject.GetComponent<Renderer>().material.color = Color.red;
        else if (GameControl.own1 == 2)
            Cube1.gameObject.GetComponent<Renderer>().material.color = orange;
        else if (GameControl.own1 == 3)
            Cube1.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        else if (GameControl.own1 == 4)
            Cube1.gameObject.GetComponent<Renderer>().material.color = Color.green;
        else if (GameControl.own1 == 5)
            Cube1.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        else if (GameControl.own1 == 6)
            Cube1.gameObject.GetComponent<Renderer>().material.color = purple;
        else if (GameControl.own1 == 7)
            Cube1.gameObject.GetComponent<Renderer>().material.color = brown;
        else if (GameControl.own1 == 8) 
            Cube1.gameObject.GetComponent<Renderer>().material.color = Color.black;
        else if (GameControl.own1 == 0)
            Cube1.gameObject.GetComponent<Renderer>().material.color = Color.white;

        if (GameControl.own2 == 1)
            Cube2.gameObject.GetComponent<Renderer>().material.color = Color.red;
        else if (GameControl.own2 == 2)
            Cube2.gameObject.GetComponent<Renderer>().material.color = orange;
        else if (GameControl.own2 == 3)
            Cube2.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        else if (GameControl.own2 == 4)
            Cube2.gameObject.GetComponent<Renderer>().material.color = Color.green;
        else if (GameControl.own2 == 5)
            Cube2.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        else if (GameControl.own2 == 6)
            Cube2.gameObject.GetComponent<Renderer>().material.color = purple;
        else if (GameControl.own2 == 7)
            Cube2.gameObject.GetComponent<Renderer>().material.color = brown;
        else if (GameControl.own2 == 8)
            Cube2.gameObject.GetComponent<Renderer>().material.color = Color.black;
        else if (GameControl.own2 == 0)
            Cube2.gameObject.GetComponent<Renderer>().material.color = Color.white;

        if (GameControl.own3 == 1)
            Cube3.gameObject.GetComponent<Renderer>().material.color = Color.red;
        else if (GameControl.own3 == 2)
            Cube3.gameObject.GetComponent<Renderer>().material.color = orange;
        else if (GameControl.own3 == 3)
            Cube3.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        else if (GameControl.own3 == 4)
            Cube3.gameObject.GetComponent<Renderer>().material.color = Color.green;
        else if (GameControl.own3 == 5)
            Cube3.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        else if (GameControl.own3 == 6)
            Cube3.gameObject.GetComponent<Renderer>().material.color = purple;
        else if (GameControl.own3 == 7)
            Cube3.gameObject.GetComponent<Renderer>().material.color = brown;
        else if (GameControl.own3 == 8)
            Cube3.gameObject.GetComponent<Renderer>().material.color = Color.black;
        else if (GameControl.own3 == 0)
            Cube3.gameObject.GetComponent<Renderer>().material.color = Color.white;

        if (GameControl.own4 == 1)
            Cube4.gameObject.GetComponent<Renderer>().material.color = Color.red;
        else if (GameControl.own4 == 2)
            Cube4.gameObject.GetComponent<Renderer>().material.color = orange;
        else if (GameControl.own4 == 3)
            Cube4.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        else if (GameControl.own4 == 4)
            Cube4.gameObject.GetComponent<Renderer>().material.color = Color.green;
        else if (GameControl.own4 == 5)
            Cube4.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        else if (GameControl.own4 == 6)
            Cube4.gameObject.GetComponent<Renderer>().material.color = purple;
        else if (GameControl.own4 == 7)
            Cube4.gameObject.GetComponent<Renderer>().material.color = brown;
        else if (GameControl.own4 == 8)
            Cube4.gameObject.GetComponent<Renderer>().material.color = Color.black;
        else if (GameControl.own4 == 0)
            Cube4.gameObject.GetComponent<Renderer>().material.color = Color.white;

        if (GameControl.own5 == 1)
            Cube5.gameObject.GetComponent<Renderer>().material.color = Color.red;
        else if (GameControl.own5 == 2)
            Cube5.gameObject.GetComponent<Renderer>().material.color = orange;
        else if (GameControl.own5 == 3)
            Cube5.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        else if (GameControl.own5 == 4)
            Cube5.gameObject.GetComponent<Renderer>().material.color = Color.green;
        else if (GameControl.own5 == 5)
            Cube5.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        else if (GameControl.own5 == 6)
            Cube5.gameObject.GetComponent<Renderer>().material.color = purple;
        else if (GameControl.own5 == 7)
            Cube5.gameObject.GetComponent<Renderer>().material.color = brown;
        else if (GameControl.own5 == 8)
            Cube5.gameObject.GetComponent<Renderer>().material.color = Color.black;
        else if (GameControl.own5 == 0)
            Cube5.gameObject.GetComponent<Renderer>().material.color = Color.white;

        if (GameControl.own6 == 1)
            Cube6.gameObject.GetComponent<Renderer>().material.color = Color.red;
        else if (GameControl.own6 == 2)
            Cube6.gameObject.GetComponent<Renderer>().material.color = orange;
        else if (GameControl.own6 == 3)
            Cube6.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        else if (GameControl.own6 == 4)
            Cube6.gameObject.GetComponent<Renderer>().material.color = Color.green;
        else if (GameControl.own6 == 5)
            Cube6.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        else if (GameControl.own6 == 6)
            Cube6.gameObject.GetComponent<Renderer>().material.color = purple;
        else if (GameControl.own6 == 7)
            Cube6.gameObject.GetComponent<Renderer>().material.color = brown;
        else if (GameControl.own6 == 8)
            Cube6.gameObject.GetComponent<Renderer>().material.color = Color.black;
        else if (GameControl.own6 == 0)
            Cube6.gameObject.GetComponent<Renderer>().material.color = Color.white;

        if (GameControl.own7 == 1)
            Cube7.gameObject.GetComponent<Renderer>().material.color = Color.red;
        else if (GameControl.own7 == 2)
            Cube7.gameObject.GetComponent<Renderer>().material.color = orange;
        else if (GameControl.own7 == 3)
            Cube7.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        else if (GameControl.own7 == 4)
            Cube7.gameObject.GetComponent<Renderer>().material.color = Color.green;
        else if (GameControl.own7 == 5)
            Cube7.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        else if (GameControl.own7 == 6)
            Cube7.gameObject.GetComponent<Renderer>().material.color = purple;
        else if (GameControl.own7 == 7)
            Cube7.gameObject.GetComponent<Renderer>().material.color = brown;
        else if (GameControl.own7 == 8)
            Cube7.gameObject.GetComponent<Renderer>().material.color = Color.black;
        else if (GameControl.own7 == 0)
            Cube7.gameObject.GetComponent<Renderer>().material.color = Color.white;

        if (GameControl.own8 == 1)
            Cube8.gameObject.GetComponent<Renderer>().material.color = Color.red;
        else if (GameControl.own8 == 2)
            Cube8.gameObject.GetComponent<Renderer>().material.color = orange;
        else if (GameControl.own8 == 3)
            Cube8.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        else if (GameControl.own8 == 4)
            Cube8.gameObject.GetComponent<Renderer>().material.color = Color.green;
        else if (GameControl.own8 == 5)
            Cube8.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        else if (GameControl.own8 == 6)
            Cube8.gameObject.GetComponent<Renderer>().material.color = purple;
        else if (GameControl.own8 == 7)
            Cube8.gameObject.GetComponent<Renderer>().material.color = brown;
        else if (GameControl.own8 == 8)
            Cube8.gameObject.GetComponent<Renderer>().material.color = Color.black;
        else if (GameControl.own8 == 0)
            Cube8.gameObject.GetComponent<Renderer>().material.color = Color.white;

        if (GameControl.own9 == 1)
            Cube9.gameObject.GetComponent<Renderer>().material.color = Color.red;
        else if (GameControl.own9 == 2)
            Cube9.gameObject.GetComponent<Renderer>().material.color = orange;
        else if (GameControl.own9 == 3)
            Cube9.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        else if (GameControl.own9 == 4)
            Cube9.gameObject.GetComponent<Renderer>().material.color = Color.green;
        else if (GameControl.own9 == 5)
            Cube9.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        else if (GameControl.own9 == 6)
            Cube9.gameObject.GetComponent<Renderer>().material.color = purple;
        else if (GameControl.own9 == 7)
            Cube9.gameObject.GetComponent<Renderer>().material.color = brown;
        else if (GameControl.own9 == 8)
            Cube9.gameObject.GetComponent<Renderer>().material.color = Color.black;
        else if (GameControl.own9 == 0)
            Cube9.gameObject.GetComponent<Renderer>().material.color = Color.white;

        if (GameControl.own10 == 1)
            Cube10.gameObject.GetComponent<Renderer>().material.color = Color.red;
        else if (GameControl.own10 == 2)
            Cube10.gameObject.GetComponent<Renderer>().material.color = orange;
        else if (GameControl.own10 == 3)
            Cube10.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        else if (GameControl.own10 == 4)
            Cube10.gameObject.GetComponent<Renderer>().material.color = Color.green;
        else if (GameControl.own10 == 5)
            Cube10.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        else if (GameControl.own10 == 6)
            Cube10.gameObject.GetComponent<Renderer>().material.color = purple;
        else if (GameControl.own10 == 7)
            Cube10.gameObject.GetComponent<Renderer>().material.color = brown;
        else if (GameControl.own10 == 8)
            Cube10.gameObject.GetComponent<Renderer>().material.color = Color.black;
        else if (GameControl.own10 == 0)
            Cube10.gameObject.GetComponent<Renderer>().material.color = Color.white;

        if (GameControl.own11 == 1)
            Cube11.gameObject.GetComponent<Renderer>().material.color = Color.red;
        else if (GameControl.own11 == 2)
            Cube11.gameObject.GetComponent<Renderer>().material.color = orange;
        else if (GameControl.own11 == 3)
            Cube11.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        else if (GameControl.own11 == 4)
            Cube11.gameObject.GetComponent<Renderer>().material.color = Color.green;
        else if (GameControl.own11 == 5)
            Cube11.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        else if (GameControl.own11 == 6)
            Cube11.gameObject.GetComponent<Renderer>().material.color = purple;
        else if (GameControl.own11 == 7)
            Cube11.gameObject.GetComponent<Renderer>().material.color = brown;
        else if (GameControl.own11 == 8)
            Cube11.gameObject.GetComponent<Renderer>().material.color = Color.black;
        else if (GameControl.own11 == 0)
            Cube11.gameObject.GetComponent<Renderer>().material.color = Color.white;

        if (GameControl.own12 == 1)
            Cube12.gameObject.GetComponent<Renderer>().material.color = Color.red;
        else if (GameControl.own12 == 2)
            Cube12.gameObject.GetComponent<Renderer>().material.color = orange;
        else if (GameControl.own12 == 3)
            Cube12.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        else if (GameControl.own12 == 4)
            Cube12.gameObject.GetComponent<Renderer>().material.color = Color.green;
        else if (GameControl.own12 == 5)
            Cube12.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        else if (GameControl.own12 == 6)
            Cube12.gameObject.GetComponent<Renderer>().material.color = purple;
        else if (GameControl.own12 == 7)
            Cube12.gameObject.GetComponent<Renderer>().material.color = brown;
        else if (GameControl.own12 == 8)
            Cube12.gameObject.GetComponent<Renderer>().material.color = Color.black;
        else if (GameControl.own12 == 0)
            Cube12.gameObject.GetComponent<Renderer>().material.color = Color.white;

        if (GameControl.own13 == 1)
            Cube13.gameObject.GetComponent<Renderer>().material.color = Color.red;
        else if (GameControl.own13 == 2)
            Cube13.gameObject.GetComponent<Renderer>().material.color = orange;
        else if (GameControl.own13 == 3)
            Cube13.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        else if (GameControl.own13 == 4)
            Cube13.gameObject.GetComponent<Renderer>().material.color = Color.green;
        else if (GameControl.own13 == 5)
            Cube13.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        else if (GameControl.own13 == 6)
            Cube13.gameObject.GetComponent<Renderer>().material.color = purple;
        else if (GameControl.own13 == 7)
            Cube13.gameObject.GetComponent<Renderer>().material.color = brown;
        else if (GameControl.own13 == 8)
            Cube13.gameObject.GetComponent<Renderer>().material.color = Color.black;
        else if (GameControl.own13 == 0)
            Cube13.gameObject.GetComponent<Renderer>().material.color = Color.white;

        if (GameControl.own14 == 1)
            Cube14.gameObject.GetComponent<Renderer>().material.color = Color.red;
        else if (GameControl.own14 == 2)
            Cube14.gameObject.GetComponent<Renderer>().material.color = orange;
        else if (GameControl.own14 == 3)
            Cube14.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        else if (GameControl.own14 == 4)
            Cube14.gameObject.GetComponent<Renderer>().material.color = Color.green;
        else if (GameControl.own14 == 5)
            Cube14.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        else if (GameControl.own14 == 6)
            Cube14.gameObject.GetComponent<Renderer>().material.color = purple;
        else if (GameControl.own14 == 7)
            Cube14.gameObject.GetComponent<Renderer>().material.color = brown;
        else if (GameControl.own14 == 8)
            Cube14.gameObject.GetComponent<Renderer>().material.color = Color.black;
        else if (GameControl.own14 == 0)
            Cube14.gameObject.GetComponent<Renderer>().material.color = Color.white;

        if (GameControl.own15 == 1)
            Cube15.gameObject.GetComponent<Renderer>().material.color = Color.red;
        else if (GameControl.own15 == 2)
            Cube15.gameObject.GetComponent<Renderer>().material.color = orange;
        else if (GameControl.own15 == 3)
            Cube15.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        else if (GameControl.own15 == 4)
            Cube15.gameObject.GetComponent<Renderer>().material.color = Color.green;
        else if (GameControl.own15 == 5)
            Cube15.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        else if (GameControl.own15 == 6)
            Cube15.gameObject.GetComponent<Renderer>().material.color = purple;
        else if (GameControl.own15 == 7)
            Cube15.gameObject.GetComponent<Renderer>().material.color = brown;
        else if (GameControl.own15 == 8)
            Cube15.gameObject.GetComponent<Renderer>().material.color = Color.black;
        else if (GameControl.own15 == 0)
            Cube15.gameObject.GetComponent<Renderer>().material.color = Color.white;

        if (GameControl.own16 == 1)
            Cube16.gameObject.GetComponent<Renderer>().material.color = Color.red;
        else if (GameControl.own16 == 2)
            Cube16.gameObject.GetComponent<Renderer>().material.color = orange;
        else if (GameControl.own16 == 3)
            Cube16.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        else if (GameControl.own16 == 4)
            Cube16.gameObject.GetComponent<Renderer>().material.color = Color.green;
        else if (GameControl.own16 == 5)
            Cube16.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        else if (GameControl.own16 == 6)
            Cube16.gameObject.GetComponent<Renderer>().material.color = purple;
        else if (GameControl.own16 == 7)
            Cube16.gameObject.GetComponent<Renderer>().material.color = brown;
        else if (GameControl.own16 == 8)
            Cube16.gameObject.GetComponent<Renderer>().material.color = Color.black;
        else if (GameControl.own16 == 0)
            Cube16.gameObject.GetComponent<Renderer>().material.color = Color.white;

        if (GameControl.own17 == 1)
            Cube17.gameObject.GetComponent<Renderer>().material.color = Color.red;
        else if (GameControl.own17 == 2)
            Cube17.gameObject.GetComponent<Renderer>().material.color = orange;
        else if (GameControl.own17 == 3)
            Cube17.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        else if (GameControl.own17 == 4)
            Cube17.gameObject.GetComponent<Renderer>().material.color = Color.green;
        else if (GameControl.own17 == 5)
            Cube17.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        else if (GameControl.own17 == 6)
            Cube17.gameObject.GetComponent<Renderer>().material.color = purple;
        else if (GameControl.own17 == 7)
            Cube17.gameObject.GetComponent<Renderer>().material.color = brown;
        else if (GameControl.own17 == 8)
            Cube17.gameObject.GetComponent<Renderer>().material.color = Color.black;
        else if (GameControl.own17 == 0)
            Cube17.gameObject.GetComponent<Renderer>().material.color = Color.white;

        if (GameControl.own18 == 1)
            Cube18.gameObject.GetComponent<Renderer>().material.color = Color.red;
        else if (GameControl.own18 == 2)
            Cube18.gameObject.GetComponent<Renderer>().material.color = orange;
        else if (GameControl.own18 == 3)
            Cube18.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        else if (GameControl.own18 == 4)
            Cube18.gameObject.GetComponent<Renderer>().material.color = Color.green;
        else if (GameControl.own18 == 5)
            Cube18.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        else if (GameControl.own18 == 6)
            Cube18.gameObject.GetComponent<Renderer>().material.color = purple;
        else if (GameControl.own18 == 7)
            Cube18.gameObject.GetComponent<Renderer>().material.color = brown;
        else if (GameControl.own18 == 8)
            Cube18.gameObject.GetComponent<Renderer>().material.color = Color.black;
        else if (GameControl.own18 == 0)
            Cube18.gameObject.GetComponent<Renderer>().material.color = Color.white;

        if (GameControl.own19 == 1)
            Cube19.gameObject.GetComponent<Renderer>().material.color = Color.red;
        else if (GameControl.own19 == 2)
            Cube19.gameObject.GetComponent<Renderer>().material.color = orange;
        else if (GameControl.own19 == 3)
            Cube19.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        else if (GameControl.own19 == 4)
            Cube19.gameObject.GetComponent<Renderer>().material.color = Color.green;
        else if (GameControl.own19 == 5)
            Cube19.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        else if (GameControl.own19 == 6)
            Cube19.gameObject.GetComponent<Renderer>().material.color = purple;
        else if (GameControl.own19 == 7)
            Cube19.gameObject.GetComponent<Renderer>().material.color = brown;
        else if (GameControl.own19 == 8)
            Cube19.gameObject.GetComponent<Renderer>().material.color = Color.black;
        else if (GameControl.own19 == 0)
            Cube19.gameObject.GetComponent<Renderer>().material.color = Color.white;

        if (GameControl.own20 == 1)
            Cube20.gameObject.GetComponent<Renderer>().material.color = Color.red;
        else if (GameControl.own20 == 2)
            Cube20.gameObject.GetComponent<Renderer>().material.color = orange;
        else if (GameControl.own20 == 3)
            Cube20.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        else if (GameControl.own20 == 4)
            Cube20.gameObject.GetComponent<Renderer>().material.color = Color.green;
        else if (GameControl.own20 == 5)
            Cube20.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        else if (GameControl.own20 == 6)
            Cube20.gameObject.GetComponent<Renderer>().material.color = purple;
        else if (GameControl.own20 == 7)
            Cube20.gameObject.GetComponent<Renderer>().material.color = brown;
        else if (GameControl.own20 == 8)
            Cube20.gameObject.GetComponent<Renderer>().material.color = Color.black;
        else if (GameControl.own20 == 0)
            Cube20.gameObject.GetComponent<Renderer>().material.color = Color.white;

        if (GameControl.own21 == 1)
            Cube21.gameObject.GetComponent<Renderer>().material.color = Color.red;
        else if (GameControl.own21 == 2)
            Cube21.gameObject.GetComponent<Renderer>().material.color = orange;
        else if (GameControl.own21 == 3)
            Cube21.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        else if (GameControl.own21 == 4)
            Cube21.gameObject.GetComponent<Renderer>().material.color = Color.green;
        else if (GameControl.own21 == 5)
            Cube21.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        else if (GameControl.own21 == 6)
            Cube21.gameObject.GetComponent<Renderer>().material.color = purple;
        else if (GameControl.own21 == 7)
            Cube21.gameObject.GetComponent<Renderer>().material.color = brown;
        else if (GameControl.own21 == 8)
            Cube21.gameObject.GetComponent<Renderer>().material.color = Color.black;
        else if (GameControl.own21 == 0)
            Cube21.gameObject.GetComponent<Renderer>().material.color = Color.white;

        if (GameControl.own22 == 1)
            Cube22.gameObject.GetComponent<Renderer>().material.color = Color.red;
        else if (GameControl.own22 == 2)
            Cube22.gameObject.GetComponent<Renderer>().material.color = orange;
        else if (GameControl.own22 == 3)
            Cube22.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        else if (GameControl.own22 == 4)
            Cube22.gameObject.GetComponent<Renderer>().material.color = Color.green;
        else if (GameControl.own22 == 5)
            Cube22.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        else if (GameControl.own22 == 6)
            Cube22.gameObject.GetComponent<Renderer>().material.color = purple;
        else if (GameControl.own22 == 7)
            Cube22.gameObject.GetComponent<Renderer>().material.color = brown;
        else if (GameControl.own22 == 8)
            Cube22.gameObject.GetComponent<Renderer>().material.color = Color.black;
        else if (GameControl.own22 == 0)
            Cube22.gameObject.GetComponent<Renderer>().material.color = Color.white;

        if (GameControl.own23 == 1)
            Cube23.gameObject.GetComponent<Renderer>().material.color = Color.red;
        else if (GameControl.own23 == 2)
            Cube23.gameObject.GetComponent<Renderer>().material.color = orange;
        else if (GameControl.own23 == 3)
            Cube23.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        else if (GameControl.own23 == 4)
            Cube23.gameObject.GetComponent<Renderer>().material.color = Color.green;
        else if (GameControl.own23 == 5)
            Cube23.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        else if (GameControl.own23 == 6)
            Cube23.gameObject.GetComponent<Renderer>().material.color = purple;
        else if (GameControl.own23 == 7)
            Cube23.gameObject.GetComponent<Renderer>().material.color = brown;
        else if (GameControl.own23 == 8)
            Cube23.gameObject.GetComponent<Renderer>().material.color = Color.black;
        else if (GameControl.own23 == 0)
            Cube23.gameObject.GetComponent<Renderer>().material.color = Color.white;

        if (GameControl.own24 == 1)
            Cube24.gameObject.GetComponent<Renderer>().material.color = Color.red;
        else if (GameControl.own24 == 2)
            Cube24.gameObject.GetComponent<Renderer>().material.color = orange;
        else if (GameControl.own24 == 3)
            Cube24.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        else if (GameControl.own24 == 4)
            Cube24.gameObject.GetComponent<Renderer>().material.color = Color.green;
        else if (GameControl.own24 == 5)
            Cube24.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        else if (GameControl.own24 == 6)
            Cube24.gameObject.GetComponent<Renderer>().material.color = purple;
        else if (GameControl.own24 == 7)
            Cube24.gameObject.GetComponent<Renderer>().material.color = brown;
        else if (GameControl.own24 == 8)
            Cube24.gameObject.GetComponent<Renderer>().material.color = Color.black;
        else if (GameControl.own24 == 0)
            Cube24.gameObject.GetComponent<Renderer>().material.color = Color.white;

        if (GameControl.own25 == 1)
            Cube25.gameObject.GetComponent<Renderer>().material.color = Color.red;
        else if (GameControl.own25 == 2)
            Cube25.gameObject.GetComponent<Renderer>().material.color = orange;
        else if (GameControl.own25 == 3)
            Cube25.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        else if (GameControl.own25 == 4)
            Cube25.gameObject.GetComponent<Renderer>().material.color = Color.green;
        else if (GameControl.own25 == 5)
            Cube25.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        else if (GameControl.own25 == 6)
            Cube25.gameObject.GetComponent<Renderer>().material.color = purple;
        else if (GameControl.own25 == 7)
            Cube25.gameObject.GetComponent<Renderer>().material.color = brown;
        else if (GameControl.own25 == 8)
            Cube25.gameObject.GetComponent<Renderer>().material.color = Color.black;
        else if (GameControl.own25 == 0)
            Cube25.gameObject.GetComponent<Renderer>().material.color = Color.white;

        if (GameControl.own26 == 1)
            Cube26.gameObject.GetComponent<Renderer>().material.color = Color.red;
        else if (GameControl.own26 == 2)
            Cube26.gameObject.GetComponent<Renderer>().material.color = orange;
        else if (GameControl.own26 == 3)
            Cube26.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        else if (GameControl.own26 == 4)
            Cube26.gameObject.GetComponent<Renderer>().material.color = Color.green;
        else if (GameControl.own26 == 5)
            Cube26.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        else if (GameControl.own26 == 6)
            Cube26.gameObject.GetComponent<Renderer>().material.color = purple;
        else if (GameControl.own26 == 7)
            Cube26.gameObject.GetComponent<Renderer>().material.color = brown;
        else if (GameControl.own26 == 8)
            Cube26.gameObject.GetComponent<Renderer>().material.color = Color.black;
        else if (GameControl.own26 == 0)
            Cube26.gameObject.GetComponent<Renderer>().material.color = Color.white;

        if (GameControl.own27 == 1)
            Cube27.gameObject.GetComponent<Renderer>().material.color = Color.red;
        else if (GameControl.own27 == 2)
            Cube27.gameObject.GetComponent<Renderer>().material.color = orange;
        else if (GameControl.own27 == 3)
            Cube27.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        else if (GameControl.own27 == 4)
            Cube27.gameObject.GetComponent<Renderer>().material.color = Color.green;
        else if (GameControl.own27 == 5)
            Cube27.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        else if (GameControl.own27 == 6)
            Cube27.gameObject.GetComponent<Renderer>().material.color = purple;
        else if (GameControl.own27 == 7)
            Cube27.gameObject.GetComponent<Renderer>().material.color = brown;
        else if (GameControl.own27 == 8)
            Cube27.gameObject.GetComponent<Renderer>().material.color = Color.black;
        else if (GameControl.own27 == 0)
            Cube27.gameObject.GetComponent<Renderer>().material.color = Color.white;

        if (GameControl.own28 == 1)
            Cube28.gameObject.GetComponent<Renderer>().material.color = Color.red;
        else if (GameControl.own28 == 2)
            Cube28.gameObject.GetComponent<Renderer>().material.color = orange;
        else if (GameControl.own28 == 3)
            Cube28.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        else if (GameControl.own28 == 4)
            Cube28.gameObject.GetComponent<Renderer>().material.color = Color.green;
        else if (GameControl.own28 == 5)
            Cube28.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        else if (GameControl.own28 == 6)
            Cube28.gameObject.GetComponent<Renderer>().material.color = purple;
        else if (GameControl.own28 == 7)
            Cube28.gameObject.GetComponent<Renderer>().material.color = brown;
        else if (GameControl.own28 == 8)
            Cube28.gameObject.GetComponent<Renderer>().material.color = Color.black;
        else if (GameControl.own28 == 0)
            Cube28.gameObject.GetComponent<Renderer>().material.color = Color.white;

        if (GameControl.own29 == 1)
            Cube29.gameObject.GetComponent<Renderer>().material.color = Color.red;
        else if (GameControl.own29 == 2)
            Cube29.gameObject.GetComponent<Renderer>().material.color = orange;
        else if (GameControl.own29 == 3)
            Cube29.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        else if (GameControl.own29 == 4)
            Cube29.gameObject.GetComponent<Renderer>().material.color = Color.green;
        else if (GameControl.own29 == 5)
            Cube29.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        else if (GameControl.own29 == 6)
            Cube29.gameObject.GetComponent<Renderer>().material.color = purple;
        else if (GameControl.own29 == 7)
            Cube29.gameObject.GetComponent<Renderer>().material.color = brown;
        else if (GameControl.own29 == 8)
            Cube29.gameObject.GetComponent<Renderer>().material.color = Color.black;
        else if (GameControl.own29 == 0)
            Cube29.gameObject.GetComponent<Renderer>().material.color = Color.white;

        if (GameControl.own30 == 1)
            Cube30.gameObject.GetComponent<Renderer>().material.color = Color.red;
        else if (GameControl.own30 == 2)
            Cube30.gameObject.GetComponent<Renderer>().material.color = orange;
        else if (GameControl.own30 == 3)
            Cube30.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        else if (GameControl.own30 == 4)
            Cube30.gameObject.GetComponent<Renderer>().material.color = Color.green;
        else if (GameControl.own30 == 5)
            Cube30.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        else if (GameControl.own30 == 6)
            Cube30.gameObject.GetComponent<Renderer>().material.color = purple;
        else if (GameControl.own30 == 7)
            Cube30.gameObject.GetComponent<Renderer>().material.color = brown;
        else if (GameControl.own30 == 8)
            Cube30.gameObject.GetComponent<Renderer>().material.color = Color.black;
        else if (GameControl.own30 == 0)
            Cube30.gameObject.GetComponent<Renderer>().material.color = Color.white;

        if (GameControl.own31 == 1)
            Cube31.gameObject.GetComponent<Renderer>().material.color = Color.red;
        else if (GameControl.own31 == 2)
            Cube31.gameObject.GetComponent<Renderer>().material.color = orange;
        else if (GameControl.own31 == 3)
            Cube31.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        else if (GameControl.own31 == 4)
            Cube31.gameObject.GetComponent<Renderer>().material.color = Color.green;
        else if (GameControl.own31 == 5)
            Cube31.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        else if (GameControl.own31 == 6)
            Cube31.gameObject.GetComponent<Renderer>().material.color = purple;
        else if (GameControl.own31 == 7)
            Cube31.gameObject.GetComponent<Renderer>().material.color = brown;
        else if (GameControl.own31 == 8)
            Cube31.gameObject.GetComponent<Renderer>().material.color = Color.black;
        else if (GameControl.own31 == 0)
            Cube31.gameObject.GetComponent<Renderer>().material.color = Color.white;

        if (GameControl.own32 == 1)
            Cube32.gameObject.GetComponent<Renderer>().material.color = Color.red;
        else if (GameControl.own32 == 2)
            Cube32.gameObject.GetComponent<Renderer>().material.color = orange;
        else if (GameControl.own32 == 3)
            Cube32.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        else if (GameControl.own32 == 4)
            Cube32.gameObject.GetComponent<Renderer>().material.color = Color.green;
        else if (GameControl.own32 == 5)
            Cube32.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        else if (GameControl.own32 == 6)
            Cube32.gameObject.GetComponent<Renderer>().material.color = purple;
        else if (GameControl.own32 == 7)
            Cube32.gameObject.GetComponent<Renderer>().material.color = brown;
        else if (GameControl.own32 == 8)
            Cube32.gameObject.GetComponent<Renderer>().material.color = Color.black;
        else if (GameControl.own32 == 0)
            Cube32.gameObject.GetComponent<Renderer>().material.color = Color.white;

        if (GameControl.own33 == 1)
            Cube33.gameObject.GetComponent<Renderer>().material.color = Color.red;
        else if (GameControl.own33 == 2)
            Cube33.gameObject.GetComponent<Renderer>().material.color = orange;
        else if (GameControl.own33 == 3)
            Cube33.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        else if (GameControl.own33 == 4)
            Cube33.gameObject.GetComponent<Renderer>().material.color = Color.green;
        else if (GameControl.own33 == 5)
            Cube33.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        else if (GameControl.own33 == 6)
            Cube33.gameObject.GetComponent<Renderer>().material.color = purple;
        else if (GameControl.own33 == 7)
            Cube33.gameObject.GetComponent<Renderer>().material.color = brown;
        else if (GameControl.own33 == 8)
            Cube33.gameObject.GetComponent<Renderer>().material.color = Color.black;
        else if (GameControl.own33 == 0)
            Cube33.gameObject.GetComponent<Renderer>().material.color = Color.white;

        if (GameControl.own34 == 1)
            Cube34.gameObject.GetComponent<Renderer>().material.color = Color.red;
        else if (GameControl.own34 == 2)
            Cube34.gameObject.GetComponent<Renderer>().material.color = orange;
        else if (GameControl.own34 == 3)
            Cube34.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        else if (GameControl.own34 == 4)
            Cube34.gameObject.GetComponent<Renderer>().material.color = Color.green;
        else if (GameControl.own34 == 5)
            Cube34.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        else if (GameControl.own34 == 6)
            Cube34.gameObject.GetComponent<Renderer>().material.color = purple;
        else if (GameControl.own34 == 7)
            Cube34.gameObject.GetComponent<Renderer>().material.color = brown;
        else if (GameControl.own34 == 8)
            Cube34.gameObject.GetComponent<Renderer>().material.color = Color.black;
        else if (GameControl.own34 == 0)
            Cube34.gameObject.GetComponent<Renderer>().material.color = Color.white;

        if (GameControl.own35 == 1)
            Cube35.gameObject.GetComponent<Renderer>().material.color = Color.red;
        else if (GameControl.own35 == 2)
            Cube35.gameObject.GetComponent<Renderer>().material.color = orange;
        else if (GameControl.own35 == 3)
            Cube35.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        else if (GameControl.own35 == 4)
            Cube35.gameObject.GetComponent<Renderer>().material.color = Color.green;
        else if (GameControl.own35 == 5)
            Cube35.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        else if (GameControl.own35 == 6)
            Cube35.gameObject.GetComponent<Renderer>().material.color = purple;
        else if (GameControl.own35 == 7)
            Cube35.gameObject.GetComponent<Renderer>().material.color = brown;
        else if (GameControl.own35 == 8)
            Cube35.gameObject.GetComponent<Renderer>().material.color = Color.black;
        else if (GameControl.own35 == 0)
            Cube35.gameObject.GetComponent<Renderer>().material.color = Color.white;

        if (GameControl.own36 == 1)
            Cube36.gameObject.GetComponent<Renderer>().material.color = Color.red;
        else if (GameControl.own36 == 2)
            Cube36.gameObject.GetComponent<Renderer>().material.color = orange;
        else if (GameControl.own36 == 3)
            Cube36.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        else if (GameControl.own36 == 4)
            Cube36.gameObject.GetComponent<Renderer>().material.color = Color.green;
        else if (GameControl.own36 == 5)
            Cube36.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        else if (GameControl.own36 == 6)
            Cube36.gameObject.GetComponent<Renderer>().material.color = purple;
        else if (GameControl.own36 == 7)
            Cube36.gameObject.GetComponent<Renderer>().material.color = brown;
        else if (GameControl.own36 == 8)
            Cube36.gameObject.GetComponent<Renderer>().material.color = Color.black;
        else if (GameControl.own36 == 0)
            Cube36.gameObject.GetComponent<Renderer>().material.color = Color.white;

        if (GameControl.own37 == 1)
            Cube37.gameObject.GetComponent<Renderer>().material.color = Color.red;
        else if (GameControl.own37 == 2)
            Cube37.gameObject.GetComponent<Renderer>().material.color = orange;
        else if (GameControl.own37 == 3)
            Cube37.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        else if (GameControl.own37 == 4)
            Cube37.gameObject.GetComponent<Renderer>().material.color = Color.green;
        else if (GameControl.own37 == 5)
            Cube37.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        else if (GameControl.own37== 6)
            Cube37.gameObject.GetComponent<Renderer>().material.color = purple;
        else if (GameControl.own37 == 7)
            Cube37.gameObject.GetComponent<Renderer>().material.color = brown;
        else if (GameControl.own37 == 8)
            Cube37.gameObject.GetComponent<Renderer>().material.color = Color.black;
        else if (GameControl.own37 == 0)
            Cube37.gameObject.GetComponent<Renderer>().material.color = Color.white;

        if (GameControl.own38 == 1)
            Cube38.gameObject.GetComponent<Renderer>().material.color = Color.red;
        else if (GameControl.own38 == 2)
            Cube38.gameObject.GetComponent<Renderer>().material.color = orange;
        else if (GameControl.own38 == 3)
            Cube38.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        else if (GameControl.own38 == 4)
            Cube38.gameObject.GetComponent<Renderer>().material.color = Color.green;
        else if (GameControl.own38 == 5)
            Cube38.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        else if (GameControl.own38 == 6)
            Cube38.gameObject.GetComponent<Renderer>().material.color = purple;
        else if (GameControl.own38 == 7)
            Cube38.gameObject.GetComponent<Renderer>().material.color = brown;
        else if (GameControl.own38 == 8)
            Cube38.gameObject.GetComponent<Renderer>().material.color = Color.black;
        else if (GameControl.own38 == 0)
            Cube38.gameObject.GetComponent<Renderer>().material.color = Color.white;

        if (GameControl.own39 == 1)
            Cube39.gameObject.GetComponent<Renderer>().material.color = Color.red;
        else if (GameControl.own39 == 2)
            Cube39.gameObject.GetComponent<Renderer>().material.color = orange;
        else if (GameControl.own39 == 3)
            Cube39.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        else if (GameControl.own39 == 4)
            Cube39.gameObject.GetComponent<Renderer>().material.color = Color.green;
        else if (GameControl.own39 == 5)
            Cube39.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        else if (GameControl.own39 == 6)
            Cube39.gameObject.GetComponent<Renderer>().material.color = purple;
        else if (GameControl.own39 == 7)
            Cube39.gameObject.GetComponent<Renderer>().material.color = brown;
        else if (GameControl.own39 == 8)
            Cube39.gameObject.GetComponent<Renderer>().material.color = Color.black;
        else if (GameControl.own39 == 0)
            Cube39.gameObject.GetComponent<Renderer>().material.color = Color.white;

        if (GameControl.own40 == 1)
            Cube40.gameObject.GetComponent<Renderer>().material.color = Color.red;
        else if (GameControl.own40 == 2)
            Cube40.gameObject.GetComponent<Renderer>().material.color = orange;
        else if (GameControl.own40 == 3)
            Cube40.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        else if (GameControl.own40 == 4)
            Cube40.gameObject.GetComponent<Renderer>().material.color = Color.green;
        else if (GameControl.own40 == 5)
            Cube40.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        else if (GameControl.own40 == 6)
            Cube40.gameObject.GetComponent<Renderer>().material.color = purple;
        else if (GameControl.own40 == 7)
            Cube40.gameObject.GetComponent<Renderer>().material.color = brown;
        else if (GameControl.own40 == 8)
            Cube40.gameObject.GetComponent<Renderer>().material.color = Color.black;
        else if (GameControl.own40 == 0)
            Cube40.gameObject.GetComponent<Renderer>().material.color = Color.white;

        if (GameControl.own41 == 1)
            Cube41.gameObject.GetComponent<Renderer>().material.color = Color.red;
        else if (GameControl.own41 == 2)
            Cube41.gameObject.GetComponent<Renderer>().material.color = orange;
        else if (GameControl.own41 == 3)
            Cube41.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        else if (GameControl.own41 == 4)
            Cube41.gameObject.GetComponent<Renderer>().material.color = Color.green;
        else if (GameControl.own41 == 5)
            Cube41.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        else if (GameControl.own41 == 6)
            Cube41.gameObject.GetComponent<Renderer>().material.color = purple;
        else if (GameControl.own41 == 7)
            Cube41.gameObject.GetComponent<Renderer>().material.color = brown;
        else if (GameControl.own41 == 8)
            Cube41.gameObject.GetComponent<Renderer>().material.color = Color.black;
        else if (GameControl.own41 == 0)
            Cube41.gameObject.GetComponent<Renderer>().material.color = Color.white;

        if (GameControl.own42 == 1)
            Cube42.gameObject.GetComponent<Renderer>().material.color = Color.red;
        else if (GameControl.own42 == 2)
            Cube42.gameObject.GetComponent<Renderer>().material.color = orange;
        else if (GameControl.own42 == 3)
            Cube42.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        else if (GameControl.own42 == 4)
            Cube42.gameObject.GetComponent<Renderer>().material.color = Color.green;
        else if (GameControl.own42 == 5)
            Cube42.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        else if (GameControl.own42 == 6)
            Cube42.gameObject.GetComponent<Renderer>().material.color = purple;
        else if (GameControl.own42 == 7)
            Cube42.gameObject.GetComponent<Renderer>().material.color = brown;
        else if (GameControl.own42 == 8)
            Cube42.gameObject.GetComponent<Renderer>().material.color = Color.black;
        else if (GameControl.own42 == 0)
            Cube42.gameObject.GetComponent<Renderer>().material.color = Color.white;

        if (GameControl.own43 == 1)
            Cube43.gameObject.GetComponent<Renderer>().material.color = Color.red;
        else if (GameControl.own43 == 2)
            Cube43.gameObject.GetComponent<Renderer>().material.color = orange;
        else if (GameControl.own43 == 3)
            Cube43.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        else if (GameControl.own43 == 4)
            Cube43.gameObject.GetComponent<Renderer>().material.color = Color.green;
        else if (GameControl.own43 == 5)
            Cube43.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        else if (GameControl.own43 == 6)
            Cube43.gameObject.GetComponent<Renderer>().material.color = purple;
        else if (GameControl.own43 == 7)
            Cube43.gameObject.GetComponent<Renderer>().material.color = brown;
        else if (GameControl.own43 == 8)
            Cube43.gameObject.GetComponent<Renderer>().material.color = Color.black;
        else if (GameControl.own43 == 0)
            Cube43.gameObject.GetComponent<Renderer>().material.color = Color.white;

        if (GameControl.own44 == 1)
            Cube44.gameObject.GetComponent<Renderer>().material.color = Color.red;
        else if (GameControl.own44 == 2)
            Cube44.gameObject.GetComponent<Renderer>().material.color = orange;
        else if (GameControl.own44 == 3)
            Cube44.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        else if (GameControl.own44 == 4)
            Cube44.gameObject.GetComponent<Renderer>().material.color = Color.green;
        else if (GameControl.own44 == 5)
            Cube44.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        else if (GameControl.own44 == 6)
            Cube44.gameObject.GetComponent<Renderer>().material.color = purple;
        else if (GameControl.own44 == 7)
            Cube44.gameObject.GetComponent<Renderer>().material.color = brown;
        else if (GameControl.own44 == 8)
            Cube44.gameObject.GetComponent<Renderer>().material.color = Color.black;
        else if (GameControl.own44 == 0)
            Cube44.gameObject.GetComponent<Renderer>().material.color = Color.white;

        if (GameControl.own45 == 1)
            Cube45.gameObject.GetComponent<Renderer>().material.color = Color.red;
        else if (GameControl.own45 == 2)
            Cube45.gameObject.GetComponent<Renderer>().material.color = orange;
        else if (GameControl.own45 == 3)
            Cube45.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        else if (GameControl.own45 == 4)
            Cube45.gameObject.GetComponent<Renderer>().material.color = Color.green;
        else if (GameControl.own45 == 5)
            Cube45.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        else if (GameControl.own45 == 6)
            Cube45.gameObject.GetComponent<Renderer>().material.color = purple;
        else if (GameControl.own45 == 7)
            Cube45.gameObject.GetComponent<Renderer>().material.color = brown;
        else if (GameControl.own45 == 8)
            Cube45.gameObject.GetComponent<Renderer>().material.color = Color.black;
        else if (GameControl.own45 == 0)
            Cube45.gameObject.GetComponent<Renderer>().material.color = Color.white;

        if (GameControl.own46 == 1)
            Cube46.gameObject.GetComponent<Renderer>().material.color = Color.red;
        else if (GameControl.own46 == 2)
            Cube46.gameObject.GetComponent<Renderer>().material.color = orange;
        else if (GameControl.own46 == 3)
            Cube46.gameObject.GetComponent<Renderer>().material.color = Color.yellow;
        else if (GameControl.own46 == 4)
            Cube46.gameObject.GetComponent<Renderer>().material.color = Color.green;
        else if (GameControl.own46 == 5)
            Cube46.gameObject.GetComponent<Renderer>().material.color = Color.blue;
        else if (GameControl.own46 == 6)
            Cube46.gameObject.GetComponent<Renderer>().material.color = purple;
        else if (GameControl.own46 == 7)
            Cube46.gameObject.GetComponent<Renderer>().material.color = brown;
        else if (GameControl.own46 == 8)
            Cube46.gameObject.GetComponent<Renderer>().material.color = Color.black;
        else if (GameControl.own46 == 0)
            Cube46.gameObject.GetComponent<Renderer>().material.color = Color.white;

    }
}
