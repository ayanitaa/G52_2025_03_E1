using System.Collections.Generic;
using UnityEngine;
using packagePunto2D;
using TMPro;

public class ControladorPuntos : MonoBehaviour
{
    [Header("Campos de entrada para las coordenadas")]
    public TMP_InputField inputX;
    public TMP_InputField inputY;


    [Header("Lista de puntos cargados")]
    [SerializeField]
    private List<Punto2D> listaPuntos = new List<Punto2D>();

    private string nombreArchivo = "puntos2d.json";

    private void Start()
    {
        var datosCargados = Utilidades.CargarJSON<List<Punto2D>>(nombreArchivo);
        if (datosCargados != null)
        {
            listaPuntos = datosCargados;
            Debug.Log($"Se cargaron {listaPuntos.Count} puntos.");
        }
        else
        {
            Debug.Log("No se encontraron puntos previos, lista vacía.");
        }
    }

    public void AgregarPunto()
    {
        if (double.TryParse(inputX.text, out double x) && double.TryParse(inputY.text, out double y))
        {
            Punto2D nuevoPunto = new Punto2D(x, y);
            listaPuntos.Add(nuevoPunto);
            Utilidades.GuardarJSON(listaPuntos, nombreArchivo);
            Debug.Log($"Punto ({x}, {y}) agregado y guardado.");

            // Limpiar campos
            inputX.text = "";
            inputY.text = "";
        }
        else
        {
            Debug.LogWarning("Entrada inválida. Por favor ingresa números válidos para X y Y.");
        }
    }

}
