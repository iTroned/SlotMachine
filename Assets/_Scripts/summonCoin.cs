using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class summonCoin : MonoBehaviour
{
    
    public Rigidbody projectile;
    public GameObject drop;
  
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Summon(int coin)
    {
        Rigidbody clone;
        for (int i = 0; i < coin + 1; i++)
        {
            
                clone = Instantiate(projectile, drop.transform.position, Quaternion.identity);
                
           
        }
        

        
        
    }
}
