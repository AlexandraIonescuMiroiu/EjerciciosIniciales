using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2_5 : MonoBehaviour
{
    // Start is called before the first frame update



    int vidasPlayer1 = 10;
    int vidasPlayer2 = 20;
    int vidasPlayer3 = 30;
    int vidasPlayer4 = 40;

   void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        vidasPlayer2 = vidasPlayer3;
        Debug.Log(vidasPlayer2);
        vidasPlayer3 = vidasPlayer1;
        Debug.Log(vidasPlayer3);
        vidasPlayer1 = vidasPlayer4;
        Debug.Log(vidasPlayer1);
        vidasPlayer4 = vidasPlayer2;
        Debug.Log(vidasPlayer4);






    }
}
