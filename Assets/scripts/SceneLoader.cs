using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UntiyEngine.SceneManagement;
public class SceneLoader : MonoBehaviour
{
   public void LoadNext()
   {
       int curentSceneIndex = SceneManager.GetActiveScene().buildindex;
       SceneManager.LoadScene(currentSceneindex + 1);
   }
   public void LoadStartScene()
   {
       SceneManager.LoadScene(0);
   }
public void QuitGame()
   {
Application.Quit();
   }
}
