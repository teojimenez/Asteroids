using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Teleporter : MonoBehaviour
{
    private float limiteX = 9.2f;
    private float limiteY = 5.5f;
    void Update()
    {
        if (transform.position.y > limiteY ) 
        { 
           transform.position = new Vector3(transform.position.x, -limiteY);
        }
        if(transform.position.y < - limiteY) 
        {
            transform.position = new Vector3(transform.position.x, limiteY); 
        }

        if (transform.position.x > limiteX)
        {
            transform.position = new Vector3(-limiteX, transform.position.y);
        }
        if (transform.position.x < -limiteX)
        {
            transform.position = new Vector3(limiteX, transform.position.y);
        }
    }
}
