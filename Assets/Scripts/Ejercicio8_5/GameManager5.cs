using UnityEngine;

public class GameManager5 : MonoBehaviour
{
    public static GameManager5 Instance { get; private set; }

    private Personaje5 personaje1;
    private Personaje5 personaje2;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        Arma armaPersonaje1 = new Arma(10f, 20f, 30, true);
        Arma armaPersonaje2 = new Arma(15f, 25f, 40, false);

        personaje1 = new Personaje5("Heroe", 100f, 2500f, armaPersonaje1);
        personaje2 = new Personaje5("Villano", 80f, 1800f, armaPersonaje2);

        personaje1.AsignarEnemigo(personaje2);
        personaje2.AsignarEnemigo(personaje1);

        personaje1.TeclaCura = KeyCode.H;
        personaje1.TeclaAtacar = KeyCode.J;
        personaje1.TeclaRecargar = KeyCode.K;

        personaje2.TeclaCura = KeyCode.U;
        personaje2.TeclaAtacar = KeyCode.I;
        personaje2.TeclaRecargar = KeyCode.O;

        personaje1.MiTurno = true;
        personaje2.MiTurno = false;
    }

    void Update()
    {
        if (personaje1.MiTurno)
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
        }
        else if (personaje2.MiTurno)
        {
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

    public void FinDeTurno(Personaje5 personaje)
    {
        if (personaje == personaje1)
        {
            personaje1.MiTurno = false;
            personaje2.MiTurno = true;
        }
        else
        {
            personaje2.MiTurno = false;
            personaje1.MiTurno = true;
        }
    }
}
