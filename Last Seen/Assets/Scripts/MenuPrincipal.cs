
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene("Caso01");
    }

    public void Salir()
    {
        Application.Quit();
    }
}
