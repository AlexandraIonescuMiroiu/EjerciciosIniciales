using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_5 : MonoBehaviour
{

    // IDK
    // Start is called before the first frame update

    [SerializeField] float radio;
    float longitud;
    float area;
    void Start()
    {
        longitud = 2 * 3.14f * radio;
        Debug.Log("La londitud de la circunferencia = " + longitud);

        area = 3.14f * radio * radio;
        Debug.Log("El area de la circunferencia = " + area);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
