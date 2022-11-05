using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamante : MonoBehaviour
{
    private void Awake()
    {
        GestorEventos.EventoMuerteJugador += reinvocarDiamante;
    }

    private void reinvocarDiamante()
    {
        if (!gameObject.activeInHierarchy)
        {
            gameObject.SetActive(true);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Llamar al evento, ejecutará todos los métodos suscritos.
            GestorEventos.IniciarEventoObtenerDiamante();

            // Ocultar el objeto actual de la escena.
            gameObject.SetActive(false);
        }
    }

    private void OnDestroy()
    {
        GestorEventos.EventoMuerteJugador -= reinvocarDiamante;
    }
}
