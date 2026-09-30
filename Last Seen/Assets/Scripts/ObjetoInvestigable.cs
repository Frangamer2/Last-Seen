using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetoInvestigable : MonoBehaviour
{
    public string nombre;

    [TextArea(3, 6)]
    public string descripcion;

    [TextArea(3, 6)]
    public string pista;

    public PanelInvestigacion panelInvestigacion;

    private void OnMouseDown()
    {
        panelInvestigacion.MostrarObjeto(nombre, descripcion);
        panelInvestigacion.pistaActual = pista;
    }
}
