using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winnerScreen : MonoBehaviour
{
    public GameObject gameOverScreenUI; //The winner screen

    public void RestartGame() //The restart game button function
    {

        SceneManager.LoadScene("Level One"); //The level is restarted
    }
}
