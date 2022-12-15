using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mainMenu : MonoBehaviour
{ 
    public void PlayGame() //The level is loaded
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //The scene (level one) is loaded
    }

    public void QuitGame() //The game is stopped
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

    }
