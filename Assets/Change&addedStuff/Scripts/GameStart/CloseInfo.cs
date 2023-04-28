using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseInfo : MonoBehaviour
{
    public GameObject tankSelect;
    public GameObject startInfo;

    public void NextSlide()
    {
        tankSelect.SetActive(true);
        startInfo.SetActive(false);
        Time.timeScale = 1f; //this is temp
    }
}
