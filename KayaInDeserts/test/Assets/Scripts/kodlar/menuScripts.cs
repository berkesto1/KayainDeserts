using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menuScripts : MonoBehaviour
{
   public void OynaButonu()
   {
       SceneManager.LoadScene(1);
   }
   public void QuitButonu()
   {
       Debug.Log("Oyundan Çıktı");
       Application.Quit();
   }

   public void MenuyeGeriDon()
   {
       SceneManager.LoadScene(0);
   }
}
