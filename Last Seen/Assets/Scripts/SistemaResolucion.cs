using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SistemaResolucion : MonoBehaviour
{
    public TMP_Dropdown dropdownPersonaje;
    public TMP_Dropdown dropdownSuceso;

    public GameObject panelResolucion;
    public GameObject panelResultado;

    public TMP_Text textoResultado;

    public void ConfirmarResolucion()
    {
        string personaje = dropdownPersonaje.options[dropdownPersonaje.value].text;
        string suceso = dropdownSuceso.options[dropdownSuceso.value].text;

        bool personajeCorrecto = personaje == "Empleado";
        bool sucesoCorrecto = suceso == "Estuvo en la oficina poco antes del incidente";

        if (personajeCorrecto && sucesoCorrecto)
        {
            textoResultado.text =
                "¡CASO RESUELTO!\n\n" +
                "Las pistas indican que el empleado estuvo " +
                "en la oficina poco antes del incidente.";
        }
        else
        {
            textoResultado.text =
                "La conexión no tiene sentido.\n\n" +
                "Revisa las pistas y vuelve a intentarlo.";
        }

        panelResultado.SetActive(true);
    }

    public void Volver()
    {
        panelResolucion.SetActive(false);
    }

    public void Reintentar()
    {
        panelResultado.SetActive(false);

        dropdownPersonaje.value = 0;
        dropdownSuceso.value = 0;

        dropdownPersonaje.RefreshShownValue();
        dropdownSuceso.RefreshShownValue();
    }

    public void Terminar()
    {
        Application.Quit();

        Debug.Log("Investigación terminada.");
    }
}
