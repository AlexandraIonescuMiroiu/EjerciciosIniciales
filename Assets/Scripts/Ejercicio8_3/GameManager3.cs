using UnityEngine;

public class GameManager3 : MonoBehaviour
{
    private Personaje3 personaje1;
    private Personaje3 personaje2;

    private bool yaEjecutado = false;

    void Start()
    {
        Arma armaPersonaje1 = new Arma(10f, 20f, 30, true);
        Arma armaPersonaje2 = new Arma(15f, 25f, 40, false);

        personaje1 = new Personaje3("Heroe", 100f, 2500f, armaPersonaje1);
        personaje2 = new Personaje3("Villano", 80f, 1800f, armaPersonaje2);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !yaEjecutado)
        {
            PrepararPersonajes();
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            personaje1.RecibirCura(20f);
            Debug.Log("Heroe ha recibido cura. Vida actual: " + personaje1.VidaActual);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            personaje2.RecibirDanho(30f);
            Debug.Log("Villano ha recibido daño. Vida actual: " + personaje2.VidaActual);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            int resultado = personaje1.UtilizarArma();
            if (resultado == 0)
            {
                Debug.Log("Heroe ha disparado. Munición restante: " + personaje1.ArmaActual.MunicionActual);
            }
            else
            {
                Debug.Log("Heroe no tiene munición.");
            }
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            int resultado = personaje1.RecargarArma();
            if (resultado == 0)
            {
                Debug.Log("Heroe ha recargado el arma. Munición actual: " + personaje1.ArmaActual.MunicionActual);
            }
            else
            {
                Debug.Log("El arma ya está totalmente cargada.");
            }
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
