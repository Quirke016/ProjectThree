using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHideOptions : MonoBehaviour
{
    public GameObject mainAudioSlider;
    public GameObject musicAudioSlider;
    public bool showing;

    private void Update()
    {
        if (showing == false)
        {
            HideOptions();
        }

        if (showing == true)
        {
            ShowOptions();
        }
    }
    public void ShowTheOptions()
    {
        if (showing == true) 
        { 
            showing = false; 
        }

        else if (showing == false) 
        { 
            showing = true; 
        }
    }

    public void ShowOptions()
    {
        mainAudioSlider.SetActive(true);
        musicAudioSlider.SetActive(true);
    }


    public void HideOptions()
    {
        mainAudioSlider.SetActive(false);
        musicAudioSlider.SetActive(false);
    }

}
