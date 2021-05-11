using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent((typeof(AudioSource)))]
public class ButtonSfx : MonoBehaviour
{
    private AudioSource audioSource;
    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void Sound()
    {
        if (Settings.sfx)
        {
            if (!audioSource)
                Debug.LogError(gameObject);
            audioSource.Play();
        }
    }
}
