﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerActions : MonoBehaviour
{
    public Rigidbody rb;
    public int velocity;   
    public Vector3 currentVelocity;   
    public Vector3 maxSpeed;
    public Material red, blue;
    public bool isBlue = true;
    public AudioSource source;
    public AudioClip clip;

    void Start()
    {
        source = GetComponent<AudioSource>();  
    }

    // Update is called once per frame
    void Update()
    {
        currentVelocity = rb.velocity;
        
        if (Input.GetKey(KeyCode.UpArrow) && currentVelocity.z < maxSpeed.z)
        {
            rb.AddForce(0, 0, velocity * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.DownArrow) && currentVelocity.z > -maxSpeed.z)
        {
            rb.AddForce(0, 0, -velocity * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.LeftArrow) && currentVelocity.x > -maxSpeed.x)
        {
            rb.AddForce(-velocity * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.RightArrow) && currentVelocity.x < maxSpeed.x)
        {
            rb.AddForce(velocity * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            if (isBlue == true)
            {
                gameObject.GetComponent<Renderer>().material = red;           
                source.PlayOneShot(clip, 1);
                isBlue = false;
            }
            else
            {
                gameObject.GetComponent<Renderer>().material = blue;
                source.PlayOneShot(clip, 1);
                isBlue = true;
            }
        }
    }
}
