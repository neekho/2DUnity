using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuLogic : MonoBehaviour
{
   
    public void startGame() {
        SceneManager.LoadScene(1);
    }

}
