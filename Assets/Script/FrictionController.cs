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
            rb.angularDrag = 1;
        }
        if (collision.gameObject.tag == "HF_Ground")
        {
            rb.angularDrag = 3;
        }
    }
}
