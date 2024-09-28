public class Personaje3
{
    private string nombre;
    private float experiencia;
    private SistemaDeVida sistemaDeVida;
    private Arma arma;

    public Personaje3(string nombre, float vidaInicial, float experiencia, Arma arma)
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

    public int UtilizarArma()
    {
        return arma.UtilizarArma();
    }

    public int RecargarArma()
    {
        return arma.RecargarArma();
    }

    public float RecibirCura(float cantidad)
    {
        return sistemaDeVida.RecibirCura(cantidad);
    }

    public float RecibirDanho(float danho)
    {
        return sistemaDeVida.RecibirDanho(danho);
    }

    public float VidaActual
    {
        get { return sistemaDeVida.VidaActual; }
    }
    public float VidaInicial
    {
        get { return sistemaDeVida.VidaInicial; }
        set { sistemaDeVida.VidaInicial = value; }
    }

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public float Experiencia
    {
        get { return experiencia; }
        set { experiencia = value; }
    }

    public Arma ArmaActual
    {
        get { return arma; }
    }
}
