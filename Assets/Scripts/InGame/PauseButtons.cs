using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseButtons : MonoBehaviour
{
    public Button button;
    public Sprite pauseTexture;
    public Sprite playTexture;
    public Canvas canvas;
    
    public void pause()
    {
        if (Time.timeScale == 1)
        {
            Time.timeScale = 0;
            button.GetComponent<Image>().sprite = playTexture;
            canvas.enabled = true;
        }
        else
        {
            Time.timeScale = 1;
            button.GetComponent<Image>().sprite = pauseTexture;
            canvas.enabled = false;
        }
    }
}
