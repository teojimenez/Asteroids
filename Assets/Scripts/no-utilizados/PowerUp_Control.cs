using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class PowerUp_Control : MonoBehaviour {
    CapsuleCollider2D collider;
    SpriteRenderer sprite;

    public int myPowerUp;
    public SpriteRenderer inmortal1;
    public GameObject PowerUp_Escudo;
    public TextMeshProUGUI puntuacion;
    // Start is called before the first frame update
    void Start()
    {
        collider = GetComponent<CapsuleCollider2D>();
        sprite = GetComponent<SpriteRenderer>();
             
    }

    IEnumerator Escudo()
    {
        inmortal1.enabled = true;
        collider.enabled = false;
        sprite.enabled = false;

        yield return new WaitForSeconds(10);

        inmortal1.enabled = false;

        sprite.enabled = true;
        collider.enabled = true;
        
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "PowerUp")
        {
            StartCoroutine(Escudo());

            Destroy(PowerUp_Escudo);
        }
    }
}
    
