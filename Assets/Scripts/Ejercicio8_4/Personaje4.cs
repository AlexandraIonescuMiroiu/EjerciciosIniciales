using UnityEngine;

public class Personaje4
{
    private string nombre;
    private float experiencia;
    private SistemaDeVida sistemaDeVida;
    private Arma arma;
    private Personaje4 enemigo;

    [SerializeField]
    private KeyCode teclaCura;

    [SerializeField]
    private KeyCode teclaAtacar;

    [SerializeField]
    private KeyCode teclaRecargar;

    public Personaje4(string nombre, float vidaInicial, float experiencia, Arma arma)
    {
        this.nombre = nombre;
        this.experiencia = experiencia;
        this.sistemaDeVida = new SistemaDeVida(vidaInicial);
        this.arma = arma;
    }

    public float CalcularNivel()
    {
        return experiencia / 1000f;
    }

    public void RecibirCura(float cantidad)
    {
        float resultado = sistemaDeVida.RecibirCura(cantidad);
        if (resultado != -1)
        {
            Debug.Log(nombre + " ha recibido " + cantidad + " puntos de cura. Vida actual: " + sistemaDeVida.VidaActual);
        }
        else
        {
            Debug.Log("No se puede curar. Valor inválido.");
        }
    }

    public void AtacarEnemigo()
    {
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
        int resultado = arma.RecargarArma();
        if (resultado == 0)
        {
            Debug.Log(nombre + " ha recargado el arma. Munición actual: " + arma.MunicionActual);
        }
        else
        {
            Debug.Log("Arma ya cargada.");
        }
    }

    public void AsignarEnemigo(Personaje4 enemigo)
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
}
