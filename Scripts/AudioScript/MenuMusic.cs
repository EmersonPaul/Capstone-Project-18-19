using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMusic : MonoBehaviour
{
    private static MenuMusic musicPlaying;

    void Awake()
    {
        if (musicPlaying != null)
        {
            Destroy(gameObject);
        }
        else
        {
            musicPlaying = this;
            DontDestroyOnLoad(transform.gameObject);
        }
    }


}
