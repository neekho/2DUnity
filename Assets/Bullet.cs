using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float bulletSpeed;
   
  void start ()
    {
        Destroy(this.gameObject, 5f);
    }

    void Update()
    {
        this.transform.position += Vector3.right * -bulletSpeed * Time.deltaTime;
    }


    void OnCollisionEnter2D(Collision2D col)

    {

        Destroy(this.gameObject);
    }


}

