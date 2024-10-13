using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResumeBackgroundMusic : MonoBehaviour
{
    void Start()
    {
        // Buscar el objeto que contiene la música de fondo
        GameObject backgroundMusic = GameObject.FindWithTag("BackgroundMusic");

        if (backgroundMusic != null)
        {
            // Reanudar el audio si estaba pausado
            backgroundMusic.GetComponent<AudioSource>().UnPause();
        }
    }
}

