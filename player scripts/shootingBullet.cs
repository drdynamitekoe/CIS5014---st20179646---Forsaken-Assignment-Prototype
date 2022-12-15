using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootingBullet : MonoBehaviour
{
    public Transform spawnPoint; //The spawn point for the first projectile
    public Transform spawnPoint2; //The spawn point for the second projectile
    public GameObject projectile; //The projectile itself
    public float speed = 5f; //The speed of the projectile
  

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) //The left button on the mouse is pressed 
        {
            ShootBulletRight(); //the function for the right button is pressed
            ShootBulletLeft(); //the funnction for the left button is pressed
        }
    }

    private void ShootBulletRight() //The function for the right bullet
    {
        GameObject cb = Instantiate(projectile, spawnPoint.position, projectile.transform.rotation); //The projectile prefab is instantiated at the second spawnpoint
        Rigidbody rig = cb.GetComponent<Rigidbody>(); //The rigidbody for the projectile is accounted for
        transform.position += Time.deltaTime * speed * transform.forward; //The projectile fires forward
        rig.AddForce(spawnPoint.forward * speed, ForceMode.Impulse);
    }

    private void ShootBulletLeft() //The function for the left bullet
    {
        GameObject cb2 = Instantiate(projectile, spawnPoint2.position, projectile.transform.rotation); //The projectile prefab is instantiated at the second spawn point
        Rigidbody rig = cb2.GetComponent<Rigidbody>(); //The rigidbody for the projectile is accounted for
        transform.position += Time.deltaTime * speed * transform.forward; //The projectile fires forward
        rig.AddForce(spawnPoint2.forward * speed, ForceMode.Impulse);
    }
}
