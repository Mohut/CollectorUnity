using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BlinkingText : MonoBehaviour
{
    [SerializeField] private Text text;
    void Start()
    {
        InvokeRepeating("Blinking", 1, 0.8f);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.F))
        {
            SceneManager.LoadScene(1);
        }
    }

    public void Blinking()
    {
        if (text.enabled)
        {
            text.enabled = false;
        }
        else
        {
            text.enabled = true;
        }
    }
}
