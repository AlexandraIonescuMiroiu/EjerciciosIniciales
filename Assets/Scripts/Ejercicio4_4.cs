using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float velocidadConvertidaenMetrosPorSegundo = Conversor(90);
        Debug.Log("90km/h convertidos en metros por segundos, son" + velocidadConvertidaenMetrosPorSegundo + " m/s");
    }

    // Update is called once per frame
    void Update()
    {

    }

    float Conversor(float velocidadKMporHora)
    {
        float velocidadConvertida = velocidadKMporHora * 1000f / 3600f;
        return velocidadConvertida;
    }
}