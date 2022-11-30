using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GameController : MonoBehaviour
{
    [Inject] private UIController uiController;
    [Inject] private AudioController audioController;

    private void Start()
    {
        SetActions();
    }

    private void SetActions()
    {
        uiController.AudioSlider.onValueChanged.AddListener((float value) => audioController.SetAudioVolume(uiController.AudioSlider.value));
        uiController.MusicSlider.onValueChanged.AddListener((float value) => audioController.SetMusicVolume(uiController.MusicSlider.value));
    }
}
