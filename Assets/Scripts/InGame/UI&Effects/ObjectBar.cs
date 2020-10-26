using System;
using UnityEngine;
using Slider = UnityEngine.UI.Slider;
using UnityEngine.UI;

public class ObjectBar : MonoBehaviour
{
    public Slider slider;
    public Image image;
    private Color32 green;

    private void Start()
    {
        green = new Color32();
    }

    public void incrementProgress()
    { 
        slider.value += 0.1f;
        image.color = Color.Lerp(Color.green, Color.red, slider.value);
    }

    public void decrementProgress()
    {
        slider.value -= 0.1f;
        image.color = Color.Lerp(Color.green, Color.red, slider.value);
    }
}
