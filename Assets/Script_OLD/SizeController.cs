using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeController : MonoBehaviour
{
    float time=1000;
    private void Update()
    {
        time = time - Time.deltaTime;
        Debug.Log(time);
        if (time < 0)
        {
            gameObject.transform.localScale = gameObject.transform.localScale - new Vector3(0.1f, 0.1f, 0);
            time = 3;
        }
    }
}
