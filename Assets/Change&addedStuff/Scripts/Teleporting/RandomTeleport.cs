using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class RandomTeleport : MonoBehaviour
{
    public RandomTpManager rtp;
    private void Update()
    {
        if (rtp.canTP == false && rtp.timer > 0)
        {
            rtp.timer -= Time.deltaTime;
            Debug.Log(rtp.timer);
        }
        


        
    }
    public void OnCollisionEnter(Collision col)
    {
        if (rtp.timer <= 0)
        {
            rtp.randomTeliPad = Random.Range(0, 4);
            Vector3 tPP = rtp.telePoint[rtp.randomTeliPad];
            col.transform.position = tPP;

            rtp.timer = 30f;

            rtp.canTP = false;
        }
    }
}
