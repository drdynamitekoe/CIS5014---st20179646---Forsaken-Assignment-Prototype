using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class enemyFollow : MonoBehaviour
{
    public float speed = 4f; //Speed of enemy NPC
    public Transform target; //The target they are set to follow
    public Transform target2; //The target they are set to follow
    Rigidbody rig; //Allows for rigidbody component

    // Use this for initialization
    void Start()
    {
        rig = GetComponent<Rigidbody>(); //Sets rigidbody 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
            Vector3 position = Vector3.MoveTowards(transform.position, target.position, speed * Time.fixedDeltaTime); //The NPC movement
            rig.MovePosition(position);
            transform.LookAt(target); //NPC seeks out target object (player)

    }

    void OnTriggerEnter(Collider collision)
    {
        Destroy(gameObject); //Destroys the object
    }
}
