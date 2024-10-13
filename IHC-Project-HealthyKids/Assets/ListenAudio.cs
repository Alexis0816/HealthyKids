using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundMusic : MonoBehaviour
{
  private static BackgroundMusic instance = null;
  private AudioSource audioSource;

  void Awake()
  {
    // Verificar si ya existe una instancia de BackgroundMusic
    if (instance == null)
    {
      instance = this;
      DontDestroyOnLoad(gameObject); // Evita que este objeto se destruya al cambiar de escena
      audioSource = GameObject.Find("Soundtrack").GetComponent<AudioSource>(); // Obtener el AudioSource en el mismo GameObject

      // Verifica si el AudioSource está presente
      if (audioSource == null)
      {
        Debug.LogError("No se encontró un componente AudioSource en el objeto Soundtrack.");
      }
      else
      {
        Debug.Log("AudioSource encontrado y listo.");
        audioSource.Play(); // Comienza a reproducir la música
      }
    }
    else
    {
      Destroy(gameObject); // Destruye el objeto duplicado
    }
  }

  void Start()
  {
    SceneManager.activeSceneChanged += OnSceneChanged;
  }

  // Detecta cambios de escena
  private void OnSceneChanged(Scene previousScene, Scene newScene)
  {
    // Reproducir música solo en la escena 1 y 2
    if (newScene.name == "UI" || newScene.name == "UI 1")
    {
      if (audioSource != null)
      {
        if (!audioSource.isPlaying)
        {
          audioSource.UnPause(); // Reanudar la música si está pausada
          Debug.Log("Música reanudada en la escena: " + newScene.name);
        }
      }
    }
    // Pausar música en la escena 3
    else if (newScene.name == "UI 2")
    {
      if (audioSource != null)
      {
        if (audioSource.isPlaying)
        {
          audioSource.Pause(); // Pausar la música
          Debug.Log("Música pausada en la escena: " + newScene.name);
        }
      }
    }
  }

  void OnDestroy()
  {
    // Eliminar el evento cuando se destruya el objeto
    SceneManager.activeSceneChanged -= OnSceneChanged;
  }
}
