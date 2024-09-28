using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private Personaje personaje1;
    private Personaje personaje2;


    private bool yaEjecutado = false;


    void Start()
    {

        personaje1 = new Personaje("Personaje1", 100f, 2500f);
        personaje2 = new Personaje("Personaje2", 80f, 1800f);
    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && !yaEjecutado)
        {
            PrepararPersonajes();
        }
    }


    private void PrepararPersonajes()
    {

        Debug.Log("Preparando personajes...");


        personaje1.Nombre = "Heroe";
        personaje1.Vida = 150f;
        Debug.Log(personaje1.Nombre + " tiene nivel: " + personaje1.CalcularNivel());

        personaje2.Nombre = "Villano";
        personaje2.Vida = 120f;
        Debug.Log(personaje2.Nombre + " tiene nivel: " + personaje2.CalcularNivel());

        yaEjecutado = true;
    }
}
