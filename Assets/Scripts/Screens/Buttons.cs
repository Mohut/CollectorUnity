using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
   public void startGame()
   {
      SceneManager.LoadScene(3);
   }
   
   public void retry()
   {
      int previousScene = PlayerPrefs.GetInt("lastScene");
      SceneManager.LoadScene(previousScene);
   }

   public void toOverWorld()
   {
      SceneManager.LoadScene(1);
   }

   public void toMainMenu()
   {
      SceneManager.LoadScene(0);
   }

    public void nextLevel()
    {
        int previousScene = PlayerPrefs.GetInt("lastScene");
        if (previousScene == 4)
        {
           SceneManager.LoadScene(5);
        }
        else
        {
           SceneManager.LoadScene(previousScene + 1);
        }
    }

    public void GoLevel1()
    {
        SceneManager.LoadScene(4);
    }

    public void GoLevel2()
    {
        SceneManager.LoadScene(5);
    }

    public void GoLevel3()
    {
        SceneManager.LoadScene(6);
    }

    public void GoLevel4()
    {
        SceneManager.LoadScene(7);
    }
}
