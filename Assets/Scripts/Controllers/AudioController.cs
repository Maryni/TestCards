using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    [SerializeField] private AudioSource musicSource;
    [SerializeField] private AudioSource audioSource;

    public void SetMusicVolume(float value)
    {
        musicSource.volume = value;
    }

    public void SetAudioVolume(float value)
    {
        audioSource.volume = value;
    }
}
