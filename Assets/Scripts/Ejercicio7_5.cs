using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_5 : MonoBehaviour
{
    [SerializeField] int numero;
    int numero1 = 0;
    // Start is called before the first frame update
    void Start()
    {
        while (numero1 >= 0 && numero1 < numero)
        {

            numero1++;
            Debug.Log(numero1);
        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}