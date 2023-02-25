using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Closewindow : MonoBehaviour
{
     public GameObject popupWindow;
    public void OnButtonClick()
    {
        // Habilita el objeto de la ventana emergente para que se muestre
        popupWindow.SetActive(false);
    }
}