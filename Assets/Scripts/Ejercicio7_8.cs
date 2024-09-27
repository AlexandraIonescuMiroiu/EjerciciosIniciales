using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio7_8 : MonoBehaviour
{
    [SerializeField] int numero, numero1;
    // Start is called before the first frame update
    void Start()
    {
        if (numero > numero1)
        {
            for (int i = numero; i >= numero1; i--)
            {
                if (i % 2 == 0)
                {
                    Debug.Log(i);
                }
            }
        }
        else
        {
            for (int i = numero; i <= numero1; i++)
            {
                if (i % 2 == 0)
                {
                    Debug.Log(i);
                }
            }
        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}