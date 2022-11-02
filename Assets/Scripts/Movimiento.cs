using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour

{
private Rigidbody2D rb;
public int Speed;
public int JumpSpeed;
public Transform GroundCheckTransform;
public float GroundCheckRadius;
public LayerMask GroundMask;
public Vector2 StartingPosition;
    //minisculas privadas y mayusculas publicas
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
    //Si pulsamos  Horizontal va a moverse en Horizontal
        float mover = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(mover * Speed ,rb.velocity.y );
        
        if (Input.GetButtonDown("Jump") && onGround())
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up * JumpSpeed, ForceMode2D.Impulse);
        }
    
    }
    public void resetPosition()
    {
        rb.velocity = Vector2.zero;
        transform.position = StartingPosition;
    }
    bool onGround()
    {
        return Physics2D.OverlapCircle(GroundCheckTransform.position, GroundCheckRadius, GroundMask);
    }
}
//rb.velocity.yprivate Rigidbody2D rb;
