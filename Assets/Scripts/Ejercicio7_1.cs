using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_1 : MonoBehaviour
{
    int numero = 0;
    // Start is called before the first frame update
    void Start()
    {
        while (numero >= 0 && numero < 100)
        {

            numero++;
            Debug.Log(numero);
        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}