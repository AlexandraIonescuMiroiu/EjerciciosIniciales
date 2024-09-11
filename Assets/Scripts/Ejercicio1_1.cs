using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1_1 : MonoBehaviour
{
    // Start is called before the first frame update

    string texto = "¡Hola Mundo!";
    string nombre = "Alexandra";
    string frame = "Ha pasado un frame";




    void Start()
    {
       
       Debug.Log(texto);
       Debug.Log("Este es el primer videojuego de " + "nombre");
       Debug.Log("Estoy aprendiendo C#");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(frame);
    }
}
