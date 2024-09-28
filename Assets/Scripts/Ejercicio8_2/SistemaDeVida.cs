using UnityEngine;

public class SistemaDeVida
{
    [SerializeField]
    private float vidaInicial;

    private float vidaActual;


    public SistemaDeVida(float vidaInicial)
    {
        this.vidaInicial = vidaInicial;
        this.vidaActual = vidaInicial;
    }

    public float RecibirCura(float cantidad)
    {
        if (cantidad < 0)
        {
            Debug.Log("Cantidad de cura inválida.");
            return -1;
        }

        vidaActual += cantidad;

        if (vidaActual > vidaInicial)
        {
            vidaActual = vidaInicial;
        }

        return vidaActual;
    }

    public float RecibirDanho(float danho)
    {
        if (danho < 0)
        {
            Debug.Log("Cantidad de daño inválida.");
            return -1;
        }

        vidaActual -= danho;

        if (vidaActual <= 0)
        {
            vidaActual = 0;
            Debug.Log("El personaje ha muerto.");
            return 0;
        }

        return vidaActual;
    }

    public float VidaActual
    {
        get { return vidaActual; }
    }

    public float VidaInicial
    {
        get { return vidaInicial; }
        set { vidaInicial = value; }
    }
}
