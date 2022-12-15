using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraSwitcher : MonoBehaviour
{
    public GameObject camera1; //The first person camera
    public GameObject camera2; //The third person camera 

  

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1)) //If the button is pressed
        {
            camera1.SetActive(true); //The game is changed to first person mode
            camera2.SetActive(false); //The third person camera is disabled
        }

        if (Input.GetKey(KeyCode.Alpha2)) //If the button is pressed
        {
            camera1.SetActive(false); //The first person camera is disabled
            camera2.SetActive(true); //The game is changed to third person mode
        }

    }
}
