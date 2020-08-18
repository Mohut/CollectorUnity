using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timer;
    public Text timerText;
    
    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        timerText.text = timer.ToString("0");
    }
}