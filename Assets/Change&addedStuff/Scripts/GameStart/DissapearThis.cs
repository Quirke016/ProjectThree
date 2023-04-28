using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissapearThis : MonoBehaviour
{
    public GameObject thing;
public void Dissapear()
    {
        thing.SetActive(false);
    }
}
