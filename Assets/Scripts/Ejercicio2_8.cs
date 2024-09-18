using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_8 : MonoBehaviour
{
    // Start is called before the first frame update
    float vida = 120f;
    float pVida;
    void Start()
    {
        pVida = (vida * 3) / 100;

        vida -= pVida;
        Debug.Log(vida);

        vida -= pVida * 2;
        Debug.Log(vida); 

        vida -= pVida * 3;
        Debug.Log(vida);

        vida -= pVida * 4;
        Debug.Log(vida);

        vida -= pVida * 5;
        Debug.Log(vida);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
