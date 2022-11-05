using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ContadorDiamantes : MonoBehaviour
{
    public TMP_Text Diamantes;
    private int diamantesConseguidos = 0;

    private void Awake()
    {
        GestorEventos.EventoObtenerDiamante += aumentarDiamantes;
        GestorEventos.EventoMuerteJugador += reiniciarDiamantes;
    }

    private void aumentarDiamantes()
    {
        diamantesConseguidos += 1;
        Diamantes.text = diamantesConseguidos.ToString();
    }

    private void reiniciarDiamantes()
    {
        diamantesConseguidos = 0;
        Diamantes.text = diamantesConseguidos.ToString();
    }

    private void OnDestroy()
    {
        GestorEventos.EventoObtenerDiamante -= aumentarDiamantes;
    }
}
