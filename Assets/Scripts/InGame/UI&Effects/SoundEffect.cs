using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffect : MonoBehaviour
{
    public float volume;
    public AudioClip audioClip;
    private AudioSource source;

    // Update is called once per frame
    void Start()
    {
        source = GetComponent<AudioSource>();
        source.PlayOneShot(audioClip, volume);
        Invoke("delete", 1);
    }
    public void delete()
    {
        Destroy(gameObject);
    }
}
