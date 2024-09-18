using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio4_1 : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] float radio;
    [SerializeField] float basexd;
    [SerializeField] float altura;
    [SerializeField] float lado;

    float circulo;
    float triangulo;
    float cuadrado;


    void Start()
    {

        circulo = (radio * radio) * 3.14f;
        triangulo = (basexd * altura) / 2;
        cuadrado = lado * lado;

        Debug.Log("EL area del circulo es " + circulo);
        Debug.Log("EL area del triangulo es " + triangulo);
        Debug.Log("EL area del cuadrado es " + cuadrado);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
