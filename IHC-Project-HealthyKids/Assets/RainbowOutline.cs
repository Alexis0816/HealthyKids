using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Outline))]
public class RainbowOutline : MonoBehaviour
{
    [Header("Configuración del Outline")]
    public Outline buttonOutline;       // Referencia al componente Outline

    [Header("Configuración del Color")]
    [Range(0.0f, 1.0f)]
    public float hueStart = 0.0f;      // Matiz inicial (rojo)
    [Range(0.0f, 1.0f)]
    public float hueEnd = 0.8f;        // Matiz final (evitando el verde)
    public float hueSpeed = 0.25f;     // Velocidad de cambio de matiz

    [Header("Configuración de Saturación y Valor")]
    [Range(0.5f, 1.0f)]
    public float saturation = 1.0f;    // Saturación fija para colores vibrantes
    [Range(0.5f, 1.0f)]
    public float value = 1.0f;         // Valor fijo para colores brillantes

    private float hue;

    void Start()
    {
        // Obtiene automáticamente el componente Outline si no se ha asignado
        if (buttonOutline == null)
        {
            buttonOutline = GetComponent<Outline>();
        }

        // Inicializa el matiz al valor de inicio
        hue = hueStart;
    }

    void Update()
    {
        // Incrementa el matiz basado en el tiempo y la velocidad
        hue += Time.deltaTime * hueSpeed;

        // Verifica si el matiz ha excedido el valor final
        if (hue > hueEnd)
        {
            // Reinicia al valor de inicio
            hue = hueStart;
        }

        // Convierte el matiz a color RGB con la saturación y el valor definidos
        Color rainbowColor = Color.HSVToRGB(hue, saturation, value);

        // Aplica el nuevo color al borde (Outline)
        buttonOutline.effectColor = rainbowColor;
    }
}