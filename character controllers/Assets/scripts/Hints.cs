using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hints : MonoBehaviour
{
    public string hintValue;
    private GameManager gameManager;
    public CubeMovement2 CM2;

    string hintMove = "WASD to move";
    string hintCollect = "move over the diamonds to add to your score";

    bool MHint = false;

    private void Awake()
    {
        gameManager = FindObjectOfType<GameManager>();
    }
    void Update()
    {
        if (MHint == false)
        {
            MovementHint();
        }
        else
        {
           CollectableHint();
        }
       
    }
    void MovementHint()
    {
        if (CM2.moveUpUsed == false || CM2.moveLeftUsed == false || CM2.moveDownUsed == false || CM2.moveRightUsed == false)
        {
            hintValue = hintMove;
            gameManager.UpdatePlayerHints(hintValue);
        }
        else
        {
            hintValue = null;
            gameManager.UpdatePlayerHints(hintValue);
            MHint = true;
        }
    }
    void CollectableHint()
    {
        if (gameManager.playerScore == 0 && MHint == true)
        {
            hintValue = hintCollect;
            gameManager.UpdatePlayerHints(hintValue);
        }
        else
        {
            hintValue = null;
            gameManager.UpdatePlayerHints(hintValue);
            MHint = true;
        }
    }
}
