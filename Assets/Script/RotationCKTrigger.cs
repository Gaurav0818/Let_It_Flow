using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationCKTrigger : MonoBehaviour
{
    public bool triggeractive = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        triggeractive = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        triggeractive = false;   
    }
}
