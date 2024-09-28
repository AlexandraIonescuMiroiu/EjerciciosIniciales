using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager2 : MonoBehaviour
{
    private Personaje2 personaje1;
    private Personaje2 personaje2;

    private bool yaEjecutado = false;

    void Start()
    {
        personaje1 = new Personaje2("Heroe", 100f, 2500f);
        personaje2 = new Personaje2("Villano", 80f, 1800f);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !yaEjecutado)
        {
            PrepararPersonajes();
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            personaje1.RecibirCura(20f);
            Debug.Log("Heroe ha recibido cura. Vida actual: " + personaje1.VidaActual);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            personaje2.RecibirDanho(30f);
            Debug.Log("Villano ha recibido daño. Vida actual: " + personaje2.VidaActual);
        }
    }

    private void PrepararPersonajes()
    {
        Debug.Log("Preparando personajes...");

        personaje1.Nombre = "Heroe";
        personaje1.VidaInicial = 150f;
        Debug.Log(personaje1.Nombre + " tiene nivel: " + personaje1.CalcularNivel());

        personaje2.Nombre = "Villano";
        personaje2.VidaInicial = 120f;
        Debug.Log(personaje2.Nombre + " tiene nivel: " + personaje2.CalcularNivel());

        yaEjecutado = true;
    }
}
