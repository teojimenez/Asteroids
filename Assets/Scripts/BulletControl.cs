using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletControl : MonoBehaviour
{
    Rigidbody2D rb;
    public float bulletSpeed = 10000;
    public float bulletLive = 3;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.up * bulletSpeed);
        Destroy(gameObject, bulletLive);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Asteroid")
        { 
            collision.gameObject.GetComponent<AsteroidControler>().Muerte();
            Destroy(gameObject);
        }
    }


}






        
