using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ContadorIntentos : MonoBehaviour
{
    public TMP_Text Intentos;
    private int intentosActuales = 0;

    void Start()
    {
        GestorEventos.EventoMuerteJugador += aumentarIntentos;
    }

    private void aumentarIntentos()
    {
        intentosActuales += 1;
        Intentos.text = intentosActuales.ToString();
    }

    private void OnDestroy()
    {
        GestorEventos.EventoMuerteJugador -= aumentarIntentos;
    }
}
