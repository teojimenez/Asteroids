using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerInmortal : MonoBehaviour
{
   
    public float timer = 0;
    public TextMeshProUGUI textoTimerPro;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        textoTimerPro.text = "" + timer.ToString("f1");
        if(timer <= 00.00)
        {
            timer = 0f;

        }
    }
}
