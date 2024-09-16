using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_2 : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField] string nombre;

    void Start()
    {
        Debug.Log ("Bienvenido de nuevo, " + nombre);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
