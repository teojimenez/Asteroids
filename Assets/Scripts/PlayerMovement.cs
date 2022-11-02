using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    Animator anim;
    CapsuleCollider2D collider;
    SpriteRenderer sprite;
    public SpriteRenderer inmortal1;
    public GameObject inmortal;
    private float speed = 600;
    private float rotSpeed = -300;
    public GameObject bullet;
    public GameObject spawnBullet;
    public GameObject ParticulasMuerte;
    public bool muerto;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        collider = GetComponent<CapsuleCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
        StartCoroutine(Respawn_Coroutine());
    }

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("Vertical"); //movimiento "W"
        if (vertical > 0)
        {
            //Time.deltaTime sirve para que la velocidad sea estable en cualquier ordenador
            rb.AddForce(transform.up * vertical * speed * Time.deltaTime);
            anim.SetBool("Impulsing", true);
        }
        else
        {
            anim.SetBool("Impulsing", false);
        }

        float horizontal = Input.GetAxis("Horizontal"); //movimiento "A" y "D" que 'damos'
        transform.eulerAngles = transform.eulerAngles + new Vector3(0, 0, horizontal * rotSpeed * Time.deltaTime);
    }
    public void Muerte()
    {

        GameObject temp = Instantiate(ParticulasMuerte, transform.position, transform.rotation);
        Destroy(temp, 2.5f);
        GameManager.instance.vidas -= 1;
        if (GameManager.instance.vidas <= 0)
        {
            Destroy(gameObject);
        }
        else
        {
            StartCoroutine(Respawn_Coroutine());
        }
    }

    IEnumerator Respawn_Coroutine()
    {
        muerto = true;
        collider.enabled = false;
        sprite.enabled = false;
        yield return new WaitForSeconds(2);


        transform.position = new Vector3(0, 0, 0);
        rb.velocity = new Vector2(0, 0);
        muerto = false;

        StartCoroutine(Inmortal());

    }
    public void LlamarInmortal()
    {
        collider.enabled = false;
        sprite.enabled = false;
        StartCoroutine(Inmortal());
    }
    public void LlamarInmortalShield()
    {
        StartCoroutine(InmortalShield());
    }
    IEnumerator InmortalShield()
    {
        collider.enabled = false;
        sprite.enabled = false;
        inmortal1.enabled = true;
        yield return new WaitForSeconds(10);
        inmortal1.enabled = false;
        collider.enabled = true;
        sprite.enabled = true;
    }
    IEnumerator Inmortal()
    {
            inmortal1.enabled = true;
             yield return new WaitForSeconds(2);
            inmortal1.enabled = false;
            sprite.enabled = true;
            collider.enabled = true;
        }
   }


