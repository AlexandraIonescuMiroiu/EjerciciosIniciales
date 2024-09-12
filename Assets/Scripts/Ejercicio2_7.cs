using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_7 : MonoBehaviour
{
    // Start is called before the first frame update
    int oro = 4;
    int orominuto;
    int orohora;
    int oro4horas;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(oro);
        orominuto = oro * 60;
        orohora= orominuto * 60;
        oro4horas = orohora * 4;
        Debug.Log(oro4horas);
    }
}
