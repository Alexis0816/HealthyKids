using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

[System.Serializable]
public class TargetVideoPair
{
    public GameObject Target; // El objeto Image Target
    public GameObject Video;  // El objeto Video asociado al Target
}

public class Multi2 : MonoBehaviour
{
    public List<TargetVideoPair> TargetVideoPairs = new List<TargetVideoPair>(); // Lista de pares de Target y Video
    private List<ObserverBehaviour> observerBehaviours = new List<ObserverBehaviour>();

    void Start()
    {
        foreach (var pair in TargetVideoPairs)
        {
            // Obtener el ObserverBehaviour de cada target
            ObserverBehaviour observer = pair.Target.GetComponent<ObserverBehaviour>();
            observerBehaviours.Add(observer);

            // Esconder el video al inicio
            pair.Video.SetActive(false);

            // Asignar el método de callback para el evento de tracking
            if (observer != null)
            {
                observer.OnTargetStatusChanged += (ObserverBehaviour behaviour, TargetStatus targetStatus) =>
                {
                    if (targetStatus.Status == Status.TRACKED)
                    {
                        ShowVideo(pair);
                    }
                    else
                    {
                        pair.Video.SetActive(false);
                    }
                };
            }
        }
    }

    // Método para mostrar un video y esconder los demás
    private void ShowVideo(TargetVideoPair currentPair)
    {
        foreach (var pair in TargetVideoPairs)
        {
            if (pair != currentPair)
            {
                pair.Video.SetActive(false);
            }
        }
        currentPair.Video.SetActive(true);
    }

    void OnDestroy()
    {
        // Desregistrar los métodos de callback para evitar memory leaks
        foreach (var observer in observerBehaviours)
        {
            if (observer != null)
            {
                observer.OnTargetStatusChanged -= (ObserverBehaviour behaviour, TargetStatus targetStatus) => { };
            }
        }
    }
}
