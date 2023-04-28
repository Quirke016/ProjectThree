using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportBackToBounds : MonoBehaviour
{
    //float amountOfDamage = 10;
    public void OnCollisionEnter(Collision col)
    {
        col.transform.position = new Vector3(0, 10, 0);
        //col.gameObject.GetComponent<TankHealth>().ApplyHealthChange(10);
    }


}
