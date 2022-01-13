using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealSpin2 : MonoBehaviour
{
    public static int rotation1 = 0;
    private float spinSpeed = 400f;
    private float myRot = 0;

    void Start()
    {

    }


    void Update()
    {
        if (stop == false)
        {
            myRot += spinSpeed * Time.deltaTime;
        }
        if (myRot >= 360 && stop == false)

        {

            myRot -= 360;

        }
        if (stop == true)
        {
            StopAt(rotation1);
            myRot = rotation1;
        }
        if (stop == false)
        {
            NormalSpin();
        }

    }
    public static bool readyToStop = false;
    public static bool stop = false;

    float str = 0;

    float strenght = 1f;
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
            
            str = Mathf.Min(strenght * Time.deltaTime, 1);

            Quaternion target = Quaternion.Euler(-stopValue, 0, 90);

            transform.rotation = Quaternion.Lerp(transform.rotation, target, str);



        }
    }

}
