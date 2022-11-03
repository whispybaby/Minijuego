using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject PanelOpciones;
    private bool menuAbierto = false;

    private void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            if (menuAbierto)
            {
                CerrarMenuOpciones();
            }
            else
            {
                AbrirMenuOpciones();
            }
        }
    }

    public void AbrirMenuOpciones()
    {
        menuAbierto = true;
        Time.timeScale = 0;
        PanelOpciones.SetActive(true);
    }

    public void CerrarMenuOpciones()
    {
        menuAbierto = false;
        Time.timeScale = 1;
        PanelOpciones.SetActive(false);
    }

    public void IrAlMenuPrincipal()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MainMenu");
    }
}
