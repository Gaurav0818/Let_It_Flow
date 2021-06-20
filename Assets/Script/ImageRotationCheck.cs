using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageRotationCheck : MonoBehaviour
{
    GameObject player;
    float horizontal;




    void Update()
    {
        player = GameObject.Find("PlayerBody");
        horizontal = player.GetComponent<PlayerMovement>().horizontal;

        if (horizontal > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (horizontal < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }

    }
}
