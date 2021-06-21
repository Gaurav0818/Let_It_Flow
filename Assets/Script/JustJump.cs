using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JustJump : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpSpeed;
    float jumptimer = 0;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        rb.velocity = new Vector2(0f, rb.velocity.y);
        if (jumptimer > 1f)
        {
            rb.velocity = Vector2.up * jumpSpeed;
            jumptimer = 0;
        }
        jumptimer = jumptimer + Time.deltaTime;
    }
}
