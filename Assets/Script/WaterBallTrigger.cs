using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterBallTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<PlayerMovement>().fillEnergy = true;
            destroyObject = true;
        }
    }

    float Destroytime = 0;
    public bool destroyObject = false;
    private void Update()
    {
        if( destroyObject == true)
        {
            Destroytime += Time.deltaTime;
            if (Destroytime > 0.3f)
            {
                Destroy(gameObject);
            }
        }

    }
}
