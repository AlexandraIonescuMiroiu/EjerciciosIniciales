using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_6 : MonoBehaviour
{
    [SerializeField] int numero;
    int numero1; //-numero 

    // Start is called before the first frame update
    void Start()
    {

        numero1 = -numero;
        while (numero1 <= numero)
        {
            Debug.Log(numero);
            numero--;
        }

        for (numero1 = -numero; numero1 <= numero; numero--)
        {
            Debug.Log(numero);
        }

    }
    // Update is called once per frame
    void Update()
    {

    }
}