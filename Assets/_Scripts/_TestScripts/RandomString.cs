using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RandomString : MonoBehaviour
{
    string lol = "Hei";
    public TextMeshProUGUI myBox;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Endre()
    {
        myBox.text = lol;
    }

}
