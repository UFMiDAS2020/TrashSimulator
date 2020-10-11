using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class UpdateSliderText : MonoBehaviour
{
    public Slider slider;
    public TMP_Text maxValueText;
    public TMP_Text currentValueText;

    private void Start()
    {
        maxValueText.text = slider.maxValue.ToString();
        currentValueText.text = Math.Floor(slider.value).ToString();
    }

    public void UpdateCurrentValue()
    {
        currentValueText.text = Math.Floor(slider.value).ToString();
    }

    public void IncreaseMaxValue()
    {
        slider.maxValue += 1;
        maxValueText.text = slider.maxValue.ToString();
    }

    public void DecreaseMaxValue()
    {
        if (slider.maxValue > 0) slider.maxValue -= 1;
        maxValueText.text = slider.maxValue.ToString();
    }
}
