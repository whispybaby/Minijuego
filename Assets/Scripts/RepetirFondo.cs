using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepetirFondo : MonoBehaviour
{
    private float longitud, posicionInicial;
    public Transform Camara;
    public float EfectoParalelo;

    void Start()
    {
        // Asigan las variables
        posicionInicial = transform.position.x;
        longitud = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    void Update()
    {
        // Mueve el fondo segun la posicion de la camara
        float distancia = (Camara.position.x * EfectoParalelo);
        transform.position = new Vector3(posicionInicial + distancia, Camara.position.y, transform.position.z);

        // Repite el fondo para que paresca infinito
        float temporal = (Camara.position.x * (1 - EfectoParalelo));
        if (temporal > posicionInicial + longitud)
        {
            posicionInicial += longitud;
        }
        else if (temporal < posicionInicial - longitud)
        {
            posicionInicial -= longitud;
        }
    }
}
