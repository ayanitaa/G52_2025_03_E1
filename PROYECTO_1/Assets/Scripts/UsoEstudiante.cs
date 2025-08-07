using packagePersona;
using packagePunto2D;
using System;
using System.Collections.Generic;
using UnityEngine;

public class UsoEstudiante : MonoBehaviour
{

    List<Estudiante> ListaE = new List<Estudiante>();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Estudiante e1 = new Estudiante("2025_23", "Ingeniería Multimedia", "David Castro", "dacastro@uao.edu.co",
            "carrera 24");

        Estudiante e2 = new Estudiante("2235319", "Ingeniería Multimedia", "Ayana Salazar", "ayana.salazar@uao.edu.co",
            "carrera 99b");

        ListaE.Add(e1);
        ListaE.Add(e2);
    

    for (int i = 0; i < ListaE.Count; i++)
        {
             Debug.Log ("Name "+ListaE [i].NameP + "Carrera "+ListaE[i].NameECarrera);
        }

        Utilidades.GuardarEstudiantes(ListaE, "estudiantes.json");
        List<Punto2D> puntos = new List<packagePunto2D.Punto2D>
        {
           new Punto2D(1.5, 2.3),
           new Punto2D(9.6, 2.0)

        };
        // Guardar los puntos en un archivo JSON
        Utilidades.GuardarPuntos(puntos, "puntos.json");


    // Update is called once per frame
    void Update()
        {

        }
    }
}
