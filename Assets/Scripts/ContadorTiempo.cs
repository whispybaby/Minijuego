using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ContadorTiempo : MonoBehaviour
{
    public TMP_Text Contador;
    public static float Tiempo { get; private set; } = 0;
    public static float TiempoTotal { get; private set; } = 0;

    private void Awake()
    {
        GestorEventos.EventoMuerteJugador += aumentarTiempoTotal;
    }

    private void Start() {
        Tiempo = 0;
        TiempoTotal = 0;
    }

    private void OnDestroy()
    {
        GestorEventos.EventoMuerteJugador -= aumentarTiempoTotal;
    }

    private void aumentarTiempoTotal()
    {
        TiempoTotal += Tiempo;
        Tiempo = 0;
    }

    void Update()
    {
        Tiempo += Time.deltaTime;
        Contador.text = Tiempo.ToString("f0");
    }
}
