using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickAMap : MonoBehaviour
{
    public string place = "TankBlankScene";
    public ChangeScene map;
    public bool mapChosen = false;
   

    public void PicMap()
    {
        map.chosenMap = place;
        mapChosen = true;
    }
}
