using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    private static BackgroundMusic instance = null;

    void Awake()
    {
        // Verificar si ya existe una instancia de BackgroundMusic
        if (instance == null)
        {
            // Si no hay instancia, asigna esta como la instancia
            instance = this;
            DontDestroyOnLoad(gameObject); // Evita que este objeto se destruya al cambiar de escena
        }
        else
        {
            // Si ya existe una instancia, destruye esta nueva para evitar duplicados
            Destroy(gameObject);
        }
    }
}
