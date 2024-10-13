using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAudioInScene3 : MonoBehaviour
{
    void Start() {
        GameObject backgroundMusic = GameObject.FindWithTag("BackgroundMusic");

        if (backgroundMusic != null){ // Pausar el audio temporalmente en la escena 3
            backgroundMusic.GetComponent<AudioSource>().Pause();
        }
    }
}
