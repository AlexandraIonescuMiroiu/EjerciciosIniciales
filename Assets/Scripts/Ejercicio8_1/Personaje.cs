public class Personaje
{
    private string nombre;
    private float vida;
    private float experiencia;

    public Personaje(string nombre, float vida, float experiencia)
    {
        this.nombre = nombre;
        this.vida = vida;
        this.experiencia = experiencia;
    }

    public string Nombre
    {
        get { return nombre; }
        set { nombre = value; }
    }

    public float Vida
    {
        get { return vida; }
        set { vida = value; }
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
}
