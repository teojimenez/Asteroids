using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using System;
using Unity.Mathematics;

public class PowerUpScript : MonoBehaviour
{
    //public AsteroidControler AsteroidControler;

    public GameObject CannonSimple;
    public GameObject CannonDouble;
    public GameObject CannonTriple;
    
    public TextMeshProUGUI puntuacion;


    void Update()
    {
        if (GameManager.instance.puntuacion >= 7500)
        {
            CannonSimple.SetActive(false);
            CannonDouble.SetActive(true);
        }
        if (GameManager.instance.puntuacion >= 20000)
        {
            CannonSimple.SetActive(false);
            CannonDouble.SetActive(false);
            CannonTriple.SetActive(true);
        }

    }
    
    void Start()
    {
        
    }

    
}
