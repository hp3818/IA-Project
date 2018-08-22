using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class TitleHead2 : MonoBehaviour
{

    public static GameObject ImageForParse;
    public Button ParseButton;
    public Text bgmText;
    public static int i = 1;

    void Start()
    {
        ImageForParse = GameObject.Find("ImageForParse");
        ImageForParse.gameObject.SetActive(false);
    }

    public void ClickParse()
    {
        StartCoroutine(TemporarilyDeactivate5(0.1f));
        ImageForParse.gameObject.SetActive(true);
    }

    public void Resume()
    {
        ImageForParse.gameObject.SetActive(false);
    }

    public void Mute()
    {
        if (i == 1)
        {
            i = 0;
            bgmText.text = "開啟音量";
        }
        else if (i == 0)
        {
            i = 1;
            bgmText.text = "關閉音量";
        }
    }

    private IEnumerator TemporarilyDeactivate5(float duration)
    {
        ParseButton.GetComponent<Image>().color = Color.red;
        yield return new WaitForSeconds(duration);
        ParseButton.GetComponent<Image>().color = Color.black;
    }
    /*
    public void ClickButtonTest()
    {
        Card.Card1.gameObject.SetActive(true);
        Card.Card2.gameObject.SetActive(true);
        Card.Card3.gameObject.SetActive(true);
        Card.Card4.gameObject.SetActive(true);
        Card.Card5.gameObject.SetActive(true);
    }
    */
}

