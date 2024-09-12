using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_6 : MonoBehaviour
{
    // Start is called before the first frame update
    int vida = 10;
    int pocion = 20;
    int buff = 30;
    int media;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(vida);
        Debug.Log(pocion);
        Debug.Log(buff);
        media = vida + pocion + buff;
        media /= 3;
        Debug.Log(media);
       

    }
}
