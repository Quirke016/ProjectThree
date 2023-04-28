using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Go : MonoBehaviour
{
    public GameObject tankSelect;
    private void Start()
    {
        tankSelect.SetActive(false);
        Time.timeScale= 1.0f;
    }
}
