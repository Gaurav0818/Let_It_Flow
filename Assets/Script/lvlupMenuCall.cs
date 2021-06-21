using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lvlupMenuCall : MonoBehaviour
{
    bool lvlup;
    public float lvlupTime;
    float lvluptimer=0;

    public GameObject lvlupPrefab;
    GameObject lvluppanal;
    public GameObject canvas;

    private void Update()
    {
        lvlup = GetComponent<TreeAnimationController>().lvlup;
        
        if (lvlup == true)
        {
            if (lvluptimer < lvlupTime)
            {
                lvluptimer = lvluptimer + Time.deltaTime;
            }
            else
            {
                lvluppanal = GameObject.Find("Lvluppanal");
                if (lvluppanal == null)
                {
                    lvluppanal = GameObject.Instantiate(lvlupPrefab, canvas.transform);
                    lvluppanal.name = "Lvluppanal";
                }

            }

        }
    }
}
