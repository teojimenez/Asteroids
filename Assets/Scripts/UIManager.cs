using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; //agregamos una libreria para usar textos
using System;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI tiempo;
    public TextMeshProUGUI puntuacion;
    public TextMeshProUGUI vidas;
    public GameObject gameOver;
    void Update()
    {

        if (GameManager.instance.vidas > 0)
        { 
            tiempo.text = Time.time.ToString("00.00");
        }
        else
        {
            gameOver.SetActive(true);
        }
        puntuacion.text = GameManager.instance.puntuacion.ToString();
        vidas.text = GameManager.instance.vidas.ToString();
    }
}
