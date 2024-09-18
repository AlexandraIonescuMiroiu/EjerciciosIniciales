using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_3 : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] string moneda;



    void Start()
    {
        if (moneda == "EURO")
        {
            float resultado = Convertir(8);
            Debug.Log("Teniendo, 20 euros, ahora tienes, " + resultado + " de dolares");
        }
        if (moneda == "euro")
        {
            float resultado = Convertir(12);
            Debug.Log("Teniendo, 40 euros, ahora tienes, " + resultado + " de euros");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    float Convertir(float cantidad)
    {
        float resultado = 0f;
        if (moneda == "EURO")
        {
            Debug.Log("Tienes " + cantidad + " de euros");
            resultado = cantidad * 1.1124f;
        }
        if (moneda == "euro")
        {
            Debug.Log("Tienes " + cantidad + " de dolares");
            resultado = cantidad * 0.8991f;
        }
        return resultado;
    }
}
