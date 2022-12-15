using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOverScreen : MonoBehaviour
{
    public GameObject gameOverScreenUI; //The game over screen
   // public AudioSource briefing; // The briefing plays when the mission is lost

    public void RestartGame() //The game is restarted
    {
        SceneManager.LoadScene("Level One"); //Level One is reloaded
    }

}
