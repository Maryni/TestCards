using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{

    [SerializeField] private GameObject panelDeveloper;
    [SerializeField] private Slider musicSlider;
    [SerializeField] private Slider audioSlider;

    public Slider MusicSlider => musicSlider;
    public Slider AudioSlider => audioSlider;
    
    public void OpenTelegram()
    {
        Application.OpenURL("https://t.me/prikolchik574");
    }

    public void CloseApplication()
    {
        Application.Quit();
    }
    
}
