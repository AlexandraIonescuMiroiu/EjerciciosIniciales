using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_4 : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] int num = 10;
    [SerializeField] int num2 = 5;
    [SerializeField] int resultado;
    void Start()
    {
        resultado= num/num2;
        Debug.Log(resultado);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
