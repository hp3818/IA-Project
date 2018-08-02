using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderValue : MonoBehaviour {

    public Text text;
    public Slider slider;

    public void UpdateText ()
    {
        text.text = slider.value.ToString();
    }

}
