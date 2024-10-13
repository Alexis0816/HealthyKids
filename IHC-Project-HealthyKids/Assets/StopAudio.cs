using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAudioInScene3 : MonoBehaviour
{
    void Start()
    {
        // Busca el Audio Source persistente
        GameObject backgroundMusic = GameObject.FindWithTag("BackgroundMusic");

        if (backgroundMusic != null)
        {
            // Pausa el audio
            backgroundMusic.GetComponent<AudioSource>().Pause();
        }
    }
}
