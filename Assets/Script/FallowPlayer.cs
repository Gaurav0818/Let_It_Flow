using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallowPlayer : MonoBehaviour
{
    GameObject player;
    
    void Start()
    {
        player = GameObject.Find("Circle");
    }

    
    void Update()
    {
        if (gameObject.tag == "Image")
        {
            transform.position = new Vector3(player.transform.position.x, player.transform.position.y-0.1f, 0f);
        }
        else
        {
            transform.position = new Vector3(player.transform.position.x, player.transform.position.y+ 3f, -10f);
        }
 
    }
}
