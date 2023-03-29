using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchAudio : MonoBehaviour
{
    public GameObject audio1;
    public GameObject audio2;

    private Camera mainCamera;
    private Camera camera2;

    private void Start() {
        // Obtener referencias a las cámaras
        mainCamera = Camera.main;
        camera2 = GetComponent<Camera>();
    }

    private void Update() {
        // Verificar si la cámara 2 está activa
        if (mainCamera.isActiveAndEnabled) {
        audio2.gameObject.SetActive(false); 
        audio1.gameObject.SetActive(true);
        }
    }
}
