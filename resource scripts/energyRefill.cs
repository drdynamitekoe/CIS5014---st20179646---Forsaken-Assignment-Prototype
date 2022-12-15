using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class energyRefill : MonoBehaviour
{
    public int maxEnergy = 100; //The starting energy value
    public int currentEnergy; //The current energy value
    public energyBar energyBar; //The energy bar
    public AudioClip clip;


    void Start()
    {
        currentEnergy = maxEnergy; //the starting energy bar is set to the maximum energy bar
        energyBar.SetMaxEnergy(maxEnergy);
    }

    void OnTriggerEnter(Collider collision) //Collision with a energy resource
    {
        GameObject otherObject = collision.gameObject; //The collision is detected 
        Destroy(gameObject); //The resource is destroyed when collided with

        currentEnergy = maxEnergy; //The energy is reset to maximum
        energyBar.SetMaxEnergy(maxEnergy); //The bar is reset to maximum
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }
}
