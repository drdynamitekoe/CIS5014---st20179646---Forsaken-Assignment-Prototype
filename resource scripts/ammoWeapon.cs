using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ammoWeapon : MonoBehaviour
{
    public AudioClip clip;

    void OnTriggerEnter(Collider collision) //The detected collision
    {
        GameObject otherObject = collision.gameObject;
            Destroy(gameObject); //The obejct is destroyed when collided with
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }

    }

