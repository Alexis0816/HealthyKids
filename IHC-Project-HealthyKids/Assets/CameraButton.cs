using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CameraButton : MonoBehaviour
{
    public void Camera() {
        SceneManager.LoadScene("UI 2");
    }
}
