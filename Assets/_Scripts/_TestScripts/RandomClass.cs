using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomClass : MonoBehaviour
{
    int num;
    void Start()
    {
        
    }

    
    void Update()
    {
       
    }
    
   public int Generate()
    {
        return Random.Range(1, 101); 
    }
}
