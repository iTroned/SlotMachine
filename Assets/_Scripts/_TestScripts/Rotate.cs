using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
   
    RotateManager rm;
    void Start()
    {
        rm = GameObject.Find("RotateManager").GetComponent<RotateManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right * Time.deltaTime * rm.GetSpeed());
       
        transform.Rotate(Vector3.up * Time.deltaTime * rm.GetSpeed());

    }
}

