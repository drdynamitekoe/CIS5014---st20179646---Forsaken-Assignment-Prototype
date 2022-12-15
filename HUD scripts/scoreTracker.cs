using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreTracker : MonoBehaviour
{
    [SerializeField] private int score = 0; //The value of points that is assigned to the resource

   public int getScore()
    {
        return score; //The scorfe is shown to the plaer
    }

    // Update is called once per frame
    public void setScore(int newScoreValue)
    {
        score = newScoreValue; //The score is shown to the player
    }

    public void incrementScore(int amountToAdd)
    {
        score += amountToAdd; //The score is updated 
    }
}
