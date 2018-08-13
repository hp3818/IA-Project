using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//369 1211
public class Bgm : MonoBehaviour
{
    private static Bgm instance = null;
    public static Bgm Instance
    {
        get { return instance; }
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }

        DontDestroyOnLoad(this.gameObject);

    }

    void Update()
    {
        if (TitleHead.i == 0)
            AudioListener.volume = 0;
        else if (TitleHead.i == 1)
            AudioListener.volume = 1;
    }
}

