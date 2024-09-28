using UnityEngine;

public class GameManager4 : MonoBehaviour
{
    private Personaje4 personaje1;
    private Personaje4 personaje2;

    void Start()
    {
        Arma armaPersonaje1 = new Arma(10f, 20f, 30, true);
        Arma armaPersonaje2 = new Arma(15f, 25f, 40, false);

        personaje1 = new Personaje4("Heroe", 100f, 2500f, armaPersonaje1);
        personaje2 = new Personaje4("Villano", 80f, 1800f, armaPersonaje2);

        personaje1.AsignarEnemigo(personaje2);
        personaje2.AsignarEnemigo(personaje1);

        personaje1.TeclaCura = KeyCode.H;
        personaje1.TeclaAtacar = KeyCode.J;
        personaje1.TeclaRecargar = KeyCode.K;

        personaje2.TeclaCura = KeyCode.U;
        personaje2.TeclaAtacar = KeyCode.I;
        personaje2.TeclaRecargar = KeyCode.O;
    }

    void Update()
    {
        if (Input.GetKeyDown(personaje1.TeclaCura))
        {
            personaje1.RecibirCura(20f);
        }

        if (Input.GetKeyDown(personaje1.TeclaAtacar))
        {
            personaje1.AtacarEnemigo();
        }

        if (Input.GetKeyDown(personaje1.TeclaRecargar))
        {
            personaje1.RecargarArma();
        }

        if (Input.GetKeyDown(personaje2.TeclaCura))
        {
            personaje2.RecibirCura(20f);
        }

        if (Input.GetKeyDown(personaje2.TeclaAtacar))
        {
            personaje2.AtacarEnemigo();
        }

        if (Input.GetKeyDown(personaje2.TeclaRecargar))
        {
            personaje2.RecargarArma();
        }
    }
}
