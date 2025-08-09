using packagePersona;
using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Controlador : MonoBehaviour
{
    public TMP_InputField inputCodigo;       
    public TMP_InputField inputCarrera;      
    public TMP_InputField inputNombre;       
    public TMP_InputField inputCorreo;       
    public TMP_InputField inputDireccion;    

    private List<Estudiante> listaEstudiantes = new List<Estudiante>();
    private string nombreArchivo = "estudiantes.json";

    public void GuardarEstudiante()
    {
        
        Estudiante estudiante = new Estudiante(
            inputCodigo.text,
            inputCarrera.text,
            inputNombre.text,
            inputCorreo.text,
            inputDireccion.text
        );

        
        listaEstudiantes.Add(estudiante);

        
        Utilidades.GuardarJSON(listaEstudiantes, nombreArchivo);

        Debug.Log("Estudiante guardado y registrado en JSON");

        
        LimpiarCampos();
    }

    private void LimpiarCampos()
    {
        inputCodigo.text = "";
        inputCarrera.text = "";
        inputNombre.text = "";
        inputCorreo.text = "";
        inputDireccion.text = "";
    }
}
