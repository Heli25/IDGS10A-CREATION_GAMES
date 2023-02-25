using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abrirventana : MonoBehaviour
{
    public GameObject popupWindow;
    public void OnButtonClick()
    {
        // Habilita el objeto de la ventana emergente para que se muestre
        popupWindow.SetActive(true);
    }
}
