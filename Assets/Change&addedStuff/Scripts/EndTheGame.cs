using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTheGame : MonoBehaviour
{
    int deaths = 0;
    public string DeathScene = "Death"; // change this

    public bool tankDies; // delete this

    public void Update()
    {
        if (deaths == 2)
            EndGame();

        if (tankDies)
            deaths ++;
    }
    void EndGame()
    {
        SceneManager.LoadScene(DeathScene);
    }

}
