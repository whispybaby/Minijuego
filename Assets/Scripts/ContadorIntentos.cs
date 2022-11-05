using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ContadorIntentos : MonoBehaviour
{
    public TMP_Text Intentos;
    public static int IntentosActuales { get; private set; } = 0;

    private void Start() {
        IntentosActuales = 0;
    }

    private void Awake()
    {
        GestorEventos.EventoMuerteJugador += aumentarIntentos;
    }

    private void aumentarIntentos()
    {
        IntentosActuales += 1;
        Intentos.text = IntentosActuales.ToString();
    }

    private void OnDestroy()
    {
        GestorEventos.EventoMuerteJugador -= aumentarIntentos;
    }
}
