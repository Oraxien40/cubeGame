using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NorthPoint : MonoBehaviour
{
    private CubeMovement2 CM2;

    public bool NTrigger;
    void Awake()
    {
       CM2 = FindObjectOfType<CubeMovement2>();
    }
    void Update()
    {

    }
    void OnTriggerEnter(Collider NCollider)
    {
        Debug.Log("GameObject 'North'has been Triggered");
        if (NCollider.tag == "Wall")
        {
            NTrigger = true;
            CM2.UpdateWallTriggerNorth(NTrigger);
            Debug.Log("NTrigger 'true' was sent");
        }
        else
        {
            NTrigger = false;
            CM2.UpdateWallTriggerNorth(NTrigger);
            Debug.Log("NTrigger 'false' was sent");
        }
    }
}
