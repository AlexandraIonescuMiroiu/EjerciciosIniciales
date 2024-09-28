using UnityEngine;

public class Personaje5
{
    private string nombre;
    private float experiencia;
    private SistemaDeVida sistemaDeVida;
    private Arma arma;
    private Personaje5 enemigo;
    private bool miTurno;

    [SerializeField]
    private KeyCode teclaCura;
    [SerializeField]
    private KeyCode teclaAtacar;
    [SerializeField]
    private KeyCode teclaRecargar;

    public Personaje5(string nombre, float vidaInicial, float experiencia, Arma arma)
    {
        this.nombre = nombre;
        this.experiencia = experiencia;
        this.sistemaDeVida = new SistemaDeVida(vidaInicial);
        this.arma = arma;
        this.miTurno = false;
    }

    public float CalcularNivel()
    {
        return experiencia / 1000f;
    }

    public void RecibirCura(float cantidad)
    {
        if (!miTurno) return;

        float resultado = sistemaDeVida.RecibirCura(cantidad);
        if (resultado != -1)
        {
            Debug.Log(nombre + " ha recibido " + cantidad + " puntos de cura. Vida actual: " + sistemaDeVida.VidaActual);
        }
        GameManager5.Instance.FinDeTurno(this);
    }

    public void AtacarEnemigo()
    {
        if (!miTurno) return;

        if (arma.UtilizarArma() == 0)
        {
            float danho = Random.Range(arma.DanhoMinimo, arma.DanhoMaximo);
            enemigo.RecibirDanho(danho);
            Debug.Log(nombre + " ha hecho " + danho + " de daño a " + enemigo.Nombre);
        }
        else
        {
            Debug.Log("Reload!!!");
        }
        GameManager5.Instance.FinDeTurno(this);
    }

    public void RecibirDanho(float danho)
    {
        float vidaRestante = sistemaDeVida.RecibirDanho(danho);
        if (vidaRestante > 0)
        {
            Debug.Log(nombre + " ha recibido " + danho + " de daño. Vida actual: " + sistemaDeVida.VidaActual);
        }
        else
        {
            Debug.Log(nombre + " ha muerto.");
        }
    }

    public void RecargarArma()
    {
        if (!miTurno) return;

        int resultado = arma.RecargarArma();
        if (resultado == 0)
        {
            Debug.Log(nombre + " ha recargado el arma. Munición actual: " + arma.MunicionActual);
        }
        else
        {
            Debug.Log("Arma ya cargada.");
        }
        GameManager5.Instance.FinDeTurno(this);
    }

    public void AsignarEnemigo(Personaje5 enemigo)
    {
        this.enemigo = enemigo;
    }

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public KeyCode TeclaCura
    {
        get { return teclaCura; }
        set { teclaCura = value; }
    }

    public KeyCode TeclaAtacar
    {
        get { return teclaAtacar; }
        set { teclaAtacar = value; }
    }

    public KeyCode TeclaRecargar
    {
        get { return teclaRecargar; }
        set { teclaRecargar = value; }
    }

    public bool MiTurno
    {
        get { return miTurno; }
        set { miTurno = value; }
    }
}
