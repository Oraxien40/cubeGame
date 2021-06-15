using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement2 : MonoBehaviour
{
    private Vector3 offset;

    public GameObject player;
    public GameObject center;
    public GameObject up;
    public GameObject down;
    public GameObject right;
    public GameObject left;

    public int step = 9;

    public float speed = (float)0.01;

    //public int JumpForce = 0;
    //private Rigidbody mrigidbody;

    private bool north = false;
    private bool south = false;
    private bool east = false;
    private bool west = false;

    public bool moveUpUsed = false;
    public bool moveDownUsed = false;
    public bool moveLeftUsed = false;
    public bool moveRightUsed = false;


    bool input = true;

    void Start()
    {
        //mrigidbody = GetComponent<Rigidbody>();

    }


    void Update()
    {
        float cameraAngle = Camera.main.transform.eulerAngles.y;
        if (cameraAngle > 315 && cameraAngle <= 360 || cameraAngle > 0 && cameraAngle <= 45)
        {
            //set north
            north = true;
            //Debug.Log("north");
        }
        else
        {
            north = false;
        }

        if (cameraAngle > 45 && cameraAngle <= 135)
        {
            //set east
            east = true;
            //Debug.Log("east");
        }
        else
        {
            east = false;
        }

        if (cameraAngle > 135 && cameraAngle <= 225)
        {
            //set south
            south = true;
            //Debug.Log("south");
        }
        else
        {
            south = false;
        }

        if (cameraAngle > 225 && cameraAngle <= 315)
        {
            //set west
            west = true;
            //Debug.Log("west");
        }
        else
        {
            west = false;
        }

        if (north == true)
        {
            if (input == true)
            {
                if (Input.GetKey(KeyCode.W))
                {
                    if ((Input.GetKey(KeyCode.D) == false) && (Input.GetKey(KeyCode.A) == false) && (Input.GetKey(KeyCode.S) == false))
                    {
                        StartCoroutine(moveUp());
                        input = false;
                    }
                }
                else if (Input.GetKey(KeyCode.D))
                {
                    if ((Input.GetKey(KeyCode.W) == false) && (Input.GetKey(KeyCode.S) == false) && (Input.GetKey(KeyCode.A) == false))
                    {
                        StartCoroutine(moveRight());
                        input = false;
                    }
                }
                else if (Input.GetKey(KeyCode.S))
                {
                    if ((Input.GetKey(KeyCode.D) == false) && (Input.GetKey(KeyCode.A) == false) && (Input.GetKey(KeyCode.W) == false))
                    {
                        StartCoroutine(moveDown());
                        input = false;
                    }
                }
                else if (Input.GetKey(KeyCode.A))
                {
                    if ((Input.GetKey(KeyCode.D) == false) && (Input.GetKey(KeyCode.W) == false) && (Input.GetKey(KeyCode.S) == false))
                    {
                        StartCoroutine(moveLeft());
                        input = false;
                    }
                }
            }
        }

        else if (east == true)
        {
            if (input == true)
            {
                if (Input.GetKey(KeyCode.W))
                {
                    if ((Input.GetKey(KeyCode.D) == false) && (Input.GetKey(KeyCode.A) == false) && (Input.GetKey(KeyCode.S) == false))
                    {
                        StartCoroutine(moveRight());
                        input = false;
                    }
                }
                else if (Input.GetKey(KeyCode.D))
                {
                    if ((Input.GetKey(KeyCode.W) == false) && (Input.GetKey(KeyCode.S) == false) && (Input.GetKey(KeyCode.A) == false))
                    {
                        StartCoroutine(moveDown());
                        input = false;
                    }
                }
                else if (Input.GetKey(KeyCode.S))
                {
                    if ((Input.GetKey(KeyCode.D) == false) && (Input.GetKey(KeyCode.A) == false) && (Input.GetKey(KeyCode.W) == false))
                    {
                        StartCoroutine(moveLeft());
                        input = false;
                    }
                }
                else if (Input.GetKey(KeyCode.A))
                {
                    if ((Input.GetKey(KeyCode.D) == false) && (Input.GetKey(KeyCode.W) == false) && (Input.GetKey(KeyCode.S) == false))
                    {
                        StartCoroutine(moveUp());
                        input = false;
                    }
                }
            }
        }

        else if (south == true)
        {
            if (input == true)
            {
                if (Input.GetKey(KeyCode.W))
                {
                    if ((Input.GetKey(KeyCode.D) == false) && (Input.GetKey(KeyCode.A) == false) && (Input.GetKey(KeyCode.S) == false))
                    {
                        StartCoroutine(moveDown());
                        input = false;
                    }
                }
                else if (Input.GetKey(KeyCode.D))
                {
                    if ((Input.GetKey(KeyCode.W) == false) && (Input.GetKey(KeyCode.S) == false) && (Input.GetKey(KeyCode.A) == false))
                    {
                        StartCoroutine(moveLeft());
                        input = false;
                    }
                }
                else if (Input.GetKey(KeyCode.S))
                {
                    if ((Input.GetKey(KeyCode.D) == false) && (Input.GetKey(KeyCode.A) == false) && (Input.GetKey(KeyCode.W) == false))
                    {
                        StartCoroutine(moveUp());
                        input = false;
                    }
                }
                else if (Input.GetKey(KeyCode.A))
                {
                    if ((Input.GetKey(KeyCode.D) == false) && (Input.GetKey(KeyCode.W) == false) && (Input.GetKey(KeyCode.S) == false))
                    {
                        StartCoroutine(moveRight());
                        input = false;
                    }
                }
            }
        }

        else if (west == true)
        {
            if (input == true)
            {
                if (Input.GetKey(KeyCode.W))
                {
                    if ((Input.GetKey(KeyCode.D) == false) && (Input.GetKey(KeyCode.A) == false) && (Input.GetKey(KeyCode.S) == false))
                    {
                        StartCoroutine(moveLeft());
                        input = false;
                    }
                }
                else if (Input.GetKey(KeyCode.D))
                {
                    if ((Input.GetKey(KeyCode.W) == false) && (Input.GetKey(KeyCode.S) == false) && (Input.GetKey(KeyCode.A) == false))
                    {
                        StartCoroutine(moveUp());
                        input = false;
                    }
                }
                else if (Input.GetKey(KeyCode.S))
                {
                    if ((Input.GetKey(KeyCode.D) == false) && (Input.GetKey(KeyCode.A) == false) && (Input.GetKey(KeyCode.W) == false))
                    {
                        StartCoroutine(moveRight());
                        input = false;
                    }
                }
                else if (Input.GetKey(KeyCode.A))
                {
                    if ((Input.GetKey(KeyCode.D) == false) && (Input.GetKey(KeyCode.W) == false) && (Input.GetKey(KeyCode.S) == false))
                    {
                        StartCoroutine(moveDown());
                        input = false;
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
            player.transform.RotateAround(up.transform.position, Vector3.right, step);
            yield return new WaitForSeconds(speed);
        }
        center.transform.position = player.transform.position;
        input = true;
        if (moveUpUsed == false)
        {
            moveUpUsed = true;
        }
    }

    IEnumerator moveDown()
    {
        for (int i = 0; i < (90 / step); i++)
        {
            player.transform.RotateAround(down.transform.position, Vector3.left, step);
            yield return new WaitForSeconds(speed);
        }
        center.transform.position = player.transform.position;
        input = true;
        if (moveDownUsed == false)
        {
            moveDownUsed = true;
        }
    }

    IEnumerator moveRight()
    {
        for (int i = 0; i < (90 / step); i++)
        {
            player.transform.RotateAround(right.transform.position, Vector3.back, step);
            yield return new WaitForSeconds(speed);
        }
        center.transform.position = player.transform.position;
        input = true;
        if (moveRightUsed == false)
        {
            moveRightUsed = true;
        }
    }

    IEnumerator moveLeft()
    {
        for (int i = 0; i < (90 / step); i++)
        {
            player.transform.RotateAround(left.transform.position, Vector3.forward, step);
            yield return new WaitForSeconds(speed);
        }
        center.transform.position = player.transform.position;
        input = true;
        if (moveLeftUsed == false)
        {
            moveLeftUsed = true;
        }
    }


}