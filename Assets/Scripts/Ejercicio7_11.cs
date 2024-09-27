using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_11 : MonoBehaviour
{
    [SerializeField] int numeroEntero;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Tabla del número " + numeroEntero);
        for (int i = 1; i <= 10; i++)
        {
            Debug.Log(numeroEntero + " * " + i + " = " + numeroEntero * i);
        }

    }
    // Update is called once per frame
    void Update()
    {


    }
}