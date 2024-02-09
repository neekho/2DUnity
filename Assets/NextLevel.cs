using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevel : MonoBehaviour
{
    // Start is called before the first frame update
    


    void OnTriggerEnter2D(Collider2D col) {

        if(col.transform.tag == "Player") {
            
            ManageScenes.instance.loadNextScene();

      
        }
    }
}
