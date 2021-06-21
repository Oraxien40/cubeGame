using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int playerScore; //the players score
    public string hints; //the hint box
    public Text scoreUI; //the players score
    public Text hintsUI; //the hint box
    private void Update()
    {
        scoreUI.text = playerScore.ToString(); //sets Variable "playerScore" to be the same as the canvases child "collectable_score" text box
        hintsUI.text = hints; //sets Variable "hints" to be the same as the canvas child "Hint_box" text box
    }

    public void UpdatePlayerScore(int newScore)
    {
        playerScore += newScore; //makes "playerScore" increase its score by 1
    }

    public void UpdatePlayerHints(string newHint)
    {
        hints = newHint; //sets "hints" to equal "newHints"
    }
}
