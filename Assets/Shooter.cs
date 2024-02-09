using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bullet;

    public float shootTime;

    public float currentShootTime;

    private float counter = 0;

    void start ()
    {
        currentShootTime = shootTime;
    }


    void Update()
    {
        if(currentShootTime > counter)
        {
            currentShootTime -= Time.deltaTime;
        }
        else
        {
            Shoot();
            currentShootTime = shootTime;
        }
    }


    private void Shoot()
    {

        GameObject bulletPrefab = (GameObject)Instantiate(bullet, this.transform.position, Quaternion.identity);

    }

}