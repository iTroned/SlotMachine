using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    private int num;
    void Start()
    {
        num = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void left()
    {
        if (num > -1)
        {
            transform.Translate(Vector3.left * 60);
            num = num - 1;
        }
    }

    public void right()
    {
        if (num < 1)
        {
            transform.Translate(Vector3.right * 60);
            num = num + 1;
        }
    }
}
