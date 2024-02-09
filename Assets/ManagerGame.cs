using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ManagerGame : MonoBehaviour
{

    public static ManagerGame instance;

    void Awake()
    {
        if(!instance) instance = this;
    }


   public void onGameOver() {
    ManageScenes.instance.reloadScene();
    // SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
   }
}
