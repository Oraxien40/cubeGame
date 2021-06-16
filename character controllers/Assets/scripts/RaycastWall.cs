using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastWall : MonoBehaviour
{
    public CubeMovement2 CM2;
    void Start()
    {

    }

    
    void Update()
    {
        //RaycastHit
        //if raycast(start location, direction, where to store data, how long is it)
        RaycastHit wall;
        // NOTE!!!!!! change rotation of center to camera!!!!!!!!!!!!!!!!!!!!!!!!
        if (Physics.Raycast(CM2.center.transform.position, new Vector3 (0, Vector3.Angle(transform.position, CM2.North.transform.position), 0), out wall, Vector3.Distance(transform.position,CM2.North.transform.position)))
        {
            CM2.Ninput = false;
        }
        if (Physics.Raycast(CM2.center.transform.position, -transform.forward,out wall,1.1f))
        {
            CM2.Sinput = false;
        }
        if (Physics.Raycast(CM2.center.transform.position, transform.right,out wall, 1.1f))
        {
            CM2.Einput = false;
        }
        if (Physics.Raycast(CM2.center.transform.position, -transform.right,out wall, 1.1f))
        {
            CM2.Winput = false;
        }
    }
}
