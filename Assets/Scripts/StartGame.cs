using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public Camera mainCamera; // La cámara principal que se activará
    public Camera camera2; // La cámara secundaria que se desactivará

    // Este método se ejecutará cuando se presione un botón o se realice alguna otra acción para cambiar las cámaras
    public void SwitchCameras()
    {
        mainCamera.gameObject.SetActive(true); // Activa la cámara principal
        camera2.gameObject.SetActive(false); // Desactiva la cámara secundaria
    }
}