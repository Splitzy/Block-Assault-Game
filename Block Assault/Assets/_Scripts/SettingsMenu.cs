using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SettingsMenu : MonoBehaviour
{
    public AudioMixer volumeMixer;

    public void SetVolume(float volume)
    {
        volumeMixer.SetFloat("Volume", volume);
    }
    
}
