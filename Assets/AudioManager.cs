using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    AudioSource source;
    bool isPlaying;

    void Start()
    {
        source = GetComponent<AudioSource>();
        isPlaying = true;
    }

    void Update()
    {
        if (isPlaying)
        {
            source.Play();
        }
        else
        {
            source.Stop();
        }
        isPlaying = !isPlaying;
    }
}