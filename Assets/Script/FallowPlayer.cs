﻿using System.Collections;
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
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y,-10f);
    }
}
