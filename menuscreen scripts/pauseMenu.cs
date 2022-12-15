using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false; //The pause conditions
    public GameObject pauseMenuUI; //The pause menu
    public GameObject hudUI; //The HUD screen

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) //The escape button is pressed
        {
            if (GameIsPaused) //The game is currently paused
            {
                Resume(); //The game resumes
            }
            else
            {
                Pause(); //The game is paused if the game is currently running
            }
        }
    }

    public void Resume() //The resume game button function
    {
        pauseMenuUI.SetActive(false); //The pause menu is disabled
        hudUI.SetActive(true); //The HUD is displayed once more
        Time.timeScale = 1f; //The scene resumes
        GameIsPaused = false; //The game is currently unpaused
    }

    void Pause() //The pause game button function
    {
        pauseMenuUI.SetActive(true); //The pause menu is displayed
        hudUI.SetActive(false); //The HUD is disabled
        Time.timeScale = 0f; // The scene is paused
        GameIsPaused = true; //The game is currently paused
    }

    public void LoadMenu() //The load menu button function
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
    }


    public void RestartGame() //The Restart game button function
    {

        SceneManager.LoadScene("Level One"); //The level is restarted
    }

    public void QuitGame() //The quit game button function
    {
        Debug.Log("Quitting Game");
        Application.Quit(); //The game is quit
    }

}
