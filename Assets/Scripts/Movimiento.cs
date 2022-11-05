using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour

{
    private Rigidbody2D rb;
    private BoxCollider2D bc;
    public int Velocidad;
    public int VelocidadSalto;
    public LayerMask CapaPiso;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        bc = GetComponent<BoxCollider2D>();
    }

    void Update()
    {
        float movimiento = Input.GetAxis("Horizontal") * Velocidad;
        rb.velocity = new Vector2(movimiento, rb.velocity.y);

        if (Input.GetButtonDown("Jump") && enElPiso())
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up * VelocidadSalto, ForceMode2D.Impulse);
        }
    }

    private bool enElPiso()
    {
        return Physics2D.BoxCast(bc.bounds.center, bc.bounds.size, 0, Vector2.down, 0.1f, CapaPiso);
    }

    private void OnTriggerStay2D(Collider2D other) {
        if (other.gameObject.CompareTag("DobleSalto") && Input.GetButton("Jump"))
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up * VelocidadSalto * 60);
        }
    }
}
