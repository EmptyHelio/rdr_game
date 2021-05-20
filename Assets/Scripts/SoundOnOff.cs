using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundOnOff : MonoBehaviour
{
    
    public Sprite enableSprite;
    public Sprite disableSprite;

    private Image im;
    private AudioSource audioSrc;

    void Start()
    {
        im = GetComponent<Image>();
        audioSrc = GetComponent<AudioSource>();
    }


    public void switchAudio()
    {
        if(audioSrc.mute == true)
        {
            im.sprite = enableSprite;
            audioSrc.mute = false;
        }
        else
        {
            im.sprite = disableSprite;
            audioSrc.mute = true;
        }
    }
}
