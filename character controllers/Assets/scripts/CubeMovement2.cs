using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement2 : MonoBehaviour
{
    //Variables
    private Vector3 offset;

    public GameObject player; //Cube
    public GameObject center; //Object point in the center of the cube
   
    public GameObject North; //Object point 1 meter North of center
    public GameObject NUp; //Object point 1 meter Up of North
    public GameObject NDown; //Object point 1 meter Down of North

    public GameObject South; //Object point 1 meter South of center
    public GameObject SUp; //Object point 1 meter Up of South
    public GameObject SDown; //Object point 1 meter Down of South

    public GameObject East; //Object point 1 meter East of center
    public GameObject EUp; //Object point 1 meter Up of East
    public GameObject EDown; //Object point 1 meter Down of East

    public GameObject West; //Object point 1 meter West of center
    public GameObject WUp; //Object point 1 meter Up of West
    public GameObject WDown; //Object point 1 meter Down of West

    public int step; //Determines the angle of rotation speed

    public float speed = (float)0.01; //Determines how long the "WaitForSeconds" is active

    bool cNorth = false; //Determines if the camera is facing North
    bool cSouth = false; //Determines if the camera is facing South
    bool cEast = false; //Determines if the camera is facing East
    bool cWest = false; //Determines if the camera is facing West

    [HideInInspector] public bool moveUpUsed = false; //Determines if "moveUp" has been used
    [HideInInspector] public bool moveDownUsed = false; //Determines if "moveDown" has been used
    [HideInInspector] public bool moveLeftUsed = false; //Determines if "moveLeft" has been used
    [HideInInspector] public bool moveRightUsed = false; //Determines if "moveRight" has been used

    [HideInInspector] public bool input = true; //stops the "void Update" from taking KeyCode inputs while Any "IEnumerators" are active 
    [HideInInspector] public bool OFFinput = true; //stops the ""void Update" from taking CameraAngle inputs while Any "IEnumerators" are active 

    void Start()
    {
        if (90 % step != 0) //checks if varible "step" is divisible by 90
        {
            Debug.LogError("your variable step is not divisivble by 90"); //Logs a Debug LogError
        }
    }
    void Update() //Update is called once per frame
    {
        if (OFFinput == true) //Checks if "OFFinput" is true
        {
            float cameraAngle = Camera.main.transform.eulerAngles.y; //Locates the cameras location/rotation around the target (Player) and sets varible "cameraAngle" to eaqual it
            if (cameraAngle > 315 && cameraAngle <= 360 || cameraAngle > 0 && cameraAngle <= 45) //Checks if the camera is facing North
            {
                //set north
                cNorth = true; //sets "cNorth" to true
                //Debug.Log("north");
            }
            else
            {
                cNorth = false; //sets "cNorth" to false
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
            if (input == true)
            {
                if (Input.GetKey(KeyCode.W)) //cecks if "W" key is pressed
                {
                    if ((Input.GetKey(KeyCode.D) == false) && (Input.GetKey(KeyCode.A) == false) && (Input.GetKey(KeyCode.S) == false)) //checks if "A" "S" and "D" are pressed
                    {
                        StartCoroutine(moveUp()); //starts coroutine "moveUp"
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

        else if (cEast == true)
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

        else if (cSouth == true)
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

        else if (cWest == true)
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
    }

    IEnumerator moveUp()
    {
        for (int i = 0; i < (90 / step); i++) //Repeats while "i" equals less than 18 (90 / step(5))
        {
            OFFinput = false; //sets OFFinput to false
            player.transform.RotateAround(NDown.transform.position, Vector3.right, step); //gets the Object "player" and rotates it around the "NDown" object
            yield return new WaitForSeconds(speed); //Waits for "speed"(0.01 seconds) before continuing 
            OFFinput = true;
        }
        center.transform.position = player.transform.position; //moves object "center" to the center of the object "player"
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
            OFFinput = false;
            player.transform.RotateAround(SDown.transform.position, Vector3.left, step);
            yield return new WaitForSeconds(speed);
            OFFinput = true;
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
            OFFinput = false;
            player.transform.RotateAround(EDown.transform.position, Vector3.back, step);
            yield return new WaitForSeconds(speed);
            OFFinput = true;
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
            OFFinput = false;
            player.transform.RotateAround(WDown.transform.position, Vector3.forward, step);
            yield return new WaitForSeconds(speed);
            OFFinput = true;
        }
        center.transform.position = player.transform.position;
        input = true;
        if (moveLeftUsed == false)
        {
            moveLeftUsed = true;
        }
    }
}