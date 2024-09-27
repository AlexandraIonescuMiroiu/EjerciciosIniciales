using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_10 : MonoBehaviour
{
    int numero = 101;
    // Start is called before the first frame update
    void Start()
    {
        while (numero <= 101 && numero > 1)
        {

            numero--;
            Debug.Log(numero);
        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}