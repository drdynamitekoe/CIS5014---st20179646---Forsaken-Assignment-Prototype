using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerControls : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 2f; //The speed the player is moving in
    [SerializeField] private float _turnSpeed = 30f; //the speed the player is turning 

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Mouse X"); //The camera is controlled by the mouse
        transform.Rotate(horizontal * _turnSpeed * Vector3.up, Space.World); //the rotation takes place

        float xDirection = Input.GetAxis("Horizontal"); //The horizontal direction
        float yDirection = Input.GetAxis("Vertical"); //The vertical direction

        Vector3 moveDirection = new Vector3(xDirection, 0.0f, yDirection);

        transform.position += moveDirection; //The position is changed
    }
}