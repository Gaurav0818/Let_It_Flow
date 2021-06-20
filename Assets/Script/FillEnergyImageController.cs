using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillEnergyImageController : MonoBehaviour
{
    float Destroytime = 0;
    private void Update()
    {
        Destroytime += Time.deltaTime;
        if (Destroytime > 1.5f)
        {
            Destroy(gameObject);
        }
    }
}
