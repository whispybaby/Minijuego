using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GestorEventos : MonoBehaviour
{
    // Declarar un evento para invocar al obtener un diamente.
    public static event Action EventoObtenerDiamante;

    // Método para ejecutar los métodos suscritos al evento.
    public static void IniciarEventoObtenerDiamante()
    {
        EventoObtenerDiamante?.Invoke();
    }
}
