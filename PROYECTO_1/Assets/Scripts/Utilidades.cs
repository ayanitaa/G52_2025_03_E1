using UnityEngine;
using System.IO;

public static class Utilidades
{
    private static string rutaBase = Path.Combine(
        Application.persistentDataPath, "RepositorioJSON");

    public static void GuardarJSON<T>(T objeto, string nombreArchivo)
    {
        Directory.CreateDirectory(rutaBase); // crea la carpeta si no existe

        if (!nombreArchivo.EndsWith(".json"))
            nombreArchivo += ".json";

        string ruta = Path.Combine(rutaBase, nombreArchivo);
        string json = JsonUtility.ToJson(objeto, true);

        File.WriteAllText(ruta, json);
        Debug.Log($"Datos guardados en: {ruta}");
    }

    public static T CargarJSON<T>(string nombreArchivo)
    {
        if (!nombreArchivo.EndsWith(".json"))
            nombreArchivo += ".json";

        string ruta = Path.Combine(rutaBase, nombreArchivo);

        if (File.Exists(ruta))
        {
            string json = File.ReadAllText(ruta);
            return JsonUtility.FromJson<T>(json);
        }
        else
        {
            Debug.LogWarning($"No se encontró el archivo: {ruta}");
            return default(T);
        }
    }
}

