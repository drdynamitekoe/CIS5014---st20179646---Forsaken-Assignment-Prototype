using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class graphicsSelector : MonoBehaviour
{
    public void setQuality(int qualityIndex) //The game quality
    {
        QualitySettings.SetQualityLevel(qualityIndex); //The game quality is set
    }
}
