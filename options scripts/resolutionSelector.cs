using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class resolutionSelector : MonoBehaviour
{
    public TMP_Dropdown resolutionDropdown; //The dropdown list
    Resolution[] resolutions; //The contents of the dropdown list


    // Start is called before the first frame update
    void Start()
    {
        resolutions = Screen.resolutions; //The resolution is set
        resolutionDropdown.ClearOptions(); //The other options are cleared

        List<string> options = new List<string>();

        int currentResolutionIndex = 0;
        for (int i = 0; i < resolutions.Length; i++) 
        {
            string option = resolutions[i].width + " x " + resolutions[i].height; //The contents of each dropdown option
            options.Add(option); //The contents are added to the list

            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = 1;
            }
        }

        resolutionDropdown.AddOptions(options); //The contents are added to the list
        resolutionDropdown.value = currentResolutionIndex; 
        resolutionDropdown.RefreshShownValue();
    }

}

