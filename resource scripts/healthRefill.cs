using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class healthRefill : MonoBehaviour
{
    public int maxHealth = 100; //The players maximum health
    public int currentHealth; //The players current health
    public healthBar healthBar; //The health bar itself
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

        currentHealth = maxHealth; //The health is reset to maximum
        healthBar.SetMaxHealth(maxHealth); //The bar is reset to maximum
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }

}
