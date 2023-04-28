using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTheGoButton : MonoBehaviour
{
    public int arbyNumber;
    public GameObject goButton;

    public void Update()
    {
        if(arbyNumber == 2)
        {
            goButton.SetActive(true);
        }
    }

    public void Arby()
    {
        arbyNumber++;
    }
}
