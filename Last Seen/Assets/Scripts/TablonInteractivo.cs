using UnityEngine;

public class TablonInteractivo : MonoBehaviour
{
    public GestorPistas gestorPistas;

    private void OnMouseDown()
    {
        gestorPistas.MostrarPistas();
    }
}