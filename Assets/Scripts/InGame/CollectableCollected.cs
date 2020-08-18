﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class CollectableCollected : MonoBehaviour
{
    public bool isBlue;
    public bool played;
    public float volume;
    public ParticleSystem particleSystemB;
    public ParticleSystem particleSystemR;

    private void OnTriggerStay(Collider other){
        if (FindObjectOfType<PlayerActions>().isBlue && isBlue || !FindObjectOfType<PlayerActions>().isBlue && !isBlue)
        {
            //creating particle effect
            if (isBlue)
            {
                Instantiate(particleSystemB, transform.position, Quaternion.identity);
            }
            else
            {
                Instantiate(particleSystemR, transform.position, Quaternion.identity);
            }
            
            Destroy(gameObject);
            
            //decreasing object bar
            FindObjectOfType<ObjectBar>().decrementProgress();
        }
    }
}