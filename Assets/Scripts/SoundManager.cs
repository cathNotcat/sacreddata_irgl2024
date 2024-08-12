using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    //public Text toggleMusictxt;
    public Image On;
    public Image Off;

    public void Start()
    {
        if(BGM.instance.Audio.isPlaying)
        {
            On.enabled = false;
            Off.enabled = true;
        }
        else
        {
            On.enabled = true;
            Off.enabled = false;
        }
    }

    public void MusicToggle()
    {
        if(BGM.instance.Audio.isPlaying)
        {
            BGM.instance.Audio.Pause();
            On.enabled = true;
            Off.enabled = false;
        }
        else
        {
            BGM.instance.Audio.Play();
            On.enabled = false;
            Off.enabled = true;
        }
    }
}
