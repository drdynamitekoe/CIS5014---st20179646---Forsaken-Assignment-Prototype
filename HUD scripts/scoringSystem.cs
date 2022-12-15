using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class scoringSystem : MonoBehaviour
{
    public GameObject scoreText; //The score text in the HUD
    public static int theScore; //The score in the HUD

    void Update()
    {
        scoreText.GetComponent<TMP_Text>().text = "SCORE: " + theScore; //The score is shown on the HUD
    }
}

