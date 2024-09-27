using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_8 : MonoBehaviour
{
    [SerializeField] int horas, minutos, segundos;
    // Start is called before the first frame update
    void Start()
    {
        if (horas >= 0 && horas < 24 && minutos >= 0 && minutos < 60 && segundos >= 0 && segundos < 60)
        {
            Debug.Log("La hora es correcta, son las: " + horas + ":" + minutos + ":" + segundos + ".");

        }
        else
        {
            Debug.Log("La hora es incorrecta");
        }

    }
    // Update is called once per frame
    void Update()
    {

    }
}