using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SetUpLocalPlayer : NetworkBehaviour
{

    [SyncVar]
    public string pname = "player";

    [SyncVar]
    public Color playerColor = Color.white;

	void OnGUI()
    {
        if (isLocalPlayer)
        {
            pname = GUI.TextField(new Rect(25, Screen.height - 40, 100, 30), pname);
            if (GUI.Button(new Rect(130, Screen.height - 40,80,30), "Change"))
            {
                CmdChangeName(pname);
            }
        }
    }

	void Start () {
		if (isLocalPlayer)
        {
            GetComponent<drive>().enabled = true;
        }
	}
	
	// Update is called once per frame
	void Update () {
        this.GetComponentInChildren<TextMesh>().text = pname;
	}

    [Command]
    public void CmdChangeName(string newName)
    {
        pname = newName;
        this.GetComponentInChildren<TextMesh>().text = pname;
    } 
}
