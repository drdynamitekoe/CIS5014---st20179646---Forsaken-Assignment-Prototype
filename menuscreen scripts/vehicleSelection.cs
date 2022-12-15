using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class vehicleSelection : MonoBehaviour
{
    public GameObject vehicleSelectionScreenUI; //The vehicle selection screen
    public GameObject hudUI; //the HUD
    public GameObject vehicle1; //The first playable choice of vehicle
    public GameObject vehicle2; //The second playable choice of vehicle
    public GameObject camera1; //The first person camera for the first vehicle
    public GameObject camera2; //The third person camera for the first vehicle
    public GameObject camera3; //The first person camera for the second vehicle
    public GameObject camera4; //The third person camera for the second vehicle

    void Start()
    {
        Time.timeScale = 0f; // The scene is paused
    }

    public void VehicleOne() //The first vehicle is chosen
            {
        vehicleSelectionScreenUI.SetActive(false); //The vehicle selection screen is disabled 
        hudUI.SetActive(true); //the HUD is displayed
        vehicle1.SetActive(true); //The first playable vehicle is used by the player
        vehicle2.SetActive(false); //The second playable vehicle is disabled
        Time.timeScale = 1f; //The scene starts

        camera1.SetActive(true); //The game starts with the first person camera for the first playable vehicle
        //The third person camera is disabled until is is called
        camera2.SetActive(false); 
        //The last two cameras are connected to the second playable vehicle so are automatically disabled
        camera3.SetActive(false);
        camera4.SetActive(false);

    }
        
        public void VehicleTwo() //the second vehicle is chosen
{
        vehicleSelectionScreenUI.SetActive(false); //The vehicle selection screen is disabled 
        hudUI.SetActive(true); //the HUD is displayed
        vehicle1.SetActive(false); //The first playable vehicle is disabled
        vehicle2.SetActive(true); //The second playable vehicle is used by the player 

        //The last first cameras are connected to the first playable vehicle so are automatically disabled
        camera1.SetActive(false);
        camera2.SetActive(false);
        camera3.SetActive(true); //The game starts with the first person camera for the second playable vehicle
        camera4.SetActive(false); //The third person camera is disabled until is is called
        Time.timeScale = 1f; //The scene starts
    }

    public void LoadMenu() //The menu is loaded
    {
        Time.timeScale = 1f; //The scene is unpaused
        SceneManager.LoadScene("Main Menu"); //The main menu is loaded
    }

}
