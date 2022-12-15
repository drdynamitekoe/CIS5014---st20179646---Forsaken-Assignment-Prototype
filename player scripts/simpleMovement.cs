using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleMovement : MonoBehaviour
{
    [SerializeField] private float _moveSpeed = 10f; //The player speed

    CharacterController _characterController; //The controllers for the player
    public bool IsGrounded; //The player is current on the ground or not?

    private float resetCounter;

    void Awake() => _characterController = GetComponent<CharacterController>(); //The controls are called upon at the start

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal"); //The horizonal axis
        float vertical = Input.GetAxis("Vertical"); //The vertical axis

        Vector3 direction = new Vector3(horizontal, 0, vertical); //The direction
        Vector3 movement = transform.TransformDirection(direction) * _moveSpeed;
        IsGrounded = _characterController.SimpleMove(movement);

        if (!IsGrounded)
        {
            resetCounter += Time.deltaTime;
        }
        if (resetCounter >= 2.0f)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(1);
        }
    }
}