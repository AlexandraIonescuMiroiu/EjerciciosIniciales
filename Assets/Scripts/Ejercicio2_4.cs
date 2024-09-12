using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_4 : MonoBehaviour
{
    // Start is called before the first frame update

    int vida = 10;



    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        vida += 77;
        Debug.Log(vida);
        vida -= 3;
        Debug.Log(vida);
        vida *= 4;
        Debug.Log(vida);

    }
}
