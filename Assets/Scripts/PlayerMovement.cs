using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    Animator anim;
    private float speed = 1000;
    private float rotSpeed = -350;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float vertical = Input.GetAxis("Vertical"); //movimiento "W"
        float horizontal = Input.GetAxis("Horizontal"); //movimiento "A" y "D" que 'damos'
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

        transform.eulerAngles = transform.eulerAngles + new Vector3(0, 0,horizontal * rotSpeed * Time.deltaTime);

       

    }


}
