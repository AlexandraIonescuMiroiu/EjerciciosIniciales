using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_9 : MonoBehaviour
{
    [SerializeField] int tipo;
    int daño = 0, vida = 0;
    // Start is called before the first frame update
    void Start()
    {

        if (tipo == 1)
        {
            daño = 350;
            vida = 650;
        }
        else if (tipo == 2)
        {
            daño = 300;
            vida = 550;
        }
        else if (tipo == 3)
        {
            daño = 300;
            vida = 500;
        }
        else if (tipo == 4)
        {
            daño = 310;
            vida = 460;
        }
        else if (tipo == 5)
        {
            daño = 280;
            vida = 490;
        }
        else if (tipo == 6)
        {
            daño = 360;
            vida = 520;
        }
        Debug.Log("Enemigo tipo " + tipo + " generado:");
        Debug.Log("Daño: " + daño);
        Debug.Log("Vida: " + vida);

    }

    // Update is called once per frame
    void Update()
    {

    }
}