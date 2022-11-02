using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AsteroidManager : MonoBehaviour
{
    // Start is called before the first frame update
    public int asteroides_min = 2;
    public int asteroides_max = 6;
    public int asteroides;
    private float limitY = 4f;
    private float limitX = 6.5f;
    public GameObject asteroid;
    PlayerMovement a;
    
    void Start()
    {
        CrearAsteroides();
    }
    
        
    void Update()
    {
        if(asteroides <= 0)
        {
            asteroides_min += 2;
            asteroides_max += 2;
            CrearAsteroides();
        Inmortal();
        }
    }

    void Inmortal()
    {
        a = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>();
        a.LlamarInmortal();
    }

    public static AsteroidManager instance;
    void CrearAsteroides()
    {

        int asteroides = Random.Range(asteroides_min, asteroides_max);

        instance = this;

        for (int i = 0; i < asteroides; i++)
        {

            Debug.Log("Instanciando asteroide: " + i);

            Vector3 posicion = new Vector3(Random.Range(-limitX, limitX), Random.Range(-limitY, limitY));

            while (Vector3.Distance(posicion, new Vector3(0, 0, 0)) < 2)
            {
                posicion = new Vector3(Random.Range(-limitX, limitX), Random.Range(-limitY, limitY));
            }


            Vector3 rotacion = new Vector3(0, 0, Random.Range(0f, 360f));
            GameObject temp = Instantiate(asteroid, posicion, Quaternion.Euler(rotacion));
            temp.GetComponent<AsteroidControler>().manager = this;

        }
    }   
}
