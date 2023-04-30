using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeThing : MonoBehaviour
{
    public float timeFrozen = 0;
    bool timeIsFrozen = false;

    private void OnCollisionEnter(Collision col)
    {
        timeIsFrozen = true;
        timeFrozen = 10f;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeIsFrozen)
        {
            Time.timeScale = 0.1f;
            timeFrozen -= Time.deltaTime;
        }

        if (!timeIsFrozen)
        {
            Time.timeScale = 1f;
        }

        if (timeFrozen <= 0)
        {
            timeIsFrozen = false;
        }
    }
}
