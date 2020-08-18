using UnityEngine;
using UnityEngine.UIElements;
using Slider = UnityEngine.UI.Slider;

public class ObjectBar : MonoBehaviour
{
    public Slider slider;
    public Camera camera;

    public void incrementProgress()
    {
        slider.value += 0.1f;
    }

    public void decrementProgress()
    {
        slider.value -= 0.1f;
    }
}
