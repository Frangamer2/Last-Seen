using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PanelInvestigacion : MonoBehaviour
{
    public GameObject panel;

    public TMP_Text textoNombre;
    public TMP_Text textoDescripcion;
    public TMP_Text textoPista;

    public GameObject botonInvestigar;

    public GestorPistas gestorPistas;

    [HideInInspector]
    public string pistaActual;

    public void MostrarObjeto(string nombre, string descripcion)
    {
        panel.SetActive(true);

        textoNombre.text = nombre;
        textoDescripcion.text = descripcion;

        textoPista.text = "";

        botonInvestigar.SetActive(true);
    }

    public void Investigar()
    {
        textoPista.text = pistaActual;

        gestorPistas.AgregarPista(pistaActual);

        botonInvestigar.SetActive(false);
    }

    public void CerrarPanel()
    {
        panel.SetActive(false);
    }
}
