using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class player : MonoBehaviour
{
    public int maxHealth = 100; // The players starting health
    public int currentHealth; //the players current health
    public healthBar healthBar; //The health bar within the HUD
    public int maxEnergy = 100; //The players starting energy
    public int currentEnergy; //The players current energy
    public energyBar energyBar; //The energy bar within the HUD

    public static bool GameIsOver = false; //The game over conditions
    public GameObject gameOverScreenUI; //the game over screen
    public GameObject hudUI; //The HUD 
    public AudioClip clip;


    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth; //Health is set to maximum at the start
        healthBar.SetMaxHealth(maxHealth); //Health bar fill is also set to maximum

        currentEnergy = maxEnergy; //Energy is set to maximum at the start
        energyBar.SetMaxEnergy(maxEnergy); //Energy bar fill is also set to maximum
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //The space button is pressed
        {
            takeDamage(10); //Health is lost (testing purposes)
            loseEnergy(10); //Energy is lost (testing purposes)
        }

        if (currentHealth <= 0) //Health reaches zero
        {
            GameOver(); //The game is lost
        }
    }


    void takeDamage(int damage) //Function for taking damage
    {
        currentHealth -= damage; //The health is decreased by the amount of damage taken
        healthBar.SetHealth(currentHealth); //The healthbar also decreases
    }

    void loseEnergy(int power) //Function for losing energy
    {
        currentEnergy -= power; //The energy us decreased by the amount of power used
        energyBar.SetEnergy(currentEnergy); //The energy bar also decreases
    }


    void GameOver() //The function for when the game over conditions are set
    {
        gameOverScreenUI.SetActive(true); //The game over screen is displayed
        hudUI.SetActive(false); // The HUD is disabled
        GameIsOver = true; //The game is lost
    }

    void OnTriggerEnter(Collider collision) // A collision has taken place
    {
        if (collision.gameObject.tag == "aidance") //Collision with the "Aidance" resource
        {
            GameObject otherObject = collision.gameObject;
            Destroy(gameObject); //The resource is destroyed

            currentHealth = maxHealth; //The health is reset to maximum
            healthBar.SetMaxHealth(maxHealth); //The health bar is also reset

            currentEnergy = maxEnergy; //The energy is reset to maximum
            energyBar.SetMaxEnergy(maxEnergy); //The energy bar is also reset
        }

        if (collision.gameObject.tag == "nopium") //Collision with the "Nopium" resource
        {
            takeDamage(10); //Health is lost (testing purposes)
            AudioSource.PlayClipAtPoint(clip, transform.position);
        }
    }
}

