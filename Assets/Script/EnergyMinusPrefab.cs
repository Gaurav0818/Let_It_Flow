using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnergyMinusPrefab : MonoBehaviour
{
    public GameObject prefabFor1;
    public GameObject prefabFor2;
    public GameObject prefabFor5;

    GameObject for1;
    GameObject for2;
    GameObject for5;

    private void Start()
    {
        
    }


    private void Update()
    {
        if (for1 != null)
        {
            for1.transform.position = for1.transform.position + new Vector3(0f, 0.02f, 0f);
        }
        if (for2 != null)
        {
            for2.transform.position = for2.transform.position + new Vector3(0f, 0.02f, 0f);
        }
        if(for5 != null)
        {
            for5.transform.position = for5.transform.position + new Vector3(0f, 0.02f, 0f);
        }
    }
    public void InstantiateFor1()
    {
        for1 = Instantiate(prefabFor1);
        for1.transform.position = GameObject.Find("PlayerBody").transform.position + new Vector3(0f, 0.1f, 0f);
    }
    public void InstantiateFor2()
    {
        for2 = Instantiate(prefabFor2);
        for2.transform.position = GameObject.Find("PlayerBody").transform.position + new Vector3(0f, 0.1f, 0f);
    }
    public void InstantiateFor5()
    {
        for5 = Instantiate(prefabFor5);
        for5.transform.position = GameObject.Find("PlayerBody").transform.position + new Vector3(0f, 0.1f, 0f);
    }
}
