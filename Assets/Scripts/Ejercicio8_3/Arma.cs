using UnityEngine;

public class Arma
{
    [SerializeField]
    private float danhoMinimo;

    [SerializeField]
    private float danhoMaximo;

    [SerializeField]
    private int capacidadTotal;

    [SerializeField]
    private bool esAutomatica;

    private int municionActual;

    public Arma(float danhoMinimo, float danhoMaximo, int capacidadTotal, bool esAutomatica)
    {
        this.danhoMinimo = danhoMinimo;
        this.danhoMaximo = danhoMaximo;
        this.capacidadTotal = capacidadTotal;
        this.esAutomatica = esAutomatica;
        this.municionActual = capacidadTotal;
    }

    public int UtilizarArma()
    {
        if (municionActual > 0)
        {
            municionActual--;
            return 0;
        }
        else
        {
            return -1;
        }
    }

    public int RecargarArma()
    {
        if (municionActual < capacidadTotal)
        {
            municionActual = capacidadTotal;
            return 0;
        }
        else
        {
            return -1;
        }
    }

    public int MunicionActual
    {
        get { return municionActual; }
    }

    public float DanhoMinimo
    {
        get { return danhoMinimo; }
    }

    public float DanhoMaximo
    {
        get { return danhoMaximo; }
    }

    public int CapacidadTotal
    {
        get { return capacidadTotal; }
    }

    public bool EsAutomatica
    {
        get { return esAutomatica; }
    }
}
