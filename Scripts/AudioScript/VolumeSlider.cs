using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class VolumeSlider : MonoBehaviour
{
    public AudioMixer menuAudioMix;

    public void setMenuVolume(float menuVolume)
    {
        menuAudioMix.SetFloat("menuMixer", menuVolume);
    }


}
