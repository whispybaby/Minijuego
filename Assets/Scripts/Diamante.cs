using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamante : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Llamar al evento, ejecutará todos los métodos suscritos.
            GestorEventos.IniciarEventoObtenerDiamante();

            // Eliminar el objeto actual de la escena.
            Destroy(gameObject);
        }
    }
}
