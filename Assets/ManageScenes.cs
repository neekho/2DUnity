using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManageScenes : MonoBehaviour
{
    // Start is called before the first frame update
    public static ManageScenes instance;

    void Awake()
    {
        if (!instance) 
            instance = this;
    }


    public void reloadScene() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }

    public void loadNextScene() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

}
