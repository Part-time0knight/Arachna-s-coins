using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]
public class MusicController : MonoBehaviour
{
    private AudioSource audioSource;
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    void Update()
    {
        bool musicPlay = audioSource.isPlaying;
        if (Settings.music && !musicPlay)
            audioSource.Play();
        else if(!Settings.music && musicPlay)
            audioSource.Stop();
    }
}
