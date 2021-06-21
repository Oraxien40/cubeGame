using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hints : MonoBehaviour
{
    public string hintValue; //is whats displayed on in the text box
    private GameManager gameManager; //is a seprate script
    public CubeMovement2 CM2; //is a seprate script

    string hintMove = "WASD to move"; //what is put in the Hint box
    string hintCollect = "move over the diamonds to add to your score"; //what is put in the Hint box

    bool MHint = false;

    private void Start()
    {
        gameManager = FindObjectOfType<GameManager>(); //finds the GameManager script and sets it to be equal with the Variable "gameManager"
    }
    void Update()
    {
        if (MHint == false) //checks if "MHint" is false
        {
            MovementHint(); //runs "MovementHint"
        }
        else
        {
           CollectableHint(); //runs "CollectableHint"
        }
       
    }
    void MovementHint()
    {
        if (CM2.moveUpUsed == false || CM2.moveLeftUsed == false || CM2.moveDownUsed == false || CM2.moveRightUsed == false) //checks if Variables "moveUpUsed", "moveLeftUsed", "moveDownUsed" and "moveRightUsed" are false
        {
            hintValue = hintMove; //sets "hintValue" to equal "hintMove"
            gameManager.UpdatePlayerHints(hintValue); //Updates "hintValue" in GameManager script
        }
        else
        {
            hintValue = null; //"hintValue" epuals nothing
            gameManager.UpdatePlayerHints(hintValue); //Updates "hintValue" in GameManager script
            MHint = true;
        }
    }
    void CollectableHint()
    {
        if (gameManager.playerScore == 0 && MHint == true) //checks if "playerScore" equals 0 and if "MHint" equals true
        {
            hintValue = hintCollect;
            gameManager.UpdatePlayerHints(hintValue); //Updates "hintValue" in GameManager script
        }
        else
        {
            hintValue = null; //"hintValue" epuals nothing
            gameManager.UpdatePlayerHints(hintValue); //Updates "hintValue" in GameManager script
            MHint = true;
        }
    }
}
