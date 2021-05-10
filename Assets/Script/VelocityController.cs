using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VelocityController : MonoBehaviour
{
    Rigidbody2D rb;
    public string groundType;
    
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
                rb.velocity = rb.velocity + new Vector2(-0.15f, -0.5f);
            }

            if (Input.GetKey(KeyCode.Space))
            {
                rb.velocity = rb.velocity + Vector2.up * 1f;
            }

        }
       
    }
}
