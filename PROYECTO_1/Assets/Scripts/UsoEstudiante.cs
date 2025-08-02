using UnityEngine;
using System;
using packagePersona;
using System.Collections.Generic;
public class UsoEstudiante : MonoBehaviour
{
    List <Estudiante> ListaE = new List <Estudiante> ();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Estudiante e1 = new Estudiante ("2025_23", "Ingeniería Multimedia", "David Castro", "dacastro@uao.edu.co",
            "carrera 24");

        Estudiante e2 = new Estudiante("2235319", "Ingeniería Multimedia", "Ayana Salazar", "ayana.salazar@uao.edu.co",
            "carrera 99b");

        ListaE.Add (e1);
        ListaE.Add (e2);

        for (int i = 0; i < ListaE.Count; i++)
        {
            ¨Debut.Log("name "+ListaE[i].NameP + "Carrera "+ListaE.NameCarreraE);
        }

    // Update is called once per frame
    void Update()
    {
        
    }
}
