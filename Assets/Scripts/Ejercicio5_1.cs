using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio5_1 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int vida1 = 1;
    [SerializeField] int vida2 = 2;

    void Start()
    {
        if (vida1 == vida2)
        {
            Debug.Log("Empate");
                
        }



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
