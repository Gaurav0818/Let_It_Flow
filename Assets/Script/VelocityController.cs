using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityController : MonoBehaviour
{
    Rigidbody2D rb;
    public string groundType;
    public float dashSpeed;
    public float dashTime;
    float startDash_Time;
    Vector2 oldspeed;
    int dir;
    bool ifDash;
    int dashCount=0;
    
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        
        if (FindObjectOfType<CheckGround>().IsGrounded() == true)
        {
            if (Input.GetKey(KeyCode.D))
            {
                dir = 1; // right dir
                if (groundType == "N_Ground")
                {
                    rb.velocity = rb.velocity + new Vector2(0.15f, -0.5f);
                }
                else if (groundType == "HF_Ground")
                {
                    rb.velocity = rb.velocity + new Vector2(0.1f, 0);
                }
            }
            if (Input.GetKey(KeyCode.A))
            {
                dir = 2; // left dir
                rb.velocity = rb.velocity + new Vector2(-0.15f, -0.5f);
            }

            if (Input.GetKey(KeyCode.Space))
            {
                rb.velocity = rb.velocity + Vector2.up * 1f;
            }

        }


        if (Input.GetKeyDown(KeyCode.LeftShift) && dashCount==0)
        {
            dashCount = 1;
            startDash_Time=0;
            ifDash = true;
            oldspeed.x = rb.velocity.x;

            if (dir == 1)
            {
                rb.velocity = rb.velocity + new Vector2(30f, 0);   /*Vector2.right * dashSpeed*/
            }
            if (dir == 2)
            {
                rb.velocity = rb.velocity + new Vector2(-30f, 0);   /* + Vector2.left * dashSpeed;*/
            }

            /*startDash_Time = startDash_Time + Time.deltaTime;
            if (startDash_Time > dashTime)
            {
                rb.velocity = oldspeed;
            }*/
            
        }
        if (dashCount == 1)
        {
            startDash_Time = startDash_Time + Time.deltaTime;
            if (ifDash == true)
            {
                if (startDash_Time > dashTime)
                {
                    rb.velocity = new Vector2(oldspeed.x * 2, 0.1f);
                    ifDash = false;
                }
            }
            if (startDash_Time > 2f)
            {
                dashCount = 0;
            }
        }

    }
}
