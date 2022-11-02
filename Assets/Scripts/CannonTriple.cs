using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonTriple : MonoBehaviour
{
    public GameObject spawnBullet3;
    public GameObject spawnBullet4;
    public GameObject spawnBullet5; 
    public GameObject bullet;
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            GameObject temp1 = Instantiate(bullet, spawnBullet3.transform.position, transform.rotation);
            Destroy(temp1, 1.5f);
            GameObject temp2 = Instantiate(bullet, spawnBullet4.transform.position, transform.rotation);
            Destroy(temp2, 1.5f);
            GameObject temp3 = Instantiate(bullet, spawnBullet5.transform.position, transform.rotation);
            Destroy(temp3, 1.5f);
        }
    }
}
