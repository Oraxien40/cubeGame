using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    bool north = false;
    public int step = 0;

    void Start()
    {
        if (90 % step != 0)
        {
            Debug.LogError("your varible step is not divisivble by 90");
        }
    }

    // Update is called once per frame
    void Update()
    {
        /*float cameraAngle = Camera.main.transform.eulerAngles.y;
        if (cameraAngle > 315 && cameraAngle <= 360)
        {
            //set north
            north = true;
            Debug.Log("north");
        }
        /*else
        {
            north = false;
        }

        if (north == true)
        {
            print("i was used");
        }*/
    }
}
