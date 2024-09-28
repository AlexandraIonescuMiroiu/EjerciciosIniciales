using System;
using UnityEngine;

public class Personaje6
{
    private float ataque;
    private float velocidad;
    private float vida;
    private Personaje6 objetivo;

    public void RellenarStats(float atq, float vel, float hp)
    {
        ataque = atq;
        velocidad = vel;
        vida = hp;
    }

    public void MarcarObjetivo(Personaje6 objetivo)
    {
        this.objetivo = objetivo;
    }

    public void Atacar()
    {
        objetivo.vida -= ataque;
        Debug.Log("Personaje atacó con " + ataque + " de daño. Vida restante del objetivo: " + objetivo.vida);
    }

    public float Velocidad
    {
        get { return velocidad; }
    }

    public float Vida
    {
        get { return vida; }
    }
}