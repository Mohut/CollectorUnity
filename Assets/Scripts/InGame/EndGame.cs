using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{

    public Slider slider;
    private float timer;
    private int currentSceneIndex;

    private void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        timer = FindObjectOfType<Timer>().timer;
        if (slider.value == 1)
        {
            currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            PlayerPrefs.SetInt("lastScene", currentSceneIndex);
            SceneManager.LoadScene(2);
        }

        if (timer < 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    
}
