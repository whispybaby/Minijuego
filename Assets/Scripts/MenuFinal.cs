using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class MenuFinal : MonoBehaviour
{
    public GameObject PanelFinalNivel;
    public Button BotonMenuPrincipal;
    public TMP_Text TextoIntentos;
    public TMP_Text TextoDiamantes;
    public TMP_Text TextoTiempo;

    private void Awake()
    {
        GestorEventos.EventoCompletarNivel += AbrirMenuFinal;
    }

    private void OnDestroy()
    {
        GestorEventos.EventoCompletarNivel -= AbrirMenuFinal;
    }

    private void actulizarUI()
    {
        float tiempo = ContadorTiempo.TiempoTotal + ContadorTiempo.Tiempo;
        TextoTiempo.text = tiempo.ToString("f0");

        int intentos = ContadorIntentos.IntentosActuales;
        TextoIntentos.text = intentos.ToString();

        int diamantes = ContadorDiamantes.DiamantesConseguidos;
        TextoDiamantes.text = diamantes.ToString();
    }

    public void AbrirMenuFinal()
    {
        actulizarUI();
        BotonMenuPrincipal.Select();
        Time.timeScale = 0;
        PanelFinalNivel.SetActive(true);
    }

    public void ReiniciarNivel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void IrAlMenuPrincipal()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MenuPrincipal");
    }
}
