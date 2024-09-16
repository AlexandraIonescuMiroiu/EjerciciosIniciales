using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio3_4 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] int exp ;
    [SerializeField] int lvl;

    void Start()
    {
        lvl = 32 + (9 * exp / 5);
        Debug.Log(lvl);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
