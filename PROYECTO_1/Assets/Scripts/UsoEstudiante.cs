using System.Collections.Generic;
using UnityEngine;
using packagePersona;  
using packagePunto2D; 

public class UsoEstudiante : MonoBehaviour
{
    
    [Header("Datos del nuevo estudiante")]
    public string codigo;
    public string carrera;
    public string nombre;
    public string correo;
    public string direccion;

    private List<Estudiante> listaEstudiantes = new List<Estudiante>();
    private string nombreArchivo = "estudiantes.json";

    
    void Start()
    {
        var datosCargados = Utilidades.CargarJSON<List<Estudiante>>(nombreArchivo);
        if (datosCargados != null)
        {
            listaEstudiantes = datosCargados;
            Debug.Log($"Se cargaron {listaEstudiantes.Count} estudiantes.");
        }
        else
        {
            Debug.Log("No se encontraron estudiantes previos, lista vacía.");
        }
    }

    // Método para agregar un estudiante nuevo
    public void AgregarEstudiante()
    {
        Estudiante nuevo = new Estudiante(codigo, carrera, nombre, correo, direccion);

        listaEstudiantes.Add(nuevo);
        Utilidades.GuardarJSON(listaEstudiantes, nombreArchivo);

        Debug.Log($"Estudiante {nombre} agregado y guardado.");
    }
}
