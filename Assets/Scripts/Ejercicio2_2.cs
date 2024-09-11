using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_2 : MonoBehaviour
{
    // Start is called before the first frame update

    int vida = 10;
    float exp = 5f;
    char carac;
    float resultadoSuma;
    float resultadoResta;
    void Start()
    {
        Debug.Log(vida);
        Debug.Log(exp);
        
        //Al int no se le puede sumar un float, al float si
        resultadoSuma = vida+exp;
        Debug.Log(resultadoSuma);

        exp -= vida;
        resultadoResta = exp;
        Debug.Log(resultadoResta);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
