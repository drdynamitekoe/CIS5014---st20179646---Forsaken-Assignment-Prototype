using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endGoal : MonoBehaviour
{ 
public GameObject winnerScreenUI; //The congratulations screen
public GameObject hudUI; //The HUD screen
public GameObject thePlayer; //The player character needed to the collision detection
public GameObject thePlayer2; //The player character needed to the collision detection
public static bool GameIsWon = false; //The condition required for the game to be won

    void OnTriggerEnter(Collider Other) //The player collides with the end goal portal
    {
        GameOver(); //The game has been won
    }

    void GameOver()
    {
        winnerScreenUI.SetActive(true); //The win screen is shown
        hudUI.SetActive(false); //The HUD is disabled
        Time.timeScale = 0f; //The game is paused/stopped
        GameIsWon = true; //The game is won
    }
}
