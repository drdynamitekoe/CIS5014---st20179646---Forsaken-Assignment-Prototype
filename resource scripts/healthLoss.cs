
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class healthLoss : MonoBehaviour
{
    public int maxHealth = 100; // The players starting health
    public int currentHealth; //the players current health
    public healthBar healthBar; //The health bar within the HUD
    public AudioClip clip;

    void Start()
    {
        currentHealth = maxHealth; //The players health at the start 
        healthBar.SetMaxHealth(maxHealth);
        healthBar.SetHealth(maxHealth); //The bar is set to maximum health
    }

    void OnTriggerEnter(Collider collision) //A collision is detected 
    {
        GameObject otherObject = collision.gameObject;
        Destroy(gameObject); //the resource is destroyed when collided with

        takeDamage(10); //Health is lost from colliding with the resource

    }
    void takeDamage(int damage) //Function for taking damage
    {
        currentHealth -= damage; //The health is decreased by the amount of damage taken
        healthBar.SetHealth(currentHealth); //The healthbar also decreases
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }
}
