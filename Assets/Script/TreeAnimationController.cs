using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeAnimationController : MonoBehaviour
{
    public Animator animator;
    public bool lvlup;
    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void Update()
    {
        if (lvlup == true)
        {
            animator.SetBool("lvlUp", true);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<PlayerMovement>().enabled = false;
            collision.GetComponent<JustJump>().enabled = true;
            lvlup = true;
            GameObject.Find("Main Camera").GetComponent<FallowPlayer>().enabled = false;
        }
    }
}
