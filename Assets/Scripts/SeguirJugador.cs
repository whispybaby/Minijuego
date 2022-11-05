using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirJugador : MonoBehaviour
{
    public Transform Jugador;

    void Update()
    {
        transform.position = new Vector3(Jugador.position.x, transform.position.y, transform.position.z);
    }
}
