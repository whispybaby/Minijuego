using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ContadorDiamantes : MonoBehaviour
{
    public TMP_Text Diamantes;
    public static int DiamantesConseguidos { get; private set; } = 0;

    private void Start() {
        DiamantesConseguidos = 0;
    }

    private void Awake()
    {
        GestorEventos.EventoObtenerDiamante += aumentarDiamantes;
        GestorEventos.EventoMuerteJugador += reiniciarDiamantes;
    }

    private void aumentarDiamantes()
    {
        DiamantesConseguidos += 1;
        Diamantes.text = DiamantesConseguidos.ToString();
    }

    private void reiniciarDiamantes()
    {
        DiamantesConseguidos = 0;
        Diamantes.text = DiamantesConseguidos.ToString();
    }

    private void OnDestroy()
    {
        GestorEventos.EventoObtenerDiamante -= aumentarDiamantes;
    }
}
