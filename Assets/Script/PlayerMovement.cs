using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D playerRB;

    public float speed;
    public float jumpSpeed;
    float horizontal;
    public float slopedownSpeed;

    bool isjump = false;
    bool isdash = false;
    bool canDash = true;

    public float dashTimeGap;
    float dashTimer=0;

    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        readupdate();
    }

    void FixedUpdate()
    {

        move();
        jump();
        dash();
        
    }

    void readupdate()
    {
        horizontal = 0;
        horizontal = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            isjump = true;
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            isdash = true;
        }

    }

    void move()
    {
        playerRB.velocity = new Vector2(playerRB.velocity.x + horizontal * speed * Time.deltaTime, playerRB.velocity.y );
    }

    void jump()
    {
        if (isjump == true)
        {
            if (FindObjectOfType<CheckGround>().IsGrounded()==true)
            {
                playerRB.velocity = Vector2.up * jumpSpeed;
            }
            isjump = false;
        }
   
    }

    void dash()
    {
        if(isdash == true)
        {
            
            isdash = false;
        }
    }

    void dashTime()
    {
        if (dashTimer == 0)
        {
            canDash = true;
            if (isdash == true)
            {

            }
        }

    }

}
