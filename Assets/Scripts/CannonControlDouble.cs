using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonControlDouble : MonoBehaviour
{
    public GameObject spawnBullet1;
    public GameObject spawnBullet2; 
    public GameObject bullet;

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            GameObject temp1 = Instantiate(bullet, spawnBullet1.transform.position, transform.rotation);
            Destroy(temp1, 1.5f);
            GameObject temp2 = Instantiate(bullet, spawnBullet2.transform.position, transform.rotation);
            Destroy(temp2, 1.5f);
        }
    }
}
