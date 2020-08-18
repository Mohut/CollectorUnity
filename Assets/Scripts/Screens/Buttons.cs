using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
   private int previousScene;
   public void startGame()
   {
      SceneManager.LoadScene(3);
   }
   
   public void retry()
   {
      previousScene = PlayerPrefs.GetInt("lastScene");
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
}
