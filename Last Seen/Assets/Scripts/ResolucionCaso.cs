using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResolucionCaso : MonoBehaviour
{
    public GameObject panelResolucion;
    public GameObject mensajeCasoCompleto;

    public void AbrirResolucion()
    {
        panelResolucion.SetActive(true);

        if (mensajeCasoCompleto != null)
            mensajeCasoCompleto.SetActive(false);
    }

    public void CerrarResolucion()
    {
        panelResolucion.SetActive(false);
    }
}
