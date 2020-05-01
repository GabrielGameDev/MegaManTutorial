using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 5;

    public float jumpForce = 3;
    public float jumpHoldForce = 1;
    public float jumpHoldDuration = 0.15f;
    public bool isJumping;
    private float jumpTime;

    public float horizontal;
    public bool jumpHeld;
    private bool jumpStarted;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        GroundMovement();
        AirMovement();
    }

    void GroundMovement()
    {

        float xVelocity = speed * horizontal;

        rb.velocity = new Vector2(xVelocity, rb.velocity.y);
    }

    void AirMovement()
    {
        if (jumpStarted)
        {
            isJumping = true;
            jumpStarted = false;

            rb.velocity = Vector2.zero;

            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);

            jumpTime = Time.time + jumpHoldDuration;
        }
        if (isJumping)
        {
            if (jumpHeld)
            {
                rb.AddForce(Vector2.up * jumpHoldForce, ForceMode2D.Impulse);
            }

            if(jumpTime <= Time.time)
            {
                isJumping = false;
            }
        }

    }

    public void Move(InputAction.CallbackContext ctx)
    {
        horizontal = ctx.ReadValue<float>();
    }

    public void Jump(InputAction.CallbackContext ctx)
    {
        if (ctx.started)
        {
            jumpStarted = true;
        }

        jumpHeld = ctx.performed;
    }
}
