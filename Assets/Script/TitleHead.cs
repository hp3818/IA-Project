using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class TitleHead : MonoBehaviour {

    private Image image;
    public static GameObject Head1;
    public static GameObject Head2;
    public static GameObject start;
    public static GameObject ImageForParse;
    public static GameObject ImageForParse2;
    public Button ParseButton;
    public Text bgmText;
    public static int i = 1;

    void Start () {

        Head1 = GameObject.Find("Head1");
        Head2 = GameObject.Find("Head2");
        start = GameObject.Find("Start");
        ImageForParse = GameObject.Find("ImageForParse");
        ImageForParse.gameObject.SetActive(false);

        StartCoroutine(TemporarilyDeactivate(0.25f));
        StartCoroutine(TemporarilyDeactivate3(0.25f));
    }

    void Update()
    {
        if (Input.touchCount == 1)
        {
            SceneManager.LoadScene("Player selection");
        }
    }



    public void ClickParse()
    {
        if (Input.GetMouseButtonUp(0))
        {
            StartCoroutine(TemporarilyDeactivate5(0.1f));
            ImageForParse.gameObject.SetActive(true);
        }
    }

    public void Resume()
    {
        ImageForParse.gameObject.SetActive(false);
    }

    public void Mute()
    {
        if(i == 1)
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

    private IEnumerator TemporarilyDeactivate(float duration)
    {
        Head1.gameObject.SetActive(true);
        Head2.gameObject.SetActive(false);
        yield return new WaitForSeconds(duration);
        StartCoroutine(TemporarilyDeactivate2(0.25f));
    }

    private IEnumerator TemporarilyDeactivate2(float duration)
    {
        Head1.gameObject.SetActive(false);
        Head2.gameObject.SetActive(true);
        yield return new WaitForSeconds(duration);
        StartCoroutine(TemporarilyDeactivate(0.25f));
    }

    private IEnumerator TemporarilyDeactivate3(float duration)
    {
        start.gameObject.SetActive(true);
        yield return new WaitForSeconds(duration);
        StartCoroutine(TemporarilyDeactivate4(1));
    }

    private IEnumerator TemporarilyDeactivate4(float duration)
    {
        start.gameObject.SetActive(false);
        yield return new WaitForSeconds(duration);
        StartCoroutine(TemporarilyDeactivate3(1));
    }

    private IEnumerator TemporarilyDeactivate5(float duration)
    {
        ParseButton.GetComponent<Image>().color = Color.red;
        yield return new WaitForSeconds(duration);
        ParseButton.GetComponent<Image>().color = Color.black;
    }

}
