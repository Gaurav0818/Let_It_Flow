using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnergyMinusPrefab : MonoBehaviour
{
    float Destroytime = 0;
    private void Update()
    {
        Destroytime += Time.deltaTime;
        if (Destroytime > 1f)
        {
            Destroy(gameObject);
        }
    }
}
