using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance = null;

    public AudioClip clap, go, hahaha, helloAndWelcome, pshh;
    public AudioClip[] lose = new AudioClip[2];
    public AudioClip[] tap = new AudioClip[4];
    public AudioClip[] yok = new AudioClip[2];

    private AudioSource soundEffectAudio;

    void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
        soundEffectAudio = GetComponent<AudioSource>();
    }

    public void PlayOneShot(AudioClip clip)
    {
        if (PlayerPrefs.GetString("Music") == "Yes")
            soundEffectAudio.PlayOneShot(clip);
    }

    public void PlayRandomOneShot(AudioClip[] clips)
    {
        PlayOneShot(clips[Random.Range(0, clips.Length)]);
    }
}