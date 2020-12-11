using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float moveSpeed;
    public float jumpForce;
    float xInput, yInput;

    Rigidbody2D rb;

    SpriteRenderer sp;

    bool isGrounded;

    public Transform groundCheck;

    public LayerMask groundlayer;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

        sp = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded)
            {
                Jump();
            }
        }
    }

    private void FixedUpdate()
    {
        xInput = Input.GetAxis("Horizontal");
        yInput = Input.GetAxis("Vertical");

        transform.Translate(xInput * moveSpeed, yInput * moveSpeed, 0);

        PlatformerMove();
        FlipPlayer();

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundlayer);
    }

    void Jump()
    {
        rb.velocity = Vector2.up * jumpForce;
    }

    void PlatformerMove()
    {
        rb.velocity = new Vector2(moveSpeed * xInput, rb.velocity.y);
    }

    void FlipPlayer()
    {
        if(rb.velocity.x < -0.05f)
        {
            sp.flipX = true;
        }
        else if(rb.velocity.x > 0.05f)
        {
            sp.flipX = false;
        }
    }
}
