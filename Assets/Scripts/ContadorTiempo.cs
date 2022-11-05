using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ContadorTiempo : MonoBehaviour
{
    public TMP_Text Contador;
    private float tiempo = 0;
    private float tiempoTotal = 0;

    private void Awake()
    {
        GestorEventos.EventoMuerteJugador += aumentarTiempoTotal;
    }

    private void aumentarTiempoTotal()
    {
        tiempoTotal += tiempo;
        tiempo = 0;
    }

    void Update()
    {
        tiempo += Time.deltaTime;
        Contador.text = tiempo.ToString("f0");
    }
}
