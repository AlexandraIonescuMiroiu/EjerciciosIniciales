using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_6 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int km = 1;
    [SerializeField] int m;
    void Start()
    {
       m= km *= 100;
        Debug.Log(m);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
