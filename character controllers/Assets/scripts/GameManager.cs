using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int playerScore;
    public string hints;
    public Text scoreUI;
    public Text hintsUI;

    


    private void Update()
    {
        scoreUI.text = playerScore.ToString();
        hintsUI.text = hints;
    }

    public void UpdatePlayerScore(int newScore)
    {
        playerScore += newScore;
    }

    public void UpdatePlayerHints(string newHint)
    {
        hints = newHint;
    }

   
}
