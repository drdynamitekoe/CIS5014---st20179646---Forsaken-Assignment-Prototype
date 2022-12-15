using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class energyBar : MonoBehaviour
{
    public Slider slider; //The energy bar
    public Gradient gradient; //the energy bar gradient
    public Image fill; //The amount of energy within the bar

    public void SetMaxEnergy(int energy) //The starting energy level (100%)
    {
        slider.maxValue = energy; //The max energy level is set
        slider.value = energy; //The energy value within the slider
        fill.color = gradient.Evaluate(1f); //The gradient of the energy bar
    }

    public void SetEnergy(int energy)
    {
        slider.value = energy; //The energy value within the slider
        fill.color = gradient.Evaluate(slider.normalizedValue);//The gradient of the energy bar
}
}