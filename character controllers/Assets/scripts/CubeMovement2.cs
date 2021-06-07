using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement2 : MonoBehaviour
{
    private Vector3 offset;

    public GameObject player;
    public GameObject camera;
    public GameObject center;
        public GameObject up;
        public GameObject down;
        public GameObject right;
        public GameObject left;

    public int step = 9;

    public float speed = (float)0.01;

    public int JumpForce = 0;
    private Rigidbody mrigidbody;

    private bool north;
    private bool south;
    private bool east;
    private bool west;
    

    bool input = true;
   
    void Start()
    {
        mrigidbody = GetComponent<Rigidbody>();
        
    }

    
    void Update()
    {
        if (camera.transform.rotation.y < 315 || camera.transform.rotation.y >= 45)
        {
            //set north
            north = true;
        }
        else
        {
            north = false;
        }

        if (camera.transform.rotation.y < 45 || camera.transform.rotation.y >= 135)
        {
            //set east
            east = true;
        }
        else
        {
            east = false;
        }

        if (camera.transform.rotation.y < 135 || camera.transform.rotation.y >= 225)
        {
            //set south
            south = true;
        }
        else
        {
            south = false;
        }

        if (camera.transform.rotation.y < 225 || camera.transform.rotation.y >= 315)
        {
            //set west
            west = true;
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
                    if (Input.GetKey(KeyCode.D) == false)
                    {
                        if (Input.GetKey(KeyCode.A) == false)
                        {
                            if (Input.GetKey(KeyCode.S) == false)
                            {
                                StartCoroutine(moveUp());
                                input = false;
                            }
                        }
                    }
                }
                if (Input.GetKey(KeyCode.D))
                {
                    if (Input.GetKey(KeyCode.W) == false)
                    {
                        if (Input.GetKey(KeyCode.S) == false)
                        {
                            if (Input.GetKey(KeyCode.A) == false)
                            {
                                StartCoroutine(moveRight());
                                input = false;
                            }
                        }
                    }
                }
                if (Input.GetKey(KeyCode.S))
                {
                    if (Input.GetKey(KeyCode.D) == false)
                    {
                        if (Input.GetKey(KeyCode.A) == false)
                        {
                            if (Input.GetKey(KeyCode.W) == false)
                            {
                                StartCoroutine(moveDown());
                                input = false;
                            }
                        }
                    }
                }
                if (Input.GetKey(KeyCode.A))
                {
                    if (Input.GetKey(KeyCode.D) == false)
                    {
                        if (Input.GetKey(KeyCode.W) == false)
                        {
                            if (Input.GetKey(KeyCode.S) == false)
                            {
                                StartCoroutine(moveLeft());
                                input = false;
                            }
                        }
                    }
                }
            }
        }

        if (east == true)
        {
            if (input == true)
            {
                if (Input.GetKey(KeyCode.W))
                {
                    if (Input.GetKey(KeyCode.D) == false)
                    {
                        if (Input.GetKey(KeyCode.A) == false)
                        {
                            if (Input.GetKey(KeyCode.S) == false)
                            {
                                StartCoroutine(moveRight());
                                input = false;
                            }
                        }
                    }
                }
                if (Input.GetKey(KeyCode.D))
                {
                    if (Input.GetKey(KeyCode.W) == false)
                    {
                        if (Input.GetKey(KeyCode.S) == false)
                        {
                            if (Input.GetKey(KeyCode.A) == false)
                            {
                                StartCoroutine(moveDown());
                                input = false;
                            }
                        }
                    }
                }
                if (Input.GetKey(KeyCode.S))
                {
                    if (Input.GetKey(KeyCode.D) == false)
                    {
                        if (Input.GetKey(KeyCode.A) == false)
                        {
                            if (Input.GetKey(KeyCode.W) == false)
                            {
                                StartCoroutine(moveLeft());
                                input = false;
                            }
                        }
                    }
                }
                if (Input.GetKey(KeyCode.A))
                {
                    if (Input.GetKey(KeyCode.D) == false)
                    {
                        if (Input.GetKey(KeyCode.W) == false)
                        {
                            if (Input.GetKey(KeyCode.S) == false)
                            {
                                StartCoroutine(moveUp());
                                input = false;
                            }
                        }
                    }
                }
            }
        }

        if (south == true)
        {
            if (input == true)
            {
                if (Input.GetKey(KeyCode.W))
                {
                    if (Input.GetKey(KeyCode.D) == false)
                    {
                        if (Input.GetKey(KeyCode.A) == false)
                        {
                            if (Input.GetKey(KeyCode.S) == false)
                            {
                                StartCoroutine(moveDown());
                                input = false;
                            }
                        }
                    }
                }
                if (Input.GetKey(KeyCode.D))
                {
                    if (Input.GetKey(KeyCode.W) == false)
                    {
                        if (Input.GetKey(KeyCode.S) == false)
                        {
                            if (Input.GetKey(KeyCode.A) == false)
                            {
                                StartCoroutine(moveLeft());
                                input = false;
                            }
                        }
                    }
                }
                if (Input.GetKey(KeyCode.S))
                {
                    if (Input.GetKey(KeyCode.D) == false)
                    {
                        if (Input.GetKey(KeyCode.A) == false)
                        {
                            if (Input.GetKey(KeyCode.W) == false)
                            {
                                StartCoroutine(moveUp());
                                input = false;
                            }
                        }
                    }
                }
                if (Input.GetKey(KeyCode.A))
                {
                    if (Input.GetKey(KeyCode.D) == false)
                    {
                        if (Input.GetKey(KeyCode.W) == false)
                        {
                            if (Input.GetKey(KeyCode.S) == false)
                            {
                                StartCoroutine(moveRight());
                                input = false;
                            }
                        }
                    }
                }
            }
        }

        if (west == true)
        {
            if (input == true)
            {
                if (Input.GetKey(KeyCode.W))
                {
                    if (Input.GetKey(KeyCode.D) == false)
                    {
                        if (Input.GetKey(KeyCode.A) == false)
                        {
                            if (Input.GetKey(KeyCode.S) == false)
                            {
                                StartCoroutine(moveRight());
                                input = false;
                            }
                        }
                    }
                }
                if (Input.GetKey(KeyCode.D))
                {
                    if (Input.GetKey(KeyCode.W) == false)
                    {
                        if (Input.GetKey(KeyCode.S) == false)
                        {
                            if (Input.GetKey(KeyCode.A) == false)
                            {
                                StartCoroutine(moveDown());
                                input = false;
                            }
                        }
                    }
                }
                if (Input.GetKey(KeyCode.S))
                {
                    if (Input.GetKey(KeyCode.D) == false)
                    {
                        if (Input.GetKey(KeyCode.A) == false)
                        {
                            if (Input.GetKey(KeyCode.W) == false)
                            {
                                StartCoroutine(moveLeft());
                                input = false;
                            }
                        }
                    }
                }
                if (Input.GetKey(KeyCode.A))
                {
                    if (Input.GetKey(KeyCode.D) == false)
                    {
                        if (Input.GetKey(KeyCode.W) == false)
                        {
                            if (Input.GetKey(KeyCode.S) == false)
                            {
                                StartCoroutine(moveUp());
                                input = false;
                            }
                        }
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
    }


}