using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_7 : MonoBehaviour
{
    [SerializeField] int velJugador1, velJugador2, velJugador3;
    // Start is called before the first frame update
    void Start()
    {
        if (velJugador2 >= velJugador1 && velJugador2 >= velJugador3)
        {
            Debug.Log("El segundo jugador comienza.");

        }
        else if (velJugador1 >= velJugador2 && velJugador1 >= velJugador2)
        {
            Debug.Log("El primer jugador comienza.");

        }
        else if (velJugador3 >= velJugador2 && velJugador3 >= velJugador2)
        {
            Debug.Log("El tercer jugador comienza.");
        }
        else
        {
            Debug.Log("Hay empate");
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}