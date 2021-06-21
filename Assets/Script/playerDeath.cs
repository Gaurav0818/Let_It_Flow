using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDeath : MonoBehaviour
{
    public Animator animator;

    private void Start()
    {
        animator = GameObject.Find("PlayerImage").GetComponent<Animator>();
    }
    private void Update()
    {
        if (FindObjectOfType<PlayerMovement>().isDead == true)
        {
            animator.SetBool("isDead", true);
        }
    }
}
