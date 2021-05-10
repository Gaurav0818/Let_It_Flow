using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGround : MonoBehaviour
{
    public LayerMask groundLayer;
    public float angle1;
    public float angle2;
    public bool IsGrounded()
    {
        Vector2 position = transform.position;
        Vector2 direction = Vector2.down;
        float distance = 1.0f;
        Vector2 direction1 = new Vector2(Mathf.Cos(angle1 * Mathf.Deg2Rad), Mathf.Sin(angle1 * Mathf.Deg2Rad)).normalized;
        Vector2 direction2 = new Vector2(Mathf.Cos(angle2 * Mathf.Deg2Rad), Mathf.Sin(angle2 * Mathf.Deg2Rad)).normalized;

        RaycastHit2D hit = Physics2D.Raycast(position, direction, distance, groundLayer);
        RaycastHit2D hit1 = Physics2D.Raycast(position, direction1, distance, groundLayer);
        RaycastHit2D hit2 = Physics2D.Raycast(position, direction2, distance, groundLayer);

        if (hit.collider != null)
        {
            return true;
        }
        else if (hit1.collider != null)
        {
            return true;
        }
        else if (hit2.collider != null)
        {
            return true;
        }
        return false;
    }
}
