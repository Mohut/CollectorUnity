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
            //save the current scene
            currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            PlayerPrefs.SetInt("lastScene", currentSceneIndex);

            //loading finishing screen
            SceneManager.LoadScene(2);
        }

        if (timer < 0)
        {
            //save the complete status
            int currentLevel = SceneManager.GetActiveScene().buildIndex - 2;
            if (currentLevel >= PlayerPrefs.GetInt("unlocked",1) && currentLevel <= 4)
            {
                PlayerPrefs.SetInt("unlocked", currentLevel);
            }
            Debug.Log(currentLevel);
            SceneManager.LoadScene(3);
        }
    }
}
