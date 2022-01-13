using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayTests : MonoBehaviour
{
    public float[] values;
    public float[] values2;
    private int ran;
    private int ran2;
    void Start()
    {
        values = new float[6];
        values[1] = 1;
        values[2] = 2;
        values[3] = 3;
        values[4] = 4;
        values[5] = 5;
        ran = Random.Range(1, 5);
        values2 = new float[6];
        values2[1] = 1;
        values2[2] = 2;
        values2[3] = 3;
        values2[4] = 4;
        values2[5] = 5;
        ran2 = Random.Range(1, 5);

        print(values[ran] + values2[ran2]);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){
            ran = Random.Range(1, 5);
            ran2 = Random.Range(1, 5);
            print(values[ran] + values2[ran2]);

        }
    }
}
