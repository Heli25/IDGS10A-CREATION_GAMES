using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DenjiFrame : MonoBehaviour
{
    private Frame frameInstance;
    private EternityFrame eternityframeInstance;
    private NayutaFrame nayutaframeInstance;
    private PowerFrame powerframeInstance;
    public GameObject popupWindow5;

    void Start()
    {
        frameInstance = FindObjectOfType<Frame>();
        eternityframeInstance = FindObjectOfType<EternityFrame>();
        nayutaframeInstance = FindObjectOfType<NayutaFrame>();
        powerframeInstance = FindObjectOfType<PowerFrame>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            frameInstance.OnButtonClick();
            eternityframeInstance.OnButtonClick2();
            nayutaframeInstance.OnButtonClick3();
            powerframeInstance.OnButtonClick4();
        }
    }


    public void OnButtonClick5()
    {
        // Habilita el objeto de la segunda ventana emergente para que se muestre
        popupWindow5.SetActive(true);
        // Deshabilita el objeto de la primera ventana emergente para que se oculte
        frameInstance.popupWindow.SetActive(false);
        eternityframeInstance.popupWindow2.SetActive(false);
        nayutaframeInstance.popupWindow3.SetActive(false);
        powerframeInstance.popupWindow4.SetActive(false);
    }
}
