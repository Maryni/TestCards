using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{

    [SerializeField] private GameObject panelDeveloper;
    [SerializeField] private GameObject panelVertical;
    [SerializeField] private Slider musicSlider;
    [SerializeField] private Slider audioSlider;
    [SerializeField] private List<Image> cardImages;
    [SerializeField] private List<Sprite> sprites;
    [SerializeField] private List<Material> materials;
    [SerializeField] private GameObject particleSystemGameobject;

    public Slider MusicSlider => musicSlider;
    public Slider AudioSlider => audioSlider;
    
    public void OpenTelegram()
    {
        Application.OpenURL("https://t.me/prikolchik574");
    }

    public void ShowNeedParticles(int value)
    {
        particleSystemGameobject.SetActive(true);
        ParticleSystemRenderer temp = particleSystemGameobject.GetComponent<ParticleSystemRenderer>();
        
        if (value > 0 && value < materials.Count)
        {
            value -= 1;
            
        }
        else
        {
            value = 0;
        }
        
        temp.material = materials[value];
    }
    
    public void ChangeVisibleVerticalPanel()
    {
        panelVertical.SetActive(!panelVertical.activeSelf);
    }
    
    public void CloseApplication()
    {
        Application.Quit();
    }

    public void LeftMove()
    {
        SetSpritesToImage( left: true);
    }

    public void RightMove()
    {
        SetSpritesToImage( right: true);
    }

    private void SetSpritesToImage( bool left = false, bool right = false)
    {
        Sprite[] temp = new Sprite[cardImages.Count];
        if (left)
        {
            for (int i = 0; i < cardImages.Count; i++)
            {
                if (i+1 < cardImages.Count)
                {
                    temp[i] = cardImages[i+1].sprite; 
                }
                else
                {
                    temp[i] = cardImages[0].sprite;
                }
            }
        }
        else if (right)
        {
            temp[0] = cardImages[cardImages.Count - 1].sprite;
            for (int i = 1; i < cardImages.Count; i++)
            {
                temp[i] = cardImages[i-1].sprite;
            }

            //temp[temp.Length - 1] = cardImages[0].sprite;
        }
        
        for (int i = 0; i < cardImages.Count; i++)
        {
            cardImages[i].sprite = temp[i];
        }
    }
    
}
