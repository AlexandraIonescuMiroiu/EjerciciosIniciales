public class Personaje2
{
    private string nombre;
    private float experiencia;

    private SistemaDeVida sistemaDeVida;

    public Personaje2(string nombre, float vidaInicial, float experiencia)
    {
        this.nombre = nombre;
        this.experiencia = experiencia;
        this.sistemaDeVida = new SistemaDeVida(vidaInicial);
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

    public float CalcularNivel()
    {
        return experiencia / 1000f;
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
}
