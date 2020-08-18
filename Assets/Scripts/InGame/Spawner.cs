﻿using System;

using UnityEngine;
using Random = UnityEngine.Random;

public class Spawner : MonoBehaviour
{
    public GameObject collectableB, collectableR;


    private float timer;

    private void Start()
    {
        timer = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 1)
        {
            spawn();
            timer = 0;
        }
    }

    public void spawn()
    {
        int randomColor = Random.Range(0, 2);
        int randomX = Random.Range(-47, 47);
        int randomZ = Random.Range(-47, 47);
        
        if (randomColor == 1)
        {
            Instantiate(collectableB, new Vector3(randomX, 2, randomZ), Quaternion.identity);
            FindObjectOfType<ObjectBar>().incrementProgress();
        }
        else
        {
            Instantiate(collectableR, new Vector3(randomX, 2, randomZ), Quaternion.identity);
            FindObjectOfType<ObjectBar>().incrementProgress();
        }
    }
}
