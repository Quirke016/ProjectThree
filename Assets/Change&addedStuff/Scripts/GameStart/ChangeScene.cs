using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string chosenMap;
     
    public void NextScene()
    {
        SceneManager.LoadScene(chosenMap);  
    }
}
