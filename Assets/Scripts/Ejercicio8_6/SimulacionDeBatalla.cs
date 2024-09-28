using UnityEngine;


public class SimulacionDeBatalla : MonoBehaviour
{
    void Start()
    {
        Batalla batalla = new Batalla();
        batalla.GenerarCombatientes();
        batalla.CrearEmparejamiento();
        batalla.GenerarCombate();
    }
}