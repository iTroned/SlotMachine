using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealSpin : MonoBehaviour
{

    public static int rotation = 0;
    private float spinSpeed = 400f;
    private float myRot;

    void Start()
    {
        myRot = 0;
   
    }


    void Update()
    {
        if (stop == false)
        {
            myRot += spinSpeed * Time.deltaTime;
            if (myRot >= 360)

            {

                myRot -= 360;

            }
        }
        
        if (stop == true)
        {
            StopAt(rotation);
            myRot = rotation;
        }
        if (stop == false)
        {
            NormalSpin();
        }
       
    }
   public static bool readyToStop = false;
   public static bool stop = false;

    float str = 0;

    float strenght = 2f;
    void NormalSpin()

    {

        transform.localRotation = Quaternion.Euler(-myRot, 0, 90);

    }


    void StopAt(int stopValue)

    {

        if (myRot < stopValue)

        {

            readyToStop = true;

        }

        if (readyToStop)

        {
           
            str = Mathf.Min(strenght * Time.deltaTime, 2);

            Quaternion target = Quaternion.Euler(-stopValue, 0, 90);

            transform.rotation = Quaternion.Lerp(transform.rotation, target, str);





        }
    }
}
