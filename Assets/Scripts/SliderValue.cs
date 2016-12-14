using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SliderValue : MonoBehaviour {

    public Text sliderValue;
    public Slider slider;

    void Update()
    {

        sliderValue.text = slider.value.ToString("0");

    }
}
