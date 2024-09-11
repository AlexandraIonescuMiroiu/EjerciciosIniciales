using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_3 : MonoBehaviour
{
    // Start is called before the first frame update


    int vida = 10;
    float exp = 5f;
    float vidamexp;
    float vidabexp;
    float vidapexp;
    float doblevida;
    float tripleexp;

    void Start()
    {
       
        vidamexp = vida * exp;
        vidabexp = vida / exp;
        vidapexp = vida % exp;
        doblevida = vida * 2;
        tripleexp = exp * 3;






    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
