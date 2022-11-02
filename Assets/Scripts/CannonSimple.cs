using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonSimple : MonoBehaviour
{
    public GameObject spawnBullet;
    public GameObject bullet;
    void Update()
    {
            if (Input.GetButtonDown("Jump"))
            {
                GameObject temp1 = Instantiate(bullet, spawnBullet.transform.position, transform.rotation);
                Destroy(temp1, 1.5f);
            }
    }
}
