using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Zoom : MonoBehaviour
{
    public float zoomSpeed = 2.0f; // Velocidad de zoom
    public float maxScale = 1.2f;  // Escala máxima del zoom
    public float minScale = 0.8f;  // Escala mínima del zoom

    private RectTransform rectTransform;
    private bool scalingUp = true;

    void Start()
    {
        // Obtener el RectTransform del texto
        rectTransform = GetComponent<RectTransform>();
    }

    void Update()
    {
        // Determinar si se está acercando o alejando
        if (scalingUp)
        {
            rectTransform.localScale += Vector3.one * zoomSpeed * Time.deltaTime;
            if (rectTransform.localScale.x >= maxScale)
            {
                rectTransform.localScale = new Vector3(maxScale, maxScale, maxScale);
                scalingUp = false; // Cambiar dirección de zoom
            }
        }
        else
        {
            rectTransform.localScale -= Vector3.one * zoomSpeed * Time.deltaTime;
            if (rectTransform.localScale.x <= minScale)
            {
                rectTransform.localScale = new Vector3(minScale, minScale, minScale);
                scalingUp = true; // Cambiar dirección de zoom
            }
        }
    }
}
