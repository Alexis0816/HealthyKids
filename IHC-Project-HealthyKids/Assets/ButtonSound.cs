using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ButtonSound : MonoBehaviour
{
    public AudioSource audioSource;  // El AudioSource que reproducirá el sonido
    public AudioClip buttonClip;     // El sonido que se reproducirá
    public float additionalWaitTime = 0.1f;  // Tiempo adicional de espera si lo necesitas (opcional)

    // Método que se llama al presionar el botón
    public void PlayButtonSound()
    {
        if(audioSource != null && buttonClip != null)
        {
            audioSource.clip = buttonClip;  // Asigna el clip de sonido al AudioSource
            audioSource.Play();  // Reproduce el sonido
            StartCoroutine(WaitForSound());  // Inicia la corrutina para esperar
        }
        else
        {
            Debug.LogError("AudioSource o AudioClip no asignado correctamente.");
        }
    }

    // Corrutina para esperar la duración del sonido
    private IEnumerator WaitForSound()
    {
        yield return new WaitForSeconds(audioSource.clip.length + additionalWaitTime);
    }
}
