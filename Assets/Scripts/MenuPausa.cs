using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuPausa : MonoBehaviour
{
    public Button BotonPrincipal;
    public GameObject PanelOpciones;
    private bool menuAbierto = false;
    private bool puedePausar = true;

    private void Awake()
    {
        GestorEventos.EventoCompletarNivel += desactivarPausado;
    }

    private void OnDestroy() {
        GestorEventos.EventoCompletarNivel -= desactivarPausado;
    }

    private void desactivarPausado()
    {
        puedePausar = false;
    }

    private void Update()
    {
        if (puedePausar)
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
    }

    public void AbrirMenuOpciones()
    {
        BotonPrincipal.Select();
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
        SceneManager.LoadScene("MenuPrincipal");
    }
}
