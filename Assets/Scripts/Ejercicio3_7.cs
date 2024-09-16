using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_7 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int vEnemigo;
    [SerializeField] int aTriangulo;
    [SerializeField] int resultado;
    void Start()
    {
        resultado= vEnemigo*aTriangulo;
        Debug.Log(resultado);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
