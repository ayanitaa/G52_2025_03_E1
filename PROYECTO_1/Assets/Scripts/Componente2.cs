using UnityEngine;
using System.Collections.Generic;
using packagePunto2D;

public class Componente2 : MonoBehaviour
{
    public List<Punto2D> puntos = new List<Punto2D>();

    private void Start()
    {
        // Inicializar algunos puntos
        puntos.Add(new Punto2D(1.0, 2.0));
        puntos.Add(new Punto2D(3.0, 4.0));
        puntos.Add(new Punto2D(5.0, 6.0));
        // Imprimir los puntos en la consola
        foreach (var punto in puntos)
        {
            Debug.Log($"Punto: ({punto.X}, {punto.Y})");
        }
    }
}

