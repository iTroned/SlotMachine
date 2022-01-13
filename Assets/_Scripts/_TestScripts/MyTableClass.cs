using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTableClass : MonoBehaviour
{
    public int[] array = new int[100];
    RandomClass rc;
    void Start()
    {
        rc = GameObject.Find("RandomClass").GetComponent<RandomClass>();
        for (int i = 0; i < 100; i++)
        {
            array[i] = rc.Generate();
        }
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < 100; i++)
            {
                array[i] = rc.Generate();
            }
        }
    }
}
