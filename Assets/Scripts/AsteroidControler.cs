using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;


public class AsteroidControler : MonoBehaviour
{   
   
    private float speed_min = 70;
    private float speed_max = 200;
    Rigidbody2D rb;
    public AsteroidManager manager;
    public GameObject prefab1;
    public GameObject prefab2;
    public GameObject prefab3;      
    
    public int randNum;
    
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Vector2 direccion = new Vector2(Random.Range(-1f,1f), Random.Range(-1f, 1f));
        direccion = direccion * Random.Range(speed_min, speed_max);
 
        rb.AddForce(direccion);
        manager.asteroides += 1;
    }

    public void Muerte()
    {
        if (transform.localScale.x > 0.25f)
        {


            GameObject temp1 = Instantiate(manager.asteroid, transform.position, transform.rotation);
            temp1.GetComponent<AsteroidControler>().manager = manager;
            temp1.transform.localScale = transform.localScale * 0.5f;
            GameObject temp2 = Instantiate(manager.asteroid, transform.position, transform.rotation);
            temp2.GetComponent<AsteroidControler>().manager = manager;
            temp2.transform.localScale = transform.localScale * 0.5f;
        }
        GameManager.instance.puntuacion += 100;
        manager.asteroides -= 1;
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.gameObject.GetComponent<PlayerMovement>().Muerte();
            
        }
        
        if(collision.tag == "Bullet")
        {

            randNum = Random.Range(0, 70);
            Debug.Log("EL numero es: " + randNum);
            if (randNum == 1)
            {
                GameObject temp = Instantiate(prefab1, transform.position, transform.rotation);
                Destroy(temp, 2f);
            }
        }
    }
}
