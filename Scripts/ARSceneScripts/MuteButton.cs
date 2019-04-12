using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteButton : MonoBehaviour
{
    public AudioListener listener;

    public GameObject MusicIsOnButton, MusicIsOffButton;

    bool musicIsMute = false;

    public void MusicToggle()
    {
        if (musicIsMute == false)
        {
            AudioListener.volume = 0f;
            musicIsMute = true;

            MusicIsOffButton.gameObject.SetActive(true);
            MusicIsOnButton.gameObject.SetActive(false);

        }
        else
        {
            AudioListener.volume = 1f;
            musicIsMute = false;

            MusicIsOffButton.gameObject.SetActive(false);
            MusicIsOnButton.gameObject.SetActive(true);

        }
    }
}
