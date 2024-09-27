using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_12 : MonoBehaviour
{
    [SerializeField] int numero0, numero1;
    int numeroTotal;
    // Start is called before the first frame update
    void Start()
    {

        for (int numero = numero0; numero != numero1; numeroTotal += numero)
        {
            numero++;
            Debug.Log(numeroTotal + numero1);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}