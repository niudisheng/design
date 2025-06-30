using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;
    public AudioSource musicSource;
    public AudioSource effectSource;
    public AudioClip backgroundMusic;
    public AudioClip[] musicClips;

    public AudioClip[] effectClips;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        
    }

    public void playBackgroundMusic()
    {
        musicSource.clip = backgroundMusic;
        musicSource.Play();
    }
    public void playEffect(int index)
    {
        effectSource.clip = effectClips[index];
        effectSource.Play();
    }
    public void playEffect(AudioClip clip)
    {
        effectSource.clip = clip;
        effectSource.Play();
    }
}