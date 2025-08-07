using UnityEngine;
using System.IO;
using System.Collections.Generic;
using packagePersona;
using packagePunto2D;

public static class Utilidades
{
    public static void GuardarEstudiantes(List<Estudiante> estudiantes, string repositorioJson)
    {
        ListaEstudiantesWrapper wrapper = new ListaEstudiantesWrapper();
        wrapper.Estudiantes = estudiantes;

        string json = JsonUtility.ToJson(wrapper, true);
        string rutaCompleta = Path.Combine(Application.persistentDataPath, repositorioJson);
        try
        {
            File.WriteAllText(rutaCompleta, json);
            Debug.Log($"Datos guardados correctamente en {rutaCompleta}");
        }
        catch (IOException e)
        {
            Debug.LogError($"Error al guardar los datos: {e.Message}");
        }
    }

    public static void GuardarPuntos(List<Punto2D> puntos, string repositorioJson)
    {
        ListaPuntosWrapper wrapper = new ListaPuntosWrapper();
        wrapper.Puntos = puntos;
        string json = JsonUtility.ToJson(wrapper, true);
        string rutaCompleta = Path.Combine(Application.persistentDataPath, repositorioJson);
        try
        {
            File.WriteAllText(rutaCompleta, json);
            Debug.Log($"Datos guardados correctamente en {rutaCompleta}");
        }
        catch (IOException e)
        {
            Debug.LogError($"Error al guardar los datos: {e.Message}");
        }
    }
    [System.Serializable]
    public class ListaEstudiantesWrapper
    {
        public List<Estudiante> Estudiantes;
    }
    [System.Serializable]
    public class ListaPuntosWrapper
    {
        public List<Punto2D> Puntos;
    }
}
