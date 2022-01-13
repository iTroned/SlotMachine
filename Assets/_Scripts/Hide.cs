using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hide : MonoBehaviour
{
    public static bool checkGameOver;
    public GameObject realButton;
    // Start is called before the first frame update
  
    

    void Start()
    {
 
        hide();
    }

   
    // Update is called once per frame
    void Update()
    {
        if (checkGameOver == true)
        {
            realButton.gameObject.SetActive(true);
        }
        
    }
   public void hide()
    {
       realButton.gameObject.SetActive(false);
        checkGameOver = false;
        credits.GameOver = false;
        credits.credit = 3;
       
    }
}
