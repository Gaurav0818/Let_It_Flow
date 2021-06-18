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
            //playerRB.velocity = new Vector2(playerRB.velocity.x + horizontal * dashSpeed * Time.deltaTime, playerRB.velocity.y);
            isdash = true;
        }

    }

    void move()
    {
        if (speedBoostTimer < speedBoostTime && dashDir==horizontal)
        {
            speedBoostTimer = speedBoostTimer + Time.deltaTime;
            playerRB.velocity = new Vector2(playerRB.velocity.x + horizontal *4* speed * Time.deltaTime, playerRB.velocity.y);
        }
        else
        {
            playerRB.velocity = new Vector2(playerRB.velocity.x + horizontal * speed * Time.deltaTime, playerRB.velocity.y);
        }
       
    }

    void jump()
    {
        if (isjump == true)
        {
            if (FindObjectOfType<CheckGround>().IsGrounded()==true)
            {
                playerRB.velocity = playerRB.velocity+ Vector2.up * jumpSpeed;
            }
            isjump = false;
        }
   
    }

    bool isdash = false;
    bool canDash = true;
    bool startDashTime = false;

    public float speedBoostTime;
    float speedBoostTimer=5;
    float dashDir;
    public float dashSpeed;
    public float dashTimeGap;
    float dashTimer = 0f;

    void dash()
    {
        if(isdash == true)
        {
            if (canDash == true)
            {
                playerRB.velocity = new Vector2(playerRB.velocity.x + horizontal * dashSpeed * Time.deltaTime, playerRB.velocity.y);
                startDashTime = true;
                speedBoostTimer = 0;
                dashDir = horizontal;
            }
            
            isdash = false;
        }
    }

    void dashTime()
    {
        if (dashTimer == 0f)
        {
            canDash = true;


        }
        if (startDashTime == true)
        {
            canDash = false;

            if (dashTimer < dashTimeGap)
            {
                dashTimer = dashTimer + Time.deltaTime;
            }
            else
            {
                dashTimer = 0f;
                startDashTime = false;
            } 
        }

    }

}
