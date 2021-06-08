using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrictionController : MonoBehaviour
{
    Rigidbody2D rb;
    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "N_Ground")
        {
            FindObjectOfType<VelocityController>().groundType = "N_Ground";
            rb.drag = 0.5f;
        }
        if (collision.gameObject.tag == "HF_Ground")
        {
            FindObjectOfType<VelocityController>().groundType = "HF_Ground";
            rb.drag = 3;
        }
    }
}
