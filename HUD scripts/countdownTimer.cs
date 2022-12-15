using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class countdownTimer : MonoBehaviour
{

    public float timeValue = 10; //The timer duration
    public TMP_Text timeText; //The timer text within the HUD
    public static bool GameIsOver = false; //The game over conditions
    public GameObject gameOverScreenUI; //The game over screen
    public GameObject hudUI;

    // Start is called before the first frame update
    void Update()
    {
        if (timeValue > 0) //If the countdown timer is still running
        {
            timeValue -= Time.deltaTime; //The countdown is decreasing
        }
        else
        {
            timeValue = 0;
            Time.timeScale = 1f;
        }
        DisplayTime(timeValue); //The time is displayed
    }

    void DisplayTime(float timeToDisplay) //The time is displayed
    {
        if(timeToDisplay < 0) //The timer has reached zero
        {
            timeToDisplay = 0;
            GameOver(); //The game over screen is shown
        }

        float minutes = Mathf.FloorToInt(timeToDisplay / 60); //Acounts for minutes in the timer
        float seconds = Mathf.FloorToInt(timeToDisplay % 60); //Accounts for seconds in the timer

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds); //The formatted timer on the HUD
    }

    void GameOver()
    {
        gameOverScreenUI.SetActive(true); //The game over screen is shown
        hudUI.SetActive(false); //The HUD is disable
        Time.timeScale = 0f; //The game is stopped
        GameIsOver = true; //The game is over
    }

   
}
