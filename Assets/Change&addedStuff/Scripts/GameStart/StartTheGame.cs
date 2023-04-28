using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTheGame : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject startInfo;

    void Start()
    {
        Time.timeScale = 0f;
    }

    public void PlayTheGame()
    {
        mainMenu.SetActive(false);
        startInfo.SetActive(true);
    }
}
