using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageRotationCheck : MonoBehaviour
{
    public GameObject player;



    public GameObject forup;
    public GameObject fordown;
    public GameObject forright;
    public GameObject forleft;

    public bool up;
    public bool down;
    public bool right;
    public bool left;
    float horizontal;




    void Update()
    {
        horizontal = player.GetComponent<PlayerMovement>().horizontal;
        

        if (horizontal > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (horizontal < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }

        /*
        up = forup.GetComponent<RotationCKTrigger>().triggeractive;
        down = fordown.GetComponent<RotationCKTrigger>().triggeractive;
        right = forright.GetComponent<RotationCKTrigger>().triggeractive;
        left = forleft.GetComponent<RotationCKTrigger>().triggeractive;

        if (down != true)
        {
            if (up == true)
            {
                transform.rotation = Quaternion.Euler(Vector3.forward * 120);
            }
            else if (right == true)
            {

            }
            else if(left == true)
            {

            }
        }*/
    }
}
