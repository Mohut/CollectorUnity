using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.UI;

public class StartTimer : MonoBehaviour
{

    private float time;
    [SerializeField] private TextMeshProUGUI text;
    [SerializeField] private Image image;
    
    void Start()
    {
        time = 3;
    }

  
    void Update()
    {
        time -= Time.deltaTime;
        if (time > 1)
        {
            text.text = time.ToString("0");
            transform.localScale = Vector3.one * (time);
        }
        else
        {
            text.text = "Go!";
            transform.localScale = Vector3.one * (time);
        }
        
        

        if (time < 0)
        {
            gameObject.GetComponent<TextMeshProUGUI>().enabled = false;
            image.enabled = false;
        }
    }
}
