using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpScript_Shield : MonoBehaviour
{
    PlayerMovement a;
    public static AsteroidManager instance;
    Rigidbody2D rb;
    CircleCollider2D collider;
    SpriteRenderer sprite;
    void Inmortal()
    {
        a = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        a.LlamarInmortalShield();
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        collider = GetComponent<CircleCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Inmortal();
            Destroy(gameObject);
        }
    }
}
