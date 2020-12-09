using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public float speed;
    private float x_input, y_input;

    Rigidbody2D rb2d;
    public float jumpPower;
    bool isGrounded;

    public Transform groundCheck;
    public LayerMask groundLayer;

    // private void awake(){
    //     rb2d = GetComponent<Rigidbody2D>();
    // }

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded)
            {
                jump();
            }

            // jump();
        }
    }

    private void FixedUpdate()
    {

        x_input = Input.GetAxis("Horizontal");
        y_input = Input.GetAxis("Vertical");

        transform.Translate(x_input * speed, y_input * speed, 0);

        PlatformerMove();

        isGrounded = Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    void jump()
    {
        rb2d.velocity = (Vector2.up * jumpPower) / 2;
    }

    void PlatformerMove()
    {

        rb2d.velocity = new Vector2(speed * x_input, rb2d.velocity.y);
    }

}
