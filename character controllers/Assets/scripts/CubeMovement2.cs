using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement2 : MonoBehaviour
{
    private Vector3 offset;

    public GameObject player;
    public GameObject center;
   
    public GameObject North;
    public GameObject NUp;
    public GameObject NDown;
    
    public GameObject South;
    public GameObject SUp;
    public GameObject SDown;
    
    public GameObject East;
    public GameObject EUp;
    public GameObject EDown;
    
    public GameObject West;
    public GameObject WUp;
    public GameObject WDown;

    public int step = 9;

    public float speed = (float)0.01;

    //public int JumpForce = 0;
    //private Rigidbody mrigidbody;

    bool cNorth = false;
    bool cSouth = false;
    bool cEast = false;
    bool cWest = false;

    [HideInInspector] public bool moveUpUsed = false;
    [HideInInspector] public bool moveDownUsed = false;
    [HideInInspector] public bool moveLeftUsed = false;
    [HideInInspector] public bool moveRightUsed = false;

    [HideInInspector] public bool Ninput = true;
    [HideInInspector] public bool Sinput = true;
    [HideInInspector] public bool Einput = true;
    [HideInInspector] public bool Winput = true;
    [HideInInspector] public bool OFFinput = true;

    void Start()
    {
        //mrigidbody = GetComponent<Rigidbody>();

    }


    void Update()
    {
        if (OFFinput == true)
        {
            float cameraAngle = Camera.main.transform.eulerAngles.y;
            if (cameraAngle > 315 && cameraAngle <= 360 || cameraAngle > 0 && cameraAngle <= 45)
            {
                //set north
                cNorth = true;
                //Debug.Log("north");
            }
            else
            {
                cNorth = false;
            }

            if (cameraAngle > 45 && cameraAngle <= 135)
            {
                //set east
                cEast = true;
                //Debug.Log("east");
            }
            else
            {
                cEast = false;
            }

            if (cameraAngle > 135 && cameraAngle <= 225)
            {
                //set south
                cSouth = true;
                //Debug.Log("south");
            }
            else
            {
                cSouth = false;
            }

            if (cameraAngle > 225 && cameraAngle <= 315)
            {
                //set west
                cWest = true;
                //Debug.Log("west");
            }
            else
            {
                cWest = false;
            }
        }
        

        if (cNorth == true)
        {
            if (Ninput == true)
            {
                if (Input.GetKey(KeyCode.W))
                {
                    if ((Input.GetKey(KeyCode.D) == false) && (Input.GetKey(KeyCode.A) == false) && (Input.GetKey(KeyCode.S) == false))
                    {
                        StartCoroutine(moveUp());
                        Ninput = false;
                    }
                }
                else if (Input.GetKey(KeyCode.D))
                {
                    if ((Input.GetKey(KeyCode.W) == false) && (Input.GetKey(KeyCode.S) == false) && (Input.GetKey(KeyCode.A) == false))
                    {
                        StartCoroutine(moveRight());
                        Ninput = false;
                    }
                }
                else if (Input.GetKey(KeyCode.S))
                {
                    if ((Input.GetKey(KeyCode.D) == false) && (Input.GetKey(KeyCode.A) == false) && (Input.GetKey(KeyCode.W) == false))
                    {
                        StartCoroutine(moveDown());
                        Ninput = false;
                    }
                }
                else if (Input.GetKey(KeyCode.A))
                {
                    if ((Input.GetKey(KeyCode.D) == false) && (Input.GetKey(KeyCode.W) == false) && (Input.GetKey(KeyCode.S) == false))
                    {
                        StartCoroutine(moveLeft());
                        Ninput = false;
                    }
                }
            }
        }

        else if (cEast == true)
        {
            if (Einput == true)
            {
                if (Input.GetKey(KeyCode.W))
                {
                    if ((Input.GetKey(KeyCode.D) == false) && (Input.GetKey(KeyCode.A) == false) && (Input.GetKey(KeyCode.S) == false))
                    {
                        StartCoroutine(moveRight());
                        Einput = false;
                    }
                }
                else if (Input.GetKey(KeyCode.D))
                {
                    if ((Input.GetKey(KeyCode.W) == false) && (Input.GetKey(KeyCode.S) == false) && (Input.GetKey(KeyCode.A) == false))
                    {
                        StartCoroutine(moveDown());
                        Einput = false;
                    }
                }
                else if (Input.GetKey(KeyCode.S))
                {
                    if ((Input.GetKey(KeyCode.D) == false) && (Input.GetKey(KeyCode.A) == false) && (Input.GetKey(KeyCode.W) == false))
                    {
                        StartCoroutine(moveLeft());
                        Einput = false;
                    }
                }
                else if (Input.GetKey(KeyCode.A))
                {
                    if ((Input.GetKey(KeyCode.D) == false) && (Input.GetKey(KeyCode.W) == false) && (Input.GetKey(KeyCode.S) == false))
                    {
                        StartCoroutine(moveUp());
                        Einput = false;
                    }
                }
            }
        }

        else if (cSouth == true)
        {
            if (Sinput == true)
            {
                if (Input.GetKey(KeyCode.W))
                {
                    if ((Input.GetKey(KeyCode.D) == false) && (Input.GetKey(KeyCode.A) == false) && (Input.GetKey(KeyCode.S) == false))
                    {
                        StartCoroutine(moveDown());
                        Sinput = false;
                    }
                }
                else if (Input.GetKey(KeyCode.D))
                {
                    if ((Input.GetKey(KeyCode.W) == false) && (Input.GetKey(KeyCode.S) == false) && (Input.GetKey(KeyCode.A) == false))
                    {
                        StartCoroutine(moveLeft());
                        Sinput = false;
                    }
                }
                else if (Input.GetKey(KeyCode.S))
                {
                    if ((Input.GetKey(KeyCode.D) == false) && (Input.GetKey(KeyCode.A) == false) && (Input.GetKey(KeyCode.W) == false))
                    {
                        StartCoroutine(moveUp());
                        Sinput = false;
                    }
                }
                else if (Input.GetKey(KeyCode.A))
                {
                    if ((Input.GetKey(KeyCode.D) == false) && (Input.GetKey(KeyCode.W) == false) && (Input.GetKey(KeyCode.S) == false))
                    {
                        StartCoroutine(moveRight());
                        Sinput = false;
                    }
                }
            }
        }

        else if (cWest == true)
        {
            if (Winput == true)
            {
                if (Input.GetKey(KeyCode.W))
                {
                    if ((Input.GetKey(KeyCode.D) == false) && (Input.GetKey(KeyCode.A) == false) && (Input.GetKey(KeyCode.S) == false))
                    {
                        StartCoroutine(moveLeft());
                        Winput = false;
                    }
                }
                else if (Input.GetKey(KeyCode.D))
                {
                    if ((Input.GetKey(KeyCode.W) == false) && (Input.GetKey(KeyCode.S) == false) && (Input.GetKey(KeyCode.A) == false))
                    {
                        StartCoroutine(moveUp());
                        Winput = false;
                    }
                }
                else if (Input.GetKey(KeyCode.S))
                {
                    if ((Input.GetKey(KeyCode.D) == false) && (Input.GetKey(KeyCode.A) == false) && (Input.GetKey(KeyCode.W) == false))
                    {
                        StartCoroutine(moveRight());
                        Winput = false;
                    }
                }
                else if (Input.GetKey(KeyCode.A))
                {
                    if ((Input.GetKey(KeyCode.D) == false) && (Input.GetKey(KeyCode.W) == false) && (Input.GetKey(KeyCode.S) == false))
                    {
                        StartCoroutine(moveDown());
                        Winput = false;
                    }
                }
            }
        }
        /*if (Input.GetKey(KeyCode.Space))
        {
            RaycastHit Floor;
            if(Physics.Raycast(gameObject.transform.position, Vector3.down, out Floor,1.1f))
            {
                if (Floor.transform.tag == "walkable")
                {
                    mrigidbody.AddForce(Vector3.up * JumpForce);
                }
            }
        }*/
    }

    IEnumerator moveUp()
    {
        for (int i = 0; i < (90 / step); i++)
        {
            OFFinput = false;
            player.transform.RotateAround(NDown.transform.position, Vector3.right, step);
            yield return new WaitForSeconds(speed);
            OFFinput = true;
        }
        center.transform.position = player.transform.position;
        input();
        if (moveUpUsed == false)
        {
            moveUpUsed = true;
        }
    }

    IEnumerator moveDown()
    {
        for (int i = 0; i < (90 / step); i++)
        {
            OFFinput = false;
            player.transform.RotateAround(SDown.transform.position, Vector3.left, step);
            yield return new WaitForSeconds(speed);
            OFFinput = true;
        }
        center.transform.position = player.transform.position;
        input();
        if (moveDownUsed == false)
        {
            moveDownUsed = true;
        }
    }

    IEnumerator moveRight()
    {
        for (int i = 0; i < (90 / step); i++)
        {
            OFFinput = false;
            player.transform.RotateAround(EDown.transform.position, Vector3.back, step);
            yield return new WaitForSeconds(speed);
            OFFinput = true;
        }
        center.transform.position = player.transform.position;
        input();
        if (moveRightUsed == false)
        {
            moveRightUsed = true;
        }
    }

    IEnumerator moveLeft()
    {
        for (int i = 0; i < (90 / step); i++)
        {
            OFFinput = false;
            player.transform.RotateAround(WDown.transform.position, Vector3.forward, step);
            yield return new WaitForSeconds(speed);
            OFFinput = true;
        }
        center.transform.position = player.transform.position;
        input();
        if (moveLeftUsed == false)
        {
            moveLeftUsed = true;
        }
    }

    void input()
    {
        Ninput = true;
        Sinput = true;
        Einput = true;
        Winput = true;
    }
}