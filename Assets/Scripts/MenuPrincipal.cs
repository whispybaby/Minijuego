using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPrincipal : MonoBehaviour
{
    public GameObject PanelCreditos;

    public void CargarEscena(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }

    public void Cerrar()
    {
        Application.Quit();
    }

    public void AbrirCreditos()
    {
        PanelCreditos.SetActive(true);
    }

    public void CerrarCreditos()
    {
        PanelCreditos.SetActive(false);
    }

    public void CargarUrl(string url)
    {
        Application.OpenURL(url);
    }
}
