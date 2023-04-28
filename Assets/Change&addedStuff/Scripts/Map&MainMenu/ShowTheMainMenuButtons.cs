using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTheMainMenuButtons : MonoBehaviour
{
    public PickAMap pam;
    public PickAMap pam1;
    public PickAMap pam2;
    public PickAMap pam3;
    public GameObject playButton;
    public GameObject mapButtons;

    // Update is called once per frame
    void Update()
    {
      if (pam.mapChosen == true || pam1.mapChosen == true || pam2.mapChosen == true || pam3.mapChosen == true)
        {
            mapButtons.SetActive(false);
            playButton.SetActive(true);
        }  
    }
}
