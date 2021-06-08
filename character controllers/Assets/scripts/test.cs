using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    private bool north = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float cameraAngle = Camera.main.transform.eulerAngles.y;
        if (cameraAngle > 315 && cameraAngle <= 360)
        {
            //set north
            north = true;
            Debug.Log("north");
        }
        /*else
        {
            north = false;
        }*/

        if (north == true)
        {
            print("i was used");
        }
    }
}
