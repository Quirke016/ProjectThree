using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static System.Net.WebRequestMethods;


    public class RandomTpManager : MonoBehaviour
    {
        public List<Vector3> telePoint = new List<Vector3>();
        public int randomTeliPad;
        public ParticleSystem tpParticles1;
        public ParticleSystem tpParticles2;
        public ParticleSystem tpParticles3;
        public ParticleSystem tpParticles4;
        public float timer = 1;
        public bool canTP = true;

        private void Start()
        {
            //adding the teliporters to a list
            telePoint.Add(GameObject.Find("Teleporter").transform.position);
            telePoint.Add(GameObject.Find("Teleporter (1)").transform.position);
            telePoint.Add(GameObject.Find("Teleporter (2)").transform.position);
            telePoint.Add(GameObject.Find("Teleporter (3)").transform.position);

            //removing this teleporter fom its own list
            if (this == GameObject.Find("Teleporter"))
            {
                telePoint.Remove(telePoint[1]);
            }
            if (this == GameObject.Find("Teleporter (1)"))
            {
                telePoint.Remove(telePoint[2]);
            }
            if (this == GameObject.Find("Teleporter (2)"))
            {
                telePoint.Remove(telePoint[3]);
            }
            if (this == GameObject.Find("Teleporter (3)"))
            {
                telePoint.Remove(telePoint[4]);
            }

        if (canTP == true)
            tpParticles1.Play(true);

        if (canTP == true)
            tpParticles2.Play(true);

        if (canTP == true)
            tpParticles3.Play(true);

        if (canTP == true)
            tpParticles4.Play(true);



        if (canTP == false)
            tpParticles1.Play(false);

        if (canTP == false)
            tpParticles2.Play(false);

        if (canTP == false)
            tpParticles3.Play(false);

        if (canTP == false)
            tpParticles4.Play(false);

        if (timer <= 0)
            canTP = true;
    }
    }

