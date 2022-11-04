using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GestorEventos : MonoBehaviour
{
    // Declarar un evento para invocar al obtener un diamente.
    public static event Action EventoObtenerDiamante;
    public static event Action EventoCompletarNivel;
    public static event Action EventoMuerteJugador;

    // Método para ejecutar los métodos suscritos al evento.
    public static void IniciarEventoObtenerDiamante()
    {
        EventoObtenerDiamante?.Invoke();
    }

    // Arrancar los métodos suscritos al evento de completar nivel
    public static void IniciarEventoCompletarNivel()
    {
        EventoCompletarNivel?.Invoke();
    }

    public static void IniciarEventoMuerteJugador()
    {
        EventoMuerteJugador?.Invoke();
    }
}
