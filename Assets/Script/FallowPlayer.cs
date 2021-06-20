using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallowPlayer : MonoBehaviour
{
    GameObject player;
    public float Xmax;
    public float Ymax;
    public float Xmin;
    public float Ymin;
    public float Yextra;
    
    void Start()
    {
        player = GameObject.Find("PlayerBody");
    }

    
    void Update()
    {
        if (gameObject.tag == "Image")
        {
            transform.position = new Vector3(player.transform.position.x, player.transform.position.y-0.1f, 0f);
        }
        else
        {
            if (player.transform.position.x > Xmax )
            {
                if (player.transform.position.y > Ymax)
                {
                    transform.position = new Vector3(Xmax, Ymax + Yextra, -10f);
                }
                else if (player.transform.position.y < Ymin)
                {
                    transform.position = new Vector3(Xmax, Ymin + Yextra, -10f);
                }
                else
                {
                    transform.position = new Vector3(Xmax, player.transform.position.y + Yextra, -10f);
                }
            }
            else if (player.transform.position.x < Xmin)
            {
                if (player.transform.position.y > Ymax)
                {
                    transform.position = new Vector3(Xmin, Ymax + Yextra, -10f);
                }
                else if (player.transform.position.y < Ymin)
                {
                    transform.position = new Vector3(Xmin, Ymin + Yextra, -10f);
                }
                else
                {
                    transform.position = new Vector3(Xmin, player.transform.position.y + Yextra, -10f);
                }
            }
            else
            {
                if (player.transform.position.y > Ymax )
                {
                    transform.position = new Vector3(player.transform.position.x, Ymax + Yextra, -10f);
                }
                else if (player.transform.position.y < Ymin)
                {
                    transform.position = new Vector3(player.transform.position.x, Ymin + Yextra, -10f);
                }
                else
                {
                    transform.position = new Vector3(player.transform.position.x, player.transform.position.y + Yextra, -10f);
                }
            }
        }
    }
}
