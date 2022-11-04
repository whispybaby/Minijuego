using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ContadorDiamantes : MonoBehaviour
{
    public TMP_Text Diamantes;
    private int diamantesConseguidos = 0;

    void Start()
    {
        GestorEventos.EventoObtenerDiamante += aumentarDiamantes;
    }

    private void aumentarDiamantes()
    {
        diamantesConseguidos += 1;
        Diamantes.text = diamantesConseguidos.ToString();
    }

    private void OnDestroy()
    {
        GestorEventos.EventoObtenerDiamante -= aumentarDiamantes;
    }
}
