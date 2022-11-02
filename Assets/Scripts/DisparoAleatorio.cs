using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisparoAleatorio : MonoBehaviour
{
    public GameObject spawnBullet;
    public GameObject bullet;
    void Start()
    {
        InvokeRepeating("BalaAleatoria", 2, 0.5f);
    }

    void BalaAleatoria()
    {
        transform.rotation = Random.rotation;
        GameObject temp = Instantiate(bullet, spawnBullet.transform.position, transform.rotation);
        Destroy(temp, 1.5f);    
    }
}
