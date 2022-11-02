using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{

    void Update()
    {
        if(Input.anyKeyDown) 
        {
            SceneManager.LoadScene(1);
        }
    }

    public void Jugar()
    {
        if (Input.GetKeyUp(KeyCode.O))
        {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
