using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform playerMain;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y > -12.5f)
        {
            transform.position = new Vector3(transform.position.x, playerMain.position.y - (4), -1);
        }
        if (transform.position.x < 31)
        {
            transform.position = new Vector3(playerMain.position.x - (-8f), transform.position.y, -1);
        }

    }
}
