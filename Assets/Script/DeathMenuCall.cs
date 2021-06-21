using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathMenuCall : MonoBehaviour
{
    bool isdead;
    public float deathTime;
    float deathTimer = 0;

    public GameObject deathPrefab;
    GameObject deathpanal;
    public GameObject canvas;

    private void Update()
    {
        isdead = GetComponent<PlayerMovement>().isDead;

        if (isdead == true)
        {
            if (deathTimer < deathTime)
            {
                deathTimer = deathTimer + Time.deltaTime;
            }
            else
            {
                deathpanal = GameObject.Find("deathpanal");
                if (deathpanal == null)
                {
                    deathpanal = GameObject.Instantiate(deathPrefab, canvas.transform);
                    deathpanal.name = "deathpanal";
                }

            }

        }
    }
}
