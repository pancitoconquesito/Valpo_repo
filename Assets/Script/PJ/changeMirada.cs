using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeMirada : MonoBehaviour
{
    [SerializeField] private SpriteRenderer m_spriteRenderer;
    [SerializeField] private bool miradaNormalDerecha;
    [SerializeField] private float offsetInput;
    enum Type_ladosMirada { iz, der }
    private Type_ladosMirada mirada ;
    private Type_ladosMirada currentMirada;
    private void Start()
    {
        if (miradaNormalDerecha)
        {
            mirada = Type_ladosMirada.der;
            currentMirada = Type_ladosMirada.der;
            mirarDer();
        }
        else
        {
            mirada = Type_ladosMirada.iz;
            currentMirada = Type_ladosMirada.iz;
            mirarIZ();
        }
    }
    public void miradaPj(float valor)
    {
        if (valor < 0f- offsetInput) currentMirada = Type_ladosMirada.iz;
        if (valor > 0f+ offsetInput) currentMirada = Type_ladosMirada.der;
        if (currentMirada != mirada)
        {
            mirada = currentMirada;
            changeMiradaFuncion();
        }
    }
    private void changeMiradaFuncion()
    {
        switch (currentMirada)
        {
            case Type_ladosMirada.iz: { mirarIZ(); break; }
            case Type_ladosMirada.der: { mirarDer(); break; }
        }
    }
    private void mirarIZ()
    {
        m_spriteRenderer.flipX= true;
    }
    private void mirarDer()
    {
        m_spriteRenderer.flipX = false;
    }
}
