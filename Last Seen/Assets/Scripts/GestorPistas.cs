using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GestorPistas : MonoBehaviour
{
    public GameObject panelPistas;
    public Transform contenedorPistas;
    public GameObject textoPistaPrefab;

    [Header("Caso")]
    public int pistasNecesarias = 5;
    public GameObject mensajeCasoCompleto;

    private List<string> pistasEncontradas = new List<string>();

    public void AgregarPista(string pista)
    {
        if (pistasEncontradas.Contains(pista))
            return;

        pistasEncontradas.Add(pista);

        GameObject nuevaPista = Instantiate(textoPistaPrefab, contenedorPistas);

        TMP_Text texto = nuevaPista.GetComponent<TMP_Text>();
        texto.text = "• " + pista;

        if (pistasEncontradas.Count >= pistasNecesarias)
        {
            CasoCompletado();
        }
    }

    private void CasoCompletado()
    {
        if (mensajeCasoCompleto != null)
        {
            mensajeCasoCompleto.SetActive(true);
        }
    }

    public void MostrarPistas()
    {
        panelPistas.SetActive(true);
    }

    public void OcultarPistas()
    {
        panelPistas.SetActive(false);
    }
}
