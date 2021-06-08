using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : MonoBehaviour
{
    public GameObject player;
    public GameObject collectableScore;
    
    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("player colidded with collision box");
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("player colidded with collectable object");
        }
    }
}
