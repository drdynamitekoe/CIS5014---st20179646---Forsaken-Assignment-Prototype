using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timeSlower : MonoBehaviour
{
    public float timeValue = 10; //The timer duration
    public AudioClip clip;

    // Start is called before the first frame update
    void Start()
    {
        timeValue = 10;
    }

    void OnTriggerEnter(Collider collision) //A collision is detected 
    {
        GameObject otherObject = collision.gameObject;
        Destroy(gameObject); //the resource is destroyed when collided with
        timeValue -= Time.deltaTime; //The countdown is decreasing
        Time.timeScale = 0.2f; //The scene slows down 
        AudioSource.PlayClipAtPoint(clip, transform.position);

        if (timeValue <= 0) //If the countdown timer is still running
        {
            Time.timeScale = 1f;
        }
    }
}