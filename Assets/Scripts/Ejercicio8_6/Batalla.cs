using System;
using UnityEngine;

public class Batalla
{
    private Personaje6 player1 = new Personaje6();
    private Personaje6 player2 = new Personaje6();
    private Personaje6 player3 = new Personaje6();
    private Personaje6 player4 = new Personaje6();
    private Personaje6 combatiente1;
    private Personaje6 combatiente2;

    public void GenerarCombatientes()
    {
        player1.RellenarStats(UnityEngine.Random.Range(50, 121), UnityEngine.Random.Range(20, 101), UnityEngine.Random.Range(50, 201));
        player2.RellenarStats(UnityEngine.Random.Range(50, 121), UnityEngine.Random.Range(20, 101), UnityEngine.Random.Range(50, 201));
        player3.RellenarStats(UnityEngine.Random.Range(50, 121), UnityEngine.Random.Range(20, 101), UnityEngine.Random.Range(50, 201));
        player4.RellenarStats(UnityEngine.Random.Range(50, 121), UnityEngine.Random.Range(20, 101), UnityEngine.Random.Range(50, 201));
    }

    public void CrearEmparejamiento()
    {
        Personaje6[] jugadores = { player1, player2, player3, player4 };
        int randomIndex1 = UnityEngine.Random.Range(0, jugadores.Length);
        int randomIndex2;
        do
        {
            randomIndex2 = UnityEngine.Random.Range(0, jugadores.Length);
        }
        while (randomIndex1 == randomIndex2);

        combatiente1 = jugadores[randomIndex1];
        combatiente2 = jugadores[randomIndex2];

        combatiente1.MarcarObjetivo(combatiente2);
        combatiente2.MarcarObjetivo(combatiente1);
    }

    public void GenerarCombate()
    {
        Personaje6 primero, segundo;

        if (combatiente1.Velocidad > combatiente2.Velocidad)
        {
            primero = combatiente1;
            segundo = combatiente2;
        }
        else
        {
            primero = combatiente2;
            segundo = combatiente1;
        }

        while (combatiente1.Vida > 0 && combatiente2.Vida > 0)
        {
            primero.Atacar();
            if (segundo.Vida > 0)
            {
                segundo.Atacar();
            }
        }

        if (combatiente1.Vida > 0)
        {
            Debug.Log("Combatiente 1 ha ganado el combate.");
        }
        else
        {
            Debug.Log("Combatiente 2 ha ganado el combate.");
        }
    }
}

